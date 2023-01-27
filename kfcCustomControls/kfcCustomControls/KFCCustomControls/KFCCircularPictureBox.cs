using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace kfcCustomControls.KFCCustomControls {
    public class KFCCircularPictureBox : PictureBox{
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50f;

        public KFCCircularPictureBox() {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Properties
        [Category("kfc Code Advenced")]
        public int BorderSize {
            get {
                return borderSize;
            }

            set {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("kfc Code Advenced")]
        public Color BorderColor {
            get {
                return borderColor;
            }

            set {
                borderColor = value;
                Invalidate();
            }
        }
        
        [Category("kfc Code Advenced")]
        public Color BorderColor2 {
            get {
                return borderColor2;
            }

            set {
                borderColor2 = value;
                Invalidate();
            }
        }
        
        [Category("kfc Code Advenced")]
        public DashStyle BorderStyle1 {
            get {
                return borderLineStyle;
            }

            set {
                borderLineStyle = value;
                Invalidate();
            }
        }
        
        [Category("kfc Code Advenced")]
        public DashCap BorderCapStyle {
            get {
                return borderCapStyle;
            }

            set {
                borderCapStyle = value;
                Invalidate();
            }
        }
        
        [Category("kfc Code Advenced")]
        public float GradientAngle {
            get {
                return gradientAngle;
            }

            set {
                gradientAngle = value;
                Invalidate();
            }
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            Size = new Size(Width, Height);
        }
        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);

            Graphics graphics = pe.Graphics;
            Rectangle rectContourSmooth = Rectangle.Inflate(ClientRectangle, -1, -1);
            Rectangle rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (LinearGradientBrush borderGColor = new LinearGradientBrush(rectBorder, borderColor, BorderColor2, gradientAngle))
            using (GraphicsPath pathRegion = new GraphicsPath())
            using (Pen penSmooth = new Pen(Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(borderGColor, borderSize)) {
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = BorderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                Region = new Region(pathRegion);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;

                graphics.DrawEllipse(penSmooth, rectContourSmooth);

                if (borderSize > 0)
                    graphics.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
