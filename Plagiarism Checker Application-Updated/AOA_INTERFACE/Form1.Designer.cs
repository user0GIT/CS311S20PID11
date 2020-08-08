namespace AOA_INTERFACE
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ButtonCheckPala = new System.Windows.Forms.Button();
            this.ButtonForFilesClickHere = new System.Windows.Forms.Button();
            this.LabelPalgiarismChecker = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(56, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(428, 274);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(502, 76);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(422, 274);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // ButtonCheckPala
            // 
            this.ButtonCheckPala.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonCheckPala.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheckPala.ForeColor = System.Drawing.Color.Black;
            this.ButtonCheckPala.Location = new System.Drawing.Point(502, 356);
            this.ButtonCheckPala.Name = "ButtonCheckPala";
            this.ButtonCheckPala.Size = new System.Drawing.Size(185, 61);
            this.ButtonCheckPala.TabIndex = 2;
            this.ButtonCheckPala.Text = "Check Plagiarism";
            this.ButtonCheckPala.UseVisualStyleBackColor = false;
            this.ButtonCheckPala.Click += new System.EventHandler(this.ButtonCheckPala_Click);
            // 
            // ButtonForFilesClickHere
            // 
            this.ButtonForFilesClickHere.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonForFilesClickHere.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonForFilesClickHere.Location = new System.Drawing.Point(693, 356);
            this.ButtonForFilesClickHere.Name = "ButtonForFilesClickHere";
            this.ButtonForFilesClickHere.Size = new System.Drawing.Size(153, 61);
            this.ButtonForFilesClickHere.TabIndex = 3;
            this.ButtonForFilesClickHere.Text = "For Files/Folder  Click Here";
            this.ButtonForFilesClickHere.UseVisualStyleBackColor = false;
            this.ButtonForFilesClickHere.Click += new System.EventHandler(this.ButtonForFilesClickHere_Click);
            // 
            // LabelPalgiarismChecker
            // 
            this.LabelPalgiarismChecker.AutoSize = true;
            this.LabelPalgiarismChecker.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPalgiarismChecker.Location = new System.Drawing.Point(318, 27);
            this.LabelPalgiarismChecker.Name = "LabelPalgiarismChecker";
            this.LabelPalgiarismChecker.Size = new System.Drawing.Size(322, 32);
            this.LabelPalgiarismChecker.TabIndex = 4;
            this.LabelPalgiarismChecker.Text = "Plagiarism Checker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Text in Above Boxes and then Click on \r\nCheck Plagiarism Button For Plagiar" +
    "ism Checking\r\n";
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(852, 356);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(72, 61);
            this.button_Close.TabIndex = 12;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(988, 442);
            this.ControlBox = false;
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelPalgiarismChecker);
            this.Controls.Add(this.ButtonForFilesClickHere);
            this.Controls.Add(this.ButtonCheckPala);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Plagiarism_Checker1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button ButtonCheckPala;
        private System.Windows.Forms.Button ButtonForFilesClickHere;
        private System.Windows.Forms.Label LabelPalgiarismChecker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Close;
    }
}

