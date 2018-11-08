using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionLab.Source.Model
{
    public static class DatabaseManagement
    {

        public static SqlConnection GetConnection()
        {
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nebojsa\Documents\Visual Studio 2017\Projects\NutritionLab\NutritionLab\NLDatabase.mdf;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(conn);

            return sqlconn;
        }

        public static void DodajNamirnicu(Namirnica n)
        {
            string insert = "INSERT INTO Namirnice (Id, Naziv, Grupa, UgljeniHidrati, Masti, Proteini, Kalorije) VALUES (@id, @naziv, @grupa, @ugljeni, @masti, @proteini, @kal)";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@id", n.Id);
            cmd.Parameters.AddWithValue("@naziv", n.Naziv);
            cmd.Parameters.AddWithValue("@grupa", n.Grupa);
            cmd.Parameters.AddWithValue("@ugljeni", n.UgljeniHidrati);
            cmd.Parameters.AddWithValue("@masti", n.Masti);
            cmd.Parameters.AddWithValue("@proteini", n.Proteini);
            cmd.Parameters.AddWithValue("@kal", n.Kalorije);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void ObrisiNamirnicu(int id)
        {
            string delete = "DELETE FROM Namirnice WHERE Id = @id";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static LinkedList<Namirnica> DohvatiSveNamirnice(string naziv = "", string grupa = "")
        {
            LinkedList<Namirnica> l = new LinkedList<Namirnica>();
            string select;

            if (naziv == "")
            {
                select = "SELECT * FROM Namirnice";
                if (grupa != "Sve grupe") select += " WHERE Grupa = @grupa";
            }
            else
            {
                select = "SELECT * FROM Namirnice WHERE Naziv LIKE @naziv";
                if (grupa != "Sve grupe") select += " AND Grupa = @grupa";
            }
            
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(select, conn);
            cmd.Parameters.AddWithValue("@naziv", "%" + naziv + "%");
            cmd.Parameters.AddWithValue("@grupa", grupa);
            try
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = int.Parse(reader["Id"].ToString());
                        string Naziv = reader["Naziv"].ToString();
                        string Grupa = reader["Grupa"].ToString();
                        double UgljeniHidrati = double.Parse(reader["UgljeniHidrati"].ToString());
                        double Masti = double.Parse(reader["Masti"].ToString());
                        double Proteini = double.Parse(reader["Proteini"].ToString());
                        double Kalorije = double.Parse(reader["Kalorije"].ToString());

                        l.AddLast(new Namirnica(Id)
                        {
                            Naziv = Naziv,
                            Grupa = Grupa,
                            UgljeniHidrati = UgljeniHidrati,
                            Masti = Masti,
                            Proteini = Proteini,
                            Kalorije = Kalorije
                        });
                    }
                }

                return l;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static int DohvatiMaxIdNamirnice()
        {
            int res;
            string select = "SELECT COALESCE(MAX(Id),0) FROM Namirnice";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(select, conn);
            try
            {
                conn.Open();
                res = int.Parse(cmd.ExecuteScalar().ToString());
                return res;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
