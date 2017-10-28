namespace NewVM
{
    partial class Trays
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
            this.textBoxTray1 = new System.Windows.Forms.TextBox();
            this.textBoxTray2 = new System.Windows.Forms.TextBox();
            this.textBoxTray3 = new System.Windows.Forms.TextBox();
            this.textBoxTray4 = new System.Windows.Forms.TextBox();
            this.textBoxTray5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTray1
            // 
            this.textBoxTray1.Location = new System.Drawing.Point(12, 12);
            this.textBoxTray1.Multiline = true;
            this.textBoxTray1.Name = "textBoxTray1";
            this.textBoxTray1.ReadOnly = true;
            this.textBoxTray1.Size = new System.Drawing.Size(257, 60);
            this.textBoxTray1.TabIndex = 0;
            // 
            // textBoxTray2
            // 
            this.textBoxTray2.Location = new System.Drawing.Point(12, 78);
            this.textBoxTray2.Multiline = true;
            this.textBoxTray2.Name = "textBoxTray2";
            this.textBoxTray2.ReadOnly = true;
            this.textBoxTray2.Size = new System.Drawing.Size(257, 60);
            this.textBoxTray2.TabIndex = 1;
            // 
            // textBoxTray3
            // 
            this.textBoxTray3.Location = new System.Drawing.Point(12, 144);
            this.textBoxTray3.Multiline = true;
            this.textBoxTray3.Name = "textBoxTray3";
            this.textBoxTray3.ReadOnly = true;
            this.textBoxTray3.Size = new System.Drawing.Size(257, 60);
            this.textBoxTray3.TabIndex = 2;
            // 
            // textBoxTray4
            // 
            this.textBoxTray4.Location = new System.Drawing.Point(12, 210);
            this.textBoxTray4.Multiline = true;
            this.textBoxTray4.Name = "textBoxTray4";
            this.textBoxTray4.ReadOnly = true;
            this.textBoxTray4.Size = new System.Drawing.Size(257, 60);
            this.textBoxTray4.TabIndex = 3;
            // 
            // textBoxTray5
            // 
            this.textBoxTray5.Location = new System.Drawing.Point(12, 276);
            this.textBoxTray5.Multiline = true;
            this.textBoxTray5.Name = "textBoxTray5";
            this.textBoxTray5.ReadOnly = true;
            this.textBoxTray5.Size = new System.Drawing.Size(257, 60);
            this.textBoxTray5.TabIndex = 4;
            // 
            // Trays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 354);
            this.Controls.Add(this.textBoxTray5);
            this.Controls.Add(this.textBoxTray4);
            this.Controls.Add(this.textBoxTray3);
            this.Controls.Add(this.textBoxTray2);
            this.Controls.Add(this.textBoxTray1);
            this.Name = "Trays";
            this.Text = "Trays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxTray1;
        public System.Windows.Forms.TextBox textBoxTray2;
        public System.Windows.Forms.TextBox textBoxTray3;
        public System.Windows.Forms.TextBox textBoxTray4;
        public System.Windows.Forms.TextBox textBoxTray5;

    }
}