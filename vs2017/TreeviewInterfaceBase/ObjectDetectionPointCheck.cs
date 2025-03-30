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

        public string maskFilePath
        {
            set
            {
                textBox_MaskFilePath.Text = value;
                if (File.Exists(value))
                {
                    updatePictureBox(pictureBox_maskImage, value);

                }
            }
            get { return textBox_MaskFilePath.Text; }
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

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (pictureBox_maskImage.Image != null)
            {
                Bitmap bitmap = (Bitmap)pictureBox_maskImage.Image;
                // 各ピクセルを走査
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        // 現在のピクセルを取得
                        Color pixel = bitmap.GetPixel(x, y);

                        // Rの値が254である場合に変更
                        if (pixel.R >= 240)
                        {
                            Color newPixel = Color.FromArgb(pixel.A, 240, pixel.G, pixel.B);
                            bitmap.SetPixel(x, y, newPixel);
                        }
                        if (pixel.G >= 240)
                        {
                            Color newPixel = Color.FromArgb(pixel.A, pixel.R, 240, pixel.B);
                            bitmap.SetPixel(x, y, newPixel);
                        }
                        if (pixel.B >= 240)
                        {
                            Color newPixel = Color.FromArgb(pixel.A, pixel.R, pixel.G, 240);
                            bitmap.SetPixel(x, y, newPixel);
                        }
                    }
                }
            }
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

        private void textBox_MaskFilePath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(textBox_MaskFilePath.Text))
            {
                pictureBox_maskImage.Image = new Bitmap(textBox_MaskFilePath.Text);
            }
        }
        bool _mouseDrug;
        int _prevX;
        int _prevY;

        private void pictureBox_maskImage_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDrug = true;
            _prevX = e.Location.X;
            _prevY = e.Location.Y;
        }

        private void pictureBox_maskImage_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDrug = false;
        }

        private void pictureBox_maskImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDrug == true)
            {
                using (Graphics g = Graphics.FromImage(pictureBox_maskImage.Image))
                using (Pen p = new Pen(Color.Black, 3))
                {
                    g.DrawLine(p, _prevX, _prevY, e.Location.X, e.Location.Y);
                    _prevX = e.Location.X;
                    _prevY = e.Location.Y;
                }
                pictureBox_maskImage.Refresh();
            }
        }
    }
}
