namespace RabinCryptosystem
{
    partial class RabinCryptosystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RabinCryptosystem));
            this.tbSecondSimple = new System.Windows.Forms.TextBox();
            this.tbMultTwoSimple = new System.Windows.Forms.TextBox();
            this.tbFirstSimple = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInputFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOutputFileName = new System.Windows.Forms.TextBox();
            this.btInputFile = new System.Windows.Forms.Button();
            this.btOutputFile = new System.Windows.Forms.Button();
            this.tbEncryptLessN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btEncrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btDecrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btClear = new System.Windows.Forms.ToolStripButton();
            this.ofdChooseAnyFile = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSecondSimple
            // 
            this.tbSecondSimple.Location = new System.Drawing.Point(52, 126);
            this.tbSecondSimple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSecondSimple.Name = "tbSecondSimple";
            this.tbSecondSimple.Size = new System.Drawing.Size(112, 26);
            this.tbSecondSimple.TabIndex = 0;
            // 
            // tbMultTwoSimple
            // 
            this.tbMultTwoSimple.BackColor = System.Drawing.Color.MintCream;
            this.tbMultTwoSimple.Location = new System.Drawing.Point(52, 183);
            this.tbMultTwoSimple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMultTwoSimple.Name = "tbMultTwoSimple";
            this.tbMultTwoSimple.ReadOnly = true;
            this.tbMultTwoSimple.Size = new System.Drawing.Size(112, 26);
            this.tbMultTwoSimple.TabIndex = 1;
            // 
            // tbFirstSimple
            // 
            this.tbFirstSimple.Location = new System.Drawing.Point(52, 67);
            this.tbFirstSimple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstSimple.Name = "tbFirstSimple";
            this.tbFirstSimple.Size = new System.Drawing.Size(112, 26);
            this.tbFirstSimple.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "p (простое,  >3,  p mod 4 = 3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "q (простое, >3511, q mod 4 = 3)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "b (b<n, 1<=b<=10532)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ввод:";
            // 
            // tbInputFileName
            // 
            this.tbInputFileName.BackColor = System.Drawing.Color.MintCream;
            this.tbInputFileName.Location = new System.Drawing.Point(30, 297);
            this.tbInputFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInputFileName.Multiline = true;
            this.tbInputFileName.Name = "tbInputFileName";
            this.tbInputFileName.ReadOnly = true;
            this.tbInputFileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInputFileName.Size = new System.Drawing.Size(156, 54);
            this.tbInputFileName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вывод:";
            // 
            // tbOutputFileName
            // 
            this.tbOutputFileName.BackColor = System.Drawing.Color.MintCream;
            this.tbOutputFileName.Location = new System.Drawing.Point(30, 417);
            this.tbOutputFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOutputFileName.Multiline = true;
            this.tbOutputFileName.Name = "tbOutputFileName";
            this.tbOutputFileName.ReadOnly = true;
            this.tbOutputFileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutputFileName.ShortcutsEnabled = false;
            this.tbOutputFileName.Size = new System.Drawing.Size(156, 54);
            this.tbOutputFileName.TabIndex = 9;
            // 
            // btInputFile
            // 
            this.btInputFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btInputFile.Location = new System.Drawing.Point(46, 358);
            this.btInputFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInputFile.Name = "btInputFile";
            this.btInputFile.Size = new System.Drawing.Size(123, 30);
            this.btInputFile.TabIndex = 10;
            this.btInputFile.Text = "Файл";
            this.btInputFile.UseVisualStyleBackColor = false;
            this.btInputFile.Click += new System.EventHandler(this.SaveFileToOpen_Click);
            // 
            // btOutputFile
            // 
            this.btOutputFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btOutputFile.Location = new System.Drawing.Point(46, 478);
            this.btOutputFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOutputFile.Name = "btOutputFile";
            this.btOutputFile.Size = new System.Drawing.Size(123, 30);
            this.btOutputFile.TabIndex = 11;
            this.btOutputFile.Text = "Файл";
            this.btOutputFile.UseVisualStyleBackColor = false;
            this.btOutputFile.Click += new System.EventHandler(this.SaveFileToOpen_Click);
            // 
            // tbEncryptLessN
            // 
            this.tbEncryptLessN.Location = new System.Drawing.Point(52, 243);
            this.tbEncryptLessN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEncryptLessN.Name = "tbEncryptLessN";
            this.tbEncryptLessN.Size = new System.Drawing.Size(112, 26);
            this.tbEncryptLessN.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "n = p * q";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(225, 68);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(587, 196);
            this.tbInput.TabIndex = 14;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(225, 309);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(587, 196);
            this.tbOutput.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Исходный текст:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Обработанный текст:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btEncrypt,
            this.toolStripSeparator1,
            this.btDecrypt,
            this.toolStripSeparator2,
            this.btClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 31);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btEncrypt
            // 
            this.btEncrypt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btEncrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("btEncrypt.Image")));
            this.btEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(94, 28);
            this.btEncrypt.Text = "Шифровать";
            this.btEncrypt.Click += new System.EventHandler(this.btEncryptOrDecrypt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btDecrypt
            // 
            this.btDecrypt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btDecrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("btDecrypt.Image")));
            this.btDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(110, 24);
            this.btDecrypt.Text = "Дешифровать";
            this.btDecrypt.Click += new System.EventHandler(this.btEncryptOrDecrypt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btClear.Image = ((System.Drawing.Image)(resources.GetObject("btClear.Image")));
            this.btClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(77, 24);
            this.btClear.Text = "Очистить";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // ofdChooseAnyFile
            // 
            this.ofdChooseAnyFile.Filter = "All files|*.*";
            // 
            // RabinCryptosystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(850, 531);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEncryptLessN);
            this.Controls.Add(this.btOutputFile);
            this.Controls.Add(this.btInputFile);
            this.Controls.Add(this.tbOutputFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbInputFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstSimple);
            this.Controls.Add(this.tbMultTwoSimple);
            this.Controls.Add(this.tbSecondSimple);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RabinCryptosystem";
            this.Text = "RabinCryptosystem";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSecondSimple;
        private System.Windows.Forms.TextBox tbMultTwoSimple;
        private System.Windows.Forms.TextBox tbFirstSimple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInputFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOutputFileName;
        private System.Windows.Forms.Button btInputFile;
        private System.Windows.Forms.Button btOutputFile;
        private System.Windows.Forms.TextBox tbEncryptLessN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btEncrypt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btDecrypt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btClear;
        private System.Windows.Forms.OpenFileDialog ofdChooseAnyFile;
    }
}

