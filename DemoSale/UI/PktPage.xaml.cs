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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для PktPage.xaml
    /// </summary>
    public partial class PktPage : Page
    {
        public PktPage()
        {
            InitializeComponent();
            AddCloudsToCanvas();
        }

        public void AddCloudsToCanvas()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Image cloudImage = new Image();
                cloudImage.Source = new BitmapImage(new Uri("C:\\Users\\wwwzl\\source\\repos\\DemoSale\\DemoSale\\Resources\\Clouds\\cl1.png"));
                Canvas.SetLeft(cloudImage, rand.Next(0, 400));
                Canvas.SetTop(cloudImage, rand.Next(0, 200));
                canvas.Children.Add(cloudImage);

                DoubleAnimation animation = new DoubleAnimation
                {
                    From = Canvas.GetLeft(cloudImage),
                    To = 400,
                    Duration = TimeSpan.FromSeconds(rand.Next(10, 20)),
                    RepeatBehavior = RepeatBehavior.Forever
                };

                cloudImage.BeginAnimation(Canvas.LeftProperty, animation);
            }
        }
    }
}
