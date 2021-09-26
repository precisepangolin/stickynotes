
namespace stickynotes
{
    partial class StickyNotes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyNotes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorButton2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorButton3 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorButton4 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorButton5 = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.strikeButton = new System.Windows.Forms.ToolStripButton();
            this.bulletButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(166)))));
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.closeToolStripButton,
            this.menuToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(403, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStrip1_MouseDown);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.AutoSize = false;
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newToolStripButton.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Margin = new System.Windows.Forms.Padding(0);
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(33, 33);
            this.newToolStripButton.Text = "+";
            this.newToolStripButton.ToolTipText = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Clicked);
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripButton.AutoSize = false;
            this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeToolStripButton.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripButton.Image")));
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Size = new System.Drawing.Size(33, 33);
            this.closeToolStripButton.Text = "✕";
            this.closeToolStripButton.ToolTipText = "Close";
            this.closeToolStripButton.Click += new System.EventHandler(this.CloseToolStripButton_Clicked);
            // 
            // menuToolStripButton
            // 
            this.menuToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorButton1,
            this.colorButton2,
            this.colorButton3,
            this.colorButton4,
            this.colorButton5,
            this.openMenuItem});
            this.menuToolStripButton.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripButton.Image")));
            this.menuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuToolStripButton.Margin = new System.Windows.Forms.Padding(0);
            this.menuToolStripButton.Name = "menuToolStripButton";
            this.menuToolStripButton.ShowDropDownArrow = false;
            this.menuToolStripButton.Size = new System.Drawing.Size(67, 33);
            this.menuToolStripButton.Text = "···";
            this.menuToolStripButton.ToolTipText = "Menu";
            // 
            // colorButton1
            // 
            this.colorButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(166, 32);
            this.colorButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorButton1.Click += new System.EventHandler(this.ColorButton1_Clicked);
            // 
            // colorButton2
            // 
            this.colorButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.colorButton2.Name = "colorButton2";
            this.colorButton2.Size = new System.Drawing.Size(166, 32);
            this.colorButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorButton2.Click += new System.EventHandler(this.ColorButton2_Clicked);
            // 
            // colorButton3
            // 
            this.colorButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(166)))));
            this.colorButton3.Name = "colorButton3";
            this.colorButton3.Size = new System.Drawing.Size(166, 32);
            this.colorButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorButton3.Click += new System.EventHandler(this.ColorButton3_Clicked);
            // 
            // colorButton4
            // 
            this.colorButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.colorButton4.Name = "colorButton4";
            this.colorButton4.Size = new System.Drawing.Size(166, 32);
            this.colorButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorButton4.Click += new System.EventHandler(this.ColorButton4_Clicked);
            // 
            // colorButton5
            // 
            this.colorButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(227)))), ((int)(((byte)(216)))));
            this.colorButton5.Name = "colorButton5";
            this.colorButton5.Size = new System.Drawing.Size(166, 32);
            this.colorButton5.Click += new System.EventHandler(this.ColorButton5_Clicked);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(166, 32);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 26);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(166)))));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.strikeButton,
            this.bulletButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 217);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(403, 36);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // boldButton
            // 
            this.boldButton.AutoSize = false;
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Margin = new System.Windows.Forms.Padding(6, 1, 4, 2);
            this.boldButton.Name = "boldButton";
            this.boldButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.boldButton.Size = new System.Drawing.Size(33, 33);
            this.boldButton.Text = "B";
            this.boldButton.ToolTipText = "Bold";
            this.boldButton.Click += new System.EventHandler(this.BoldButton_Clicked);
            // 
            // italicButton
            // 
            this.italicButton.AutoSize = false;
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Margin = new System.Windows.Forms.Padding(2, 1, 4, 2);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(33, 33);
            this.italicButton.Text = "I";
            this.italicButton.ToolTipText = "Italic";
            this.italicButton.Click += new System.EventHandler(this.ItalicButton_Clicked);
            // 
            // underlineButton
            // 
            this.underlineButton.AutoSize = false;
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underlineButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Margin = new System.Windows.Forms.Padding(4, 1, 2, 2);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(33, 33);
            this.underlineButton.Text = "U";
            this.underlineButton.ToolTipText = "Underline";
            this.underlineButton.Click += new System.EventHandler(this.UnderlineButton_Clicked);
            // 
            // strikeButton
            // 
            this.strikeButton.AutoSize = false;
            this.strikeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strikeButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.strikeButton.Image = ((System.Drawing.Image)(resources.GetObject("strikeButton.Image")));
            this.strikeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikeButton.Margin = new System.Windows.Forms.Padding(2, 1, 4, 2);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(33, 33);
            this.strikeButton.Text = "S";
            this.strikeButton.ToolTipText = "Strikethrough";
            this.strikeButton.Click += new System.EventHandler(this.StrikeButton_Clicked);
            // 
            // bulletButton
            // 
            this.bulletButton.AutoSize = false;
            this.bulletButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bulletButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bulletButton.Image = ((System.Drawing.Image)(resources.GetObject("bulletButton.Image")));
            this.bulletButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bulletButton.Margin = new System.Windows.Forms.Padding(2, 0, 1, 2);
            this.bulletButton.Name = "bulletButton";
            this.bulletButton.Size = new System.Drawing.Size(33, 33);
            this.bulletButton.Text = "⠸☰";
            this.bulletButton.ToolTipText = "Toggle Bullets";
            this.bulletButton.Click += new System.EventHandler(this.BulletButton_Clicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 2, 5);
            this.panel1.Size = new System.Drawing.Size(403, 184);
            this.panel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(5, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(396, 174);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // StickyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(1F, 2F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(403, 253);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Lucida Console", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 200);
            this.Name = "StickyNotes";
            this.ShowIcon = false;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton menuToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripButton strikeButton;
        private System.Windows.Forms.ToolStripButton bulletButton;
        private System.Windows.Forms.ToolStripMenuItem colorButton1;
        private System.Windows.Forms.ToolStripMenuItem colorButton2;
        private System.Windows.Forms.ToolStripMenuItem colorButton3;
        private System.Windows.Forms.ToolStripMenuItem colorButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem colorButton5;
    }
}

