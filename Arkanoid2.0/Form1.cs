﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid2
{
    public partial class Form1 : Form
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
        private bool mouseIsDown; //Zmienna typu logicznego która sprawdza czy przycisk myszki jest wciśnięty.
        private int mouse_x;
        private bool ballDirectionX;
        private bool ballDirectionY;

        public Form1()
        {
            InitializeComponent();//Metoda obsługująca kontrolki interfejsu użytkownika.

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Muzyka/background.wav"); //Wczytanie muzyki
            player.Play(); //Odtworzenie muzyki
            block_x = 378; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block_y = 20; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block.Location = new Point(block_x, block_y); //Nadanie wartości początkowej lokalizacji bloku.
            ball_x = 378; //Nadanie wartości początkowej zmiennej ball_x, czyli nadanie współrzędnej x piłki.
            ball_y = 546; //Nadanie wartości początkowej zmiennej ball_y, czyli nadanie współrzędnej y piłki.
            paddle_x = 350; //Nadanie wartości początkowej zmiennej paddle_x, czyli nadanie współrzędnej x paletki.
            paddle_y = 550; //Nadanie wartości początkowej zmiennej paddle_y, czyli nadanie współrzędnej y paletki.
            paddle_direction = Direction.None; //Nadanie wartości początkowej zmiennej paddle_direction, czyli nadanie paletce kierunku "spoczynkowego", żeby sie nie ruszała od początku.
            ballOnPaddle = true; //Nadanie wartości początkowej zmiennej ballOnPaddle, czyli piłka znajduje się na paletce.
            mouseIsDown = false; //Nadanie wartości początkowej zmiennej mouseDown na false, ponieważ mysz nie jest wciśnięta na początku.
            ballDirectionY = true;
            ballDirectionX = true;
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
                //KOLIZJA PIŁKI Z OKNEM
                //Bool
                if (ball_x <= 0 && ballDirectionX == true)
                {
                    ballDirectionX = false;
                }
                else if (ball_x <= 0 && ballDirectionX == false)
                {
                    ballDirectionX = true;
                }
                else if (ball_x >= 780 && ballDirectionX == false)
                {
                    ballDirectionX = true;
                }
                else if (ball_x >= 780 && ballDirectionX == true)
                {
                    ballDirectionX = false;
                }
                else if (ball_y <= 0 && ballDirectionY == true)
                {
                    ballDirectionY = false;
                }
                else if (ball_y <= 0 && ballDirectionY == false)
                {
                    ballDirectionY = true;
                }
                else if (ball_y >= 560 && ballDirectionY == false)
                {
                    ballDirectionY = true;
                }
                else if (ball_y >= 560 && ballDirectionY == true)
                {
                    ballDirectionY = false;
                }
                //Wykorzystanie booli do ukierunkowania piłki
                if (ballDirectionX == true && ballDirectionY == true)
                {
                    ball_x -= -mouse_x;
                    ball_y -= 10;
                }
                else if (ballDirectionX == true && ballDirectionY == false)
                {
                    ball_x -= -mouse_x;
                    ball_y -= -10;
                }
                else if (ballDirectionX == false && ballDirectionY == true)
                {
                    ball_x -= mouse_x;
                    ball_y -= 10;
                }
                else if (ballDirectionX == false && ballDirectionY == false)
                {
                    ball_x -= mouse_x;
                    ball_y -= -10;
                }
                //Przesuwanie piłki za pomocą Location
                ball.Location = new Point(ball_x, ball_y);

                //STEROWANIE PALETKĄ
                if (paddle_direction == Direction.None)
                {
                    paddle_x += 0; //Jeżeli paletka ma spoczynkowy kierunek nie została przyciśnięta żadna strzałka na klawiaturze, to niech paletka stoi w miejscu.
                }
                else if (paddle_direction == Direction.Right)
                {
                    paddle_x += 10; //Jeżeli paletka ma prawy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, to przesuń w prawo paletkę o 6 pixeli.
                }
                else if (paddle_direction == Direction.Left)
                {
                    paddle_x -= 10; //Jeżeli paletka ma lewy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, to przesuń w lewo paletkę o 6 pixeli.
                }
                //Przesuwanie paletki za pomocą Location
                paddle.Location = new Point(paddle_x, paddle_y);

            }

            Invalidate(); //Odświeża obraz czyli co każdy "tick" licznika zostany odświeżony obraz co umożliwia animacje.
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (mouseIsDown == true && ballOnPaddle == true)
            {
                mouse_x = (Cursor.Position.X - 390) / 10; //Zapisanie współrzędnej x kursora do zmiennej
                mouseIsDown = false; //Lewy przycisk myszki został zwolniony
                ballOnPaddle = false; //Oderwij piłkę od paletki
            }
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mouseIsDown = true; //Lewy przycisk myszki został wciśnięty
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
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

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
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
