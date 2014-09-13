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
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageRestaurant = new System.Windows.Forms.TabPage();
            this.tabPageCafeteria = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPageDevices = new System.Windows.Forms.TabPage();
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
            this.tabPageDevices.SuspendLayout();
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
            this.tabPageMenu.BackgroundImage = global::Castle.Properties.Resources.castle_5;
            resources.ApplyResources(this.tabPageMenu, "tabPageMenu");
            this.tabPageMenu.Controls.Add(this.tabControlMenu);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.UseVisualStyleBackColor = true;
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
            this.tabPageRestaurant.BackgroundImage = global::Castle.Properties.Resources.villecroze_cafe_provence;
            resources.ApplyResources(this.tabPageRestaurant, "tabPageRestaurant");
            this.tabPageRestaurant.Name = "tabPageRestaurant";
            this.tabPageRestaurant.UseVisualStyleBackColor = true;
            // 
            // tabPageCafeteria
            // 
            this.tabPageCafeteria.BackgroundImage = global::Castle.Properties.Resources.size1;
            resources.ApplyResources(this.tabPageCafeteria, "tabPageCafeteria");
            this.tabPageCafeteria.Name = "tabPageCafeteria";
            this.tabPageCafeteria.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "glass.png");
            // 
            // tabPageDevices
            // 
            this.tabPageDevices.BackgroundImage = global::Castle.Properties.Resources.bedroom;
            resources.ApplyResources(this.tabPageDevices, "tabPageDevices");
            this.tabPageDevices.Controls.Add(this.labelRoomDevices);
            this.tabPageDevices.Name = "tabPageDevices";
            this.tabPageDevices.UseVisualStyleBackColor = true;
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
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageDevices.ResumeLayout(false);
            this.tabPageDevices.PerformLayout();
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
    }
}