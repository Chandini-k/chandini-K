using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assign
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L2GAA57\SQLEXPRESS;Initial Catalog=Product;Persist Security Info=True;User ID=sa;Password=pass@word1");
        SqlCommand cmd = null;
        public void Add(int id, string name, int price, int stock)
        {
            try
            {
                cmd = new SqlCommand("Insert into Product values(@pid,@name,@price,@stock)", con);
                cmd.Parameters.AddWithValue("@pid", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void GetProjectById(int id)
        {
            try
            {
                cmd = new SqlCommand("select * from product where id=@pid", con);
                cmd.Parameters.AddWithValue("@pid", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    Console.WriteLine("ID:{0} Name:{1} Price:{2} Stock:{3}", dr["pid"], dr["name"], dr["price"], dr["stock"]);
                }

                else
                {
                    Console.WriteLine("invalid project id");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void GetAllProjects()
        {
            try
            {
                cmd = new SqlCommand("select * from product", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name:{1} Price:{2} Stock:{3}", dr["pid"], dr["name"], dr["price"], dr["stock"]);
                    }
                }
                else
                {
                    Console.WriteLine("table is empty");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(int pid)
        {
            try
            {
                cmd = new SqlCommand("delete from Product where pid=@pid");
                cmd.Parameters.AddWithValue("@pid", pid);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Update(int pid,int price,int stock)
        {
            try
            {
                cmd = new SqlCommand("update Product set price=@price,stock=@stock where pid=@pid",con);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@pid", pid);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)

        {
            Program p = new Program();
            //p.Add(3,"suma",1000,100);
            // p.Add(2, "chandu", 10000, 90);
            //p.GetProjectById(2);
            //p.GetAllProjects();
            p.Update(3, 1111, 101);
            Console.ReadKey();
        }
    }
}