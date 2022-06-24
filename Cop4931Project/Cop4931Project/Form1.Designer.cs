namespace Cop4931Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.aesTextEncrpyt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptedTextAes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rsaEncrpytBox = new System.Windows.Forms.TextBox();
            this.rsaEncryptedText = new System.Windows.Forms.TextBox();
            this.rsaDecryptBox = new System.Windows.Forms.TextBox();
            this.rsaEncrptyBtn = new System.Windows.Forms.Button();
            this.digitalSignatureBtn = new System.Windows.Forms.Button();
            this.signatureTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hashValueToConvert = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hashValueOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type in text to Encrypt";
            // 
            // aesTextEncrpyt
            // 
            this.aesTextEncrpyt.Location = new System.Drawing.Point(151, 25);
            this.aesTextEncrpyt.Name = "aesTextEncrpyt";
            this.aesTextEncrpyt.Size = new System.Drawing.Size(125, 20);
            this.aesTextEncrpyt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encrpty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(326, 25);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(100, 20);
            this.encryptedText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Decrypted Text";
            // 
            // decryptedTextAes
            // 
            this.decryptedTextAes.Location = new System.Drawing.Point(455, 25);
            this.decryptedTextAes.Name = "decryptedTextAes";
            this.decryptedTextAes.Size = new System.Drawing.Size(100, 20);
            this.decryptedTextAes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "AES ENCRYPTION:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "RSA ENCRYPTION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type in text to Encrypt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Encrypted Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Decrypted Text";
            // 
            // rsaEncrpytBox
            // 
            this.rsaEncrpytBox.Location = new System.Drawing.Point(151, 117);
            this.rsaEncrpytBox.Name = "rsaEncrpytBox";
            this.rsaEncrpytBox.Size = new System.Drawing.Size(100, 20);
            this.rsaEncrpytBox.TabIndex = 14;
            // 
            // rsaEncryptedText
            // 
            this.rsaEncryptedText.Location = new System.Drawing.Point(326, 116);
            this.rsaEncryptedText.Name = "rsaEncryptedText";
            this.rsaEncryptedText.Size = new System.Drawing.Size(100, 20);
            this.rsaEncryptedText.TabIndex = 15;
            // 
            // rsaDecryptBox
            // 
            this.rsaDecryptBox.Location = new System.Drawing.Point(455, 116);
            this.rsaDecryptBox.Name = "rsaDecryptBox";
            this.rsaDecryptBox.Size = new System.Drawing.Size(100, 20);
            this.rsaDecryptBox.TabIndex = 16;
            // 
            // rsaEncrptyBtn
            // 
            this.rsaEncrptyBtn.Location = new System.Drawing.Point(151, 144);
            this.rsaEncrptyBtn.Name = "rsaEncrptyBtn";
            this.rsaEncrptyBtn.Size = new System.Drawing.Size(75, 23);
            this.rsaEncrptyBtn.TabIndex = 17;
            this.rsaEncrptyBtn.Text = "Encrypt";
            this.rsaEncrptyBtn.UseVisualStyleBackColor = true;
            this.rsaEncrptyBtn.Click += new System.EventHandler(this.rsaEncrptyBtn_Click);
            // 
            // digitalSignatureBtn
            // 
            this.digitalSignatureBtn.Location = new System.Drawing.Point(15, 217);
            this.digitalSignatureBtn.Name = "digitalSignatureBtn";
            this.digitalSignatureBtn.Size = new System.Drawing.Size(151, 24);
            this.digitalSignatureBtn.TabIndex = 18;
            this.digitalSignatureBtn.Text = "Generate Digital Signature";
            this.digitalSignatureBtn.UseVisualStyleBackColor = true;
            this.digitalSignatureBtn.Click += new System.EventHandler(this.digitalSignatureBtn_Click);
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.Location = new System.Drawing.Point(197, 221);
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(565, 20);
            this.signatureTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Input used to generate digital Signture:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(482, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = " 59, 4, 248, 102, 77, 97, 142, 201, 210, 12, 224, 93, 25, 41, 100, 197, 213, 134," +
    " 130, 135";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Compute Hash Value of PlainText:";
            // 
            // hashValueToConvert
            // 
            this.hashValueToConvert.Location = new System.Drawing.Point(247, 308);
            this.hashValueToConvert.Name = "hashValueToConvert";
            this.hashValueToConvert.Size = new System.Drawing.Size(168, 20);
            this.hashValueToConvert.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Compute Hash Value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Enter Text to Compute Hash Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Output of Hash Value";
            // 
            // hashValueOutput
            // 
            this.hashValueOutput.Location = new System.Drawing.Point(214, 367);
            this.hashValueOutput.Name = "hashValueOutput";
            this.hashValueOutput.Size = new System.Drawing.Size(318, 20);
            this.hashValueOutput.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hashValueOutput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hashValueToConvert);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.signatureTextBox);
            this.Controls.Add(this.digitalSignatureBtn);
            this.Controls.Add(this.rsaEncrptyBtn);
            this.Controls.Add(this.rsaDecryptBox);
            this.Controls.Add(this.rsaEncryptedText);
            this.Controls.Add(this.rsaEncrpytBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptedTextAes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aesTextEncrpyt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aesTextEncrpyt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox encryptedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptedTextAes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rsaEncrpytBox;
        private System.Windows.Forms.TextBox rsaEncryptedText;
        private System.Windows.Forms.TextBox rsaDecryptBox;
        private System.Windows.Forms.Button rsaEncrptyBtn;
        private System.Windows.Forms.Button digitalSignatureBtn;
        private System.Windows.Forms.TextBox signatureTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox hashValueToConvert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox hashValueOutput;
    }
}

