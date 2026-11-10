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
    public class UGroupPanel : Panel
    {
        private string _groupTitle = "";
        private readonly int _titleHeight = 34;
        private readonly Color _titleBg = Color.FromArgb(22, 98, 170);
        private readonly Font _titleFont = new Font("微软雅黑", 11, FontStyle.Bold);

        [System.ComponentModel.Browsable(true)]
        public string GroupTitle
        {
            get => _groupTitle;
            set { _groupTitle = value; Invalidate(); }
        }

        public UGroupPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 标题蓝色背景
            Rectangle titleRect = new Rectangle(0, 0, Width, _titleHeight);
            using (SolidBrush brush = new SolidBrush(_titleBg))
            {
                g.FillRectangle(brush, titleRect);
            }

            // 标题文字
            if (!string.IsNullOrEmpty(_groupTitle))
            {
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    float y = (_titleHeight - g.MeasureString(_groupTitle, _titleFont).Height) / 2;
                    g.DrawString(_groupTitle, _titleFont, textBrush, 12, y);
                }
            }

            // 边框
            using (Pen pen = new Pen(Color.LightGray))
            {
                g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }

        // 释放字体资源
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _titleFont?.Dispose();
            }
            base.Dispose(disposing);
        }

        // 子控件自动往下偏移，不会被蓝色标题盖住
        protected override ControlCollection CreateControlsInstance()
        {
            return new GroupControlCollection(this);
        }

        public class GroupControlCollection : ControlCollection
        {
            private readonly UGroupPanel _owner;
            public GroupControlCollection(UGroupPanel owner) : base(owner) => _owner = owner;

            public override void Add(Control control)
            {
                base.Add(control);
                // 设计器模式不偏移，避免控件反复叠加下移
                if (!_owner.DesignMode)
                {
                    control.Top += _owner._titleHeight;
                }
                control.Margin = new Padding(8);
            }
        }
    }
}
