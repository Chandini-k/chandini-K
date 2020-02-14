using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HandsOnADO
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L2GAA57\SQLEXPRESS;Initial Catalog = PracticeDB; Persist Security Info=True;User ID = sa; Password=pass@word1");
        SqlCommand cmd = null;
        public void Add()
        {
            try
            {
                cmd = new SqlCommand("Insert into project values(@pid,@pname,@sdate,@edate)", con);
                //passing values to the parametres
                cmd.Parameters.AddWithValue("@pid", "P0006");
                cmd.Parameters.AddWithValue("@pname", "Suma");
                cmd.Parameters.AddWithValue("@sdate", DateTime.Parse("12.3.2019"));
                cmd.Parameters.AddWithValue("@edate", DateTime.Parse("10.2.2020"));
                con.Open();//open connection
                cmd.ExecuteNonQuery();//execute dml query
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection
            }
        }
        public void GetProjectById(string pid)
        {
            try
            {
                cmd = new SqlCommand("Select * from project where Pid=@pid", con);
                cmd.Parameters.AddWithValue("@pid", pid);
                con.Open();
                SqlDataReader dr=cmd.ExecuteReader();//execute select statement
                if(dr.HasRows)//check rows existence
                {
                    //Read records in datareader
                    dr.Read();//read only one record
                    Console.WriteLine("ID:{0} Name:{1} SDate:{2}", dr["pid"], dr["pname"], dr["sdate"], dr["edate"]);
                }
                else
                {
                    Console.WriteLine("Invalid Project ID");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetAllProjects()
        {
            try
            {
                cmd = new SqlCommand("Select * from project", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                      Console.WriteLine("ID:{0} Name:{1} SDate:{2}", dr["pid"], dr["pname"], dr["sdate"], dr["edate"]);
                    }
                }
                else
                {
                    Console.WriteLine("Table Empty");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.Add()
            //obj.GetProjectById("P009");
            obj.GetAllProjects();
            Console.ReadKey();
        }
    }
}
