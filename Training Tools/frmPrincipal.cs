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
            moveMouse(e.X, e.Y);
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

                if (microsecond < 10)
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
        string lbText = "";
        int lbDeleteX = 28;
        Label lb = new Label();
        private void pb_mouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            lb = (Label)sender;
            pbX = lb.Location.X;
            pbY = lb.Location.Y;
            lbText = lb.Text;
        }

        List<string> listItems = new List<string>();
        int ActionY = 5;
        int heightAction = 50;
        Font fontDelete = new Font("Time New Roman", 18, FontStyle.Bold);
        private void pb_mouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            Label lb = (Label)sender;
            if (lb.Location.X > pnExcerciseAction.Location.X && lb.Location.X < pnExcerciseAction.Location.X + pnExcerciseAction.Width &&
                lb.Location.Y > pnExcerciseAction.Location.Y && lb.Location.Y < pnExcerciseAction.Location.Y + pnExcerciseAction.Height)
            {
                try
                {
                    //MessageBox.Show(pnExcerciseAction.Controls[0].Controls[0].Text);
                }
                catch
                {


                }
                if (listItems.Count == 0)
                {
                    listItems.Add(lb.Text);

                    //MessageBox.Show(listItems[0]);

                    Panel pn = new Panel();
                    pn.Width = pnExcerciseAction.Width - 20;
                    pn.Height = heightAction + 10;
                    pn.Location = new Point(pnExcerciseAction.Location.X + 1, ActionY - 2);
                    pn.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                    //pn.BackColor = Color.Red;

                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(pnExcerciseAction.Location.X + 15, 6);
                    pb.Width = pnExcerciseAction.Width - 50;
                    pb.Height = heightAction;
                    pb.BackColor = Color.White;

                    Label label = new Label();
                    label.Text = lb.Text;
                    label.BackColor = Color.Transparent;
                    pb.Controls.Add(label);

                    //label for Delete
                    Label lbdelete = new Label();
                    lbdelete.Text = "X";
                    lbdelete.Location = new Point(pb.Location.X - lbDeleteX, pb.Location.Y + 15);
                    lbdelete.Font = fontDelete;

                    Label lbID = new Label();
                    lbID.Text = "0";
                    lbdelete.Controls.Add(lbID);
                    pn.Controls.Add(lbdelete);
                    lbID.Visible = false;
                    lbdelete.Click += lbDelete_Click;

                    TextBox txtMinute = new TextBox();
                    txtMinute.Width = 50;
                    txtMinute.Location = new Point(pb.Width - 200, 15);
                    txtMinute.Anchor = (AnchorStyles.Right);

                    TextBox txtSecond = new TextBox();
                    txtSecond.Width = 50;
                    txtSecond.Location = new Point(pb.Width - 130, 15);
                    txtSecond.Anchor = (AnchorStyles.Right);

                    Label lbTimeTex = new Label();
                    lbTimeTex.Text = ":";
                    lbTimeTex.Location = new Point(pb.Width - 145, 15);
                    lbTimeTex.Font = new Font("Arial", 12, FontStyle.Bold);
                    lbTimeTex.Anchor = (AnchorStyles.Right);

                    txtMinute.KeyPress += txtBox_KeyPress;
                    txtSecond.KeyPress += txtBox_KeyPress;

                    pb.Controls.Add(txtMinute);
                    pb.Controls.Add(txtSecond);
                    pb.Controls.Add(lbTimeTex);

                    pn.Controls.Add(pb);
                    pnExcerciseAction.Controls.Add(pn);
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
                    for (int ii = 0; ii < listItems.Count; ii++)
                    {
                        if (ii + 1 > list.Count && ii < 10)
                        {

                            PictureBox pb = new PictureBox();
                            pb.Location = new Point(pnExcerciseAction.Location.X + 15, 6);
                            pb.Width = pnExcerciseAction.Width - 50;
                            pb.Height = heightAction;
                            pb.BackColor = Color.White;

                            Panel pn = new Panel();
                            pn.Width = pnExcerciseAction.Width - 20;
                            pn.Height = heightAction + 10;
                            pn.Location = new Point(pnExcerciseAction.Location.X + 1, ActionY - 2);
                            pn.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                            //pn.BackColor = Color.Red;

                            Label label = new Label();
                            label.Text = lb.Text;
                            label.BackColor = Color.Transparent;
                            pb.Controls.Add(label);

                            //label for Delete
                            Label lbdelete = new Label();
                            lbdelete.Text = "X";
                            lbdelete.Location = new Point(pb.Location.X - lbDeleteX, pb.Location.Y + 15);
                            lbdelete.Font = fontDelete;

                            Label lbID = new Label();
                            lbID.Text = (ii).ToString();
                            lbdelete.Controls.Add(lbID);
                            pn.Controls.Add(lbdelete);
                            lbID.Visible = false;
                            lbdelete.Click += lbDelete_Click;

                            TextBox txtMinute = new TextBox();
                            txtMinute.Width = 50;
                            txtMinute.Location = new Point(pb.Width - 200, 15);
                            txtMinute.Anchor = (AnchorStyles.Right);

                            TextBox txtSecond = new TextBox();
                            txtSecond.Width = 50;
                            txtSecond.Location = new Point(pb.Width - 130, 15);
                            txtSecond.Anchor = (AnchorStyles.Right);

                            Label lbTimeTex = new Label();
                            lbTimeTex.Text = ":";
                            lbTimeTex.Location = new Point(pb.Width - 145, 15);
                            lbTimeTex.Font = new Font("Arial", 12, FontStyle.Bold);
                            lbTimeTex.Anchor = (AnchorStyles.Right);

                            txtMinute.KeyPress += txtBox_KeyPress;
                            txtSecond.KeyPress += txtBox_KeyPress;

                            pb.Controls.Add(txtMinute);
                            pb.Controls.Add(txtSecond);
                            pb.Controls.Add(lbTimeTex);

                            pn.Controls.Add(pb);
                            pnExcerciseAction.Controls.Add(pn);
                            pb.BringToFront();
                            pb.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                        }
                        ActionY += heightAction + 5;
                    }
                    if (ActionY > pnExcerciseAction.Height)
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

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (e.KeyChar.ToString() != "\b")
            {
                int num = 0;
                try
                {
                    num = int.Parse(e.KeyChar.ToString());
                    TextBox txt = (TextBox)sender;
                    if (txt.Text != "")
                    {
                        if (int.Parse(txt.Text + e.KeyChar.ToString()) > 60)
                        {
                            if (txt.SelectedText != txt.Text && !txt.Text.Contains(txt.SelectedText))
                            {
                                e.Handled = true;
                                txt.Text = 59 + "";
                            }
                            else
                            {
                                try
                                {
                                    if (int.Parse(txt.Text.Replace(char.Parse(txt.SelectedText), e.KeyChar).ToString()) > 60)
                                    {
                                        e.Handled = true;
                                        txt.Text = 59 + "";
                                    }
                                }
                                catch
                                {
                                    if (txt.SelectedText != txt.Text)
                                    {
                                        e.Handled = true;
                                        txt.Text = 59 + "";
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    e.Handled = true;
                }
            }
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            Label close = (Label)sender;
            int indexdelete = int.Parse(close.Controls[0].Text);
            //First controls is created by code, 2nd control is the picture box and 3rd  controls is label
            //MessageBox.Show(pnExcerciseAction.Controls[indexdelete].Controls[0].Controls[0].Text);
            /*
             * get id number = pnExcerciseAction.Controls[indexdelete].Controls[1].Controls[0].Text
             * 
             * Text Box min = pnExcerciseAction.Controls[indexdelete].Controls[0].Controls[1].Text
             * Text Box Sec = pnExcerciseAction.Controls[indexdelete].Controls[0].Controls[2].Text
             */

            List<string> min = new List<string>();
            List<string> sec = new List<string>();

            for(int kk = 0; kk < pnExcerciseAction.Controls.Count; kk++)
            {
                min.Add(pnExcerciseAction.Controls[kk].Controls[0].Controls[1].Text);
                sec.Add(pnExcerciseAction.Controls[kk].Controls[0].Controls[2].Text);
            }

            if (min.Count == 1)
                min.Clear();
            else
                min.RemoveAt(indexdelete);


            if (sec.Count == 1)
                sec.Clear();
            else
                sec.RemoveAt(indexdelete);
            

            if (listItems.Count == 1)
                listItems.Clear();
            else
                listItems.RemoveAt(indexdelete);
            pnExcerciseAction.Controls.Clear();
            for (int ii = 0; ii < listItems.Count; ii++)
            {
                Panel pn = new Panel();
                pn.Width = pnExcerciseAction.Width - 20;
                pn.Height = heightAction + 10;
                pn.Location = new Point(pnExcerciseAction.Location.X + 1, ActionY - 2);
                pn.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);

                PictureBox pb = new PictureBox();
                pb.Location = new Point(pnExcerciseAction.Location.X + 15, 6);
                pb.Width = pnExcerciseAction.Width - 50;
                pb.Height = heightAction;
                pb.BackColor = Color.White;

                Label label = new Label();
                label.Text = listItems[ii];
                label.BackColor = Color.Transparent;
                pb.Controls.Add(label);

                //label for Delete
                Label lbdelete = new Label();
                lbdelete.Text = "X";
                lbdelete.Location = new Point(pb.Location.X - lbDeleteX, pb.Location.Y + 15);
                lbdelete.Font = fontDelete;

                Label lbID = new Label();
                lbID.Text = (ii).ToString();
                lbdelete.Controls.Add(lbID);
                pn.Controls.Add(lbdelete);
                lbID.Visible = false;
                lbdelete.Click += lbDelete_Click;

                TextBox txtMinute = new TextBox();
                txtMinute.Width = 50;
                txtMinute.Location = new Point(pb.Width - 200, 15);
                txtMinute.Text = min[ii];
                txtMinute.Anchor = (AnchorStyles.Right);

                TextBox txtSecond = new TextBox();
                txtSecond.Width = 50;
                txtSecond.Location = new Point(pb.Width - 130, 15);
                txtSecond.Text = sec[ii];
                txtSecond.Anchor = (AnchorStyles.Right);

                Label lbTimeTex = new Label();
                lbTimeTex.Text = ":";
                lbTimeTex.Location = new Point(pb.Width - 145, 15);
                lbTimeTex.Font = new Font("Arial", 12, FontStyle.Bold);
                lbTimeTex.Anchor = (AnchorStyles.Right);

                txtMinute.KeyPress += txtBox_KeyPress;
                txtSecond.KeyPress += txtBox_KeyPress;

                pb.Controls.Add(txtMinute);
                pb.Controls.Add(txtSecond);
                pb.Controls.Add(lbTimeTex);

                pn.Controls.Add(pb);
                pnExcerciseAction.Controls.Add(pn);
                pb.BringToFront();
                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                ActionY += heightAction + 5;
            }
            if (ActionY > pnExcerciseAction.Height)
            {
                pnExcerciseAction.AutoScroll = true;
            }
            else
            {
                pnExcerciseAction.AutoScroll = false;
            }
            ActionY = 5;
            /* pnExcerciseAction.Controls.Remove(close);
             pnExcerciseAction.Controls.RemoveAt(indexdelete);*/
        }

        private void pb_mouseMove(object sender, MouseEventArgs e)
        {
            moveMouse(e.X, e.Y);
            Label lb = (Label)sender;
            lb.BringToFront();
            if (move && e.X != -1 && e.Y != -1 && lbText == lb.Text)
            {
                //pnExcercise.Controls.Remove(lb);
                lb.BackColor = Color.Black;
                lb.Location = new Point(MousePosition.X - this.Location.X - 40, MousePosition.Y - this.Location.Y - 50);
            }
            else
            {
                if (pbX != 0 && pbY != 0 && lbText == lb.Text)
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
