
namespace Training_Tools
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnExcerciseAction = new System.Windows.Forms.Panel();
            this.lstExcercise = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTimePrincipal = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMouseX = new System.Windows.Forms.Label();
            this.lbMouseY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCycle = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.herramientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoYTamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnExcercise = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbTrash = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrash)).BeginInit();
            this.SuspendLayout();
            // 
            // pnExcerciseAction
            // 
            this.pnExcerciseAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnExcerciseAction.AutoScroll = true;
            this.pnExcerciseAction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnExcerciseAction.Location = new System.Drawing.Point(12, 111);
            this.pnExcerciseAction.Name = "pnExcerciseAction";
            this.pnExcerciseAction.Size = new System.Drawing.Size(737, 465);
            this.pnExcerciseAction.TabIndex = 0;
            this.pnExcerciseAction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // lstExcercise
            // 
            this.lstExcercise.FormattingEnabled = true;
            this.lstExcercise.Location = new System.Drawing.Point(498, 147);
            this.lstExcercise.Name = "lstExcercise";
            this.lstExcercise.Size = new System.Drawing.Size(240, 355);
            this.lstExcercise.TabIndex = 0;
            this.lstExcercise.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(755, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // lbTimePrincipal
            // 
            this.lbTimePrincipal.AutoSize = true;
            this.lbTimePrincipal.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimePrincipal.Location = new System.Drawing.Point(227, 20);
            this.lbTimePrincipal.Name = "lbTimePrincipal";
            this.lbTimePrincipal.Size = new System.Drawing.Size(198, 50);
            this.lbTimePrincipal.TabIndex = 1;
            this.lbTimePrincipal.Text = "00 : 00 : 00";
            this.lbTimePrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(528, 34);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(97, 33);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Interval = 10;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(631, 34);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(97, 33);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            this.label1.Visible = false;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            this.label2.Visible = false;
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // lbMouseX
            // 
            this.lbMouseX.AutoSize = true;
            this.lbMouseX.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMouseX.Location = new System.Drawing.Point(45, 46);
            this.lbMouseX.Name = "lbMouseX";
            this.lbMouseX.Size = new System.Drawing.Size(15, 17);
            this.lbMouseX.TabIndex = 5;
            this.lbMouseX.Text = "0";
            this.lbMouseX.Visible = false;
            this.lbMouseX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // lbMouseY
            // 
            this.lbMouseY.AutoSize = true;
            this.lbMouseY.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMouseY.Location = new System.Drawing.Point(111, 46);
            this.lbMouseY.Name = "lbMouseY";
            this.lbMouseY.Size = new System.Drawing.Size(15, 17);
            this.lbMouseY.TabIndex = 6;
            this.lbMouseY.Text = "0";
            this.lbMouseY.Visible = false;
            this.lbMouseY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Segundos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ciclos";
            // 
            // txtCycle
            // 
            this.txtCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCycle.Location = new System.Drawing.Point(70, 80);
            this.txtCycle.Name = "txtCycle";
            this.txtCycle.Size = new System.Drawing.Size(35, 24);
            this.txtCycle.TabIndex = 11;
            this.txtCycle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // herramientaToolStripMenuItem
            // 
            this.herramientaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatoYTamañoToolStripMenuItem});
            this.herramientaToolStripMenuItem.Name = "herramientaToolStripMenuItem";
            this.herramientaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.herramientaToolStripMenuItem.Text = "Herramienta";
            // 
            // formatoYTamañoToolStripMenuItem
            // 
            this.formatoYTamañoToolStripMenuItem.Name = "formatoYTamañoToolStripMenuItem";
            this.formatoYTamañoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.formatoYTamañoToolStripMenuItem.Text = "Fuentes y tamaños";
            this.formatoYTamañoToolStripMenuItem.Click += new System.EventHandler(this.formatoYTamañoToolStripMenuItem_Click);
            // 
            // pnExcercise
            // 
            this.pnExcercise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnExcercise.BackColor = System.Drawing.Color.White;
            this.pnExcercise.Location = new System.Drawing.Point(758, 111);
            this.pnExcercise.Name = "pnExcercise";
            this.pnExcercise.Size = new System.Drawing.Size(232, 502);
            this.pnExcercise.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Training_Tools.Properties.Resources.pngtree_instagram_color_icon_png_image_557163;
            this.pictureBox1.Location = new System.Drawing.Point(124, 576);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pbTrash
            // 
            this.pbTrash.Image = global::Training_Tools.Properties.Resources.trash;
            this.pbTrash.Location = new System.Drawing.Point(758, 79);
            this.pbTrash.Name = "pbTrash";
            this.pbTrash.Size = new System.Drawing.Size(33, 29);
            this.pbTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrash.TabIndex = 12;
            this.pbTrash.TabStop = false;
            this.pbTrash.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(149, 579);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(226, 18);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@principiante_en_programar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hecho por:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(663, 579);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(75, 18);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Web Site";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnExcercise);
            this.Controls.Add(this.pbTrash);
            this.Controls.Add(this.txtCycle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnExcerciseAction);
            this.Controls.Add(this.lbMouseY);
            this.Controls.Add(this.lbMouseX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbTimePrincipal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstExcercise);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Training Tool";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnExcerciseAction;
        private System.Windows.Forms.ListBox lstExcercise;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbTimePrincipal;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMouseX;
        private System.Windows.Forms.Label lbMouseY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCycle;
        private System.Windows.Forms.PictureBox pbTrash;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem herramientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoYTamañoToolStripMenuItem;
        private System.Windows.Forms.Panel pnExcercise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

