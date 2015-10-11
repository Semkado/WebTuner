namespace WebRadio
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBarVolume.Location = new System.Drawing.Point(6, 26);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(116, 45);
            this.trackBarVolume.TabIndex = 2;
            this.trackBarVolume.TickFrequency = 5;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Value = 1;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(12, 10);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(54, 13);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "Volume ():";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonMute);
            this.panel1.Controls.Add(this.trackBarVolume);
            this.panel1.Controls.Add(this.buttonPlay);
            this.panel1.Controls.Add(this.labelVolume);
            this.panel1.Location = new System.Drawing.Point(0, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 69);
            this.panel1.TabIndex = 4;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(433, 10);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(48, 48);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.Location = new System.Drawing.Point(128, 10);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(48, 48);
            this.buttonMute.TabIndex = 4;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(487, 10);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(48, 48);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Radio:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(89, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(458, 173);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 273);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Webradio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    }
}

