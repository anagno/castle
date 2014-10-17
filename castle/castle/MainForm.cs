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
using System.Resources;

namespace Castle
{
    public partial class MainForm : Form
    {
        private ChangeColor colors = new ChangeColor();

        // Music Player variable. Για να μην έχουμε απόλυτα μονοπάτια θα πρέπει να προστίθενται
        // οι τυχόν επιλογές στο Resources.resx
        private System.Media.SoundPlayer music_player = new System.Media.SoundPlayer(Castle.Properties.Resources.song);

        public MainForm()
        {
            InitializeComponent();

            // Για να επιλεχθεί το τελευαίο tab στην Form
            tabControl.SelectedTab = tabPageExit;
            buttonMenuPayment.Enabled = Enabled;

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
        private void changeLanguage(CultureInfo new_lang)
        {
            Thread.CurrentThread.CurrentCulture = new_lang;
            Thread.CurrentThread.CurrentUICulture = new_lang;

            // Για την μετάφραση μέσα στα tabs
            foreach (TabPage tab in this.tabControl.TabPages)
            {
                var controls = tab.Controls;

                foreach (Control c in controls)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                    resources.ApplyResources(c, c.Name, new_lang);
                }
            }

            // Για την μετάφραση των κειμένων μέσα στο μενού

            foreach (Control c in this.tabControlMenu.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                resources.ApplyResources(c, c.Name, new_lang);
            }

            foreach (TabPage tab in this.tabControlMenu.TabPages)
            {
                var controls = tab.Controls;

                foreach (Control c in controls)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                    resources.ApplyResources(c, c.Name, new_lang);
                }
            }

            foreach (Control c in groupBoxMenuFood.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                resources.ApplyResources(c, c.Name, new_lang);
            }

            foreach (Control c in groupBoxMenuDrinks.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                resources.ApplyResources(c, c.Name, new_lang);
            }

            // Για να βάλουμε σωστά την τιμή της θερμοκρασίας όταν αλλάζουμε την γλώσσα.
            labelRoomDevicesTemperatureValue.Text = trackBarTemperature.Value.ToString() + " C";
            labelPoolDevicesTemperatureValue.Text = trackBarPoolTemerature.Value.ToString() + " C";
            labelPoolDevicesLevelValue.Text = trackBarPoolLevel.Value.ToString() + " M";


            buttonMenuPayment.Enabled = Enabled;

            //Δεν αλλάζει γλώσσα ο τίτλος της φόρμας. Ή να το φιτάξω ή να το διαγράψω ...
        }

