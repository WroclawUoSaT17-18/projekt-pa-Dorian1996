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
            Left,  //Lewy kierunek - Left = 0.
            Right, //Prawy kierunek - Right = 1.
            None   //Żaden (kierunek spoczynkowy) - None = 2.
        }

        private bool ballOnPaddle; //Zmienna typu logicznego, która posłuży do opisu współrzędnej czy piłka przylega do paletki.
        private int ball_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x piłki.
        private int ball_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y piłki.
        private int paddle_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x paletki.
        private int paddle_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y paletki.
        private Direction paddle_direction; //Zmienna opisująca kierunek paletki, nowy obiekt klasy enum Direction który może używać jej parametrów.
        private bool mouseLeftIsDown; //Zmienna typu logicznego, która sprawdza czy przycisk myszki jest wciśnięty.
        private bool mouseRightIsDown; //Zmienna typu logicznego, która sprawdza czy przycisk myszki jest wciśnięty.
        private bool ballDirectionX; //Zmienna typu logicznego, która służy do operowania x-owym kierunkiem wektora prędkości piłki. 
        private bool ballDirectionY; //Zmienna typu logicznego, która służy do operowania y-owym kierunkiem wektora prędkości piłki.
        private int livesCounter; //Zmienna typu całkowitego, która będzie służyła jako licznik żyć gracza.
        private int scoreCounter; //Zmienna typu całkowitego, która będzie służyła jako licznik punktów gracza.
        private int blockCounter; //Zmienna typu całkowitego, która będzie służyła jako licznik bloków na planszy.
        private int block1_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block1_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block2_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block2_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block3_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block3_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block4_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block4_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block5_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block5_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block6_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block6_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block7_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block7_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block8_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block8_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block9_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block9_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block10_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block10_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block11_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block11_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block12_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block12_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block13_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block13_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block14_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block14_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block15_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block15_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block16_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block16_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block17_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block17_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block18_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block18_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block19_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block19_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.
        private int block20_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x bloku.
        private int block20_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y bloku.

        public FormMain()
        {
            InitializeComponent(); //Metoda obsługująca kontrolki interfejsu użytkownika.

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Muzyka/background.wav"); //Wczytanie muzyki.
            player.Play(); //Odtworzenie muzyki
            block1.Location = new Point(block1_x, block1_y);
            block2.Location = new Point(block2_x, block2_y);
            block3.Location = new Point(block3_x, block3_y);
            block4.Location = new Point(block4_x, block4_y);
            block5.Location = new Point(block5_x, block5_y);
            block6.Location = new Point(block6_x, block6_y);
            block7.Location = new Point(block7_x, block7_y);
            block8.Location = new Point(block8_x, block8_y);
            block9.Location = new Point(block9_x, block9_y);
            block10.Location = new Point(block10_x, block10_y);
            block11.Location = new Point(block11_x, block11_y);
            block12.Location = new Point(block12_x, block12_y);
            block13.Location = new Point(block13_x, block13_y);
            block14.Location = new Point(block14_x, block14_y);
            block15.Location = new Point(block15_x, block15_y);
            block16.Location = new Point(block16_x, block16_y);
            block17.Location = new Point(block17_x, block17_y);
            block18.Location = new Point(block18_x, block18_y);
            block19.Location = new Point(block19_x, block19_y);
            block20.Location = new Point(block20_x, block20_y);
            ball_x = 378; //Nadanie wartości początkowej zmiennej ball_x, czyli nadanie współrzędnej x piłki.
            ball_y = 546; //Nadanie wartości początkowej zmiennej ball_y, czyli nadanie współrzędnej y piłki.
            paddle_x = 350; //Nadanie wartości początkowej zmiennej paddle_x, czyli nadanie współrzędnej x paletki.
            paddle_y = 550; //Nadanie wartości początkowej zmiennej paddle_y, czyli nadanie współrzędnej y paletki.
            paddle_direction = Direction.None; //Nadanie wartości początkowej zmiennej paddle_direction, czyli nadanie paletce kierunku spoczynkowego, żeby nie ruszała się na początku rozgrywki.
            ballOnPaddle = true; //Nadanie wartości początkowej zmiennej ballOnPaddle, czyli piłka znajduje się na paletce jeśli true, jeśli false to piłki nie ma na paletce.
            mouseLeftIsDown = false; //Nadanie wartości początkowej false, zmiennej mouseLeftIsDown, ponieważ lewy przycisk myszy nie jest wciśnięty na początku.
            mouseRightIsDown = false; //Nadanie wartości początkowej false, zmiennej mouseRightIsDown, ponieważ prawy przycisk myszy nie jest wciśnięty na początku.
            ballDirectionX = true; //Nadanie wartości początkowej zmiennej ballDirectionX.
            ballDirectionY = true; //Nadanie wartości początkowej zmiennej ballDirectionY.
            livesCounter = 3; //Nadanie wartośći początkowej zmiennej livesCounter, czyli nastawienie liczby żyć gracza na 3.
            livesCounterLabel.Text = Convert.ToString(livesCounter); //Konwersja jawna typu int do string, żeby dało się wykonywać operacje na liczbach, a potem wpisywać je w pole tekst kontrolki label.
            scoreCounter = 0; //Nadanie wartośći początkowej zmiennej scoreCounter, czyli nastawienie liczby punktów gracza na 0.
            scoreCounterLabel.Text = Convert.ToString(scoreCounter);
            blockCounter = 0;
            block1_x = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block1_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block2_x = 160; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block2_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block3_x = 220; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block3_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block4_x = 280; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block4_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block5_x = 340; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block5_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block6_x = 400; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block6_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block7_x = 460; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block7_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block8_x = 520; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block8_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block9_x = 580; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block9_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block10_x = 640; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block10_y = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block11_x = 100; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block11_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block12_x = 160; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block12_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block13_x = 220; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block13_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block14_x = 280; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block14_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block15_x = 340; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block15_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block16_x = 400; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block16_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block17_x = 460; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block17_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block18_x = 520; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block18_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block19_x = 580; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block19_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.
            block20_x = 640; //Nadanie wartości początkowej zmiennej block_x, czyli nadanie współrzędnej x blokowi.
            block20_y = 200; //Nadanie wartości początkowej zmiennej block_y, czyli nadanie współrzędnej y blokowi.

            /*PictureBox[,] pictureBoxes = new PictureBox[10, 3];

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    pictureBoxes[i, j] = new PictureBox();
                    pictureBoxes[i, j].Location = new Point(100 + i * 60,100 + j * 30);
                    pictureBoxes[i, j].Name = "block" + i;
                    pictureBoxes[i, j].Size = new Size(48, 16);
                    pictureBoxes[i, j].ImageLocation = @"../../Sprity/spr_block.png";

                    this.Controls.Add(pictureBoxes[i, j]);
                };
            }
            */
        }

        private void TimerRefresh_Tick(object sender, EventArgs e) //Obsługa zdarzeń licznika czasu. Licznik ten służy do odświeżania pozycji kontrolek na ekranie, a jego interwał to 1ms czyli co 0,001 sekundy wykonywany jest ten kod.
        {
            if (ballOnPaddle == true) //JEŚLI PIŁKA ZNAJDUJE SIĘ NA PALETCE
            {
                if (paddle_direction == Direction.None)
                {
                    paddle_x += 0; //Jeżeli paletka ma spoczynkowy kierunek, nie została przyciśnięta żadna strzałka na klawiaturze, to niech paletka stoi w miejscu.
                    ball_x += 0; //Jeśli piłka leży na paletce, to stoi w miejscu razem z nią.
                }

                else if (paddle_direction == Direction.Right && paddle_x < 720)
                {
                    paddle_x += 10; //Jeżeli paletka ma prawy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze i nie wychodzi z prawej strony poza obszar kliencki okna, to przesuń w prawo paletkę o 10 pixeli.
                    ball_x += 10; //Jeśli piłka leży na paletce to porusza się wraz z nią w prawo.
                }

                else if (paddle_direction == Direction.Left && paddle_x > 0)
                {
                    paddle_x -= 10; //Jeżeli paletka ma lewy kierunek, czyli została przyciśnięta lewa strzałka na klawiaturze i nie wychodzi z lewej strony poza obszar kliencki okna, to przesuń w lewo paletkę o 10 pixeli.
                    ball_x -= 10; //Jeśli piłka leży na paletce to porusza się wraz z nią w lewo.
                }
                paddle.Location = new Point(paddle_x, paddle_y); //Przesuwanie paletki za pomocą Location.
                ball.Location = new Point(ball_x, ball_y); //Przesuwanie piłki za pomocą Location.
                block1.Location = new Point(block1_x, block1_y);
                block2.Location = new Point(block2_x, block2_y);
                block3.Location = new Point(block3_x, block3_y);
                block4.Location = new Point(block4_x, block4_y);
                block5.Location = new Point(block5_x, block5_y);
                block6.Location = new Point(block6_x, block6_y);
                block7.Location = new Point(block7_x, block7_y);
                block8.Location = new Point(block8_x, block8_y);
                block9.Location = new Point(block9_x, block9_y);
                block10.Location = new Point(block10_x, block10_y);
                block11.Location = new Point(block11_x, block11_y);
                block12.Location = new Point(block12_x, block12_y);
                block13.Location = new Point(block13_x, block13_y);
                block14.Location = new Point(block14_x, block14_y);
                block15.Location = new Point(block15_x, block15_y);
                block16.Location = new Point(block16_x, block16_y);
                block17.Location = new Point(block17_x, block17_y);
                block18.Location = new Point(block18_x, block18_y);
                block19.Location = new Point(block19_x, block19_y);
                block20.Location = new Point(block20_x, block20_y);
            }

            else if (ballOnPaddle == false) //JEŚLI PIŁKA NIE ZNAJDUJE SIĘ NA PALETCE
            {
                //KOLIZJA PIŁKI Z OKNEM
                //LEWA KRAWĘDŹ OKNA
                if (ball_x <= 0) //Jeżeli piłka dotknie lewej krawędzi ekranu, to zmień zwrot wektora X prędkości piłki na przeciwny(odbicie w poziomie).
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

                //PRAWA KRAWĘDŹ OKNA
                else if (ball_x >= 780) //Jeżeli piłka dotknie prawej krawędzi ekranu, to zmień zwrot wektora X prędkości piłki na przeciwny(odbicie w poziomie).
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

                //GÓRNA KRAWĘDŹ OKNA
                else if (ball_y <= 0) //Jeżeli piłka dotknie górnej krawędzi ekranu, to zmień zwrot wektora Y prędkości piłki na przeciwny(odbicie w pionie).
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

                //DOLNA KRAWĘDŹ OKNA
                else if (ball_y >= 560) //Jeżeli piłka dotknie dolnej krawędzi ekranu, to gracz traci życie.
                {
                    livesCounter = livesCounter - 1; //Zmniejszenie liczby żyć o 1 - Skucha.
                    livesCounterLabel.Text = Convert.ToString(livesCounter); //Odświeżenie tekstu na kontrolce label z nową liczbą żyć.
                    paddle_x = 350; //Reset współrzędnej x paletki.
                    paddle_y = 550; //Reset współrzędnej y paletki.
                    ball_x = 374; //Reset współrzędnej x piłki.
                    ball_y = 540; //Reset współrzędnej y piłki.
                    ballOnPaddle = true; //Piłka znajduje się znowu na paletce po skuciu.
                }

                //KOLIZJA PIŁKI Z PALETKĄ
                if (ball_x + 4 >= paddle_x && ball_x <= paddle_x + 64 && ball_y + 4 >= paddle_y && paddle_y + 4 <= paddle_y + 16) //Jeśli środek piłki znajduje się w przedziale dwuwymiarowej przestrzeni, która opsuje prostokąt, czyli paletkę, to zmień zwrot Y piłki na przeciwny.
                {
                    ballDirectionY = true;
                }

                //KOLIZJA PIŁKI Z BLOKIEM 1
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block1_x && ball_x + 7 <= block1_x + 1 && ball_y >= block1_y && ball_y + 7 <= block1_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block1.Visible = false;
                    block1_x = 1000;
                    block1_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block1_x + 46 && ball_x + 1 <= block1_x + 47 && ball_y >= block1_y && ball_y + 7 <= block1_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block1.Visible = false;
                    block1_x = 1000;
                    block1_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block1_x && ball_x + 7 <= block1_x + 47 && ball_y + 6 >= block1_y && ball_y + 7 <= block1_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block1.Visible = false;
                    block1_x = 1000;
                    block1_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block1_x && ball_x + 7 <= block1_x + 47 && ball_y >= block1_y + 14 && ball_y + 1 <= block1_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block1.Visible = false;
                    block1_x = 1000;
                    block1_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 2
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block2_x && ball_x + 7 <= block2_x + 1 && ball_y >= block2_y && ball_y + 7 <= block2_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block2.Visible = false;
                    block2_x = 1000;
                    block2_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block2_x + 46 && ball_x + 1 <= block2_x + 47 && ball_y >= block2_y && ball_y + 7 <= block2_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block2.Visible = false;
                    block2_x = 1000;
                    block2_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block2_x && ball_x + 7 <= block2_x + 47 && ball_y + 6 >= block2_y && ball_y + 7 <= block2_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block2.Visible = false;
                    block2_x = 1000;
                    block2_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block2_x && ball_x + 7 <= block2_x + 47 && ball_y >= block2_y + 14 && ball_y + 1 <= block2_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block2.Visible = false;
                    block2_x = 1000;
                    block2_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 3
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block3_x && ball_x + 7 <= block3_x + 1 && ball_y >= block3_y && ball_y + 7 <= block3_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block3.Visible = false;
                    block3_x = 1000;
                    block3_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block3_x + 46 && ball_x + 1 <= block3_x + 47 && ball_y >= block3_y && ball_y + 7 <= block3_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block3.Visible = false;
                    block3_x = 1000;
                    block3_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block3_x && ball_x + 7 <= block3_x + 47 && ball_y + 6 >= block3_y && ball_y + 7 <= block3_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block3.Visible = false;
                    block3_x = 1000;
                    block3_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block3_x && ball_x + 7 <= block3_x + 47 && ball_y >= block3_y + 14 && ball_y + 1 <= block3_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block3.Visible = false;
                    block3_x = 1000;
                    block3_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 4
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block4_x && ball_x + 7 <= block4_x + 1 && ball_y >= block4_y && ball_y + 7 <= block4_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block4.Visible = false;
                    block4_x = 1000;
                    block4_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block4_x + 46 && ball_x + 1 <= block4_x + 47 && ball_y >= block4_y && ball_y + 7 <= block4_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block4.Visible = false;
                    block4_x = 1000;
                    block4_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block4_x && ball_x + 7 <= block4_x + 47 && ball_y + 6 >= block4_y && ball_y + 7 <= block4_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block4.Visible = false;
                    block4_x = 1000;
                    block4_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block4_x && ball_x + 7 <= block4_x + 47 && ball_y >= block4_y + 14 && ball_y + 1 <= block4_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block4.Visible = false;
                    block4_x = 1000;
                    block4_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 5
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block5_x && ball_x + 7 <= block5_x + 1 && ball_y >= block5_y && ball_y + 7 <= block5_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block5.Visible = false;
                    block5_x = 1000;
                    block5_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block5_x + 46 && ball_x + 1 <= block5_x + 47 && ball_y >= block5_y && ball_y + 7 <= block5_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block5.Visible = false;
                    block5_x = 1000;
                    block5_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block5_x && ball_x + 7 <= block5_x + 47 && ball_y + 6 >= block5_y && ball_y + 7 <= block5_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block5.Visible = false;
                    block5_x = 1000;
                    block5_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block5_x && ball_x + 7 <= block5_x + 47 && ball_y >= block5_y + 14 && ball_y + 1 <= block5_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block5.Visible = false;
                    block5_x = 1000;
                    block5_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 6
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block6_x && ball_x + 7 <= block6_x + 1 && ball_y >= block6_y && ball_y + 7 <= block6_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block6.Visible = false;
                    block6_x = 1000;
                    block6_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block6_x + 46 && ball_x + 1 <= block6_x + 47 && ball_y >= block6_y && ball_y + 7 <= block6_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block6.Visible = false;
                    block6_x = 1000;
                    block6_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block6_x && ball_x + 7 <= block6_x + 47 && ball_y + 6 >= block6_y && ball_y + 7 <= block6_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block6.Visible = false;
                    block6_x = 1000;
                    block6_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block6_x && ball_x + 7 <= block6_x + 47 && ball_y >= block6_y + 14 && ball_y + 1 <= block6_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block6.Visible = false;
                    block6_x = 1000;
                    block6_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 7
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block7_x && ball_x + 7 <= block7_x + 1 && ball_y >= block7_y && ball_y + 7 <= block7_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block7.Visible = false;
                    block7_x = 1000;
                    block7_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block7_x + 46 && ball_x + 1 <= block7_x + 47 && ball_y >= block7_y && ball_y + 7 <= block7_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block7.Visible = false;
                    block7_x = 1000;
                    block7_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block7_x && ball_x + 7 <= block7_x + 47 && ball_y + 6 >= block7_y && ball_y + 7 <= block7_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block7.Visible = false;
                    block7_x = 1000;
                    block7_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block7_x && ball_x + 7 <= block7_x + 47 && ball_y >= block7_y + 14 && ball_y + 1 <= block7_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block7.Visible = false;
                    block7_x = 1000;
                    block7_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 8
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block8_x && ball_x + 7 <= block8_x + 1 && ball_y >= block8_y && ball_y + 7 <= block8_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block8.Visible = false;
                    block8_x = 1000;
                    block8_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block8_x + 46 && ball_x + 1 <= block8_x + 47 && ball_y >= block8_y && ball_y + 7 <= block8_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block8.Visible = false;
                    block8_x = 1000;
                    block8_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block8_x && ball_x + 7 <= block8_x + 47 && ball_y + 6 >= block8_y && ball_y + 7 <= block8_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block8.Visible = false;
                    block8_x = 1000;
                    block8_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block8_x && ball_x + 7 <= block8_x + 47 && ball_y >= block8_y + 14 && ball_y + 1 <= block8_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block8.Visible = false;
                    block8_x = 1000;
                    block8_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 9
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block9_x && ball_x + 7 <= block9_x + 1 && ball_y >= block9_y && ball_y + 7 <= block9_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block9.Visible = false;
                    block9_x = 1000;
                    block9_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block9_x + 46 && ball_x + 1 <= block9_x + 47 && ball_y >= block9_y && ball_y + 7 <= block9_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block9.Visible = false;
                    block9_x = 1000;
                    block9_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block9_x && ball_x + 7 <= block9_x + 47 && ball_y + 6 >= block9_y && ball_y + 7 <= block9_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block9.Visible = false;
                    block9_x = 1000;
                    block9_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block9_x && ball_x + 7 <= block9_x + 47 && ball_y >= block9_y + 14 && ball_y + 1 <= block9_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block9.Visible = false;
                    block9_x = 1000;
                    block9_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 10
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block10_x && ball_x + 7 <= block10_x + 1 && ball_y >= block10_y && ball_y + 7 <= block10_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block10.Visible = false;
                    block10_x = 1000;
                    block10_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block10_x + 46 && ball_x + 1 <= block10_x + 47 && ball_y >= block10_y && ball_y + 7 <= block10_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block10.Visible = false;
                    block10_x = 1000;
                    block10_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block10_x && ball_x + 7 <= block10_x + 47 && ball_y + 6 >= block10_y && ball_y + 7 <= block10_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block10.Visible = false;
                    block10_x = 1000;
                    block10_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block10_x && ball_x + 7 <= block10_x + 47 && ball_y >= block10_y + 14 && ball_y + 1 <= block10_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block10.Visible = false;
                    block10_x = 1000;
                    block10_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 11
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block11_x && ball_x + 7 <= block11_x + 1 && ball_y >= block11_y && ball_y + 7 <= block11_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block11.Visible = false;
                    block11_x = 1000;
                    block11_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block11_x + 46 && ball_x + 1 <= block11_x + 47 && ball_y >= block11_y && ball_y + 7 <= block11_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block11.Visible = false;
                    block11_x = 1000;
                    block11_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block11_x && ball_x + 7 <= block11_x + 47 && ball_y + 6 >= block11_y && ball_y + 7 <= block11_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block11.Visible = false;
                    block11_x = 1000;
                    block11_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block11_x && ball_x + 7 <= block11_x + 47 && ball_y >= block11_y + 14 && ball_y + 1 <= block11_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block11.Visible = false;
                    block11_x = 1000;
                    block11_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 12
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block12_x && ball_x + 7 <= block12_x + 1 && ball_y >= block12_y && ball_y + 7 <= block12_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block12.Visible = false;
                    block12_x = 1000;
                    block12_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block12_x + 46 && ball_x + 1 <= block12_x + 47 && ball_y >= block12_y && ball_y + 7 <= block12_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block12.Visible = false;
                    block12_x = 1000;
                    block12_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block12_x && ball_x + 7 <= block12_x + 47 && ball_y + 6 >= block12_y && ball_y + 7 <= block12_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block12.Visible = false;
                    block12_x = 1000;
                    block12_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block12_x && ball_x + 7 <= block12_x + 47 && ball_y >= block12_y + 14 && ball_y + 1 <= block12_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block12.Visible = false;
                    block12_x = 1000;
                    block12_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 13
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block13_x && ball_x + 7 <= block13_x + 1 && ball_y >= block13_y && ball_y + 7 <= block13_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block13.Visible = false;
                    block13_x = 1000;
                    block13_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block13_x + 46 && ball_x + 1 <= block13_x + 47 && ball_y >= block13_y && ball_y + 7 <= block13_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block13.Visible = false;
                    block13_x = 1000;
                    block13_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block13_x && ball_x + 7 <= block13_x + 47 && ball_y + 6 >= block13_y && ball_y + 7 <= block13_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block13.Visible = false;
                    block13_x = 1000;
                    block13_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block13_x && ball_x + 7 <= block13_x + 47 && ball_y >= block13_y + 14 && ball_y + 1 <= block13_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block13.Visible = false;
                    block13_x = 1000;
                    block13_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 14
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block14_x && ball_x + 7 <= block14_x + 1 && ball_y >= block14_y && ball_y + 7 <= block14_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block14.Visible = false;
                    block14_x = 1000;
                    block14_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block14_x + 46 && ball_x + 1 <= block14_x + 47 && ball_y >= block14_y && ball_y + 7 <= block14_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block14.Visible = false;
                    block14_x = 1000;
                    block14_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block14_x && ball_x + 7 <= block14_x + 47 && ball_y + 6 >= block14_y && ball_y + 7 <= block14_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block14.Visible = false;
                    block14_x = 1000;
                    block14_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block14_x && ball_x + 7 <= block14_x + 47 && ball_y >= block14_y + 14 && ball_y + 1 <= block14_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block14.Visible = false;
                    block14_x = 1000;
                    block14_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 15
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block15_x && ball_x + 7 <= block15_x + 1 && ball_y >= block15_y && ball_y + 7 <= block15_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block15.Visible = false;
                    block15_x = 1000;
                    block15_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block15_x + 46 && ball_x + 1 <= block15_x + 47 && ball_y >= block15_y && ball_y + 7 <= block15_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block15.Visible = false;
                    block15_x = 1000;
                    block15_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block15_x && ball_x + 7 <= block15_x + 47 && ball_y + 6 >= block15_y && ball_y + 7 <= block15_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block15.Visible = false;
                    block15_x = 1000;
                    block15_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block15_x && ball_x + 7 <= block15_x + 47 && ball_y >= block15_y + 14 && ball_y + 1 <= block15_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block15.Visible = false;
                    block15_x = 1000;
                    block15_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 16
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block16_x && ball_x + 7 <= block16_x + 1 && ball_y >= block16_y && ball_y + 7 <= block16_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block16.Visible = false;
                    block16_x = 1000;
                    block16_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block16_x + 46 && ball_x + 1 <= block16_x + 47 && ball_y >= block16_y && ball_y + 7 <= block16_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block16.Visible = false;
                    block16_x = 1000;
                    block16_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block16_x && ball_x + 7 <= block16_x + 47 && ball_y + 6 >= block16_y && ball_y + 7 <= block16_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block16.Visible = false;
                    block16_x = 1000;
                    block16_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block16_x && ball_x + 7 <= block16_x + 47 && ball_y >= block16_y + 14 && ball_y + 1 <= block16_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block16.Visible = false;
                    block16_x = 1000;
                    block16_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 17
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block17_x && ball_x + 7 <= block17_x + 1 && ball_y >= block17_y && ball_y + 7 <= block17_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block17.Visible = false;
                    block17_x = 1000;
                    block17_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block17_x + 46 && ball_x + 1 <= block17_x + 47 && ball_y >= block17_y && ball_y + 7 <= block17_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block17.Visible = false;
                    block17_x = 1000;
                    block17_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block17_x && ball_x + 7 <= block17_x + 47 && ball_y + 6 >= block17_y && ball_y + 7 <= block17_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block17.Visible = false;
                    block17_x = 1000;
                    block17_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block17_x && ball_x + 7 <= block17_x + 47 && ball_y >= block17_y + 14 && ball_y + 1 <= block17_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block17.Visible = false;
                    block17_x = 1000;
                    block17_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 18
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block18_x && ball_x + 7 <= block18_x + 1 && ball_y >= block18_y && ball_y + 7 <= block18_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block18.Visible = false;
                    block18_x = 1000;
                    block18_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block18_x + 46 && ball_x + 1 <= block18_x + 47 && ball_y >= block18_y && ball_y + 7 <= block18_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block18.Visible = false;
                    block18_x = 1000;
                    block18_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block18_x && ball_x + 7 <= block18_x + 47 && ball_y + 6 >= block18_y && ball_y + 7 <= block18_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block18.Visible = false;
                    block18_x = 1000;
                    block18_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block18_x && ball_x + 7 <= block18_x + 47 && ball_y >= block18_y + 14 && ball_y + 1 <= block18_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block18.Visible = false;
                    block18_x = 1000;
                    block18_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 19
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block19_x && ball_x + 7 <= block19_x + 1 && ball_y >= block19_y && ball_y + 7 <= block19_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block19.Visible = false;
                    block19_x = 1000;
                    block19_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block19_x + 46 && ball_x + 1 <= block19_x + 47 && ball_y >= block19_y && ball_y + 7 <= block19_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block19.Visible = false;
                    block19_x = 1000;
                    block19_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block19_x && ball_x + 7 <= block19_x + 47 && ball_y + 6 >= block19_y && ball_y + 7 <= block19_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block19.Visible = false;
                    block19_x = 1000;
                    block19_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block19_x && ball_x + 7 <= block19_x + 47 && ball_y >= block19_y + 14 && ball_y + 1 <= block19_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block19.Visible = false;
                    block19_x = 1000;
                    block19_y = 1000;
                }
                //KOLIZJA PIŁKI Z BLOKIEM 20
                //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                if (ball_x + 6 >= block20_x && ball_x + 7 <= block20_x + 1 && ball_y >= block20_y && ball_y + 7 <= block20_y + 15)
                {
                    ballDirectionX = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block20.Visible = false;
                    block20_x = 1000;
                    block20_y = 1000;
                }

                //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block20_x + 46 && ball_x + 1 <= block20_x + 47 && ball_y >= block20_y && ball_y + 7 <= block20_y + 15)
                {
                    ballDirectionX = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block20.Visible = false;
                    block20_x = 1000;
                    block20_y = 1000;
                }

                //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block20_x && ball_x + 7 <= block20_x + 47 && ball_y + 6 >= block20_y && ball_y + 7 <= block20_y + 1)
                {
                    ballDirectionY = true;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block20.Visible = false;
                    block20_x = 1000;
                    block20_y = 1000;
                }

                //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                else if (ball_x >= block20_x && ball_x + 7 <= block20_x + 47 && ball_y >= block20_y + 14 && ball_y + 1 <= block20_y + 15)
                {
                    ballDirectionY = false;
                    scoreCounter = scoreCounter + 5;
                    blockCounter = blockCounter + 1;
                    block20.Visible = false;
                    block20_x = 1000;
                    block20_y = 1000;
                }
                scoreCounterLabel.Text = Convert.ToString(scoreCounter); //Odświeżanie wyniku.


                //UKIERUNKOWANIE PIŁKI
                if (ballDirectionX == true)
                {
                    if (ballDirectionY == true)
                    {
                        ball_x += 2; //RUCH PRAWO-GORA
                        ball_y -= 2;
                    }
                    else
                    {
                        ball_x += 2; //RUCH PRAWO-DOŁ
                        ball_y += 2;
                    }
                }

                else if (ballDirectionX == false)
                {
                    if (ballDirectionY == true)
                    {
                        ball_x -= 2; //RUCH LEWO-GORA
                        ball_y -= 2;
                    }
                    else
                    {
                        ball_x -= 2; //RUCH LEWO-DOŁ 
                        ball_y += 2;
                    }
                }

                //Przesuwanie piłki za pomocą Location - Odświeżanie lokalizacji piłki.
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
                //Przesuwanie paletki za pomocą Location - Odświeżanie lokalizacji paletki.
                paddle.Location = new Point(paddle_x, paddle_y);

                if (livesCounter == 0 || blockCounter == 20)
                {
                    Application.Exit();
                }
            }

            Invalidate(); //Odświeża obraz, czyli co każdy "tick"(0,001s) licznika zostanie odświeżony obraz, co umożliwia animacje.
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e) //Obsługa zdarzeń wciśniętych klawiszy na klawiaturze.
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle_direction = Direction.Left; //Jeżeli została wciśnięta lewa strzałka, to nadaj lewy kierunek paletce.
            }
            else if (e.KeyCode == Keys.Right)
            {
                paddle_direction = Direction.Right; //Jeżeli została wciśnięta prawa strzałka, to nadaj prawy kierunek paletce.
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e) //Obsługa zdarzeń zwolnionych klawiszy na klawiaturze.
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle_direction = Direction.None; //Jeżeli została zwolniona lewa strzałka, to nadaj kierunek spoczynkowy paletce.
            }
            else if (e.KeyCode == Keys.Right)
            {
                paddle_direction = Direction.None; //Jeżeli została zwolniona prawa strzałka, to nadaj kierunek spoczynkowy paletce.
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e) //Obsługa zdarzeń wciśnietych klawiszy na myszce.
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mouseLeftIsDown = true; //Lewy przycisk myszki został wciśnięty.
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                mouseRightIsDown = true; //Prawy przycisk myszki został wciśnięty.
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e) //Obsługa zdarzeń zwolnionych klawiszy na myszce.
        {
            if (mouseLeftIsDown == true && ballOnPaddle == true)
            {
                mouseLeftIsDown = false; //Lewy przycisk myszki został zwolniony
                ballOnPaddle = false; //Oderwij piłkę od paletki
                ballDirectionX = false; //Niech piłka porusza się w lewo
            }
            else if (mouseRightIsDown == true && ballOnPaddle == true)
            {
                mouseRightIsDown = false; //Prawy przycisk myszki został zwolniony
                ballOnPaddle = false; //Oderwij piłkę od paletki
                ballDirectionX = true; //Niech piłka porusza się w prawo
            }
        }
    }
}
