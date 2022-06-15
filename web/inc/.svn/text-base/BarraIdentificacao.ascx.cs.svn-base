using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using FWBDS;

public partial class BarraIdentificacao : System.Web.UI.UserControl
{

    private int? _PFL_MNU_CSU;
    private int? _PFL_MNU_ALT;
    private int? _PFL_MNU_NOO;
    private int? _PFL_MNU_EXL;

    public int? PFL_MNU_CSU
    {
        get { return _PFL_MNU_CSU; }
        set { _PFL_MNU_CSU = value; }
    }
    public int? PFL_MNU_ALT
    {
        get { return _PFL_MNU_ALT; }
        set { _PFL_MNU_ALT = value; }
    }
    public int? PFL_MNU_NOO
    {
        get { return _PFL_MNU_NOO; }
        set { _PFL_MNU_NOO = value; }
    }
    public int? PFL_MNU_EXL
    {
        get { return _PFL_MNU_EXL; }
        set { _PFL_MNU_EXL = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Verifica sessão ativa
        if (Session["USR"] == null)
        {
            Response.Write("<script>window.top.location = 'Default.aspx?Msg=1';</script>");
            Response.End();
        }

        string URL = Request.ServerVariables["URL"].ToString();
        URL = URL.Substring(URL.LastIndexOf("/") + 1, URL.Length - URL.LastIndexOf("/") - 1);

        if (URL.IndexOf("?") > 0)
        {
            URL = URL.Substring(0, URL.IndexOf("?"));
        }

        //Verifica banner
        if (URL != "AlterarSenha.aspx" && URL != "SemPermissao.aspx")
        {
            if (Session["Banner"] == null)
            {
                Response.Write("<script>window.top.location = 'Default.aspx?Msg=1';</script>");
                Response.End();
            }
        }

        //Verifica usuário tem permissão

        if (URL != "SemPermissao.aspx")
        {
            Usuario Usuario = new Usuario();
            Usuario.USR_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            Usuario.Pagina = URL;
            DataSet dtPermissao = Usuario.ConsultarPermissao();
            DataTable tblPermissao = dtPermissao.Tables[0];
            if (tblPermissao.Rows.Count > 0)
            {
                DataRow drPermissao = tblPermissao.Rows[0];
                PFL_MNU_CSU = Convert.ToInt32(drPermissao["PFL_MNU_CSU"].ToString());
                PFL_MNU_ALT = Convert.ToInt32(drPermissao["PFL_MNU_ALT"].ToString());
                PFL_MNU_NOO = Convert.ToInt32(drPermissao["PFL_MNU_NOO"].ToString());
                PFL_MNU_EXL = Convert.ToInt32(drPermissao["PFL_MNU_EXL"].ToString());

                if (PFL_MNU_ALT == 0)
                {
                    Button btSalvar = (Button)Parent.FindControl("btSalvar");
                    if (btSalvar != null)
                    {
                        btSalvar.Enabled = false;
                    }
                }

                if (PFL_MNU_NOO == 0)
                {
                    Button btNovoFiltro = (Button)Parent.FindControl("btNovoFiltro");
                    if (btNovoFiltro != null)
                    {
                        btNovoFiltro.Enabled = false;
                    }

                    Button btNovoLista = (Button)Parent.FindControl("btNovoLista");
                    if (btNovoLista != null)
                    {
                        btNovoLista.Enabled = false;
                    }

                    Button btNovo = (Button)Parent.FindControl("btNovo");
                    if (btNovo != null)
                    {
                        btNovo.Enabled = false;
                    }
                }

                if (PFL_MNU_EXL == 0)
                {
                    Button btExcluir = (Button)Parent.FindControl("btExcluir");
                    if (btExcluir != null)
                    {
                        btExcluir.Enabled = false;
                    }
                }
            }
            else
            {
                Response.Redirect("SemPermissao.aspx");
            }
            dtPermissao.Dispose();
            Dispose();
        }


    }
}
