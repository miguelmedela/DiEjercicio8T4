using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiEjercicio8T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Form2 secundario;
        static bool flagOpen = false;
        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Seleccione una imagen";
                open.InitialDirectory = "C:\\";
                open.Filter = "Todos|*.*|Png| *.png|Jpg |*.jpg|JPEG |*.jpeg";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.Text = String.Format("Visor de imagenes-<{0}>", open.SafeFileName);
                    Bitmap image = new Bitmap(open.FileName);
                    if (!flagOpen)
                    {
                        secundario = new Form2();
                        flagOpen = true;

                    }
                    NewMethod(open);
                    ActualizarImagen(image);

                }
            }
        }
        public int i = 0;


        public void ActualizarImagen(Bitmap image)
        {
            if (flagOpen)
            {

            }
            secundario.Size = new Size(image.Width, image.Height);
            secundario.pictureBox1.Location = new Point(0, 0);
            secundario.pictureBox1.Size = secundario.Size;
            secundario.pictureBox1.Image = image;
            secundario.Show();

            lbImagen.Text = String.Format("Nombre: {0}\nTamaño: {1}\nResolucion: {2}x{3}",
               imagenes[i], "", image.HorizontalResolution, image.VerticalResolution);
            this.Text = String.Format("Visor de imagenes-<{0}>", imagenes[i]);
        }

        
        public void NewMethod(OpenFileDialog open)
        {
            imagenes = GetFiles(Path.GetDirectoryName(open.FileName));

            
            lbDirect.Text = Path.GetDirectoryName(open.FileName);

            //Hago esto para coger la posicion de la imagen dentro del directorio 
            foreach (var item in imagenes)
            {
                if (item == open.FileName)
                {
                    break;
                }
                i++;
            }

        }

        public string[] imagenes;
        public string[] GetFiles(string path)
        {
            string searchPattern = "*.jpg|*.png|*.jpeg";
            string[] searchPatterns = searchPattern.Split('|');

            List<string> files = new List<string>();
            foreach (string item in searchPatterns)
            {
                files.AddRange(Directory.GetFiles(path, item));
                files.Sort();
            }
            return files.ToArray();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("¿You want to exit?", "Visor de imagenes",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        Bitmap newImage;

        private void buttonRetroceso_Click(object sender, EventArgs e)
        {
            if (flagOpen)
            {
                i--;
                if (i < 0)
                {
                    i = imagenes.Length-1;
                }
                if (i >= 0)
                {
                    newImage = new Bitmap(imagenes[i]);
                    ActualizarImagen(newImage);
                }
            }
        }
        private void buttonAvance_Click(object sender, EventArgs e)
        {

            if (flagOpen)
            {
                i++;
                if (i == imagenes.Length)
                {
                    i = 0;
                }
                if (i < imagenes.Length)
                {
                    newImage = new Bitmap(imagenes[i]);
                    ActualizarImagen(newImage);
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                buttonRetroceso.PerformClick();
            }
            if (e.KeyCode == Keys.D)
            {
                buttonAvance.PerformClick();
            }
        }
    }
}
