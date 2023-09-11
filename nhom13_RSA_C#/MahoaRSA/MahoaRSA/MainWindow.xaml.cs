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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace MahoaRSA
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

        private string privatePem, publicPem;
        private RSACryptoServiceProvider rsa;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rsa = new RSACryptoServiceProvider();
            rsa.ExportParameters(true);
        }

        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            rsa = RSAKeys.ImportPrivateKey(rsa, privatePem);
            var encryptedData = Convert.FromBase64String(richCipher.Text);
            var plainText = rsa.Decrypt(encryptedData, false);
            richOutDecrypted.Text = Encoding.UTF8.GetString(plainText);
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            rsa = RSAKeys.ImportPublicKey(rsa, publicPem);
            var inputData = Encoding.UTF8.GetBytes(richPlaintext.Text);
            var cipher = rsa.Encrypt(inputData, false);
            richCipher.Text = Convert.ToBase64String(cipher);
        }

        private void btnLoadPublic_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Public Key .PEM|.PEM";
            openFile.Title = "Vui lòng trọn Public key";
            FileStream fs = new FileStream("C:\\Users\\DELL\\Desktop\\public.pem", FileMode.Open);
            FileStream fs1 = new FileStream("C:\\Users\\DELL\\Desktop\\private.pem", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            publicPem = rd.ReadToEnd();// ReadLine() chỉ đọc 1 dòng đầu thoy, ReadToEnd là đọc hết
            rd.Close();
            StreamReader rd1 = new StreamReader(fs1, Encoding.UTF8);
            privatePem = rd1.ReadToEnd();
            rd1.Close();
            richTextPublic.Text = publicPem;
            richTextPrivate.Text = privatePem;
        }

        
    }
}
