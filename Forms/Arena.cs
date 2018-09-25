using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //d_4.BackgroundImage = imgResize(Img.ResourceManager.GetObject("Alexandra") as Bitmap, d_4.Size);
        }

        private void Arena_Shown(object sender, EventArgs e)
        {
            foreach (var x in PanelDetail.Controls)
                if (x.GetType() == typeof(Label))
                {
                    var y = x as Label;
                    y.BackgroundImage = imgResize(Img.ResourceManager.GetObject("Alexandra") as Bitmap, y.Size);
                }
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Reset_Click(object sender, EventArgs e)
        {

        }

        private Bitmap imgResize(Bitmap image, Size newSize)
        {
            Bitmap hsl = null;
            if (image != null)
            {
                var rW = (double)newSize.Width / image.Width;
                var rH = (double)newSize.Height / image.Height;
                var r = Math.Min(rW, rH);
                var nW = (int)(image.Width * r);
                var nH = (int)(image.Height * r);
                hsl = new Bitmap(nW, nH);
                using (var g = Graphics.FromImage(hsl)) { g.DrawImage(image, 0, 0, nW, nH); }
            }
            return hsl;
        }

        
    }
}
