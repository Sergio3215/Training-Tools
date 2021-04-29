
namespace Training_Tools
{
    partial class frmFont
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
            this.lstFont = new System.Windows.Forms.ListBox();
            this.lstSizeFont = new System.Windows.Forms.ListBox();
            this.groupExample = new System.Windows.Forms.GroupBox();
            this.lbExample = new System.Windows.Forms.Label();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupExample.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFont
            // 
            this.lstFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFont.FormattingEnabled = true;
            this.lstFont.ItemHeight = 24;
            this.lstFont.Items.AddRange(new object[] {
            "Arial",
            "Arial Rounded MT",
            "Bookman Old Style",
            "Segoe UI",
            "Times New Roman"});
            this.lstFont.Location = new System.Drawing.Point(12, 62);
            this.lstFont.Name = "lstFont";
            this.lstFont.Size = new System.Drawing.Size(175, 268);
            this.lstFont.TabIndex = 0;
            this.lstFont.SelectedIndexChanged += new System.EventHandler(this.lstFont_SelectedIndexChanged);
            // 
            // lstSizeFont
            // 
            this.lstSizeFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSizeFont.FormattingEnabled = true;
            this.lstSizeFont.ItemHeight = 24;
            this.lstSizeFont.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.lstSizeFont.Location = new System.Drawing.Point(210, 62);
            this.lstSizeFont.Name = "lstSizeFont";
            this.lstSizeFont.Size = new System.Drawing.Size(102, 268);
            this.lstSizeFont.TabIndex = 1;
            this.lstSizeFont.SelectedIndexChanged += new System.EventHandler(this.lstFont_SelectedIndexChanged);
            // 
            // groupExample
            // 
            this.groupExample.Controls.Add(this.lbExample);
            this.groupExample.Location = new System.Drawing.Point(328, 62);
            this.groupExample.Name = "groupExample";
            this.groupExample.Size = new System.Drawing.Size(246, 139);
            this.groupExample.TabIndex = 0;
            this.groupExample.TabStop = false;
            this.groupExample.Text = "Ejemplo";
            // 
            // lbExample
            // 
            this.lbExample.AutoSize = true;
            this.lbExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExample.Location = new System.Drawing.Point(55, 61);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(76, 18);
            this.lbExample.TabIndex = 1;
            this.lbExample.Text = "AaBbYyZz";
            this.lbExample.SizeChanged += new System.EventHandler(this.lbExample_SizeChanged);
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(210, 376);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(91, 31);
            this.btnAcept.TabIndex = 2;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 432);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.groupExample);
            this.Controls.Add(this.lstSizeFont);
            this.Controls.Add(this.lstFont);
            this.Name = "frmFont";
            this.Text = "frmFont";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFont_FormClosed);
            this.Load += new System.EventHandler(this.frmFont_Load);
            this.groupExample.ResumeLayout(false);
            this.groupExample.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFont;
        private System.Windows.Forms.ListBox lstSizeFont;
        private System.Windows.Forms.GroupBox groupExample;
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancel;
    }
}