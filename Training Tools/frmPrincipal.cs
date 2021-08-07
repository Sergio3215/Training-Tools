using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            play = !play;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            if(lbTimePrincipal.Text != "00 : 00 : 00")
                RestartCycle();
        }

        public void Restart()
        {
            timeCounter = 0;
            firstTime = !firstTime;
            minCounter = 0;
            secCounter = 0;
        }

        public void RestartCycle()
        {
            if (!play)
            {
                microsecond = 0;
                second = 0;
                minute = 0;
                lbTimePrincipal.Text = "00 : 00 : 00";

                txtCycle.Enabled = true;

                Restart();

                for (int jj = 0; jj < pnExcerciseAction.Controls.Count; jj++)
                {
                    pnExcerciseAction.Controls[jj].BackColor = Color.Transparent;
                    pnExcerciseAction.Controls[jj].Controls[0].Controls[1].Enabled = true;
                    pnExcerciseAction.Controls[jj].Controls[0].Controls[2].Enabled = true;
                }
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
        int timeCounter = 0;
        bool firstTime = true;
        int minCounter = 0;
        int secCounter = 0;
        int counterCycle = 1;
        public static bool addNew = false;
        public static bool enableForm = false;
        public static bool changeFont = false;
        private void timerPrincipal_Tick(object sender, EventArgs e)
        {

            bool txtEmpty = false;
            if (!String.IsNullOrEmpty(txtSeaching.Text))
            {
                txtEmpty = true;
            }
            btnClearText.Visible = txtEmpty;

            bool clearAll = false;
            if(pnExcerciseAction.Controls.Count > 0)
            {
                clearAll = true;
            }
            btnClearAll.Visible = clearAll;

            if (enableForm)
            {
                this.Enabled = true;
                enableForm = !enableForm;
                this.BringToFront();
                if (changeFont && pnExcerciseAction.Controls.Count != 0)
                {
                    StreamReader sr = new StreamReader("Font");
                    string font = sr.ReadLine();
                    sr.Close();
                    string[] cutFont = font.Split(';');

                    for (int tt = 0; tt < pnExcerciseAction.Controls.Count; tt++)
                    {
                        pnExcerciseAction.Controls[tt].Controls[0].Controls[0].Font = new Font(cutFont[0], int.Parse(cutFont[1]));
                    }
                }
                else
                {
                    changeFont = false;
                }
            }
            if (addNew)
            {
                pnExcercise.Controls.Clear();
                lstExcercise.Items.Clear();

                CreateNewItems();
                addNew = !addNew;
            }

            if (pnExcerciseAction.Controls.Count == 0)
            {
                btnPlay.Enabled = false;
            }
            else
            {
                btnPlay.Enabled = true;
            }

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

                //btnPlay.Text = "Stop";
                btnPlay.BackgroundImage = Properties.Resources.pngwing_com;
                btnRestart.Enabled = false;

                if (timeCounter < pnExcerciseAction.Controls.Count)
                {
                    if (pnExcerciseAction.Controls[timeCounter].Controls[0].Controls[1].Text == "")
                        pnExcerciseAction.Controls[timeCounter].Controls[0].Controls[1].Text = "0";

                    if (pnExcerciseAction.Controls[timeCounter].Controls[0].Controls[2].Text == "")
                        pnExcerciseAction.Controls[timeCounter].Controls[0].Controls[2].Text = "0";

                    pnExcerciseAction.Controls[timeCounter].BackColor = Color.LightSalmon;

                    if (firstTime)
                    {
                        for (int jj = 0; jj < pnExcerciseAction.Controls.Count; jj++)
                        {
                            pnExcerciseAction.Controls[jj].Controls[0].Controls[1].Enabled = false;
                            pnExcerciseAction.Controls[jj].Controls[0].Controls[2].Enabled = false;
                            txtCycle.Enabled = false;
                        }
                        minCounter += int.Parse(pnExcerciseAction.Controls[timeCounter].Controls[0].Controls[1].Text);
                        secCounter += int.Parse(pnExcerciseAction.Controls[timeCounter].Controls[0].Controls[2].Text);
                        firstTime = !firstTime;
                    }

                    if (secCounter >= 60)
                    {
                        secCounter = secCounter - 60;
                        minCounter++;
                    }

                    if (minCounter <= minute && secCounter <= second)
                    {
                        pnExcerciseAction.Controls[timeCounter].BackColor = Color.LightGreen;
                        timeCounter++;
                        firstTime = !firstTime;
                    }
                }
                else
                {
                    counterCycle++;
                    if (txtCycle.Text == "" || txtCycle.Text == "0")
                        txtCycle.Text = "1";


                    play = !play;

                    if (counterCycle <= int.Parse(txtCycle.Text))
                    {
                        RestartCycle();
                        play = !play;
                        firstTime = !firstTime;
                    }
                    else
                    {
                        Restart();
                        counterCycle = 1;
                    }
                    /*microsecond = 0;
                    second = 0;
                    minute = 0;
                    lbTimePrincipal.Text = "00 : 00 : 00";

                    for (int jj = 0; jj<pnExcerciseAction.Controls.Count;jj++)
                    {
                        pnExcerciseAction.Controls[jj].BackColor = Color.Transparent;
                    }*/

                }

            }
            else
            {
                btnPlay.BackgroundImage = Properties.Resources.play_icon_134504;
                //btnPlay.Text = "Play";
                btnRestart.Enabled = true;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1015, 655);
            if (!File.Exists("Item"))
            {
                File.Create("Item").Close();
            }

            if (!File.Exists("Font"))
            {
                File.Create("Font").Close();

                StreamWriter sw = new StreamWriter("Font");
                sw.Write("Arial;9");
                sw.Close();
            }

            CreateNewItems();
        }

        public void CreateNewItems()
        {
            StreamReader sr = new StreamReader("Item");
            string list = sr.ReadLine();
            sr.Close();

            if (list != null)
            {
                string[] listCut = list.Split(';');

                for (int ll = 0; ll < listCut.Length; ll++)
                {
                    if (listCut[ll] != "")
                        lstExcercise.Items.Add(listCut[ll]);
                }
            }
            createItemList(lstExcercise);
            //var control = this.Controls;
        }

        public void createItemList(ListBox lstExcercises)
        {
            int height = 15;
            for (int ii = 0; ii < lstExcercises.Items.Count; ii++)
            {
                Label lb = new Label();
                lb.Text = lstExcercises.Items[ii].ToString();
                lb.ForeColor = Color.White;
                lb.Width = 100;
                lb.Height = 30;
                lb.BackColor = Color.Blue;
                lb.Location = new Point(50, height);
                lb.MouseDown += pb_mouseDown;
                lb.MouseMove += pb_mouseMove;
                lb.MouseUp += pb_mouseUp;
                pnExcercise.Controls.Add(lb);
                lb.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                lb.BringToFront();
                height += 35;

                if (height > pnExcercise.Height)
                {
                    pnExcercise.AutoScroll = true;
                }
                else
                {
                    pnExcercise.AutoScroll = false;
                }
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
            this.Controls.Add(lb);
            pbX = lb.Location.X;
            pbY = lb.Location.Y;
            lbText = lb.Text;
            pbTrash.Visible = true;
        }

        List<string> listItems = new List<string>();
        int ActionY = 5;
        int heightAction = 50;
        Font fontDelete = new Font("Time New Roman", 18, FontStyle.Bold);
        private void pb_mouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            pbTrash.Visible = false;
            Label lb = (Label)sender;
            pnExcercise.Controls.Add(lb);
            lb.BringToFront();

            bool paramAddNew = (lb.Location.X > pnExcerciseAction.Location.X && lb.Location.X < pnExcerciseAction.Location.X + pnExcerciseAction.Width &&
                lb.Location.Y > pnExcerciseAction.Location.Y && lb.Location.Y < pnExcerciseAction.Location.Y + pnExcerciseAction.Height);

            bool timeZero = (lbTimePrincipal.Text == "00 : 00 : 00");

            bool itemtrash = (lb.Location.X > pbTrash.Location.X && lb.Location.X < pbTrash.Width + pbTrash.Location.X
                    && lb.Location.Y > pbTrash.Location.Y && lb.Location.Y < pbTrash.Height + pbTrash.Location.Y ||
                    lb.Location.X + pbTrash.Width > pbTrash.Location.X && lb.Location.X + pbTrash.Width < pbTrash.Width + pbTrash.Location.X &&
                    lb.Location.Y + pbTrash.Height > pbTrash.Location.Y && lb.Location.Y + pbTrash.Height < pbTrash.Height + pbTrash.Location.Y);

            lb.Width = 100;
            lb.Height = 30;
            lb.Location = new Point(50, pbY);
            lb.BackColor = Color.Blue;



            if (paramAddNew)
            {
                if (timeZero)
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
                        CreateComponentExcercise(0, "", "");
                        lb.Location = new Point(50, pbY);
                        lb.BackColor = Color.Blue;
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
                            if (ii + 1 > list.Count && ii < 9)
                            {
                                CreateComponentExcercise(ii, "", "");
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
                        lb.Location = new Point(50, pbY);
                        lb.BackColor = Color.Blue;
                    }
                }
                else
                {
                    MessageBox.Show("En este momento no puede añadirse ningun ejercicio mas.\nPulse el boton reiniciar para añadir mas.");
                }
            }
            else if (itemtrash)
            {
                if (timeZero)
                {
                    pbTrash.Image = Properties.Resources.trash;
                    StreamWriter sw = new StreamWriter("item");
                    sw.WriteLine("");
                    sw.Close();
                    for (int pp = 0; pp < lstExcercise.Items.Count; pp++)
                    {
                        if (lb.Text == lstExcercise.Items[pp].ToString())
                        {
                            lstExcercise.Items.RemoveAt(pp);
                            pp--;
                        }
                        else
                        {
                            StreamReader sr = new StreamReader("item");
                            string list = sr.ReadLine();
                            sr.Close();

                            StreamWriter sw1 = new StreamWriter("item");
                            sw1.WriteLine(list + lstExcercise.Items[pp].ToString() + ";");
                            sw1.Close();
                        }
                    }
                    addNew = true;
                    lb.Location = new Point(50, pbY);
                    lb.BackColor = Color.Blue;
                }
                else
                {
                    lb.Width = 100;
                    lb.Height = 30;
                    MessageBox.Show("No se puede borrar cuando esta ejecutandose el temporizador");
                }
            }
        }

        public void CreateComponentExcercise(int counter, string min, string sec)
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
            label.Text = listItems[counter];
            label.BackColor = Color.Transparent;

            StreamReader sr = new StreamReader("Font");
            string font = sr.ReadLine();
            sr.Close();
            string[] cutFont = font.Split(';');

            label.Font = new Font(cutFont[0], int.Parse(cutFont[1]));
            label.Width = 400 + int.Parse(cutFont[1]);
            label.Height = 200+ int.Parse(cutFont[1]);
            label.Anchor = (AnchorStyles.Bottom| AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);

            pb.Controls.Add(label);

            //label for Delete
            Label lbdelete = new Label();
            lbdelete.Text = "X";
            lbdelete.Location = new Point(pb.Location.X - lbDeleteX, pb.Location.Y + 15);
            lbdelete.Font = fontDelete;

            Label lbID = new Label();
            lbID.Text = (counter).ToString();
            lbdelete.Controls.Add(lbID);
            pn.Controls.Add(lbdelete);
            lbID.Visible = false;
            lbdelete.Click += lbDelete_Click;

            TextBox txtMinute = new TextBox();
            txtMinute.Width = 50;
            txtMinute.Location = new Point(pb.Width - 200, 15);
            txtMinute.Text = min;
            txtMinute.Anchor = (AnchorStyles.Right);

            TextBox txtSecond = new TextBox();
            txtSecond.Width = 50;
            txtSecond.Location = new Point(pb.Width - 130, 15);
            txtSecond.Text = sec;
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
            if (lbTimePrincipal.Text == "00 : 00 : 00")
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

                listItems.Clear();

                for (int kk = 0; kk < pnExcerciseAction.Controls.Count; kk++)
                {
                    min.Add(pnExcerciseAction.Controls[kk].Controls[0].Controls[1].Text);
                    sec.Add(pnExcerciseAction.Controls[kk].Controls[0].Controls[2].Text);
                    listItems.Add(pnExcerciseAction.Controls[kk].Controls[0].Controls[0].Text);
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
                    CreateComponentExcercise(ii, min[ii], sec[ii]);
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
            else
            {
                MessageBox.Show("No se puede borrar el ejercicio seleccionado porque esta corriendo el cronometro.\nPara eliminarlo pulse stop y reiniciar.");
            }
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

                if (lb.Location.X > pbTrash.Location.X && lb.Location.X < pbTrash.Width + pbTrash.Location.X
                    && lb.Location.Y > pbTrash.Location.Y && lb.Location.Y < pbTrash.Height + pbTrash.Location.Y ||
                    lb.Location.X + pbTrash.Width > pbTrash.Location.X && lb.Location.X + pbTrash.Width < pbTrash.Width + pbTrash.Location.X &&
                    lb.Location.Y + pbTrash.Height > pbTrash.Location.Y && lb.Location.Y + pbTrash.Height < pbTrash.Height + pbTrash.Location.Y)
                {
                    pbTrash.Image = Properties.Resources.trashSelected;
                    lb.Width = 55;
                    lb.Height = 20;
                }
                else
                {
                    pbTrash.Image = Properties.Resources.trash;
                    lb.Width = 100;
                    lb.Height = 30;
                }
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

        private void formatoYTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFont fontoption = new frmFont();
            fontoption.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/principiante_en_programar/");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.principianteenprogramar.com");
        }

        public static frmPrincipal from;
        public static Point pointSeg;

        private void btnShowLight_Click(object sender, EventArgs e)
        {
            frmActive frm = new frmActive();

            from = this;

            for (int ii = 0; ii < this.Controls.Count; ii++)
            {
                if (this.Controls[ii].Name == "pnExcerciseAction")
                {
                    frm.Size = new Size(this.Controls[ii].Width, this.Controls[ii].Height);
                    break;
                }
            }
            for (int qq = 0; qq < this.Controls.Count; qq++)
            {
                if(this.Controls[qq].Name == "lbTimePrincipal" || this.Controls[qq].Name == "btnPlay" || 
                    this.Controls[qq].Name == "btnRestart" || this.Controls[qq].Name == "pnExcerciseAction" || 
                    this.Controls[qq].Name == "label5" || this.Controls[qq].Name == "txtCycle" || 
                    this.Controls[qq].Name == "label4" || this.Controls[qq].Name == "label3")
                {
                    if(this.Controls[qq].Name == "label4")
                    {
                        pointSeg = new Point(label4.Location.X, label4.Location.Y);
                    }

                    frm.Controls.Add(this.Controls[qq]);
                    qq--;
                }
            }

            frm.Show();
        }

        public void SeackItem()
        {
            lstExcercise.Items.Clear();
            pnExcercise.Controls.Clear();
            CreateNewItems();

            if (!String.IsNullOrEmpty(txtSeaching.Text))
            {
                lstExcercise.Items.Clear();
                foreach(var control in pnExcercise.Controls)
                {
                    Label lb = (Label)control;
                    //MessageBox.Show(lb.Text);
                    try
                    {
                        string seach = lb.Text.Substring(0, txtSeaching.TextLength);

                        if (txtSeaching.Text.ToUpper() == seach.ToUpper())
                        {
                            lstExcercise.Items.Add(lb.Text);
                        }
                    }
                    catch
                    {
                        lb.Visible = false;
                    }

                }

                pnExcercise.Controls.Clear();
                createItemList(lstExcercise);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SeackItem();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lbTimePrincipal.Text == "00 : 00 : 00")
            {
                pnExcerciseAction.Controls.Clear();
                heightAction = 50;
                ActionY = 5;
                listItems.Clear();
            }
            else
            {
                MessageBox.Show("No se puede borrar cuando esta ejecutandose el temporizador");
            }
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtSeaching.Text = "";
            SeackItem();
        }
    }
}
