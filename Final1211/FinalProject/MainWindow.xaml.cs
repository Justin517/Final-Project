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
using System.Timers;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Monster grublin;
        Player player;

        public MainWindow()
        {
            InitializeComponent();
            grublin = new Grublin(20, true, 5);
            player = new Player("Carl");
        }

       

        private void NextAreaButton_Click(object sender, RoutedEventArgs e)
        {
            AttackButton.Visibility = Visibility.Hidden;
            DefendButton.Visibility = Visibility.Hidden;
            if (grublin.Health > 0)
            {
                NextAreaButton.Visibility = Visibility.Hidden;
            }
            else
            {
                NextAreaButton.Visibility = Visibility.Visible;
            }

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            NextAreaButton.Visibility = Visibility.Hidden;
            SearchButton.Visibility = Visibility.Hidden;
            ShopButton.Visibility = Visibility.Hidden;
            ItemsButton.Visibility = Visibility.Hidden;
            AttackButton.Visibility = Visibility.Visible;
            DefendButton.Visibility = Visibility.Visible;
            EncounterText.Visibility = Visibility.Visible;
            EncounterText = "You encountered a monster!";
            if (Area1.Visibility == Visibility.Visible)
            {
                Area1.Visibility = Visibility.Hidden;
                GrublinPic.Visibility = Visibility.Visible;


            }


        }
        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            player.Attack(ref grublin);
            AttackButton.Visibility = Visibility.Hidden;
            if (grublin.Health > 0)
            {
                grublin.MonsterAttack(ref player);
            }
            else if (grublin.Health <= 0)
            {
                GrublinPic.Visibility = Visibility.Hidden;
                Area1.Visibility = Visibility.Visible;
                ShopButton.Visibility = Visibility.Visible;
                ItemsButton.Visibility = Visibility.Visible;
                AttackButton.Visibility = Visibility.Hidden;
                DefendButton.Visibility = Visibility.Hidden;
                NextAreaButton.Visibility = Visibility.Visible;
                SearchButton.Visibility = Visibility.Hidden;
            }
        }

        private void DefendButton_Click(object sender, RoutedEventArgs e)
        {
            grublin.Damage = 0;
        }
    }
}
