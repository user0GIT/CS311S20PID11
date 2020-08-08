namespace AOA_INTERFACE
{
    partial class Form2
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
            this.TextBoxFilePath1 = new System.Windows.Forms.TextBox();
            this.TextBoxFilePath2 = new System.Windows.Forms.TextBox();
            this.LabelFilePath1 = new System.Windows.Forms.Label();
            this.LabelFilePath2 = new System.Windows.Forms.Label();
            this.LabelPalgiarismChecker = new System.Windows.Forms.Label();
            this.ButtonFileCheckPalgiarism = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SelectFile2 = new System.Windows.Forms.Button();
            this.btn_SelectFile1 = new System.Windows.Forms.Button();
            this.groupBox_FolderChecking = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_btn_Files = new System.Windows.Forms.RadioButton();
            this.radio_btn_Folders = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox_FolderChecking.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxFilePath1
            // 
            this.TextBoxFilePath1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFilePath1.Location = new System.Drawing.Point(105, 25);
            this.TextBoxFilePath1.Name = "TextBoxFilePath1";
            this.TextBoxFilePath1.Size = new System.Drawing.Size(513, 23);
            this.TextBoxFilePath1.TabIndex = 0;
            this.TextBoxFilePath1.TextChanged += new System.EventHandler(this.TextBoxFilePath1_TextChanged);
            // 
            // TextBoxFilePath2
            // 
            this.TextBoxFilePath2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFilePath2.Location = new System.Drawing.Point(105, 70);
            this.TextBoxFilePath2.Name = "TextBoxFilePath2";
            this.TextBoxFilePath2.Size = new System.Drawing.Size(513, 23);
            this.TextBoxFilePath2.TabIndex = 1;
            this.TextBoxFilePath2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LabelFilePath1
            // 
            this.LabelFilePath1.AutoSize = true;
            this.LabelFilePath1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFilePath1.Location = new System.Drawing.Point(15, 24);
            this.LabelFilePath1.Name = "LabelFilePath1";
            this.LabelFilePath1.Size = new System.Drawing.Size(84, 18);
            this.LabelFilePath1.TabIndex = 2;
            this.LabelFilePath1.Text = "FilePath 1";
            // 
            // LabelFilePath2
            // 
            this.LabelFilePath2.AutoSize = true;
            this.LabelFilePath2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFilePath2.Location = new System.Drawing.Point(15, 79);
            this.LabelFilePath2.Name = "LabelFilePath2";
            this.LabelFilePath2.Size = new System.Drawing.Size(84, 18);
            this.LabelFilePath2.TabIndex = 3;
            this.LabelFilePath2.Text = "FilePath 2";
            // 
            // LabelPalgiarismChecker
            // 
            this.LabelPalgiarismChecker.AutoSize = true;
            this.LabelPalgiarismChecker.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPalgiarismChecker.Location = new System.Drawing.Point(296, 35);
            this.LabelPalgiarismChecker.Name = "LabelPalgiarismChecker";
            this.LabelPalgiarismChecker.Size = new System.Drawing.Size(325, 39);
            this.LabelPalgiarismChecker.TabIndex = 4;
            this.LabelPalgiarismChecker.Text = "Plagiarism Checker";
            // 
            // ButtonFileCheckPalgiarism
            // 
            this.ButtonFileCheckPalgiarism.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonFileCheckPalgiarism.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFileCheckPalgiarism.Location = new System.Drawing.Point(395, 419);
            this.ButtonFileCheckPalgiarism.Name = "ButtonFileCheckPalgiarism";
            this.ButtonFileCheckPalgiarism.Size = new System.Drawing.Size(206, 57);
            this.ButtonFileCheckPalgiarism.TabIndex = 5;
            this.ButtonFileCheckPalgiarism.Text = "Check Palagrism";
            this.ButtonFileCheckPalgiarism.UseVisualStyleBackColor = false;
            this.ButtonFileCheckPalgiarism.Click += new System.EventHandler(this.ButtonFileCheckPalgiarism_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonBack.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Location = new System.Drawing.Point(607, 420);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(196, 56);
            this.ButtonBack.TabIndex = 6;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.btn_SelectFile2);
            this.groupBox1.Controls.Add(this.TextBoxFilePath2);
            this.groupBox1.Controls.Add(this.btn_SelectFile1);
            this.groupBox1.Controls.Add(this.TextBoxFilePath1);
            this.groupBox1.Controls.Add(this.LabelFilePath1);
            this.groupBox1.Controls.Add(this.LabelFilePath2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Checking";
            // 
            // btn_SelectFile2
            // 
            this.btn_SelectFile2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_SelectFile2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectFile2.Location = new System.Drawing.Point(633, 70);
            this.btn_SelectFile2.Name = "btn_SelectFile2";
            this.btn_SelectFile2.Size = new System.Drawing.Size(101, 29);
            this.btn_SelectFile2.TabIndex = 12;
            this.btn_SelectFile2.Text = "Select File";
            this.btn_SelectFile2.UseVisualStyleBackColor = false;
            this.btn_SelectFile2.Click += new System.EventHandler(this.btn_SelectFile2_Click);
            // 
            // btn_SelectFile1
            // 
            this.btn_SelectFile1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_SelectFile1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectFile1.Location = new System.Drawing.Point(633, 26);
            this.btn_SelectFile1.Name = "btn_SelectFile1";
            this.btn_SelectFile1.Size = new System.Drawing.Size(101, 29);
            this.btn_SelectFile1.TabIndex = 11;
            this.btn_SelectFile1.Text = "Select File";
            this.btn_SelectFile1.UseVisualStyleBackColor = false;
            this.btn_SelectFile1.Click += new System.EventHandler(this.btn_SelectFile1_Click);
            // 
            // groupBox_FolderChecking
            // 
            this.groupBox_FolderChecking.Controls.Add(this.textBox1);
            this.groupBox_FolderChecking.Controls.Add(this.button1);
            this.groupBox_FolderChecking.Controls.Add(this.label1);
            this.groupBox_FolderChecking.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_FolderChecking.Location = new System.Drawing.Point(22, 300);
            this.groupBox_FolderChecking.Name = "groupBox_FolderChecking";
            this.groupBox_FolderChecking.Size = new System.Drawing.Size(781, 87);
            this.groupBox_FolderChecking.TabIndex = 8;
            this.groupBox_FolderChecking.TabStop = false;
            this.groupBox_FolderChecking.Text = "Folder Checking";
            this.groupBox_FolderChecking.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(606, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radio_btn_Files
            // 
            this.radio_btn_Files.AutoSize = true;
            this.radio_btn_Files.Checked = true;
            this.radio_btn_Files.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_btn_Files.Location = new System.Drawing.Point(214, 107);
            this.radio_btn_Files.Name = "radio_btn_Files";
            this.radio_btn_Files.Size = new System.Drawing.Size(107, 20);
            this.radio_btn_Files.TabIndex = 9;
            this.radio_btn_Files.TabStop = true;
            this.radio_btn_Files.Text = "File Checking";
            this.radio_btn_Files.UseVisualStyleBackColor = true;
            this.radio_btn_Files.CheckedChanged += new System.EventHandler(this.radio_btn_Files_CheckedChanged);
            // 
            // radio_btn_Folders
            // 
            this.radio_btn_Folders.AutoSize = true;
            this.radio_btn_Folders.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_btn_Folders.Location = new System.Drawing.Point(350, 107);
            this.radio_btn_Folders.Name = "radio_btn_Folders";
            this.radio_btn_Folders.Size = new System.Drawing.Size(126, 20);
            this.radio_btn_Folders.TabIndex = 10;
            this.radio_btn_Folders.Text = "Folder Checking";
            this.radio_btn_Folders.UseVisualStyleBackColor = true;
            this.radio_btn_Folders.CheckedChanged += new System.EventHandler(this.radio_btn_Folders_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(993, 488);
            this.ControlBox = false;
            this.Controls.Add(this.radio_btn_Folders);
            this.Controls.Add(this.radio_btn_Files);
            this.Controls.Add(this.groupBox_FolderChecking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonFileCheckPalgiarism);
            this.Controls.Add(this.LabelPalgiarismChecker);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_FolderChecking.ResumeLayout(false);
            this.groupBox_FolderChecking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFilePath1;
        private System.Windows.Forms.TextBox TextBoxFilePath2;
        private System.Windows.Forms.Label LabelFilePath1;
        private System.Windows.Forms.Label LabelFilePath2;
        private System.Windows.Forms.Label LabelPalgiarismChecker;
        private System.Windows.Forms.Button ButtonFileCheckPalgiarism;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_FolderChecking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_btn_Files;
        private System.Windows.Forms.RadioButton radio_btn_Folders;
        private System.Windows.Forms.Button btn_SelectFile1;
        private System.Windows.Forms.Button btn_SelectFile2;
    }
}