using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class SqlRepository : IRepository
    {

        public void Add(IProduct product, double fare)
        {

            FileRepository.Instance.Add("Here in SqlRepository" + "Add function is called" + "To add product in SQL DataBase");

            Console.WriteLine("IN ADDD DATATBASE");
            IProduct prod = null;

            SqlConnection connectionobject = new SqlConnection();
            connectionobject.ConnectionString = "Data Source=TAVDESK004;Initial Catalog=ProductDatabase;User ID=sa;Password=test123!@#";
            //connectionobject.ConnectionString = "Data Source=TAVDESK004;Initial Catalog=Product;Integrated Security=True";
            connectionobject.Open();
            FileRepository.Instance.Add("Connection opened ");

          string typeProduct = product.GetTypeOf();
            FileRepository.Instance.Add("Insert function is called");
            string query = "insert into " + typeProduct + " values(@name,@id,@fare,@isbooked)";
            SqlCommand cmd = new SqlCommand(query, connectionobject);
            cmd.Parameters.Add(new SqlParameter("@name", product.itemName));

            cmd.Parameters.Add(new SqlParameter("@fare", fare));

            cmd.Parameters.Add(new SqlParameter("@isbooked", product.isBooked));
            cmd.Parameters.Add(new SqlParameter("@id", product.itemId));

            cmd.ExecuteNonQuery();
            connectionobject.Close();
        }
    }

}

