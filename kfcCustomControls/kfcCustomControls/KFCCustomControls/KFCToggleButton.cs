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
    public class KFCToggleButton : CheckBox{

        private Color onBackColor = Color.RoyalBlue;
        private Color onToggleColor = Color.White;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidyStyle = true;


        [Category("kfc Code Advenced")]
        public Color OnBackColor { 
            get => onBackColor;
            set { 
                onBackColor = value;
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public Color OnToggleColor { 
            get => onToggleColor;
            set {
                onToggleColor = value;
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public Color OffBackColor { 
            get => offBackColor;
            set {
                offBackColor = value;
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public Color OffToggleColor { 
            get => offToggleColor;
            set {
                offToggleColor = value;
                Invalidate();
            } 
        }
        [DefaultValue(true)]
        [Category("kfc Code Advenced")]
        public bool SolidyStyle {
            get => solidyStyle;
            set {
                solidyStyle = value;
                Invalidate();
            }
        }
        public override string Text { 
            get => base.Text;
            set { }
        }

        public KFCToggleButton() {
            AutoSize = false;
            MinimumSize = new Size(Height * 2, 22);
        }

        private GraphicsPath GetFigurePath() {
            int arcSize = Height -1;

            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(Width-arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent) {
            int toggleSize = Height - 5;

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(Parent.BackColor);

            if (Checked) {
                if (solidyStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));

            } else {
                if (solidyStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));

            }

            MinimumSize = new Size(Height * 2, 22);
        }
    }
}
