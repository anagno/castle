namespace Castle
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePool = new System.Windows.Forms.TabPage();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.buttonMenuPayment = new System.Windows.Forms.Button();
            this.buttonMenuCancel = new System.Windows.Forms.Button();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageRestaurant = new System.Windows.Forms.TabPage();
            this.groupBoxMenuFood = new System.Windows.Forms.GroupBox();
            this.checkBoxMenuFoodCheececake = new System.Windows.Forms.CheckBox();
            this.labelMenuFoodSweet = new System.Windows.Forms.Label();
            this.checkBoxMenuFoodProfiterol = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuFoodCarbonara = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuFoodCanneloni = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuFoodRisotto = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuFoodRibEye = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuFoodChops = new System.Windows.Forms.CheckBox();
            this.labelMenuFoodMainCourse = new System.Windows.Forms.Label();
            this.checkBoxMenuFoodMuffin = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuFoodTsigarilos = new System.Windows.Forms.CheckBox();
            this.labelMenuFoodAppetizers = new System.Windows.Forms.Label();
            this.checkBoxMenuFoodExotic = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuFoodCaesar = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuFoodGreek = new System.Windows.Forms.CheckBox();
            this.labelMenuFoodSalads = new System.Windows.Forms.Label();
            this.tabPageCafeteria = new System.Windows.Forms.TabPage();
            this.groupBoxMenuDrinks = new System.Windows.Forms.GroupBox();
            this.checkBoxMenuDrinksJuice = new System.Windows.Forms.CheckBox();
            this.labelMenuFoodOther = new System.Windows.Forms.Label();
            this.checkBoxMenuDrinksVodka = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuDrinksBeer = new System.Windows.Forms.CheckBox();
            this.labelMenuFoodAlcoholic = new System.Windows.Forms.Label();
            this.checkBoxMenuDrinksCappuccino = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuDrinksEspresso = new System.Windows.Forms.CheckBox();
            this.checkBoxMenuDrinksGreek = new System.Windows.Forms.CheckBox();
            this.labelMenuFoodCoffee = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.textBoxMenuTotal = new System.Windows.Forms.TextBox();
            this.labelMenuTotal = new System.Windows.Forms.Label();
            this.tabPageDevices = new System.Windows.Forms.TabPage();
            this.trackBarDoor = new System.Windows.Forms.TrackBar();
            this.labelRoomDevicesTemperatureValue = new System.Windows.Forms.Label();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.labelRoomDevicesDoor = new System.Windows.Forms.Label();
            this.labelRoomDevicesTemperature = new System.Windows.Forms.Label();
            this.labelRoomDevicesRadio = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelRoomDevicesAlarm = new System.Windows.Forms.Label();
            this.trackBarAlarm = new System.Windows.Forms.TrackBar();
            this.labelRoomDevicesON = new System.Windows.Forms.Label();
            this.labelRoomDevicesOFF = new System.Windows.Forms.Label();
            this.labelRoomDevicesLights = new System.Windows.Forms.Label();
            this.trackBarLights = new System.Windows.Forms.TrackBar();
            this.labelRoomDevices = new System.Windows.Forms.Label();
            this.tabPageExit = new System.Windows.Forms.TabPage();
            this.labelDescritptionPool = new System.Windows.Forms.Label();
            this.labelDescritpionExit = new System.Windows.Forms.Label();
            this.labelDescriptionRoomDevices = new System.Windows.Forms.Label();
            this.labelDescritpionMenu = new System.Windows.Forms.Label();
            this.buttonLanguageEnglish = new System.Windows.Forms.Button();
            this.buttonLanguageGreek = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabPageRestaurant.SuspendLayout();
            this.groupBoxMenuFood.SuspendLayout();
            this.tabPageCafeteria.SuspendLayout();
            this.groupBoxMenuDrinks.SuspendLayout();
            this.tabPageDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLights)).BeginInit();
            this.tabPageExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPagePool);
            this.tabControl.Controls.Add(this.tabPageMenu);
            this.tabControl.Controls.Add(this.tabPageDevices);
            this.tabControl.Controls.Add(this.tabPageExit);
            this.tabControl.ImageList = this.imageList;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPagePool
            // 
            this.tabPagePool.BackgroundImage = global::Castle.Properties.Resources.castle_5;
            resources.ApplyResources(this.tabPagePool, "tabPagePool");
            this.tabPagePool.Name = "tabPagePool";
            this.tabPagePool.UseVisualStyleBackColor = true;
            // 
            // tabPageMenu
            // 
            resources.ApplyResources(this.tabPageMenu, "tabPageMenu");
            this.tabPageMenu.Controls.Add(this.buttonMenuPayment);
            this.tabPageMenu.Controls.Add(this.buttonMenuCancel);
            this.tabPageMenu.Controls.Add(this.tabControlMenu);
            this.tabPageMenu.Controls.Add(this.textBoxMenuTotal);
            this.tabPageMenu.Controls.Add(this.labelMenuTotal);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.UseVisualStyleBackColor = true;
            // 
            // buttonMenuPayment
            // 
            resources.ApplyResources(this.buttonMenuPayment, "buttonMenuPayment");
            this.buttonMenuPayment.Name = "buttonMenuPayment";
            this.buttonMenuPayment.UseVisualStyleBackColor = true;
            this.buttonMenuPayment.Click += new System.EventHandler(this.buttonMenuPayment_Click);
            // 
            // buttonMenuCancel
            // 
            resources.ApplyResources(this.buttonMenuCancel, "buttonMenuCancel");
            this.buttonMenuCancel.Name = "buttonMenuCancel";
            this.buttonMenuCancel.UseVisualStyleBackColor = true;
            this.buttonMenuCancel.Click += new System.EventHandler(this.buttonMenuCancel_Click);
            // 
            // tabControlMenu
            // 
            resources.ApplyResources(this.tabControlMenu, "tabControlMenu");
            this.tabControlMenu.AllowDrop = true;
            this.tabControlMenu.Controls.Add(this.tabPageRestaurant);
            this.tabControlMenu.Controls.Add(this.tabPageCafeteria);
            this.tabControlMenu.ImageList = this.imageList;
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            // 
            // tabPageRestaurant
            // 
            this.tabPageRestaurant.BackgroundImage = global::Castle.Properties.Resources.size1;
            resources.ApplyResources(this.tabPageRestaurant, "tabPageRestaurant");
            this.tabPageRestaurant.Controls.Add(this.groupBoxMenuFood);
            this.tabPageRestaurant.Name = "tabPageRestaurant";
            this.tabPageRestaurant.UseVisualStyleBackColor = true;
            // 
            // groupBoxMenuFood
            // 
            this.groupBoxMenuFood.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodCheececake);
            this.groupBoxMenuFood.Controls.Add(this.labelMenuFoodSweet);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodProfiterol);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodCarbonara);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodCanneloni);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodRisotto);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodRibEye);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodChops);
            this.groupBoxMenuFood.Controls.Add(this.labelMenuFoodMainCourse);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodMuffin);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodTsigarilos);
            this.groupBoxMenuFood.Controls.Add(this.labelMenuFoodAppetizers);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodExotic);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodCaesar);
            this.groupBoxMenuFood.Controls.Add(this.checkBoxMenuFoodGreek);
            this.groupBoxMenuFood.Controls.Add(this.labelMenuFoodSalads);
            resources.ApplyResources(this.groupBoxMenuFood, "groupBoxMenuFood");
            this.groupBoxMenuFood.Name = "groupBoxMenuFood";
            this.groupBoxMenuFood.TabStop = false;
            // 
            // checkBoxMenuFoodCheececake
            // 
            resources.ApplyResources(this.checkBoxMenuFoodCheececake, "checkBoxMenuFoodCheececake");
            this.checkBoxMenuFoodCheececake.Name = "checkBoxMenuFoodCheececake";
            this.checkBoxMenuFoodCheececake.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodCheececake.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodCheececake_CheckedChanged);
            // 
            // labelMenuFoodSweet
            // 
            resources.ApplyResources(this.labelMenuFoodSweet, "labelMenuFoodSweet");
            this.labelMenuFoodSweet.Name = "labelMenuFoodSweet";
            // 
            // checkBoxMenuFoodProfiterol
            // 
            resources.ApplyResources(this.checkBoxMenuFoodProfiterol, "checkBoxMenuFoodProfiterol");
            this.checkBoxMenuFoodProfiterol.Name = "checkBoxMenuFoodProfiterol";
            this.checkBoxMenuFoodProfiterol.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodProfiterol.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodProfiterol_CheckedChanged);
            // 
            // checkBoxMenuFoodCarbonara
            // 
            resources.ApplyResources(this.checkBoxMenuFoodCarbonara, "checkBoxMenuFoodCarbonara");
            this.checkBoxMenuFoodCarbonara.Name = "checkBoxMenuFoodCarbonara";
            this.checkBoxMenuFoodCarbonara.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodCarbonara.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodCarbonara_CheckedChanged);
            // 
            // checkBoxMenuFoodCanneloni
            // 
            resources.ApplyResources(this.checkBoxMenuFoodCanneloni, "checkBoxMenuFoodCanneloni");
            this.checkBoxMenuFoodCanneloni.Name = "checkBoxMenuFoodCanneloni";
            this.checkBoxMenuFoodCanneloni.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodCanneloni.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodCanneloni_CheckedChanged);
            // 
            // checkBoxMenuFoodRisotto
            // 
            resources.ApplyResources(this.checkBoxMenuFoodRisotto, "checkBoxMenuFoodRisotto");
            this.checkBoxMenuFoodRisotto.Name = "checkBoxMenuFoodRisotto";
            this.checkBoxMenuFoodRisotto.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodRisotto.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodRisotto_CheckedChanged);
            // 
            // checkBoxMenuFoodRibEye
            // 
            resources.ApplyResources(this.checkBoxMenuFoodRibEye, "checkBoxMenuFoodRibEye");
            this.checkBoxMenuFoodRibEye.Name = "checkBoxMenuFoodRibEye";
            this.checkBoxMenuFoodRibEye.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodRibEye.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodRibEye_CheckedChanged);
            // 
            // checkBoxMenuFoodChops
            // 
            resources.ApplyResources(this.checkBoxMenuFoodChops, "checkBoxMenuFoodChops");
            this.checkBoxMenuFoodChops.Name = "checkBoxMenuFoodChops";
            this.checkBoxMenuFoodChops.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodChops.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodChops_CheckedChanged);
            // 
            // labelMenuFoodMainCourse
            // 
            resources.ApplyResources(this.labelMenuFoodMainCourse, "labelMenuFoodMainCourse");
            this.labelMenuFoodMainCourse.Name = "labelMenuFoodMainCourse";
            // 
            // checkBoxMenuFoodMuffin
            // 
            resources.ApplyResources(this.checkBoxMenuFoodMuffin, "checkBoxMenuFoodMuffin");
            this.checkBoxMenuFoodMuffin.Name = "checkBoxMenuFoodMuffin";
            this.checkBoxMenuFoodMuffin.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodMuffin.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodMuffin_CheckedChanged);
            // 
            // checkBoxMenuFoodTsigarilos
            // 
            resources.ApplyResources(this.checkBoxMenuFoodTsigarilos, "checkBoxMenuFoodTsigarilos");
            this.checkBoxMenuFoodTsigarilos.Name = "checkBoxMenuFoodTsigarilos";
            this.checkBoxMenuFoodTsigarilos.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodTsigarilos.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodTsigarilos_CheckedChanged);
            // 
            // labelMenuFoodAppetizers
            // 
            resources.ApplyResources(this.labelMenuFoodAppetizers, "labelMenuFoodAppetizers");
            this.labelMenuFoodAppetizers.Name = "labelMenuFoodAppetizers";
            // 
            // checkBoxMenuFoodExotic
            // 
            resources.ApplyResources(this.checkBoxMenuFoodExotic, "checkBoxMenuFoodExotic");
            this.checkBoxMenuFoodExotic.Name = "checkBoxMenuFoodExotic";
            this.checkBoxMenuFoodExotic.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodExotic.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodExotic_CheckedChanged);
            // 
            // checkBoxMenuFoodCaesar
            // 
            resources.ApplyResources(this.checkBoxMenuFoodCaesar, "checkBoxMenuFoodCaesar");
            this.checkBoxMenuFoodCaesar.Name = "checkBoxMenuFoodCaesar";
            this.checkBoxMenuFoodCaesar.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodCaesar.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodCaesar_CheckedChanged);
            // 
            // checkBoxMenuFoodGreek
            // 
            resources.ApplyResources(this.checkBoxMenuFoodGreek, "checkBoxMenuFoodGreek");
            this.checkBoxMenuFoodGreek.Name = "checkBoxMenuFoodGreek";
            this.checkBoxMenuFoodGreek.UseVisualStyleBackColor = true;
            this.checkBoxMenuFoodGreek.CheckedChanged += new System.EventHandler(this.checkBoxMenuFoodGreek_CheckedChanged);
            // 
            // labelMenuFoodSalads
            // 
            resources.ApplyResources(this.labelMenuFoodSalads, "labelMenuFoodSalads");
            this.labelMenuFoodSalads.Name = "labelMenuFoodSalads";
            // 
            // tabPageCafeteria
            // 
            this.tabPageCafeteria.BackgroundImage = global::Castle.Properties.Resources.villecroze_cafe_provence;
            resources.ApplyResources(this.tabPageCafeteria, "tabPageCafeteria");
            this.tabPageCafeteria.Controls.Add(this.groupBoxMenuDrinks);
            this.tabPageCafeteria.Name = "tabPageCafeteria";
            this.tabPageCafeteria.UseVisualStyleBackColor = true;
            // 
            // groupBoxMenuDrinks
            // 
            this.groupBoxMenuDrinks.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMenuDrinks.Controls.Add(this.checkBoxMenuDrinksJuice);
            this.groupBoxMenuDrinks.Controls.Add(this.labelMenuFoodOther);
            this.groupBoxMenuDrinks.Controls.Add(this.checkBoxMenuDrinksVodka);
            this.groupBoxMenuDrinks.Controls.Add(this.checkBoxMenuDrinksBeer);
            this.groupBoxMenuDrinks.Controls.Add(this.labelMenuFoodAlcoholic);
            this.groupBoxMenuDrinks.Controls.Add(this.checkBoxMenuDrinksCappuccino);
            this.groupBoxMenuDrinks.Controls.Add(this.checkBoxMenuDrinksEspresso);
            this.groupBoxMenuDrinks.Controls.Add(this.checkBoxMenuDrinksGreek);
            this.groupBoxMenuDrinks.Controls.Add(this.labelMenuFoodCoffee);
            resources.ApplyResources(this.groupBoxMenuDrinks, "groupBoxMenuDrinks");
            this.groupBoxMenuDrinks.Name = "groupBoxMenuDrinks";
            this.groupBoxMenuDrinks.TabStop = false;
            // 
            // checkBoxMenuDrinksJuice
            // 
            resources.ApplyResources(this.checkBoxMenuDrinksJuice, "checkBoxMenuDrinksJuice");
            this.checkBoxMenuDrinksJuice.Name = "checkBoxMenuDrinksJuice";
            this.checkBoxMenuDrinksJuice.UseVisualStyleBackColor = true;
            this.checkBoxMenuDrinksJuice.CheckedChanged += new System.EventHandler(this.checkBoxMenuDrinksJuice_CheckedChanged);
            // 
            // labelMenuFoodOther
            // 
            resources.ApplyResources(this.labelMenuFoodOther, "labelMenuFoodOther");
            this.labelMenuFoodOther.Name = "labelMenuFoodOther";
            // 
            // checkBoxMenuDrinksVodka
            // 
            resources.ApplyResources(this.checkBoxMenuDrinksVodka, "checkBoxMenuDrinksVodka");
            this.checkBoxMenuDrinksVodka.Name = "checkBoxMenuDrinksVodka";
            this.checkBoxMenuDrinksVodka.UseVisualStyleBackColor = true;
            this.checkBoxMenuDrinksVodka.CheckedChanged += new System.EventHandler(this.checkBoxMenuDrinksVodka_CheckedChanged);
            // 
            // checkBoxMenuDrinksBeer
            // 
            resources.ApplyResources(this.checkBoxMenuDrinksBeer, "checkBoxMenuDrinksBeer");
            this.checkBoxMenuDrinksBeer.Name = "checkBoxMenuDrinksBeer";
            this.checkBoxMenuDrinksBeer.UseVisualStyleBackColor = true;
            this.checkBoxMenuDrinksBeer.CheckedChanged += new System.EventHandler(this.checkBoxMenuDrinksBeer_CheckedChanged);
            // 
            // labelMenuFoodAlcoholic
            // 
            resources.ApplyResources(this.labelMenuFoodAlcoholic, "labelMenuFoodAlcoholic");
            this.labelMenuFoodAlcoholic.Name = "labelMenuFoodAlcoholic";
            // 
            // checkBoxMenuDrinksCappuccino
            // 
            resources.ApplyResources(this.checkBoxMenuDrinksCappuccino, "checkBoxMenuDrinksCappuccino");
            this.checkBoxMenuDrinksCappuccino.Name = "checkBoxMenuDrinksCappuccino";
            this.checkBoxMenuDrinksCappuccino.UseVisualStyleBackColor = true;
            this.checkBoxMenuDrinksCappuccino.CheckedChanged += new System.EventHandler(this.checkBoxMenuDrinksCappuccino_CheckedChanged);
            // 
            // checkBoxMenuDrinksEspresso
            // 
            resources.ApplyResources(this.checkBoxMenuDrinksEspresso, "checkBoxMenuDrinksEspresso");
            this.checkBoxMenuDrinksEspresso.Name = "checkBoxMenuDrinksEspresso";
            this.checkBoxMenuDrinksEspresso.UseVisualStyleBackColor = true;
            this.checkBoxMenuDrinksEspresso.CheckedChanged += new System.EventHandler(this.checkBoxMenuDrinksEspresso_CheckedChanged);
            // 
            // checkBoxMenuDrinksGreek
            // 
            resources.ApplyResources(this.checkBoxMenuDrinksGreek, "checkBoxMenuDrinksGreek");
            this.checkBoxMenuDrinksGreek.Name = "checkBoxMenuDrinksGreek";
            this.checkBoxMenuDrinksGreek.UseVisualStyleBackColor = true;
            this.checkBoxMenuDrinksGreek.CheckedChanged += new System.EventHandler(this.checkBoxMenuDrinksGreek_CheckedChanged);
            // 
            // labelMenuFoodCoffee
            // 
            resources.ApplyResources(this.labelMenuFoodCoffee, "labelMenuFoodCoffee");
            this.labelMenuFoodCoffee.Name = "labelMenuFoodCoffee";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "glass.png");
            // 
            // textBoxMenuTotal
            // 
            this.textBoxMenuTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxMenuTotal, "textBoxMenuTotal");
            this.textBoxMenuTotal.Name = "textBoxMenuTotal";
            this.textBoxMenuTotal.ReadOnly = true;
            // 
            // labelMenuTotal
            // 
            resources.ApplyResources(this.labelMenuTotal, "labelMenuTotal");
            this.labelMenuTotal.Name = "labelMenuTotal";
            // 
            // tabPageDevices
            // 
            this.tabPageDevices.BackgroundImage = global::Castle.Properties.Resources.bedroom;
            resources.ApplyResources(this.tabPageDevices, "tabPageDevices");
            this.tabPageDevices.Controls.Add(this.trackBarDoor);
            this.tabPageDevices.Controls.Add(this.labelRoomDevicesTemperatureValue);
            this.tabPageDevices.Controls.Add(this.trackBarTemperature);
            this.tabPageDevices.Controls.Add(this.labelRoomDevicesDoor);
            this.tabPageDevices.Controls.Add(this.labelRoomDevicesTemperature);
            this.tabPageDevices.Controls.Add(this.labelRoomDevicesRadio);
            this.tabPageDevices.Controls.Add(this.buttonStop);
            this.tabPageDevices.Controls.Add(this.buttonPlay);
            this.tabPageDevices.Controls.Add(this.labelRoomDevicesAlarm);
            this.tabPageDevices.Controls.Add(this.trackBarAlarm);
            this.tabPageDevices.Controls.Add(this.labelRoomDevicesON);
            this.tabPageDevices.Controls.Add(this.labelRoomDevicesOFF);
            this.tabPageDevices.Controls.Add(this.labelRoomDevicesLights);
            this.tabPageDevices.Controls.Add(this.trackBarLights);
            this.tabPageDevices.Controls.Add(this.labelRoomDevices);
            this.tabPageDevices.Name = "tabPageDevices";
            this.tabPageDevices.UseVisualStyleBackColor = true;
            // 
            // trackBarDoor
            // 
            resources.ApplyResources(this.trackBarDoor, "trackBarDoor");
            this.trackBarDoor.Maximum = 1;
            this.trackBarDoor.Name = "trackBarDoor";
            this.trackBarDoor.Value = 1;
            this.trackBarDoor.ValueChanged += new System.EventHandler(this.trackBarDoor_ValueChanged);
            // 
            // labelRoomDevicesTemperatureValue
            // 
            resources.ApplyResources(this.labelRoomDevicesTemperatureValue, "labelRoomDevicesTemperatureValue");
            this.labelRoomDevicesTemperatureValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevicesTemperatureValue.Name = "labelRoomDevicesTemperatureValue";
            // 
            // trackBarTemperature
            // 
            resources.ApplyResources(this.trackBarTemperature, "trackBarTemperature");
            this.trackBarTemperature.Maximum = 35;
            this.trackBarTemperature.Minimum = 14;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Value = 22;
            this.trackBarTemperature.ValueChanged += new System.EventHandler(this.trackBarTemperature_ValueChanged);
            // 
            // labelRoomDevicesDoor
            // 
            resources.ApplyResources(this.labelRoomDevicesDoor, "labelRoomDevicesDoor");
            this.labelRoomDevicesDoor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevicesDoor.Name = "labelRoomDevicesDoor";
            // 
            // labelRoomDevicesTemperature
            // 
            resources.ApplyResources(this.labelRoomDevicesTemperature, "labelRoomDevicesTemperature");
            this.labelRoomDevicesTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevicesTemperature.Name = "labelRoomDevicesTemperature";
            // 
            // labelRoomDevicesRadio
            // 
            resources.ApplyResources(this.labelRoomDevicesRadio, "labelRoomDevicesRadio");
            this.labelRoomDevicesRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevicesRadio.Name = "labelRoomDevicesRadio";
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::Castle.Properties.Resources.stop;
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click_1);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::Castle.Properties.Resources.play;
            resources.ApplyResources(this.buttonPlay, "buttonPlay");
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelRoomDevicesAlarm
            // 
            resources.ApplyResources(this.labelRoomDevicesAlarm, "labelRoomDevicesAlarm");
            this.labelRoomDevicesAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevicesAlarm.Name = "labelRoomDevicesAlarm";
            // 
            // trackBarAlarm
            // 
            resources.ApplyResources(this.trackBarAlarm, "trackBarAlarm");
            this.trackBarAlarm.Maximum = 1;
            this.trackBarAlarm.Name = "trackBarAlarm";
            this.trackBarAlarm.ValueChanged += new System.EventHandler(this.trackBarAlarm_ValueChanged);
            // 
            // labelRoomDevicesON
            // 
            resources.ApplyResources(this.labelRoomDevicesON, "labelRoomDevicesON");
            this.labelRoomDevicesON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevicesON.Name = "labelRoomDevicesON";
            // 
            // labelRoomDevicesOFF
            // 
            resources.ApplyResources(this.labelRoomDevicesOFF, "labelRoomDevicesOFF");
            this.labelRoomDevicesOFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevicesOFF.Name = "labelRoomDevicesOFF";
            // 
            // labelRoomDevicesLights
            // 
            resources.ApplyResources(this.labelRoomDevicesLights, "labelRoomDevicesLights");
            this.labelRoomDevicesLights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevicesLights.Name = "labelRoomDevicesLights";
            // 
            // trackBarLights
            // 
            resources.ApplyResources(this.trackBarLights, "trackBarLights");
            this.trackBarLights.Maximum = 1;
            this.trackBarLights.Name = "trackBarLights";
            this.trackBarLights.Value = 1;
            this.trackBarLights.ValueChanged += new System.EventHandler(this.trackBarLights_ValueChanged);
            // 
            // labelRoomDevices
            // 
            resources.ApplyResources(this.labelRoomDevices, "labelRoomDevices");
            this.labelRoomDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRoomDevices.Name = "labelRoomDevices";
            // 
            // tabPageExit
            // 
            resources.ApplyResources(this.tabPageExit, "tabPageExit");
            this.tabPageExit.BackgroundImage = global::Castle.Properties.Resources.castle_wallpaper_3;
            this.tabPageExit.Controls.Add(this.labelDescritptionPool);
            this.tabPageExit.Controls.Add(this.labelDescritpionExit);
            this.tabPageExit.Controls.Add(this.labelDescriptionRoomDevices);
            this.tabPageExit.Controls.Add(this.labelDescritpionMenu);
            this.tabPageExit.Controls.Add(this.buttonLanguageEnglish);
            this.tabPageExit.Controls.Add(this.buttonLanguageGreek);
            this.tabPageExit.Controls.Add(this.labelWelcome);
            this.tabPageExit.Name = "tabPageExit";
            this.tabPageExit.UseVisualStyleBackColor = true;
            // 
            // labelDescritptionPool
            // 
            resources.ApplyResources(this.labelDescritptionPool, "labelDescritptionPool");
            this.labelDescritptionPool.ForeColor = System.Drawing.Color.Yellow;
            this.labelDescritptionPool.Name = "labelDescritptionPool";
            // 
            // labelDescritpionExit
            // 
            resources.ApplyResources(this.labelDescritpionExit, "labelDescritpionExit");
            this.labelDescritpionExit.ForeColor = System.Drawing.Color.Yellow;
            this.labelDescritpionExit.Name = "labelDescritpionExit";
            // 
            // labelDescriptionRoomDevices
            // 
            resources.ApplyResources(this.labelDescriptionRoomDevices, "labelDescriptionRoomDevices");
            this.labelDescriptionRoomDevices.ForeColor = System.Drawing.Color.Yellow;
            this.labelDescriptionRoomDevices.Name = "labelDescriptionRoomDevices";
            // 
            // labelDescritpionMenu
            // 
            resources.ApplyResources(this.labelDescritpionMenu, "labelDescritpionMenu");
            this.labelDescritpionMenu.ForeColor = System.Drawing.Color.Yellow;
            this.labelDescritpionMenu.Name = "labelDescritpionMenu";
            // 
            // buttonLanguageEnglish
            // 
            resources.ApplyResources(this.buttonLanguageEnglish, "buttonLanguageEnglish");
            this.buttonLanguageEnglish.Name = "buttonLanguageEnglish";
            this.buttonLanguageEnglish.UseVisualStyleBackColor = true;
            this.buttonLanguageEnglish.Click += new System.EventHandler(this.buttonLanguageEnglish_Click);
            // 
            // buttonLanguageGreek
            // 
            resources.ApplyResources(this.buttonLanguageGreek, "buttonLanguageGreek");
            this.buttonLanguageGreek.Name = "buttonLanguageGreek";
            this.buttonLanguageGreek.UseVisualStyleBackColor = true;
            this.buttonLanguageGreek.Click += new System.EventHandler(this.buttonLanguageGreek_Click);
            // 
            // labelWelcome
            // 
            resources.ApplyResources(this.labelWelcome, "labelWelcome");
            this.labelWelcome.Name = "labelWelcome";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageMenu.ResumeLayout(false);
            this.tabPageMenu.PerformLayout();
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageRestaurant.ResumeLayout(false);
            this.groupBoxMenuFood.ResumeLayout(false);
            this.groupBoxMenuFood.PerformLayout();
            this.tabPageCafeteria.ResumeLayout(false);
            this.groupBoxMenuDrinks.ResumeLayout(false);
            this.groupBoxMenuDrinks.PerformLayout();
            this.tabPageDevices.ResumeLayout(false);
            this.tabPageDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLights)).EndInit();
            this.tabPageExit.ResumeLayout(false);
            this.tabPageExit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePool;
        private System.Windows.Forms.TabPage tabPageDevices;
        private System.Windows.Forms.TabPage tabPageExit;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageRestaurant;
        private System.Windows.Forms.TabPage tabPageCafeteria;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLanguageGreek;
        private System.Windows.Forms.Label labelRoomDevices;
        private System.Windows.Forms.Button buttonLanguageEnglish;
        private System.Windows.Forms.Label labelDescritpionMenu;
        private System.Windows.Forms.Label labelDescriptionRoomDevices;
        private System.Windows.Forms.Label labelDescritpionExit;
        private System.Windows.Forms.Label labelDescritptionPool;
        private System.Windows.Forms.TrackBar trackBarLights;
        private System.Windows.Forms.Label labelRoomDevicesLights;
        private System.Windows.Forms.Label labelRoomDevicesON;
        private System.Windows.Forms.Label labelRoomDevicesOFF;
        private System.Windows.Forms.TrackBar trackBarAlarm;
        private System.Windows.Forms.Label labelRoomDevicesAlarm;
        private System.Windows.Forms.Label labelRoomDevicesRadio;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.Label labelRoomDevicesDoor;
        private System.Windows.Forms.Label labelRoomDevicesTemperature;
        private System.Windows.Forms.Label labelRoomDevicesTemperatureValue;
        private System.Windows.Forms.TrackBar trackBarDoor;
        private System.Windows.Forms.GroupBox groupBoxMenuFood;
        private System.Windows.Forms.Button buttonMenuCancel;
        private System.Windows.Forms.TextBox textBoxMenuTotal;
        private System.Windows.Forms.Label labelMenuTotal;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodCheececake;
        private System.Windows.Forms.Label labelMenuFoodSweet;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodProfiterol;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodCarbonara;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodCanneloni;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodRisotto;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodRibEye;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodChops;
        private System.Windows.Forms.Label labelMenuFoodMainCourse;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodMuffin;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodTsigarilos;
        private System.Windows.Forms.Label labelMenuFoodAppetizers;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodExotic;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodCaesar;
        private System.Windows.Forms.CheckBox checkBoxMenuFoodGreek;
        private System.Windows.Forms.Label labelMenuFoodSalads;
        private System.Windows.Forms.GroupBox groupBoxMenuDrinks;
        private System.Windows.Forms.CheckBox checkBoxMenuDrinksJuice;
        private System.Windows.Forms.Label labelMenuFoodOther;
        private System.Windows.Forms.CheckBox checkBoxMenuDrinksVodka;
        private System.Windows.Forms.CheckBox checkBoxMenuDrinksBeer;
        private System.Windows.Forms.Label labelMenuFoodAlcoholic;
        private System.Windows.Forms.CheckBox checkBoxMenuDrinksCappuccino;
        private System.Windows.Forms.CheckBox checkBoxMenuDrinksEspresso;
        private System.Windows.Forms.CheckBox checkBoxMenuDrinksGreek;
        private System.Windows.Forms.Label labelMenuFoodCoffee;
        private System.Windows.Forms.Button buttonMenuPayment;
    }
}