using DemoSale.Data;
using DemoSale.DataBaseCore;
using System.Windows;
using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        ApplicationContext db = new();

        public LoginPage()
        {
            InitializeComponent();

            //MessageBox.Show(db.Dealer.ToList().Count.ToString());

            InitApplication();
        }

        private void InitApplication()
        {

        }

        private void ButtonInClick(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            ((Window)FrameClass.mainFrame.Parent).Height = 800;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
            ((Window)FrameClass.mainFrame.Parent).Width = 1200;

            FrameClass.role = User.users[$"{tbLogin.Text}"];

            FrameClass.mainFrame.Navigate(new MainPage());
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            ((Window)FrameClass.mainFrame.Parent).Height = 800;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
            ((Window)FrameClass.mainFrame.Parent).Width = 1200;

            FrameClass.role = User.users[$"{tbLogin.Text}"];

            FrameClass.mainFrame.Navigate(new PktPage());

            #region backup

            //List<Dealer> backupDealers = new List<Dealer>() {
            //        new Dealer("Тверца"),
            //        new Dealer("МТЗ-Татарстан"),
            //        new Dealer("ЗКАвгуст"),
            //        new Dealer("ПМЗ"),
            //        new Dealer("МАМ"),
            //        new Dealer("ТООТехмаш"),
            //        new Dealer("Смолтра"),
            //        new Dealer("Белагро"),
            //        new Dealer("Агромашснаб"),
            //        new Dealer("Техномаркет"),
            //        new Dealer("ЮжныйВетер"),
            //        new Dealer("Ульяновское"),
            //        new Dealer("БольшаяЗемля"),
            //        new Dealer("ТРИО"),
            //        new Dealer("Агриматко"),
            //        new Dealer("КРМЗ"),
            //        new Dealer("М-Агро"),
            //        new Dealer("ТДМТЗ-СЗ")
            //};

            //foreach (var item in backupDealers)
            //{
            //    FrameClass.db.Dealer.Add(item);

            //}
            //FrameClass.db.SaveChanges();

            //List<PositionType> backupTypes = new List<PositionType>() {
            //            new PositionType("Погрузчики"),
            //            new PositionType("Тракторы"),
            //            new PositionType("Кондиционеры"),
            //            new PositionType("Оборудование коммунальное"),
            //            new PositionType("Прицепы"),
            //            new PositionType("Спецтехника"),
            //            new PositionType("Сеялки"),
            //            new PositionType("Культиваторы"),
            //            new PositionType("Сцепки"),
            //            new PositionType("Косилки"),
            //            new PositionType("Плуги"),
            //            new PositionType("Дискаторы"),
            //            new PositionType("Пресс-подборщики"),
            //            new PositionType("Овощнаятехника"),
            //            new PositionType("Навесное"),
            //            new PositionType("Кормораздатчики"),
            //            new PositionType("Глубокорыхлители"),
            //            new PositionType("Грабли"),
            //            new PositionType("Бороны"),
            //            new PositionType("Лущильники")

            //};

            //foreach (var item in backupTypes)
            //{
            //    FrameClass.db.PositionType.Add(item);
            //}
            //FrameClass.db.SaveChanges();

            #endregion

        }
    }
}
