using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        Form1 Frm13;
        public Form3(Form1 F_13)
        {
            InitializeComponent();
            this.Frm13 = F_13;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            #region
            Form1 A = new Form1();
            if (A.button1.BackColor == SystemColors.Control && this.BackColor != SystemColors.Control)
            {
                this.BackColor = SystemColors.Control;

                button7.BackColor = SystemColors.Control;
                button8.BackColor = SystemColors.Control;
                button9.BackColor = SystemColors.Control;
                button10.BackColor = SystemColors.Control;
                button11.BackColor = SystemColors.Control;
                button12.BackColor = SystemColors.Control;
                button13.BackColor = SystemColors.Control;
                button14.BackColor = SystemColors.Control;
                button15.BackColor = SystemColors.Control;
                button16.BackColor = SystemColors.Control;
                button17.BackColor = SystemColors.Control;
                label1.BackColor = SystemColors.Control;
                textBox2.BackColor = SystemColors.Control;

                button7.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button9.ForeColor = Color.Black;
                button10.ForeColor = Color.Black;
                button11.ForeColor = Color.Black;
                button12.ForeColor = Color.Black;
                button13.ForeColor = Color.Black;
                button14.ForeColor = Color.Black;
                button15.ForeColor = Color.Black;
                button16.ForeColor = Color.Black;
                button17.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;
            }
            else if (A.button1.BackColor == Color.SaddleBrown && this.BackColor != Color.DimGray)
            {
                this.BackColor = Color.DimGray;

                button7.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.Black;
                button10.BackColor = Color.Black;
                button11.BackColor = Color.Black;
                button12.BackColor = Color.Black;
                button13.BackColor = Color.Black;
                button14.BackColor = Color.Black;
                button15.BackColor = Color.Black;
                button16.BackColor = Color.Black;
                button17.BackColor = Color.Black;
                label1.BackColor = Color.DimGray;
                textBox2.BackColor = Color.DimGray;

                button7.ForeColor = Color.White;
                button8.ForeColor = Color.White;
                button9.ForeColor = Color.White;
                button10.ForeColor = Color.White;
                button11.ForeColor = Color.White;
                button12.ForeColor = Color.White;
                button13.ForeColor = Color.White;
                button14.ForeColor = Color.White;
                button15.ForeColor = Color.White;
                button16.ForeColor = Color.White;
                button17.ForeColor = Color.White;
                textBox2.ForeColor = Color.White;
            }
            else if (A.button1.BackColor == Color.FromArgb(0, 102, 204) && this.BackColor != System.Drawing.Color.White)
            {
                this.BackColor = System.Drawing.Color.White;

                button7.BackColor = Color.FromArgb(229, 228, 226);
                button8.BackColor = Color.FromArgb(229, 228, 226);
                button9.BackColor = Color.FromArgb(229, 228, 226);
                button10.BackColor = Color.FromArgb(229, 228, 226);
                button11.BackColor = Color.FromArgb(229, 228, 226);
                button12.BackColor = Color.FromArgb(229, 228, 226);
                button13.BackColor = Color.FromArgb(229, 228, 226);
                button14.BackColor = Color.FromArgb(229, 228, 226);
                button15.BackColor = Color.FromArgb(229, 228, 226);
                button16.BackColor = Color.FromArgb(229, 228, 226);
                button17.BackColor = Color.FromArgb(229, 228, 226);
                label1.BackColor = Color.White;
                textBox2.BackColor = Color.White;

                button7.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button9.ForeColor = Color.Black;
                button10.ForeColor = Color.Black;
                button11.ForeColor = Color.Black;
                button12.ForeColor = Color.Black;
                button13.ForeColor = Color.Black;
                button14.ForeColor = Color.Black;
                button15.ForeColor = Color.Black;
                button16.ForeColor = Color.Black;
                button17.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;
            }
            #endregion
        }

        //Numbers
        #region
        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 0;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 1;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 2;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 3;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 4;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 5;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 6;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 7;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 8;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                textBox2.Clear();
            }
            textBox2.Text += 9;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        #endregion

        //OK
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "2";
            }
            for (int i = textBox2.TextLength - 1 ; i >= 0 ; i--)
            {
                char w = textBox2.Text[i];
                if (w == '.')
                {
                    label1.Text = "1";
                }
                else
                {
                    label1.Text = "0";
                }
            }
            if (Double.Parse(textBox2.Text) <= 1)
            {
                MessageBox.Show("Ufortunately, can't calculate negative or zero or one root!");
            }
            else if (Double.Parse(textBox2.Text) > 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid input‬");
            }
        }

        #endregion

        //Backspace
        #region
        private void button17_Click(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            textBox2.Clear();
            for (int i = 0; i < s.Length - 1; i++)
            {
                char w = s[i];
                textBox2.Text += w;
            }
        }
        #endregion

        //Timer
        #region
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد"))
            {
                label1.ForeColor = System.Drawing.Color.Red;
            }
            int n = 0;
            if (textBox2.Text != "")
            {
                if (BigInteger.Parse(textBox2.Text) > 99999999999999)
                {
                    label1.ForeColor = System.Drawing.Color.Red;
                    n = 1;
                }
               else if (BigInteger.Parse(textBox2.Text) <= 99999999999999)
                {
                    label1.ForeColor = System.Drawing.Color.Lime;
                }
            }
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                char w = textBox2.Text[i];
                if (w == '.')
                {
                    label1.Text = "1";
                    label1.ForeColor = System.Drawing.Color.Red;
                    break;
                }
                if (n == 0)
                {
                    label1.Text = "0";
                    label1.ForeColor = System.Drawing.Color.Lime;
                }
            }
        }
        #endregion

        //Right click of textBox2.Text
        #region
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.SelectedText.Length > 0)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.SelectionStart) + textBox2.Text.Substring(textBox2.SelectionStart + textBox2.SelectionLength, textBox2.Text.Length - (textBox2.SelectionStart + textBox2.SelectedText.Length));
            }
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }
        #endregion
    }
}