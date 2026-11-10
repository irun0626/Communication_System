using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zhaoxi.IntelligentWaterStorageMonitorSystem
{
    public class StatusLight : ToolStripLabel
    {
        private bool _isConnected;

        public bool IsConnected
        {
            get => _isConnected;
            set
            {
                _isConnected = value;
                Invalidate(); // 改状态自动重绘，刷新颜色
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 圆点位置大小
            Rectangle circleRect = new Rectangle(4, 4, 14, 14);
            Color fillColor = _isConnected ? Color.LimeGreen : Color.Red;
            g.FillEllipse(new SolidBrush(fillColor), circleRect);
        }
    }
}
