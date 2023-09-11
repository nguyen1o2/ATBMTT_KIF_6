namespace RSA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox4 = new RichTextBox();
            label4 = new Label();
            richTextBox5 = new RichTextBox();
            label5 = new Label();
            btnTaoKhoa = new Button();
            btnLuuKhoa = new Button();
            btnNapKhoa = new Button();
            btnNhapDuLieu = new Button();
            btnLuuKetQuaMaHoa = new Button();
            btnChuyen = new Button();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            btnMaHoa = new Button();
            label1 = new Label();
            richTextBox6 = new RichTextBox();
            label3 = new Label();
            richTextBox3 = new RichTextBox();
            btnGiaiMa = new Button();
            btnLuuKetQuaGiaiMa = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnNhapChuoiMaHoa = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(12, 568);
            richTextBox4.Margin = new Padding(2);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(550, 147);
            richTextBox4.TabIndex = 15;
            richTextBox4.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 540);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 4;
            label4.Text = "Public Key:";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(588, 568);
            richTextBox5.Margin = new Padding(2);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(550, 147);
            richTextBox5.TabIndex = 16;
            richTextBox5.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(588, 540);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 8;
            label5.Text = "Private Key:";
            // 
            // btnTaoKhoa
            // 
            btnTaoKhoa.Location = new Point(168, 12);
            btnTaoKhoa.Margin = new Padding(2);
            btnTaoKhoa.Name = "btnTaoKhoa";
            btnTaoKhoa.Size = new Size(103, 39);
            btnTaoKhoa.TabIndex = 2;
            btnTaoKhoa.Text = "Tạo khóa";
            btnTaoKhoa.UseVisualStyleBackColor = true;
            btnTaoKhoa.Click += btnTaoKhoa_Click;
            // 
            // btnLuuKhoa
            // 
            btnLuuKhoa.Location = new Point(275, 12);
            btnLuuKhoa.Margin = new Padding(2);
            btnLuuKhoa.Name = "btnLuuKhoa";
            btnLuuKhoa.Size = new Size(103, 39);
            btnLuuKhoa.TabIndex = 3;
            btnLuuKhoa.Text = "Lưu khóa";
            btnLuuKhoa.UseVisualStyleBackColor = true;
            btnLuuKhoa.Click += btnLuuKhoa_Click;
            // 
            // btnNapKhoa
            // 
            btnNapKhoa.Location = new Point(382, 12);
            btnNapKhoa.Margin = new Padding(2);
            btnNapKhoa.Name = "btnNapKhoa";
            btnNapKhoa.Size = new Size(103, 39);
            btnNapKhoa.TabIndex = 4;
            btnNapKhoa.Text = "Nạp khóa";
            btnNapKhoa.UseVisualStyleBackColor = true;
            btnNapKhoa.Click += btnNapKhoa_Click;
            // 
            // btnNhapDuLieu
            // 
            btnNhapDuLieu.Location = new Point(12, 12);
            btnNhapDuLieu.Name = "btnNhapDuLieu";
            btnNhapDuLieu.Size = new Size(151, 39);
            btnNhapDuLieu.TabIndex = 1;
            btnNhapDuLieu.Text = "Nhập dữ liệu đầu vào";
            btnNhapDuLieu.UseVisualStyleBackColor = true;
            btnNhapDuLieu.Click += btnNhapDuLieu_Click;
            // 
            // btnLuuKetQuaMaHoa
            // 
            btnLuuKetQuaMaHoa.Location = new Point(459, 289);
            btnLuuKetQuaMaHoa.Name = "btnLuuKetQuaMaHoa";
            btnLuuKetQuaMaHoa.Size = new Size(103, 35);
            btnLuuKetQuaMaHoa.TabIndex = 9;
            btnLuuKetQuaMaHoa.Text = "Lưu kết quả";
            btnLuuKetQuaMaHoa.UseVisualStyleBackColor = true;
            btnLuuKetQuaMaHoa.Click += btnLuuKetQuaMaHoa_Click;
            // 
            // btnChuyen
            // 
            btnChuyen.Location = new Point(350, 289);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(103, 35);
            btnChuyen.TabIndex = 8;
            btnChuyen.Text = "Gửi";
            btnChuyen.UseVisualStyleBackColor = true;
            btnChuyen.Click += btnChuyen_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 328);
            richTextBox2.Margin = new Padding(2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(550, 200);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 298);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 17);
            label2.TabIndex = 28;
            label2.Text = "Kết quả mã hóa RSA:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 84);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(550, 200);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "Thuật toán được Ron Rivest, Adi Shamir và Len Adleman mô tả lần đầu tiên vào năm 1977 tại Học viện Công nghệ Massachusetts (MIT). Tên của thuật toán lấy từ 3 chữ cái đầu của tên 3 tác giả.";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnMaHoa
            // 
            btnMaHoa.Location = new Point(242, 289);
            btnMaHoa.Margin = new Padding(2);
            btnMaHoa.Name = "btnMaHoa";
            btnMaHoa.Size = new Size(103, 35);
            btnMaHoa.TabIndex = 7;
            btnMaHoa.Text = "Mã hóa";
            btnMaHoa.UseVisualStyleBackColor = true;
            btnMaHoa.Click += btnMaHoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 25;
            label1.Text = "Dữ liệu đầu vào:";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(588, 84);
            richTextBox6.Margin = new Padding(2);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(550, 200);
            richTextBox6.TabIndex = 11;
            richTextBox6.Text = "";
            richTextBox6.TextChanged += richTextBox6_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(588, 298);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 32;
            label3.Text = "Kết quả giải mã RSA:";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(588, 328);
            richTextBox3.Margin = new Padding(2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(550, 200);
            richTextBox3.TabIndex = 14;
            richTextBox3.Text = "";
            // 
            // btnGiaiMa
            // 
            btnGiaiMa.Location = new Point(927, 289);
            btnGiaiMa.Margin = new Padding(2);
            btnGiaiMa.Name = "btnGiaiMa";
            btnGiaiMa.Size = new Size(103, 35);
            btnGiaiMa.TabIndex = 12;
            btnGiaiMa.Text = "Giải mã";
            btnGiaiMa.UseVisualStyleBackColor = true;
            btnGiaiMa.Click += btnGiaiMa_Click;
            // 
            // btnLuuKetQuaGiaiMa
            // 
            btnLuuKetQuaGiaiMa.Location = new Point(1035, 289);
            btnLuuKetQuaGiaiMa.Name = "btnLuuKetQuaGiaiMa";
            btnLuuKetQuaGiaiMa.Size = new Size(103, 35);
            btnLuuKetQuaGiaiMa.TabIndex = 13;
            btnLuuKetQuaGiaiMa.Text = "Lưu kết quả";
            btnLuuKetQuaGiaiMa.UseVisualStyleBackColor = true;
            btnLuuKetQuaGiaiMa.Click += btnLuuKetQuaGiaiMa_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(588, 58);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 17);
            label6.TabIndex = 36;
            label6.Text = "Chuỗi đã mã hóa RSA:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.RSA;
            pictureBox1.Location = new Point(1012, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // btnNhapChuoiMaHoa
            // 
            btnNhapChuoiMaHoa.Location = new Point(588, 12);
            btnNhapChuoiMaHoa.Name = "btnNhapChuoiMaHoa";
            btnNhapChuoiMaHoa.Size = new Size(147, 39);
            btnNhapChuoiMaHoa.TabIndex = 5;
            btnNhapChuoiMaHoa.Text = "Nhập chuỗi mã hóa";
            btnNhapChuoiMaHoa.UseVisualStyleBackColor = true;
            btnNhapChuoiMaHoa.Click += btnNhapChuoiMaHoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 726);
            Controls.Add(btnNhapChuoiMaHoa);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox6);
            Controls.Add(label3);
            Controls.Add(richTextBox3);
            Controls.Add(btnGiaiMa);
            Controls.Add(btnLuuKetQuaGiaiMa);
            Controls.Add(label6);
            Controls.Add(btnLuuKetQuaMaHoa);
            Controls.Add(btnChuyen);
            Controls.Add(richTextBox2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(btnMaHoa);
            Controls.Add(label1);
            Controls.Add(btnNhapDuLieu);
            Controls.Add(btnNapKhoa);
            Controls.Add(btnLuuKhoa);
            Controls.Add(btnTaoKhoa);
            Controls.Add(richTextBox5);
            Controls.Add(label5);
            Controls.Add(richTextBox4);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSA - Lê Kim Thành";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox4;
        private Label label4;
        private RichTextBox richTextBox5;
        private Label label5;
        private Button btnTaoKhoa;
        private Button btnLuuKhoa;
        private Button btnNapKhoa;
        private Button btnNhapDuLieu;
        private Button btnLuuKetQuaMaHoa;
        private Button btnChuyen;
        private RichTextBox richTextBox2;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button btnMaHoa;
        private Label label1;
        private RichTextBox richTextBox6;
        private Label label3;
        private RichTextBox richTextBox3;
        private Button btnGiaiMa;
        private Button btnLuuKetQuaGiaiMa;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnNhapChuoiMaHoa;
    }
}