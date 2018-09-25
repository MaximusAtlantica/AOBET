using System;
using System.Windows.Forms;

namespace AOBET
{
    public class HeroButton : Button
    {
    
        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }
    }
}