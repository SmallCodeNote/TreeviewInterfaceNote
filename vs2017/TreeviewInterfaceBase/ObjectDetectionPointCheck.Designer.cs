namespace TreeviewInterfaceBase
{
    partial class ObjectDetectionPointCheck
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Top = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_MaskFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DataFileDirectoryPath = new System.Windows.Forms.TextBox();
            this.label_DataFileDirectoryPath = new System.Windows.Forms.Label();
            this.textBox_ModelFilePath = new System.Windows.Forms.TextBox();
            this.label_ModelFilePath = new System.Windows.Forms.Label();
            this.label_MaskImage = new System.Windows.Forms.Label();
            this.panel_MaskImageFrame = new System.Windows.Forms.Panel();
            this.pictureBox_maskImage = new System.Windows.Forms.PictureBox();
            this.textBox_configName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_ch1 = new System.Windows.Forms.RadioButton();
            this.radioButton_ch2 = new System.Windows.Forms.RadioButton();
            this.radioButton_ch3 = new System.Windows.Forms.RadioButton();
            this.radioButton_nan = new System.Windows.Forms.RadioButton();
            this.button_Create = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_getMaskFilePath = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_getModelFilePath = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_MaskImageFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maskImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.textBox_configName);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.label_Top);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.panel1.Size = new System.Drawing.Size(470, 38);
            this.panel1.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Save.Location = new System.Drawing.Point(387, 8);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 22);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_Top
            // 
            this.label_Top.AutoSize = true;
            this.label_Top.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Top.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Top.Location = new System.Drawing.Point(0, 8);
            this.label_Top.Name = "label_Top";
            this.label_Top.Size = new System.Drawing.Size(249, 16);
            this.label_Top.TabIndex = 0;
            this.label_Top.Text = "ObjectDetectionAndPointCheck";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_MaskImageFrame);
            this.panel2.Controls.Add(this.label_MaskImage);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_DataFileDirectoryPath);
            this.panel2.Controls.Add(this.label_DataFileDirectoryPath);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label_ModelFilePath);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 38);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.panel2.Size = new System.Drawing.Size(470, 462);
            this.panel2.TabIndex = 1;
            // 
            // textBox_MaskFilePath
            // 
            this.textBox_MaskFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MaskFilePath.Location = new System.Drawing.Point(0, 0);
            this.textBox_MaskFilePath.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_MaskFilePath.Multiline = true;
            this.textBox_MaskFilePath.Name = "textBox_MaskFilePath";
            this.textBox_MaskFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_MaskFilePath.Size = new System.Drawing.Size(400, 38);
            this.textBox_MaskFilePath.TabIndex = 5;
            this.textBox_MaskFilePath.TextChanged += new System.EventHandler(this.textBox_MaskFilePath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(20, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 1);
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "MaskFilePath";
            // 
            // textBox_DataFileDirectoryPath
            // 
            this.textBox_DataFileDirectoryPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_DataFileDirectoryPath.Location = new System.Drawing.Point(20, 82);
            this.textBox_DataFileDirectoryPath.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_DataFileDirectoryPath.Multiline = true;
            this.textBox_DataFileDirectoryPath.Name = "textBox_DataFileDirectoryPath";
            this.textBox_DataFileDirectoryPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_DataFileDirectoryPath.Size = new System.Drawing.Size(430, 38);
            this.textBox_DataFileDirectoryPath.TabIndex = 3;
            // 
            // label_DataFileDirectoryPath
            // 
            this.label_DataFileDirectoryPath.AutoSize = true;
            this.label_DataFileDirectoryPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DataFileDirectoryPath.Location = new System.Drawing.Point(20, 61);
            this.label_DataFileDirectoryPath.Margin = new System.Windows.Forms.Padding(10);
            this.label_DataFileDirectoryPath.Name = "label_DataFileDirectoryPath";
            this.label_DataFileDirectoryPath.Padding = new System.Windows.Forms.Padding(0, 8, 0, 1);
            this.label_DataFileDirectoryPath.Size = new System.Drawing.Size(118, 21);
            this.label_DataFileDirectoryPath.TabIndex = 2;
            this.label_DataFileDirectoryPath.Text = "DataFileDirectoryPath";
            // 
            // textBox_ModelFilePath
            // 
            this.textBox_ModelFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ModelFilePath.Location = new System.Drawing.Point(0, 0);
            this.textBox_ModelFilePath.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_ModelFilePath.Multiline = true;
            this.textBox_ModelFilePath.Name = "textBox_ModelFilePath";
            this.textBox_ModelFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ModelFilePath.Size = new System.Drawing.Size(400, 38);
            this.textBox_ModelFilePath.TabIndex = 1;
            // 
            // label_ModelFilePath
            // 
            this.label_ModelFilePath.AutoSize = true;
            this.label_ModelFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ModelFilePath.Location = new System.Drawing.Point(20, 10);
            this.label_ModelFilePath.Margin = new System.Windows.Forms.Padding(10);
            this.label_ModelFilePath.Name = "label_ModelFilePath";
            this.label_ModelFilePath.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.label_ModelFilePath.Size = new System.Drawing.Size(77, 13);
            this.label_ModelFilePath.TabIndex = 0;
            this.label_ModelFilePath.Text = "ModelFilePath";
            // 
            // label_MaskImage
            // 
            this.label_MaskImage.AutoSize = true;
            this.label_MaskImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_MaskImage.Location = new System.Drawing.Point(20, 179);
            this.label_MaskImage.Margin = new System.Windows.Forms.Padding(10);
            this.label_MaskImage.Name = "label_MaskImage";
            this.label_MaskImage.Padding = new System.Windows.Forms.Padding(0, 8, 0, 1);
            this.label_MaskImage.Size = new System.Drawing.Size(62, 21);
            this.label_MaskImage.TabIndex = 6;
            this.label_MaskImage.Text = "MaskImage";
            // 
            // panel_MaskImageFrame
            // 
            this.panel_MaskImageFrame.AutoScroll = true;
            this.panel_MaskImageFrame.Controls.Add(this.pictureBox_maskImage);
            this.panel_MaskImageFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MaskImageFrame.Location = new System.Drawing.Point(20, 200);
            this.panel_MaskImageFrame.Name = "panel_MaskImageFrame";
            this.panel_MaskImageFrame.Size = new System.Drawing.Size(430, 199);
            this.panel_MaskImageFrame.TabIndex = 7;
            // 
            // pictureBox_maskImage
            // 
            this.pictureBox_maskImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_maskImage.Name = "pictureBox_maskImage";
            this.pictureBox_maskImage.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_maskImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_maskImage.TabIndex = 0;
            this.pictureBox_maskImage.TabStop = false;
            this.pictureBox_maskImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_maskImage_MouseDown);
            this.pictureBox_maskImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_maskImage_MouseMove);
            this.pictureBox_maskImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_maskImage_MouseUp);
            // 
            // textBox_configName
            // 
            this.textBox_configName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_configName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_configName.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_configName.Location = new System.Drawing.Point(287, 8);
            this.textBox_configName.Name = "textBox_configName";
            this.textBox_configName.Size = new System.Drawing.Size(100, 16);
            this.textBox_configName.TabIndex = 2;
            this.textBox_configName.TextChanged += new System.EventHandler(this.textBox_configName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel3.Size = new System.Drawing.Size(10, 500);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 490);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.button_Create);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(20, 399);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 43);
            this.panel5.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_nan);
            this.groupBox1.Controls.Add(this.radioButton_ch3);
            this.groupBox1.Controls.Add(this.radioButton_ch2);
            this.groupBox1.Controls.Add(this.radioButton_ch1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_ch1
            // 
            this.radioButton_ch1.AutoSize = true;
            this.radioButton_ch1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_ch1.Location = new System.Drawing.Point(3, 15);
            this.radioButton_ch1.Name = "radioButton_ch1";
            this.radioButton_ch1.Size = new System.Drawing.Size(41, 25);
            this.radioButton_ch1.TabIndex = 0;
            this.radioButton_ch1.Text = "ch1";
            this.radioButton_ch1.UseVisualStyleBackColor = true;
            // 
            // radioButton_ch2
            // 
            this.radioButton_ch2.AutoSize = true;
            this.radioButton_ch2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_ch2.Location = new System.Drawing.Point(44, 15);
            this.radioButton_ch2.Name = "radioButton_ch2";
            this.radioButton_ch2.Size = new System.Drawing.Size(41, 25);
            this.radioButton_ch2.TabIndex = 1;
            this.radioButton_ch2.Text = "ch2";
            this.radioButton_ch2.UseVisualStyleBackColor = true;
            // 
            // radioButton_ch3
            // 
            this.radioButton_ch3.AutoSize = true;
            this.radioButton_ch3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_ch3.Location = new System.Drawing.Point(85, 15);
            this.radioButton_ch3.Name = "radioButton_ch3";
            this.radioButton_ch3.Size = new System.Drawing.Size(41, 25);
            this.radioButton_ch3.TabIndex = 2;
            this.radioButton_ch3.Text = "ch3";
            this.radioButton_ch3.UseVisualStyleBackColor = true;
            // 
            // radioButton_nan
            // 
            this.radioButton_nan.AutoSize = true;
            this.radioButton_nan.Checked = true;
            this.radioButton_nan.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_nan.Location = new System.Drawing.Point(126, 15);
            this.radioButton_nan.Name = "radioButton_nan";
            this.radioButton_nan.Size = new System.Drawing.Size(41, 25);
            this.radioButton_nan.TabIndex = 3;
            this.radioButton_nan.TabStop = true;
            this.radioButton_nan.Text = "nan";
            this.radioButton_nan.UseVisualStyleBackColor = true;
            // 
            // button_Create
            // 
            this.button_Create.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Create.Location = new System.Drawing.Point(355, 0);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 43);
            this.button_Create.TabIndex = 4;
            this.button_Create.Text = "Brightness Down";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox_MaskFilePath);
            this.panel6.Controls.Add(this.button_getMaskFilePath);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(20, 141);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 38);
            this.panel6.TabIndex = 9;
            // 
            // button_getMaskFilePath
            // 
            this.button_getMaskFilePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_getMaskFilePath.Location = new System.Drawing.Point(400, 0);
            this.button_getMaskFilePath.Name = "button_getMaskFilePath";
            this.button_getMaskFilePath.Size = new System.Drawing.Size(30, 38);
            this.button_getMaskFilePath.TabIndex = 6;
            this.button_getMaskFilePath.Text = "...";
            this.button_getMaskFilePath.UseVisualStyleBackColor = true;
            this.button_getMaskFilePath.Click += new System.EventHandler(this.button_getMaskFilePath_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox_ModelFilePath);
            this.panel7.Controls.Add(this.button_getModelFilePath);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(20, 23);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(430, 38);
            this.panel7.TabIndex = 10;
            // 
            // button_getModelFilePath
            // 
            this.button_getModelFilePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_getModelFilePath.Location = new System.Drawing.Point(400, 0);
            this.button_getModelFilePath.Name = "button_getModelFilePath";
            this.button_getModelFilePath.Size = new System.Drawing.Size(30, 38);
            this.button_getModelFilePath.TabIndex = 2;
            this.button_getModelFilePath.Text = "...";
            this.button_getModelFilePath.UseVisualStyleBackColor = true;
            this.button_getModelFilePath.Click += new System.EventHandler(this.button_getModelFilePath_Click);
            // 
            // ObjectDetectionPointCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ObjectDetectionPointCheck";
            this.Size = new System.Drawing.Size(480, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_MaskImageFrame.ResumeLayout(false);
            this.panel_MaskImageFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maskImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Top;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_ModelFilePath;
        private System.Windows.Forms.Label label_ModelFilePath;
        private System.Windows.Forms.TextBox textBox_DataFileDirectoryPath;
        private System.Windows.Forms.Label label_DataFileDirectoryPath;
        private System.Windows.Forms.TextBox textBox_MaskFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_MaskImageFrame;
        private System.Windows.Forms.Label label_MaskImage;
        private System.Windows.Forms.PictureBox pictureBox_maskImage;
        private System.Windows.Forms.TextBox textBox_configName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_nan;
        private System.Windows.Forms.RadioButton radioButton_ch3;
        private System.Windows.Forms.RadioButton radioButton_ch2;
        private System.Windows.Forms.RadioButton radioButton_ch1;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_getMaskFilePath;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_getModelFilePath;
    }
}
