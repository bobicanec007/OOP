using MEVPaint.GrafickiOblici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MEVPaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point startPoint;
        private Point endPoint;

        //oblik koji se trenutno crta na ekranu
        //private GrafickiOblikcs sjena;
        private GrafickiOblikcs sjena;

        //vrsta oblika
        VrstaOblika vrsta = VrstaOblika.Linija;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            // zapisivanje koordinate
            endPoint = e.GetPosition(PlocaCanvas);

            // ispisivanje koordinate
            KoordinateTextBox.Text = endPoint.X.ToString() + " / " +
                endPoint.Y.ToString(); 

            // ako postoji sjena - osvjezi je
            if(sjena != null)
            {
                sjena.Postavi(PlocaCanvas, startPoint, endPoint, BojaTextBox.Background, double.Parse(LinijaTextBox.Text), Brushes.Black);
                sjena.Nacrtaj();

            }

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // početna točka kojeg crtamo
            startPoint = e.GetPosition(PlocaCanvas);

            if (sjena == null)
            {
                {
                    sjena = KreatorOblika.KreirajOblik(vrsta);
                }
                // na luuumenu primjer kolokvija....
            }
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //zaboravi na trenutni oblik
            sjena = null;

        }

        private void BojaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //podešavanje boje pozadine textboxa
            try
            {
                var brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(BojaTextBox.Text));
                BojaTextBox.Background = brush;
            }
            catch
            {

            }
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            // brišemo posljednji element s liste
            if (PlocaCanvas.Children.Count > 0)
                PlocaCanvas.Children.RemoveAt(
                    PlocaCanvas.Children.Count - 1);
        }

        private void PravokutnikButton_Click(object sender, RoutedEventArgs e)
        {
            vrsta = VrstaOblika.Pravokutnik;
        }

        private void ElipsaButton_Click(object sender, RoutedEventArgs e)
        {
            vrsta = VrstaOblika.Elipsa;
        }

        private void LinijaButton_Click(object sender, RoutedEventArgs e)
        {
            vrsta = VrstaOblika.Linija;
        }

        private void KrugButton_Click(object sender, RoutedEventArgs e)
        {
            vrsta = VrstaOblika.Krug;
        }
    }
}
