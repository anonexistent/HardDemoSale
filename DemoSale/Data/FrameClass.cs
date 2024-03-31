using DemoSale.DataBaseCore;
using System.Windows.Controls;

namespace DemoSale
{
    public static class FrameClass
    {
        public static Frame? mainFrame { get; set; }
        public static Frame? addFrame { get; set; }
        public static int role { get; set; } = -1;
        public static ApplicationContext db { get; set; } = new ApplicationContext();
    }
}