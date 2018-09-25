namespace AOBET.Forms
{
    partial class Formasi
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
            this.cmb_Hero = new System.Windows.Forms.ComboBox();
            this.cmb_Formasi = new System.Windows.Forms.ComboBox();
            this.btn_Pilih = new System.Windows.Forms.Button();
            this.btn_Batal = new System.Windows.Forms.Button();
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
            this.PanelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Hero
            // 
            this.cmb_Hero.FormattingEnabled = true;
            this.cmb_Hero.Location = new System.Drawing.Point(5, 5);
            this.cmb_Hero.Name = "cmb_Hero";
            this.cmb_Hero.Size = new System.Drawing.Size(130, 21);
            this.cmb_Hero.TabIndex = 2;
            this.cmb_Hero.Text = "Pilih Hero";
            this.cmb_Hero.SelectedIndexChanged += new System.EventHandler(this.cmb_Hero_SelectedIndexChanged);
            // 
            // cmb_Formasi
            // 
            this.cmb_Formasi.FormattingEnabled = true;
            this.cmb_Formasi.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5"});
            this.cmb_Formasi.Location = new System.Drawing.Point(5, 31);
            this.cmb_Formasi.Name = "cmb_Formasi";
            this.cmb_Formasi.Size = new System.Drawing.Size(130, 21);
            this.cmb_Formasi.TabIndex = 3;
            this.cmb_Formasi.Text = "Pilih Formasi";
            this.cmb_Formasi.SelectedIndexChanged += new System.EventHandler(this.cmb_Formasi_SelectedIndexChanged);
            // 
            // btn_Pilih
            // 
            this.btn_Pilih.Location = new System.Drawing.Point(5, 158);
            this.btn_Pilih.Name = "btn_Pilih";
            this.btn_Pilih.Size = new System.Drawing.Size(130, 23);
            this.btn_Pilih.TabIndex = 4;
            this.btn_Pilih.Text = "Pilih";
            this.btn_Pilih.UseVisualStyleBackColor = true;
            this.btn_Pilih.Click += new System.EventHandler(this.btn_Pilih_Click);
            // 
            // btn_Batal
            // 
            this.btn_Batal.Location = new System.Drawing.Point(5, 186);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(130, 23);
            this.btn_Batal.TabIndex = 5;
            this.btn_Batal.Text = "Batal";
            this.btn_Batal.UseVisualStyleBackColor = true;
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
            // 
            // PanelDetail
            // 
            this.PanelDetail.BackgroundImage = global::AOBET.Properties.Resources.CharInfo;
            this.PanelDetail.Controls.Add(this.d_9);
            this.PanelDetail.Controls.Add(this.d_8);
            this.PanelDetail.Controls.Add(this.d_7);
            this.PanelDetail.Controls.Add(this.d_3);
            this.PanelDetail.Controls.Add(this.d_2);
            this.PanelDetail.Controls.Add(this.d_1);
            this.PanelDetail.Controls.Add(this.d_6);
            this.PanelDetail.Controls.Add(this.d_5);
            this.PanelDetail.Controls.Add(this.d_4);
            this.PanelDetail.Location = new System.Drawing.Point(32, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(78, 96);
            this.PanelDetail.TabIndex = 6;
            // 
            // d_9
            // 
            this.d_9.BackColor = System.Drawing.Color.Transparent;
            this.d_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_9.Location = new System.Drawing.Point(52, 64);
            this.d_9.Name = "d_9";
            this.d_9.Size = new System.Drawing.Size(26, 32);
            this.d_9.TabIndex = 17;
            this.d_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_8
            // 
            this.d_8.BackColor = System.Drawing.Color.Transparent;
            this.d_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_8.Location = new System.Drawing.Point(26, 64);
            this.d_8.Name = "d_8";
            this.d_8.Size = new System.Drawing.Size(26, 32);
            this.d_8.TabIndex = 16;
            this.d_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_7
            // 
            this.d_7.BackColor = System.Drawing.Color.Transparent;
            this.d_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_7.Location = new System.Drawing.Point(0, 64);
            this.d_7.Name = "d_7";
            this.d_7.Size = new System.Drawing.Size(26, 32);
            this.d_7.TabIndex = 15;
            this.d_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_3
            // 
            this.d_3.BackColor = System.Drawing.Color.Transparent;
            this.d_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_3.Location = new System.Drawing.Point(52, 0);
            this.d_3.Name = "d_3";
            this.d_3.Size = new System.Drawing.Size(26, 32);
            this.d_3.TabIndex = 14;
            this.d_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_2
            // 
            this.d_2.BackColor = System.Drawing.Color.Transparent;
            this.d_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_2.Location = new System.Drawing.Point(26, 0);
            this.d_2.Name = "d_2";
            this.d_2.Size = new System.Drawing.Size(26, 32);
            this.d_2.TabIndex = 13;
            this.d_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_1
            // 
            this.d_1.BackColor = System.Drawing.Color.Transparent;
            this.d_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_1.Location = new System.Drawing.Point(0, 0);
            this.d_1.Name = "d_1";
            this.d_1.Size = new System.Drawing.Size(26, 32);
            this.d_1.TabIndex = 12;
            this.d_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_6
            // 
            this.d_6.BackColor = System.Drawing.Color.Transparent;
            this.d_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_6.Location = new System.Drawing.Point(52, 32);
            this.d_6.Name = "d_6";
            this.d_6.Size = new System.Drawing.Size(26, 32);
            this.d_6.TabIndex = 11;
            this.d_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_5
            // 
            this.d_5.BackColor = System.Drawing.Color.Transparent;
            this.d_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_5.Location = new System.Drawing.Point(26, 32);
            this.d_5.Name = "d_5";
            this.d_5.Size = new System.Drawing.Size(26, 32);
            this.d_5.TabIndex = 10;
            this.d_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_4
            // 
            this.d_4.BackColor = System.Drawing.Color.Transparent;
            this.d_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_4.Location = new System.Drawing.Point(0, 32);
            this.d_4.Name = "d_4";
            this.d_4.Size = new System.Drawing.Size(26, 32);
            this.d_4.TabIndex = 9;
            this.d_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Formasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AOBET.Properties.Resources.FormasiBg;
            this.ClientSize = new System.Drawing.Size(140, 214);
            this.Controls.Add(this.PanelDetail);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.btn_Pilih);
            this.Controls.Add(this.cmb_Formasi);
            this.Controls.Add(this.cmb_Hero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formasi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formasi";
            this.Shown += new System.EventHandler(this.Formasi_Shown);
            this.PanelDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Hero;
        private System.Windows.Forms.ComboBox cmb_Formasi;
        private System.Windows.Forms.Button btn_Pilih;
        private System.Windows.Forms.Button btn_Batal;
        private System.Windows.Forms.Panel PanelDetail;
        private System.Windows.Forms.Label d_9;
        private System.Windows.Forms.Label d_8;
        private System.Windows.Forms.Label d_7;
        private System.Windows.Forms.Label d_3;
        private System.Windows.Forms.Label d_2;
        private System.Windows.Forms.Label d_1;
        private System.Windows.Forms.Label d_6;
        private System.Windows.Forms.Label d_5;
        private System.Windows.Forms.Label d_4;
    }
}