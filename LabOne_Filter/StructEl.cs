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
    public partial class StructEl : Form
    {
        public StructEl()
        {
            InitializeComponent();
            if(Form1.Can_Use_Struct_Elem)
            {
                int size = Form1.struct_kernel.GetLength(0);
                TABLE.Rows.Clear();
                TABLE.Columns.Clear();
                for (int i = 0; i < size; i++)
                {
                    TABLE.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                    TABLE.Rows.Add();
                    TABLE.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        TABLE.Rows[i].Cells[j].Value = Form1.struct_kernel[i, j];
                    }
                }
                OK.Enabled = true;
                SIZE.Text = size.ToString();
            }
        }

        private void TO_SIZE_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(SIZE.Text);
            }
            catch
            {
                MessageBox.Show("Невозможно задать некорретным значением размер матрицы\n Необходима целочисленная переменная", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(SIZE.Text) < 2 || Convert.ToInt32(SIZE.Text) >= 10) 
            {
                MessageBox.Show("Невозможный размер! \n Допустимые границы [2 ; 10]", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OK.Enabled = true;
            int size = Convert.ToInt32(SIZE.Text);
            TABLE.Rows.Clear();
            TABLE.Columns.Clear();
            for (int i = 0; i < size; i++) 
            {
                TABLE.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                TABLE.Rows.Add();
                TABLE.Rows[i].HeaderCell.Value = (i + 1).ToString();
                
            }
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    TABLE.Rows[i].Cells[j].Value = 0;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int size = TABLE.Columns.Count;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    try
                    {
                        Convert.ToDouble(TABLE.Rows[i].Cells[j].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно задать некорретным значением ячейки матрицы\nИспользуйте только числа типа Float (Double)\n\nНекорректное значение в ячейке [ " + i + " ] [ " + j + " ] ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Form1.Can_Use_Struct_Elem = false;
                        return;
                    }
                }
            }
            Form1.struct_kernel = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Form1.struct_kernel[i, j] = (float)Convert.ToDouble(TABLE.Rows[i].Cells[j].Value.ToString());
                }
            }
            MessageBox.Show("Матрица задана\nЗакрыть окно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1.Can_Use_Struct_Elem = true;
            Close();
        }
    }
}
