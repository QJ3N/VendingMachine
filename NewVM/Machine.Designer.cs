namespace NewVM
{
    partial class Machine
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Machine));
            this.pictureBoxMachine = new System.Windows.Forms.PictureBox();
            this.pictureBoxPanel = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrays = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMachine
            // 
            this.pictureBoxMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMachine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMachine.Image")));
            this.pictureBoxMachine.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMachine.Name = "pictureBoxMachine";
            this.pictureBoxMachine.Size = new System.Drawing.Size(335, 556);
            this.pictureBoxMachine.TabIndex = 0;
            this.pictureBoxMachine.TabStop = false;
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPanel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPanel.Image")));
            this.pictureBoxPanel.InitialImage = null;
            this.pictureBoxPanel.Location = new System.Drawing.Point(266, 76);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(48, 223);
            this.pictureBoxPanel.TabIndex = 1;
            this.pictureBoxPanel.TabStop = false;
            this.pictureBoxPanel.Click += new System.EventHandler(this.pictureBoxPanel_Click);
            // 
            // pictureBoxTrays
            // 
            this.pictureBoxTrays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTrays.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTrays.Image")));
            this.pictureBoxTrays.Location = new System.Drawing.Point(23, 44);
            this.pictureBoxTrays.Name = "pictureBoxTrays";
            this.pictureBoxTrays.Size = new System.Drawing.Size(224, 360);
            this.pictureBoxTrays.TabIndex = 2;
            this.pictureBoxTrays.TabStop = false;
            this.pictureBoxTrays.Click += new System.EventHandler(this.pictureBoxTrays_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(33, 468);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(204, 31);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 556);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pictureBoxTrays);
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.pictureBoxMachine);
            this.Name = "Machine";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMachine;
        private System.Windows.Forms.PictureBox pictureBoxPanel;
        private System.Windows.Forms.PictureBox pictureBoxTrays;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

