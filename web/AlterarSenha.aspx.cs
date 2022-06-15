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

public partial class AlterarSenha : System.Web.UI.Page
{

    private int _QtdeNaoRepetir;

    public int QtdeNaoRepetir
    {
        get { return _QtdeNaoRepetir; }
        set { _QtdeNaoRepetir = value; }
    }

    private bool _ViaLogin;

    public bool ViaLogin
    {
        get { return _ViaLogin; }
        set { _ViaLogin = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["Msg"] == "Expira")
        {
            Msg.Text = "Sua senha expirou, cadastre uma nova.";
            ViaLogin = true;

        }
        frmAlterarSenha.DefaultFocus = "txt_snh_atu";
        QtdeNaoRepetir = Convert.ToInt16(ConfigurationManager.AppSettings["QtdeNaoRepetir"].ToString());


    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        //Monta Expressão de validação da senha
        string QtdeMinima = ConfigurationManager.AppSettings["QtdeMinima"].ToString();
        string QtdeSimbolos = ConfigurationManager.AppSettings["QtdeSimbolos"].ToString();
        string QtdeNumeros = ConfigurationManager.AppSettings["QtdeNumeros"].ToString();
        string validacao = "(?=.{" + QtdeMinima + ",})";
        validacao = validacao + @"(?=(.*\d){" + QtdeNumeros + ",})";
        validacao = validacao + @"(?=(.*\W){" + QtdeSimbolos + ",})";
       
        if (txt_snh_atu.Text == "")
        {
            Msg.Text = "O campo Senha Atual é obrigatório.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh_atu.focus();";
            Msg.Focus();
            return;
        }
        if (txt_snh_nov.Text == "")
        {
            Msg.Text = "O campo Nova Senha é obrigatório.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh_nov.focus();";
            Msg.Focus();
            return;
        }
        if (txt_snh_conf.Text == "")
        {
            Msg.Text = "O campo Confirmar Nova Senha é obrigatório.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh_conf.focus();";
            Msg.Focus();
            return;
        }
        if (txt_snh_nov.Text != txt_snh_conf.Text)
        {
            Msg.Text = "Os campos Nova Senha e Repetir Senha devem ser preenchidos com o mesmo valor.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh_nov.focus();";
            Msg.Focus();
            return;
        }
        if (Regex.IsMatch(txt_snh_nov.Text, validacao) == false)
        {
            Msg.Text = "A senha deve conter no mínimo " + QtdeMinima + " caracter(es), " + QtdeSimbolos + " simbolo(s) e " + QtdeNumeros + " número(s).";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh_nov.focus();";
            Msg.Focus();
            return;
        }

        //Não deixar a senha atual ser igual a nova senha
        if (ComparaSenha(txt_snh_atu.Text, txt_snh_nov.Text) == false)
        {
            return;
        }


        Usuario Login = new Usuario();

        Login.USR_COD = Session["USR"].ToString();
        Login.USR_SNH = txt_snh_atu.Text;
        DataSet dtLogin = Login.ConsultarLogin();

        DataTable tblLogin = dtLogin.Tables[0];

        if (tblLogin.Rows.Count > 0)
        {
            DataRow drCurrent = tblLogin.Rows[0];

            int UsuId = Convert.ToInt32(drCurrent["USR_ID"].ToString());
            string NovasSenhas = "";

            if (QtdeNaoRepetir > 1)
            {

                string SenhasAnt = drCurrent["USR_SNH_ANE"].ToString();
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

                            if (ComparaSenha(aSenhas[i].Trim().ToString(), txt_snh_nov.Text) == false)
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
                    if (ComparaSenha(SenhasAnt, txt_snh_nov.Text) == false)
                    {
                        return;
                    }

                    NovasSenhas = PreencheSenhas(SenhasAnt, NovasSenhas);
                }

                NovasSenhas = PreencheSenhas(txt_snh_nov.Text, NovasSenhas);
            }

            Usuario Senha = new Usuario();
            Senha.USR_ID = UsuId;
            Senha.USR_SNH = txt_snh_nov.Text;
            if (!String.IsNullOrEmpty(NovasSenhas))
            {
                Senha.USR_SNH_ANE = NovasSenhas;
            }
            Senha.USR_DAT_ATL_SNH = DateTime.Now;
            Senha.AtualizaSenha = true;

            Msg.Text = Senha.Alterar();
        }
        else
        {
            Msg.Text = "A senha Atual está incorreta.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh_atu.focus();";
            Msg.Focus();
            return;
        }
        tblLogin.Dispose();
        dtLogin.Dispose();
        Dispose();

        if (Msg.Text == "")
        {
            if (ViaLogin == true)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Msg.Text = "Senha alterada!";
            }
        }

    }

    protected bool ComparaSenha(string SenhaAntiga, string SenhaNova)
    {
        if (SenhaAntiga == SenhaNova)
        {
            Msg.Text = "A senha não pode ser igual as ultimas " + QtdeNaoRepetir + " senhas cadastradas.";
            Msg.NavigateUrl = "JavaScript:document.all.txt_snh_nov.focus();";
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

    protected void Limpar()
    {
        txt_snh_atu.Text = "";
        txt_snh_nov.Text = "";
        txt_snh_conf.Text = "";
        txt_snh_atu.Focus();

    }

}
