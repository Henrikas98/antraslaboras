using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_antrauzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                
                int skaicius; //skaicius, kuri ives naudotojas
                int counter = 0;
                int a = 1;
                int b;
                if (Int32.TryParse(textBox1.Text, out skaicius) && skaicius > 0)
                {
                    richTextBox1.Text = "Linksmų Kalėdų!: " + '\n' + '\n';
                    b = skaicius;
                    do
                    {
                        for (int i = 1; i < b; i++)
                        {
                            richTextBox1.AppendText(" ");
                        }
                        for (int i = 0; i < a; i++)
                        {
                            richTextBox1.AppendText("* ");
                        }
                        richTextBox1.AppendText("\n");
                        b--;
                        a++;
                        counter++;
                    } while (counter < skaicius);
                }
            }
        }
    }
}