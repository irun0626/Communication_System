using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Communication_System.ControlTool
{
    public class UPipeVertical : Control
    {
        private bool _active;
        private readonly Color _pipeNormal = Color.FromArgb(180, 185, 192);
        private readonly Color _pipeRun = Color.FromArgb(22, 98, 170);

        [System.ComponentModel.Browsable(true)]
        public bool Active
        {
            get => _active;
            set { _active = value; Invalidate(); }
        }

        public UPipeVertical()
        {
            DoubleBuffered = true;
            // 关键：开启支持透明背景的样式
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
            // 不要写 BackColor = Color.Transparent; 放到这里依然会报错
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 管道居中，宽度固定6px
            int pipeW = 3;
            int x = (Width - pipeW) / 2;
            Rectangle pipeRect = new Rectangle(x, 0, pipeW, Height);

            Color c = _active ? _pipeRun : _pipeNormal;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(x, 0),
                new Point(x + pipeW, 0),
                ControlPaint.Light(c, 0.6f),
                c))
            {
                FillRoundedRectangle(g, brush, pipeRect, 3);
            }
        }

        private static void FillRoundedRectangle(Graphics g, Brush brush, Rectangle rect, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                g.FillPath(brush, path);
            }
        }
    }
}
