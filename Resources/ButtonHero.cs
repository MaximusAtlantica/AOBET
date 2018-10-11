using System;
using System.Drawing;
using System.Windows.Forms;

namespace AOBET
{
    public class ButtonHero : Button
    {
        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }
    }

    //    public override Image base.Image
    //    {
    //        get { return this.Image; }
    //        set
    //        {
    //            if (this.Image != value)
    //            {
    //                Image old = this.Image;
    //                this.Image = value;
    //                OnImageChanged(this, new ImageChangedEventArgs("__", old, value));
    //            }
    //        }
    //    }
    //    public delegate void ImageChangedEventHandler(object sender, ImageChangedEventArgs e);
    //    public event ImageChangedEventHandler ImageChanged;
    //    protected virtual void OnImageChanged(object sender,ImageChangedEventArgs e)
    //    {
    //        if (ImageChanged != null)
    //            ImageChanged(this, e);
    //    }
    //}

    //public class ImageChangedEventArgs : EventArgs
    //{
    //    public string _PropertyName { get; internal set; }
    //    public Image _OldValue { get; internal set; }
    //    public Image _NewValue { get; internal set; }
    //    public ImageChangedEventArgs(string propertyName, Image oldValue, Image newValue)
    //    {
    //        this._PropertyName = propertyName;
    //        this._OldValue = oldValue;
    //        this._NewValue = newValue;
    //    }
    //}
}