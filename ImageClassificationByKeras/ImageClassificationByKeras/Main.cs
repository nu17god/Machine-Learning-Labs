using OpenCvSharp;
using OpenCvSharp.Dnn;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageClassificationByKeras
{
    public partial class Main : Form
    {
        Net NeuralNetwork = CvDnn.ReadNetFromTensorflow(@"Final_model.pb");

        public Main()
        {
            InitializeComponent();
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            if (ctlOpenDialog.ShowDialog() == DialogResult.OK)
            {
                ctlPicture.Image = new Bitmap(ctlOpenDialog.FileName);

                Mat m = new Mat(ctlOpenDialog.FileName);

                Mat blob = CvDnn.BlobFromImage(m, 1, new OpenCvSharp.Size(96, 96), new Scalar(0, 0, 0), false, false);

                NeuralNetwork.SetInput(blob);

                Mat result = NeuralNetwork.Forward();

                OpenCvSharp.Point p1, p2;
                Cv2.MinMaxLoc(result, out p1, out p2);
                MessageBox.Show("На рисунке представен класс: " + ((Labels)p2.X).ToString());
            }
        }
    }
}
