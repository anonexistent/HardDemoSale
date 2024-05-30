using MessagingToolkit.QRCode.Codec;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace DemoSale.QR
{
    /// <summary>
    /// Логика взаимодействия для QrCode.xaml
    /// </summary>
    public partial class QrCode : Window
    {
        public QrCode(string question, string defaultAnswer = "")
        {
            InitializeComponent();
            lblQuestion.Content = question;
            txtAnswer.Text = defaultAnswer;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {


            QrCodeDialog();

        }

        private void QrCodeDialog()
        {
            string temp = txtAnswer.Text;
            Bitmap q = new QRCodeEncoder().Encode(temp);

            BitmapSource i = Imaging.CreateBitmapSourceFromHBitmap(
               q.GetHbitmap(),
               IntPtr.Zero,
               Int32Rect.Empty,
               BitmapSizeOptions.FromEmptyOptions());

            imgQr.Source = i;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }
    }
}
