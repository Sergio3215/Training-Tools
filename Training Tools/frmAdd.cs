using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Tools
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("item");
            string list = sr.ReadLine();
            sr.Close();

            StreamWriter sw = new StreamWriter("item");
            sw.WriteLine(list+txtName.Text+";");
            sw.Close();
            frmPrincipal.addNew = true;
            frmPrincipal.enableForm = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrincipal.enableForm = true;
            this.Close();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            frmPrincipal.ActiveForm.Enabled = false;
            this.Location = new Point(this.Width+frmPrincipal.ActiveForm.Location.X, this.Height + frmPrincipal.ActiveForm.Location.Y);
        }

        private void frmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.enableForm = true;
        }
    }
}
