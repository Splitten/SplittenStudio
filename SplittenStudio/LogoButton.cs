/*
 * Created using SharpDevelop.
 * User: OftenGuy
 * Date: February 20, 2023
 * Time: 1:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SplittenStudio {
	public class LogoButton : Button {
		private Color leftColor = Color.FromArgb(0, 0, 0);
		private Color rightColor = Color.FromArgb(0, 0, 0);
		public Color LeftColor {
			get {
				return leftColor;
			}
			set {
				leftColor = value;
				this.Invalidate();
			}
		}
		public Color RightColor {
			get {
				return rightColor;
			}
			set {
				rightColor = value;
				this.Invalidate();
			}
		}
		protected override void OnPaint(PaintEventArgs pevent) {
			base.OnPaint(pevent);
			LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, leftColor, rightColor, 180F);
			pevent.Graphics.FillRectangle(brush, this.ClientRectangle);
			brush.Dispose();
			SizeF textSize = pevent.Graphics.MeasureString(this.Text, this.Font);
			pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
		}
	}
}
