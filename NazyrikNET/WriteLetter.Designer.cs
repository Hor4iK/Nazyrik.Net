namespace NazyrikNET
{
    partial class WriteLetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteLetter));
            this.panel_newLetter = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panelbutton_let = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelbutton_rec = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelbutton_new = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panelbutton_let.SuspendLayout();
            this.panelbutton_rec.SuspendLayout();
            this.panelbutton_new.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_newLetter
            // 
            this.panel_newLetter.BackColor = System.Drawing.Color.White;
            this.panel_newLetter.Location = new System.Drawing.Point(96, 100);
            this.panel_newLetter.Name = "panel_newLetter";
            this.panel_newLetter.Size = new System.Drawing.Size(1068, 862);
            this.panel_newLetter.TabIndex = 2;
            this.panel_newLetter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_newLetter_Paint);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.Controls.Add(this.linkLabel2);
            this.panel_menu.Controls.Add(this.panelbutton_let);
            this.panel_menu.Controls.Add(this.panelbutton_rec);
            this.panel_menu.Controls.Add(this.panelbutton_new);
            this.panel_menu.Controls.Add(this.panel1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1262, 67);
            this.panel_menu.TabIndex = 3;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(1175, 20);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(66, 24);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Выйти";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panelbutton_let
            // 
            this.panelbutton_let.BackColor = System.Drawing.Color.Transparent;
            this.panelbutton_let.Controls.Add(this.button3);
            this.panelbutton_let.Location = new System.Drawing.Point(606, 11);
            this.panelbutton_let.Name = "panelbutton_let";
            this.panelbutton_let.Size = new System.Drawing.Size(227, 43);
            this.panelbutton_let.TabIndex = 4;
            this.panelbutton_let.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbutton_let_Paint);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "История сообщений";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panelbutton_rec
            // 
            this.panelbutton_rec.BackColor = System.Drawing.Color.Transparent;
            this.panelbutton_rec.Controls.Add(this.button2);
            this.panelbutton_rec.Location = new System.Drawing.Point(331, 11);
            this.panelbutton_rec.Name = "panelbutton_rec";
            this.panelbutton_rec.Size = new System.Drawing.Size(233, 43);
            this.panelbutton_rec.TabIndex = 3;
            this.panelbutton_rec.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbutton_rec_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "История получателей";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelbutton_new
            // 
            this.panelbutton_new.BackColor = System.Drawing.Color.Transparent;
            this.panelbutton_new.Controls.Add(this.button1);
            this.panelbutton_new.Location = new System.Drawing.Point(98, 11);
            this.panelbutton_new.Name = "panelbutton_new";
            this.panelbutton_new.Size = new System.Drawing.Size(189, 43);
            this.panelbutton_new.TabIndex = 1;
            this.panelbutton_new.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbutton_new_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Написать письмо";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NazyrikNET.Properties.Resources.profile;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1098, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 0;
            // 
            // WriteLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.BackgroundImage = global::NazyrikNET.Properties.Resources.backgroundForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 1055);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_newLetter);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 1130);
            this.MinimumSize = new System.Drawing.Size(1140, 900);
            this.Name = "WriteLetter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Написать письмо";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panelbutton_let.ResumeLayout(false);
            this.panelbutton_rec.ResumeLayout(false);
            this.panelbutton_new.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_newLetter;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelbutton_new;
        private System.Windows.Forms.Panel panelbutton_let;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelbutton_rec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}