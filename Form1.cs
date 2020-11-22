using RadarTestTask.GraphObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadarTestTask
{
    public partial class Form : System.Windows.Forms.Form
    {
        private OpenFileDialog openFileDialog;
        private Renderer renderer;
        private string data;
        private PointF graphDragAndDropPrevPosition;
        private bool isDragAndDrop;
        public Form()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files ANSI encoding (*.txt)|*.txt";
            this.CreateGraphics();
            renderer = new Renderer(graphPictureBox);
            ResetCoordinates();
            SetZoom(10);
        }
        private void DisplayInfo(string text)
        {
            dataTextBox.Text = text;
        }
        private void SelectDataFile(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    data = GraphObjects.Encoder.ReadFile(openFileDialog.FileName);
                    DisplayInfo(data);
                    var graphObjects = GraphObjects.Encoder.Decode(data);
                    renderer.Clear();
                    renderer.AddGraphObjects(graphObjects);
                    renderer.Render();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void graphPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            graphToolStripCoordinates.Text = $"Координаты: {nameof(renderer.MousePosition.X)} {renderer.MousePosition.X.ToString("0.0000")} {nameof(renderer.MousePosition.Y)} {renderer.MousePosition.Y.ToString("0.0000")}";
            SelectGraphObject(sender, e);
            DragAndDrop(sender, e);
        }

        private void graphPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ResetCoordinates();
            DisplayInfo(data);
            isDragAndDrop = false;
        }

        private void ResetCoordinates()
        {
            graphToolStripCoordinates.Text = $"Координаты: {nameof(renderer.MousePosition.X)} 0 {nameof(renderer.MousePosition.Y)} 0";
        }

        private void graphZoomIn_Click(object sender, EventArgs e)
        {
            SetZoom(10);
        }

        private void graphZoomOut_Click(object sender, EventArgs e)
        {
            SetZoom(-10);
        }

        private void graphZoomAll_Click(object sender, EventArgs e)
        {
            renderer.ZoomOnAll();
            SetScaleText(renderer.Scale);
        }
        private void SetZoom(float delta)
        {
            renderer.Zoom(delta);
            SetScaleText(renderer.Scale);
        }
        private void SetScaleText(float value)
        {
            graphToolStripScale.Text = $"Масштаб: 1:{value}";
        }

        private void SelectGraphObject(object sender, MouseEventArgs e)
        {
            if (renderer.TryGetGraphObject(out var go))
            {
                DisplayInfo(GraphObject.GetGraphObjectInfo(go));
            }
            else
            {
                DisplayInfo(string.Empty);
            }
        }

        private void graphPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDragAndDrop = true;
            graphDragAndDropPrevPosition = e.Location;
        }

        private void graphPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragAndDrop = false;
        }

        private void DragAndDrop(object sender, MouseEventArgs e)
        {
            if (!isDragAndDrop)
                return;

            renderer.MoveImage(graphDragAndDropPrevPosition.Y - e.Y, graphDragAndDropPrevPosition.X - e.X);
            graphDragAndDropPrevPosition = e.Location;
        }
    }
}
