/*
 * Created using SharpDevelop.
 * User: OftenGuy
 * Date: February 12, 2023
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;
 using System.Drawing;
 using System.Drawing.Drawing2D;
 using System.Windows.Forms;
 namespace SplittenStudio {
    public class LogoButton : Button {
        protected override void OnPaint(PaintEventArgs pevent) {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float width = this.Width;
            float height = this.Height;
            PointF[] points = new PointF[] {new Point(width / 2, 0), new PointF(0, width), new PointF(width, height)};
            graphics.FillPolygon(new SolidBrush(this.BackColor), points);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddPolygon(points);
            this.Region = new Region(graphicsPath);
            base.OnPaint(pevent);
        }
    }
 }
