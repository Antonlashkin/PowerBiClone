using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Classes
{
    internal class DataCacheStorage
    {
        private string nameOfData;
        private Dictionary<string, List<object>> dataColumn = new Dictionary<string, List<object>>();
        //private List<string> nameOfColumn = new List<string>();

        public DataCacheStorage(string nameOfDate)
        {
            RenameData(nameOfDate);
        }

        public DataCacheStorage(string nameOfDate, Dictionary<string, List<object>> data)
        {
            RenameData(nameOfDate);
            this.dataColumn = data;
        }

        public void AddColumn(List<object> newColumn, string nameOfColumn)
        {
            dataColumn.Add(nameOfColumn, newColumn);
        }

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
            dataColumn[nameinColumn][number] = data;    //На вид хуета какая-то
        }

        public void RenameData(string nameOfData)
        {
            this.nameOfData = nameOfData;
        }

        public void RenameColumn(string nameOfColumn, string newNameOfColumn)
        {
            List<object> data = new List<object>();
            data = this.dataColumn[nameOfColumn];
            this.dataColumn.Remove(nameOfColumn);
            this.dataColumn.Add(newNameOfColumn, data);
        }

        public Dictionary<string, List<Object>> DataColumn
        {
            get => dataColumn;
            set => dataColumn = value;
        }

    }
}
