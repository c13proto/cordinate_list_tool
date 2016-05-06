namespace 座標リスト作成ツール
{
    partial class 写真画面
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Resize = new System.Windows.Forms.Button();
            this.textBox_Resize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(65, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(430, 362);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.Click_PictureBox);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_pictureBox);
            // 
            // button_Resize
            // 
            this.button_Resize.Location = new System.Drawing.Point(12, 37);
            this.button_Resize.Name = "button_Resize";
            this.button_Resize.Size = new System.Drawing.Size(47, 23);
            this.button_Resize.TabIndex = 4;
            this.button_Resize.Text = "Resize";
            this.button_Resize.UseVisualStyleBackColor = true;
            this.button_Resize.Click += new System.EventHandler(this.Click_Resize);
            // 
            // textBox_Resize
            // 
            this.textBox_Resize.Location = new System.Drawing.Point(12, 12);
            this.textBox_Resize.Name = "textBox_Resize";
            this.textBox_Resize.Size = new System.Drawing.Size(21, 19);
            this.textBox_Resize.TabIndex = 3;
            this.textBox_Resize.Text = "2.0";
            // 
            // 写真画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(503, 384);
            this.Controls.Add(this.button_Resize);
            this.Controls.Add(this.textBox_Resize);
            this.Controls.Add(this.pictureBox);
            this.Name = "写真画面";
            this.Text = "写真画面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_Resize;
        private System.Windows.Forms.TextBox textBox_Resize;
    }
}