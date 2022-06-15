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
using FWBDS;

public partial class _Default : System.Web.UI.Page
{
    private int _QtdeNaoRepetir;

    public int QtdeNaoRepetir
    {
        get { return _QtdeNaoRepetir; }
        set { _QtdeNaoRepetir = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (USR_ID.Value.Length == 0)
        {
            USR_ID.Value = Convert.ToString(Request["USR_ID"]);
        }
        if (MNU_ID.Value.Length == 0)
        {
            MNU_ID.Value = Convert.ToString(Request["MNU_ID"]);
        }

        if (USR_ID.Value.Length > 0)
        {
            lbAcao.Text = "Alterar ";
        }
        else
        {
            lbAcao.Text = "Novo ";
        }

        if (!IsPostBack)
        {
            CarregaPerfil();
            CarregaMenu();
            CarregaDados();
        }

        QtdeNaoRepetir = Convert.ToInt16(ConfigurationManager.AppSettings["QtdeNaoRepetir"].ToString());

        FormataCampos();

    }

    protected void FormataCampos()
    {
        txt_dat_exi.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_exi.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
    }

    protected void cbo_pfl_SelectedIndexChanged(object sender, EventArgs e)
    {
        CarregaMenu();
    }

    protected void CarregaDados()
    {
        if (!String.IsNullOrEmpty(USR_ID.Value))
        {
            int TentativasIncorretas = Convert.ToInt16(ConfigurationManager.AppSettings["TentativasIncorretas"].ToString());

            Usuario Usuario = new Usuario();
            Usuario.USR_ID = Convert.ToInt32(USR_ID.Value);
            DataSet dsUsuario = Usuario.Consultar();

            DataTable dtUsuario = dsUsuario.Tables[0];
            if (dtUsuario.Rows.Count > 0)
            {
                DataRow drUSR = dtUsuario.Rows[0];

                txt_cod.Text = drUSR["USR_COD"].ToString();
                txt_snh.Text = drUSR["USR_SNH"].ToString();
                SNH_ANE.Value = drUSR["USR_SNH"].ToString(); //Guardo senha para validação de alteração
                if (!String.IsNullOrEmpty(drUSR["USR_DAT_EXI"].ToString()))
                {
                    txt_dat_exi.Text = Convert.ToDateTime(drUSR["USR_DAT_EXI"].ToString()).ToString("dd/MM/yyyy");
                }
                cbo_sts.SelectedValue = drUSR["USR_STS"].ToString();

                cbo_pfl.SelectedValue = drUSR["USR_PFL_ID"].ToString();
                CarregaMenu();

                cbo_pgn_ini.SelectedValue = drUSR["USR_MNU_ID"].ToString();

                txt_nom.Text = drUSR["USR_NOM"].ToString();

                txt_eml.Text = drUSR["USR_EML"].ToString();

                USR_NUM_TTT.Value = drUSR["USR_NUM_TTT"].ToString();
                if (Convert.ToInt16(drUSR["USR_NUM_TTT"].ToString()) >= TentativasIncorretas)
                {
                    UsuBloqueado.Visible = true;
                    btDesbloquear.Visible = true;
                }
                else
                {
                    UsuBloqueado.Visible = false;
                    btDesbloquear.Visible = false;
                }
                USR_SNH_ANE.Value = drUSR["USR_SNH_ANE"].ToString();

                if (Convert.ToInt32(drUSR["USR_STM"].ToString()) == 1)
                {
                    btSalvar.Enabled = false;
                    btDesbloquear.Enabled = false;
                }

            }
            dtUsuario.Dispose();
            Dispose();
        }
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        string sMsg = "";
        string NovasSenhas = "";

        //Monta Expressão de validação da senha
        string QtdeMinima = ConfigurationManager.AppSettings["QtdeMinima"].ToString();
        string QtdeSimbolos = ConfigurationManager.AppSettings["QtdeSimbolos"].ToString();
        string QtdeNumeros = ConfigurationManager.AppSettings["QtdeNumeros"].ToString();
        string validacao = "(?=.{" + QtdeMinima + ",})";
        validacao = validacao + @"(?=(.*\d){" + QtdeNumeros + ",})";
        validacao = validacao + @"(?=(.*\W){" + QtdeSimbolos + ",})";

        Msg.Text = "";

        if (txt_cod.Text == "")
        {
            Msg.Text = "<br> O campo Login é obrigatório.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_cod.focus();";
            Msg.Focus();
            return;
        }

        if (txt_snh.Text == "")
        {
            Msg.Text = "<br> O campo Senha é obrigatório.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh.focus();";
            Msg.Focus();
            return;
        }

        if (cbo_pfl.Text == "")
        {
            Msg.Text = "<br> O campo Perfil é obrigatório.";
            Msg.NavigateUrl = "JavaScript:document.all.cbo_pfl.focus();";
            Msg.Focus();
            return;
        }

        if (txt_nom.Text == "")
        {
            Msg.Text = "<br> O campo Nome é obrigatório.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_nom.focus();";
            Msg.Focus();
            return;
        }


        //Se a senha do banco for diferente da que estiver no campo processar alteração de senha
        if (txt_snh.Text != SNH_ANE.Value)
        {

            if (QtdeNaoRepetir > 1)
            {

                string SenhasAnt = USR_SNH_ANE.Value;

                if (SenhasAnt.IndexOf('\n') > 0)
                {
                    string[] aSenhas = SenhasAnt.Split('\n');
                    if (aSenhas.Length > 0)
                    {
                        for (int i = 0; i <= aSenhas.Length - 1; i++)
                        {

                            if (aSenhas.Length < QtdeNaoRepetir)
                            {
                                NovasSenhas = PreencheSenhas(aSenhas[i].Trim().ToString(), NovasSenhas);
                            }
                            else
                            {

                                if (i != 0)
                                {
                                    NovasSenhas = PreencheSenhas(aSenhas[i].Trim().ToString(), NovasSenhas);
                                }
                            }
                            if (ComparaSenha(aSenhas[i].Trim().ToString(), txt_snh.Text) == false)
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        NovasSenhas = PreencheSenhas(aSenhas[0].ToString(), NovasSenhas);
                    }
                }
                else
                {
                    if (ComparaSenha(SenhasAnt, txt_snh.Text) == false)
                    {
                        return;
                    }

                    NovasSenhas = PreencheSenhas(SenhasAnt, NovasSenhas);
                }

                NovasSenhas = PreencheSenhas(txt_snh.Text, NovasSenhas);
            }

        }

        Usuario Usuario = new Usuario();

        Usuario.USR_COD = txt_cod.Text;
        Usuario.USR_SNH = txt_snh.Text;
        Usuario.USR_DAT_ATL_SNH = DateTime.Now;
        Usuario.USR_SNH_ANE = NovasSenhas;
        if (txt_dat_exi.Text != "")
        {
            Usuario.USR_DAT_EXI = Convert.ToDateTime(txt_dat_exi.Text);
        }
        Usuario.USR_PFL_ID = Convert.ToInt16(cbo_pfl.SelectedValue);

        if (cbo_pgn_ini.SelectedValue != "")
        {
            Usuario.USR_MNU_ID = Convert.ToInt16(cbo_pgn_ini.SelectedValue);
        }

        Usuario.USR_NOM = txt_nom.Text;

        Usuario.USR_EML = txt_eml.Text;
        Usuario.USR_STS = Convert.ToInt16(cbo_sts.SelectedValue);
        Usuario.USR_STM = 0; //Indica que não é usuário do sistema

        if (USR_ID.Value != "")
        {
            Usuario.USR_ID = Convert.ToInt32(USR_ID.Value);
            Usuario.USR_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Usuario.Alterar();
            if (sMsg != "")
            {
                Msg.Text = "<br>" + sMsg;
            }
            else
            {
                Response.Write("<script language=\"javascript\">alert('Usuario alterado com sucesso.')</script>");
            }
        }
        else
        {
            Usuario USR = new Usuario();
            USR.USR_COD = txt_cod.Text;
            DataSet dtUSR = USR.Consultar();
            if (dtUSR.Tables[0].Rows.Count > 0)
            {
                Msg.Text = "<br>Esse Usuario já está cadastrado.";
                Msg.NavigateUrl = "JavaScript:document.all.txt_cod.focus();";
                Msg.Focus();
                return;
            }

            Usuario.USR_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Usuario.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Msg.Text = "<br>" + sMsg;
            }
            else
            {
                Response.Write("<script language=\"javascript\">alert('Usuario inserido com sucesso.')</script>");
            }
            dtUSR.Dispose();
        }
        Dispose();
    }

    protected bool ComparaSenha(string SenhaAntiga, string SenhaNova)
    {
        if (SenhaAntiga == SenhaNova)
        {
            Msg.Text = "<br>A senha não pode ser igual as ultimas " + QtdeNaoRepetir + " senhas cadastradas.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh.focus();";
            Msg.Focus();
            return false;
        }
        return true;
    }

    protected string PreencheSenhas(string Valor, string Senhas)
    {
        string NovasSenhas = "";
        if (!String.IsNullOrEmpty(Senhas))
        {
            NovasSenhas = Senhas + '\n' + Valor;
        }
        else
        {
            NovasSenhas = Valor;
        }
        return NovasSenhas;
    }

    protected void btDesbloquear_Click(object sender, EventArgs e)
    {
        string sMsg = "";

        Usuario Usuario = new Usuario();
        Usuario.USR_ID = Convert.ToInt32(USR_ID.Value);
        Usuario.USR_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
        Usuario.USR_NUM_TTT = 0;
        Usuario.AtualizaTentativas = true;
        sMsg = Usuario.Alterar();
        if (!String.IsNullOrEmpty(sMsg))
        {
            Msg.Text = sMsg;
        }
        CarregaDados();
    }

    protected void btNovo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CadastroUsuario.aspx?mnu_id=" + Request.QueryString["MNU_ID"] + "&USR_ID=");
    }

