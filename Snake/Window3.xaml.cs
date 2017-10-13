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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
          
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CreateBorder()
        {


            
            Rectangle Borders = new Rectangle();
            Borders.Width = 439;
            Borders.Height = 231;
            Borders.HorizontalAlignment = HorizontalAlignment.Center;
            Borders.VerticalAlignment = VerticalAlignment.Center;
            Borders.Stroke = Brushes.Black;
            Borders.StrokeThickness = 5;
            Canvas.SetTop(Borders, 40);
            Canvas.SetLeft(Borders, 35);

            Page.Children.Add(Borders);






        }

        private void DrawSnake()
        {
            
            Ellipse Snake = new Ellipse();
            Snake.Fill = SnakeColor(PlayerSnake.test);
            Snake.Height = 22;
            Snake.Width = 22;
            Snake.HorizontalAlignment = HorizontalAlignment.Center;
            Snake.VerticalAlignment = VerticalAlignment.Center;
            Snake.Stroke = Brushes.Black;

            Page.Children.Add(Snake);
            Snake.Name = "Snake";

        }


        private SolidColorBrush SnakeColor(PlayerSnake.Color test)
        {
            SolidColorBrush colorfill = new SolidColorBrush();

            switch (test)
            {
                case PlayerSnake.Color.Red:
                    colorfill.Color = Color.FromRgb(255, 0, 0);
                    break;
                case PlayerSnake.Color.Blue:
                    colorfill.Color = Color.FromRgb(0, 153, 255);
                    break;
                case PlayerSnake.Color.Green:
                    colorfill.Color = Color.FromRgb(0, 204, 0);
                    break;
                case PlayerSnake.Color.Yellow:
                    colorfill.Color = Color.FromRgb(255, 255, 0);
                    break;
                default:
                    break;
            }

            return colorfill;
        }


        private void test()
        {


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CreateBorder();
            DrawSnake();
        }
    }

}
