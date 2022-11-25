using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Classes
{
    public class DataCacheStorage
    {
        private string fileLcation;
        private List<string> columnsName;
        private List<List<string>> dataColumn;
        // private Dictionary<string, List<object>> dataColumn = new Dictionary<string, List<object>>();
        //private List<string> nameOfColumn = new List<string>();

        public string FileLcation { get { return fileLcation; } set { fileLcation = value; } }
        public List<string> ColumnsName { get { return columnsName; } set { columnsName = value; } }

        public List<List<string>> DataColumn { get { return dataColumn; } set { dataColumn = value; } }
        public DataCacheStorage()
        {
            this.fileLcation = null;
            columnsName = new List<string>();
            dataColumn = new List<List<string>>();
        }

        // public void AddColumn(List<object> newColumn, string nameOfColumn)
        //{
        //   dataColumn.Add(nameOfColumn, newColumn);
        // }

        /*public void AddLine(int placeY, object[] data)
        {
            for (int i = 0; i < dataColumn.Count; i++)
            {
                AddElement(i, placeY, data[i]);
            }
        }*/

        /*public void AddElement(int placeX, int placeY, object data)
        {
            dataColumn[placeX].Add(null);
            for (int i = dataColumn[placeX].Count - 1; i > placeY; i--)
            {
                dataColumn[placeX][i] = dataColumn[placeX][i - 1];
            }
            dataColumn[placeX][placeY] = data;
        }*/

        public void ChangeElement(string nameinColumn, int number, object data)
        {
            //  dataColumn[nameinColumn][number] = data;    //На вид хуета какая-то
        }


        public void RenameColumn(int columnInsex, string newNameOfColumn)
        {
            columnsName[--columnInsex] = newNameOfColumn;
        }

        //   public Dictionary<string, List<Object>> DataColumn
        //  {
        //     get => dataColumn;
        //     set => dataColumn = value;
    }
}
