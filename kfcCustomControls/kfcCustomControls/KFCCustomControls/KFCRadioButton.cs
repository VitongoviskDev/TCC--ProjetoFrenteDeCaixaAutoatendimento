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
    public class KFCRadioButton : RadioButton{
        private Color checkColor = Color.RoyalBlue;
        private Color uncheckedColor = Color.DimGray;

        [Category("kfc Code Advenced")]
        public Color CheckColor { 
            get => checkColor;
            set {
                checkColor = value;
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public Color UncheckedColor { 
            get => uncheckedColor; 
            set {
                uncheckedColor = value;
                Invalidate();
            } 
        }

        public KFCRadioButton() {
            MinimumSize = new Size(0, 21);
        }

        protected override void OnPaint(PaintEventArgs pevent) {
            Graphics graphics = pevent.Graphics;

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            float rbBorderSize = 18f;
            float rbCheckSize = 12f;

            RectangleF rectRbBorder = new RectangleF() {
                X = 0.5f,
                Y = (Height - rbBorderSize) / 2,
                Height = rbBorderSize,
                Width = rbBorderSize
            };
            RectangleF rectRbCheck = new RectangleF() {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2),
                Y = (Height - rbCheckSize) / 2,
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            using (Pen penBorder = new Pen(checkColor, 1.6f))
            using (SolidBrush brushRbCheck = new SolidBrush(checkColor))
            using (SolidBrush brushText = new SolidBrush(ForeColor)){

                graphics.Clear(BackColor);

                if (Checked) {
                    graphics.DrawEllipse(penBorder, rectRbBorder);
                    graphics.FillEllipse(brushRbCheck, rectRbCheck);
                } else {
                    penBorder.Color = UncheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder);
                }
                graphics.DrawString(Text, Font, brushText, rbBorderSize + 8, (Height - TextRenderer.MeasureText(Text, Font).Height) / 2);
            }
        }
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            Width = TextRenderer.MeasureText(Text, Font).Width + 30;
        }
    }
}
