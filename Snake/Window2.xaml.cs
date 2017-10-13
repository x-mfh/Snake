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

namespace Snake
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ColorChoice_Loaded(object sender, RoutedEventArgs e)
        { 
            ColorChoice.ItemsSource = Enum.GetNames(typeof(PlayerSnake.Color));
            ColorChoice.SelectedIndex = 0;
        }
        
        private void ColorChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlayerSnake.Color playerColorChoice;
            Enum.TryParse(ColorChoice.SelectedValue.ToString(), out playerColorChoice);
        }

        private void DifficultyChoice_Loaded(object sender, RoutedEventArgs e)
        {
            
            DifficultyChoice.ItemsSource = Enum.GetNames(typeof(Game.Difficulty));
            DifficultyChoice.SelectedIndex = 0;
        }

        

        private void DifficultyChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game.Difficulty playerDifficultyChoice;
            Enum.TryParse(DifficultyChoice.SelectedValue.ToString(), out playerDifficultyChoice);
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            this.Hide();
            win3.Top = this.Top;
            win3.Left = this.Left;
            win3.Show();
        }
    }
}
