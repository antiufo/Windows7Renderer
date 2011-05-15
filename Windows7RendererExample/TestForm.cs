using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Antiufo.Controls
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var r = Antiufo.Controls.Windows7Renderer.Instance;
            ToolStrip1.Renderer = r;
            toolStrip2.Renderer = r;
            toolStrip3.Renderer = r;
            toolStrip4.Renderer = r;
            menuStrip1.Renderer = r;
            statusStrip1.Renderer = r;
        }


    }
}
