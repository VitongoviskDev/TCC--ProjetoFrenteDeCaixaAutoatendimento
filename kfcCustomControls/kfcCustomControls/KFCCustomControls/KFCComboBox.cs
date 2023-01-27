using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace kfcCustomControls.KFCCustomControls {
    [DefaultEvent("OnSelectedIndexChanged")]
    public class KFCComboBox : UserControl {
        private Color backColor = Color.Black;
        private Color iconColor = Color.White;
        private Color listBackColor = Color.DimGray;
        private Color listTextColor = Color.White;
        private Color borderColor = Color.Black;
        private int borderSize = 1;

        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        [Category("kfc Code Advenced")]
        public new Color BackColor {
            get => backColor;
            set {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }
        [Category("kfc Code Advenced")]
        public Color IconColor {
            get => iconColor;
            set {
                iconColor = value;
                btnIcon.Invalidate();
            }
        }
        [Category("kfc Code Advenced")]
        public Color ListBackColor {
            get => listBackColor;
            set {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }
        [Category("kfc Code Advenced")]
        public Color ListTextColor {
            get => listTextColor;
            set {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }
        [Category("kfc Code Advenced")]
        public Color BorderColor {
            get => borderColor;
            set {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }
        [Category("kfc Code Advenced")]
        public int BorderSize {
            get => borderSize;
            set {
                borderSize = value;
                Padding = new Padding(BorderSize);
                AdjustComboBoxDimensions();
            }
        }
        [Category("kfc Code Advenced")]
        public override Color ForeColor {
            get => base.ForeColor;
            set {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }
        [Category("kfc Code Advenced")]
        public override Font Font {
            get => base.Font;
            set {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;
            }
        }
        [Category("kfc Code Advenced")]
        public string Texts {
            get => lblText.Text;
            set {
                lblText.Text = value;
            }
        }
        [Category("kfc Code Advenced")]
        public ComboBoxStyle DropDownStyle {
            get => cmbList.DropDownStyle;
            set {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        //Items
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        [Category("KFC Combo Box Data")]
        public ComboBox.ObjectCollection Items { get => cmbList.Items; }

        //Data Source
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        [AttributeProvider(typeof(IListSource))]
        [Category("KFC Combo Box Data")]
        public object DataSource {
            get => cmbList.DataSource;
            set => cmbList.DataSource = value;
        }

        //Auto Complete Mode
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("KFC Combo Box Data")]
        public AutoCompleteMode AutoCompleteMode {
            get => cmbList.AutoCompleteMode;
            set => cmbList.AutoCompleteMode = value;
        }

        //Auto Complete Source
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("KFC Combo Box Data")]
        public AutoCompleteSource AutoCompleteSource {
            get => cmbList.AutoCompleteSource;
            set => cmbList.AutoCompleteSource = value;
        }

        //Auto Complete Custom Source
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("KFC Combo Box Data")]
        public AutoCompleteStringCollection AutoCompleteCustomSource {
            get => cmbList.AutoCompleteCustomSource;
            set => cmbList.AutoCompleteCustomSource = value;
        }

        //Selected Index
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("KFC Combo Box Data")]
        public  int SelectedIndex {
            get => cmbList.SelectedIndex; 
            set => cmbList.SelectedIndex = value;
        }

        //Selected Item
        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("KFC Combo Box Data")]
        public object SelectedItem {
            get => cmbList.SelectedItem; 
            set => cmbList.SelectedItem = value;
        }


        public event EventHandler OnSelectedIndexChanged;
        public event EventHandler btnDropDownClick;

        public KFCComboBox() {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            SuspendLayout();

            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(Font.Name, 10f);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(btnIcon_Click);
            btnIcon.Paint += new PaintEventHandler(btnIcon_Paint);

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(0,0,0,0);
            lblText.Font = new Font(Font.Name, 10f);
            lblText.Click += new EventHandler(Surface_Click);
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            Controls.Add(lblText);
            Controls.Add(btnIcon);
            Controls.Add(cmbList);
            MinimumSize = new Size(200, 30);
            Size = new Size(200, 30);
            ForeColor = Color.DimGray;
            Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            ResumeLayout();
            AdjustComboBoxDimensions();
        }
        private void AdjustComboBoxDimensions() {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point() {
                X = Width - Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
        }
        private void btnIcon_Paint(object sender, PaintEventArgs e) {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2)) {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }
        private void btnIcon_Click(object sender, EventArgs e) {
            cmbList.Select();
            cmbList.DroppedDown = true;

            if (btnDropDownClick != null)
                btnDropDownClick.Invoke(sender, e);

        }
        private void ComboBox_TextChanged(object sender, EventArgs e) {
            lblText.Text = cmbList.Text;
        }
        private void Surface_Click(object sender, EventArgs e) {
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;

            OnClick(e);
        }
        private void Surface_MouseEnter(object sender, EventArgs e) {
            OnMouseEnter(e);
        }
        private void Surface_MouseLeave(object sender, EventArgs e) {
            OnMouseLeave(e);
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
