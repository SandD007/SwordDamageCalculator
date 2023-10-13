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

namespace SwordDamageCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        SwordDamageCalulator swordDamage;
        public MainWindow()
        {
            InitializeComponent();
            swordDamage = new SwordDamageCalulator(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
            DisplayDamage();
        }

        private void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            DisplayDamage();
        }

        private void DisplayDamage()
        {
            damage.Text = $"Roled {swordDamage.Roll} for {swordDamage.Damage} HP.";
        }

        private void Flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = true;
            DisplayDamage();
        }

        private void Flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = false;
            DisplayDamage();
        }

        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = false;
            DisplayDamage();
        }

        private void Magic_Cheked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = true;
            DisplayDamage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }
    }
}
