using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AOA_INTERFACE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonFileCheckPalgiarism_Click(object sender, EventArgs e)
        {
            if (radio_btn_Files.Checked == true)  //if file checking 
            {
                
                    string File_1_data = System.IO.File.ReadAllText(TextBoxFilePath1.Text);
                    string File_2_data = System.IO.File.ReadAllText(TextBoxFilePath2.Text);
                    lcs1(File_1_data, File_2_data);//Calling function for checking TWO files plagiarism

              
            }
            else if (radio_btn_Folders.Checked == true)  //if folder checking
            {

                string[] array;
                array = Directory.GetFiles(textBox1.Text);
               
                if (array.Length >= 2)  //if folder contains atleast two files
                {

                    //checking first two files
                   
                    string First_file_data = System.IO.File.ReadAllText(array[0]);
                    string Second_file_data = System.IO.File.ReadAllText(array[1]);

                    //Caling function for checking folders files plagiarism
                    lcs2(First_file_data, Second_file_data);

                }
              }
        }

        //For File Checking
        void lcs1(String X, String Y)

        {
            // This empty the existing file
            if (File.Exists(@"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input1.txt"))
            {
                File.WriteAllText(@"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input1.txt", String.Empty);
            }
            String path = @"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input1.txt";
            File.WriteAllText(path, "");
            int m = X.Length;
            int n = Y.Length;
            int[,] L = new int[m + 1, n + 1];


            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
            int index = L[m, n];
            int temp = index;


            char[] lcs = new char[index + 1];
            lcs[index] = '\0'; // Set the terminating character
            int k = m, l = n;
            while (k > 0 && l > 0)
            {
                if (X[k - 1] == Y[l - 1])
                {
                    lcs[index - 1] = X[k - 1];
                    k--;
                    l--;
                    index--;
                }
                else if (L[k - 1, l] > L[k, l - 1])
                    k--;
                else
                    l--;
            }

            //temp variable contain lenght of lcs
            for (int q = 0; q <= temp; q++)
            {
                string s = lcs[q].ToString();
                {

                    //Create new file and store matching words in it.
                    
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        sr.Write(s);
                        sr.Close();
                        
                    }
                }
            }
            //Read all matching characters from file in variable file_data and print it by message box. 

            string file_data = System.IO.File.ReadAllText(path);
            MessageBox.Show("THE LENGHT OF LCS is : " + temp + " \nAnd the LCS Is \n" + file_data + "", "Plagairism Checker");
            
        }

        //For Folder checking
        void lcs2(string X, string Y)
        {
            // This empty the existing file
            if (File.Exists(@"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input2.txt"))
            {
                File.WriteAllText(@"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input2.txt", String.Empty);
            }
            String path = @"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input2.txt";
            File.WriteAllText(path, "");
            int m = X.Length;
            int n = Y.Length;
            int[,] L = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }

            int index = L[m, n];
            int temp = index;
            char[] lcs = new char[index + 1];

            lcs[index] = '\0'; // Set the terminating character

            int k = m, l = n;
            while (k > 0 && l > 0)
            {
                if (X[k - 1] == Y[l - 1])
                {
                    lcs[index - 1] = X[k - 1];
                    k--;
                    l--;
                    index--;
                }

                else if (L[k - 1, l] > L[k, l - 1])
                    k--;
                else
                    l--;
            }


            int q;
            for (q = 0; q <= temp; q++)
            {

                string s = lcs[q].ToString();
                {
                    //Create new file and store matching words in it.
                    
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        sr.Write(s);
                        sr.Close();
                      
                    }
                }
            }
            //Read all matching characters from file in variable fileData and print it by message box. 

            string fileData = System.IO.File.ReadAllText(path);
            MessageBox.Show("THE LENGHT OF LCS is : " + temp + " \nAnd the LCS Is \n" + fileData + "", "Plagairism Checker");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //To browse folder from pc
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath.ToString();
            }
        }

        private void radio_btn_Folders_CheckedChanged(object sender, EventArgs e)
        {
            bool visible = true;
            groupBox_FolderChecking.Visible = visible;
            groupBox1.Visible = !visible;
        }

        private void radio_btn_Files_CheckedChanged(object sender, EventArgs e)
        {
            bool visible = true;
            groupBox_FolderChecking.Visible = !visible;
            groupBox1.Visible = visible;
        }

        private void btn_SelectFile1_Click(object sender, EventArgs e)
        {
            //To browse file from pc
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.FileName.ToString();
                TextBoxFilePath1.Text = path;
            }
        }

        private void TextBoxFilePath1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SelectFile2_Click(object sender, EventArgs e)
        {
            //To browse file from pc
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.FileName.ToString();
                TextBoxFilePath2.Text = path;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   