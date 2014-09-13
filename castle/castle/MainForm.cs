using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Globalization;

namespace Castle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("el");
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("el");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("el");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("el");
            //this.Refresh();
            //this.labelWelcome.Refresh();

            changeLanguage("el");

            //Application.Run(new LanguageMenu(new System.Globalization.CultureInfo("el")));
            //Application.ExitThread();
        }

        private void changeLanguage(string lang)
        {
            foreach (Control c in this.tabControl.SelectedTab.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                Console.WriteLine(c.Name);
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void buttonLanguageGreek_Click(object sender, EventArgs e)
        {
            CultureInfo lang = new CultureInfo("el");
            changeLanguage(lang);
        }

        private void buttonLanguageEnglish_Click(object sender, EventArgs e)
        {
            CultureInfo lang = new CultureInfo("en");
            changeLanguage(lang);
        }

        private void changeLanguage (CultureInfo new_lang)
        {
            Thread.CurrentThread.CurrentCulture = new_lang;
            Thread.CurrentThread.CurrentUICulture = new_lang;

            foreach (TabPage tab in this.tabControl.TabPages)
            {
                var controls = tab.Controls;

                foreach (Control c in controls)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                    resources.ApplyResources(c, c.Name, new_lang);
                }
            }
                
        }


    }
}
