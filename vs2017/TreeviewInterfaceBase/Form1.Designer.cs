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
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_config = new System.Windows.Forms.TabPage();
            this.panel_configMain = new System.Windows.Forms.Panel();
            this.panel_configFrame = new System.Windows.Forms.Panel();
            this.panel_configBottom = new System.Windows.Forms.Panel();
            this.treeView_config = new System.Windows.Forms.TreeView();
            this.tabPage_RunSetting = new System.Windows.Forms.TabPage();
            this.textBox_configPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_AddButtons = new System.Windows.Forms.Panel();
            this.button_Add_ObjectDetectionPointCheck = new System.Windows.Forms.Button();
            this.panel_AddButtonsHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_config.SuspendLayout();
            this.panel_configMain.SuspendLayout();
            this.panel_configBottom.SuspendLayout();
            this.tabPage_RunSetting.SuspendLayout();
            this.panel_AddButtons.SuspendLayout();
            this.panel_AddButtonsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_config);
            this.tabControl_Main.Controls.Add(this.tabPage_RunSetting);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(703, 711);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_config
            // 
            this.tabPage_config.Controls.Add(this.panel_configMain);
            this.tabPage_config.Controls.Add(this.panel_configBottom);
            this.tabPage_config.Controls.Add(this.treeView_config);
            this.tabPage_config.Location = new System.Drawing.Point(4, 22);
            this.tabPage_config.Name = "tabPage_config";
            this.tabPage_config.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_config.Size = new System.Drawing.Size(695, 685);
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
            this.panel_configMain.Size = new System.Drawing.Size(540, 616);
            this.panel_configMain.TabIndex = 2;
            // 
            // panel_configFrame
            // 
            this.panel_configFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_configFrame.Location = new System.Drawing.Point(0, 0);
            this.panel_configFrame.Name = "panel_configFrame";
            this.panel_configFrame.Size = new System.Drawing.Size(540, 88);
            this.panel_configFrame.TabIndex = 0;
            // 
            // panel_configBottom
            // 
            this.panel_configBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_configBottom.Controls.Add(this.panel_AddButtons);
            this.panel_configBottom.Controls.Add(this.panel_AddButtonsHeader);
            this.panel_configBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_configBottom.Location = new System.Drawing.Point(152, 619);
            this.panel_configBottom.Name = "panel_configBottom";
            this.panel_configBottom.Size = new System.Drawing.Size(540, 63);
            this.panel_configBottom.TabIndex = 1;
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
            // tabPage_RunSetting
            // 
            this.tabPage_RunSetting.Controls.Add(this.textBox_configPath);
            this.tabPage_RunSetting.Controls.Add(this.label1);
            this.tabPage_RunSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RunSetting.Name = "tabPage_RunSetting";
            this.tabPage_RunSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RunSetting.Size = new System.Drawing.Size(695, 685);
            this.tabPage_RunSetting.TabIndex = 1;
            this.tabPage_RunSetting.Text = "Run";
            this.tabPage_RunSetting.UseVisualStyleBackColor = true;
            // 
            // textBox_configPath
            // 
            this.textBox_configPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_configPath.Location = new System.Drawing.Point(3, 15);
            this.textBox_configPath.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_configPath.Name = "textBox_configPath";
            this.textBox_configPath.Size = new System.Drawing.Size(689, 19);
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
            // panel_AddButtons
            // 
            this.panel_AddButtons.Controls.Add(this.button_Add_ObjectDetectionPointCheck);
            this.panel_AddButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AddButtons.Location = new System.Drawing.Point(0, 22);
            this.panel_AddButtons.Name = "panel_AddButtons";
            this.panel_AddButtons.Size = new System.Drawing.Size(538, 39);
            this.panel_AddButtons.TabIndex = 1;
            // 
            // button_Add_ObjectDetectionPointCheck
            // 
            this.button_Add_ObjectDetectionPointCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Add_ObjectDetectionPointCheck.Location = new System.Drawing.Point(0, 0);
            this.button_Add_ObjectDetectionPointCheck.Name = "button_Add_ObjectDetectionPointCheck";
            this.button_Add_ObjectDetectionPointCheck.Size = new System.Drawing.Size(97, 39);
            this.button_Add_ObjectDetectionPointCheck.TabIndex = 1;
            this.button_Add_ObjectDetectionPointCheck.Text = "ObjectDetectionPointCheck";
            this.button_Add_ObjectDetectionPointCheck.UseVisualStyleBackColor = true;
            // 
            // panel_AddButtonsHeader
            // 
            this.panel_AddButtonsHeader.BackColor = System.Drawing.Color.Transparent;
            this.panel_AddButtonsHeader.Controls.Add(this.label2);
            this.panel_AddButtonsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_AddButtonsHeader.Location = new System.Drawing.Point(0, 0);
            this.panel_AddButtonsHeader.Name = "panel_AddButtonsHeader";
            this.panel_AddButtonsHeader.Size = new System.Drawing.Size(538, 22);
            this.panel_AddButtonsHeader.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 711);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "Form1";
            this.Text = "TreeviewInterfaceBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_config.ResumeLayout(false);
            this.panel_configMain.ResumeLayout(false);
            this.panel_configBottom.ResumeLayout(false);
            this.tabPage_RunSetting.ResumeLayout(false);
            this.tabPage_RunSetting.PerformLayout();
            this.panel_AddButtons.ResumeLayout(false);
            this.panel_AddButtonsHeader.ResumeLayout(false);
            this.panel_AddButtonsHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_config;
        private System.Windows.Forms.TabPage tabPage_RunSetting;
        private System.Windows.Forms.Panel panel_configMain;
        private System.Windows.Forms.Panel panel_configFrame;
        private System.Windows.Forms.Panel panel_configBottom;
        private System.Windows.Forms.TreeView treeView_config;
        private System.Windows.Forms.TextBox textBox_configPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_AddButtons;
        private System.Windows.Forms.Button button_Add_ObjectDetectionPointCheck;
        private System.Windows.Forms.Panel panel_AddButtonsHeader;
        private System.Windows.Forms.Label label2;
    }
}

