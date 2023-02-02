using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bebrik
{
    public partial class Formprogram : Form
    {
        Random random = new Random();
        public static Stopwatch Timer = new Stopwatch();

        public static int[] array;
        public Formprogram()
        {
            InitializeComponent();
        }

        private void buttoncreatearray_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown.Value);
            array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(0, 99);
            }
            Drawing(array, count);

        }

        private void Drawing(int[] array, int n)
        {
            try
            {
                GridMatrixView.RowCount = 1;
                GridMatrixView.Rows[0].Height = 45;
                GridMatrixView.ColumnCount = n;
                for (int i = 0; i < n; ++i)
                {
                    GridMatrixView.Rows[0].Cells[i].Value = array[i];
                }

                for (int k = 0; k < n; k++)
                {
                    GridMatrixView.Columns[k].Width = 45;
                }
            }
            catch { };
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            GnomeSort(array);
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            GridMatrixView.Rows[0].Cells[i].Value = array[j];
            array[j] = temp;
            GridMatrixView.Rows[0].Cells[j].Value = temp;
            wait();
        }
        private void GnomeSort(int[] array)
        {
            int i = 1;
            int j = 2;
            while (i < array.Length)
            {
                
                if (array[i - 1] < array[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    Swap(array, i - 1, i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            }
        }
        private void wait()
        {
            var t = Task.Run(async delegate{await Task.Delay(1000);});
            t.Wait();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GridMatrixView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
