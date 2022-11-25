using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BigProject.Classes;

namespace BigProject
{
    public partial class Form1 : Form
    {
        private List<DataCacheStorage> A = new List<DataCacheStorage>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fdb = new OpenFileDialog())
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                  
                    string path = fdb.FileName;
                    DataCacheStorage data = new DataCacheStorage();
                    ReaderCSV.getInstance().reader(path, ref data);
                    A.Add(data);
                }
            }
            // List < List<object>> dataList = new List<List<object>>();
            // dataList = data.dataToList();
            // foreach (var colums in data.DataColumn) { dataGridView1.Columns.Add(colums.Key,colums.Key); }
            // foreach (var obj in dataList)
            // {
            //    dataGridView1.DataSource = obj;
            // }
            /* for (int i = 0; i< dataList.Count;i++)
             {
                 foreach (var obj in dataList[i]) {
                         dataGridView1.Rows.Add(obj);
                 }
             }*/
            // dataGridView1.Columns.Add(data.DataColumn[0], "Header column - 1");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.chart1.Series[0].Points.Clear();
                Axis xAxis = new Axis();
                xAxis.Title = A.ElementAt(0).ColumnsName[0];
                Axis yAxis = new Axis();
                yAxis.Title = A.ElementAt(0).ColumnsName[2];
                this.chart1.ChartAreas[0].AxisX = xAxis;
                this.chart1.ChartAreas[0].AxisY = yAxis;
                List<List<string>> dataList = new List<List<string>>();
                dataList = A.ElementAt(0).DataColumn;
                foreach (var elements in dataList)
                {
                    object x = elements[0];
                    object y = elements[2];
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = A.ElementAt(0).ColumnsName;
            foreach (var colums in A.ElementAt(0).ColumnsName)
            {
                dataGridView1.Columns.Add(colums, colums);
            }
            int i = 0;
            foreach (var colums in A.ElementAt(0).ColumnsName)
            {
                foreach(var obj in A.ElementAt(0).DataColumn[i])
                {
                    //dataGridView1.Rows[1].SetValues(obj);
                }
                i++;
            }
        }
        //[A.ElementAt(0).ColumnsName.IndexOf(colums)]
    }
}
