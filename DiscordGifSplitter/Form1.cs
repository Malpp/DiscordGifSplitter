using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DiscordGifSplitter
{
    public partial class MainWindow : Form
    {
        private float NumOfCellsX => (float) gridX.Value;
        private float NumOfCellsY => (float) gridY.Value;

        private float Scale
        {
            get
            {
                if (imageViewer.Image != null)
                {
                    return Math.Min((float) imageViewer.ClientSize.Width / imageViewer.Image.Width,
                        (float) imageViewer.ClientSize.Height / imageViewer.Image.Height);
                }
                return 1;
            }
        }

        private float XOffset
        {
            get
            {
                float xOffset = (float) (imageViewer.ClientRectangle.X + offsetX.Value * (decimal) Scale);
                if (imageViewer.Image != null)
                {
                    xOffset += (imageViewer.ClientSize.Width - imageViewer.Image.Width * Scale) / 2;
                }
                return xOffset;
            }
        }

        private float YOffset
        {
            get
            {
                float yOffset = (float) (imageViewer.ClientRectangle.Y + offsetY.Value * (decimal) Scale);
                if (imageViewer.Image != null)
                {
                    yOffset += (imageViewer.ClientSize.Height - imageViewer.Image.Height * Scale) / 2;
                }
                return yOffset;
            }
        }

        private float ScaledCellSize => (float) gridSize.Value * (Scale);
        private float CellSize => (float) gridSize.Value;
        private string imagePath;

        public MainWindow()
        {
            InitializeComponent();
            outputFormat.SelectedIndex = 0;
            DragEnter += Form1_DragEnter;
            gridX.ValueChanged += GridXOnValueChanged;
            gridY.ValueChanged += GridXOnValueChanged;
            offsetX.ValueChanged += GridXOnValueChanged;
            offsetY.ValueChanged += GridXOnValueChanged;
            gridSize.ValueChanged += GridXOnValueChanged;
            finalName.TextChanged += FinalNameOnTextChanged;
            outputFormat.SelectedIndexChanged += FinalNameOnTextChanged;
        }

        private void FinalNameOnTextChanged(object sender, EventArgs eventArgs)
        {
            if (finalName.Text.Length == 0)
                gifNamePreview.Text = "";
            else
            {
                gifNamePreview.Text = $"{finalName.Text}_1{outputFormat.SelectedItem}";
            }
        }

        private void GridXOnValueChanged(object sender, EventArgs eventArgs)
        {
            imageViewer.Refresh();
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            var image = files.First();
            try
            {
                imageViewer.Image = Image.FromFile(image);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Failed to open image");
            }
            imagePath = image;
            imageResolution.Text = $"{imageViewer.Image.Width} x {imageViewer.Image.Height}";
            imageType.Text = imagePath.Split('.').Last();
            offsetX.Maximum = imageViewer.Image.Width;
            offsetY.Maximum = imageViewer.Image.Height;
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            if (imagePath == null)
                return;

            Graphics g = e.Graphics;

            Pen p = new Pen(Color.Black);
            Pen p2 = new Pen(Color.White);
            p.DashStyle = DashStyle.Custom;
            p.DashPattern = new[] {3f, 3f};
            p2.DashStyle = DashStyle.Solid;

            for (var y = 0; y < NumOfCellsY + 1; ++y)
            {
                g.DrawLine(p2, XOffset, y * ScaledCellSize + YOffset, NumOfCellsX * ScaledCellSize + XOffset,
                    y * ScaledCellSize + YOffset);
                g.DrawLine(p, XOffset, y * ScaledCellSize + YOffset, NumOfCellsX * ScaledCellSize + XOffset,
                    y * ScaledCellSize + YOffset);
            }

            for (var x = 0; x < NumOfCellsX + 1; ++x)
            {
                g.DrawLine(p2, x * ScaledCellSize + XOffset, YOffset, x * ScaledCellSize + XOffset,
                    NumOfCellsY * ScaledCellSize + YOffset);
                g.DrawLine(p, x * ScaledCellSize + XOffset, YOffset, x * ScaledCellSize + XOffset,
                    NumOfCellsY * ScaledCellSize + YOffset);
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                return;
            }

            using (var dialog = new CommonOpenFileDialog())
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var location = dialog.FileName.Replace('\\', '/');
                    var creation = new Creation();
                    creation.Configure(finalName.Text, imagePath, outputFormat.SelectedItem.ToString(), CellSize, (float) offsetX.Value, (float)offsetY.Value, (int) gridX.Value, (int) gridY.Value, location);
                    creation.StartSplitting();
                    creation.ShowDialog();
                    OpenFolder(location);
                }
            }
        }

        private void OpenFolder(string location)
        {
            if (!checkBox1.Checked)
                return;
            Process.Start(location);
        }

        private bool IsInputValid()
        {
            if (finalName.Text.Length == 0)
            {
                MessageBox.Show("Gif name is empty");
                return false;
            }

            if (finalName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                MessageBox.Show("The filename is invalid");
                return false;
            }

            if (imageViewer.Image == null)
            {
                MessageBox.Show("Add an image first");
                return false;
            }

            if (!IsFfmpegFound())
            {
                MessageBox.Show("FFmpeg not found. Please make sure FFmpeg is in PATH.");
                return false;
            }

            return true;
        }

        private bool IsFfmpegFound()
        {
            return Common.RunCommand("ffmpeg -version").ExitCode == 0;
        }
    }
}