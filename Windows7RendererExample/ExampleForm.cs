using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Antiufo.Controls
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
        }

        private void Windows_7_ToolStripRenderer_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            toolStrip1.Renderer = Antiufo.Controls.Windows7Renderer.Instance;
            contextMenuStrip1.Renderer = Antiufo.Controls.Windows7Renderer.Instance;

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var f = new TestForm();
            f.ShowDialog(this);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://at-my-window.blogspot.com/?page=windows7renderer");
        }
    }
}
