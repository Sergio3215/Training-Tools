using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Tools
{
    public partial class frmPrincipal : Form
    {
        bool play = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        public void moveMouse(int X, int Y)
        {
            lbMouseX.Text = MousePosition.X.ToString();
            lbMouseY.Text = MousePosition.Y.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            play = !play;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (!play)
            {
                microsecond = 0;
                second = 0;
                minute = 0;
                lbTimePrincipal.Text = "00 : 00 : 00";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.Show();
        }
        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            moveMouse(e.X,e.Y);
            if (pbX != 0 && pbY != 0 && lbText == lb.Text)
            {
                lb.BackColor = Color.Blue;
                lb.Location = new Point(pbX, pbY);
            }
        }

        //Timer

        int microsecond = 0;
        int second = 0;
        int minute = 0;
        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            if (play)
            {
                string ceroMicroSec = "";
                string ceroSec = "";
                string ceroMin = "";

                if (microsecond == 59)
                {
                    microsecond = 0;
                    second++;
                }
                else
                {
                    microsecond++;
                }

                if (second == 59)
                {
                    second = 0;
                    minute++;
                }

                if(microsecond < 10)
                {
                    ceroMicroSec = "0";
                }
                if (second < 10)
                {
                    ceroSec = "0";
                }
                if (minute < 10)
                {
                    ceroMin = "0";
                }

                lbTimePrincipal.Text = $"{ceroMin}{minute} : {ceroSec}{second} : {ceroMicroSec}{microsecond}";

                btnPlay.Text = "Stop";
                btnRestart.Enabled = false;
            }
            else
            {
                btnPlay.Text = "Play";
                btnRestart.Enabled = true;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            int height = 15;
            for (int ii = 0; ii < lstExcercise.Items.Count; ii++)
            {
                Label lb = new Label();
                lb.Text = lstExcercise.Items[ii].ToString();
                lb.ForeColor = Color.White;
                lb.Width = 100;
                lb.Height = 30;
                lb.BackColor = Color.Blue;
                lb.Location = new Point(pbExcercise.Location.X + 50, height + pbExcercise.Location.Y);
                lb.MouseDown += pb_mouseDown;
                lb.MouseMove += pb_mouseMove;
                lb.MouseUp += pb_mouseUp;
                this.Controls.Add(lb);
                lb.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                lb.BringToFront();
                height += 35;
            }
        }
        bool move = false;
        int pbX = 0;
        int pbY = 0;
        int x = 0;
        int Y = 0;
        string lbText = "";
        Label lb = new Label();
        private void pb_mouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            lb = (Label)sender;
            pbX = lb.Location.X;
            pbY = lb.Location.Y;
            lbText = lb.Text;
            x = e.X;
            Y = e.Y;
        }

        List<string> listItems = new List<string>();
        int ActionY = 5;
        int heightAction = 50;
        private void pb_mouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            Label lb = (Label)sender;
            if (lb.Location.X > pnExcerciseAction.Location.X && lb.Location.X < pnExcerciseAction.Location.X + pnExcerciseAction.Width &&
                lb.Location.Y > pnExcerciseAction.Location.Y && lb.Location.Y < pnExcerciseAction.Location.Y + pnExcerciseAction.Height)
            {
                try
                {
                    MessageBox.Show(pnExcerciseAction.Controls[0].Controls[0].Text);
                }
                catch
                {

                    
                }
                if (listItems.Count == 0)
                {
                    listItems.Add(lb.Text);

                    //MessageBox.Show(listItems[0]);
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(pnExcerciseAction.Location.X + 15, ActionY);
                    pb.Width = pnExcerciseAction.Width - 50;
                    pb.Height = heightAction;
                    pb.BackColor = Color.White;

                    Label label = new Label();
                    label.Text = lb.Text;
                    pb.Controls.Add(label);

                    pnExcerciseAction.Controls.Add(pb);
                    pb.BringToFront();
                    pb.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                }
                else
                {
                    List<string> list = new List<string>();
                    foreach (var lst in listItems)
                    {
                        list.Add(lst);
                    }
                    listItems.Add(lb.Text);
                    for(int ii=0; ii < listItems.Count; ii++)
                    {
                        if(ii+1 > list.Count)
                        {
                            PictureBox pb = new PictureBox();
                            pb.Location = new Point(pnExcerciseAction.Location.X + 15, ActionY);
                            pb.Width = pnExcerciseAction.Width - 50;
                            pb.Height = heightAction;
                            pb.BackColor = Color.White;

                            Label label = new Label();
                            label.Text = lb.Text;
                            pb.Controls.Add(label);

                            pnExcerciseAction.Controls.Add(pb);
                            pb.BringToFront();
                            pb.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                        }
                        ActionY += heightAction+5;
                    }
                    if(ActionY > pnExcerciseAction.Height)
                    {
                        pnExcerciseAction.AutoScroll = true;
                    }
                    else
                    {
                        pnExcerciseAction.AutoScroll = false;
                    }
                    ActionY = 5;
                }
            }
        }
        private void pb_mouseMove(object sender, MouseEventArgs e)
        {
            moveMouse(e.X,e.Y);
            Label lb = (Label)sender;
            lb.BringToFront();
            if (move && e.X != -1 && e.Y != -1 && lbText==lb.Text)
            {
                //pnExcercise.Controls.Remove(lb);
                lb.BackColor = Color.Black;
                lb.Location = new Point(MousePosition.X - this.Location.X - 40, MousePosition.Y - this.Location.Y - 50);
            }
            else
            {
                if(pbX != 0 && pbY != 0 && lbText == lb.Text)
                {
                    lb.BackColor = Color.Blue;
                    lb.Location = new Point(pbX, pbY);
                    lb.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                }
                pbX = 0;
                pbY = 0;
            }
        }

    }
}
