using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using FWBDS;

public partial class CadastroAnexo : System.Web.UI.UserControl
{
    private string _TAB_PAI;
    private int? _PAI_ID;

    public string TAB_PAI
    {
        get { return _TAB_PAI; }
        set { _TAB_PAI = value; }
    }
    public int? PAI_ID
    {
        get { return _PAI_ID; }
        set { _PAI_ID = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregaDados();
        }

    }

    protected void btIncluir_Click(object sender, EventArgs e)
    {
        if (txt_des.Text == "")
        {
            Response.Write("<script language=\"JavaScript\">alert('O campo Descrição é obrigatório!');</script>");
            return;
        }

        if (fu_url.FileName == "")
        {
            Response.Write("<script language=\"JavaScript\">alert('O campo Caminho é obrigatório!');</script>");
            return;
        }

        Anexo Anexo = new Anexo();
        if (!String.IsNullOrEmpty(TAB_PAI.ToString()))
        {
            Anexo.ANX_TAB_PAI = TAB_PAI.ToString();
        }
        if (!String.IsNullOrEmpty(PAI_ID.ToString()))
        {
            Anexo.ANX_PAI_ID = PAI_ID.Value;
        }
        Anexo.ANX_TIP_ANX_ID = 1; // Fixando 0 pois não temos o conceito de Tipo de Anexo no Salvado
        Anexo.ANX_DES = txt_des.Text;

        string sPastaAnexo = ConfigurationManager.AppSettings["PastaAnexo"].ToString();
        Anexo.ANX_CAM = sPastaAnexo; //Insere registro de Anexo somente com a pasta de Anexos do Servidor

        Anexo.ANX_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());

        string sRetorno = "";
        sRetorno = Anexo.Inserir();

        if (sRetorno.Substring(0, 1) == "E")
        {
            throw new Exception("Erro ao inserir ANX. Code Behind: CadastroAnexo.ascx.cs " + sRetorno);
        }

        Anexo.ANX_ID = Convert.ToInt16(sRetorno);
        string sArquivo = "ANX_" + sRetorno.PadLeft(4, '0') + fu_url.FileName.Substring(fu_url.FileName.LastIndexOf("."));
        string sCaminho = Server.MapPath("~") + "\\" + sPastaAnexo + "\\" + sArquivo;

        fu_url.SaveAs(sCaminho); //Grava arquivo fisico no local absoluto do Servidor

        Anexo.ANX_CAM = Anexo.ANX_CAM + "/" + sArquivo; //Atualiza registro do Anexo com o caminho virtual do Servidor
        Anexo.ANX_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());

        sRetorno = "";
        sRetorno = Anexo.Alterar();

        CarregaDados();

        //cbo_tip.SelectedIndex = 0; Não existe Tipo de Anexo no Salvado
        txt_des.Text = "";

    }

    protected void imgExcluir_Click(object sender, EventArgs e)
    {
        string sCommandArgument = ((ImageButton)sender).CommandArgument;
        char[] delimiterChars = { ',' };
        string[] aExcluir = sCommandArgument.Split(delimiterChars);

        Anexo Anexo = new Anexo();
        Anexo.ANX_ID = Convert.ToInt16(aExcluir[0]); //Contem ANX_ID
        Anexo.Excluir();

        string sCaminho = Server.MapPath("~") + "\\" + aExcluir[1]; //Contem ANX_CAM
        File.Delete(sCaminho);

        CarregaDados();
    }

    protected void gvAnexo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.className = 'selecionado'");
            if ((e.Row.RowIndex % 2) == 0)
            {
                e.Row.Attributes.Add("onMouseOut", "this.className = 'linha_par'");
            }
            else
            {
                e.Row.Attributes.Add("onMouseOut", "this.className = 'linha_impar'");
            }
            string sCaminho = gvAnexo.DataKeys[e.Row.RowIndex][1].ToString(); //Contem ANX_CAM
            string sDescricao = gvAnexo.DataKeys[e.Row.RowIndex][2].ToString(); //Contem ANX_DES

            e.Row.Cells[0].Attributes.Add("onClick", "JavaScript:window.open('ApresentaAnexo.aspx?ANX=" + sCaminho + "&DES=" + sDescricao + "','Anexo')");
            e.Row.Cells[1].Attributes.Add("onClick", "JavaScript:window.open('ApresentaAnexo.aspx?ANX=" + sCaminho + "&DES=" + sDescricao + "','Anexo')");
            //e.Row.Cells[2].Attributes.Add("onClick", "JavaScript:window.open('ApresentaAnexo.aspx?ANX=" + sCaminho + "&DES=" + sDescricao + "','Anexo')"); Não temos a ultima coluna por conta do Tipo de Anexo que não tem no Salvado
        }
    }

    private SortDirection GridViewSortDirection
    {
        get
        {
            if (ViewState["sortDirection"] == null)
                ViewState["sortDirection"] = SortDirection.Ascending;
            return (SortDirection)ViewState["sortDirection"];
        }
        set { ViewState["sortDirection"] = value; }
    }

    private int GetSortColumnIndex()
    {
        foreach (DataControlField field in gvAnexo.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvAnexo.Columns.IndexOf(field);
            }
        }
        return -1;
    }

    private void AddSortImage(int columnIndex, GridViewRow headerRow)
    {
        // Create the sorting image based on the sort direction.
        Image sortImage = new Image();
        if (GridViewSortDirection == SortDirection.Ascending)
        {
            sortImage.ImageUrl = "img/arrow_down.gif";
            sortImage.AlternateText = "Ordem Ascendente";
        }
        else
        {
            sortImage.ImageUrl = "img/arrow_up.gif";
            sortImage.AlternateText = "Ordem Descendente";
        }
        // Add the image to the appropriate header cell.
        headerRow.Cells[columnIndex].Controls.Add(sortImage);
    }

    protected void gvAnexo_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            int sortColumnIndex = GetSortColumnIndex();
            if (sortColumnIndex != -1)
            {
                AddSortImage(sortColumnIndex, e.Row);
            }
        }
    }

    protected void gvAnexo_Sorting(Object sender, GridViewSortEventArgs e)
    {
        string Ordem = " ASC ";
        string sortExpression = e.SortExpression;
        ViewState["SortExpression"] = sortExpression;
        if (GridViewSortDirection == SortDirection.Ascending)
        {
            GridViewSortDirection = SortDirection.Descending;
            Ordem = " DESC ";
        }
        else
        {
            GridViewSortDirection = SortDirection.Ascending;
            Ordem = " ASC ";
        }

        Anexo Anexo = new Anexo();
        DataSet dtAnexo = Anexo.Consultar();

        DataTable tblAnexo = dtAnexo.Tables[0];
        DataView dvAnexo = new DataView(tblAnexo);
        dvAnexo.Sort = e.SortExpression + Ordem;
        gvAnexo.DataSource = dvAnexo;
        gvAnexo.DataBind();

        dvAnexo.Dispose();
        tblAnexo.Dispose();
        dtAnexo.Dispose();
        Dispose();
    }

    protected void CarregaDados()
    {
        Anexo Anexo = new Anexo();
        if (!String.IsNullOrEmpty(TAB_PAI.ToString()))
        {
            Anexo.ANX_TAB_PAI = TAB_PAI.ToString();
        }
        if (!String.IsNullOrEmpty(PAI_ID.ToString()))
        {
            Anexo.ANX_PAI_ID = PAI_ID.Value;
        }
        DataSet dtAnexo = Anexo.Consultar();

        gvAnexo.DataSource = dtAnexo;
        gvAnexo.DataBind();

        dtAnexo.Dispose();
        Dispose();
    }

}
