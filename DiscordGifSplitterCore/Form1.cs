using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DiscordGifSplitter
{
    public partial class MainWindow : Form
    {
        private const int MAX_EMOTES_BEFORE_SMALLER_SIZE = 27;
        private const int EMOTE_SMALL_PIXEL_SIZE = 22;
        private int NumOfCellsX => (int) gridX.Value;
        private int NumOfCellsY => (int) gridY.Value;
        private int TotalCells => NumOfCellsX * NumOfCellsY;
        private bool IsImagePresent => imageViewer.Image != null;
        private float CellsArea => TotalCells * CellSize * CellSize;
        private float ImageArea => imageViewer.Image.Height * imageViewer.Image.Width;
        private float CellToImageArea => CellsArea / ImageArea;

        private new float Scale
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

        private float ScaledImageWidth => imageViewer.Image.Size.Width * Scale;
        private float ScaledImageHeight => imageViewer.Image.Size.Height * Scale;
        private float ScaledImageX => (imageViewer.ClientSize.Width - imageViewer.Image.Width * Scale) / 2;
        private float ScaledImageY => (imageViewer.ClientSize.Height - imageViewer.Image.Height * Scale) / 2;
        private bool IsImageScalingInX => ScaledXOffset >= ScaledImageY;

        private float ScaledXOffset
        {
            get
            {
                float xOffset = (float) (imageViewer.ClientRectangle.X + offsetX.Value * (decimal) Scale);
                if (imageViewer.Image != null)
                {
                    xOffset += ScaledImageX;
                }
                return xOffset;
            }
        }

        private float ScaledYOffset
        {
            get
            {
                float yOffset = (float) (imageViewer.ClientRectangle.Y + offsetY.Value * (decimal) Scale);
                if (imageViewer.Image != null)
                {
                    yOffset += ScaledImageY;
                }
                return yOffset;
            }
        }

        private float ScaledCellSize => (float) gridSize.Value * (Scale);

        private float CellSize
        {
            get => (float) gridSize.Value;
            set => gridSize.Value = (decimal) value;
        }

        private string imagePath;
        private long imageFileSize;

        private long ImageFileSize
        {
            get => imageFileSize;
            set
            {
                imageFileSize = value;
                UpdateGifOutputSize();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            outputFormat.SelectedIndex = 0;
            DragEnter += Form1_DragEnter;
            gridX.ValueChanged += UpdateGrid;
            gridY.ValueChanged += UpdateGrid;
            offsetX.ValueChanged += UpdateGrid;
            offsetY.ValueChanged += UpdateGrid;
            gridSize.ValueChanged += UpdateGrid;
            imageOutputName.TextChanged += OnImageOutputNameChange;
            outputFormat.SelectedIndexChanged += OnImageOutputNameChange;
            showImageBorder.CheckedChanged += UpdateGrid;
        }

        private void OnImageOutputNameChange(object sender, EventArgs eventArgs)
        {
            if (imageOutputName.Text.Length == 0)
                gifNamePreview.Text = "";
            else
            {
                gifNamePreview.Text = $"{imageOutputName.Text}_1{outputFormat.SelectedItem}";
            }
        }

        private void UpdateGrid(object sender, EventArgs eventArgs)
        {
            imageViewer.Refresh();

            UpdateGifOutputSize();

            if (TotalCells >= MAX_EMOTES_BEFORE_SMALLER_SIZE && CellSize == 32f)
            {
                CellSize = EMOTE_SMALL_PIXEL_SIZE;
            }
        }

        private void UpdateGifOutputSize()
        {
            gifOutputSize.Text = IsImagePresent ? Common.BytesToString((long) (ImageFileSize * CellToImageArea / TotalCells)) : "";
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            var image = files.First();
            try
            {
                imageViewer.Image = Image.FromFile(image);
                ImageFileSize = new FileInfo(image).Length;
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
            imageViewer.BackgroundImage = null;
            gridSize.Maximum = Math.Max(imageViewer.Image.Width, imageViewer.Image.Height);
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            if (imagePath == null)
                return;

            Graphics g = e.Graphics;

            DrawGrid(g);
            DrawImageBorder(g);
        }

        private void DrawImageBorder(Graphics g)
        {
            if (!showImageBorder.Checked)
                return;

            Pen borderPen = new Pen(Color.Black);
            Pen yellowBorderPen = new Pen(Color.Yellow);
            borderPen.DashStyle = DashStyle.Custom;
            borderPen.DashPattern = new[] {10f, 10f};
            var scaledImageWidth = ScaledImageWidth - (IsImageScalingInX ? 0 : 1);
            var scaledImageHeight = ScaledImageHeight - (IsImageScalingInX ? 1 : 0);
            g.DrawRectangle(yellowBorderPen, ScaledImageX, ScaledImageY, scaledImageWidth, scaledImageHeight);
            g.DrawRectangle(borderPen, ScaledImageX, ScaledImageY, scaledImageWidth, scaledImageHeight);
        }

        private void DrawGrid(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black);
            Pen whitePen = new Pen(Color.White);
            blackPen.DashStyle = DashStyle.Custom;
            blackPen.DashPattern = new[] {3f, 3f};

            for (var y = 0; y < NumOfCellsY + 1; ++y)
            {
                g.DrawLine(whitePen, ScaledXOffset, y * ScaledCellSize + ScaledYOffset,
                    NumOfCellsX * ScaledCellSize + ScaledXOffset,
                    y * ScaledCellSize + ScaledYOffset);
                g.DrawLine(blackPen, ScaledXOffset, y * ScaledCellSize + ScaledYOffset,
                    NumOfCellsX * ScaledCellSize + ScaledXOffset,
                    y * ScaledCellSize + ScaledYOffset);
            }

            for (var x = 0; x < NumOfCellsX + 1; ++x)
            {
                g.DrawLine(whitePen, x * ScaledCellSize + ScaledXOffset, ScaledYOffset,
                    x * ScaledCellSize + ScaledXOffset,
                    NumOfCellsY * ScaledCellSize + ScaledYOffset);
                g.DrawLine(blackPen, x * ScaledCellSize + ScaledXOffset, ScaledYOffset,
                    x * ScaledCellSize + ScaledXOffset,
                    NumOfCellsY * ScaledCellSize + ScaledYOffset);
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                return;
            }
            /*
            using (var dialog = new CommonOpenFileDialog())
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var location = dialog.FileName.Replace('\\', '/');
                    var creation = new Creation();
                    creation.Configure(imageOutputName.Text, imagePath, outputFormat.SelectedItem.ToString(), CellSize,
                        (float) offsetX.Value, (float) offsetY.Value, (int) gridX.Value, (int) gridY.Value, location);
                    creation.StartSplitting();
                    creation.ShowDialog();
                    OpenFolder(location);
                }
            }*/
        }

        private void OpenFolder(string location)
        {
            if (!checkBox1.Checked)
                return;
            Process.Start(location);
        }

        private bool IsInputValid()
        {
            if (imageOutputName.Text.Length == 0)
            {
                MessageBox.Show("Gif name is empty");
                return false;
            }

            if (imageOutputName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
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