        private void trackBarLights_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBarLights.Value)
            {
                case 0:
                    this.tabControl.SelectedTab.BackgroundImage = Castle.Properties.Resources.bedroom2;
                    break;
                case 1:
                    this.tabControl.SelectedTab.BackgroundImage = Castle.Properties.Resources.bedroom;
                    break;
            }
        }

        private void trackBarAlarm_ValueChanged(object sender, EventArgs e)
        {
            ResourceManager LocRM = new ResourceManager("Castle.Properties.strings", typeof(MainForm).Assembly);

            switch (trackBarAlarm.Value)
            {
                case 0:
                    MessageBox.Show(LocRM.GetString("trackBarAlarmDisable"));
                    break;
                case 1:
                    MessageBox.Show(LocRM.GetString("trackBarAlarmEnable"));
                    break;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            music_player.Play();
        }

        private void buttonStop_Click_1(object sender, EventArgs e)
        {
            music_player.Stop();
        }

        private void trackBarTemperature_ValueChanged(object sender, EventArgs e)
        {
            labelRoomDevicesTemperatureValue.Text = trackBarTemperature.Value.ToString() + " C";
        }

        private void trackBarDoor_ValueChanged(object sender, EventArgs e)
        {
            ResourceManager LocRM = new ResourceManager("Castle.Properties.strings", typeof(MainForm).Assembly);

            switch (trackBarDoor.Value)
            {
                case 0:
                    MessageBox.Show(LocRM.GetString("trackBarDoorClose"));
                    break;
                case 1:
                    MessageBox.Show(LocRM.GetString("trackBarDoorOpen"));
                    break;
            }

        }

        private void changeSumFood(CheckBox check_box, float value)
        {
            float sum = float.Parse(textBoxMenuTotal.Text);
            if (check_box.Checked)
            {
                sum = sum + value;
                textBoxMenuTotal.Text = sum.ToString();
            }
            else
            {
                sum = sum - value;
                textBoxMenuTotal.Text = sum.ToString();
            }
        }

        private void checkBoxMenuFoodGreek_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodGreek, 9.00F);
        }

        private void checkBoxMenuFoodCaesar_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodCaesar, 11.00F);
        }

        private void checkBoxMenuFoodExotic_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodExotic, 12.50F);
        }

        private void checkBoxMenuFoodTsigarilos_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodTsigarilos, 13.00F);
        }

        private void checkBoxMenuFoodMuffin_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodMuffin, 7.50F);
        }

        private void checkBoxMenuFoodCanneloni_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodCanneloni, 8.50F);
        }

        private void checkBoxMenuFoodChops_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodChops, 20.00F);
        }

        private void checkBoxMenuFoodRibEye_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodRibEye, 31.00F);
        }

        private void checkBoxMenuFoodRisotto_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodRisotto, 13.50F);
        }

        private void checkBoxMenuFoodCarbonara_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodCarbonara, 16.00F);
        }

        private void checkBoxMenuFoodProfiterol_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodProfiterol, 10.00F);
        }

        private void checkBoxMenuFoodCheececake_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuFoodCheececake, 10.00F);
        }

        private void checkBoxMenuDrinksGreek_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuDrinksGreek, 2.00F);
        }

        private void checkBoxMenuDrinksEspresso_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuDrinksEspresso, 2.00F);
        }

        private void checkBoxMenuDrinksCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuDrinksCappuccino, 3.50F);
        }

        private void checkBoxMenuDrinksJuice_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuDrinksJuice, 5.00F);
        }

        private void checkBoxMenuDrinksBeer_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuDrinksBeer, 5.00F);
        }

        private void checkBoxMenuDrinksVodka_CheckedChanged(object sender, EventArgs e)
        {
            changeSumFood(checkBoxMenuDrinksVodka, 6.00F);
        }

        private void cancelOrder ()
        {
            checkBoxMenuDrinksBeer.Checked = false;
            checkBoxMenuDrinksCappuccino.Checked = false;
            checkBoxMenuDrinksEspresso.Checked = false;
            checkBoxMenuDrinksGreek.Checked = false;
            checkBoxMenuDrinksJuice.Checked = false;
            checkBoxMenuDrinksVodka.Checked = false;
            checkBoxMenuFoodCaesar.Checked = false;
            checkBoxMenuFoodCanneloni.Checked = false;
            checkBoxMenuFoodCarbonara.Checked = false;
            checkBoxMenuFoodCheececake.Checked = false;
            checkBoxMenuFoodChops.Checked = false;
            checkBoxMenuFoodExotic.Checked = false;
            checkBoxMenuFoodGreek.Checked = false;
            checkBoxMenuFoodMuffin.Checked = false;
            checkBoxMenuFoodProfiterol.Checked = false;
            checkBoxMenuFoodRibEye.Checked = false;
            checkBoxMenuFoodRisotto.Checked = false;
            checkBoxMenuFoodTsigarilos.Checked = false;

            textBoxMenuTotal.Text = "0";
        }

        private void buttonMenuCancel_Click(object sender, EventArgs e)
        {
            cancelOrder();
        }         

        private void buttonMenuPayment_Click(object sender, EventArgs e)
        {
            ResourceManager LocRM = new ResourceManager("Castle.Properties.strings", typeof(MainForm).Assembly);
            if(float.Parse(textBoxMenuTotal.Text)!=0)
            {
                DialogResult result = MessageBox.Show(LocRM.GetString("buttonMenuPayment") + textBoxMenuTotal.Text + LocRM.GetString("buttonMenuPayment2"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(LocRM.GetString("buttonMenuPaymentCard"));
                    cancelOrder();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show(LocRM.GetString("buttonMenuPaymentCancel"));
                    cancelOrder();
                }
            }
            else
            {
                MessageBox.Show(LocRM.GetString("buttonMenuPaymentEmpty"));
            }


        }

        private void trackBarPoolTemerature_ValueChanged(object sender, EventArgs e)
        {
            labelPoolDevicesTemperatureValue.Text = trackBarPoolTemerature.Value.ToString() + " C";
        }

        private void trackBarPoolLevel_ValueChanged(object sender, EventArgs e)
        {
            labelPoolDevicesLevelValue.Text = trackBarPoolLevel.Value.ToString() + " M";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelWelcome.ForeColor = colors.returnColor();
            labelRoomDevices.ForeColor = colors.returnColor();
            labelPoolDevices.ForeColor = colors.returnColor();
            colors.changeColor();
        }

        private void trackBarPoolAlarm_ValueChanged(object sender, EventArgs e)
        {
            ResourceManager LocRM = new ResourceManager("Castle.Properties.strings", typeof(MainForm).Assembly);

            switch (trackBarPoolAlarm.Value)
            {
                case 0:
                    MessageBox.Show(LocRM.GetString("PoolAlarmDisable"));
                    break;
                case 1:
                    MessageBox.Show(LocRM.GetString("PoolAlarmEnable"));
                    break;
            }
        }

        private void trackBarPoolDoor_ValueChanged(object sender, EventArgs e)
        {
            ResourceManager LocRM = new ResourceManager("Castle.Properties.strings", typeof(MainForm).Assembly);

            switch (trackBarPoolDoor.Value)
            {
                case 0:
                    MessageBox.Show(LocRM.GetString("trackBarDoorClose"));
                    break;
                case 1:
                    MessageBox.Show(LocRM.GetString("trackBarDoorOpen"));
                    break;
            }

        }

        private void buttonExitHelp_Click(object sender, EventArgs e)
        {
            Help_menu hm = new Help_menu();
            hm.Show();
        }

        private void buttonDeviceHelp_Click(object sender, EventArgs e)
        {
            Bedroom_Help bh = new Bedroom_Help();
            bh.Show();
        }

        private void buttonDrinkHelp_Click(object sender, EventArgs e)
        {
            Help_for_cafe_restaurant hrc = new Help_for_cafe_restaurant();
            hrc.Show();
        }

        private void buttonPoolHelp_Click(object sender, EventArgs e)
        {
            Help_for_pool hfp = new Help_for_pool();
            hfp.Show();
        }

        private void trackBarPoolDoor_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonFoodHelp_Click(object sender, EventArgs e)
        {
            Help_for_cafe_restaurant hcr = new Help_for_cafe_restaurant();
            hcr.Show();
        }

    }
}
