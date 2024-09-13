using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace NazyrikNET
{
    public partial class Autorization : Form
    {
        private Register register;
        private WriteLetter writeLetter;
        public Autorization()
        {
            InitializeComponent();
            register = new Register(this) { Visible = false };
            writeLetter = new WriteLetter(this) { Visible = false };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(panel1.Parent.BackColor);
            Control control = panel1;
            int radius = 30;
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddLine(radius, 0, control.Width - radius, 0);
                path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                path.AddLine(control.Width, radius, control.Width, control.Height - radius);
                path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                path.AddLine(control.Width - radius, control.Height, radius, control.Height);
                path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
                path.AddLine(0, control.Height - radius, 0, radius);
                path.AddArc(0, 0, radius, radius, 180, 90);
                using (SolidBrush brush = new SolidBrush(control.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private void buttonEnter_mainForm_Click(object sender, EventArgs e)
        {
            bool warning = false;
            if ((textBoxLogin == null || textBoxLogin.Text == "") || (textBoxPassword == null || textBoxPassword.Text == ""))
                { labelImpField1.Visible = true; warning = true; }
            else { labelImpField1.Visible = false; warning = false; }


            if (writeLetter == null || writeLetter.IsDisposed)
            { WriteLetter writeLetter = new WriteLetter(this); writeLetter.Show(); Hide(); }
            else
            { writeLetter.Show(); Hide(); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkArea = new LinkArea(0, 18);
            if (register == null || register.IsDisposed)
            { Register register = new Register(this); register.Show(); Hide(); }
            else
            { register.Show(); Hide(); }
        }
    }
}
