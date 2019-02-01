﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorScriptPoint
{
    public partial class Info : Form
    {
        private frmPrincipal parentForm;
        public Info(frmPrincipal parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            parentForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Close();
        }
    }
}
