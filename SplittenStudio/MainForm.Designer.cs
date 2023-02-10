/*
 * Created using SharpDevelop.
 * User: OftenGuy
 * Date: February 6, 2023
 * Time: 4:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace SplittenStudio {
	partial class MainForm {
		private IContainer components = null;
		protected override void Dispose(bool disposing) {
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		#region
		private void InitializeComponent() {
			this.SuspendLayout();
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(800, 450);
			this.Name = "SplittenStudio";
			this.Text = "Splitten Studio";
			this.TransparencyKey = Color.Gray;
			this.Load += new EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		#endregion
	}
}
