using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stickynotes
{
    public partial class StickyNotes : Form
    {
        #region generalWindow
        public Color[] bgColors = {
        System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(204)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(185)))), ((int)(((byte)(190))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(201)))), ((int)(((byte)(195))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(227)))), ((int)(((byte)(216)))))
        };
        public Color backColor;
        protected override void OnLoad(EventArgs e)
        {
            backColor = bgColors[3];
            this.toolStrip1.BackColor = this.toolStrip2.BackColor = this.richTextBox1.BackColor = this.panel1.BackColor = backColor;
            base.OnLoad(e);
            //this.toolStrip1.Renderer = this.toolStrip2.Renderer = new MySR();
        }
        // make toolstrips appear/disappear when active or unactive
        protected override void OnActivated (EventArgs e)
        {
            this.ControlBox = false;
            this.toolStrip1.Visible = true;
            this.toolStrip2.Visible = true;
        }
        protected override void OnDeactivate(EventArgs e)
        {
            this.ControlBox = false;
            this.toolStrip1.Visible = false;
            this.toolStrip2.Visible = false;
        }
        public StickyNotes()
        {
            InitializeComponent();
        }
        // drag window when toolStrip1 is held
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private void ToolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // renderer for toolStrip1 to remove border - need to change renderer in designer/onLoad
        public class MySR : ToolStripSystemRenderer
        {
            public MySR() { }
            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                if (e.ToolStrip.GetType() == typeof(ToolStrip))
                {
                // skip render border
                }
                else
                {
                // do render border
                base.OnRenderToolStripBorder(e);
                }
            }
        }
        #endregion
        #region colorMenu

        public void ColorButton1_Clicked(object sender, EventArgs e)
        {
            this.toolStrip1.BackColor = this.toolStrip2.BackColor = this.richTextBox1.BackColor = this.panel1.BackColor = bgColors[0];
        }
        public void ColorButton2_Clicked(object sender, EventArgs e)
        {
            this.toolStrip1.BackColor = this.toolStrip2.BackColor = this.richTextBox1.BackColor = this.panel1.BackColor = bgColors[1];
        }
        public void ColorButton3_Clicked(object sender, EventArgs e)
        {
            this.toolStrip1.BackColor = this.toolStrip2.BackColor = this.richTextBox1.BackColor = this.panel1.BackColor = bgColors[2];
        }
        public void ColorButton4_Clicked(object sender, EventArgs e)
        {
            this.toolStrip1.BackColor = this.toolStrip2.BackColor = this.richTextBox1.BackColor = this.panel1.BackColor = bgColors[3];
        }
        public void ColorButton5_Clicked(object sender, EventArgs e)
        {
            this.toolStrip1.BackColor = this.toolStrip2.BackColor = this.richTextBox1.BackColor = this.panel1.BackColor = bgColors[4];
        }
        private void NewToolStripButton_Clicked (object sender, EventArgs e)
        {
            var myForm = new StickyNotes();
            myForm.Show();
        }
        private void CloseToolStripButton_Clicked (object sender, EventArgs e)
        {
            Close();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region textMethods
        private void BoldButton_Clicked (object sender, EventArgs e)
        {
            var sel = this.richTextBox1.SelectionStart;
            var selLen = this.richTextBox1.SelectionLength;
            for (int i = 0; i < selLen; i++)
            {
                this.richTextBox1.Select(sel + i, 1);
                if (this.richTextBox1.SelectionFont.Bold)
                {
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                }
                else
                {
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Bold);
                }
            }
            this.richTextBox1.SelectionStart = sel;
            this.richTextBox1.SelectionLength = selLen;
        }
        private void ItalicButton_Clicked (object sender, EventArgs e)
        {            
            var sel = this.richTextBox1.SelectionStart;
            var selLen = this.richTextBox1.SelectionLength;
            for (int i = 0; i < selLen; i++)
             {
                    this.richTextBox1.Select(sel + i, 1);
                    if (this.richTextBox1.SelectionFont.Italic)
                    {
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
                    }
                    else
                    {
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Italic);
                    }
             }         
            this.richTextBox1.SelectionStart = sel;
            this.richTextBox1.SelectionLength = selLen;
        }
        private void UnderlineButton_Clicked(object sender, EventArgs e)
        {
            var sel = this.richTextBox1.SelectionStart;
            var selLen = this.richTextBox1.SelectionLength;
            for (int i = 0; i < selLen; i++)
            {
                this.richTextBox1.Select(sel + i, 1);
                if (this.richTextBox1.SelectionFont.Underline)
                {
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                }
                else
                {
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Underline);
                }
            }
            this.richTextBox1.SelectionStart = sel;
            this.richTextBox1.SelectionLength = selLen;
        }
        private void StrikeButton_Clicked(object sender, EventArgs e)
        {
            var sel = this.richTextBox1.SelectionStart;
            var selLen = this.richTextBox1.SelectionLength;
            for (int i = 0; i < selLen; i++)
            {
                this.richTextBox1.Select(sel + i, 1);
                if (this.richTextBox1.SelectionFont.Strikeout)
                {
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style & ~FontStyle.Strikeout);
                }
                else
                {
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
                }
            }
            this.richTextBox1.SelectionStart = sel;
            this.richTextBox1.SelectionLength = selLen;
        }
        private void BulletButton_Clicked(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionBullet)
            {
                richTextBox1.SelectionBullet = false;
            }
            else
            {
                richTextBox1.SelectionBullet = true;
            }

        }
        #endregion
    }

}
