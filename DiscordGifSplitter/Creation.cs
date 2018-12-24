using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordGifSplitter
{
    public partial class Creation : Form
    {
        private string gifName;
        private string imagePath;
        private string outputType;
        private float cellSize;
        private float xOffset;
        private float yOffset;
        private int gridY;
        private int gridX;
        private string finalPath;
        private Task splittingTask;

        public Creation()
        {
            InitializeComponent();
        }

        public void Configure(string gifName, string imagePath, string outputType, float cellSize, float xOffset,
            float yOffset, int gridX, int gridY, string finalPath)
        {
            this.finalPath = finalPath;
            this.gridX = gridX;
            this.gridY = gridY;
            this.yOffset = yOffset;
            this.xOffset = xOffset;
            this.cellSize = cellSize;
            this.gifName = gifName;
            this.imagePath = imagePath;
            this.outputType = outputType;

            creatingLabel.Text = $"Creating {gridX * gridY} images...";
        }

        public void StartSplitting()
        {
            backgroundWorker1.RunWorkerAsync();
            TopMost = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            float totalGifs = gridX * gridY;
            string finalCommand = "";
            string name = gifName;
            var count = 0;
            for (int i = 0; i < gridY; i++)
            {
                for (int j = 0; j < gridX; j++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    count += 1;
                    worker.ReportProgress((int) (count / totalGifs * 100));
                    var ffmpeg =
                        $"ffmpeg -y -i \"{imagePath}\" -filter:v \"crop={cellSize}:{cellSize}:{cellSize * j + (double) xOffset}:{cellSize * i + (double) yOffset}\" \"{finalPath}/{name}_{count}{outputType}\"";
                    Console.WriteLine(ffmpeg);
                    Common.RunCommand(ffmpeg);
                    finalCommand += $":{name}_{count}:";
                }
                finalCommand += "\n";
            }
            string textPath = $"{finalPath}/_copy_from_here-{name}.txt";
            if (!File.Exists(textPath))
            {
                using (StreamWriter sw = File.CreateText(textPath))
                {
                    sw.Write(finalCommand);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Creation_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}