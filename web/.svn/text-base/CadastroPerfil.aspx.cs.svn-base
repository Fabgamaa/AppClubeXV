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
using System.Text.RegularExpressions;
using FWBDS;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (PFL_ID.Value.Length == 0)
        {
            PFL_ID.Value = Convert.ToString(Request["PFL_ID"]);
        }
        if (MNU_ID.Value.Length == 0)
        {
            MNU_ID.Value = Convert.ToString(Request["MNU_ID"]);
        }

        if (PFL_ID.Value.Length > 0)
        {
            lbAcao.Text = "Alterar ";
        }
        else
        {
            lbAcao.Text = "Novo ";
        }

        if (!IsPostBack)
        {
            CarregaDados();
        }
    }

    protected void CarregaDados()
    {
        CarregaPerfil();

        if (!String.IsNullOrEmpty(PFL_ID.Value))
        {
            Perfil Perfil = new Perfil();
            Perfil.PFL_ID = Convert.ToInt32(PFL_ID.Value);
            DataSet dtPerfil = Perfil.Consultar();
            
            DataTable tblPerfil = dtPerfil.Tables[0];
            if (tblPerfil.Rows.Count > 0)
            {
                DataRow drCurrent = tblPerfil.Rows[0];
                txt_des.Text = drCurrent["PFL_DES"].ToString();
                cbo_pfl_rsp.SelectedValue = drCurrent["PFL_PFL_RSP_ID"].ToString();
                cbo_sts.SelectedValue = drCurrent["PFL_STS"].ToString();
                if (Convert.ToInt32(drCurrent["PFL_STM"].ToString()) == 1)
                {
                    btSalvar.Enabled = false;
                }
            }
            dtPerfil.Dispose();
            Dispose();
        }
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        string sMsg = "";
        Msg.Text = "";

        if (txt_des.Text == "")
        {
            Msg.Text = "<br> O campo Descrição é obrigatório.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_des.focus();";
            Msg.Focus();
            return;
        }

        Perfil Perfil = new Perfil();
        Perfil.PFL_DES = txt_des.Text;
        if (cbo_pfl_rsp.SelectedValue != "")
        {
            Perfil.PFL_PFL_RSP_ID = Convert.ToInt16(cbo_pfl_rsp.SelectedValue);
        }
        Perfil.PFL_STS = Convert.ToInt16(cbo_sts.SelectedValue);
        Perfil.PFL_STM = 0;  //Indica que não é usuário do sistema

        if (PFL_ID.Value != "")
        {
            Perfil.PFL_ID = Convert.ToInt32(PFL_ID.Value);
            Perfil.PFL_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Perfil.Alterar();
            if (sMsg != "")
            {
                Msg.Text = "<br>" + sMsg;
            }
            else
            {
                Response.Write("<script language=\"javascript\">alert('Perfil alterado com sucesso.')</script>");
            }
        }
        else
        {
            Perfil PFL = new Perfil();
            PFL.PFL_DES = txt_des.Text;
            DataSet dtPFL = PFL.Consultar();
            if (dtPFL.Tables[0].Rows.Count > 0)
            {
                Msg.Text = "<br>Esse Perfil já está cadastrado.";
                Msg.NavigateUrl = "JavaScript:document.all.txt_cod.focus();";
                Msg.Focus();
                return;
            }

            Perfil.PFL_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Perfil.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Msg.Text = "<br>" + sMsg;
            }
            else
            {
                PFL_ID.Value = sMsg;

                // Inserir todos os Menus disponíveis com todas as permissões ativas
                PerfilMenu PerfilMenu = new PerfilMenu();
                PerfilMenu.PFL_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
                sMsg = PerfilMenu.InserirPermissaoNovoPerfil(Convert.ToInt32(PFL_ID.Value));
                if (sMsg != "")
                {
                    Msg.Text = "<br>" + sMsg;
                }
                else
                {
                    lbAcao.Text = "Alterar ";
                    Response.Write("<script language=\"javascript\">alert('Perfil inserido com sucesso.')</script>");
                    if (!String.IsNullOrEmpty(Msg.Text))
                    {
                        CarregaDados();
                    }
                }
            }
            dtPFL.Dispose();
        }
        Dispose();
    }

    protected void CarregaPerfil()
    {
        cbo_pfl_rsp.Items.Clear();
        cbo_pfl_rsp.AppendDataBoundItems = true;
        cbo_pfl_rsp.Items.Insert(0, "");

        Perfil Perfil = new Perfil();
        DataSet dtPerfil = Perfil.Consultar();

        cbo_pfl_rsp.DataTextField = "PFL_DES";
        cbo_pfl_rsp.DataValueField = "PFL_ID";

        cbo_pfl_rsp.DataSource = dtPerfil;
        cbo_pfl_rsp.DataBind();

        dtPerfil.Dispose();
        Dispose();

    }

    protected void btNovo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CadastroPerfil.aspx?mnu_id=" + Request.QueryString["MNU_ID"] + "&USR_ID=");
    }

}
