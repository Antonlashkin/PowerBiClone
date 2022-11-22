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
            DataCacheStorage data = new DataCacheStorage("Name");
            ReaderCSV R = new ReaderCSV();
            R.reader("E:ForExample.csv", data);
            A.Add(data);
            foreach (var colums in data.DataColumn) { dataGridView1.DataSource = colums; }
            dataGridView1.DataSource = data.DataColumn["1"];
            // dataGridView1.Columns.Add(data.DataColumn[0], "Header column - 1");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }

}
