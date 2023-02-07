/*
* Created using SharpDevelop.
* User: OftenGuy
* Date: February 6, 2023
* Time: 4:42 PM
*
* To change this template use Tools | Options | Coding | Edit Standard Headers.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace SplittenStudio {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      this.Text = "Splitten Studio";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Width = 1280;
      this.Height = 720;
      this.BackColor = Color.FromArgb(150, 150, 150);
      // this.FormBorderStyle = Style.Windows.Forms.FormBorderStyle.NONE;
      Button minimizeButton = new Button();
      this.Controls.Add(minimizeButton);
      minimizeButton.Text = "-";
      minimizeButton.Location = new Point(1125, 0);
      minimizeButton.Size = new Size(50, 35);
      minimizeButton.Click += new EventHandler(minimizeButtonClicked);
      minimizeButton.Cursor = Cursors.Hand;
      ToolTip minimizeToolTip = new ToolTip();
			minimizeToolTip.AutoPopDelay = 5000;
			minimizeToolTip.InitialDelay = 1000;
			minimizeToolTip.ReshowDelay = 500;
			minimizeToolTip.ShowAlways = true;
			minimizeToolTip.SetToolTip(minimizeButton, "Minimize");
      Button maximizeButton = new Button();
      this.Controls.Add(maximizeButton);
      maximizeButton.Text = "+";
      maximizeButton.Location = new Point(1170, 0);
      maximizeButton.Size = new Size(50, 35);
      maximizeButton.Click += new EventHandler(maximizeButtonClicked);
      maximizeButton.Cursor = Cursors.Hand;
      ToolTip maximizeTooltip = new ToolTip();
			maximizeToolTip.AutoPopDelay = 5000;
			maximizeToolTip.InitialDelay = 1000;
			maximizeToolTip.ReshowDelay = 500;
			maximizeToolTip.ShowAlways = true;
			maximizeToolTip.SetToolTip(maximizeButton, "Maximize");
      Button exitButton = new Button();
      this.Controls.Add(exitButton);
      exitButton.Text = "X";
      exitButton.Location = new Point(1215, 0);
      exitButton.Size = new Size(50, 35);
      exitButton.Click += new EventHandler(exitButtonClicked);
      exitButton.Click = Cursors.Hand;
      ToolTip exitToolTip = new ToolTip();
			exitToolTip.AutoPopDelay = 5000;
			exitToolTip.InitialDelay = 1000;
			exitToolTip.ReshowDelay = 500;
			exitToolTip.ShowAlways = true;
			exitToolTip.SetToolTip(exitButton, "Exit");
    }
    void MainFormLoad(object sender, EventArgs eventArgs) {}
    void minimizeButtonClicked(object sender, EventArgs eventArgs) {
        this.WindowState = FormWindowState.Minimized;
    }
    void maximizeButtonClicked(object sender, EventArgs eventArgs) {
        this.WindowState = FormWindowState.Maximized;
    }
    void exitButtonClicked(object sender, EventArgs eventArgs) {
        var button = sender as Button;
        if(button.Text == "X") {
            this.Close();
        }
    }
  }
}
