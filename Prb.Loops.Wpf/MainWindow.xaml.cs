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

namespace Prb.Loops.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random(); /* Deze variabele zal gebruikt kunnen worden om een willekeurig getal te genereren */
        const int MAX_NUMBER = 10000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Guess_Click(object sender, RoutedEventArgs e)
        {
            int toGuess;
            int guess = -1;
            int nrOfTries = 0;

            toGuess = int.Parse(txtToGuess.Text);

            while (guess != toGuess)
            {
                guess = random.Next(1, MAX_NUMBER + 1);
                lstGuesses.Items.Insert(0, guess); /* Met Insert voeg je iets toe op een bepaalde plaats in een lijst */
                nrOfTries++;
            }
            lblFeedback.Content = $"Het getal {toGuess} is geraden in {nrOfTries} pogingen";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblMax.Content = MAX_NUMBER;
        }
    }
}
