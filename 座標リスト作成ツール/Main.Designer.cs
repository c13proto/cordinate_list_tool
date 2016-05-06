namespace 座標リスト作成ツール
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Open = new System.Windows.Forms.Button();
            this.textBox_list = new System.Windows.Forms.TextBox();
            this.label_pos = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(13, 13);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(91, 23);
            this.button_Open.TabIndex = 0;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.Click_Open);
            // 
            // textBox_list
            // 
            this.textBox_list.AcceptsReturn = true;
            this.textBox_list.AcceptsTab = true;
            this.textBox_list.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_list.Location = new System.Drawing.Point(13, 85);
            this.textBox_list.Multiline = true;
            this.textBox_list.Name = "textBox_list";
            this.textBox_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_list.Size = new System.Drawing.Size(91, 477);
            this.textBox_list.TabIndex = 4;
            // 
            // label_pos
            // 
            this.label_pos.AutoSize = true;
            this.label_pos.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_pos.Location = new System.Drawing.Point(12, 68);
            this.label_pos.Name = "label_pos";
            this.label_pos.Size = new System.Drawing.Size(23, 14);
            this.label_pos.TabIndex = 5;
            this.label_pos.Text = "x,y";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(12, 42);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(92, 23);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Click_Save);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(116, 584);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_pos);
            this.Controls.Add(this.textBox_list);
            this.Controls.Add(this.button_Open);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.TextBox textBox_list;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.Button button_Save;
    }
}

