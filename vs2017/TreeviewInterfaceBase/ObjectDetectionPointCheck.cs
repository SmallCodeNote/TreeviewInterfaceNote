using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using WinFormStringCnvClass;

namespace TreeviewInterfaceBase
{
    public partial class ObjectDetectionPointCheck : UserControl, IUserControlActions
    {
        public string thisConfigPath;
        public string configName = "";

        public string modeFilePath
        {
            set { textBox_ModelFilePath.Text = value; }
            get { return textBox_ModelFilePath.Text; }
        }

        public string detaFileDirectoryPath
        {
            set { textBox_DataFileDirectoryPath.Text = value; }
            get { return textBox_DataFileDirectoryPath.Text; }
        }


        private void updatePictureBox(PictureBox pictureBox, string filePath)
        {
            if (File.Exists(filePath))
            {
                if (pictureBox.Image != null) pictureBox.Image.Dispose();
                pictureBox.Image = new Bitmap(filePath);

            }
        }

        public ObjectDetectionPointCheck(string configPath = "")
        {
            InitializeComponent();

            if (File.Exists(configPath))
            {
                this.thisConfigPath = configPath;
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(thisConfigPath));
            }
            else if (Directory.Exists(configPath))
            {
                string nodePath = configPath;
                thisConfigPath = createNewConfigFilePath(nodePath);
            }
            else
            {
                this.thisConfigPath = configPath;
            }
        }

        public string createNewConfigFilePath(string nodePath)
        {
            if (Directory.Exists(nodePath))
            {
                return Path.Combine(nodePath, ".config_" + this.GetType().Name + "_" + textBox_configName.Text + ".txt");
            }
            else
            {
                return "";
            }
        }

        public void updateConfigFilePath()
        {
            try
            {
                string nodePath = Path.GetDirectoryName(thisConfigPath);
                if (Directory.Exists(nodePath))
                {
                    string newConfigPath = createNewConfigFilePath(nodePath);
                    if (File.Exists(thisConfigPath) && thisConfigPath != newConfigPath)
                    {
                        File.Move(thisConfigPath, newConfigPath);
                    }
                    thisConfigPath = newConfigPath;
                }
            }
            catch
            {

            }
        }

        public void SaveConfig()
        {
            updateConfigFilePath();
            string cntrolContents = WinFormStringCnv.ToString(this);
            File.WriteAllText(thisConfigPath, cntrolContents);
        }

        public string Run()
        {


            return "";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void textBox_configName_TextChanged(object sender, EventArgs e)
        {
            updateConfigFilePath();
        }

        private void button_getModelFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ONNX|*.onnx";
            ofd.Title = "Select a Model File";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            textBox_ModelFilePath.Text = ofd.FileName;
        }

        private void button_getMaskFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            ofd.Title = "Select an Image File";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            textBox_ModelFilePath.Text = ofd.FileName;

        }

        private void dataGridView_MaskList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ボタン列がクリックされたかを確認
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) // 2はボタン列のインデックス
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        // 選択された行のColumn_Path列にファイルパスを格納
                        dataGridView_MaskList.Rows[e.RowIndex].Cells["Column_Path"].Value = filePath;
                    }
                }
            }
        }

        private void dataGridView_MaskList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int RowsCount = ((DataGridView)sender).Rows.Count-1;
            if (e.RowIndex < RowsCount && e.ColumnIndex < 0 && e.RowIndex >= 0)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                Rectangle indexRect = e.CellBounds;
                indexRect.Inflate(-2, -2);

                TextRenderer.DrawText(e.Graphics,
                    (e.RowIndex + 1).ToString(),
                    e.CellStyle.Font,
                    indexRect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
        }
    }
}
