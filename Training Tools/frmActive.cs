using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Tools
{
    public partial class frmActive : Form
    {
        public frmActive()
        {
            InitializeComponent();
        }

        private void frmActive_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(745, 305);
        }

        private void frmActive_FormClosing(object sender, FormClosingEventArgs e)
        {
            int yCreator = 0;
            int xList = 0;
            for(var nn =0; nn < frmPrincipal.from.Controls.Count; nn++)
            {
                if (frmPrincipal.from.Controls[nn].Name == "pnCreator")
                {
                    yCreator = frmPrincipal.from.Controls[nn].Location.Y;
                    break;
                }
            }

            for(var nn =0; nn < frmPrincipal.from.Controls.Count; nn++)
            {
                if (frmPrincipal.from.Controls[nn].Name == "pnExcercise")
                {
                    xList = frmPrincipal.from.Controls[nn].Location.X;
                    break;
                }
            }

            Point seg = frmPrincipal.pointSeg;
            Point min = new Point(seg.X - 67, seg.Y);

            for (int ii = 0; ii < this.Controls.Count; ii++)
            {
                if(this.Controls[ii].Name == "pnExcerciseAction")
                {
                    this.Controls[ii].Size = new Size(xList - 21, yCreator - 112);
                }

                if(this.Controls[ii].Name == "label4")
                {
                    this.Controls[ii].Location = seg;
                }
                if (this.Controls[ii].Name == "label3")
                {
                    this.Controls[ii].Location = min;
                }

                frmPrincipal.from.Controls.Add(this.Controls[ii]);
                ii--;
            }
        }
    }
}
