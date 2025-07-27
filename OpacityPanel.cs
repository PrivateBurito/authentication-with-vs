using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public class OpacityPanel : Panel
    {
        public Color BackgroundColor { get; set; }
        public int Opacity { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(BackgroundColor);
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            g.FillRectangle(solidBrush, rect);
            //BackColor = Color.FromArgb(Opacity, BackgroundColor);
            base.OnPaint(e);
            g.Dispose();
            solidBrush.Dispose();
        }
    }
}
