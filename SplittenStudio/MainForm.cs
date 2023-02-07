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
    }
    void MainFormLoad(object sender, EventArgs eventArgs) {}
  }
}
