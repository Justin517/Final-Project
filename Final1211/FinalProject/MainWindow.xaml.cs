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
using System.Threading;

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
            if (Area1.Visibility == Visibility.Visible && grublin.Health > 0)
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
            EncounterText.Text = "You Encountered a Monster!";
            PlayerHealthText.Visibility = Visibility.Visible;
            PlayerHealthText.Text = Convert.ToString(player.PlayerHealth);
         
            if (Area1.Visibility == Visibility.Visible)
            {
                Area1.Visibility = Visibility.Hidden;
                GrublinPic.Visibility = Visibility.Visible;
                MonsterHealth.Text = Convert.ToString(grublin.Health);
                MonsterHealth.Visibility = Visibility.Visible;

            }


        }
        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            EncounterText.Visibility = Visibility.Hidden;
            player.Attack(ref grublin);
            AttackButton.Visibility = Visibility.Hidden;
 
            if (GrublinPic.Visibility == Visibility.Visible)
            {
                MonsterHealth.Text = Convert.ToString(grublin.Health);
                if (grublin.Health > 0)
                {
                    Thread.Sleep(2000);
                    grublin.MonsterAttack(ref player);
                    PlayerHealthText.Text = Convert.ToString(player.PlayerHealth);
                    AttackButton.Visibility = Visibility.Visible;
                }
                else if (grublin.Health <= 0)
                {
                    GrublinPic.Visibility = Visibility.Hidden;

                    ShopButton.Visibility = Visibility.Visible;
                    ItemsButton.Visibility = Visibility.Visible;
                    AttackButton.Visibility = Visibility.Hidden;
                    DefendButton.Visibility = Visibility.Hidden;
                    NextAreaButton.Visibility = Visibility.Visible;
                    SearchButton.Visibility = Visibility.Hidden;
                    MonsterHealth.Visibility = Visibility.Hidden;
                    PlayerHealthText.Visibility = Visibility.Hidden;
                    ItemGrabbed.Text = "You got a standard Sword";
                    ItemGrabbed.Visibility = Visibility.Visible;
                    ContinueButton.Visibility = Visibility.Visible;

                }
            }
        }
        private void DefendButton_Click(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(2000);

            if (GrublinPic.Visibility == Visibility.Visible && grublin.Health > 0)
            {
                EncounterText.Visibility = Visibility.Hidden;
                grublin.MonsterAttackWDefend(ref player);
                PlayerHealthText.Text = Convert.ToString(player.PlayerHealth);
                PlayerHealthText.Text = Convert.ToString(player.PlayerHealth);                
            }

        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {  
             ItemGrabbed.Visibility = Visibility.Hidden;
             Area1.Visibility = Visibility.Visible;
            ContinueButton.Visibility = Visibility.Hidden;
        }
    }
}
