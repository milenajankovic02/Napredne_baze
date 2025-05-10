using Projekat.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat.Repositories
{
    public class HerbarijumRepository
    {
        public static DataTable GetHerbariumsDataTable()
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = null;
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM Herbarijum";
                    cmd.Connection = connection;

                    reader = cmd.ExecuteReader();
                    result = new DataTable();
                    result.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri konekciji sa bazom!");
                }
                finally
                {
                    if ((reader != null && !reader.IsClosed)) reader.Close();
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static DataTable SearchHerbariums(string name, string description)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = null;
                try
                {
                    connection.Open();

                    // Osnovna komanda sa WHERE klauzulom koja se može proširiti
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    string cmdText = "SELECT * FROM Herbarijum WHERE 1=1";

                    // Dodavanje filtera za naziv herbarijuma
                    if (!string.IsNullOrEmpty(name))
                    {
                        cmdText += " AND (Naziv LIKE @name)";
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    }

                    // Dodavanje filtera za opis herbarijuma
                    if (!string.IsNullOrEmpty(description))
                    {
                        cmdText += " AND (Opis LIKE @description)";
                        cmd.Parameters.AddWithValue("@description", "%" + description + "%");
                    }

                    cmd.CommandText = cmdText;

                    reader = cmd.ExecuteReader();
                    result = new DataTable();
                    result.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri konekciji sa bazom! " + ex.Message);
                }
                finally
                {
                    if (reader != null && !reader.IsClosed) reader.Close();
                    if (connection != null) connection.Close();
                }

                return result;
            }
        }

        public static bool InsertHerbarium(Herbarijum herbarijum)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Herbarijum (Naziv, Opis, DatumOsnivanja) " +
                                      "VALUES (@Naziv, @Opis, @DatumOsnivanja)";

                    cmd.Parameters.AddWithValue("@Naziv", herbarijum.Naziv);
                    cmd.Parameters.AddWithValue("@Opis", herbarijum.Opis);
                    cmd.Parameters.AddWithValue("@DatumOsnivanja", herbarijum.DatumOsnivanja);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri umetanje herbarijuma u bazu: " + ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static Herbarijum GetHerbariumByID(int herbarijumID)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                Herbarijum result = null;
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Herbarijum WHERE HerbarijumID = @HerbarijumID";
                    cmd.Parameters.AddWithValue("@HerbarijumID", herbarijumID);

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = new Herbarijum();
                        result.HerbarijumID = reader.GetInt32(reader.GetOrdinal("HerbarijumID"));
                        result.Naziv = reader.GetString(reader.GetOrdinal("Naziv"));
                        result.Opis = reader.GetString(reader.GetOrdinal("Opis"));
                        result.DatumOsnivanja = reader.GetDateTime(reader.GetOrdinal("DatumOsnivanja"));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri citanju podataka o herbarijumu: " + ex.Message);
                }
                finally
                {
                    if ((reader != null && !reader.IsClosed)) reader.Close();
                    if (connection != null) connection.Close();
                }

                return result;
            }
        }

        public static bool UpdateHerbarium(Herbarijum herbarijum)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Herbarijum SET Naziv = @Naziv, Opis = @Opis, " +
                                      "DatumOsnivanja = @DatumOsnivanja " +
                                      "WHERE HerbarijumID = @HerbarijumID";

                    cmd.Parameters.AddWithValue("@Naziv", herbarijum.Naziv);
                    cmd.Parameters.AddWithValue("@Opis", herbarijum.Opis);
                    cmd.Parameters.AddWithValue("@DatumOsnivanja", herbarijum.DatumOsnivanja);
                    cmd.Parameters.AddWithValue("@HerbarijumID", herbarijum.HerbarijumID);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ažuriranju herbarijuma u bazi: " + ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static bool DeleteHerbarium(int herbarijumID)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Herbarijum WHERE HerbarijumID = @HerbarijumID";
                    cmd.Parameters.AddWithValue("@HerbarijumID", herbarijumID);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju herbarijuma iz baze: " + ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }
    }
}
