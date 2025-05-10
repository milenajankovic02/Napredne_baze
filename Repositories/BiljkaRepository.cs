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
    public class BiljkaRepository
    {
        public static DataTable GetPlantsDataTable()
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = null;
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM Biljka";
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

        public static DataTable SearchPlants(string name, string type)
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

                    string cmdText = "SELECT * FROM Biljka WHERE 1=1";

                    // Dodavanje filtera za naziv biljke
                    if (!string.IsNullOrEmpty(name))
                    {
                        cmdText += " AND (Naziv LIKE @name)";
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    }

                    // Dodavanje filtera za vrstu biljke
                    if (!string.IsNullOrEmpty(type))
                    {
                        cmdText += " AND (Vrsta LIKE @type)";
                        cmd.Parameters.AddWithValue("@type", "%" + type + "%");
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

        public static bool InsertPlant(Biljka biljka)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Biljka (Naziv, Vrsta, DatumZalivanja, Opis) " +
                                      "VALUES (@Naziv, @Vrsta, @DatumZalivanja, @Opis)";

                    cmd.Parameters.AddWithValue("@Naziv", biljka.Naziv);
                    cmd.Parameters.AddWithValue("@Vrsta", biljka.Vrsta);
                    cmd.Parameters.AddWithValue("@DatumZalivanja", biljka.DatumZalivanja);
                    cmd.Parameters.AddWithValue("@Opis", biljka.Opis);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri umetanje biljke u bazu: " + ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static Biljka GetPlantByID(int biljkaID)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                Biljka result = null;
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Biljka WHERE BiljkaID = @BiljkaID";
                    cmd.Parameters.AddWithValue("@BiljkaID", biljkaID);

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = new Biljka();
                        result.BiljkaID = reader.GetInt32(reader.GetOrdinal("BiljkaID"));
                        result.Naziv = reader.GetString(reader.GetOrdinal("Naziv"));
                        result.Vrsta = reader.GetString(reader.GetOrdinal("Vrsta"));
                        result.DatumZalivanja = reader.GetDateTime(reader.GetOrdinal("DatumZalivanja"));
                        result.Opis = reader.GetString(reader.GetOrdinal("Opis"));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri citanju podataka o biljci: " + ex.Message);
                }
                finally
                {
                    if ((reader != null && !reader.IsClosed)) reader.Close();
                    if (connection != null) connection.Close();
                }

                return result;
            }
        }

        public static bool UpdatePlant(Biljka biljka)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Biljka SET Naziv = @Naziv, Vrsta = @Vrsta, " +
                                      "DatumZalivanja = @DatumZalivanja, Opis = @Opis " +
                                      "WHERE BiljkaID = @BiljkaID";

                    cmd.Parameters.AddWithValue("@Naziv", biljka.Naziv);
                    cmd.Parameters.AddWithValue("@Vrsta", biljka.Vrsta);
                    cmd.Parameters.AddWithValue("@DatumZalivanja", biljka.DatumZalivanja);
                    cmd.Parameters.AddWithValue("@Opis", biljka.Opis);
                    cmd.Parameters.AddWithValue("@BiljkaID", biljka.BiljkaID);

                    int affectedRows = cmd.ExecuteNonQuery(); //broj pogodjenih redova
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ažuriranju biljke u bazi: " + ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static bool DeletePlant(int biljkaID)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Biljka WHERE BiljkaID = @BiljkaID";
                    cmd.Parameters.AddWithValue("@BiljkaID", biljkaID);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju biljke iz baze: " + ex.Message);
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
