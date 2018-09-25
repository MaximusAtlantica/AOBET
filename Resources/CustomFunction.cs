using System;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CustomFucntion
{
    public class CF
    {
        public static Bitmap ImgResize(Bitmap image, Size newSize)
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

    public class NativeMethod
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint uMsg, uint wParam, uint lParam);
    }
}
