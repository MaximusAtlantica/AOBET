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
            this.lbl_Reset = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
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
            this.Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.x_8 = new AOBET.HeroButton();
            this.b_7 = new AOBET.HeroButton();
            this.a_7 = new AOBET.HeroButton();
            this.b_6 = new AOBET.HeroButton();
            this.b_5 = new AOBET.HeroButton();
            this.a_6 = new AOBET.HeroButton();
            this.a_5 = new AOBET.HeroButton();
            this.b_4 = new AOBET.HeroButton();
            this.b_3 = new AOBET.HeroButton();
            this.b_2 = new AOBET.HeroButton();
            this.b_1 = new AOBET.HeroButton();
            this.a_4 = new AOBET.HeroButton();
            this.a_3 = new AOBET.HeroButton();
            this.a_2 = new AOBET.HeroButton();
            this.a_1 = new AOBET.HeroButton();
            this.PanelArena.SuspendLayout();
            this.ArenaCMenu.SuspendLayout();
            this.PanelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelArena
            // 
            this.PanelArena.BackColor = System.Drawing.Color.Transparent;
            this.PanelArena.BackgroundImage = global::AOBET.Properties.Resources.MatchFrame;
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
            this.PanelArena.Controls.Add(this.lbl_Reset);
            this.PanelArena.Controls.Add(this.lbl_Exit);
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
            // lbl_Reset
            // 
            this.lbl_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Reset.Image = global::AOBET.Properties.Resources.Reset;
            this.lbl_Reset.Location = new System.Drawing.Point(422, 4);
            this.lbl_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Reset.Name = "lbl_Reset";
            this.lbl_Reset.Size = new System.Drawing.Size(62, 21);
            this.lbl_Reset.TabIndex = 3;
            this.lbl_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Reset.Click += new System.EventHandler(this.lbl_Reset_Click);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Exit.Image = global::AOBET.Properties.Resources.Exit;
            this.lbl_Exit.Location = new System.Drawing.Point(484, 4);
            this.lbl_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(21, 21);
            this.lbl_Exit.TabIndex = 2;
            this.lbl_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
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
            // Clear
            // 
            this.Clear.AutoSize = false;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(71, 22);
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // x_8
            // 
            this.x_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.x_8.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_7
            // 
            this.b_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.b_7.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_7
            // 
            this.a_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.a_7.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_6
            // 
            this.b_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.b_6.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_5
            // 
            this.b_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.b_5.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_6
            // 
            this.a_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.a_6.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_5
            // 
            this.a_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.a_5.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_4
            // 
            this.b_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_4.ContextMenuStrip = this.ArenaCMenu;
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
            this.b_4.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_3
            // 
            this.b_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_3.ContextMenuStrip = this.ArenaCMenu;
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
            this.b_3.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_2
            // 
            this.b_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_2.ContextMenuStrip = this.ArenaCMenu;
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
            this.b_2.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // b_1
            // 
            this.b_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_1.ContextMenuStrip = this.ArenaCMenu;
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
            this.b_1.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_4
            // 
            this.a_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_4.ContextMenuStrip = this.ArenaCMenu;
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
            this.a_4.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_3
            // 
            this.a_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_3.ContextMenuStrip = this.ArenaCMenu;
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
            this.a_3.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_2
            // 
            this.a_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_2.ContextMenuStrip = this.ArenaCMenu;
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
            this.a_2.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // a_1
            // 
            this.a_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_1.ContextMenuStrip = this.ArenaCMenu;
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
            this.a_1.Click += new System.EventHandler(this.btn_Hero_Click);
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AOBET.Properties.Resources.MatchBackground;
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
        private HeroButton a_1;
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
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label lbl_Reset;
        private HeroButton x_8;
        private HeroButton b_7;
        private HeroButton a_7;
        private HeroButton b_6;
        private HeroButton b_5;
        private HeroButton a_6;
        private HeroButton a_5;
        private HeroButton b_4;
        private HeroButton b_3;
        private HeroButton b_2;
        private HeroButton b_1;
        private HeroButton a_4;
        private HeroButton a_3;
        private HeroButton a_2;
        private System.Windows.Forms.Label lbl_Judul;
        private System.Windows.Forms.ToolStripMenuItem Clear;
    }
}