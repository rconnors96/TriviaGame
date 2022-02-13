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

namespace TriviaGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_button_clicked(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Exit Button Pressed");
            //Exits the application
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            } 
            else
            {
                System.Environment.Exit(0);
            }
            
        }

        private void maximize_button_clicked(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Maximize Button Pressed");
            //sets to fullscreen if not already in fullscreen
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }
            else 
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
        }

        private void minimize_button_clicked(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Minimize Button Pressed");
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void minimize_button_mouseEnter(object sender, MouseEventArgs e)
        {
            Image test = (Image)sender;

            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri("/Images/invert_minimize_button.png", UriKind.Relative);
            bmp.EndInit();

            test.Stretch = Stretch.Fill;
            test.Source = bmp;
        }

        private void minimize_button_mouseLeave(object sender, MouseEventArgs e)
        {
            Image test = (Image)sender;

            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri("/Images/minimize_button.png", UriKind.Relative);
            bmp.EndInit();

            test.Stretch = Stretch.Fill;
            test.Source = bmp;
        }

        private void maximize_button_mouseEnter(object sender, MouseEventArgs e)
        {
            Image test = (Image)sender;

            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri("/Images/invert_maximize_button.png", UriKind.Relative);
            bmp.EndInit();

            test.Stretch = Stretch.Fill;
            test.Source = bmp;
        }

        private void maximize_button_mouseLeave(object sender, MouseEventArgs e)
        {
            Image test = (Image)sender;

            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri("/Images/maximize_button.png", UriKind.Relative);
            bmp.EndInit();

            test.Stretch = Stretch.Fill;
            test.Source = bmp;
        }

        private void exit_button_mouseEnter(object sender, MouseEventArgs e)
        {
            Image test = (Image)sender;

            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri("/Images/invert_exit_button.png", UriKind.Relative);
            bmp.EndInit();

            test.Stretch = Stretch.Fill;
            test.Source = bmp;
        }

        private void exit_button_mouseLeave(object sender, MouseEventArgs e)
        {
            Image test = (Image)sender;

            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri("/Images/exit_button.png", UriKind.Relative);
            bmp.EndInit();

            test.Stretch = Stretch.Fill;
            test.Source = bmp;
        }

        private void play_button_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock playButton = (TextBlock)sender;
            playButton.FontWeight = FontWeights.Bold;
        }

        private void play_button_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock playButton = (TextBlock)sender;
            playButton.FontWeight = FontWeights.Regular;
        }

        private void play_button_clicked(object sender, MouseButtonEventArgs e)
        {
            Play playWindow = new Play();
            playWindow.Show();
        }
    }
}
