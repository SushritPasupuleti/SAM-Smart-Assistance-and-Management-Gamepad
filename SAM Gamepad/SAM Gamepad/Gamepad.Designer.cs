namespace SAM_Gamepad
{
    partial class Gamepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gamepad));
            this.bdumbchk = new System.Windows.Forms.CheckBox();
            this.Closethis = new System.Windows.Forms.PictureBox();
            this.TRGTS = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NCTRL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRGTS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdumbchk
            // 
            this.bdumbchk.AutoSize = true;
            this.bdumbchk.BackColor = System.Drawing.Color.Transparent;
            this.bdumbchk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bdumbchk.Location = new System.Drawing.Point(12, 304);
            this.bdumbchk.Name = "bdumbchk";
            this.bdumbchk.Size = new System.Drawing.Size(15, 14);
            this.bdumbchk.TabIndex = 85;
            this.bdumbchk.UseVisualStyleBackColor = false;
            this.bdumbchk.Visible = false;
            this.bdumbchk.CheckedChanged += new System.EventHandler(this.bdumbchk_CheckedChanged);
            // 
            // Closethis
            // 
            this.Closethis.BackColor = System.Drawing.Color.Transparent;
            this.Closethis.BackgroundImage = global::SAM_Gamepad.Properties.Resources.Close2;
            this.Closethis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closethis.Location = new System.Drawing.Point(195, 30);
            this.Closethis.Name = "Closethis";
            this.Closethis.Size = new System.Drawing.Size(40, 40);
            this.Closethis.TabIndex = 169;
            this.Closethis.TabStop = false;
            this.Closethis.Click += new System.EventHandler(this.Closethis_Click);
            // 
            // TRGTS
            // 
            this.TRGTS.BackColor = System.Drawing.Color.Transparent;
            this.TRGTS.BackgroundImage = global::SAM_Gamepad.Properties.Resources.Controller_icon;
            this.TRGTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TRGTS.Location = new System.Drawing.Point(55, 41);
            this.TRGTS.Name = "TRGTS";
            this.TRGTS.Size = new System.Drawing.Size(167, 124);
            this.TRGTS.TabIndex = 77;
            this.TRGTS.TabStop = false;
            this.TRGTS.Click += new System.EventHandler(this.TRGTS_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.NCTRL);
            this.panel1.Controls.Add(this.Closethis);
            this.panel1.Controls.Add(this.TRGTS);
            this.panel1.Location = new System.Drawing.Point(36, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 215);
            this.panel1.TabIndex = 170;
            // 
            // NCTRL
            // 
            this.NCTRL.AutoSize = true;
            this.NCTRL.BackColor = System.Drawing.Color.Black;
            this.NCTRL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NCTRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCTRL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NCTRL.Location = new System.Drawing.Point(107, 171);
            this.NCTRL.Name = "NCTRL";
            this.NCTRL.Size = new System.Drawing.Size(115, 28);
            this.NCTRL.TabIndex = 572;
            this.NCTRL.Text = "Edit Commands";
            this.NCTRL.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NCTRL.UseVisualStyleBackColor = false;
            this.NCTRL.Click += new System.EventHandler(this.NCTRL_Click);
            // 
            // Gamepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::SAM_Gamepad.Properties.Resources.GamepadWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(333, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bdumbchk);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gamepad";
            this.Text = "Gamepad";
            this.Load += new System.EventHandler(this.Gamepad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRGTS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TRGTS;
        private System.Windows.Forms.CheckBox bdumbchk;
        private System.Windows.Forms.PictureBox Closethis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NCTRL;
    }
}