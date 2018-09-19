using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabOne_Filter
{
    public partial class Form1 : Form
    {
        Bitmap image;
        Stack<Bitmap> IMAGES = new Stack<Bitmap>();
        int count_pict_save = 0;
        int count_pict = 0;
        static public int[] color = new int[4];
        static public float[,] struct_kernel;
        static public bool Can_Use_Struct_Elem = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *bmp | All files (*.*) | *.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
                count_pict = 0;
                if (IMAGES.Count>0) IMAGES.Clear();
                IMAGES.Push(image);
            }

        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap NewImage = ((Filter)e.Argument).ProcessImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = NewImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button1.Enabled = false;
            if(!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
            SAVE.Enabled = true;
            BACK.Enabled = true;
            IMAGES.Push(image);
            count_pict++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            button1.Enabled = false;
        }

        private void размытиеBlurFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеGaussianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void чернобелыйGrayScaleFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new SepiaFilter(55);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void яркостьBrightFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new BrightFilter(35);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new SharpFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new StampingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Сохранить картинку ...";
            dialog.Filter = "Изображение (*.jpeg*)|*.jpeg*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;
            dialog.OverwritePrompt = true;
            dialog.ShowHelp = true;
            dialog.AddExtension = true;
            string filename = "pic_" + count_pict_save;
            count_pict_save++;
            dialog.FileName = filename;
            Image img = pictureBox1.Image;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img.Save(dialog.FileName+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else return;
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            if (count_pict > 0)
            {
                IMAGES.Pop();
                --count_pict;
                pictureBox1.Image = IMAGES.Peek();
                image = IMAGES.Peek();
                pictureBox1.Refresh();
            }
            else MessageBox.Show("Нельзя сделать шаг назад. История пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void шагНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BACK_Click(sender, e);
        }

        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            RollFilter filter = new RollFilter(20);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void переносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            TransferFilter filter = new TransferFilter(200, 0);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void щарраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new SharrFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void прюиттToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new PrewitteFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеДвиженияMotionBlurFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new MotionBlurFilter(10);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void эффектСтеклаWindowFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new WindowFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }



        private void серыйМирToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new GrayWorld();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void линейнаяКоррекцияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new LinearSize();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void идеальныйОтражательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new IdealReflect();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void коррекцияСОпорнымЦветомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color[0] = color[1] = color[2] = color[3] = 0;
            UserColor form = new UserColor(ref color);
            form.ShowDialog();
            while (color[3] != 1) { };
            button1.Enabled = true;
            Filter filter = new SupportColor(color[0], color[1], color[2]);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйФильтрMedianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new MedianFilter(7);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void dialationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Can_Use_Struct_Elem)
            {
                MessageBox.Show("Необходимо сначала задать структурный элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1.Enabled = true;
            Filter filter = new DilationFilter(struct_kernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void собеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void структурныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StructEl form = new StructEl();
            form.ShowDialog();
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Can_Use_Struct_Elem)
            {
                MessageBox.Show("Необходимо сначала задать структурный элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1.Enabled = true;
            Filter filter = new ErosionFilter(struct_kernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Can_Use_Struct_Elem)
            {
                MessageBox.Show("Необходимо сначала задать структурный элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1.Enabled = true;
            Filter filter = new OpeningFilter(struct_kernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Can_Use_Struct_Elem)
            {
                MessageBox.Show("Необходимо сначала задать структурный элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1.Enabled = true;
            Filter filter = new ClosingFilter(struct_kernel);
             backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Can_Use_Struct_Elem)
            {
                MessageBox.Show("Необходимо сначала задать структурный элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1.Enabled = true;
            Filter filter = new GradFilter(struct_kernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Can_Use_Struct_Elem)
            {
                MessageBox.Show("Необходимо сначала задать структурный элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1.Enabled = true;
            Filter filter = new TopHat(struct_kernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Can_Use_Struct_Elem)
            {
                MessageBox.Show("Необходимо сначала задать структурный элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1.Enabled = true;
            Filter filter = new BlackHat(struct_kernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void собельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void шумСиПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Filter filter = new SaltPepperFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void статистическаяКоррекцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap simage;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *bmp | All files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
                simage = new Bitmap(dialog.FileName);
            else
                simage = image;

            button1.Enabled = true;
            Filter filter = new StatCorFilter(simage);
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
