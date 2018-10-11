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
        bool Loading = true;

        #endregion variables

        public Arena()
        {
            InitializeComponent();
            this.BackColor = BgCustom;
            this.TransparencyKey = BgCustom;
            this.AllowTransparency = true;
            this.BackgroundImage = Img.MatchBackground;
            PanelArena.BackgroundImage = Img.MatchFrame;
            //PanelArena.BackColor = BgTrans;
        }

        private void Arena_Shown(object sender, EventArgs e)
        {
            Loading = false;
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
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
            var z = y.SourceControl as ButtonHero;
            if (z.Tag != null)
            {
                var QueryString = "SELECT FormasiName FROM Formasi WHERE FormasiId='" + z.Tag.ToString() + "'";
                var TmpHeroName = SQLite.ExecuteScalar(QueryString, Img.SQLiteConnString).ToString().Split('_')[0];
                Program.HeroList.Add(TmpHeroName);
                z.Tag = null;
                z.BackgroundImage = null;
            }
        }

        private void btn_Hero_Click(object sender, EventArgs e)
        {
            var Asal = sender as ButtonHero;
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

        private void btn_Observe_Click(object sender, EventArgs e)
        {
            var Asal = sender as ButtonObserve;
            if (Asal.Tag.ToString() == "ok")
            {
                var Bracket = Asal.Name.Substring(1, 1);
                var Urutan = Convert.ToInt32(Asal.Name.Substring(2, 1));
                switch (Urutan)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }

        private void btn_Hero_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                var Asal = sender as ButtonHero;
                var Bracket = Asal.Name.Substring(0, 1);
                var Urutan = Convert.ToInt32(Asal.Name.Substring(2, 1));
                switch (Urutan)
                {
                    case 1:
                    case 2:
                        cekObserve("1", "2", "1", Bracket);
                        break;
                    case 3:
                    case 4:
                        cekObserve("3", "4", "2", Bracket);
                        break;
                    case 5:
                    case 6:
                        cekObserve("5", "6", "3", Bracket);
                        break;
                    case 7:
                        cekObserve("7", "7", "4");
                        break;
                }
            }
        }

        private void cekObserve(string cekName1, string cekName2, string tujuan, string bracket = "x")
        {
            string bracket1 = "", bracket2 = "";
            if (bracket != "x")
                bracket1 = bracket2 = bracket;
            else
            {
                bracket1 = "a";
                bracket2 = "b";
            }
            var cek1 = PanelArena.Controls.Find(bracket1 + "_" + cekName1, true)[0] as ButtonHero;
            var cek2 = PanelArena.Controls.Find(bracket2 + "_" + cekName2, true)[0] as ButtonHero;
            var obs = PanelArena.Controls.Find(string.Concat("o" + bracket + tujuan), true)[0] as ButtonObserve;
            if (cek1.Tag != null && cek2.Tag != null)
            {
                obs.BackgroundImage = Img.Observe;
                obs.Enabled = true;
                obs.Tag = "ok";
            }
            else
            {
                obs.BackgroundImage = Img.NoObserve;
                obs.Enabled = false;
                obs.Tag = "no";
            }
        }

        

        
    }
}
