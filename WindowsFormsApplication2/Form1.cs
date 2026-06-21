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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal f, c, m;
        
        #region π
        private void button19_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Clear();
            textBox1.Text += "π";
            textBox2.Text += "3.1415926535897932384626433833";
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        #endregion
        
        #region Decimal point
        private void button6_Click(object sender, EventArgs e)
        {
            int n = 0;
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            if (textBox2.Text == "")
            {
                textBox2.Text += 0;
            }
            for (int i = textBox2.Text.Length - 1; i >= 0; i--)
            {
                char w = textBox2.Text[i];
                if (w == '.')
                {
                    MessageBox.Show("Alraedy it has decimal point.");
                    n = 1;
                }
            }
            if (n == 0)
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
                textBox2.Text += ".";
            }
        }
        #endregion
        
        #region Right click
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Copy();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.SelectedText.Length > 0)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.SelectionStart) + textBox2.Text.Substring(textBox2.SelectionStart + textBox2.SelectionLength, textBox2.Text.Length - (textBox2.SelectionStart + textBox2.SelectedText.Length));
            }
            //if (textBox2.SelectedText.Length > 0)
            //{
            //    string s = textBox2.SelectedText;
            //    string q = textBox2.Text;
            //    textBox2.Clear();
            //    for (int i = 0; i <= q.Length - 1; i++)
            //    {
            //        if (s.Contains(q[i]))
            //        {
            //        }
            //        else
            //        {
            //            textBox2.Text += q[i];
            //        }
            //    }
            //}
        }
        private void selectAllToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    label1.Text = "0";
            //    if (button1.BackColor == Color.SaddleBrown)
            //    {
            //        label1.ForeColor = System.Drawing.Color.White;
            //    }
            //    else if (button1.BackColor == Color.FromArgb(0, 102, 204) || button1.BackColor == SystemColors.Control)
            //    {
            //        label1.ForeColor = System.Drawing.Color.Black;
            //    }
            //}
            //else if (decimal.Parse(textBox2.Text) > 99999999999)
            //{
            //    label1.ForeColor = System.Drawing.Color.Red;
            //}
            //else if (decimal.Parse(textBox2.Text) <= 99999999999)
            //{
            //    if (button1.BackColor == Color.SaddleBrown)
            //    {
            //        label1.ForeColor = System.Drawing.Color.White;
            //    }
            //    else if (button1.BackColor == Color.FromArgb(0, 102, 204) || button1.BackColor == SystemColors.Control)
            //    {
            //        label1.ForeColor = System.Drawing.Color.Black;
            //    }
            //    for (int i = 0; i < textBox2.Text.Length; i++)
            //    {
            //        char w = textBox2.Text[i];
            //        if (w == '.')
            //        {
            //            label1.Text = "1";
            //            break;
            //        }
            //        label1.Text = "0";
            //    }
            //}
        }
        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    label1.Text = "0";
            //    if (button1.BackColor == Color.SaddleBrown)
            //    {
            //        label1.ForeColor = System.Drawing.Color.White;
            //    }
            //    else if (button1.BackColor == Color.FromArgb(0, 102, 204) || button1.BackColor == SystemColors.Control)
            //    {
            //        label1.ForeColor = System.Drawing.Color.Black;
            //    }
            //}
            //else if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            //{
            //    label1.Text = "0";
            //    label1.ForeColor = System.Drawing.Color.Red;
            //}
            //else if (textBox2.Text != "")
            //{
            //    if (decimal.Parse(textBox2.Text) > 99999999999)
            //    {
            //        label1.ForeColor = System.Drawing.Color.Red;
            //    }
            //    else if (decimal.Parse(textBox2.Text) <= 99999999999)
            //    {
            //        if (button1.BackColor == Color.SaddleBrown)
            //        {
            //            label1.ForeColor = System.Drawing.Color.White;
            //        }
            //        else if (button1.BackColor == Color.FromArgb(0, 102, 204) || button1.BackColor == SystemColors.Control)
            //        {
            //            label1.ForeColor = System.Drawing.Color.Black;
            //        }
            //        for (int i = 0; i < textBox2.Text.Length; i++)
            //        {
            //            char w = textBox2.Text[i];
            //            if (w == '.')
            //            {
            //                label1.Text = "1";
            //                break;
            //            }
            //            label1.Text = "0";
            //        }
            //    }
            //}
        }
        #endregion

        #region Skin
        #region Defualt
        private void deualtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;

            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button17.BackColor = SystemColors.Control;
            button18.BackColor = SystemColors.Control;
            button19.BackColor = SystemColors.Control;
            button20.BackColor = SystemColors.Control;
            button22.BackColor = SystemColors.Control;
            button23.BackColor = SystemColors.Control;
            button24.BackColor = SystemColors.Control;
            button25.BackColor = SystemColors.Control;


            button6.BackColor = SystemColors.Control;
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
            button21.BackColor = SystemColors.Control;
            label1.BackColor = SystemColors.Control;

            textBox1.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;

            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button17.ForeColor = Color.Black;
            button18.ForeColor = Color.Black;
            button19.ForeColor = Color.Black;
            button20.ForeColor = Color.Black;
            button22.ForeColor = Color.Black;
            button23.ForeColor = Color.Black;
            button24.ForeColor = Color.Black;
            button25.ForeColor = Color.Black;

            button6.ForeColor = Color.Black;
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
            button21.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
        }
        #endregion
        
        #region Dark
        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;

            button1.BackColor = Color.SaddleBrown;
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button17.BackColor = Color.FromArgb(64, 64, 64);
            button18.BackColor = Color.FromArgb(64, 64, 64);
            button19.BackColor = Color.FromArgb(64, 64, 64);
            button20.BackColor = Color.FromArgb(64, 64, 64);
            button22.BackColor = Color.FromArgb(64, 64, 64);
            button23.BackColor = Color.FromArgb(64, 64, 64);
            button24.BackColor = Color.FromArgb(64, 64, 64);
            button25.BackColor = Color.FromArgb(64, 64, 64);


            button6.BackColor = Color.Black;
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
            button21.BackColor = Color.Black;
            label1.BackColor = Color.Black;

            textBox1.BackColor = Color.DimGray;
            textBox2.BackColor = Color.DimGray;

            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button17.ForeColor = Color.White;
            button18.ForeColor = Color.White;
            button19.ForeColor = Color.White;
            button20.ForeColor = Color.White;
            button22.ForeColor = Color.White;
            button23.ForeColor = Color.White;
            button24.ForeColor = Color.White;
            button25.ForeColor = Color.White;

            button6.ForeColor = Color.White;
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
            button21.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;

        }
        #endregion
        
        #region White
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;

            button1.BackColor = Color.FromArgb(0, 102, 204);
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
            button22.BackColor = Color.White;
            button23.BackColor = Color.White;
            button24.BackColor = Color.White;
            button25.BackColor = Color.White;


            button6.BackColor = Color.FromArgb(229, 228, 226);
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
            button21.BackColor = Color.FromArgb(229, 228, 226);
            label1.BackColor = Color.FromArgb(229, 228, 226);

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;

            button1.ForeColor = Color.White;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button17.ForeColor = Color.Black;
            button18.ForeColor = Color.Black;
            button19.ForeColor = Color.Black;
            button20.ForeColor = Color.Black;
            button22.ForeColor = Color.Black;
            button23.ForeColor = Color.Black;
            button24.ForeColor = Color.Black;
            button25.ForeColor = Color.Black;

            button6.ForeColor = Color.Black;
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
            button21.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
        }
        #endregion
        #endregion
        
        #region Numbers
        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 0;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 1;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 2;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 3;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 4;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 5;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 6;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 7;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 8;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                textBox2.Clear();
                c = 0;
                m = 0;
            }
            textBox2.Text += 9;
            if (textBox2.Text != "")
            {
                textBox2.Text = Convert.ToString(decimal.Parse(textBox2.Text));
            }
        }
        #endregion


        
        #region Sub
        private void button2_Click(object sender, EventArgs e)
        {
            int n = 0;
            decimal a;
            if (textBox1.Text != "")
            {
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '%')
                    {
                        c = 0;
                        n = 1;
                        break;
                    }
                }
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                c = 0;
                m = 0;
            }
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            else if (textBox2.Text == "")
            {
                a = 0;
                textBox1.Text += 0 + "+";
                f += a;
            }
            else if (n == 0)
            {
                a = Convert.ToDecimal(textBox2.Text);
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '+')
                    {
                        break;
                    }
                    else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                    {
                        textBox2.Clear();
                        break;
                    }
                }
                textBox1.Text += textBox2.Text + "+";
                textBox2.Clear();
                f += a;
            }
            else if (n == 1)
            {
                a = Convert.ToDecimal(textBox2.Text);
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '×')
                    {
                        f *= a;
                        break;
                    }
                    else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                    {
                        textBox2.Clear();
                        f *= a;
                        break;
                    }
                }
                textBox1.Text += textBox2.Text + "+";
                textBox2.Clear();
                if (f == 0 && m == 0)
                {
                    f = a;
                }
            }
        }
        #endregion
        
        #region Minus
        private void button3_Click(object sender, EventArgs e)
        {
            int n = 0;
            decimal a;
            if (textBox1.Text != "")
            {
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '%')
                    {
                        c = 0;
                        n = 1;
                        break;
                    }
                }
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                c = 0;
                m = 0;
            }
       
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            else if (textBox2.Text == "")
            {
                a = 0;
                textBox1.Text += 0 + "−";
                if (f == 0)
                {
                    f -= a;
                    f = Math.Abs(f);
                }
            }
            else if (n == 0)
            {
                a = Convert.ToDecimal(textBox2.Text);
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '−')
                    {
                        break;
                    }
                    else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                    {
                        textBox2.Clear();
                        break;
                    }
                }
                textBox1.Text += textBox2.Text + "−";
                textBox2.Clear();
                if (f == 0)
                {
                    if (a > 0)
                    {
                        f = Math.Abs(f -= a);
                    }
                    else
                    {
                        f += a;
                    }
                }
                else
                {
                    f -= a;
                }
            }
            else if (n == 1)
            {
                a = Convert.ToDecimal(textBox2.Text);
                
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '×')
                    {
                        f *= a;
                        break;
                    }
                    else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                    {
                        textBox2.Clear();
                        f *= a;
                        break;
                    }
                }
                textBox1.Text += textBox2.Text + "−";
                textBox2.Clear();
                if (f == 0 && m == 0)
                {
                    f = a;
                }
            }
        }
        #endregion

        #region Multiply
        private void button4_Click(object sender, EventArgs e)
        {
            int n = 0;
            decimal a;
            if (textBox1.Text != "")
            {
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '%')
                    {
                        c = 0;
                        n = 1;
                        break;
                    }
                }
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                c = 0;
                m = 0;
            }
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((textBox2.Text == "") && (f == 0))
            {
                a = 0;
                textBox1.Text += 0 + "×";
                f = 0;
                f *= a;
            }
            else if (textBox2.Text == "")
            {
                a = 1;
                textBox1.Text += 1 + "×";
                f *= a;
            }
            else if (n == 0)
            {
                a = Convert.ToDecimal(textBox2.Text);
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '×')
                    {
                        break;
                    }
                    else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                    {
                        textBox2.Clear();
                        break;
                    }
                }
                textBox1.Text += textBox2.Text + "×";
                textBox2.Clear();
                if (f == 0)
                {
                    f = 1;
                    f *= a;
                }
                else
                {
                    f *= a;
                }
            }
            else if (n == 1)
            {
                a = Convert.ToDecimal(textBox2.Text);
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '×')
                    {
                        f *= a;
                        break;
                    }
                    else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                    {
                        textBox2.Clear();
                        f *= a;
                        break;
                    }
                }
                textBox1.Text += textBox2.Text + "×";
                textBox2.Clear();
                if (f == 0 && m == 0)
                {
                    f = a;
                }
            }
        }
        #endregion

        #region Divide
        private void button5_Click_1(object sender, EventArgs e)
        {
            int n = 0;
            decimal a;
            if (textBox1.Text != "")
            {
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '%')
                    {
                        c = 0;
                        n = 1;
                        break;
                    }
                }
            }
            if ((f == 0) && (m == 2))
            {
                textBox1.Clear();
                c = 0;
                m = 0;
            }
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if ((textBox2.Text == "") && (f == 0))
            {
                a = 0;
                textBox1.Text += 0 + "÷";
                f = 1;
                f = a / f;
            }
            else if (textBox2.Text == "")
            {
                a = 1;
                textBox1.Text += 1 + "÷";
                f /= a;
            }
            else if (n == 0)
            {
                a = Convert.ToDecimal(textBox2.Text);
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '÷')
                    {
                        break;
                    }
                    else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                    {
                        textBox2.Clear();
                        break;
                    }
                }
                textBox1.Text += textBox2.Text + "÷";
                textBox2.Clear();
                if (f == 0)
                {
                    f = 1;
                    f = a / f;
                }
                else
                {
                    f /= a;
                }
            }
            else if (n == 1)
            {
                a = Convert.ToDecimal(textBox2.Text);
                for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                {
                    char w = textBox1.Text[i];
                    if (w == '×')
                    {
                        f *= a;
                        break;
                    }
                    else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                    {
                        textBox2.Clear();
                        f *= a;
                        break;
                    }
                }
                textBox1.Text += textBox2.Text + "÷";
                textBox2.Clear();
                if (f == 0 && m == 0)
                {
                    f = a;
                }
            }
        }
        #endregion


        #region Equals
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
                textBox2.Text = "0";
            }
            if (c == 0)
            {
                decimal b;
                if (textBox2.Text == "")
                {
                    string s = textBox1.Text;
                    textBox1.Clear();
                    for (int i = 0; i < s.Length - 1; i++)
                    {
                        char w = s[i];
                        textBox1.Text += w;
                    }
                    c = f;
                }
                else if (textBox2.Text != "" && f == 0 && m==2)
                {
                   //بودنش با نبودنش فرقی نمی کنه, باز حالا خودت میدونی اگه میخوای پاکش کنی
                   //ولی یه خوبی داره که عدد دیگه ای از کیبورد بزنی بعد مساوی بزنی اون رو پاکش می کنه
                   c = decimal.Parse(textBox2.Text);
                }
                else
                {
                    b = Convert.ToDecimal(textBox2.Text);
                    for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                    {
                        char w = textBox1.Text[i];
                        for (int j = textBox1.Text.Length - 1; j >= i; j--)
                        {
                            if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                            {
                                textBox2.Clear();
                                break;
                            }
                        }
                        if (w == '+')
                        {
                            textBox1.Text += textBox2.Text;
                            c = f + b;
                            break;
                        }
                        else if (w == '−')
                        {
                            textBox1.Text += textBox2.Text;
                            b = b * -1;
                            c = f + b;
                            break;
                        }
                        else if (w == '×')
                        {
                            textBox1.Text += textBox2.Text;
                            c = f * b;
                            break;
                        }
                        else if (w == '÷')
                        {
                            textBox1.Text += textBox2.Text;
                            c = f / b;
                            break;
                        }
                    }
                }
                textBox2.Text = Convert.ToString(c);
                f = 0;
                m = 2;
            }
            else if (c != 0)
            {
                textBox2.Text = Convert.ToString(c);
                f = 0;
            }
        }
        #endregion



        #region Clear
        private void button18_Click(object sender, EventArgs e)
        {
            c = 0;
            m = 0;
            f = 0;
            textBox1.Clear();
            textBox2.Clear();
        }
        #endregion
        
        #region CE
        private void button25_Click(object sender, EventArgs e)
        {
            if (m==2)
            {
                m = 0;
            }
            if (textBox1.Text == "")
            {
                textBox2.Clear();
            }
            for (int i = textBox1.Text.Length - 1; i >= 0; i--)
            {
                char w = textBox1.Text[i];
                if (w == '+' || w == '−' || w == '×' || w == '÷')
                {
                    textBox2.Clear();
                    break;
                }
                else if ((w == '√') || (w == '!') || (w == '^') || (w == 'π'))
                {
                    if (f == 0)
                    {
                        c = 0;
                        textBox1.Clear();
                        textBox2.Clear();
                        break;
                    }
                    else if (f != 0)
                    {
                        for (int t = textBox1.TextLength - 1; t >= 0; t--)
                        {
                            char q = textBox1.Text[t];
                            if (q == '+' || q == '−' || q == '×' || q == '÷')
                            {
                                string s = textBox1.Text;
                                textBox1.Clear();
                                for (int u = 0; u <= t; u++)
                                {
                                    textBox1.Text += s[u];
                                }
                                textBox2.Clear();
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            if (c != 0 || ((m == 2) && (c == 0)))
            {
                c = 0;
                f = 0;
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        #endregion
        
        #region Backspace
        private void button17_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            if (textBox2.Text == "")
            {
            }
            else if (textBox2.Text != "")
            {
                if ((f == 0) && (m == 2))
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    c = 0;
                    m = 0;
                }
                else
                {
                    string s = textBox2.Text;
                    textBox2.Clear();
                    for (int i = 0; i < s.Length - 1; i++)
                    {
                        char w = s[i];
                        textBox2.Text += w;
                    }
                }
            }
        }
        #endregion

        #region Factorial
        private void button20_Click(object sender, EventArgs e)
        {
            int V=0;
            string s = textBox2.Text;
            for (int i = 0; i < s.Length - 1; i++)
            {
                char w = s[i];
                if (w=='.')
                {
                    textBox2.Text = "Invalid input‬";
                    V = 1;
                }
                
            }
            if (V == 0)
            {
                if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
                {
                    textBox2.Clear();
                }
                else if (textBox2.Text == "")
                {
                    textBox1.Text += "(0!)";
                    textBox2.Text = "1";
                }
                else if (Convert.ToInt32(textBox2.Text) < 0)
                {
                    textBox2.Text = "Invalid input‬";
                }
                else
                {
                    textBox1.Text += "(" + textBox2.Text + "!)";
                    BigInteger b = 1;
                    for (int i = Convert.ToInt32(textBox2.Text); i > 1; i--)
                    {
                        b = b * i;
                    }
                    textBox2.Clear();
                    textBox2.Text = Convert.ToString(b);
                }
            }
        }
        #endregion


        #region Negative
        private void button21_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            else if (textBox2.Text == "")
            {
                textBox2.Text = "Enter number";
            }
            else
            {
                textBox2.Text = Convert.ToString(Convert.ToDecimal(textBox2.Text) * -1);
            }
        }
        #endregion
        
        #region Percentage
        private void button23_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            else if (textBox2.Text == "")
            {
                textBox2.Text = "Enter number";
            }
            else if (Convert.ToDecimal(textBox2.Text) < 0)
            {
                textBox2.Text = "Invalid input‬";
            }
            else
            {
                f = 0;
                decimal a = Convert.ToDecimal(textBox2.Text);
                textBox1.Clear();
                textBox1.Text = textBox2.Text + "%" + "×";
                textBox2.Clear();
                f = a / 100;
            }
        }
        #endregion
        
        #region Radical
        private void button22_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            else if (textBox2.Text == "")
            {
                textBox2.Text = "Enter number";
            }
            else
            {
                Form3 E = new Form3(this);
                E.ShowDialog();
                if (E.textBox2.Text == "")
                {
                    E.textBox2.Text = "2";
                }
                textBox1.Text += E.textBox2.Text + "^√(" + this.textBox2.Text + ")";
                double R = Math.Pow(Convert.ToDouble(this.textBox2.Text), 1/Convert.ToDouble(E.textBox2.Text));
                if (Convert.ToString(R) == "NaN")
                {
                    R = 0;
                }
                textBox2.Text = Convert.ToString(R);
            }
        }
        #endregion

        #region Power
        private void button24_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "Invalid input‬") || (textBox2.Text == "Enter number") || (textBox2.Text == "ناعدد") || (textBox2.Text == "NaN"))
            {
                textBox2.Clear();
            }
            else if (textBox2.Text == "")
            {
                textBox2.Text = "Enter number";
            }
            else
            {
                Form2 F2 = new Form2(this);
                F2.ShowDialog();
                if (F2.textBox2.Text == "")
                {
                    F2.textBox2.Text = "0";
                }
                if (F2.label1.Text == "0" && label1.Text == "0" && double.Parse(F2.textBox2.Text) >= 0)
                {
                    BigInteger P1, P2 = BigInteger.Parse(this.textBox2.Text);
                    int P3 = Int32.Parse(F2.textBox2.Text);
                    P1 = BigInteger.Pow(P2,P3);
                    textBox1.Text += "(" + textBox2.Text + ")^" + F2.textBox2.Text;
                    textBox2.Clear();
                    textBox2.Text = Convert.ToString(P1);
                }
                else
                {
                    double S = 0.0, D = Convert.ToDouble(textBox2.Text), B = Convert.ToDouble(F2.textBox2.Text);
                    if (B < 0)
                    {
                        D = 1 / D;
                        B *= -1;
                    }
                    S = Math.Pow(D, B);
                    textBox1.Text += "(" + textBox2.Text + ")^" + F2.textBox2.Text;
                    textBox2.Clear();
                    if (Convert.ToString(S)=="NaN")
                    {
                        S = 0;
                    }
                    textBox2.Text = Convert.ToString(S);
                }
            }
        }
        #endregion

        #region Others
        private void textBox2_TextChanged(object sender, EventArgs e)
        {  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
