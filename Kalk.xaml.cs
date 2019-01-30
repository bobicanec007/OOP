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
using System.Windows.Shapes;

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for Kalk.xaml
    /// </summary>

    //enumeracija
    enum Operacije { Zbrajanje, Oduzimanje, Mnozenje, Dijeljenje, Nedefinirano};

    public partial class Kalk : Window
    {
        //aktualna operacija
        private Operacije operacija = Operacije.Nedefinirano;

        //memorirani broj
        private double pomocniBroj = 0;

        //broj koji se upisuje
        private double glavniBroj = 0;


        public Kalk()
        {
            InitializeComponent();
        }
        public void OsvjeziEkran()
        {

        }
        private void PritisnutBroj(object sender, RoutedEventArgs e)
        {
            glavniBroj *= 10;
            glavniBroj +=
            int.Parse(((Button)sender).Content.ToString());
            InicijalizacijaEkrana();
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            OdabirOperacije(Operacije.Zbrajanje);

        }
        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            OdabirOperacije(Operacije.Oduzimanje);
        }
        private void putaButton_Click(object sender, RoutedEventArgs e)
        {
            OdabirOperacije(Operacije.Mnozenje);
        }
        private void podijeljenoButton_Click(object sender, RoutedEventArgs e)
        {
            OdabirOperacije(Operacije.Dijeljenje);
        }

        private void InicijalizacijaEkrana()
        {
            ekranTextBox.Text = glavniBroj.ToString();
            pomocniTextBox.Text = pomocniBroj.ToString();
            // operacija na pomocnom ekranu
            switch(operacija)
            {
                case Operacije.Zbrajanje:
                    pomocniTextBox.Text += " +";
                    break;
                case Operacije.Oduzimanje:
                    pomocniTextBox.Text += " -";
                    break;
                case Operacije.Mnozenje:
                    pomocniTextBox.Text += " *";
                    break;
                case Operacije.Dijeljenje:
                    pomocniTextBox.Text += " /";
                    break;
                default:
                    pomocniTextBox.Text = ""; 
                    break;
            }

        }

        private void OdabirOperacije(Operacije _operacija)
        {
            //memoriramo operaciju
            operacija = _operacija;
            //preselimo glavni broj u pomocni
            pomocniBroj = glavniBroj;
            glavniBroj = 0;
            InicijalizacijaEkrana();
        }

        private void jednakoButton_Click(object sender, RoutedEventArgs e)
        {
            //prvo provjeravamo da li je zadana operacija
            if(operacija!= Operacije.Nedefinirano)
            {
                switch (operacija)
                {
                    case Operacije.Zbrajanje:
                        glavniBroj += pomocniBroj;
                        break;
                    case Operacije.Oduzimanje:
                        glavniBroj = pomocniBroj - glavniBroj;
                        break;
                    case Operacije.Mnozenje:
                        glavniBroj *= pomocniBroj;
                        break;
                    case Operacije.Dijeljenje:
                        glavniBroj = pomocniBroj / glavniBroj;
                        break;
                }
                pomocniBroj = 0;
                InicijalizacijaEkrana();
            }
        }
    }
}
