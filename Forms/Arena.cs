using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLWrapper;
using CustomFucntion;
using Img = AOBET.Properties.Resources;

namespace AOBET.Forms
{
    public partial class Arena : Form
    {
        #region variables

        Color
            BgCustom = Color.FromArgb(255, 1, 1, 8),
            BgBlack = Color.FromArgb(255, 0, 0, 0),
            BgWhite = Color.FromArgb(255, 255, 255, 255),
            BgTrans = Color.FromKnownColor(KnownColor.Transparent);
        Size
            SzHero = new Size(46, 56),
            SzDetail = new Size(19, 23);

        #endregion variables

        public Arena()
        {
            InitializeComponent();
            this.BackColor = BgCustom;
            this.TransparencyKey = BgCustom;
            this.AllowTransparency = true;
            //this.BackgroundImage = Img.MatchBackground;
            //PanelArena.BackColor = BgTrans;
            //PanelArena.BackgroundImage = Img.MatchFrame;
            //a_1.BackgroundImage = imgResize(Img.ResourceManager.GetObject("Alexandra") as Bitmap, a_1.Size);
        }

        private void Arena_Shown(object sender, EventArgs e)
        {
            //foreach (var x in PanelDetail.Controls)
            //    if (x.GetType() == typeof(Label))
            //    {
            //        var y = x as Label;
            //        y.BackgroundImage = CF.ImgResize(Img.ResourceManager.GetObject("Alexandra") as Bitmap, y.Size);
            //    }
        }
        
        private void PanelArena_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethod.ReleaseCapture();
                NativeMethod.SendMessage(this.Handle, 0x00A1, 0x2, 0);
            }
        }

        private void PanelDetail_DoubleClick(object sender, EventArgs e)
        {
            PanelDetail.Hide();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Reset_Click(object sender, EventArgs e)
        {

        }

        private void PilihHero_Click(object sender, EventArgs e)
        {
            var x = sender as ToolStripMenuItem;
            var y = x.Owner as ContextMenuStrip;
            var z = y.SourceControl;
            var f = new Formasi();
            f.Owner = this;
            f.Tag = z;
            f.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            var x = sender as ToolStripMenuItem;
            var y = x.Owner as ContextMenuStrip;
            var z = y.SourceControl as HeroButton;
            var QueryString = "SELECT FormasiName FROM Formasi WHERE FormasiId='" + z.Tag.ToString() + "'";
            var TmpHeroName = SQLite.ExecuteScalar(QueryString, Img.SQLiteConnString).ToString().Split('_')[0];
            Program.HeroList.Add(TmpHeroName);
            z.Tag = null;
            z.BackgroundImage = null;
        }

        private void btn_Hero_Click(object sender, EventArgs e)
        {
            var Asal = sender as HeroButton;
            if (Asal.Tag != null && Asal.BackgroundImage != null)
            {
                var QueryString = "SELECT FormasiData FROM Formasi WHERE FormasiId='" + Asal.Tag.ToString() + "'";
                var FormasiData = SQLite.ExecuteScalar(QueryString, AOBET.Properties.Resources.SQLiteConnString).ToString().Split('+');
                if (FormasiData != null)
                {
                    foreach (var x in PanelDetail.Controls)
                    {
                        if (x.GetType() == typeof(Label))
                            (x as Label).Image = null;
                    }
                    for (int i = 1; i <= 9; i++)
                    {
                        if (FormasiData[i - 1] != "Empty")
                        {
                            var Target = PanelDetail.Controls.Find("d_" + i.ToString(), true)[0] as Label;
                            Target.Image = CF.ImgResize(Img.ResourceManager.GetObject(FormasiData[i - 1]) as Bitmap, Target.Size);
                        }
                    }
                    PanelDetail.Show();
                }
            }
        }

        


        

    }
}
