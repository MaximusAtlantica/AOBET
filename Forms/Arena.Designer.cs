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
            this.PanelArena = new System.Windows.Forms.Panel();
            this.ArenaCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PilihHero = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.lbl_Reset = new System.Windows.Forms.Label();
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
            this.PanelArena.Controls.Add(this.lbl_Reset);
            this.PanelArena.Controls.Add(this.lbl_Exit);
            this.PanelArena.Controls.Add(this.a_1);
            this.PanelArena.Controls.Add(this.PanelDetail);
            this.PanelArena.Location = new System.Drawing.Point(0, 0);
            this.PanelArena.Name = "PanelArena";
            this.PanelArena.Size = new System.Drawing.Size(512, 512);
            this.PanelArena.TabIndex = 0;
            // 
            // ArenaCMenu
            // 
            this.ArenaCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PilihHero});
            this.ArenaCMenu.Name = "ArenaCMenu";
            this.ArenaCMenu.ShowImageMargin = false;
            this.ArenaCMenu.Size = new System.Drawing.Size(102, 26);
            // 
            // PilihHero
            // 
            this.PilihHero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PilihHero.Name = "PilihHero";
            this.PilihHero.Size = new System.Drawing.Size(101, 22);
            this.PilihHero.Text = "Pilih Hero";
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
            // 
            // d_9
            // 
            this.d_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_9.Location = new System.Drawing.Point(52, 64);
            this.d_9.Name = "d_9";
            this.d_9.Size = new System.Drawing.Size(26, 32);
            this.d_9.TabIndex = 8;
            this.d_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_8
            // 
            this.d_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_8.Location = new System.Drawing.Point(26, 64);
            this.d_8.Name = "d_8";
            this.d_8.Size = new System.Drawing.Size(26, 32);
            this.d_8.TabIndex = 7;
            this.d_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_7
            // 
            this.d_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_7.Location = new System.Drawing.Point(0, 64);
            this.d_7.Name = "d_7";
            this.d_7.Size = new System.Drawing.Size(26, 32);
            this.d_7.TabIndex = 6;
            this.d_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_3
            // 
            this.d_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_3.Location = new System.Drawing.Point(52, 0);
            this.d_3.Name = "d_3";
            this.d_3.Size = new System.Drawing.Size(26, 32);
            this.d_3.TabIndex = 5;
            this.d_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_2
            // 
            this.d_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_2.Location = new System.Drawing.Point(26, 0);
            this.d_2.Name = "d_2";
            this.d_2.Size = new System.Drawing.Size(26, 32);
            this.d_2.TabIndex = 4;
            this.d_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_1
            // 
            this.d_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_1.Location = new System.Drawing.Point(0, 0);
            this.d_1.Name = "d_1";
            this.d_1.Size = new System.Drawing.Size(26, 32);
            this.d_1.TabIndex = 3;
            this.d_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_6
            // 
            this.d_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_6.Location = new System.Drawing.Point(52, 32);
            this.d_6.Name = "d_6";
            this.d_6.Size = new System.Drawing.Size(26, 32);
            this.d_6.TabIndex = 2;
            this.d_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_5
            // 
            this.d_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_5.Location = new System.Drawing.Point(26, 32);
            this.d_5.Name = "d_5";
            this.d_5.Size = new System.Drawing.Size(26, 32);
            this.d_5.TabIndex = 1;
            this.d_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_4
            // 
            this.d_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_4.Location = new System.Drawing.Point(0, 32);
            this.d_4.Name = "d_4";
            this.d_4.Size = new System.Drawing.Size(26, 32);
            this.d_4.TabIndex = 0;
            this.d_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AOBET.Properties.Resources.MatchBackground;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.PanelArena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}