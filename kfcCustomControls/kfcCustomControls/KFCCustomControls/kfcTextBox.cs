using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Frente_de_Caixa.View.CustomControls {
    [DefaultEvent("_TextChanged")]
    public partial class KFCTextBox : UserControl {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool bottomBorder = false;
        private Color borderFocusColor = Color.RoyalBlue;
        private bool isFocused = false;
        private char passwordChar;

        private int borderRadius = 0;
        private Color placeHolderColor = Color.DarkGray;
        private string placeHolderText = "";
        private bool isPlaceHolder = false;
        public KFCTextBox() {
            InitializeComponent();
        }
        //Events
        public event EventHandler _TextChanged;

        //Properties
        [Category("kfc Code Advenced")]
        public Color BorderColor { 
            get => borderColor; 
            set { 
                borderColor = value; 
                Invalidate(); 
            } 
        }
        [Category("kfc Code Advenced")]
        public int BorderSize { 
            get => borderSize; 
            set { 
                borderSize = value; 
                Invalidate(); 
            } 
        }
        [Category("kfc Code Advenced")]
        public bool BottomBorderOnly { 
            get => bottomBorder; 
            set { 
                bottomBorder = value; 
                Invalidate(); 
            } 
        }
        [Category("kfc Code Advenced")]
        public char PasswordChar
        {
            get => textBox1.PasswordChar;
            set
            {
                passwordChar = value;
                textBox1.PasswordChar = passwordChar;
            }
        }
        [Category("kfc Code Advenced")]
        public int MaxLength
        {
            get => textBox1.MaxLength;
            set => textBox1.MaxLength = value;
        }
        [Category("kfc Code Advenced")]
        public bool Multiline { 
            get => textBox1.Multiline; 
            set { 
                textBox1.Multiline = value; 
                Invalidate(); 
            } 
        }
        [Category("kfc Code Advenced")]
        public override Color BackColor { 
            get => base.BackColor; 
            set { 
                base.BackColor = value; 
                textBox1.BackColor = value; 
            } 
        }
        [Category("kfc Code Advenced")]
        public override Color ForeColor { 
            get => base.ForeColor; 
            set { 
                base.ForeColor = value; 
                textBox1.ForeColor = value; 
            } 
        }
        [Category("kfc Code Advenced")]
        public override Font Font { get => base.Font; 
            set { 
                base.Font = value; 
                textBox1.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("kfc Code Advenced")]
        public HorizontalAlignment TextAlign
        {
            get => textBox1.TextAlign;
            set{
                textBox1.TextAlign = value;
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public string Texts {
            get {
                if (isPlaceHolder) return "";
                else return textBox1.Text;
            }
            set { 
                textBox1.Text = value;
                SetPlaceHolder();
            } 
        }
        [Category("kfc Code Advenced")]
        public Color BorderFocusColor { 
            get => borderFocusColor; 
            set { borderFocusColor = value;
            } 
        }
        [Category("kfc Code Advenced")]
        public int BorderRadius { 
            get => borderRadius; 
            set { 
                if(value > 0) {
                    borderRadius = value;
                    Invalidate();
                }
            }
        }
        [Category("kfc Code Advenced")]
        public Color PlaceHolderColor {
            get => placeHolderColor;
            set {
                placeHolderColor = value;
                if (isPlaceHolder)
                    textBox1.ForeColor = value;
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public string PlaceHolderText { 
            get => placeHolderText;
            set {
                placeHolderText = value;
                textBox1.Text = "";
                SetPlaceHolder();
                Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public int CursorIndex
        {
            get => textBox1.SelectionStart;
            set => textBox1.SelectionStart = value;
        }
        
        private void SetPlaceHolder() {
            if(string.IsNullOrWhiteSpace(textBox1.Text) && placeHolderText != "") {
                isPlaceHolder = true;
                textBox1.Text = placeHolderText;
                textBox1.ForeColor = placeHolderColor;
                if (passwordChar != '\0')
                    textBox1.PasswordChar = '\0';

                Invalidate();
            }
        }
        private void RemovePlaceHolder() {
            if (isPlaceHolder && placeHolderText != "") {
                isPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = ForeColor;
                if (passwordChar != '\0')
                    textBox1.PasswordChar = passwordChar;

                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            if(borderRadius > 1) {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize)) {

                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = PenAlignment.Center;

                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (bottomBorder) {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    } else {

                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            } else {
                using (Pen penBorder = new Pen(borderColor, borderSize)) {

                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;

                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (bottomBorder)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, Width - .5f, Height - .5f);
                }
            }
        }
        private void SetTextBoxRoundedRegion() {
            GraphicsPath pathTxt;
            if (Multiline) {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            } else {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect ,int radius) {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseAllFigures();

            return path;
        }
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);

            if(DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            UpdateControlHeight();
        }
        private void UpdateControlHeight() {
            if (textBox1.Multiline == false) {
                int textHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, textHeight);
                textBox1.Multiline = false;

                Height = textBox1.Height + Padding.Top + Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if(_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
        private void textBox1_Click(object sender, EventArgs e) {
            this.OnClick(e);
            Invalidate();
        }
        private void textBox1_MouseEnter(object sender, EventArgs e) {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e) {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e) {
            isFocused = true;
            Invalidate();
            RemovePlaceHolder();
        }

        private void textBox1_Leave(object sender, EventArgs e) {
            isFocused = false;
            Invalidate();
            SetPlaceHolder();
        }
        public void Select(int start, int length)
        {
            textBox1.Select(start, length);
        }
        public void SelectAll()
        {
            textBox1.Select(0, textBox1.Text.length);
        }
        public void DeselectAll()
        {
            textBox1.DeselectAll();
        }

    }
}
