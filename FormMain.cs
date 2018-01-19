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

        PictureBox[,] pictureBoxes = new PictureBox[10, 3]; //Nowa instancja klasy pictureBoxes o typie dwuwymiarowej tablicy PictureBoxów?
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
        private bool fireballActive; //Zmienna typu logicznego, która sprawdza czy jest aktywny bonus ognistej piłki.
        private PictureBox fireball; //Nowa isntancja klasy PictureBox czyli nowy PictureBox o nazwie fireball
        private int fireball_x; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej x ikony bonusu ognistej piłki.
        private int fireball_y; //Zmienna typu całkowitego, która posłuży do opisu współrzędnej y ikony bonusu ognistej piłki.
        private bool fireballFall; //Zmienna typu logicznego, która służy do kontroli spadania bonusu ognistej piłki.

        public FormMain()
        {
            InitializeComponent(); //Metoda obsługująca kontrolki interfejsu użytkownika.

            System.Media.SoundPlayer bg = new System.Media.SoundPlayer(@"../../Muzyka/background.wav"); //Wczytanie muzyki.
            bg.Play(); //Odtworzenie muzyki
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
            scoreCounterLabel.Text = Convert.ToString(scoreCounter); //Konwersja jawna typu int do string, żeby dało się wykonywać operacje na liczbach, a potem wpisywać je w pole tekst kontrolki label.
            blockCounter = 0; //Nadanie wartośći początkowej zmiennej blockCounter, czyli nastawienie liczby zniszczonych bloków przez gracza na 0.
            fireballActive = false; //Nadanie wartości początkowej zmiennej fireballActive na false, ponieważ tryb ognistej piłki nie jest aktywny na początku gry.
            fireballFall = false; //Nadanie wartości początkowej zmiennej fireballFall na false, ponieważ ikonka ognistej piłki nie spada na początku gry(nawet jej nie ma).

            //TWORZENIE BLOKOW
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

                //DOLNA KRAWĘDŹ OKNA - DEATH
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

                //KOLIZJA PIŁKI Z BLOKAMI
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        //PRAWA KRAWĘDŹ PIŁKI Z LEWĄ KRAWĘDZIĄ BLOKU 
                        if (ball_x + 6 >= pictureBoxes[i, j].Location.X && ball_x + 7 <= pictureBoxes[i, j].Location.X + 1 && ball_y >= pictureBoxes[i, j].Location.Y && ball_y + 7 <= pictureBoxes[i, j].Location.Y + 15)
                        {
                            if (fireballActive == false) //Jeżeli tryb ognistej piłki nie jest aktywny
                            {
                                ballDirectionX = false; //Zmień kierunek X piłki na przeciwny
                            }
                            //System.Media.SoundPlayer destroy = new System.Media.SoundPlayer(@"../../Muzyka/destroy.wav");
                            //destroy.Play(); //Odtworzenie muzyki
                            rollBonus(i, j); //Uruchom metodę losującą bonus
                            scoreCounter = scoreCounter + 5; //Po zniszczeniu bloka zwiększ licznik punktów o 5.
                            blockCounter = blockCounter + 1; //Po zniszczeniu bloka zwiększ licznik zniszczonych bloków o 1.
                            pictureBoxes[i, j].Location = new Point(1000, 1000); //Po kolizji zniszcz blok(Przenieś go za obszar okna)
       
                        }

                        //LEWA KRAWĘDŹ PIŁKI Z PRAWĄ KRAWĘDZIĄ BLOKU
                        else if (ball_x >= pictureBoxes[i, j].Location.X + 46 && ball_x + 1 <= pictureBoxes[i, j].Location.X + 47 && ball_y >= pictureBoxes[i, j].Location.Y && ball_y + 7 <= pictureBoxes[i, j].Location.Y + 15)
                        {
                            if (fireballActive == false) //Jeżeli tryb ognistej piłki nie jest aktywny
                            {
                                ballDirectionX = true; //Zmień kierunek X piłki na przeciwny
                            }
                            //System.Media.SoundPlayer destroy = new System.Media.SoundPlayer(@"../../Muzyka/destroy.wav");
                            //destroy.Play(); //Odtworzenie muzyki
                            rollBonus(i, j); //Uruchom metodę losującą bonus
                            scoreCounter = scoreCounter + 5; //Po zniszczeniu bloka zwiększ licznik punktów o 5.
                            blockCounter = blockCounter + 1; //Po zniszczeniu bloka zwiększ licznik zniszczonych bloków o 1.
                            pictureBoxes[i, j].Location = new Point(1000, 1000); //Po kolizji zniszcz blok(Przenieś go za obszar okna)
                        }

                        //DOLNA KRAWĘDŹ PIŁKI Z GORNĄ KRAWĘDZIĄ BLOKU
                        else if (ball_x >= pictureBoxes[i, j].Location.X && ball_x + 7 <= pictureBoxes[i, j].Location.X + 47 && ball_y + 6 >= pictureBoxes[i, j].Location.Y && ball_y + 7 <= pictureBoxes[i, j].Location.Y + 1)
                        {
                            if (fireballActive == false) //Jeżeli tryb ognistej piłki nie jest aktywny
                            {
                                ballDirectionY = true; //Zmień kierunek Y piłki na przeciwny
                            }
                            //System.Media.SoundPlayer destroy = new System.Media.SoundPlayer(@"../../Muzyka/destroy.wav");
                            //destroy.Play(); //Odtworzenie muzyki
                            rollBonus(i, j); //Uruchom metodę losującą bonus
                            scoreCounter = scoreCounter + 5; //Po zniszczeniu bloka zwiększ licznik punktów o 5.
                            blockCounter = blockCounter + 1; //Po zniszczeniu bloka zwiększ licznik zniszczonych bloków o 1.
                            pictureBoxes[i, j].Location = new Point(1000, 1000); //Po kolizji zniszcz blok(Przenieś go za obszar okna)
                        }

                        //GORNA KRAWĘDŹ PIŁKI Z DOLNĄ KRAWĘDZIĄ BLOKU
                        else if (ball_x >= pictureBoxes[i, j].Location.X && ball_x + 7 <= pictureBoxes[i, j].Location.X + 47 && ball_y >= pictureBoxes[i, j].Location.Y + 14 && ball_y + 1 <= pictureBoxes[i, j].Location.Y + 15)
                        {
                            if (fireballActive == false) //Jeżeli tryb ognistej piłki nie jest aktywny
                            {
                                ballDirectionY = false; //Zmień kierunek Y piłki na przeciwny
                            }
                            //System.Media.SoundPlayer destroy = new System.Media.SoundPlayer(@"../../Muzyka/destroy.wav");
                            //destroy.Play(); //Odtworzenie muzyki
                            rollBonus(i, j); //Uruchom metodę losującą bonus
                            scoreCounter = scoreCounter + 5; //Po zniszczeniu bloka zwiększ licznik punktów o 5.
                            blockCounter = blockCounter + 1; //Po zniszczeniu bloka zwiększ licznik zniszczonych bloków o 1.
                            pictureBoxes[i, j].Location = new Point(1000, 1000); //Po kolizji zniszcz blok(Przenieś go za obszar okna)
                        }
                    };
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

                if (livesCounter == 0 || blockCounter == 30)
                {
                    Application.Exit(); //Jeżeli życia gracza spadną do zera lub wszystkie bloki zostaną zniszczone - zakończ grę.
                }
            }

            if (Controls.ContainsKey("fireball")) //Jeżeli ikona bonusu ognistej piłki istnieje to bonus zaczyna spadać. Jest to potrzebne do tego, że bez sprawdzania czy istnieje ikona bonusu ognistej piłki wyskakuje bład NullReferenceExeption, ponieważ kiedy ikona nie jest jeszcze stworzona nie możemy się do niej odnieść. 
            {
                fireballFall = true; //Jeżeli ikona bonusu ognistej piłki istnieje, to wartość zmiennej typu boolean zmieni się na true, co umożliwi spadek tej ikonki w dół.
            }

            if (fireballFall == true) //Jeżeli fireballFall = true
            {
                fireball_y += 2; //Ikona bonusu ognistej piłki będzie spadać w dół z prędkością dwa pixele na tick.
                fireball.Location = new Point(fireball_x, fireball_y); //Odświeżanie pozycji ikony bonusu ognistej piłki co umożliwia jego ruch w dół.

                if(fireball_x + 4 >= paddle_x && fireball_x <= paddle_x + 64 && fireball_y + 4 >= paddle_y && fireball_y + 4 <= paddle_y + 16) //Jeżeli ikona bonusu ognistej piłki trafi na paletkę
                {
                    ball.ImageLocation = @"../../Sprity/spr_fireball.png"; //Zmień sprite piłki na ognistą piłkę.
                    fireballActive = true; //Włącz tryb ognistej piłki.
                    Controls.Remove(fireball); //Usuń kontrolkę bonusu ognistej piłki.
                }
            }


            Invalidate(); //Odświeża obraz, czyli co każdy "tick"(0,001s) licznika zostanie odświeżony obraz, co umożliwia animacje.
        }

        private void rollBonus(int i,int j) //Metoda słuząca do tworzenia bonusów typu void(nic nie zwraca) pobiera zmienne całkowite i oraz j co umożliwia wygenerowanie bonusu na specyficznym bloku.
        {
            Random rnd = new Random(); //Nowa instancja klasy random pozwalająca zaimplementować losowanie liczb całkowitych.
            int roll = rnd.Next(1, 2); //Zmienna roll typu całkowitego, która przechowuje losowaną liczbę całkowitą z przedziału (min, max).
            if (roll == 1 && !Controls.ContainsKey("fireball")) //Jeżeli wylosowana liczba jest równa 1 oraz nie istnieje ikona bonusu ognistej piłki, to wytwórz ikonę bonusu ognistej piłki.
            {
                fireball_x = 100 + i * 60 + 16; //Zmienna fireball_x przechowuje współrzędna x ikony bonusu ognistej piłki, pozwala to odnieść się później do tej zmiennej i zmieniać ją.
                fireball_y = 100 + j * 30; //Zmienna fireball_y przechowuje współrzędna y ikony bonusu ognistej piłki, pozwala to odnieść się później do tej zmiennej i zmieniać ją.
                fireball = new PictureBox(); //Utworzenie ikony bonusu ognistej piłki.
                fireball.Location = new Point(fireball_x, fireball_y); //Nastawienie lokalizacji ikony bonusu ognistej piłki na x=fireball_x y=fireball_y, czyli na środek bloku z którego wygenerował się bonus po zniszczeniu.
                fireball.Name = "fireball"; //Nastawienie nazwy pictureBoxa bonusu ognistej piłki na "fireball".
                fireball.Size = new Size(16, 16); //Nastawienie wielkości pictureBoxa bonusu ognistej piłki na 16x16, ponieważ takiej wielkości jest sprite.
                fireball.ImageLocation = @"../../Sprity/spr_fireballbonus.png"; //Nastawienie sprite'a bonusu ognistej piłki.
                this.Controls.Add(fireball); //Dodanie kontrolki do obszaru klienckiego okna.
            }
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
