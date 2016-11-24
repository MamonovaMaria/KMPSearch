using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMPSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxForText_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxForText.Text.Equals(""))
            {
                label1.Enabled = true;
                textBoxForSearch.Enabled = true;
                buttonForSearch.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                textBoxForSearch.Enabled = false;
                buttonForSearch.Enabled = false;
            }
        }

        private void buttonForChoiceFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader openFile = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                textBoxForText.AppendText(openFile.ReadToEnd());
                openFile.Close();
            }
        }

        private void buttonForSearch_Click(object sender, EventArgs e)
        {
            int result = KMPSearchFunction(textBoxForText.Text, textBoxForSearch.Text);
            label2.Enabled = true;
            textBoxForResult.Enabled = true;
            if (result == -1)
                textBoxForResult.Text = "Подстрока не найдена или введена некорректно";
            else
                textBoxForResult.Text = result.ToString();
        }


        private int KMPSearchFunction(string text, string substring)
        {
            int res = -1;

            int lText = text.Length;
            int lSubstr = substring.Length;

            if(lText != 0 && lSubstr != 0)
            {
                int i, j = 0, k = -1;
                int[] d = new int[1000];
                d[0] = -1;

                while(j < lSubstr-1)
                {
                    while (k >= 0 && substring[j] != substring[k])
                        k = d[k];
                    j++;
                    k++;
                    if (substring[j] == substring[k])
                        d[j] = d[k];
                    else
                        d[j] = k;
                }

                i = 0;
                j = 0;
                while(j < lSubstr && i < lText)
                {
                    while (j >= 0 && text[i] != substring[j])
                        j = d[j];
                    i++;
                    j++;
                }

                res = j == lSubstr ? i - lSubstr : -1;
            }
            return res;
        }
    }
}
