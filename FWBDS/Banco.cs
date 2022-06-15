using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace FWBDS
{
    ///<sumary>
    ///Classe com métodos para conectar no banco de dados
    ///</sumary>

    public class clsBanco
    {

        public SqlConnection dbConn = new SqlConnection(ConfigurationManager.AppSettings["FWConnection"]);
        //public SqlConnection dbConn = new SqlConnection("database= FWUNF_HOM; server=localhost;Uid=sa;Pwd=Admsa;");
        //public MySqlConnection dbConn = new MySqlConnection("database = xvnovembro; server=localhost;Uid=root;Pwd=Admroot;");

        ///<sumary>
        ///Metodo para desconectar do banco de dados
        ///</sumary>

        public void Conecta()
        {
            try
            {
                ///Verifica se o status da Conexão está fechada
                if (dbConn.State == 0)
                {
                    dbConn.Open();
                }
                else
                {
                    dbConn.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Conectar com Banco de Dados. Classe: clsBanco.cs" + e.Message);
            }
            finally { }
        }

        ///<sumary>
        ///Metodo para desconectar do banco de dados
        ///</sumary>

        public void Desconecta()
        {
            try
            {
                dbConn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao desconectar. Classe: clsBanco.cs" + e.Message);
            }
        }


        ///<sumary>
        ///Metodo para executar queries sem retorno no banco de dados
        ///</sumary>

        public string Executar(string sSQL)
        {
            try
            {
                Conecta();
                SqlCommand sSQLC = new SqlCommand(sSQL, dbConn);
                sSQLC.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return "Erro ao Alterar/Excluir. Classe: clsBanco.cs" + e.Message + " SQL: " + sSQL;
            }
            finally
            {
                Desconecta();
            }
            return "";
        }

        ///<sumary>
        ///Metodo para executar insert com Identity no banco de dados
        ///</sumary>

        public string ExecutarInserir(string sSQL)
        {
            string Indice = "";
            try
            {
                Conecta();
                SqlCommand sSQLC = new SqlCommand(sSQL, dbConn);
                sSQLC.ExecuteNonQuery();

                sSQL = "SELECT @@IDENTITY AS INDICE ";
                DataSet dtSet = new DataSet();
                SqlDataAdapter dtAdapter = new SqlDataAdapter(sSQL, dbConn);
                dtAdapter.Fill(dtSet);

                DataRow drCurrent = dtSet.Tables[0].Rows[0];
                Indice = drCurrent["INDICE"].ToString();

            }
            catch (Exception e)
            {
                return "Erro ao Inserir. Classe: clsBanco.cs" + e.Message + " SQL: " + sSQL;
            }
            finally
            {
                Desconecta();
            }
            return Indice;
        }

        ///<sumary>
        ///Metodo para executar query com retorno de DataSet no banco de dados
        ///</sumary>

        public DataSet ExecutarRetorno(string sSQL)
        {
            try
            {
                Conecta();
                DataSet dtSet = new DataSet();
                SqlDataAdapter dtAdapter = new SqlDataAdapter(sSQL, dbConn);
                dtAdapter.Fill(dtSet);

                return dtSet;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Consultar. Classe: clsBanco.cs" + e.Message + " SQL: " + sSQL);
            }
            finally
            {
                Desconecta();
            }
        }

    }
}

