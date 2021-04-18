
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
            this.pbExcercise = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcercise)).BeginInit();
            this.SuspendLayout();
            // 
            // pnExcerciseAction
            // 
            this.pnExcerciseAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnExcerciseAction.AutoScroll = true;
            this.pnExcerciseAction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnExcerciseAction.Location = new System.Drawing.Point(12, 82);
            this.pnExcerciseAction.Name = "pnExcerciseAction";
            this.pnExcerciseAction.Size = new System.Drawing.Size(737, 522);
            this.pnExcerciseAction.TabIndex = 0;
            this.pnExcerciseAction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // lstExcercise
            // 
            this.lstExcercise.FormattingEnabled = true;
            this.lstExcercise.Items.AddRange(new object[] {
            "Descanso",
            "Fuerza de brazos"});
            this.lstExcercise.Location = new System.Drawing.Point(497, 82);
            this.lstExcercise.Name = "lstExcercise";
            this.lstExcercise.Size = new System.Drawing.Size(252, 511);
            this.lstExcercise.TabIndex = 0;
            this.lstExcercise.Visible = false;
            // 
            // btnAdd
            // 
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
            this.btnRestart.Location = new System.Drawing.Point(631, 34);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(97, 33);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // lbMouseX
            // 
            this.lbMouseX.AutoSize = true;
            this.lbMouseX.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMouseX.Location = new System.Drawing.Point(45, 15);
            this.lbMouseX.Name = "lbMouseX";
            this.lbMouseX.Size = new System.Drawing.Size(15, 17);
            this.lbMouseX.TabIndex = 5;
            this.lbMouseX.Text = "0";
            this.lbMouseX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // lbMouseY
            // 
            this.lbMouseY.AutoSize = true;
            this.lbMouseY.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMouseY.Location = new System.Drawing.Point(111, 15);
            this.lbMouseY.Name = "lbMouseY";
            this.lbMouseY.Size = new System.Drawing.Size(15, 17);
            this.lbMouseY.TabIndex = 6;
            this.lbMouseY.Text = "0";
            this.lbMouseY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // pbExcercise
            // 
            this.pbExcercise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExcercise.BackColor = System.Drawing.Color.White;
            this.pbExcercise.Location = new System.Drawing.Point(755, 82);
            this.pbExcercise.Name = "pbExcercise";
            this.pbExcercise.Size = new System.Drawing.Size(232, 522);
            this.pbExcercise.TabIndex = 7;
            this.pbExcercise.TabStop = false;
            this.pbExcercise.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 616);
            this.Controls.Add(this.pnExcerciseAction);
            this.Controls.Add(this.pbExcercise);
            this.Controls.Add(this.lbMouseY);
            this.Controls.Add(this.lbMouseX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbTimePrincipal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstExcercise);
            this.Name = "frmPrincipal";
            this.Text = "Training Tool";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbExcercise)).EndInit();
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
        private System.Windows.Forms.PictureBox pbExcercise;
    }
}

