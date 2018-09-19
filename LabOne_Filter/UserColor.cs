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
    public partial class UserColor : Form
    {
        public int[] array;
        public UserColor(ref int []_color)
        {
            InitializeComponent();
            array = new int[_color.Length];
        }

        private void OK_Click(object sender, EventArgs e)
        {
            R.Text = Convert.ToInt32(R.Text).ToString();
            G.Text = Convert.ToInt32(G.Text).ToString();
            B.Text = Convert.ToInt32(B.Text).ToString();
            if (Convert.ToInt32(R.Text)<0 || Convert.ToInt32(R.Text)>255)
            {
                MessageBox.Show("Цвет должен быть в диапазоне:\n [ 0 ; 255 ]", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(G.Text) < 0 || Convert.ToInt32(G.Text) > 255)
            {
                MessageBox.Show("Цвет должен быть в диапазоне:\n [ 0 ; 255 ]", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(B.Text) < 0 || Convert.ToInt32(B.Text) > 255)
            {
                MessageBox.Show("Цвет должен быть в диапазоне:\n [ 0 ; 255 ]", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form1.color[0] = array[0] = Convert.ToInt32(R.Text);
            Form1.color[1] = array[1] = Convert.ToInt32(G.Text);
            Form1.color[2] = array[2] = Convert.ToInt32(B.Text);
            Form1.color[3] = array[3] = 1;
            
            Close();
        }
    }
}
