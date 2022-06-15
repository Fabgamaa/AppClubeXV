using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FWBDS;
using System.Data;

public partial class uc_Funcao : System.Web.UI.UserControl
{

    private string _Tipo;

    public string Tipo
    {
        get { return _Tipo; }
        set { _Tipo = value; }
    }
    
    private int? _FAO_USR_ID;

    public int? FAO_USR_ID
    {
        get { return _FAO_USR_ID; }
        set { _FAO_USR_ID = value; }
    }

    private int _FAO_PFL_ID;

    public int FAO_PFL_ID
    {
        get { return _FAO_PFL_ID; }
        set { _FAO_PFL_ID = value; }
    }

    private string _FuncoesUsu;

    public string FuncoesUsu
    {
        get { return _FuncoesUsu; }
        set { _FuncoesUsu = value; }
    }

    private string _FuncoesPerfil;

    public string FuncoesPerfil
    {
        get { return _FuncoesPerfil; }
        set { _FuncoesPerfil = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack || Request["__EVENTTARGET"] == "cb_pfl")
        {
            if (!String.IsNullOrEmpty(FAO_USR_ID.ToString()))
            {
                CarregaUsuario();
            }
            CarregaFuncoes();
            
            if (String.IsNullOrEmpty(FAO_USR_ID.ToString()) && Tipo == "USR")
            {
                foreach (GridViewRow row in gvFuncoes.Rows)
                {
                    CheckBox ck = (CheckBox)row.FindControl("ckPermitir");
                    ck.Checked = true;
                }
            }
        }
    }

    protected void gvFuncoes_RowDataBound(object sender, GridViewRowEventArgs e)
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
            if (!String.IsNullOrEmpty(FuncoesUsu))
            {
                string[] aFuncoes = FuncoesUsu.Split(',');
                for (int i = 0; i <= aFuncoes.Length - 1; i++)
                {
                    if (gvFuncoes.DataKeys[e.Row.RowIndex].Value.ToString() == aFuncoes[i].ToString())
                    {
                        CheckBox ckPermitir = (CheckBox)e.Row.FindControl("ckPermitir");
                        ckPermitir.Checked = true;
                    }
                }
            }
        }

    }

    /*
    protected void ckPermitir_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox ch = (CheckBox)sender;
        GridViewRow row = (GridViewRow)ch.NamingContainer;
        int selectInd = row.RowIndex;
        int id = Convert.ToInt32(gvFuncoes.DataKeys[selectInd].Value.ToString());
        if (ch.Checked)
        {
            IncluiFuncao(id);
        }
        else
        {
            ExcluiFuncao(id);
        }
    }

    protected void IncluiFuncao(int FAO_ID)
    {
        string sMsg = "";

        UsuarioFuncao UsuFuncao = new UsuarioFuncao();
        UsuFuncao.USR_FAO_USR_ID = FAO_USR_ID;
        UsuFuncao.USR_FAO_FAO_ID = FAO_ID;
        UsuFuncao.USR_FAO_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
        sMsg = UsuFuncao.Inserir();

        if (sMsg.Substring(0, 1) == "E")
        {
            Msg.Text = "<br>" + sMsg;
        }
    }
    protected void ExcluiFuncao(int FAO_ID)
    {
        string sMsg = "";

        UsuarioFuncao UsuFuncao = new UsuarioFuncao();
        UsuFuncao.USR_FAO_USR_ID = FAO_USR_ID;
        UsuFuncao.USR_FAO_FAO_ID = FAO_ID;
        sMsg = UsuFuncao.Excluir();
        if (sMsg != "")
        {
            Msg.Text = "<br>" + sMsg;
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
        foreach (DataControlField field in gvFuncoes.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvFuncoes.Columns.IndexOf(field);
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




    protected void gvFuncoes_RowCreated(object sender, GridViewRowEventArgs e)
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


    protected void gvFuncoes_Sorting(Object sender, GridViewSortEventArgs e)
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

        PerfilFuncao PerfilFuncao = new PerfilFuncao();
        DataSet dtPerfilFuncao = PerfilFuncao.Consultar();

        DataTable tblPerfilFuncao = dtPerfilFuncao.Tables[0];
        DataView dvPerfilFuncao = new DataView(tblPerfilFuncao);
        dvPerfilFuncao.Sort = e.SortExpression + Ordem;
        gvFuncoes.DataSource = dvPerfilFuncao;
        gvFuncoes.DataBind();

        dvPerfilFuncao.Dispose();
        tblPerfilFuncao.Dispose();
        dtPerfilFuncao.Dispose();
        Dispose();
    }*/

    protected void CarregaFuncoes()
    {
        PerfilFuncao PerfilFuncao = new PerfilFuncao();
        PerfilFuncao.PFL_FAO_PFL_ID = Convert.ToInt32(FAO_PFL_ID);
        DataSet dtPerfilFuncao = PerfilFuncao.Consultar();

        gvFuncoes.DataSource = dtPerfilFuncao;
        gvFuncoes.DataBind();

        dtPerfilFuncao.Dispose();
        Dispose();
    }

    protected void CarregaUsuario()
    {
        UsuarioFuncao UsuFuncao = new UsuarioFuncao();
        UsuFuncao.USR_FAO_USR_ID = Convert.ToInt32(FAO_USR_ID);
        DataSet dtUsuFuncao = UsuFuncao.Consultar();
        DataTable tblUsuFuncao = dtUsuFuncao.Tables[0];
        
        foreach (DataRow drCurrent in tblUsuFuncao.Rows)
        {
            FuncoesUsu = FuncoesUsu + drCurrent["USR_FAO_FAO_ID"].ToString() + ",";
        }
        if (!String.IsNullOrEmpty(FuncoesUsu))
        {
            FuncoesUsu = FuncoesUsu.Substring(0, FuncoesUsu.Length - 1);
        }
        tblUsuFuncao.Dispose();
        dtUsuFuncao.Dispose();
        Dispose();
    }

}
