using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castle
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox8.Checked)
            {
                sum = sum + 5.50F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 5.50F;
                textBox2.Text = sum.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

            
            }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            float sum =  float.Parse(textBox2.Text);
            if (checkBox1.Checked)
            {
                sum = sum + 2.00F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 2.00F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox2.Checked)
            {
                sum = sum + 4.00F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 4.00F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox3.Checked)
            {
                sum = sum + 3.50F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 3.50F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox4.Checked)
            {
                sum = sum + 4.50F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 4.50F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox5.Checked)
            {
                sum = sum + 3.50F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 3.50F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox6.Checked)
            {
                sum = sum + 4.00F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 4.00F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox7.Checked)
            {
                sum = sum + 4.00F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 4.00F;
                textBox2.Text = sum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox9.Checked)
            {
                sum = sum + 2.00F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 2.00F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox10.Checked)
            {
                sum = sum + 3.00F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 3.00F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox11.Checked)
            {
                sum = sum + 6.00F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 6.00F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox12.Checked)
            {
                sum = sum + 4.50F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 4.50F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox13.Checked)
            {
                sum = sum + 6.50F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 6.50F;
                textBox2.Text = sum.ToString();
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(textBox2.Text);
            if (checkBox14.Checked)
            {
                sum = sum + 4.50F;
                textBox2.Text = sum.ToString();
            }
            else
            {
                sum = sum - 4.50F;
                textBox2.Text = sum.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            textBox2.Text = "0";
            groupBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Το σύνολο είναι " + textBox2.Text + " ευρώ. Θέλετε να συνεχίσετε;", "Ναι or Όχι", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Η κάρτα σας χρεώθηκε.");
                groupBox2.Visible = false;
                button2.Enabled = false;
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Ακύρωση παραγγελίας.");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                groupBox2.Visible = false;
                button2.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (float.Parse(textBox2.Text) > 0)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
        }
    }



