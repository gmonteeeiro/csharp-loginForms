﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loginForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFrmModernDark_Click(object sender, EventArgs e)
        {
            FrmModernDark modernDark = new FrmModernDark();
            modernDark.ShowDialog();
        }

        private void BtnFrmZuounMenu_Click(object sender, EventArgs e)
        {
            FrmZuounMenu zuounMenu = new FrmZuounMenu();
            zuounMenu.ShowDialog();
        }
    }
}
