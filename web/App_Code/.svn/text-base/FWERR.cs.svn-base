using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for FWERR
/// </summary>
public class FWERR
{

    #region Propriedades
    /// <summary>
    /// Propriedade que recebe a mensagem de erro
    /// </summary>
    /// 
    private string _MsgErro;
   
    public string MsgErro
    {
        get { return _MsgErro; }
        set { _MsgErro = value; }
    }
    
    /// <summary>
    /// Propriedade que recebe os detalhes do erro
    /// </summary>
    /// 
    private string _Trace;

    public string Trace
    {
        get { return _Trace; }
        set { _Trace = value; }
    }


    /// <summary>
    /// Propriedade que recebe o caminho onde ocorreu o erro
    /// </summary>
    /// 
    private string _URL;

    public string URL
    {
        get { return _URL; }
        set { _URL = value; }
    }


    /// <summary>
    /// Propriedade que recebe a data e a hora que o erro ocorreu
    /// </summary>
    /// 
    private DateTime _Data;

    public DateTime Data
    {
        get { return _Data; }
        set { _Data = value; }
    }

    /// <summary>
    /// Propriedade que recebe a data e a hora que o erro ocorreu
    /// </summary>
    /// 
    private string _ErroGravar;

    public string ErroGravar
    {
        get { return _ErroGravar; }
        set { _ErroGravar = value; }
    }

    #endregion

    #region "Metodos"

     /// <summary>
    /// Salva o log em XML
    /// </summary>
    /// <param name="CaminhoCompleto">
    /// Caminho completo do arquivo de Log
    /// </param>
    /// 

    public void SalvarLogErro(string CaminhoCompleto)
    {
        try
        {
            //Pego o caminho e arquivo do Log no WebConfig
            //string CaminhoLog = CaminhoCompleto + ConfigurationManager.AppSettings["FWLocalLogErro"].ToString();

            //Crio a estrutura da tabela para gerar no XML
            DataTable dtErro = new DataTable();
            dtErro.TableName = "Log";
            dtErro.Columns.Add("MsgErro");
            dtErro.Columns.Add("Trace");
            dtErro.Columns.Add("URL");
            dtErro.Columns.Add("Data");

            //Leio o XML
            if (System.IO.File.Exists(CaminhoCompleto))
            {
                //Se o arquivo existir os valores são lidos
                dtErro.ReadXml(CaminhoCompleto);
            }
            else
            {
                //Se o arquivo não existir é criado
                System.IO.File.WriteAllText(CaminhoCompleto, String.Empty);
            }

            //Crio uma nova linha
            DataRow drErro = dtErro.NewRow();


            //Atribuo os valores para a linha
            drErro["MsgErro"] = MsgErro;
            drErro["Trace"] = Trace;
            drErro["URL"] = URL;
            drErro["Data"] = Data.ToString("dd/MM/yyyy HH:mm:ss");

            //Adiciono a linha para a tabela
            dtErro.Rows.Add(drErro);
            //Salvo o arquivo
            dtErro.WriteXml(CaminhoCompleto);

            //Limpo o datatable da memória
            dtErro.Dispose();
        }
        catch(Exception e)
        {
            ErroGravar = e.Message.ToString(); 
        }
    }

    #endregion

}
