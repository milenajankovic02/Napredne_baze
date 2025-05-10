using Projekat.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projekat.Repositories
{
    public static class BiljkaHerbRepository
    {
        public static DataTable SearchBiljkeHerbarijum(string plantName, string herbariumName)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = null;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    string cmdText = @"
                        SELECT 
                            bh.BiljkaHerbarijumID,
                            b.Naziv AS BiljkaNaziv,
                            h.Naziv AS HerbarijumNaziv
                        FROM 
                            BiljkaHerbarijum bh
                        JOIN 
                            Biljka b ON bh.BiljkaID = b.BiljkaID
                        JOIN 
                            Herbarijum h ON bh.HerbarijumID = h.HerbarijumID
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(plantName))
                    {
                        cmdText += " AND b.Naziv LIKE @plantName";
                        cmd.Parameters.AddWithValue("@plantName", "%" + plantName + "%");
                    }

                    if (!string.IsNullOrEmpty(herbariumName))
                    {
                        cmdText += " AND h.Naziv LIKE @herbariumName";
                        cmd.Parameters.AddWithValue("@herbariumName", "%" + herbariumName + "%");
                    }

                    cmd.CommandText = cmdText;

                    reader = cmd.ExecuteReader();
                    result = new DataTable();
                    result.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri pretrazi podataka iz BiljkaHerbarijum tabele: " + ex.Message);
                }
                finally
                {
                    if (reader != null && !reader.IsClosed) reader.Close();
                    if (connection != null) connection.Close();
                }

                return result;
            }
        }

        public static bool AddPlantToHerbarium(int biljkaID, int herbarijumID, DateTime datumSmjestanja)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO BiljkaHerbarijum (BiljkaID, HerbarijumID, DatumSmještanja) VALUES (@BiljkaID, @HerbarijumID, @DatumSmještanja)";
                    cmd.Parameters.AddWithValue("@BiljkaID", biljkaID);
                    cmd.Parameters.AddWithValue("@HerbarijumID", herbarijumID);
                    cmd.Parameters.AddWithValue("@DatumSmještanja", datumSmjestanja);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri dodavanju biljke u herbarijum: " + ex.Message);
                }
                finally
                {
                    if (connection != null) connection.Close();
                }
                return result;
            }
        }

        public static bool UpdatePlantInHerbarium(int biljkaHerbarijumID, int biljkaID, int herbarijumID, DateTime datumSmjestanja)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE BiljkaHerbarijum SET BiljkaID = @BiljkaID, HerbarijumID = @HerbarijumID, DatumSmještanja = @DatumSmještanja WHERE BiljkaHerbarijumID = @BiljkaHerbarijumID";
                    cmd.Parameters.AddWithValue("@BiljkaID", biljkaID);
                    cmd.Parameters.AddWithValue("@HerbarijumID", herbarijumID);
                    cmd.Parameters.AddWithValue("@DatumSmještanja", datumSmjestanja);
                    cmd.Parameters.AddWithValue("@BiljkaHerbarijumID", biljkaHerbarijumID);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ažuriranju biljke u herbarijumu: " + ex.Message);
                }
                finally
                {
                    if (connection != null) connection.Close();
                }
                return result;
            }
        }


        public static bool DeletePlantHerb(int biljkaHerbarijumID)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM BiljkaHerbarijum WHERE BiljkaHerbarijumID = @BiljkaHerbarijumID";
                    cmd.Parameters.AddWithValue("@BiljkaHerbarijumID", biljkaHerbarijumID);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju biljke iz herbarijuma: " + ex.Message);
                }
                finally
                {
                    if (connection != null) connection.Close();
                }
                return result;
            }
        }

        public static BiljkaHerbarijum GetBiljkaHerbarijumByID(int biljkaHerbarijumID)
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                BiljkaHerbarijum result = null;
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM BiljkaHerbarijum WHERE BiljkaHerbarijumID = @BiljkaHerbarijumID";
                    cmd.Parameters.AddWithValue("@BiljkaHerbarijumID", biljkaHerbarijumID);

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = new BiljkaHerbarijum
                        {
                            BiljkaHerbarijumID = reader.GetInt32(reader.GetOrdinal("BiljkaHerbarijumID")),
                            BiljkaID = reader.GetInt32(reader.GetOrdinal("BiljkaID")),
                            HerbarijumID = reader.GetInt32(reader.GetOrdinal("HerbarijumID")),
                            DatumSmještanja = reader.GetDateTime(reader.GetOrdinal("DatumSmještanja"))
                        };
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri dobavljanju biljke iz herbarijuma: " + ex.Message);
                }
                finally
                {
                    if (connection != null) connection.Close();
                }
                return result;
            }
        }

        public static DataTable GetBiljkeHerbarijumDataTable()
        {
            using (SqlConnection connection = new SqlConnection("Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = null;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = @"
                        SELECT 
                            bh.BiljkaHerbarijumID,
                            b.Naziv AS BiljkaNaziv,
                            h.Naziv AS HerbarijumNaziv,
                            bh.DatumSmještanja
                        FROM 
                            BiljkaHerbarijum bh
                        JOIN 
                            Biljka b ON bh.BiljkaID = b.BiljkaID
                        JOIN 
                            Herbarijum h ON bh.HerbarijumID = h.HerbarijumID";

                    reader = cmd.ExecuteReader();
                    result = new DataTable();
                    result.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri dobavljanju podataka iz BiljkaHerbarijum tabele: " + ex.Message);
                }
                finally
                {
                    if (connection != null) connection.Close();
                }
                return result;
            }
        }
    }
}
