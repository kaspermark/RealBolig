﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBolig
{
    public partial class Main : Form
    {
        public static Main MainInstance;

        public Main()
        {
            MainInstance = this;
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)//Home knap
        {
            pContainer.Controls.Clear();
            Home frm1 = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm1.FormBorderStyle = FormBorderStyle.None;
            this.pContainer.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnBolig_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();
            AdminBolig frmABolig = new AdminBolig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmABolig.FormBorderStyle = FormBorderStyle.None;
            this.pContainer.Controls.Add(frmABolig);
            frmABolig.Show();
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();
            AdminKunder frmAKunder = new AdminKunder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAKunder.FormBorderStyle = FormBorderStyle.None;
            this.pContainer.Controls.Add(frmAKunder);
            frmAKunder.Show();
        }
    }
}
