using DemoSale.DataBaseCore;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Linq.Expressions;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для TatarstanReportPage.xaml
    /// </summary>
    public partial class TatarstanReportPage : Page
    {
        ApplicationContext db = new();

        public TatarstanReportPage()
        {
            InitializeComponent();

            InitItems();
        }

        private void InitItems()
        {
            PreInitItems();

            var a = MessageBox.Show("Возможно, были загружены не все записи. Загрузить?", 
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (a == MessageBoxResult.No)
            {
                return;
            }
            AddAllTatarstanFromPkt();
        }

        void PreInitItems()
        {
            //  from database
            var b = db.TatarstanReport.ToList();
            dgMain.ItemsSource = b;

        }

        private void AddAllTatarstanFromPkt()
        {
            //MessageBox.Show("all entities from Pkt was benn loaded!");
        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.GoBack();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }

        private void Button_Click_1_Add(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.Navigate(new TatarstanReportAddPage());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

        }

        private void Button_ClickRestore(object sender, RoutedEventArgs e)
        {
            //dgMain.ItemsSource = FrameClass.db.TatarstanReport.ToList();
        }

        private void Button_ClickRestore1(object sender, RoutedEventArgs e)
        {
            string repotrName = "Отчет-Татарстан-" + DateTime.Now;
            ExportToPdf(this.dgMain, repotrName.Replace('.', '-').Replace(' ', '-').Replace(':','-')+".pdf");
        }

        public void ExportToPdf(DataGrid dataGrid, string filePath)
        {
            try
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                PdfPTable pdfTable = new PdfPTable(dataGrid.Columns.Count);

                // Добавляем заголовки столбцов
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    pdfTable.AddCell(new Phrase(dataGrid.Columns[i].Header.ToString()));
                }

                // Добавляем данные из DataGrid
                for (int i = 0; i < dataGrid.Items.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        pdfTable.AddCell(dataGrid.Items[i].GetType().GetProperty(dataGrid.Columns[j].SortMemberPath).GetValue(dataGrid.Items[i]).ToString());
                    }
                }

                document.Add(pdfTable);
                document.Close();

                MessageBox.Show("Эспорт выполнен успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
