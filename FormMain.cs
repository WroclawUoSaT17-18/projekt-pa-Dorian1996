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

        private int paddle_x; //Zmienna typu całkowitego która posłuży do opisu współrzędnej x paletki.
        private int paddle_y; //Zmienna typu całkowitego która posłuży do opisu współrzędnej y paletki.
        private Direction paddle_direction; //Zmienna opisująca kierunek paletki,nowy obiekt klasy enum Direction który może używać jej parametrów.

        public FormMain()
        {
            InitializeComponent();//Metoda obsługująca kontrolki interfejsu użytkownika.

            paddle_x = 380; //Nadanie wartości początkowej zmiennej paddle_x, czyli nadanie współrzędnej x paletki.
            paddle_y = 550; //Nadanie wartości początkowej zmiennej paddle_y, czyli nadanie współrzędnej y paletki.
            paddle_direction = Direction.None; //Nadanie wartości początkowej zmiennej paddle_direction, czyli nadanie jej kierunku "spoczynkowego", żeby sie nie ruszała od początku.
        }

        private void FormMain_Paint(object sender, PaintEventArgs e) //Zdarzenie, które opisuje rysowanie w oknie.
        {
            e.Graphics.FillRectangle(Brushes.White, paddle_x, paddle_y, 50, 10); //Narysowanie prostokąta, poprzez wypełnienie pewnej ograniczonej przestrzeni dwuwymiarowej, kolorem białym. Lewy górny róg ma współrzędne(x = paddle_x = 375, y = paddle_y = 500). Szerokość prostokąta to 50 pikseli, a jego wysokość to 10 pikseli.
        }

        private void TimerRefresh_Tick(object sender, EventArgs e) //Obsługa zdarzeń licznika czasu
        {
            if (paddle_direction == Direction.None)
            {
                paddle_x += 0; //Jeżeli paletka ma spoczynkowy kierunek nie została przyciśnięta żadna strzałka na klawiaturze, to niech paletka stoi w miejscu.
            }
            else if (paddle_direction == Direction.Right)
            {
                paddle_x += 6; //Jeżeli paletka ma prawy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, to przesuń w prawo paletkę o 6 pixeli.
            }
            else if (paddle_direction == Direction.Left)
            {
                paddle_x -= 6; //Jeżeli paletka ma lewy kierunek, czyli została przyciśnięta prawa strzałka na klawiaturze, to przesuń w lewo paletkę o 6 pixeli.
            }

            Invalidate(); //Odświeża obraz czyli co każdy "tick" licznika zostany odświeżony obraz co umożliwia animacje paletki.
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
    }
}
