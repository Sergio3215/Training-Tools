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
    public partial class frmFont : Form
    {
        public frmFont()
        {
            InitializeComponent();
        }

        private void frmFont_Load(object sender, EventArgs e)
        {
            frmPrincipal.ActiveForm.Enabled = false;
            this.Location = new Point(frmPrincipal.ActiveForm.Location.X + (this.Width/4), frmPrincipal.ActiveForm.Location.Y + (this.Height / 4));

            lbExample.Location = new Point(groupExample.Location.X + lbExample.Width, groupExample.Location.Y + (groupExample.Height / 2));
            lstFont.SelectedIndex = 0;
            lstSizeFont.SelectedIndex = 0;


            StreamReader sr = new StreamReader("Font");
            string font = sr.ReadLine();
            sr.Close();
            string[] cutFont = font.Split(';');

            for (int tt = 0; tt < lstFont.Items.Count; tt++)
            {
                if(cutFont[0] == lstFont.Items[tt].ToString())
                {
                    lstFont.SelectedIndex = tt;
                }
            }
            for (int tt = 0; tt < lstSizeFont.Items.Count; tt++)
            {
                if (cutFont[1] == lstSizeFont.Items[tt].ToString())
                {
                    lstSizeFont.SelectedIndex = tt;
                }
            }
        }

        private void lbExample_SizeChanged(object sender, EventArgs e)
        {
            groupExample.Controls.Add(lbExample);
            lbExample.Location = new Point(50, 50);
            //lbExample.Location = new Point(groupExample.Location.X + 50, groupExample.Location.Y + (groupExample.Height / 2));
        }

        private void lstFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFont.SelectedItem != null && lstSizeFont.SelectedItem != null)
                lbExample.Font = new Font(lstFont.SelectedItem.ToString(), int.Parse(lstSizeFont.SelectedItem.ToString()));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrincipal.enableForm = true;
            this.Close();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Font");
            sw.WriteLine($"{lstFont.SelectedItem};{int.Parse(lstSizeFont.SelectedItem.ToString())}");
            sw.Close();
            frmPrincipal.changeFont = true;
            frmPrincipal.enableForm = true;
            this.Close();
        }

        private void frmFont_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.enableForm = true;
        }
    }
}
