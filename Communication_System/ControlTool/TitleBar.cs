using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communication_System.ControlTool
{
    public class TitleBar : Panel
    {
        private string _titleText = "";
        private Image _icon;
        private Color _bgColor = Color.FromArgb(22, 98, 170);
        private Font _titleFont = new Font("微软雅黑", 14, FontStyle.Regular);

        [System.ComponentModel.Browsable(true)]
        public string TitleText
        {
            get => _titleText;
            set { _titleText = value; Invalidate(); }
        }
        [System.ComponentModel.Browsable(true)]
        public Image Icon
        {
            get => _icon;
            set { _icon = value; Invalidate(); }
        }
        public TitleBar()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Height = 44;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(_bgColor))
            {
                g.FillRectangle(brush, ClientRectangle);
            }
            int iconSize = 32;
            int margin = 8;
            if (_icon != null)
            {
                Rectangle iconRect = new Rectangle(margin, (Height - iconSize) / 2, iconSize, iconSize);
                g.DrawImage(_icon, iconRect);
            }
            float textX = margin + iconSize + 8;
            float textY = (Height - g.MeasureString(_titleText, _titleFont).Height) / 2;
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            {
                g.DrawString(_titleText, _titleFont, textBrush, textX, textY);
            }
        }
    }
}
