using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Draft
{
    public class DatabaseHandler
    {
        private static WarehouseDataEntities db;
        
        public static void NewElement(Items item)
        {
            var _alreadyExists = from records in db.Items where records.Name.Equals(item.Name) select records;

            if (_alreadyExists.Count() > 0) IncreaseQuantityForElement(_alreadyExists.First());
            else AddNewElement(item);

            Update();
        }

        public static void Init()
        {
            db = new WarehouseDataEntities();
        }

        private static void Update()
        {
            db.SaveChanges();
           // db.Items.SqlQuery();

        }

        private static void AddNewElement(Items item)
        {
            db.Items.Add(item);
        }

        private static void IncreaseQuantityForElement(Items item)
        {
            item.Quantity++;
        }

        public static void RemoveElement()
        {

        }

        public static WarehouseDataEntities DataBase { get { return db; } }
    }
}
