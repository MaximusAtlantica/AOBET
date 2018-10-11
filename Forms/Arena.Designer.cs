namespace AOBET.Forms
{
    partial class Arena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arena));
            this.PanelArena = new System.Windows.Forms.Panel();
            this.lbl_Judul = new System.Windows.Forms.Label();
            this.ArenaCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PilihHero = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelDetail = new System.Windows.Forms.Panel();
            this.d_9 = new System.Windows.Forms.Label();
            this.d_8 = new System.Windows.Forms.Label();
            this.d_7 = new System.Windows.Forms.Label();
            this.d_3 = new System.Windows.Forms.Label();
            this.d_2 = new System.Windows.Forms.Label();
            this.d_1 = new System.Windows.Forms.Label();
            this.d_6 = new System.Windows.Forms.Label();
            this.d_5 = new System.Windows.Forms.Label();
            this.d_4 = new System.Windows.Forms.Label();
            this.ob2 = new AOBET.ButtonObserve();
            this.ob3 = new AOBET.ButtonObserve();
            this.ob1 = new AOBET.ButtonObserve();
            this.ox4 = new AOBET.ButtonObserve();
            this.oa2 = new AOBET.ButtonObserve();
            this.oa3 = new AOBET.ButtonObserve();
            this.oa1 = new AOBET.ButtonObserve();
            this.x_8 = new AOBET.ButtonHero();
            this.b_7 = new AOBET.ButtonHero();
            this.a_7 = new AOBET.ButtonHero();
            this.b_6 = new AOBET.ButtonHero();
            this.b_5 = new AOBET.ButtonHero();
            this.a_6 = new AOBET.ButtonHero();
            this.a_5 = new AOBET.ButtonHero();
            this.b_4 = new AOBET.ButtonHero();
            this.b_3 = new AOBET.ButtonHero();
            this.b_2 = new AOBET.ButtonHero();
            this.b_1 = new AOBET.ButtonHero();
            this.a_4 = new AOBET.ButtonHero();
            this.a_3 = new AOBET.ButtonHero();
            this.a_2 = new AOBET.ButtonHero();
            this.a_1 = new AOBET.ButtonHero();
            this.btn_Reset = new AOBET.ButtonReset();
            this.btn_Exit = new AOBET.ButtonExit();
            this.PanelArena.SuspendLayout();
            this.ArenaCMenu.SuspendLayout();
            this.PanelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelArena
            // 
            this.PanelArena.BackColor = System.Drawing.Color.Transparent;
            this.PanelArena.Controls.Add(this.btn_Exit);
            this.PanelArena.Controls.Add(this.btn_Reset);
            this.PanelArena.Controls.Add(this.ob2);
            this.PanelArena.Controls.Add(this.ob3);
            this.PanelArena.Controls.Add(this.ob1);
            this.PanelArena.Controls.Add(this.ox4);
            this.PanelArena.Controls.Add(this.oa2);
            this.PanelArena.Controls.Add(this.oa3);
            this.PanelArena.Controls.Add(this.oa1);
            this.PanelArena.Controls.Add(this.lbl_Judul);
            this.PanelArena.Controls.Add(this.x_8);
            this.PanelArena.Controls.Add(this.b_7);
            this.PanelArena.Controls.Add(this.a_7);
            this.PanelArena.Controls.Add(this.b_6);
            this.PanelArena.Controls.Add(this.b_5);
            this.PanelArena.Controls.Add(this.a_6);
            this.PanelArena.Controls.Add(this.a_5);
            this.PanelArena.Controls.Add(this.b_4);
            this.PanelArena.Controls.Add(this.b_3);
            this.PanelArena.Controls.Add(this.b_2);
            this.PanelArena.Controls.Add(this.b_1);
            this.PanelArena.Controls.Add(this.a_4);
            this.PanelArena.Controls.Add(this.a_3);
            this.PanelArena.Controls.Add(this.a_2);
            this.PanelArena.Controls.Add(this.a_1);
            this.PanelArena.Controls.Add(this.PanelDetail);
            this.PanelArena.Location = new System.Drawing.Point(0, 0);
            this.PanelArena.Name = "PanelArena";
            this.PanelArena.Size = new System.Drawing.Size(512, 512);
            this.PanelArena.TabIndex = 0;
            this.PanelArena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelArena_MouseDown);
            // 
            // lbl_Judul
            // 
            this.lbl_Judul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Judul.ForeColor = System.Drawing.Color.White;
            this.lbl_Judul.Location = new System.Drawing.Point(184, 40);
            this.lbl_Judul.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Judul.Name = "lbl_Judul";
            this.lbl_Judul.Size = new System.Drawing.Size(141, 21);
            this.lbl_Judul.TabIndex = 18;
            this.lbl_Judul.Text = "Daftar Pertandingan";
            this.lbl_Judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArenaCMenu
            // 
            this.ArenaCMenu.AutoSize = false;
            this.ArenaCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PilihHero,
            this.Clear});
            this.ArenaCMenu.Name = "ArenaCMenu";
            this.ArenaCMenu.ShowImageMargin = false;
            this.ArenaCMenu.Size = new System.Drawing.Size(72, 48);
            // 
            // PilihHero
            // 
            this.PilihHero.AutoSize = false;
            this.PilihHero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PilihHero.Name = "PilihHero";
            this.PilihHero.Size = new System.Drawing.Size(71, 22);
            this.PilihHero.Text = "Pilih Hero";
            this.PilihHero.Click += new System.EventHandler(this.PilihHero_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = false;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(71, 22);
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // PanelDetail
            // 
            this.PanelDetail.BackgroundImage = global::AOBET.Properties.Resources.CharInfo;
            this.PanelDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelDetail.Controls.Add(this.d_9);
            this.PanelDetail.Controls.Add(this.d_8);
            this.PanelDetail.Controls.Add(this.d_7);
            this.PanelDetail.Controls.Add(this.d_3);
            this.PanelDetail.Controls.Add(this.d_2);
            this.PanelDetail.Controls.Add(this.d_1);
            this.PanelDetail.Controls.Add(this.d_6);
            this.PanelDetail.Controls.Add(this.d_5);
            this.PanelDetail.Controls.Add(this.d_4);
            this.PanelDetail.Location = new System.Drawing.Point(215, 205);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(78, 96);
            this.PanelDetail.TabIndex = 0;
            this.PanelDetail.Visible = false;
            // 
            // d_9
            // 
            this.d_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_9.Location = new System.Drawing.Point(52, 64);
            this.d_9.Name = "d_9";
            this.d_9.Size = new System.Drawing.Size(26, 32);
            this.d_9.TabIndex = 8;
            this.d_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_9.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // d_8
            // 
            this.d_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_8.Location = new System.Drawing.Point(26, 64);
            this.d_8.Name = "d_8";
            this.d_8.Size = new System.Drawing.Size(26, 32);
            this.d_8.TabIndex = 7;
            this.d_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_8.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // d_7
            // 
            this.d_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_7.Location = new System.Drawing.Point(0, 64);
            this.d_7.Name = "d_7";
            this.d_7.Size = new System.Drawing.Size(26, 32);
            this.d_7.TabIndex = 6;
            this.d_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_7.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // d_3
            // 
            this.d_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_3.Location = new System.Drawing.Point(52, 0);
            this.d_3.Name = "d_3";
            this.d_3.Size = new System.Drawing.Size(26, 32);
            this.d_3.TabIndex = 5;
            this.d_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_3.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // d_2
            // 
            this.d_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_2.Location = new System.Drawing.Point(26, 0);
            this.d_2.Name = "d_2";
            this.d_2.Size = new System.Drawing.Size(26, 32);
            this.d_2.TabIndex = 4;
            this.d_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_2.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // d_1
            // 
            this.d_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_1.Location = new System.Drawing.Point(0, 0);
            this.d_1.Name = "d_1";
            this.d_1.Size = new System.Drawing.Size(26, 32);
            this.d_1.TabIndex = 3;
            this.d_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_1.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // d_6
            // 
            this.d_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_6.Location = new System.Drawing.Point(52, 32);
            this.d_6.Name = "d_6";
            this.d_6.Size = new System.Drawing.Size(26, 32);
            this.d_6.TabIndex = 2;
            this.d_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_6.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // d_5
            // 
            this.d_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_5.Location = new System.Drawing.Point(26, 32);
            this.d_5.Name = "d_5";
            this.d_5.Size = new System.Drawing.Size(26, 32);
            this.d_5.TabIndex = 1;
            this.d_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_5.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // d_4
            // 
            this.d_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_4.Location = new System.Drawing.Point(0, 32);
            this.d_4.Name = "d_4";
            this.d_4.Size = new System.Drawing.Size(26, 32);
            this.d_4.TabIndex = 0;
            this.d_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_4.DoubleClick += new System.EventHandler(this.PanelDetail_DoubleClick);
            // 
            // ob2
            // 
            this.ob2.BackgroundImage = global::AOBET.Properties.Resources.NoObserve;
            this.ob2.Enabled = false;
            this.ob2.FlatAppearance.BorderSize = 0;
            this.ob2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ob2.Location = new System.Drawing.Point(416, 388);
            this.ob2.Margin = new System.Windows.Forms.Padding(0);
            this.ob2.Name = "ob2";
            this.ob2.Size = new System.Drawing.Size(58, 21);
            this.ob2.TabIndex = 26;
            this.ob2.UseVisualStyleBackColor = true;
            // 
            // ob3
            // 
            this.ob3.BackgroundImage = global::AOBET.Properties.Resources.NoObserve;
            this.ob3.Enabled = false;
            this.ob3.FlatAppearance.BorderSize = 0;
            this.ob3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ob3.Location = new System.Drawing.Point(352, 337);
            this.ob3.Margin = new System.Windows.Forms.Padding(0);
            this.ob3.Name = "ob3";
            this.ob3.Size = new System.Drawing.Size(58, 21);
            this.ob3.TabIndex = 26;
            this.ob3.UseVisualStyleBackColor = true;
            // 
            // ob1
            // 
            this.ob1.BackgroundImage = global::AOBET.Properties.Resources.NoObserve;
            this.ob1.Enabled = false;
            this.ob1.FlatAppearance.BorderSize = 0;
            this.ob1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ob1.Location = new System.Drawing.Point(287, 388);
            this.ob1.Margin = new System.Windows.Forms.Padding(0);
            this.ob1.Name = "ob1";
            this.ob1.Size = new System.Drawing.Size(58, 21);
            this.ob1.TabIndex = 26;
            this.ob1.UseVisualStyleBackColor = true;
            // 
            // ox4
            // 
            this.ox4.BackgroundImage = global::AOBET.Properties.Resources.NoObserve;
            this.ox4.Enabled = false;
            this.ox4.FlatAppearance.BorderSize = 0;
            this.ox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ox4.Location = new System.Drawing.Point(225, 181);
            this.ox4.Margin = new System.Windows.Forms.Padding(0);
            this.ox4.Name = "ox4";
            this.ox4.Size = new System.Drawing.Size(58, 21);
            this.ox4.TabIndex = 26;
            this.ox4.UseVisualStyleBackColor = true;
            // 
            // oa2
            // 
            this.oa2.BackgroundImage = global::AOBET.Properties.Resources.NoObserve;
            this.oa2.Enabled = false;
            this.oa2.FlatAppearance.BorderSize = 0;
            this.oa2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oa2.Location = new System.Drawing.Point(163, 388);
            this.oa2.Margin = new System.Windows.Forms.Padding(0);
            this.oa2.Name = "oa2";
            this.oa2.Size = new System.Drawing.Size(58, 21);
            this.oa2.TabIndex = 26;
            this.oa2.UseVisualStyleBackColor = true;
            // 
            // oa3
            // 
            this.oa3.BackgroundImage = global::AOBET.Properties.Resources.NoObserve;
            this.oa3.Enabled = false;
            this.oa3.FlatAppearance.BorderSize = 0;
            this.oa3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oa3.Location = new System.Drawing.Point(98, 337);
            this.oa3.Margin = new System.Windows.Forms.Padding(0);
            this.oa3.Name = "oa3";
            this.oa3.Size = new System.Drawing.Size(58, 21);
            this.oa3.TabIndex = 26;
            this.oa3.UseVisualStyleBackColor = true;
            // 
            // oa1
            // 
            this.oa1.BackgroundImage = global::AOBET.Properties.Resources.NoObserve;
            this.oa1.Enabled = false;
            this.oa1.FlatAppearance.BorderSize = 0;
            this.oa1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oa1.Location = new System.Drawing.Point(34, 388);
            this.oa1.Margin = new System.Windows.Forms.Padding(0);
            this.oa1.Name = "oa1";
            this.oa1.Size = new System.Drawing.Size(58, 21);
            this.oa1.TabIndex = 26;
            this.oa1.UseVisualStyleBackColor = true;
            // 
            // x_8
            // 
            this.x_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.x_8.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.x_8.FlatAppearance.BorderSize = 0;
            this.x_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.x_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.x_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x_8.Location = new System.Drawing.Point(230, 104);
            this.x_8.Margin = new System.Windows.Forms.Padding(0);
            this.x_8.Name = "x_8";
            this.x_8.Size = new System.Drawing.Size(46, 56);
            this.x_8.TabIndex = 17;
            this.x_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.x_8.UseVisualStyleBackColor = true;
            this.x_8.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.x_8.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_7
            // 
            this.b_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_7.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.b_7.FlatAppearance.BorderSize = 0;
            this.b_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_7.Location = new System.Drawing.Point(356, 214);
            this.b_7.Margin = new System.Windows.Forms.Padding(0);
            this.b_7.Name = "b_7";
            this.b_7.Size = new System.Drawing.Size(46, 56);
            this.b_7.TabIndex = 16;
            this.b_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_7.UseVisualStyleBackColor = true;
            this.b_7.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.b_7.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_7
            // 
            this.a_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_7.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.a_7.FlatAppearance.BorderSize = 0;
            this.a_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.a_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.a_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_7.Location = new System.Drawing.Point(103, 214);
            this.a_7.Margin = new System.Windows.Forms.Padding(0);
            this.a_7.Name = "a_7";
            this.a_7.Size = new System.Drawing.Size(46, 56);
            this.a_7.TabIndex = 15;
            this.a_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.a_7.UseVisualStyleBackColor = true;
            this.a_7.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.a_7.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_6
            // 
            this.b_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_6.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.b_6.FlatAppearance.BorderSize = 0;
            this.b_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_6.Location = new System.Drawing.Point(422, 320);
            this.b_6.Margin = new System.Windows.Forms.Padding(0);
            this.b_6.Name = "b_6";
            this.b_6.Size = new System.Drawing.Size(46, 56);
            this.b_6.TabIndex = 14;
            this.b_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_6.UseVisualStyleBackColor = true;
            this.b_6.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.b_6.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_5
            // 
            this.b_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_5.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.b_5.FlatAppearance.BorderSize = 0;
            this.b_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_5.Location = new System.Drawing.Point(293, 320);
            this.b_5.Margin = new System.Windows.Forms.Padding(0);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(46, 56);
            this.b_5.TabIndex = 13;
            this.b_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_5.UseVisualStyleBackColor = true;
            this.b_5.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.b_5.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_6
            // 
            this.a_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_6.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.a_6.FlatAppearance.BorderSize = 0;
            this.a_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.a_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.a_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_6.Location = new System.Drawing.Point(169, 320);
            this.a_6.Margin = new System.Windows.Forms.Padding(0);
            this.a_6.Name = "a_6";
            this.a_6.Size = new System.Drawing.Size(46, 56);
            this.a_6.TabIndex = 12;
            this.a_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.a_6.UseVisualStyleBackColor = true;
            this.a_6.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.a_6.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_5
            // 
            this.a_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_5.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.a_5.FlatAppearance.BorderSize = 0;
            this.a_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.a_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.a_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_5.Location = new System.Drawing.Point(40, 320);
            this.a_5.Margin = new System.Windows.Forms.Padding(0);
            this.a_5.Name = "a_5";
            this.a_5.Size = new System.Drawing.Size(46, 56);
            this.a_5.TabIndex = 11;
            this.a_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.a_5.UseVisualStyleBackColor = true;
            this.a_5.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.a_5.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_4
            // 
            this.b_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_4.ContextMenuStrip = this.ArenaCMenu;
            this.b_4.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.b_4.FlatAppearance.BorderSize = 0;
            this.b_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_4.Location = new System.Drawing.Point(452, 421);
            this.b_4.Margin = new System.Windows.Forms.Padding(0);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(46, 56);
            this.b_4.TabIndex = 10;
            this.b_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.b_4.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_3
            // 
            this.b_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_3.ContextMenuStrip = this.ArenaCMenu;
            this.b_3.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.b_3.FlatAppearance.BorderSize = 0;
            this.b_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_3.Location = new System.Drawing.Point(391, 421);
            this.b_3.Margin = new System.Windows.Forms.Padding(0);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(46, 56);
            this.b_3.TabIndex = 9;
            this.b_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.b_3.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_2
            // 
            this.b_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_2.ContextMenuStrip = this.ArenaCMenu;
            this.b_2.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.b_2.FlatAppearance.BorderSize = 0;
            this.b_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_2.Location = new System.Drawing.Point(325, 421);
            this.b_2.Margin = new System.Windows.Forms.Padding(0);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(46, 56);
            this.b_2.TabIndex = 8;
            this.b_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.b_2.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_1
            // 
            this.b_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_1.ContextMenuStrip = this.ArenaCMenu;
            this.b_1.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.b_1.FlatAppearance.BorderSize = 0;
            this.b_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_1.Location = new System.Drawing.Point(264, 421);
            this.b_1.Margin = new System.Windows.Forms.Padding(0);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(46, 56);
            this.b_1.TabIndex = 7;
            this.b_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.b_1.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_4
            // 
            this.a_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_4.ContextMenuStrip = this.ArenaCMenu;
            this.a_4.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.a_4.FlatAppearance.BorderSize = 0;
            this.a_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.a_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.a_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_4.Location = new System.Drawing.Point(199, 421);
            this.a_4.Margin = new System.Windows.Forms.Padding(0);
            this.a_4.Name = "a_4";
            this.a_4.Size = new System.Drawing.Size(46, 56);
            this.a_4.TabIndex = 6;
            this.a_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.a_4.UseVisualStyleBackColor = true;
            this.a_4.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.a_4.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_3
            // 
            this.a_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_3.ContextMenuStrip = this.ArenaCMenu;
            this.a_3.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.a_3.FlatAppearance.BorderSize = 0;
            this.a_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.a_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.a_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_3.Location = new System.Drawing.Point(137, 421);
            this.a_3.Margin = new System.Windows.Forms.Padding(0);
            this.a_3.Name = "a_3";
            this.a_3.Size = new System.Drawing.Size(46, 56);
            this.a_3.TabIndex = 5;
            this.a_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.a_3.UseVisualStyleBackColor = true;
            this.a_3.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.a_3.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_2
            // 
            this.a_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_2.ContextMenuStrip = this.ArenaCMenu;
            this.a_2.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.a_2.FlatAppearance.BorderSize = 0;
            this.a_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.a_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.a_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_2.Location = new System.Drawing.Point(72, 421);
            this.a_2.Margin = new System.Windows.Forms.Padding(0);
            this.a_2.Name = "a_2";
            this.a_2.Size = new System.Drawing.Size(46, 56);
            this.a_2.TabIndex = 4;
            this.a_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.a_2.UseVisualStyleBackColor = true;
            this.a_2.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.a_2.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_1
            // 
            this.a_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_1.ContextMenuStrip = this.ArenaCMenu;
            this.a_1.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.a_1.FlatAppearance.BorderSize = 0;
            this.a_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.a_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.a_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_1.Location = new System.Drawing.Point(11, 421);
            this.a_1.Margin = new System.Windows.Forms.Padding(0);
            this.a_1.Name = "a_1";
            this.a_1.Size = new System.Drawing.Size(46, 56);
            this.a_1.TabIndex = 1;
            this.a_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.a_1.UseVisualStyleBackColor = true;
            this.a_1.BackgroundImageChanged += new System.EventHandler(this.btn_Hero_BackgroundImageChanged);
            this.a_1.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImage = global::AOBET.Properties.Resources.Reset;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Location = new System.Drawing.Point(421, 4);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(62, 21);
            this.btn_Reset.TabIndex = 27;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::AOBET.Properties.Resources.Exit;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Location = new System.Drawing.Point(484, 4);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(21, 21);
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.PanelArena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arena";
            this.Shown += new System.EventHandler(this.Arena_Shown);
            this.PanelArena.ResumeLayout(false);
            this.ArenaCMenu.ResumeLayout(false);
            this.PanelDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelArena;
        private System.Windows.Forms.Panel PanelDetail;
        private ButtonHero a_1;
        private System.Windows.Forms.Label d_4;
        private System.Windows.Forms.Label d_9;
        private System.Windows.Forms.Label d_8;
        private System.Windows.Forms.Label d_7;
        private System.Windows.Forms.Label d_3;
        private System.Windows.Forms.Label d_2;
        private System.Windows.Forms.Label d_1;
        private System.Windows.Forms.Label d_6;
        private System.Windows.Forms.Label d_5;
        private System.Windows.Forms.ContextMenuStrip ArenaCMenu;
        private System.Windows.Forms.ToolStripMenuItem PilihHero;
        private ButtonHero x_8;
        private ButtonHero b_7;
        private ButtonHero a_7;
        private ButtonHero b_6;
        private ButtonHero b_5;
        private ButtonHero a_6;
        private ButtonHero a_5;
        private ButtonHero b_4;
        private ButtonHero b_3;
        private ButtonHero b_2;
        private ButtonHero b_1;
        private ButtonHero a_4;
        private ButtonHero a_3;
        private ButtonHero a_2;
        private System.Windows.Forms.Label lbl_Judul;
        private System.Windows.Forms.ToolStripMenuItem Clear;
        private ButtonObserve ob2;
        private ButtonObserve ob3;
        private ButtonObserve ob1;
        private ButtonObserve ox4;
        private ButtonObserve oa2;
        private ButtonObserve oa3;
        private ButtonObserve oa1;
        private ButtonReset btn_Reset;
        private ButtonExit btn_Exit;
    }
}