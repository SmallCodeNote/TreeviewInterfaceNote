namespace TreeviewInterfaceBase
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_config = new System.Windows.Forms.TabPage();
            this.panel_configMain = new System.Windows.Forms.Panel();
            this.panel_configFrame = new System.Windows.Forms.Panel();
            this.panel_configBottom = new System.Windows.Forms.Panel();
            this.button_Add_ObjectDetectionPointCheck = new System.Windows.Forms.Button();
            this.treeView_config = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_configPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_config.SuspendLayout();
            this.panel_configMain.SuspendLayout();
            this.panel_configBottom.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_config);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 711);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_config
            // 
            this.tabPage_config.Controls.Add(this.panel_configMain);
            this.tabPage_config.Controls.Add(this.panel_configBottom);
            this.tabPage_config.Controls.Add(this.treeView_config);
            this.tabPage_config.Location = new System.Drawing.Point(4, 22);
            this.tabPage_config.Name = "tabPage_config";
            this.tabPage_config.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_config.Size = new System.Drawing.Size(1058, 685);
            this.tabPage_config.TabIndex = 0;
            this.tabPage_config.Text = "Config";
            this.tabPage_config.UseVisualStyleBackColor = true;
            // 
            // panel_configMain
            // 
            this.panel_configMain.AutoScroll = true;
            this.panel_configMain.Controls.Add(this.panel_configFrame);
            this.panel_configMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_configMain.Location = new System.Drawing.Point(152, 3);
            this.panel_configMain.Name = "panel_configMain";
            this.panel_configMain.Size = new System.Drawing.Size(903, 642);
            this.panel_configMain.TabIndex = 2;
            // 
            // panel_configFrame
            // 
            this.panel_configFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_configFrame.Location = new System.Drawing.Point(0, 0);
            this.panel_configFrame.Name = "panel_configFrame";
            this.panel_configFrame.Size = new System.Drawing.Size(903, 88);
            this.panel_configFrame.TabIndex = 0;
            // 
            // panel_configBottom
            // 
            this.panel_configBottom.Controls.Add(this.button_Add_ObjectDetectionPointCheck);
            this.panel_configBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_configBottom.Location = new System.Drawing.Point(152, 645);
            this.panel_configBottom.Name = "panel_configBottom";
            this.panel_configBottom.Size = new System.Drawing.Size(903, 37);
            this.panel_configBottom.TabIndex = 1;
            // 
            // button_Add_ObjectDetectionPointCheck
            // 
            this.button_Add_ObjectDetectionPointCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Add_ObjectDetectionPointCheck.Location = new System.Drawing.Point(0, 0);
            this.button_Add_ObjectDetectionPointCheck.Name = "button_Add_ObjectDetectionPointCheck";
            this.button_Add_ObjectDetectionPointCheck.Size = new System.Drawing.Size(97, 37);
            this.button_Add_ObjectDetectionPointCheck.TabIndex = 0;
            this.button_Add_ObjectDetectionPointCheck.Text = "ObjectDetectionPointCheck";
            this.button_Add_ObjectDetectionPointCheck.UseVisualStyleBackColor = true;
            this.button_Add_ObjectDetectionPointCheck.Click += new System.EventHandler(this.button_Add_ObjectDetectionPointCheck_Click);
            // 
            // treeView_config
            // 
            this.treeView_config.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_config.Location = new System.Drawing.Point(3, 3);
            this.treeView_config.Name = "treeView_config";
            this.treeView_config.Size = new System.Drawing.Size(149, 679);
            this.treeView_config.TabIndex = 0;
            this.treeView_config.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_config_BeforeSelect);
            this.treeView_config.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_config_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_configPath);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Run";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_configPath
            // 
            this.textBox_configPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_configPath.Location = new System.Drawing.Point(3, 15);
            this.textBox_configPath.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_configPath.Name = "textBox_configPath";
            this.textBox_configPath.Size = new System.Drawing.Size(1052, 19);
            this.textBox_configPath.TabIndex = 1;
            this.textBox_configPath.TextChanged += new System.EventHandler(this.textBox_configPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config Directory Path  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 711);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TreeviewInterfaceBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_config.ResumeLayout(false);
            this.panel_configMain.ResumeLayout(false);
            this.panel_configBottom.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_config;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_configMain;
        private System.Windows.Forms.Panel panel_configFrame;
        private System.Windows.Forms.Panel panel_configBottom;
        private System.Windows.Forms.TreeView treeView_config;
        private System.Windows.Forms.TextBox textBox_configPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Add_ObjectDetectionPointCheck;
    }
}

