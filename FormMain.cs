using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_pa_Dorian1996
{
    public partial class FormMain : Form
    {

        enum Direction //Typ wyliczeniowy służący do nadania kierunku, który z kolei umożliwi ruch paletki w odpowiednim kierunku. Przyjmuje wartości: Left, Right i None.
        {
            Left, //Lewy Left = 0.
            Right, //Prawy Right = 1.
            None //Żaden, Spoczynkowy None = 2.
        }

        private bool ballOnPaddle; //Zmienna typu logicznego która posłuży do opisu współrzędnej czy piłka przylega do paletki.
        private int block_x; //Zmienna typu całkowitego która posłuży do opisu współrzędnej x bloku.
        private int block_y; //Zmienna typu całkowitego która posłuży do opisu współrzędnej y bloku.
        private int ball_x; //Zmienna typu całkowitego która posłuży do opisu współrzędnej x piłki.
        private int ball_y; //Zmienna typu całkowitego która posłuży do opisu współrzędnej y piłki.
        private int paddle_x; //Zmienna typu całkowitego która posłuży do opisu współrzędnej x paletki.
        private int paddle_y; //Zmienna typu całkowitego która posłuży do opisu współrzędnej y paletki.
        private Direction paddle_direction; //Zmienna opisująca kierunek paletki,nowy obiekt klasy enum Direction który może używać jej parametrów.

        public FormMain()
        {
            InitializeComponent();//Metoda obsługująca kontrolki interfejsu użytkownika.

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Muzyka/background.wav"); //Wczytanie muzyki
            player.Play(); //Odtworzenie muzyki
            ballOnPaddle = true; //Nadanie wartości początkowej zmiennej ballOnPaddle, czyli piłka znajduje się na paletce.
            block_x = 378; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block_y = 20; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            ball_x = 378; //Nadanie wartości początkowej zmiennej ball_x, czyli nadanie współrzędnej x piłki.
            ball_y = 550; //Nadanie wartości początkowej zmiennej ball_y, czyli nadanie współrzędnej y piłki.
            paddle_x = 350; //Nadanie wartości początkowej zmiennej paddle_x, czyli nadanie współrzędnej x paletki.
            paddle_y = 550; //Nadanie wartości początkowej zmiennej paddle_y, czyli nadanie współrzędnej y paletki.
            paddle_direction = Direction.None; //Nadanie wartości początkowej zmiennej paddle_direction, czyli nadanie jej kierunku "spoczynkowego", żeby sie nie ruszała od początku.
            block.Location = new Point(block_x, block_y); //Nadanie wartości początkowej lokalizacji bloku.
        }

        private void TimerRefresh_Tick(object sender, EventArgs e) //Obsługa zdarzeń licznika czasu
        {
            if (ballOnPaddle == true) //Jeżeli piłka jest na paletce
            {
                if (paddle_direction == Direction.None)
                {
                    paddle_x += 0; //Jeżeli paletka ma spoczynkowy kierunek nie została przyciśnięta żadna strzałka na klawiaturze, to niech paletka stoi w miejscu.
                    ball_x += 0; //Jeśli piłka leży na paletce to stoi w miejscu razem z nią
                    paddle.Location = new Point(paddle_x, paddle_y); //Przesuwanie PictureBoxa za pomocą Location
                    ball.Location = new Point(ball_x, ball_y); //Przesuwanie PictureBoxa za pomocą Location
                }

                else if (paddle_direction == Direction.Right)
                {
                    paddle_x += 10; //Jeżeli paletka ma prawy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, to przesuń w prawo paletkę o 6 pixeli.
                    ball_x += 10; //Jeśli piłka leży na paletce to porusza się z nią w prawo
                    paddle.Location = new Point(paddle_x, paddle_y); //Przesuwanie PictureBoxa za pomocą Location
                    ball.Location = new Point(ball_x, ball_y); //Przesuwanie PictureBoxa za pomocą Location
                }

                else if (paddle_direction == Direction.Left)
                {
                    paddle_x -= 10; //Jeżeli paletka ma lewy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, to przesuń w lewo paletkę o 6 pixeli.
                    ball_x -= 10; //Jeśli piłka leży na paletce to porusza się z nią
                    paddle.Location = new Point(paddle_x, paddle_y); //Przesuwanie PictureBoxa za pomocą Location
                    ball.Location = new Point(ball_x, ball_y); //Przesuwanie PictureBoxa za pomocą Location
                }
            }

            else if (ballOnPaddle == false) //Jeżeli piłki nie ma na paletce
            {
                if (ball_y != block_y)
                {
                    ball_y -= 10; //Piłka leci w góre jej y zmniejsza się o 10 co tick
                    ball.Location = new Point(ball_x, ball_y); //Przesuwanie PictureBoxa za pomocą Location
                }
                else
                {
                    if (ball_x - 40 <= block_x && ball_x + 20 >= block_x) //Kolizja piłki z blokiem
                    {
                        block.Dispose();
                       // block.Visible = false;
                        ball_y += 20; //Piłka leci w dół jej y zwiększa się o 10 co tick
                        ball.Location = new Point(ball_x, ball_y);
                    }
                }

                if (paddle_direction == Direction.None)
                {
                    paddle_x += 0; //Jeżeli paletka ma spoczynkowy kierunek nie została przyciśnięta żadna strzałka na klawiaturze, to niech paletka stoi w miejscu.
                    paddle.Location = new Point(paddle_x, paddle_y); //Przesuwanie PictureBoxa za pomocą Location
                }

                else if (paddle_direction == Direction.Right)
                {
                    paddle_x += 10; //Jeżeli paletka ma prawy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, to przesuń w prawo paletkę o 6 pixeli.
                    paddle.Location = new Point(paddle_x, paddle_y); //Przesuwanie PictureBoxa za pomocą Location
                }

                else if (paddle_direction == Direction.Left)
                {
                    paddle_x -= 10; //Jeżeli paletka ma lewy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, to przesuń w lewo paletkę o 6 pixeli.
                    paddle.Location = new Point(paddle_x, paddle_y); //Przesuwanie PictureBoxa za pomocą Location
                }
            }

            Invalidate(); //Odświeża obraz czyli co każdy "tick" licznika zostany odświeżony obraz co umożliwia animacje.
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e) //Obsługa zdarzeń wciśniętych klawiszy na klawiaturze.
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle_direction = Direction.Left; //Jeżeli została wciśnięta lewa strzałka to nadaj lewy kierunek paletce.
            }
            else if (e.KeyCode == Keys.Right)
            {
                paddle_direction = Direction.Right; //Jeżeli została wciśnięta prawa strzałka to nadaj prawy kierunek paletce.
            }
            else if (e.KeyCode == Keys.Space)
            {
                ballOnPaddle = false; //Jeżeli została wciśnięta spacja to piłka nie będzie już na paletce bo wystrzeli.
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e) //Obsługa zdarzeń zwolnionych klawiszy na klawiaturze.
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle_direction = Direction.None; //Jeżeli została zwolniona lewa strzałka to nadaj kierunek spoczynkowy paletce.
            }
            else if (e.KeyCode == Keys.Right)
            {
                paddle_direction = Direction.None; //Jeżeli została zwolniona prawa strzałka to nadaj kierunek spoczynkowy paletce.
            }
        }


    }
}
