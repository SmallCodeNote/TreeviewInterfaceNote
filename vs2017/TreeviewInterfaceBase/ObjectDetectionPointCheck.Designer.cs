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
            this.textBox_configName = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Top = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_MaskList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DataFileDirectoryPath = new System.Windows.Forms.TextBox();
            this.label_DataFileDirectoryPath = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox_ModelFilePath = new System.Windows.Forms.TextBox();
            this.button_getModelFilePath = new System.Windows.Forms.Button();
            this.label_ModelFilePath = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_openFileButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_Mode = new System.Windows.Forms.Label();
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MaskList)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel2.Controls.Add(this.dataGridView_MaskList);
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
            this.panel2.Size = new System.Drawing.Size(470, 240);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_MaskList
            // 
            this.dataGridView_MaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Path,
            this.Column_openFileButton});
            this.dataGridView_MaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MaskList.Location = new System.Drawing.Point(20, 153);
            this.dataGridView_MaskList.Name = "dataGridView_MaskList";
            this.dataGridView_MaskList.RowTemplate.Height = 21;
            this.dataGridView_MaskList.Size = new System.Drawing.Size(430, 67);
            this.dataGridView_MaskList.TabIndex = 11;
            this.dataGridView_MaskList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MaskList_CellClick);
            this.dataGridView_MaskList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_MaskList_CellPainting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(20, 132);
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
            this.textBox_DataFileDirectoryPath.Location = new System.Drawing.Point(20, 102);
            this.textBox_DataFileDirectoryPath.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_DataFileDirectoryPath.Multiline = true;
            this.textBox_DataFileDirectoryPath.Name = "textBox_DataFileDirectoryPath";
            this.textBox_DataFileDirectoryPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_DataFileDirectoryPath.Size = new System.Drawing.Size(430, 30);
            this.textBox_DataFileDirectoryPath.TabIndex = 3;
            // 
            // label_DataFileDirectoryPath
            // 
            this.label_DataFileDirectoryPath.AutoSize = true;
            this.label_DataFileDirectoryPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DataFileDirectoryPath.Location = new System.Drawing.Point(20, 81);
            this.label_DataFileDirectoryPath.Margin = new System.Windows.Forms.Padding(10);
            this.label_DataFileDirectoryPath.Name = "label_DataFileDirectoryPath";
            this.label_DataFileDirectoryPath.Padding = new System.Windows.Forms.Padding(0, 8, 0, 1);
            this.label_DataFileDirectoryPath.Size = new System.Drawing.Size(118, 21);
            this.label_DataFileDirectoryPath.TabIndex = 2;
            this.label_DataFileDirectoryPath.Text = "DataFileDirectoryPath";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox_ModelFilePath);
            this.panel7.Controls.Add(this.button_getModelFilePath);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(20, 51);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(430, 30);
            this.panel7.TabIndex = 10;
            // 
            // textBox_ModelFilePath
            // 
            this.textBox_ModelFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ModelFilePath.Location = new System.Drawing.Point(0, 0);
            this.textBox_ModelFilePath.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_ModelFilePath.Multiline = true;
            this.textBox_ModelFilePath.Name = "textBox_ModelFilePath";
            this.textBox_ModelFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ModelFilePath.Size = new System.Drawing.Size(400, 30);
            this.textBox_ModelFilePath.TabIndex = 1;
            // 
            // button_getModelFilePath
            // 
            this.button_getModelFilePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_getModelFilePath.Location = new System.Drawing.Point(400, 0);
            this.button_getModelFilePath.Name = "button_getModelFilePath";
            this.button_getModelFilePath.Size = new System.Drawing.Size(30, 30);
            this.button_getModelFilePath.TabIndex = 2;
            this.button_getModelFilePath.Text = "...";
            this.button_getModelFilePath.UseVisualStyleBackColor = true;
            this.button_getModelFilePath.Click += new System.EventHandler(this.button_getModelFilePath_Click);
            // 
            // label_ModelFilePath
            // 
            this.label_ModelFilePath.AutoSize = true;
            this.label_ModelFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ModelFilePath.Location = new System.Drawing.Point(20, 30);
            this.label_ModelFilePath.Margin = new System.Windows.Forms.Padding(10);
            this.label_ModelFilePath.Name = "label_ModelFilePath";
            this.label_ModelFilePath.Padding = new System.Windows.Forms.Padding(0, 8, 0, 1);
            this.label_ModelFilePath.Size = new System.Drawing.Size(77, 21);
            this.label_ModelFilePath.TabIndex = 0;
            this.label_ModelFilePath.Text = "ModelFilePath";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel3.Size = new System.Drawing.Size(10, 278);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 268);
            this.panel4.TabIndex = 0;
            // 
            // Column_Name
            // 
            this.Column_Name.Frozen = true;
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_Path
            // 
            this.Column_Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Path.HeaderText = "Path";
            this.Column_Path.Name = "Column_Path";
            // 
            // Column_openFileButton
            // 
            this.Column_openFileButton.HeaderText = "...";
            this.Column_openFileButton.MinimumWidth = 20;
            this.Column_openFileButton.Name = "Column_openFileButton";
            this.Column_openFileButton.Width = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBox_Mode);
            this.panel5.Controls.Add(this.label_Mode);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(20, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 20);
            this.panel5.TabIndex = 12;
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Mode.Location = new System.Drawing.Point(0, 0);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label_Mode.Size = new System.Drawing.Size(42, 12);
            this.label_Mode.TabIndex = 0;
            this.label_Mode.Text = "Mode";
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Items.AddRange(new object[] {
            "Mode1",
            "Mode2",
            "Mode3"});
            this.comboBox_Mode.Location = new System.Drawing.Point(42, 0);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(120, 20);
            this.comboBox_Mode.TabIndex = 1;
            // 
            // ObjectDetectionPointCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ObjectDetectionPointCheck";
            this.Size = new System.Drawing.Size(480, 278);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MaskList)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_configName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_getModelFilePath;
        private System.Windows.Forms.DataGridView dataGridView_MaskList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Path;
        private System.Windows.Forms.DataGridViewButtonColumn Column_openFileButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBox_Mode;
        private System.Windows.Forms.Label label_Mode;
    }
}
