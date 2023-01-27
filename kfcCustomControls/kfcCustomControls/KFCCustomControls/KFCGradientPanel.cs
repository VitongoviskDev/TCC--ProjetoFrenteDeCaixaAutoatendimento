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
    public class KFCGradientPanel : Panel {

        private int borderRadius;
        private float gradientAngle;
        private Color color1 = Color.RoyalBlue;
        private Color color2 = Color.HotPink;

        public KFCGradientPanel() {
            BackColor = Color.White;
            ForeColor = Color.Black;
            Size = new Size(200, 100);
        }

        public int BorderRadius {
            get {
                return borderRadius;
            }

            set {
                borderRadius = value;
                Invalidate();
            }
        }

        public float GradientAngle {
            get {
                return gradientAngle;
            }

            set {
                gradientAngle = value;
                Invalidate();
            }
        }

        public Color Color1 {
            get {
                return color1;
            }

            set {
                color1 = value;
                Invalidate();
            }
        }

        public Color Color2 {
            get {
                return color2;
            }

            set {
                color2 = value;
                Invalidate();
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius) {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush surfaceBrush = new LinearGradientBrush(ClientRectangle, color1, color2, gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(surfaceBrush, ClientRectangle);

            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            if(borderRadius > 2) {
                using (GraphicsPath path = GetFigurePath(rectSurface, borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2)) {
                    Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            } else {
                Region = new Region(rectSurface);
            }
        }
    }
}
