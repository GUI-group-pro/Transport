namespace Transport_company
{
    partial class login_form
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
            this.Panel1 = new MetroFramework.Controls.MetroPanel();
            this.Panel2 = new MetroFramework.Controls.MetroPanel();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.pb1);
            this.Panel1.HorizontalScrollbarBarColor = true;
            this.Panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel1.HorizontalScrollbarSize = 10;
            this.Panel1.Location = new System.Drawing.Point(0, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(309, 526);
            this.Panel1.TabIndex = 0;
            this.Panel1.UseCustomBackColor = true;
            this.Panel1.UseCustomForeColor = true;
            this.Panel1.UseStyleColors = true;
            this.Panel1.VerticalScrollbarBarColor = true;
            this.Panel1.VerticalScrollbarHighlightOnWheel = false;
            this.Panel1.VerticalScrollbarSize = 10;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.HorizontalScrollbarBarColor = true;
            this.Panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel2.HorizontalScrollbarSize = 10;
            this.Panel2.Location = new System.Drawing.Point(309, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(442, 526);
            this.Panel2.TabIndex = 1;
            this.Panel2.UseCustomBackColor = true;
            this.Panel2.UseCustomForeColor = true;
            this.Panel2.UseStyleColors = true;
            this.Panel2.VerticalScrollbarBarColor = true;
            this.Panel2.VerticalScrollbarHighlightOnWheel = false;
            this.Panel2.VerticalScrollbarSize = 10;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(88, 55);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(120, 120);
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(72, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(168, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.DisplayHeader = false;
            this.Name = "login_form";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Panel1;
        private MetroFramework.Controls.MetroPanel Panel2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}