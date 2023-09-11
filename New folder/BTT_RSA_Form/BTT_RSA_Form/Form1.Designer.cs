
namespace BTT_RSA_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_banro1 = new System.Windows.Forms.TextBox();
            this.tx_banma1 = new System.Windows.Forms.TextBox();
            this.bt_path = new System.Windows.Forms.Button();
            this.bt_mahoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_banma2 = new System.Windows.Forms.TextBox();
            this.tx_banro2 = new System.Windows.Forms.TextBox();
            this.bt_path2 = new System.Windows.Forms.Button();
            this.bt_giaima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_banro1
            // 
            this.tx_banro1.Location = new System.Drawing.Point(103, 54);
            this.tx_banro1.Multiline = true;
            this.tx_banro1.Name = "tx_banro1";
            this.tx_banro1.Size = new System.Drawing.Size(174, 92);
            this.tx_banro1.TabIndex = 0;
            // 
            // tx_banma1
            // 
            this.tx_banma1.Location = new System.Drawing.Point(103, 232);
            this.tx_banma1.Multiline = true;
            this.tx_banma1.Name = "tx_banma1";
            this.tx_banma1.Size = new System.Drawing.Size(174, 109);
            this.tx_banma1.TabIndex = 1;
            // 
            // bt_path
            // 
            this.bt_path.Location = new System.Drawing.Point(315, 57);
            this.bt_path.Name = "bt_path";
            this.bt_path.Size = new System.Drawing.Size(75, 23);
            this.bt_path.TabIndex = 2;
            this.bt_path.Text = "Lấy file";
            this.bt_path.UseVisualStyleBackColor = true;
            this.bt_path.Click += new System.EventHandler(this.bt_path_Click);
            // 
            // bt_mahoa
            // 
            this.bt_mahoa.Location = new System.Drawing.Point(152, 168);
            this.bt_mahoa.Name = "bt_mahoa";
            this.bt_mahoa.Size = new System.Drawing.Size(75, 23);
            this.bt_mahoa.TabIndex = 3;
            this.bt_mahoa.Text = "Mã hóa";
            this.bt_mahoa.UseVisualStyleBackColor = true;
            this.bt_mahoa.Click += new System.EventHandler(this.bt_mahoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bản rõ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bản mã:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bản mã:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bản rõ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "NGƯỜI GỬI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(784, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "NGƯỜI NHẬN";
            // 
            // tx_banma2
            // 
            this.tx_banma2.Location = new System.Drawing.Point(758, 54);
            this.tx_banma2.Multiline = true;
            this.tx_banma2.Name = "tx_banma2";
            this.tx_banma2.Size = new System.Drawing.Size(173, 92);
            this.tx_banma2.TabIndex = 7;
            // 
            // tx_banro2
            // 
            this.tx_banro2.Location = new System.Drawing.Point(758, 235);
            this.tx_banro2.Multiline = true;
            this.tx_banro2.Name = "tx_banro2";
            this.tx_banro2.Size = new System.Drawing.Size(173, 106);
            this.tx_banro2.TabIndex = 8;
            // 
            // bt_path2
            // 
            this.bt_path2.Location = new System.Drawing.Point(988, 72);
            this.bt_path2.Name = "bt_path2";
            this.bt_path2.Size = new System.Drawing.Size(75, 23);
            this.bt_path2.TabIndex = 9;
            this.bt_path2.Text = "Lấy file";
            this.bt_path2.UseVisualStyleBackColor = true;
            this.bt_path2.Click += new System.EventHandler(this.bt_path2_Click);
            // 
            // bt_giaima
            // 
            this.bt_giaima.Location = new System.Drawing.Point(805, 168);
            this.bt_giaima.Name = "bt_giaima";
            this.bt_giaima.Size = new System.Drawing.Size(75, 23);
            this.bt_giaima.TabIndex = 10;
            this.bt_giaima.Text = "Giải mã";
            this.bt_giaima.UseVisualStyleBackColor = true;
            this.bt_giaima.Click += new System.EventHandler(this.bt_giaima_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 416);
            this.Controls.Add(this.bt_giaima);
            this.Controls.Add(this.bt_path2);
            this.Controls.Add(this.tx_banro2);
            this.Controls.Add(this.tx_banma2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_mahoa);
            this.Controls.Add(this.bt_path);
            this.Controls.Add(this.tx_banma1);
            this.Controls.Add(this.tx_banro1);
            this.Name = "Form1";
            this.Text = "RSA Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_banro1;
        private System.Windows.Forms.TextBox tx_banma1;
        private System.Windows.Forms.Button bt_path;
        private System.Windows.Forms.Button bt_mahoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_banma2;
        private System.Windows.Forms.TextBox tx_banro2;
        private System.Windows.Forms.Button bt_path2;
        private System.Windows.Forms.Button bt_giaima;
    }
}

