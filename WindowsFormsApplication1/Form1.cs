using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Encryption (string input)
        {
                        /* Get the string to encrypt: From File
             * 
             */

            //Process input into character array
            char[] inputArray = input.ToCharArray();

            //Creat encryption key
            var ran = new Random();
            int[] keyArray = Enumerable.Range(0, 94).OrderBy(x => ran.Next()).ToArray();

            //Convert integers in key to legal characters
            char[] chars = new char[126];
            for (int k = 0; k < 94; k++)
            {
                keyArray[k] = keyArray[k] + 33;
                System.Console.WriteLine(k + ". " + keyArray[k]);
                char character = (char)keyArray[k];
                chars[k] = character;
            }

            //Encrypt string
            for (int i = 0; i < inputArray.Length; i = i + 1)
            {
                int c = Convert.ToInt32(inputArray[i]);
                if (c >= 33 && c <= 126)
                {
                    c = keyArray[c - 33];
                }
                char character = (char)c;
                inputArray[i] = character;
            }

            //Print Output
            string output = new string(inputArray);
            outputBox.Text = output;

            //Print Key
            string key = new string(chars);
            keyBox.Text = key;

            
        }

        private void Decryption(string input)
        {
            //Process input into character array
            char[] inputArray = input.ToCharArray();

            //Read key
            string key = keyBox.Text;
            char[] keyArray = key.ToCharArray();

            //Decrypt string
            for (int i = 0; i < input.Length; i++)
            {
                int c = Convert.ToInt32(inputArray[i]);
                for (int j = 0; j < 94; j++ )
                    if (inputArray[i] == keyArray[j])
                    {
                        c = 33 + j;
                    }
                inputArray[i] = (char)c;
            }

            //Print Output
            string output = new string(inputArray);
            outputBox.Text = output;



        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            //Get String: Manual
            string input = inputBox.Text;
            Encryption(input);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            //Get String: Manual
            string input = inputBox.Text;
            Decryption(input);
        }

        private void encryptFromFileButton_Click(object sender, EventArgs e)
        {
            //Get String: From File
            //DialogResult result = openFileDialog1.ShowDialog();
            /*if (result == DialogResult.OK) // Test result.
            {
                string input = openFileDialog1.ToString;
            }*/
            string input = File.ReadAllText(@"C:\Users\Brandon\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\input.txt");
            Encryption(input);
            string output = outputBox.Text;
            File.WriteAllText(@"C:\Users\Brandon\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\output.txt", output);
        }

        private void decryptFromFileButton_Click(object sender, EventArgs e)
        {
            //Get String: Manual
            string input = File.ReadAllText(@"C:\Users\Brandon\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\input1.txt");
            Decryption(input);
            string output = outputBox.Text;
            File.WriteAllText(@"C:\Users\Brandon\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\output1.txt", output);
        }
    }
}
