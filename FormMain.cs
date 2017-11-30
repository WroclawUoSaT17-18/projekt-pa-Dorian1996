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
        private bool mouseLeftIsDown; //Zmienna typu logicznego która sprawdza czy przycisk myszki jest wciśnięty.
        private bool mouseRightIsDown; //Zmienna typu logicznego która sprawdza czy przycisk myszki jest wciśnięty.
        private bool ballDirectionX; //Zmienna typu logicznego, która służy do operowania x-owym kierunkiem wektora prędkości piłki 
        private bool ballDirectionY; //Zmienna typu logicznego, która służy do operowania y-owym kierunkiem wektora prędkości piłki 
        private int livesCounter;

        public FormMain()
        {
            InitializeComponent();//Metoda obsługująca kontrolki interfejsu użytkownika.

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Muzyka/background.wav"); //Wczytanie muzyki
            player.Play(); //Odtworzenie muzyki
            block_x = 378; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block_y = 300; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block.Location = new Point(block_x, block_y); //Nadanie wartości początkowej lokalizacji bloku.
            ball_x = 378; //Nadanie wartości początkowej zmiennej ball_x, czyli nadanie współrzędnej x piłki.
            ball_y = 546; //Nadanie wartości początkowej zmiennej ball_y, czyli nadanie współrzędnej y piłki.
            paddle_x = 350; //Nadanie wartości początkowej zmiennej paddle_x, czyli nadanie współrzędnej x paletki.
            paddle_y = 550; //Nadanie wartości początkowej zmiennej paddle_y, czyli nadanie współrzędnej y paletki.
            paddle_direction = Direction.None; //Nadanie wartości początkowej zmiennej paddle_direction, czyli nadanie paletce kierunku "spoczynkowego", żeby sie nie ruszała od początku.
            ballOnPaddle = true; //Nadanie wartości początkowej zmiennej ballOnPaddle, czyli piłka znajduje się na paletce.
            mouseLeftIsDown = false; //Nadanie wartości początkowej zmiennej mouseDown na false, ponieważ mysz nie jest wciśnięta na początku.
            mouseRightIsDown = false; //Nadanie wartości początkowej zmiennej mouseDown na false, ponieważ mysz nie jest wciśnięta na początku.
            ballDirectionX = true; //Nadanie wartości początkowej zmiennej ballDirectionX.
            ballDirectionY = true; //Nadanie wartości początkowej zmiennej ballDirectionY.
            livesCounter = 3;
            livesCounterLabel.Text = Convert.ToString(livesCounter);
    }

        private void TimerRefresh_Tick(object sender, EventArgs e) //Obsługa zdarzeń licznika czasu
        {
            if (ballOnPaddle == true) //Jeżeli piłka jest na paletce
            {
                if (paddle_direction == Direction.None)
                {
                    paddle_x += 0; //Jeżeli paletka ma spoczynkowy kierunek nie została przyciśnięta żadna strzałka na klawiaturze, to niech paletka stoi w miejscu.
                    ball_x += 0; //Jeśli piłka leży na paletce to stoi w miejscu razem z nią
                }

                else if (paddle_direction == Direction.Right && paddle_x < 720)
                {
                    paddle_x += 10; //Jeżeli paletka ma prawy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, i nie wychodzi z prawej strony poza obszar kliencki okna, to przesuń w prawo paletkę o 10 pixeli.
                    ball_x += 10; //Jeśli piłka leży na paletce to porusza się z nią w prawo
                }

                else if (paddle_direction == Direction.Left && paddle_x > 0)
                {
                    paddle_x -= 10; //Jeżeli paletka ma lewy kierunek, czyli została przyciśnięta lewa strzałka na klawiaturze,  i nie wychodzi z lewej strony poza obszar kliencki okna, to przesuń w lewo paletkę o 10 pixeli.
                    ball_x -= 10; //Jeśli piłka leży na paletce to porusza się z nią
                }
                paddle.Location = new Point(paddle_x, paddle_y); //Przesuwanie paletki za pomocą Location
                ball.Location = new Point(ball_x, ball_y); //Przesuwanie piłki za pomocą Location
                block.Location = new Point(block_x, block_y);
            }

            else if (ballOnPaddle == false) //Jeżeli piłki nie ma na paletce
            {
                //KOLIZJA PIŁKI Z OKNEM
                //LEWA KRAWĘDŹ
                if (ball_x <= 0) //Jeżeli piłka dotknie lewej krawędzi ekranu, to zmień zwrot wektora X prędkości piłki na przeciwny(odbicie w poziomie) 
                {
                    if (ballDirectionX == true)
                    {
                        ballDirectionX = false;
                    }
                    else
                    {
                        ballDirectionX = true;
                    }
                }
                
                //PRAWA KRAWĘDŹ
                else if (ball_x >= 780) //Jeżeli piłka dotknie prawej krawędzi ekranu, to zmień zwrot wektora X prędkości piłki na przeciwny(odbicie w poziomie)
                {
                    if (ballDirectionX == false)
                    {
                        ballDirectionX = true;
                    }
                    else
                    {
                        ballDirectionX = false;
                    }
                }
                
                //GORNA KRAWĘDŹ
                else if (ball_y <= 0) //Jeżeli piłka dotknie górnej krawędzi ekranu, to zmień zwrot wektora Y prędkości piłki na przeciwny(odbicie w pionie)
                {
                    if (ballDirectionY == true)
                    {
                        ballDirectionY = false;
                    }
                    else
                    {
                        ballDirectionY = true;
                    }
                }
                
                //DOLNA KRAWĘDŹ
                else if (ball_y >= 560)
                {
                    livesCounter = livesCounter - 1;
                    livesCounterLabel.Text = Convert.ToString(livesCounter);
                    paddle_x = 350;
                    paddle_y = 550;
                    ball_x = 374;
                    ball_y = 540;
                    ballOnPaddle = true;
                }

                //KOLIZJA PIŁKI Z PALETKĄ
                if(ballOnPaddle == false)
                {
                    if (ball_x + 4 >= paddle_x && ball_x <= paddle_x+64 && ball_y + 4 >= paddle_y && paddle_y + 4 <= paddle_y + 16)
                    {
                        ballDirectionY = true;
                    }
                }

                //KOLIZJA PIŁKI Z BLOKIEM
                //LEWA KRAWĘDŹ
                if (ball_x+4 == block_x && ball_y+4 >= block_y && ball_y+4 <= block_y+16) 
                {
                    ballDirectionX = false;
                }

                //PRAWA KRAWĘDŹ
                else if (ball_x+4 == block_x+48 && ball_y+4 >= block_y && ball_y+4 <= block_y + 16) 
                {
                    ballDirectionX = true;
                }

                //GORNA KRAWĘDŹ
                else if (ball_y+4 == block_y && ball_x+4 >= block_x && ball_x+4 <= block_x+48) 
                {
                    ballDirectionY = true;
                }

                //DOLNA KRAWĘDŹ
                else if (ball_y+4 == block_y+16 && ball_x+4 >= block_x && ball_x+4 <= block_x+48) 
                {
                    ballDirectionY = false;
                }

                
                
                //UKIERUNKOWANIE PIŁKI
                if (ballDirectionX == true)
                {
                    if (ballDirectionY == true)
                    {
                        ball_x += 6; //RUCH PRAWO-GORA
                        ball_y -= 6;
                    }
                    else
                    {
                        ball_x += 6; //RUCH PRAWO-DOŁ
                        ball_y += 6;
                    }
                }

                else if (ballDirectionX == false)
                {
                    if (ballDirectionY == true)
                    {
                        ball_x -= 6; //RUCH LEWO-GORA
                        ball_y -= 6;
                    }
                    else
                    {
                        ball_x -= 6; //RUCH LEWO-DOŁ 
                        ball_y += 6;
                    }
                }

                //Przesuwanie piłki za pomocą Location
                ball.Location = new Point(ball_x, ball_y);

                //STEROWANIE PALETKĄ
                if (paddle_direction == Direction.None)
                {
                    paddle_x += 0; //Jeżeli paletka ma spoczynkowy kierunek nie została przyciśnięta żadna strzałka na klawiaturze, to niech paletka stoi w miejscu.
                }
                else if (paddle_direction == Direction.Right && paddle_x < 720)
                {
                    paddle_x += 10; //Jeżeli paletka ma prawy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, i nie wychodzi z prawej strony poza obszar kliencki okna, to przesuń w prawo paletkę o 10 pixeli.
                }
                else if (paddle_direction == Direction.Left && paddle_x > 0)
                {
                    paddle_x -= 10; //Jeżeli paletka ma lewy kierunek, czyli została przyciśnięta lewa strzałka na klawiaturze, i nie wychodzi z lewej strony poza obszar kliencki okna, to przesuń w lewo paletkę o 10 pixeli.
                }
                //Przesuwanie paletki za pomocą Location
                paddle.Location = new Point(paddle_x, paddle_y);

            }

            Invalidate(); //Odświeża obraz czyli co każdy "tick" licznika zostanie odświeżony obraz co umożliwia animacje.
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

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mouseLeftIsDown = true; //Lewy przycisk myszki został wciśnięty
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                mouseRightIsDown = true; //Lewy przycisk myszki został wciśnięty
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseLeftIsDown == true && ballOnPaddle == true)
            {
                mouseLeftIsDown = false; //Lewy przycisk myszki został zwolniony
                ballOnPaddle = false; //Oderwij piłkę od paletki
                ballDirectionX = false;
            }
            else if (mouseRightIsDown == true && ballOnPaddle == true)
            {
                mouseRightIsDown = false; //Lewy przycisk myszki został zwolniony
                ballOnPaddle = false; //Oderwij piłkę od paletki
                ballDirectionX = true;
            }
        }
    }
}
