using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;


namespace AOA_INTERFACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCheckPala_Click(object sender, EventArgs e)
        {
            string Text1 = richTextBox1.Text;
            string Text2 = richTextBox2.Text;
            lcs(Text1,Text2); //calling function of lcs
        }

        
       
        
        //Function of LCS
        void lcs(string X, string Y)
        {
            // This empty the existing file
            if (File.Exists(@"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input.txt"))
            {
                File.WriteAllText(@"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input.txt", String.Empty);
            }
            String path = @"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input.txt";
            File.WriteAllText(path, "");
            int m = X.Length;
            int n = Y.Length;
            int[,] L = new int[m + 9999, n + 9999];

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
                    //Create a file and store matching word in it.
                    
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        sr.Write(s);
                        sr.Close();
                    }

                }
            }

            //Read all matching words from file and print it.
            string file_data = System.IO.File.ReadAllText(@"C:\Users\Muhammad Haroon\Desktop\uni\Work\User_input.txt");
            MessageBox.Show("THE LENGHT OF LCS is : "+temp+ " \nAnd the LCS Is :\n"+ file_data + "","Plagiarism Checker");
        }


        private void ButtonForFilesClickHere_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
            obj.Show();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
