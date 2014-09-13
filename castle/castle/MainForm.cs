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
            InitializeComponent();
            // Για να επιλεχθεί το τελευαίο tab στην Form
            tabControl.SelectedTab = tabPageExit;
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

        // http://www.dotnetcurry.com/showarticle.aspx?ID=174
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

            //Δεν αλλάζει γλώσσα ο τίτλος της φόρμας. Ή να το φιτάξω ή να το διαγράψω ...
        }
    }
}
