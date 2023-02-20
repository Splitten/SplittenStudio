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
      /* Buttons */
      LogoButton logoButton1 = new LogoButton();
      this.Controls.Add(logoButton1);
      logoButton1.LeftColor = Color.FromArgb(180, 180, 180);
      logoButton1.RightColor = Color.FromArgb(235, 235, 235);
      logoButton1.Width = 25;
      logoButton1.Height = 25;
      logoButton1.Location = new Point(560, 10);
      logoButton1.Cursor = Cursors.Hand;
      ToolTip logoButton1ToolTip = new ToolTip();
      logoButton1ToolTip.AutoPopDelay = 5000;
      logoButton1ToolTip.InitialDelay = 1000;
      logoButton1ToolTip.ShowAlways = true;
      logoButton1ToolTip.SetToolTip(logoButton1, "Splitten");
      LogoButton logoButton2 = new LogoButton();
      this.Controls.Add(logoButton2);
      logoButton2.LeftColor = Color.FromArgb(235, 235, 235);
      logoButton2.RightColor = Color.FromArgb(180, 180, 180);
      logoButton2.Width = 25;
      logoButton2.Height = 25;
      logoButton2.Location = new Point(710, 10);
      logoButton2.Cursor = Cursors.Hand;
      ToolTip logoButton2ToolTip = new ToolTip();
      logoButton2ToolTip.AutoPopDelay = 5000;
      logoButton2ToolTip.InitialDelay = 1000;
      logoButton2ToolTip.ShowAlways = true;
      logoButton2ToolTip.SetToolTip(logoButton2, "Splitten");
      /* Text */
      Label logoText = new Label();
      this.Controls.Add(logoText);
      logoText.BackColor = Color.Transparent;
      logoText.ForeColor = Color.FromArgb(222, 222, 222);
      logoText.Text = "SPLITTEN";
      logoText.Font = new Font("Impact", 16, FontStyle.Italic);
      logoText.Location = new Point(600, 10);
      logoText.Cursor = Cursors.Hand;
      ToolTip logoTextToolTip = new ToolTip();
      logoTextToolTip.AutoPopDelay = 5000;
      logoTextToolTip.InitialDelay = 1000;
      logoTextToolTip.ShowAlways = true;
      logoTextToolTip.SetToolTip(logoText, "Splitten");
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
