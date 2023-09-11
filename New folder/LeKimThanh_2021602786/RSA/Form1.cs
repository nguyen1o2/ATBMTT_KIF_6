using System.Numerics;
using System.Text;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Console.Title = "RSA Console";
                Console.OutputEncoding = Encoding.UTF8;
            }
            catch (Exception) { }
        }

        RandomBigInteger rnd = new RandomBigInteger();
        bool encryptTypeCRT = false;
        bool useRTF = false;
        const int blockSize = 128;
        const int BYTE_SIZE = 256;
        // https://www.mobilefish.com/services/rsa_key_generation/rsa_key_generation.php

        // Hàm chuyển số thập phân sang số nhị phân
        string ToBinaryString(BigInteger myNum)
        {
            var bytes = myNum.ToByteArray();
            var idx = bytes.Length - 1;
            var base2 = new StringBuilder(bytes.Length * 8);
            var binary = Convert.ToString(bytes[idx], 2);
            if (binary[0] != '0' && myNum.Sign == 1)
            {
                base2.Append('0');
            }
            base2.Append(binary);
            for (idx--; idx >= 0; idx--)
            {
                base2.Append(Convert.ToString(bytes[idx], 2).PadLeft(8, '0'));
            }
            return base2.ToString();
        }

        string ReverseString(string myStr)
        {
            char[] myArr = myStr.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }

        // Hàm tính x^n mod m
        BigInteger modPow(BigInteger x, BigInteger n, BigInteger m)
        {
            string binaryStr = ToBinaryString(n);
            binaryStr = ReverseString(binaryStr);
            BigInteger p = 1;
            for (int i = binaryStr.Length - 1; i >= 0; i--)
            {
                p = BigInteger.Remainder((p * p), m);
                if (binaryStr[i] == '1') p = BigInteger.Remainder((p * x), m);
            }
            return p;
        }

        // Thuật toán Rabin Miller kiểm tra số nguyên tố
        bool rabinMiller(BigInteger num)
        {
            BigInteger s = num - 1;
            BigInteger t = 0;
            while (BigInteger.Remainder(s, 2) == 0)
            {
                s /= 2;
                t++;
            }
            foreach (var trials in Enumerable.Range(0, 5))
            {
                BigInteger a, v, i;
                a = rnd.NextBigInteger(2, Int32.MaxValue);
                v = BigInteger.ModPow(a, s, num);
                //v = modPow(a, s, num);
                if (v != 1)
                {
                    i = 0;
                    while (v != num - 1)
                    {
                        if (i == t - 1)
                        {
                            return false;
                        }
                        else
                        {
                            i++;
                            v = BigInteger.ModPow(v, 2, num);
                            //v = modPow(v, 2, num);
                        }
                    }
                }
            }
            return true;
        }

        bool isPrime(BigInteger num)
        {
            if (num < 2) return false;
            BigInteger[] lowPrimes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47,
                53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137,
                139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227,
                229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313,
                317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419,
                421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509,
                521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617,
                619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727,
                733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829,
                839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947,
                953, 967, 971, 977, 983, 991, 997 };
            if (lowPrimes.Contains(num)) return true;
            foreach (BigInteger prime in lowPrimes)
            {
                if (BigInteger.Remainder(num, prime) == 0) return false;
            }
            return rabinMiller(num);
        }

        BigInteger generateLargePrime(int keySize = 1024)
        {
            BigInteger num;
            while (true)
            {
                num = rnd.NextBigInteger(keySize);
                if (isPrime(num)) return num;
            }
        }

        // Thuật toán tìm ước chung lớn nhất
        BigInteger GCD(BigInteger a, BigInteger b)
        {
            BigInteger r;
            while (b > 0)
            {
                r = BigInteger.Remainder(a, b);
                a = b;
                b = r;
            }
            return a;
        }

        // Thuật toán tìm phần tử nghịch đảo
        BigInteger findModInverse(BigInteger a, BigInteger m)
        {
            BigInteger[] r = new BigInteger[10];
            BigInteger[] s = new BigInteger[10];
            BigInteger[] t = new BigInteger[10];
            BigInteger[] q = new BigInteger[10];
            BigInteger result;
            r[0] = a; r[1] = m;
            s[0] = 0; s[1] = 1;
            t[0] = 1; t[1] = 0;
            int i = 0, j;
            while (true)
            {
                if (i > 4)
                {
                    j = 2;
                    r[j + 2] = r[i + 2];
                    r[j + 1] = r[i + 1];
                    r[j] = r[i];
                    s[j] = s[i];
                    s[j - 1] = s[i - 1];
                    s[j - 2] = s[i - 2];
                    t[j] = t[i];
                    t[j - 1] = t[i - 1];
                    t[j - 2] = t[i - 2];
                    q[j] = q[i];
                    q[j - 1] = q[i - 1];
                    q[j - 2] = q[i - 2];
                    i = j;
                }
                q[i + 1] = r[i] / r[i + 1];
                r[i + 2] = BigInteger.Remainder(r[i], r[i + 1]);
                if (i >= 2)
                {
                    s[i] = s[i - 2] - q[i - 1] * s[i - 1];
                    t[i] = t[i - 2] - q[i - 1] * t[i - 1];
                }
                if (r[i + 2] == 0)
                {
                    s[i + 1] = s[i - 1] - q[i] * s[i];
                    t[i + 1] = t[i - 1] - q[i] * t[i];
                    break;
                }
                i++;
            }
            result = t[i + 1];
            while (result < 0)
            {
                result += m;
            }
            return result;
        }

        // Khởi tạo Public Key và Private Key
        Tuple<BigInteger, BigInteger, BigInteger, BigInteger, BigInteger> generateKey(int keySize)
        {
            BigInteger p, q, n, e, d, phi_n, e1 = 0;
            Console.WriteLine("Khởi tạo số nguyên tố p...");
            p = generateLargePrime(keySize);
            Console.WriteLine("Khởi tạo số nguyên tố q...");
            q = generateLargePrime(keySize);
            n = p * q;
            phi_n = (p - 1) * (q - 1);
            Console.WriteLine("Khởi tạo số nguyên tố e đồng dư với (p-1)*(q-1)...");
            while (true)
            {
                e = rnd.NextBigInteger(2, phi_n - 1);
                if (e1 == e) rnd = new RandomBigInteger();
                //if (GCD(e, phi_n) == 1) break;
                if (BigInteger.GreatestCommonDivisor(e, phi_n) == 1) break;
                e1 = e;
            }
            d = findModInverse(e, phi_n);
            return Tuple.Create(n, e, d, p, q);
        }

        BigInteger decryptModPow(BigInteger messageBlock, BigInteger dKey, BigInteger nKey)
        {
            return BigInteger.ModPow(messageBlock, dKey, nKey);
            //return modPow(messageBlock, dKey, nKey);
        }

        // Thuật toán Phần dư Trung Hoa
        BigInteger decryptCRT(BigInteger messageBlock, BigInteger p, BigInteger q, BigInteger dP, BigInteger dQ, BigInteger qInv)
        {
            BigInteger m_1, m_2, h;
            m_1 = BigInteger.ModPow(messageBlock, dP, p);
            m_2 = BigInteger.ModPow(messageBlock, dQ, q);
            //m_1 = modPow(messageBlock, dP, p);
            //m_2 = modPow(messageBlock, dQ, q);
            h = BigInteger.Remainder((qInv * (m_1 - m_2)), p);
            return m_2 + q * h;
        }

        // save Docx. 
        void saveDocx(RichTextBox rt, string fileName)
        {
            string tmp = Path.GetTempPath() + fileName + ".rtf";
            rt.SaveFile(tmp);
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var currentDoc = wordApp.Documents.Open(tmp);
            currentDoc.SaveAs(AppDomain.CurrentDomain.BaseDirectory + fileName, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocumentDefault);
            currentDoc.Close();
            wordApp.Quit();
        }
        //...

        void loadDocx(RichTextBox rt, string fileName)
        {
            object readOnly = true;
            object visible = false;
            object missing = Type.Missing;
            object fName = fileName;
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document currentDoc = wordApp.Documents.Open(
                                ref fName, ref missing, ref readOnly, ref missing,
                                ref missing, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing, ref visible,
                                ref missing, ref missing, ref missing, ref missing);
            currentDoc.ActiveWindow.Selection.WholeStory();
            currentDoc.ActiveWindow.Selection.Copy();
            IDataObject data = Clipboard.GetDataObject();
            rt.Rtf = data.GetData(DataFormats.Rtf).ToString();
            currentDoc.Close();
            wordApp.Quit();
        }

        private void btnTaoKhoa_Click(object sender, EventArgs e)
        {
            BigInteger nKey, eKey, dKey, p, q, dP, dQ, qInv;
            string publicKey, privateKey;
            int keySize = 1024;
            var keyData = generateKey(keySize);
            nKey = keyData.Item1;
            eKey = keyData.Item2;
            dKey = keyData.Item3;
            p = keyData.Item4;
            q = keyData.Item5;
            dP = BigInteger.Remainder(dKey, (p - 1));
            dQ = BigInteger.Remainder(dKey, (q - 1));
            qInv = findModInverse(q, p);
            Console.WriteLine("Public Key: " + nKey + "," + eKey);
            Console.WriteLine("Private Key: " + nKey + "," + dKey);
            publicKey = keySize + "," + nKey + "," + eKey;
            privateKey = keySize + "," + nKey + "," + dKey + "," + p + "," + q + "," + dP + "," + dQ + "," + qInv;
            richTextBox4.Text = publicKey;
            richTextBox5.Text = privateKey;
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == "" || richTextBox4.Text == "")
                {
                    MessageBox.Show("Hãy nhập Public Key và bản rõ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BigInteger nKey, eKey, blockInt;
                BigInteger[] blockInts, encryptedBlocks;
                byte[] messageBytes;
                int keySize, count;
                string cipherText = "";
                string publicKey = richTextBox4.Text;
                string[] keyData = publicKey.Split(",");
                keySize = Int32.Parse(keyData[0]);
                nKey = BigInteger.Parse(keyData[1]);
                eKey = BigInteger.Parse(keyData[2]);
                Console.WriteLine("Bắt đầu mã hóa...");
                Console.WriteLine("Modulus: " + nKey);
                Console.WriteLine("Exponent: " + eKey);
                if (keySize < blockSize * 8)
                    MessageBox.Show("Lỗi keySize không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (useRTF)
                {
                    messageBytes = Encoding.UTF8.GetBytes(richTextBox1.Rtf);
                }
                else
                {
                    messageBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
                }
                blockInts = new BigInteger[keySize];
                count = 0;
                for (int i = 0; i < messageBytes.Length; i += blockSize)
                {
                    blockInt = 0;
                    for (int j = i; j < BigInteger.Min(i + blockSize, messageBytes.Length); j++)
                    {
                        blockInt += messageBytes[j] * BigInteger.Pow(BYTE_SIZE, (int)(BigInteger.Remainder(j, blockSize)));
                    }
                    blockInts[count] = blockInt;
                    count++;
                }
                encryptedBlocks = new BigInteger[count];
                for (int i = 0; i < count; i++)
                {
                    encryptedBlocks[i] = BigInteger.ModPow(blockInts[i], eKey, nKey);
                    //encryptedBlocks[i] = modPow(blockInts[i], eKey, nKey);
                }
                richTextBox2.Text = "";
                if (count > 0) cipherText = messageBytes.Length + "_" + blockSize + "_";
                cipherText += String.Join(",", encryptedBlocks);
                richTextBox2.Text += cipherText;
                MessageBox.Show("Đã mã hóa!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox6.Text == "" || richTextBox5.Text == "")
                {
                    MessageBox.Show("Hãy nhập Private Key và bản mã!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BigInteger nKey, dKey, p, q, dP, dQ, qInv, asciiNumber;
                BigInteger[] encryptedBlocks, decryptedBlocks;
                string encrypted, privateKey, encryptedMessage;
                string[] keyData, encryptedData, encryptedMessageData;
                int messageLength, keySize, blockSize, blockCount;
                byte[] blockMessage;
                encrypted = richTextBox6.Text;
                privateKey = richTextBox5.Text;
                keyData = privateKey.Split(",");
                keySize = Int32.Parse(keyData[0]);
                nKey = BigInteger.Parse(keyData[1]);
                dKey = BigInteger.Parse(keyData[2]);
                if (keyData.Length == 8)
                {
                    p = BigInteger.Parse(keyData[3]);
                    q = BigInteger.Parse(keyData[4]);
                    dP = BigInteger.Parse(keyData[5]);
                    dQ = BigInteger.Parse(keyData[6]);
                    qInv = BigInteger.Parse(keyData[7]);
                }
                else
                {
                    p = q = dP = dQ = qInv = 0;
                    encryptTypeCRT = false;
                }
                encryptedData = encrypted.Split("_");
                messageLength = Int32.Parse(encryptedData[0]);
                blockSize = Int32.Parse(encryptedData[1]);
                Console.WriteLine("Bắt đầu giải mã...");
                Console.WriteLine("Key Size: " + keySize);
                Console.WriteLine("Modulus: " + nKey);
                Console.WriteLine("D: " + dKey);
                Console.WriteLine("P: " + p);
                Console.WriteLine("Q: " + q);
                Console.WriteLine("DP: " + dP);
                Console.WriteLine("DQ: " + dQ);
                Console.WriteLine("InverseQ: " + qInv);
                encryptedMessage = encryptedData[2];
                if (keySize < blockSize * 8)
                    MessageBox.Show("Lỗi keySize không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encryptedMessageData = encryptedMessage.Split(",");
                blockCount = encryptedMessageData.Length;
                encryptedBlocks = new BigInteger[blockCount];
                for (int i = 0; i < blockCount; i++)
                {
                    encryptedBlocks[i] = BigInteger.Parse(encryptedMessageData[i]);
                }
                decryptedBlocks = new BigInteger[blockCount];
                for (int i = 0; i < blockCount; i++)
                {
                    if (encryptTypeCRT)
                    {
                        decryptedBlocks[i] = decryptCRT(encryptedBlocks[i], p, q, dP, dQ, qInv);
                    }
                    else
                    {
                        decryptedBlocks[i] = decryptModPow(encryptedBlocks[i], dKey, nKey);
                    }
                }
                blockMessage = new byte[blockCount * blockSize];
                for (int i = 0; i < blockCount; i++)
                {
                    for (int j = blockSize - 1; j >= 0; j--)
                    {
                        asciiNumber = decryptedBlocks[i] / BigInteger.Pow(BYTE_SIZE, j);
                        decryptedBlocks[i] = BigInteger.Remainder(decryptedBlocks[i], BigInteger.Pow(BYTE_SIZE, j));
                        blockMessage[j + i * blockSize] = (byte)asciiNumber;
                    }
                }
                try
                {
                    richTextBox3.Rtf = Encoding.UTF8.GetString(blockMessage);
                }
                catch (Exception)
                {
                    richTextBox3.Text = Encoding.UTF8.GetString(blockMessage);
                }
                MessageBox.Show("Đã giải mã!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            if (richTextBox4.Text != "" && richTextBox5.Text != "")
            {
                saveDocx(richTextBox4, "PublicKey");
                saveDocx(richTextBox5, "PrivateKey");
                MessageBox.Show("Đã lưu PublicKey và PrivateKey!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chưa tạo PublicKey và PrivateKey!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNapKhoa_Click(object sender, EventArgs e)
        {
            if (File.Exists("PublicKey.docx") && File.Exists("PrivateKey.docx"))
            {
                loadDocx(richTextBox4, AppDomain.CurrentDomain.BaseDirectory + "PublicKey.docx");
                loadDocx(richTextBox5, AppDomain.CurrentDomain.BaseDirectory + "PrivateKey.docx");
                MessageBox.Show("Đã nạp PublicKey và PrivateKey!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy PublicKey và PrivateKey!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuKetQuaMaHoa_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text != "")
            {
                saveDocx(richTextBox2, "MaHoa");
                MessageBox.Show("Đã lưu kết quả mã hóa!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả mã hóa!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuKetQuaGiaiMa_Click(object sender, EventArgs e)
        {
            if (richTextBox3.Text != "")
            {
                saveDocx(richTextBox3, "GiaiMa");
                MessageBox.Show("Đã lưu kết quả giải mã!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả giải mã!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text != "")
            {
                richTextBox6.Text = richTextBox2.Text;
                //MessageBox.Show("Đã gửi!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả mã hóa!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnNhapDuLieu_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word Document|*.docx|Word 97 - 2003 Document|*.doc|Text Document|*.txt" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(ofd.FileName) == ".txt")
                    {
                        richTextBox1.Text = await File.ReadAllTextAsync(ofd.FileName);
                        useRTF = false;
                    }
                    else
                    {
                        loadDocx(richTextBox1, ofd.FileName);
                        useRTF = true;
                    }
                    MessageBox.Show("Đã nhập!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void btnNhapChuoiMaHoa_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word Document|*.docx|Word 97 - 2003 Document|*.doc|Text Document|*.txt" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(ofd.FileName) == ".txt")
                    {
                        richTextBox6.Text = await File.ReadAllTextAsync(ofd.FileName);
                    }
                    else
                    {
                        loadDocx(richTextBox6, ofd.FileName);
                    }
                    MessageBox.Show("Đã nhập!", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}