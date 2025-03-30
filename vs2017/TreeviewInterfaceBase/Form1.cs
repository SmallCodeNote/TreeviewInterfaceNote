using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using WinFormStringCnvClass;

namespace TreeviewInterfaceBase
{
    public partial class Form1 : Form
    {
        string thisExeDirPath;
        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename))
                {
                    WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
                }
            }

            panel_configFrame.Height = 0;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
            }

        }

        private void textBox_configPath_TextChanged(object sender, EventArgs e)
        {
            string targetPath = textBox_configPath.Text;

            if (Directory.Exists(targetPath))
            {
                LoadDirectory(targetPath, treeView_config.Nodes);
                treeView_config.ExpandAll();

            }
        }

        void LoadDirectory(string path, TreeNodeCollection nodes)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                if (directoryInfo.Name == ".config") return;

                TreeNode directoryNode = new TreeNode(directoryInfo.Name);
                directoryNode.Tag = directoryInfo.FullName;
                nodes.Add(directoryNode);

                foreach (var subDirectory in directoryInfo.GetDirectories())
                {
                    LoadDirectory(subDirectory.FullName, directoryNode.Nodes);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void treeView_config_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                e.Cancel = true;
            }
        }

        private void button_Add_ObjectDetectionPointCheck_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(selectedNodePath))
            {
                var ctrl = new ObjectDetectionPointCheck(selectedNodePath);
                ctrl.Top = panel_configFrame.Height;
                panel_configFrame.Height += ctrl.Height;
                ctrl.Dock = DockStyle.Top;
                panel_configFrame.Controls.Add(ctrl);
            }
        }

        public string selectedNodePath;

        private void treeView_config_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNodePath = treeView_config.SelectedNode.Tag.ToString();

            panel_configFrame.Controls.Clear();
            panel_configFrame.Height = 0;

            string[] files = Directory.GetFiles(selectedNodePath, ".config*.txt", SearchOption.AllDirectories);
            Array.Sort(files);
            Array.Reverse(files);

            foreach (var configFilePath in files)
            {
                string filename = Path.GetFileName(configFilePath);
                int findindex = filename.IndexOf(".config_ObjectDetectionPointCheck");
                if (findindex == 0)
                {
                    var ctrl = new ObjectDetectionPointCheck(configFilePath);
                    ctrl.Top = panel_configFrame.Height;
                    panel_configFrame.Height += ctrl.Height;
                    ctrl.Dock = DockStyle.Top;
                    panel_configFrame.Controls.Add(ctrl);

                }
                else
                {

                }

            }

        }
    }
}
