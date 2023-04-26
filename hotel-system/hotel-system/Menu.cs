﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_system
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            TopPanel.BackColor = Color.FromArgb(200, 200, 200);
            RightPanel.BackColor = Color.FromArgb(160, 160, 160);
        }

    }
}
