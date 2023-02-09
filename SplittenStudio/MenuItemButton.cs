/*
 * Created using SharpDevelop.
 * User: OftenGuy
 * Date: February 8, 2023
 * Time: 9:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;
 using System.Drawing;
 using System.Windows.Forms;
 namespace SplittenStudio {
    public class MenuItemButton : Button {
        public MenuItemButton() {
            this.BackColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.ForeColor = System.Drawing.Color.White;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Harvest", 15, System.Drawing.FontStyle.Regular);
            this.Cursor = Cursors.Hand;
            this.Size = new System.Drawing.Size(70, 40);
        }
    }
 }
