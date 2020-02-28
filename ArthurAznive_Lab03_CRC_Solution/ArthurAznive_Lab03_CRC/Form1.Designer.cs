namespace ArthurAznive_Lab03_CRC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.openFileBttn = new System.Windows.Forms.Button();
            this.textFileContentLbl = new System.Windows.Forms.Label();
            this.richTextBoxFileContent = new System.Windows.Forms.RichTextBox();
            this.calcCRCBtn = new System.Windows.Forms.Button();
            this.resultsCRCGroupBox = new System.Windows.Forms.GroupBox();
            this.binaryResultTxtBox = new System.Windows.Forms.TextBox();
            this.lblBinary = new System.Windows.Forms.Label();
            this.octalResultTxtBox = new System.Windows.Forms.TextBox();
            this.lblOctal = new System.Windows.Forms.Label();
            this.hexResultTxtBox = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.decResultTxtBox = new System.Windows.Forms.TextBox();
            this.resultsCRCGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Location = new System.Drawing.Point(12, 12);
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(325, 20);
            this.filePathTxtBox.TabIndex = 0;
            // 
            // openFileBttn
            // 
            this.openFileBttn.Location = new System.Drawing.Point(342, 10);
            this.openFileBttn.Name = "openFileBttn";
            this.openFileBttn.Size = new System.Drawing.Size(106, 23);
            this.openFileBttn.TabIndex = 1;
            this.openFileBttn.Text = "Open File";
            this.openFileBttn.UseVisualStyleBackColor = true;
            this.openFileBttn.Click += new System.EventHandler(this.openFileBttn_Click);
            // 
            // textFileContentLbl
            // 
            this.textFileContentLbl.AutoSize = true;
            this.textFileContentLbl.Location = new System.Drawing.Point(12, 46);
            this.textFileContentLbl.Name = "textFileContentLbl";
            this.textFileContentLbl.Size = new System.Drawing.Size(152, 13);
            this.textFileContentLbl.TabIndex = 2;
            this.textFileContentLbl.Text = "Contents of Selected Text File:";
            // 
            // richTextBoxFileContent
            // 
            this.richTextBoxFileContent.Location = new System.Drawing.Point(12, 63);
            this.richTextBoxFileContent.Name = "richTextBoxFileContent";
            this.richTextBoxFileContent.ReadOnly = true;
            this.richTextBoxFileContent.Size = new System.Drawing.Size(322, 155);
            this.richTextBoxFileContent.TabIndex = 3;
            this.richTextBoxFileContent.Text = "";
            // 
            // calcCRCBtn
            // 
            this.calcCRCBtn.Location = new System.Drawing.Point(343, 185);
            this.calcCRCBtn.Name = "calcCRCBtn";
            this.calcCRCBtn.Size = new System.Drawing.Size(105, 33);
            this.calcCRCBtn.TabIndex = 4;
            this.calcCRCBtn.Text = "Calculate CRC";
            this.calcCRCBtn.UseVisualStyleBackColor = true;
            this.calcCRCBtn.Click += new System.EventHandler(this.calcCRCBtn_Click);
            // 
            // resultsCRCGroupBox
            // 
            this.resultsCRCGroupBox.Controls.Add(this.binaryResultTxtBox);
            this.resultsCRCGroupBox.Controls.Add(this.lblBinary);
            this.resultsCRCGroupBox.Controls.Add(this.octalResultTxtBox);
            this.resultsCRCGroupBox.Controls.Add(this.lblOctal);
            this.resultsCRCGroupBox.Controls.Add(this.hexResultTxtBox);
            this.resultsCRCGroupBox.Controls.Add(this.lblHex);
            this.resultsCRCGroupBox.Controls.Add(this.lblDecimal);
            this.resultsCRCGroupBox.Controls.Add(this.decResultTxtBox);
            this.resultsCRCGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsCRCGroupBox.Location = new System.Drawing.Point(456, 13);
            this.resultsCRCGroupBox.Name = "resultsCRCGroupBox";
            this.resultsCRCGroupBox.Size = new System.Drawing.Size(231, 205);
            this.resultsCRCGroupBox.TabIndex = 5;
            this.resultsCRCGroupBox.TabStop = false;
            this.resultsCRCGroupBox.Text = "Results";
            // 
            // binaryResultTxtBox
            // 
            this.binaryResultTxtBox.Location = new System.Drawing.Point(73, 168);
            this.binaryResultTxtBox.Name = "binaryResultTxtBox";
            this.binaryResultTxtBox.Size = new System.Drawing.Size(152, 22);
            this.binaryResultTxtBox.TabIndex = 7;
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Location = new System.Drawing.Point(9, 171);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(46, 16);
            this.lblBinary.TabIndex = 6;
            this.lblBinary.Text = "Binary";
            // 
            // octalResultTxtBox
            // 
            this.octalResultTxtBox.Location = new System.Drawing.Point(73, 124);
            this.octalResultTxtBox.Name = "octalResultTxtBox";
            this.octalResultTxtBox.Size = new System.Drawing.Size(152, 22);
            this.octalResultTxtBox.TabIndex = 5;
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(9, 127);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(39, 16);
            this.lblOctal.TabIndex = 4;
            this.lblOctal.Text = "Octal";
            // 
            // hexResultTxtBox
            // 
            this.hexResultTxtBox.Location = new System.Drawing.Point(73, 78);
            this.hexResultTxtBox.Name = "hexResultTxtBox";
            this.hexResultTxtBox.Size = new System.Drawing.Size(152, 22);
            this.hexResultTxtBox.TabIndex = 3;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(9, 81);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(32, 16);
            this.lblHex.TabIndex = 2;
            this.lblHex.Text = "Hex";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(9, 36);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(58, 16);
            this.lblDecimal.TabIndex = 1;
            this.lblDecimal.Text = "Decimal";
            // 
            // decResultTxtBox
            // 
            this.decResultTxtBox.Location = new System.Drawing.Point(73, 33);
            this.decResultTxtBox.Name = "decResultTxtBox";
            this.decResultTxtBox.Size = new System.Drawing.Size(152, 22);
            this.decResultTxtBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 230);
            this.Controls.Add(this.resultsCRCGroupBox);
            this.Controls.Add(this.calcCRCBtn);
            this.Controls.Add(this.richTextBoxFileContent);
            this.Controls.Add(this.textFileContentLbl);
            this.Controls.Add(this.openFileBttn);
            this.Controls.Add(this.filePathTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "8-Bit CRC Calculator";
            this.resultsCRCGroupBox.ResumeLayout(false);
            this.resultsCRCGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.Button openFileBttn;
        private System.Windows.Forms.Label textFileContentLbl;
        private System.Windows.Forms.RichTextBox richTextBoxFileContent;
        private System.Windows.Forms.Button calcCRCBtn;
        private System.Windows.Forms.GroupBox resultsCRCGroupBox;
        private System.Windows.Forms.TextBox binaryResultTxtBox;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.TextBox octalResultTxtBox;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.TextBox hexResultTxtBox;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.TextBox decResultTxtBox;
    }
}

