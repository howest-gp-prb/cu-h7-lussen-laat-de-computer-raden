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

namespace Prb.Lussen.RaadPogingen.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random(); /* Deze variabele zal gebruikt kunnen worden om een willekeurig getal te genereren */
        const int MAX_GETAL = 10000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRaad_Click(object sender, RoutedEventArgs e)
        {
            int teRaden;
            int gok = -1;
            int pogingen = 0;

            teRaden = int.Parse(txtTeRaden.Text);

            while (gok != teRaden)
            {
                gok = random.Next(1, MAX_GETAL + 1);
                lstGokjes.Items.Insert(0, gok); /* Met Insert voeg je iets toe op een bepaalde plaats in een lijst */
                pogingen++;
            }
            lblFeedback.Content = $"Het getal {teRaden} is geraden in {pogingen} pogingen";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblMax.Content = MAX_GETAL;
        }
    }
}
