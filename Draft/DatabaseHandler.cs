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
            // TODO make the program check if it should add new elemnt or increase quanitty in existing one
            string query = "INSERT INTO Items VALUES (" + item.Id +",'" +item.Name+"',"+item.Quantity+",'"+item.Filters+"')";
           
            db.Items.SqlQuery(query);
            db.Items.Add(item);
            Update();
            
            Console.WriteLine("ADDING NEW ELEMENT");
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

        private static void AddNewElement()
        {

        }

        private static void IncreaseQuantityForElement()
        {

        }

        public static void RemoveElement()
        {

        }

        public static WarehouseDataEntities DataBase { get { return db; } }
    }
}
