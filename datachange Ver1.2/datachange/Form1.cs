using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datachange
{
    public partial class Form1 : Form
    {

        int b = 1;
        int kb = 0;
        int mb = 0;
        int gb = 0;
        int tf = 0;
        int c = 1024;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;
            textBox1.Text = ("0");
            double a = Convert.ToDouble(textBox1.Text);

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void B_Click(object sender, EventArgs e)
        {

            textBox1.MaxLength = 10;
            b = 1;
            kb = 0;
            mb = 0;
            gb = 0;
            if (b == 1)
            {
                choosemode.Text = ("B");
            }
            else if (kb == 1)
            {
                choosemode.Text = ("KB");
            }
            else if (mb == 1)
            {
                choosemode.Text = ("MB");
            }
            else if (gb == 1)
            {
                choosemode.Text = ("GB");
            }
        }

        private void kB_Click(object sender, EventArgs e)
        {
            textBox1.MaxLength = 8;
            b = 0;
            kb = 1;
            mb = 0;
            gb = 0;
            if (b == 1)
            {
                choosemode.Text = ("B");
            }
            else if (kb == 1)
            {
                choosemode.Text = ("KB");
            }
            else if (mb == 1)
            {
                choosemode.Text = ("MB");
            }
            else if (gb == 1)
            {
                choosemode.Text = ("GB");
            }
        }

        private void MB_Click(object sender, EventArgs e)
        {
            textBox1.MaxLength = 6;
            b = 0;
            kb = 0;
            mb = 1;
            gb = 0;
            if (b == 1)
            {
                choosemode.Text = ("B");
            }
            else if (kb == 1)
            {
                choosemode.Text = ("KB");
            }
            else if (mb == 1)
            {
                choosemode.Text = ("MB");
            }
            else if (gb == 1)
            {
                choosemode.Text = ("GB");
            }
        }

        private void GB_Click(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;
            b = 0;
            kb = 0;
            mb = 0;
            gb = 1;
            if (b == 1)
            {
                choosemode.Text = ("B");
            }
            else if (kb == 1)
            {
                choosemode.Text = ("KB");
            }
            else if (mb == 1)
            {
                choosemode.Text = ("MB");
            }
            else if (gb == 1)
            {
                choosemode.Text = ("GB");
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                if (b == 1)
                {

                    b1.Text = String.Format("{0:0}", a);
                    a /= c;
                    kb1.Text = String.Format("{0:0.00000}", a);
                    a /= c;
                    mb1.Text = String.Format("{0:0.00000}", a);
                    a /= c;
                    gb1.Text = String.Format("{0:0.00000}", a);
                    a /= c;
                    tb1.Text = String.Format("{0:0.00000}", a);
                    a = 0;
                }
                if (kb == 1)
                {
                    if (textBox1.Text.Length < 9)
                    {
                        a *= c;
                        b1.Text = string.Format("{0:0}", a);
                        a /= c;
                        kb1.Text = string.Format("{0:0.00000}", a);
                        a /= c;
                        mb1.Text = String.Format("{0:0.00000}", a);
                        a /= c;
                        gb1.Text = String.Format("{0:0.00000}", a);
                        a /= c;
                        tb1.Text = String.Format("{0:0.00000}", a);
                        a = 0;
                    }
                    else
                    {
                        MessageBox.Show("1～99999999の値を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (mb == 1)
                {
                    if (textBox1.Text.Length < 7)
                    {
                        a = a * c * c;
                        b1.Text = String.Format("{0:0}", a);
                        a = a / c;
                        kb1.Text = string.Format("{0:0.00000}", a);
                        a /= c;
                        mb1.Text = String.Format("{0:0.00000}", a);
                        a /= c;
                        gb1.Text = String.Format("{0:0.00000}", a);
                        a /= c;
                        tb1.Text = String.Format("{0:0.00000}", a);
                        a = 0;
                    }
                    else
                    {
                        MessageBox.Show("1～999999の値を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (gb == 1)
                {
                    if(textBox1.Text.Length < 5)
                    {
                        a = a * c * c * c;
                        b1.Text = String.Format("{0:0}", a);
                        a = a / c;
                        kb1.Text = string.Format("{0:0.00000}", a);
                        a /= c;
                        mb1.Text = String.Format("{0:0.00000}", a);
                        a /= c;
                        gb1.Text = String.Format("{0:0.00000}", a);
                        a /= c;
                        tb1.Text = String.Format("{0:0.00000}", a);
                        a = 0;
                    }
                    else
                    {
                        MessageBox.Show("1～9999の値を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("正しく入力してください","エラー",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;
            textBox1.Text = ("0");
            b1.Text = String.Format("0", b1);
            kb1.Text = String.Format("0", b1);
            mb1.Text = String.Format("0", b1);
            gb1.Text = String.Format("0", b1);
            tb1.Text = String.Format("0", b1);
            textBox1.Text = ("0");
            choosemode.Text = ("B");
        }

        private void b1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            c = 1000;
            ba.Text = "1000倍";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            c = 1024;
            ba.Text = "1024倍";
        }

        private void 終了するEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void データ容量変換器Ver12についてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

    }

}

  

