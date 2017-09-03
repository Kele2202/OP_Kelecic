namespace OP_Kelecic_projekt
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.lOriginal = new System.Windows.Forms.Label();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.lBandW = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnBW = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(34, 77);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(150, 200);
            this.pbOriginal.TabIndex = 1;
            this.pbOriginal.TabStop = false;
            // 
            // lOriginal
            // 
            this.lOriginal.AutoSize = true;
            this.lOriginal.Location = new System.Drawing.Point(34, 42);
            this.lOriginal.Name = "lOriginal";
            this.lOriginal.Size = new System.Drawing.Size(73, 13);
            this.lOriginal.TabIndex = 2;
            this.lOriginal.Text = "Original image";
            // 
            // pbEdit
            // 
            this.pbEdit.Location = new System.Drawing.Point(216, 77);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(150, 200);
            this.pbEdit.TabIndex = 3;
            this.pbEdit.TabStop = false;
            // 
            // lBandW
            // 
            this.lBandW.AutoSize = true;
            this.lBandW.Location = new System.Drawing.Point(216, 42);
            this.lBandW.Name = "lBandW";
            this.lBandW.Size = new System.Drawing.Size(56, 13);
            this.lBandW.TabIndex = 4;
            this.lBandW.Text = "BW image";
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(399, 77);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(88, 23);
            this.btnRed.TabIndex = 6;
            this.btnRed.Text = "Ukloni crvenu";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(399, 121);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(88, 23);
            this.btnGreen.TabIndex = 7;
            this.btnGreen.Text = "Ukloni Zelenu";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(399, 165);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(88, 23);
            this.btnBlue.TabIndex = 8;
            this.btnBlue.Text = "Ukloni plavu";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnBW
            // 
            this.btnBW.Location = new System.Drawing.Point(399, 212);
            this.btnBW.Name = "btnBW";
            this.btnBW.Size = new System.Drawing.Size(88, 23);
            this.btnBW.TabIndex = 9;
            this.btnBW.Text = "Crno bijela slika";
            this.btnBW.UseVisualStyleBackColor = true;
            this.btnBW.Click += new System.EventHandler(this.btnBW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 534);
            this.Controls.Add(this.btnBW);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lBandW);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.lOriginal);
            this.Controls.Add(this.pbOriginal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.Label lOriginal;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.Label lBandW;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnBW;
    }
}

