/*
 * Created using SharpDevelop.
 * User: OftenGuy
 * Date: February 8, 2023
 * Time: 3:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;
 using System.Drawing;
 using System.Drawing.Drawing2D;
 using System.Windows.Forms;
 namespace SplittenStudio {
    public class TitleBarButtons : Button {
        protected override void OnPaint(PaintEventArgs e) {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);
            base.OnPaint(e);
       }
    }
 }
