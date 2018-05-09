using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Core;

using System.Reflection;

namespace DataAccess
{
    public class BaseFunctions<T> where T : class, new()
    {
        private string GetTypeT()
        {
            return typeof(T).Name;
        }

        /// <summary>
        /// Hàm l?y danh sách các giá tr? các thu?c tính c?a m?t ??i t??ng
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private List<object> GetInsertUpdateValues(T item)
        {
            //Lây danh sách các thu?c tính c?a m?t ?t
            object[] props = item.GetType().GetProperties();

            //Danh sách giá tr? các thu?c tính
            List<object> objvalue = new List<object>();

            //Duy?t danh sách các thu?c tính
            foreach (PropertyInfo prop in props)
            {
                //L?y giá tr? c?a m?t thu?c tính và add và danh sách giá tr? các thu?c tính
                objvalue.Add(prop.GetValue(item, null));
            }

            return objvalue;
        }
        //Lấy mã cuối cùng để tạo mã mới
        public T GetLastID()
        {
            return CBO.FillObject<T>(DataProvider.Instance.ExecuteReader("GetLastID"+ this.GetTypeT()));
        }
        // Lấy giá được cập nhật mới nhất
        public T GetLast(object item,string name )
        {
            return CBO.FillObject<T>(DataProvider.Instance.ExecuteReader("GetLast" +name+ this.GetTypeT(),item));
        }
        public List<T> SelectAll()
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader("GetAll"+ this.GetTypeT()));
        }

        public List<T> SelectPage(object From, object To)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_SelectPage", From, To));
        }

        public int Add(T obj)
        {
            return DataProvider.Instance.ExecuteNonQuery("Add"+ this.GetTypeT(), this.GetInsertUpdateValues(obj).ToArray());
        }

        public int Update(T obj)
        {

            return DataProvider.Instance.ExecuteNonQuery("Update"+ this.GetTypeT(), this.GetInsertUpdateValues(obj).ToArray());
        }

        public int Delete(object ID)
        {

            return DataProvider.Instance.ExecuteNonQuery("Delete"+ this.GetTypeT(), ID);
        }

        public List<T> SelectBy(object item, string Name)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader( "GetBy" + Name + this.GetTypeT(), item));
        }

        public List<T> SelectByID(object ID)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader("GetByID"+ this.GetTypeT(), ID));
        }

        public List<T> FindKeyWord(object item)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader("FindKeyWord"+ this.GetTypeT(), item));
        }
        public List<T> SearchWord(object item,string Name)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader("SearchWord" + Name + this.GetTypeT(), item));
        }
        public DataTable SelectTables(string SPName, params object[] parameterValues)
        {
            return null;
        }
        public DataTable GetBy(string Name,object item)
        {
            return DataProvider.Instance.ExecuteDataset("Get" + Name + this.GetTypeT(), item).Tables[0];
        }
    }
}
