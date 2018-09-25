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
    public partial class Formasi : Form
    {
        public Formasi()
        {
            InitializeComponent();
        }

        private void Formasi_Shown(object sender, EventArgs e)
        {
            var LocationNow = this.Location;
            this.Location = new Point(LocationNow.X - 4, LocationNow.Y);
            var HeroList = Program.HeroList.OrderBy(x => x).ToArray();
            cmb_Hero.Items.AddRange(HeroList);
        }

        private void cmb_Hero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Hero.SelectedIndex > -1)
            {
                cmb_Formasi.SelectedIndex = -1;
                cmb_Formasi.SelectedIndex = 0;
            }
        }

        private void cmb_Formasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Hero.SelectedIndex > -1 && cmb_Formasi.SelectedIndex > -1)
            {
                var HeroName = cmb_Hero.Items[cmb_Hero.SelectedIndex].ToString();
                var FormasiCode = cmb_Formasi.Items[cmb_Formasi.SelectedIndex].ToString();
                var QueryString = "SELECT FormasiData FROM Formasi WHERE FormasiName='" + HeroName + "_" + FormasiCode + "'";
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
                }
            }
        }

        private void btn_Pilih_Click(object sender, EventArgs e)
        {
            var HeroName = cmb_Hero.Items[cmb_Hero.SelectedIndex].ToString();
            var FormasiCode = cmb_Formasi.Items[cmb_Formasi.SelectedIndex].ToString();
            var QueryString = "SELECT FormasiId FROM Formasi WHERE FormasiName='" + HeroName + "_" + FormasiCode + "'";
            var FormasiId = SQLite.ExecuteScalar(QueryString, AOBET.Properties.Resources.SQLiteConnString).ToString();
            var Asal = this.Tag as HeroButton;
            if (Asal.Tag != null && Asal.BackgroundImage != null)
            {
                QueryString = "SELECT FormasiName FROM Formasi WHERE FormasiId='" + Asal.Tag.ToString() + "'";
                var TmpHeroName = SQLite.ExecuteScalar(QueryString, Img.SQLiteConnString).ToString().Split('_')[0];
                Program.HeroList.Add(TmpHeroName);
            }
            Asal.Tag = FormasiId;
            Asal.BackgroundImage = CF.ImgResize(Img.ResourceManager.GetObject(HeroName) as Bitmap, Asal.Size);
            Program.HeroList.Remove(HeroName);
            this.Close();
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
