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

namespace Point_And_Rectangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double X1 { get { return double.Parse(x1.Text); } set { } }
        public double X2 { get { return double.Parse(x2.Text); } set { } }
        public double Y1 { get { return double.Parse(y1.Text); } set { } }
        public double Y2 { get { return double.Parse(y2.Text); } set { } }
        public double X { get { return double.Parse(x.Text); } set { } }
        public double Y { get { return double.Parse(y.Text); } set { } }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void DrawRectangle()
        {
            System.Windows.Shapes.Rectangle rect;
            rect = new System.Windows.Shapes.Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.Black);
            
            rect.Width = X2-X1;
            rect.Height = Y1-X1;
            Canvas.SetLeft(rect, 50);
            Canvas.SetTop(rect, 50);
            myCanvas.Children.Add(rect);

            Ellipse myEllipse = new Ellipse();
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 0);
            myEllipse.Fill = mySolidColorBrush;
            myEllipse.StrokeThickness = 2;
            myEllipse.Stroke = Brushes.White;
            myEllipse.Width = X;
            myEllipse.Height = Y;
            Canvas.SetTop(myEllipse, 50);
            Canvas.SetLeft(myEllipse, 80);
            myCanvas.Children.Add(myEllipse);

        }

        private void Draw_Button(object sender, RoutedEventArgs e)
        {
            DrawRectangle();

        }
    }
}
