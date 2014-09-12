using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Castle
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }
        SoundPlayer pl = new SoundPlayer(@"C:\Users\George\Documents\Visual Studio 2013\Music\The More I Want.wav");
        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Text = "Κλείσιμο Ραδιοφώνου";
                pl.Play();
            }
            else
            {
                checkBox1.Text = "Άνοιγμα Ραδιοφώνου";
                pl.Stop();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                checkBox2.Text = "Κλείσιμο Φώτων";
                this.BackgroundImage = Castle.Properties.Resources.bedroom2;
            }
            else
            {
                checkBox2.Text = "Άνοιγμα Φώτων";
                this.BackgroundImage = Castle.Properties.Resources.bedroom;
            }
        }
    }
}
 