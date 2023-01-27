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
    public enum TextPosition {
        Left,
        Right,
        Center,
        Sliding,
        None
    }
    public class KFCProgressBar : ProgressBar{
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;

        private bool paintedBack = false;
        private bool stopPainting = false;

        public KFCProgressBar() {
            SetStyle(ControlStyles.UserPaint, true);
            ForeColor = Color.White;
        }

        [Category("kfc Code Advenced")]
        public Color ChannelColor { 
            get => channelColor; 
            set {            
                channelColor = value;
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public Color SlideColor { 
            get => sliderColor; 
            set {            
                sliderColor = value;
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public Color ForebackColor { 
            get => foreBackColor; 
            set {            
                foreBackColor = value; 
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public int ChannelHeight { 
            get => channelHeight; 
            set {            
                channelHeight = value; 
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public int SliderHeight { 
            get => sliderHeight; 
            set {            
                sliderHeight = value; 
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public TextPosition ShowValue { 
            get => showValue; 
            set {            
                showValue = value; 
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font { 
            get => base.Font;
            set => base.Font = value;
        }
        [Category("kfc Code Advenced")]
        public override Color ForeColor { 
            get => base.ForeColor; 
            set => base.ForeColor = value; 
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (!stopPainting)
            {
                if (!paintedBack)
                {
                    Graphics graphics = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, Width, channelHeight);
                    using (SolidBrush brushChanel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= sliderHeight)
                            rectChannel.Y = Height - channelHeight;
                        else
                            rectChannel.Y = Height - ((channelHeight - sliderHeight) / 2);

                        graphics.Clear(Parent.BackColor);
                        graphics.Clear(Parent.BackColor);
                        graphics.FillRectangle(brushChanel, rectChannel);

                        if(!DesignMode)
                            paintedBack = true;
                    }
                }
                if (Value == Maximum || Value == Minimum)
                    paintedBack = false;

            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!stopPainting)
            {
                Graphics graphics = e.Graphics;
                double scaleFactor = ((double)Value - Minimum) / ((double)Maximum - Minimum);
                int sliderWidth = (int)(Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
                using(SolidBrush brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderHeight >= channelHeight)
                        rectSlider.Y = Height - sliderHeight;
                    else
                        rectSlider.Y = Height - ((sliderHeight + channelHeight) / 2);

                    if (sliderWidth > 1)
                        graphics.FillRectangle(brushSlider, rectSlider);
                    if (ShowValue != TextPosition.None)
                        DrawValueText(graphics, sliderWidth, rectSlider);
                }
            }
            if (Value == Maximum) stopPainting = true;
            else stopPainting = false;
        }

        private void DrawValueText(Graphics graphics, int sliderWidth, Rectangle rectSlider)
        {
            string text = Value.ToString() + "%";
            var TextSize = TextRenderer.MeasureText(text, Font);
            var rectText = new Rectangle(0, 0, TextSize.Width, TextSize.Height + 2);

            using (SolidBrush brushText = new SolidBrush(ForeColor))
            using (SolidBrush brushTextBack = new SolidBrush(foreBackColor))
            using (StringFormat textFormat = new StringFormat())
            {
                switch (ShowValue)
                {
                    case TextPosition.Left:
                        rectText.X = 0;
                        textFormat.Alignment = StringAlignment.Near;
                        break;
                    case TextPosition.Right:
                        rectText.X = Width - TextSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                        break;
                    case TextPosition.Center:
                        rectText.X = (Width - TextSize.Width) / 2;
                        textFormat.Alignment = StringAlignment.Center;
                        break;
                    case TextPosition.Sliding:
                        rectText.X = sliderWidth - TextSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        
                        using(SolidBrush brushClear = new SolidBrush(Parent.BackColor))
                        {
                            var rect = rectSlider;
                            rect.Y = rectText.Y;
                            rect.Height = rectText.Height;
                            
                            graphics.FillRectangle(brushClear, rect);
                        }
                        break;

                }
                graphics.FillRectangle(brushTextBack, rectText);
                graphics.DrawString(text, Font, brushText, rectText, textFormat);
            }
        }
    }
}
