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
      // Title Bar Buttons
      TitleBarButton minimizeButton = new TitleBarButton();
      this.Controls.Add(minimizeButton);
      minimizeButton.Text = "-";
      minimizeButton.Location = new Point(1135, 0);
      minimizeButton.Size = new Size(30, 30);
      minimizeButton.Click += new EventHandler(minimizeButtonClicked);
      minimizeButton.Cursor = Cursors.Hand;
      minimizeButton.BackColor = Color.FromArgb(100, 100, 100);
      minimizeButton.ForeColor = Color.FromArgb(200, 200, 200);
      minimizeButton.Font = new Font(minimizeButton.Font.Name, minimizeButton.Font.Size, FontStyle.Bold);
      minimizeButton.FlatStyle = FlatStyle.Flat;
      minimizeButton.FlatAppearance.BorderSize = 0;
      ToolTip minimizeToolTip = new ToolTip();
      minimizeToolTip.AutoPopDelay = 5000;
      minimizeToolTip.InitialDelay = 1000;
      minimizeToolTip.ReshowDelay = 500;
      minimizeToolTip.ShowAlways = true;
      minimizeToolTip.SetToolTip(minimizeButton, "Minimize");
      TitleBarButton maximizeButton = new TitleBarButton();
      this.Controls.Add(maximizeButton);
      maximizeButton.Text = "+";
      maximizeButton.Location = new Point(1180, 0);
      maximizeButton.Size = new Size(30, 30);
      maximizeButton.Click += new EventHandler(maximizeButtonClicked);
      maximizeButton.Cursor = Cursors.Hand;
      maximizeButton.BackColor = Color.FromArgb(100, 100, 100);
      maximizeButton.ForeColor = Color.FromArgb(200, 200, 200);
      maximizeButton.Font = new Font(maximizeButton.Font.Name, maximizeButton.Font.Size, FontStyle.Bold);
      maximizeButton.FlatStyle = FlatStyle.Flat;
      maximizeButton.FlatAppearance.BorderSize = 0;
      ToolTip maximizeToolTip = new ToolTip();
      maximizeToolTip.AutoPopDelay = 5000;
      maximizeToolTip.InitialDelay = 1000;
      maximizeToolTip.ReshowDelay = 500;
      maximizeToolTip.ShowAlways = true;
      maximizeToolTip.SetToolTip(maximizeButton, "Maximize");
      TitleBarButton exitButton = new TitleBarButton();
      this.Controls.Add(exitButton);
      exitButton.Text = "X";
      exitButton.Location = new Point(1225, 0);
      exitButton.Size = new Size(30, 30);
      exitButton.Click += new EventHandler(exitButtonClicked);
      exitButton.Cursor = Cursors.Hand;
      exitButton.BackColor = Color.FromArgb(100, 100, 100);
      exitButton.ForeColor = Color.FromArgb(200, 200, 200);
      exitButton.Font = new Font(exitButton.Font.Name, exitButton.Font.Size, FontStyle.Bold);
      exitButton.FlatStyle = FlatStyle.Flat;
      exitButton.FlatAppearance.BorderSize = 0;
      ToolTip exitToolTip = new ToolTip();
      exitToolTip.AutoPopDelay = 5000;
      exitToolTip.InitialDelay = 1000;
      exitToolTip.ReshowDelay = 500;
      exitToolTip.ShowAlways = true;
      exitToolTip.SetToolTip(exitButton, "Close");
      // Menu
      MenuItemButton file = new MenuItemButton();
      this.Controls.Add(file);
      file.Text = "FILE";
      file.Location = new Point(0, -5);
      ToolTip fileToolTip = new ToolTip();
      fileToolTip.AutoPopDelay = 5000;
      fileToolTip.InitialDelay = 1000;
      fileToolTip.ReshowDelay = 500;
      fileToolTip.ShowAlways = true;
      fileToolTip.SetToolTip(file, "File");
      MenuItemButton edit = new MenuItemButton();
      this.Controls.Add(edit);
      edit.Text = "EDIT";
      edit.Location = new Point(70, -5);
      ToolTip editToolTip = new ToolTip();
      editToolTip.AutoPopDelay = 5000;
      editToolTip.InitialDelay = 1000;
      editToolTip.ShowAlways = true;
      editToolTip.SetToolTip(edit, "Edit");
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