    protected void CarregaPerfil()
    {

        cbo_pfl.Items.Clear();
        cbo_pfl.AppendDataBoundItems = true;
        cbo_pfl.Items.Insert(0, "");

        Perfil Perfil = new Perfil();
        DataSet dtPerfil = Perfil.Consultar();

        cbo_pfl.DataTextField = "PFL_DES";
        cbo_pfl.DataValueField = "PFL_ID";

        cbo_pfl.DataSource = dtPerfil;
        cbo_pfl.DataBind();

        dtPerfil.Dispose();
        Dispose();

    }

    protected void CarregaMenu()
    {
        if (!String.IsNullOrEmpty(cbo_pfl.SelectedValue))
        {
            cbo_pgn_ini.Items.Clear();
            cbo_pgn_ini.Items.Add(new ListItem("", ""));
            FWBDS.Menu Menu = new FWBDS.Menu();
            Menu.PFL_ID = Convert.ToInt32(cbo_pfl.SelectedValue);
            DataSet dtMenu = Menu.CarregarMenus();

            DataTable tblMenu = dtMenu.Tables[0];
            if (tblMenu.Rows.Count > 0)
            {
                int iCount = 1;
                foreach (DataRow drCurrent in tblMenu.Rows)
                {
                    string sMenu = String.Empty;
                    for (int i = 1; i <= Convert.ToInt16(drCurrent["MNU_NVL"].ToString()); i++)
                    {
                        sMenu = sMenu + "\xa0\xa0";
                    }
                    sMenu = sMenu + drCurrent["MNU_TIT"].ToString();
                    cbo_pgn_ini.Items.Add(new ListItem(sMenu, drCurrent["MNU_ID"].ToString()));
                    if (String.IsNullOrEmpty(drCurrent["MNU_URL"].ToString()))
                    {
                        cbo_pgn_ini.Items[iCount].Attributes.Add("disabled", "true");
                    }

                    iCount = iCount + 1;
                }
            }

            tblMenu.Dispose();
            dtMenu.Dispose();
            Dispose();
        }
    }
}
