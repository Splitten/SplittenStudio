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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SplittenStudio {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      // this.Icon = new System.Drawing.Icon("SplittenLogo.ico", 100, 100); <- DOES NOT FRICKING WORK
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
      minimizeButton.Location = new Point(1135, 5);
      minimizeButton.Size = new Size(30, 30);
      minimizeButton.Click += new EventHandler(MinimizeButtonClicked);
      minimizeButton.Cursor = Cursors.Hand;
      minimizeButton.BackColor = Color.FromArgb(100, 100, 100);
      minimizeButton.ForeColor = Color.FromArgb(200, 200, 200);
      minimizeButton.Font = new Font(minimizeButton.Font.Name, minimizeButton.Font.Size, FontStyle.Bold);
      minimizeButton.FlatStyle = FlatStyle.Flat;
      minimizeButton.FlatAppearance.BorderSize = 0;
      minimizeButton.Padding = new Padding(5);
      ToolTip minimizeToolTip = new ToolTip();
      minimizeToolTip.AutoPopDelay = 5000;
      minimizeToolTip.InitialDelay = 1000;
      minimizeToolTip.ReshowDelay = 500;
      minimizeToolTip.ShowAlways = true;
      minimizeToolTip.SetToolTip(minimizeButton, "Minimize");
      TitleBarButton maximizeButton = new TitleBarButton();
      this.Controls.Add(maximizeButton);
      maximizeButton.Text = "+";
      maximizeButton.Location = new Point(1180, 5);
      maximizeButton.Size = new Size(30, 30);
      maximizeButton.Click += new EventHandler(MaximizeButtonClicked);
      maximizeButton.Cursor = Cursors.Hand;
      maximizeButton.BackColor = Color.FromArgb(100, 100, 100);
      maximizeButton.ForeColor = Color.FromArgb(200, 200, 200);
      maximizeButton.Font = new Font(maximizeButton.Font.Name, maximizeButton.Font.Size, FontStyle.Bold);
      maximizeButton.FlatStyle = FlatStyle.Flat;
      maximizeButton.FlatAppearance.BorderSize = 0;
      maximizeButton.Padding = new Padding(5);
      ToolTip maximizeToolTip = new ToolTip();
      maximizeToolTip.AutoPopDelay = 5000;
      maximizeToolTip.InitialDelay = 1000;
      maximizeToolTip.ReshowDelay = 500;
      maximizeToolTip.ShowAlways = true;
      maximizeToolTip.SetToolTip(maximizeButton, "Maximize");
      TitleBarButton closeButton = new TitleBarButton();
      this.Controls.Add(closeButton);
      closeButton.Text = "X";
      closeButton.Location = new Point(1225, 5);
      closeButton.Size = new Size(30, 30);
      closeButton.Click += new EventHandler(CloseButtonClicked);
      closeButton.Cursor = Cursors.Hand;
      closeButton.BackColor = Color.FromArgb(100, 100, 100);
      closeButton.ForeColor = Color.FromArgb(200, 200, 200);
      closeButton.Font = new Font(closeButton.Font.Name, closeButton.Font.Size, FontStyle.Bold);
      closeButton.FlatStyle = FlatStyle.Flat;
      closeButton.FlatAppearance.BorderSize = 0;
      closeButton.Padding = new Padding(5);
      ToolTip closeToolTip = new ToolTip();
      closeToolTip.AutoPopDelay = 5000;
      closeToolTip.InitialDelay = 1000;
      closeToolTip.ReshowDelay = 500;
      closeToolTip.ShowAlways = true;
      closeToolTip.SetToolTip(closeButton, "Close");
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
      MenuItemButton view = new MenuItemButton();
      this.Controls.Add(view);
      view.Text = "VIEW";
      view.Location = new Point(140, -5);
      ToolTip viewToolTip = new ToolTip();
      viewToolTip.AutoPopDelay = 5000;
      viewToolTip.InitialDelay = 1000;
      viewToolTip.ShowAlways = true;
      viewToolTip.SetToolTip(view, "View");
      // Logo
    }
    void MainFormLoad(object sender, EventArgs eventArgs) {}
    void MinimizeButtonClicked(object sender, EventArgs eventArgs) {
        this.WindowState = FormWindowState.Minimized;
    }
    void MaximizeButtonClicked(object sender, EventArgs eventArgs) {
        this.WindowState = FormWindowState.Maximized;
    }
    void CloseButtonClicked(object sender, EventArgs eventArgs) {
        var button = sender as Button;
        if(button.Text == "X") {
            this.Close();
        }
    }
  }
}
