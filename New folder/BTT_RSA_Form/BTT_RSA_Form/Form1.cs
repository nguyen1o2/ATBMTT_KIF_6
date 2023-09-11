using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTT_RSA_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int kt = 0;

        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }

        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }

        }
        



        private void bt_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName.ToString());
                string line;
                string kq = "";
                while((line = sr.ReadLine()) != null)
                {
                    kq += line;
                }
                tx_banro1.Text = kq;
            }
        }

        private void bt_mahoa_Click(object sender, EventArgs e)
        {
            byte[] plaintext;
            byte[] encryptedtext;
            plaintext = ByteConverter.GetBytes(tx_banro1.Text);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            tx_banma1.Text = Convert.ToBase64String(encryptedtext);
            if(kt == 0)
            {
                File.WriteAllText("D:\\ATBMTT\\output.txt", tx_banma1.Text);
                kt++;
            }
            if(kt == 1)
            {
                File.WriteAllText("D:\\ATBMTT\\output1.txt", tx_banma1.Text);
            }
        }

        private void bt_giaima_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] test = Convert.FromBase64String(tx_banma2.Text);
                byte[] decryptedtex = Decryption(test, RSA.ExportParameters(true), false);
                tx_banro2.Text = ByteConverter.GetString(decryptedtex);
            }
            catch (Exception ex)
            {
                tx_banro2.Text = "Thất bại !";
            }


        }

        private void bt_path2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName.ToString());
                string line;
                string kq = "";
                while ((line = sr.ReadLine()) != null)
                {
                    kq += line;
                }
                tx_banma2.Text = kq;
            }
        }

        private void bt_getKey_Click(object sender, EventArgs e)
        {

        }
    }
}