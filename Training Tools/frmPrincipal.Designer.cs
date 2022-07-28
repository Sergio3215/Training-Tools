
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCycle = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.herramientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoYTamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnExcercise = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnShowLight = new System.Windows.Forms.Button();
            this.pnCreator = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSeaching = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            this.pbTrash = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnCreator.SuspendLayout();
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
            this.btnAdd.Location = new System.Drawing.Point(889, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 31);
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
            this.lbTimePrincipal.Location = new System.Drawing.Point(243, 27);
            this.lbTimePrincipal.Name = "lbTimePrincipal";
            this.lbTimePrincipal.Size = new System.Drawing.Size(198, 50);
            this.lbTimePrincipal.TabIndex = 1;
            this.lbTimePrincipal.Text = "00 : 00 : 00";
            this.lbTimePrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Training_Tools.Properties.Resources.play_icon_134504;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(316, 78);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(35, 28);
            this.btnPlay.TabIndex = 2;
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
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(154, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(226, 18);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@principiante_en_programar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hecho por:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(672, 579);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(75, 18);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Web Site";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnShowLight
            // 
            this.btnShowLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLight.Location = new System.Drawing.Point(413, 82);
            this.btnShowLight.Name = "btnShowLight";
            this.btnShowLight.Size = new System.Drawing.Size(92, 23);
            this.btnShowLight.TabIndex = 2;
            this.btnShowLight.Text = "Zoom Mode";
            this.btnShowLight.UseVisualStyleBackColor = true;
            this.btnShowLight.Click += new System.EventHandler(this.btnShowLight_Click);
            this.btnShowLight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // pnCreator
            // 
            this.pnCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnCreator.Controls.Add(this.linkLabel1);
            this.pnCreator.Controls.Add(this.label6);
            this.pnCreator.Controls.Add(this.pictureBox1);
            this.pnCreator.Location = new System.Drawing.Point(0, 576);
            this.pnCreator.Name = "pnCreator";
            this.pnCreator.Size = new System.Drawing.Size(668, 41);
            this.pnCreator.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Training_Tools.Properties.Resources.pngtree_instagram_color_icon_png_image_557163;
            this.pictureBox1.Location = new System.Drawing.Point(129, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtSeaching
            // 
            this.txtSeaching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeaching.Location = new System.Drawing.Point(758, 53);
            this.txtSeaching.Name = "txtSeaching";
            this.txtSeaching.Size = new System.Drawing.Size(198, 20);
            this.txtSeaching.TabIndex = 19;
            this.txtSeaching.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(230, 81);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(71, 24);
            this.btnClearAll.TabIndex = 20;
            this.btnClearAll.Text = "Borrar Todo";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearText.Location = new System.Drawing.Point(956, 53);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(33, 20);
            this.btnClearText.TabIndex = 20;
            this.btnClearText.Text = "X";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // pbTrash
            // 
            this.pbTrash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTrash.Image = global::Training_Tools.Properties.Resources.trash;
            this.pbTrash.Location = new System.Drawing.Point(758, 79);
            this.pbTrash.Name = "pbTrash";
            this.pbTrash.Size = new System.Drawing.Size(33, 29);
            this.pbTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrash.TabIndex = 12;
            this.pbTrash.TabStop = false;
            this.pbTrash.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::Training_Tools.Properties.Resources.reload_icon_16912;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(357, 78);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(31, 29);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 616);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtSeaching);
            this.Controls.Add(this.pnCreator);
            this.Controls.Add(this.pnExcercise);
            this.Controls.Add(this.pbTrash);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.txtCycle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnExcerciseAction);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShowLight);
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
            this.pnCreator.ResumeLayout(false);
            this.pnCreator.PerformLayout();
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
        private System.Windows.Forms.Button btnShowLight;
        private System.Windows.Forms.Panel pnCreator;
        private System.Windows.Forms.TextBox txtSeaching;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearText;
    }
}

