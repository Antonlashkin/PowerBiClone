using Presenters.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IServices;
using DataServices;
using IDataSourcePerositories;

namespace Presenters.Views
{
    public partial class InitView : Form, IView
    {
        private InitPresenter presenter;
        public InitView()
        {
            presenter = new InitPresenter(this);
            InitializeComponent();
            loadFile.Enabled = false;
            ToTableVizualization.Enabled = false;
        }

        public IDataSourceRep Data { get => presenter.Service.GetData(); }

        private void InitView_Load(object sender, EventArgs e)
        {

        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            presenter.Service.reader(textBox1.Text);
            ToTableVizualization.Enabled = true;
        }

        private void select_Click(object sender, EventArgs e)
        {
            textBox1.Text = presenter.SelectFile().ToString();
            loadFile.Enabled = true;
        }

        private void toTableVizualization_Click(object sender, EventArgs e)
        {
            TableVizualiztionView tvzv = new TableVizualiztionView(this);
            this.Hide();
            tvzv.ShowDialog();

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
