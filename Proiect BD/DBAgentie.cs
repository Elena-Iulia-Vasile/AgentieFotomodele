using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD
{
    public class DBAgentie
    {
        public static SqlConnection GetConnection()
        {
            string sql = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
            SqlConnection conn = new SqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(" SQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void AddFotomodel(Fotomodel model)
        {
            int caracteristiciID = 0;
            SqlConnection conn = GetConnection();
            //Inserarea valorilor noii inregistrari in tabele Caracteristici
            string sql = "INSERT INTO Caracteristici VALUES (@Inaltime, @Bust, @Talie, @Solduri, @Pantof, @MarimeHaine, @CuloarePar, @CuloareOchi)";
           
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Inaltime", SqlDbType.Int).Value = model.Inaltime;
            cmd.Parameters.Add("@Bust", SqlDbType.Int).Value = model.Bust;
            cmd.Parameters.Add("@Talie", SqlDbType.Int).Value = model.Talie;
            cmd.Parameters.Add("@Solduri", SqlDbType.Int).Value = model.Solduri;
            cmd.Parameters.Add("@Pantof", SqlDbType.Int).Value = model.Pantof;
            cmd.Parameters.Add("@MarimeHaine", SqlDbType.VarChar).Value = model.MarimeHaine;
            cmd.Parameters.Add("@CuloarePar", SqlDbType.VarChar).Value = model.CuloarePar;
            cmd.Parameters.Add("@CuloareOchi", SqlDbType.VarChar).Value = model.CuloareOchi;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added succesfully cacarcteristici.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Model characteristics not insert! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            //Comanda pentru a afla ultimul ID din tabela Caracteristici
            SqlCommand cmdId = new SqlCommand("SELECT Id FROM Caracteristici WHERE Id = (SELECT MAX(id) FROM Caracteristici)", conn);
            
            cmdId.CommandType = System.Data.CommandType.Text;
            try
            {
                caracteristiciID = (int)cmdId.ExecuteScalar();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Id not found! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Inserarea unei noi inregistrari in tabela Model
            string sql2 = "INSERT INTO Model VALUES (@caracteristiciID, @Nume, @DataNasterii, @Sex, @NumarTelefon, @Mail, null)";

            SqlCommand cmd2 = new SqlCommand(sql2, conn);

            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.Parameters.Add("@caracteristiciID", SqlDbType.Int).Value = caracteristiciID;
            cmd2.Parameters.Add("@Nume", SqlDbType.VarChar).Value = model.Nume;
            cmd2.Parameters.Add("@DataNasterii", SqlDbType.Date).Value = model.DataNasterii;
            cmd2.Parameters.Add("@Sex", SqlDbType.VarChar).Value = model.Sex;
            cmd2.Parameters.Add("@NumarTelefon", SqlDbType.VarChar).Value = model.NumarTelefon;
            cmd2.Parameters.Add("@Mail", SqlDbType.VarChar).Value = model.Mail;

            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Added succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Model not insert! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public static void UpdateFotomodel(Fotomodel model, int id)
        {
            int caracteristiciID;
            SqlConnection conn = GetConnection();

            //Comanda pentru a afla ID-ul din tabela Caracteristici modelului pe care vrem sa-l updatam
            SqlCommand cmdId = new SqlCommand("SELECT CaracteristiciId FROM Model WHERE Id = @ModelId", conn);

            cmdId.CommandType = System.Data.CommandType.Text;

            cmdId.Parameters.Add("@ModelId", SqlDbType.VarChar).Value = id;

            caracteristiciID = (int)cmdId.ExecuteScalar();

            //Update tabela Caracteristici
            string sql = "UPDATE Caracteristici SET";
            
            if (model.Inaltime != null) {
                sql = sql + " Inaltime = @Inaltime";
            }
            if (model.Bust != null)
            {
                sql = sql + ", Bust = @Bust";
            }
            if (model.Talie != null)
            {
                sql = sql + ", Talie = @Talie";
            }
            if (model.Solduri != null)
            {
                sql = sql + ", Solduri = @Solduri";
            }
            if (model.Pantof != null)
            {
                sql = sql + ", Pantof = @Pantof";
            }
            if (model.MarimeHaine != null)
            {
                sql = sql + ", MarimeHaine = @MarimeHaine";
            }
            if (model.CuloarePar!= null)
            {
                sql = sql + ", CuloarePar = @CuloarePar";
            }
            if (model.CuloareOchi != null)
            {
                sql = sql + ", CuloareOchi = @CuloareOchi";
            }
            sql = sql + " WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = caracteristiciID;

            if (model.Inaltime != null)
            {
                cmd.Parameters.Add("@Inaltime", SqlDbType.Int).Value = model.Inaltime;
            }
            if (model.Bust != null)
            {
                cmd.Parameters.Add("@Bust", SqlDbType.Int).Value = model.Bust;
            }
            if (model.Talie != null)
            {
                cmd.Parameters.Add("@Talie", SqlDbType.Int).Value = model.Talie;
            }
            if (model.Solduri != null)
            {
                cmd.Parameters.Add("@Solduri", SqlDbType.Int).Value = model.Solduri;
            }
            if (model.Pantof != null)
            {
                cmd.Parameters.Add("@Pantof", SqlDbType.Int).Value = model.Pantof;
            }
            if (model.MarimeHaine != null)
            {
                cmd.Parameters.Add("@MarimeHaine", SqlDbType.VarChar).Value = model.MarimeHaine;
            }
            if (model.CuloarePar != null)
            {
                cmd.Parameters.Add("@CuloarePar", SqlDbType.VarChar).Value = model.CuloarePar;
            }
            if (model.CuloareOchi != null)
            {
                cmd.Parameters.Add("@CuloareOchi", SqlDbType.VarChar).Value = model.CuloareOchi;
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Model characteristics not insert! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            string sql2 = "UPDATE Model SET";

            if (model.Nume != null)
            {
                sql2 = sql2 + " Nume = @Nume";
            }
            if (model.DataNasterii != null)
            {
                sql2 = sql2 + ", DataNasterii = @DataNasterii";
            }
            if (model.Sex != null)
            {
                sql2 = sql2 + ", Sex = @Sex";
            }
            if (model.NumarTelefon != null)
            {
                sql2 = sql2 + ",  NumarTelefon = @NumarTelefon";
            }
            if (model.Mail != null)
            {
                sql2 = sql2 + ", Mail = @Mail";
            }

            sql2 = sql2 + " WHERE Id = @Id";

            SqlCommand cmd2 = new SqlCommand(sql2, conn);

            cmd2.CommandType = System.Data.CommandType.Text;

            cmd2.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;

            if (model.Nume != null)
            {
                cmd2.Parameters.Add("@Nume", SqlDbType.VarChar).Value = model.Nume;
            }
            if (model.DataNasterii != null)
            {
                cmd2.Parameters.Add("@DataNasterii", SqlDbType.Date).Value = model.DataNasterii;
            }
            if (model.Sex != null)
            {
                cmd2.Parameters.Add("@Sex", SqlDbType.VarChar).Value = model.Sex;
            }
            if (model.NumarTelefon != null)
            {
                cmd2.Parameters.Add("@NumarTelefon", SqlDbType.VarChar).Value = model.NumarTelefon;
            }
            if (model.Mail != null)
            {
                cmd2.Parameters.Add("@Mail", SqlDbType.VarChar).Value = model.Mail;
            }

            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Updated succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Model not update! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DeleteModel(int id)
        {
            SqlConnection conn = GetConnection();
            int caracteristiciId;

            //Comanda pentru a afla ID-ul din tabela Caracteristici modelului pe care vrem sa-l stergem
            SqlCommand cmdId = new SqlCommand("SELECT CaracteristiciId FROM Model WHERE Id = @ModelId", conn);

            cmdId.CommandType = System.Data.CommandType.Text;

            cmdId.Parameters.Add("@ModelId", SqlDbType.VarChar).Value = id;

            caracteristiciId = (int)cmdId.ExecuteScalar();

            //Stergere interogare dorita din tabela Model
            string sql = "DELETE FROM Model WHERE ID = @ModelId";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@ModelId", SqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Model not delete! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Stergere interogare dorita din tabele Caracteristici
            string sqlCarac = "DELETE FROM Caracteristici WHERE ID = @caracteristiciId";

            SqlCommand cmdCarac = new SqlCommand(sqlCarac, conn);

            cmdCarac.CommandType = System.Data.CommandType.Text;

            cmdCarac.Parameters.Add("@caracteristiciId", SqlDbType.Int).Value = caracteristiciId;

            try
            {
                cmdCarac.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Characteristics not delete! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            conn.Close();
        }

        public static void AddEvent(Event eve)
        {
            int contactInfoId, companieId;
            SqlConnection conn = GetConnection();

            //Inserarea valorilor noii inregistrari in tabele ContactInfo
            string sql = "INSERT INTO ContactInfo VALUES (@NumarTelefon, @Adresa, @Mail, @Fax, @IndicatiiOrientare)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@NumarTelefon", SqlDbType.VarChar).Value = eve.NumarTelefon;
            cmd.Parameters.Add("@Adresa", SqlDbType.VarChar).Value = eve.Adresa;
            cmd.Parameters.Add("@Mail", SqlDbType.VarChar).Value = eve.Mail;
            cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value = eve.Fax;
            cmd.Parameters.Add("@IndicatiiOrientare", SqlDbType.VarChar).Value = eve.Indicatii;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Company contact info not insert! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Comanda pentru a afla ultimul ID din tabela ContactInfo
            SqlCommand cmdId = new SqlCommand("SELECT Id FROM ContactInfo WHERE Id = (SELECT MAX(id) FROM ContactInfo)", conn);

            cmdId.CommandType = System.Data.CommandType.Text;

            contactInfoId = (int)cmdId.ExecuteScalar();

            //Inserarea valorilor noii inregistrari in tabele Companie
            string sqlCom = "INSERT INTO Companie VALUES (@contactInfoId, @Nume, @CUI, @IBAN, @Banca, @CapitalSocial)";

            SqlCommand cmdCom = new SqlCommand(sqlCom, conn);

            cmdCom.CommandType = System.Data.CommandType.Text;
            cmdCom.Parameters.Add("@contactInfoId", SqlDbType.Int).Value = contactInfoId;
            cmdCom.Parameters.Add("@Nume", SqlDbType.VarChar).Value = eve.NumeCompanie;
            cmdCom.Parameters.Add("@CUI", SqlDbType.VarChar).Value = eve.CUI;
            cmdCom.Parameters.Add("@IBAN", SqlDbType.VarChar).Value = eve.IBAN;
            cmdCom.Parameters.Add("@Banca", SqlDbType.VarChar).Value = eve.Banca;
            cmdCom.Parameters.Add("@CapitalSocial", SqlDbType.Int).Value = eve.CapitalSocial;
            
            try
            {
                cmdCom.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Company details not insert! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Comanda pentru a afla ultimul ID din tabela Companie
            SqlCommand cmdIdC = new SqlCommand("SELECT Id FROM Companie WHERE Id = (SELECT MAX(Id) FROM Companie)", conn);

            cmdIdC.CommandType = System.Data.CommandType.Text;

            companieId = (int)cmdIdC.ExecuteScalar();


            //Inserarea unei noi inregistrari in tabela Evenimente
            string sql2 = "INSERT INTO Eveniment VALUES (@companieId, @Nume, @Locatie, @Data, @Descriere)";

            SqlCommand cmd2 = new SqlCommand(sql2, conn);

            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.Parameters.Add("@companieId", SqlDbType.Int).Value = companieId;
            cmd2.Parameters.Add("@Nume", SqlDbType.VarChar).Value = eve.NumeEveniment;
            cmd2.Parameters.Add("@Locatie", SqlDbType.VarChar).Value = eve.Locatie;
            cmd2.Parameters.Add("@Data", SqlDbType.Date).Value = eve.Data;
            cmd2.Parameters.Add("@Descriere", SqlDbType.VarChar).Value = eve.Descriere;

            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Added succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("event not insert! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public static void UpdateEvent(Event eve, int id)
        {
            int companieId, contactInfoId;
            SqlConnection conn = GetConnection();

            //Comanda pentru a afla ID-ul din tabela Companie a evenimentului pe care vrem sa-l updatam
            SqlCommand cmdIdCompanie = new SqlCommand("SELECT CompanieId FROM Eveniment WHERE Id = @EventId", conn);

            cmdIdCompanie.CommandType = System.Data.CommandType.Text;

            cmdIdCompanie.Parameters.Add("@EventId", SqlDbType.Int).Value = id;

            companieId = (int)cmdIdCompanie.ExecuteScalar();

            //Comanda pentru a afla ID-ul din tabela ContactInfo evenimentului pe care vrem sa-l updatam
            SqlCommand cmdId = new SqlCommand("SELECT ContactInfoId FROM Companie WHERE Id = @CompanieId", conn);

            cmdId.CommandType = System.Data.CommandType.Text;

            cmdId.Parameters.Add("@CompanieId", SqlDbType.Int).Value = companieId;

            contactInfoId = (int)cmdId.ExecuteScalar();

            
            //Updatare interogare dorita din tabele ContactInfo
            string sqlCI = "UPDATE ContactInfo SET";
            
            if (eve.NumarTelefon != null)
            {
                sqlCI = sqlCI + " NumarTelefon = @NumarTelefon";
            }
            if (eve.Adresa != null)
            {
                sqlCI = sqlCI + ", Adresa = @Adresa";
            }
            if (eve.Mail != null)
            {
                sqlCI = sqlCI + ", Mail = @Mail";
            }
            if (eve.Fax != null)
            {
                sqlCI = sqlCI + ", Fax = @Fax";
            }
            if (eve.Indicatii != null)
            {
                sqlCI = sqlCI + ", IndicatiiOrientare = @Indicatii";
            }

            sqlCI = sqlCI + " WHERE Id = @ContactInfoId";

            SqlCommand cmdCI = new SqlCommand(sqlCI, conn);
            cmdCI.CommandType = System.Data.CommandType.Text;
            cmdCI.Parameters.Add("@ContactInfoId", SqlDbType.VarChar).Value = contactInfoId;

            if (eve.NumarTelefon != null)
            {
                cmdCI.Parameters.Add("@NumarTelefon", SqlDbType.VarChar).Value = eve.NumarTelefon;
            }
            if (eve.Adresa != null)
            {
                cmdCI.Parameters.Add("@Adresa", SqlDbType.VarChar).Value = eve.Adresa;
            }
            if (eve.Mail != null)
            {
                cmdCI.Parameters.Add("@Mail", SqlDbType.VarChar).Value = eve.Mail;
            }
            if (eve.Fax != null)
            {
                cmdCI.Parameters.Add("@Fax", SqlDbType.VarChar).Value = eve.Fax;
            }
            if (eve.Indicatii != null)
            {
                cmdCI.Parameters.Add("@Indicatii", SqlDbType.VarChar).Value = eve.Indicatii;
            }

            try
            {
                cmdCI.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Event Contact Info not update! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Updatare interogare dorita din tabele Companie
            string sqlCompanie = "UPDATE Companie SET";
            
            if (eve.NumeCompanie != null)
            {
                sqlCompanie = sqlCompanie + " Nume = @NumeCompanie";
            }
            if (eve.CUI != null)
            {
                sqlCompanie = sqlCompanie + ", CUI = @CUI";
            }
            if (eve.IBAN != null)
            {
                sqlCompanie = sqlCompanie + ", IBAN = @IBAN";
            }
            if (eve.Banca != null)
            {
                sqlCompanie = sqlCompanie + ", Banca = @Banca";
            }
            if (eve.Indicatii != null)
            {
                sqlCompanie = sqlCompanie + ", CapitalSocial = @CapitalSocial";
            }
            sqlCompanie = sqlCompanie + " WHERE Id = @Id";

            SqlCommand cmdCompanie = new SqlCommand(sqlCompanie, conn);
            cmdCompanie.CommandType = System.Data.CommandType.Text;
            cmdCompanie.Parameters.Add("@Id", SqlDbType.Int).Value = companieId;

            if (eve.NumeCompanie != null)
            {
                cmdCompanie.Parameters.Add("@NumeCompanie", SqlDbType.VarChar).Value = eve.NumeCompanie;
            }
            if (eve.CUI != null)
            {
                cmdCompanie.Parameters.Add("@CUI", SqlDbType.VarChar).Value = eve.CUI;
            }
            if (eve.IBAN != null)
            {
                cmdCompanie.Parameters.Add("@IBAN", SqlDbType.VarChar).Value = eve.IBAN;
            }
            if (eve.Banca != null)
            {
                cmdCompanie.Parameters.Add("@Banca", SqlDbType.VarChar).Value = eve.Banca;
            }
            if (eve.Indicatii != null)
            {
                cmdCompanie.Parameters.Add("@CapitalSocial", SqlDbType.Int).Value = eve.CapitalSocial;
            }
            
            try
            {
                cmdCompanie.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Event company info not updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            //Update Event
            string sql2 = "UPDATE Eveniment SET";

            if (eve.NumeEveniment != null)
            {
                sql2 = sql2 + " Nume = @Nume";
            }
            if (eve.Locatie != null)
            {
                sql2 = sql2 + ", Locatie = @Locatie";
            }
            if (eve.Data != null)
            {
                sql2 = sql2 + ", Data = @Data";
            }
            if (eve.Descriere != null)
            {
                sql2 = sql2 + ", Descriere = @Descriere";
            }
            sql2 = sql2 + " WHERE Id = @Id";

            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;

            if (eve.NumeEveniment != null)
            {
                cmd2.Parameters.Add("@Nume", SqlDbType.VarChar).Value = eve.NumeEveniment;
            }
            if (eve.Locatie != null)
            {
                cmd2.Parameters.Add("@Locatie", SqlDbType.VarChar).Value = eve.Locatie;
            }
            if (eve.Data != null)
            {
                cmd2.Parameters.Add("@Data", SqlDbType.DateTime).Value = eve.Data;
            }
            if (eve.Descriere != null)
            {
                cmd2.Parameters.Add("@Descriere", SqlDbType.VarChar).Value = eve.Descriere;
            }
            
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Updated succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Event not update! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DeleteEvent(int id)
        {
            SqlConnection conn = GetConnection();
            int companieId;
            int contactInfoId;

            //Comanda pentru a afla ID-ul din tabela Companie a evenimentului pe care vrem sa-l stergem
            SqlCommand cmdIdCompanie = new SqlCommand("SELECT CompanieId FROM Eveniment WHERE Id = @EventId", conn);

            cmdIdCompanie.CommandType = System.Data.CommandType.Text;

            cmdIdCompanie.Parameters.Add("@EventId", SqlDbType.Int).Value = id;

            companieId = (int)cmdIdCompanie.ExecuteScalar();

            //Comanda pentru a afla ID-ul din tabela ContactInfo evenimentului pe care vrem sa-l stergem
            SqlCommand cmdId = new SqlCommand("SELECT ContactInfoId FROM Companie WHERE Id = @CompanieId", conn);

            cmdId.CommandType = System.Data.CommandType.Text;

            cmdId.Parameters.Add("@CompanieId", SqlDbType.Int).Value = companieId;

            contactInfoId = (int)cmdId.ExecuteScalar();

            //Stergere interogare dorita din tabela Evenimente
            string sql = "DELETE FROM Eveniment WHERE Id = @EventId";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@EventId", SqlDbType.Int).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Event not delete! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Stergere interogare dorita din tabela EvenimenteModel
            string sqlEM = "DELETE FROM EvenimentModel WHERE EvenimentId = @Id";

            SqlCommand cmdEM = new SqlCommand(sqlEM, conn);
            cmdEM.CommandType = System.Data.CommandType.Text;
            cmdEM.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            try
            {
                cmdEM.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Event from common table not delete! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Stergere interogare dorita din tabele Companie
            /*string sqlC = "DELETE FROM Companie WHERE ID = @companieId";

            SqlCommand cmdC = new SqlCommand(sqlC, conn);

            cmdC.CommandType = System.Data.CommandType.Text;

            cmdC.Parameters.Add("@companieId", SqlDbType.Int).Value = companieId;

            try
            {
                cmdC.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Companie not delete! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Stergere interogare dorita din tabele ContactInfo
            string sqlCI = "DELETE FROM ContactInfo WHERE ID = @contactInfoId";

            SqlCommand cmdCI = new SqlCommand(sqlCI, conn);

            cmdCI.CommandType = System.Data.CommandType.Text;

            cmdCI.Parameters.Add("@contactInfoId", SqlDbType.Int).Value = contactInfoId;

            try
            {
                cmdCI.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Contact Info not delete! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
          
            conn.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();

        }
    }
}
