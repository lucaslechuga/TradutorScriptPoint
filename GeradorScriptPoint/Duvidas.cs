using MetroFramework.Forms;
using System;
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
    public partial class Duvidas : Form
    {
        private frmPrincipal formParent;
        public Duvidas(frmPrincipal formParent)
        {
            InitializeComponent();
            this.formParent = formParent;
        }

        private void Duvidas_Load(object sender, EventArgs e)
        {
            formParent.Hide();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            formParent.Show();
            Close();
        }
    }
}
