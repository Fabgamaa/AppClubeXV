using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using FWBDS;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool LogarRede = Convert.ToBoolean(ConfigurationManager.AppSettings["LogarRede"]);
        //bool LogarRede = true;
        int TempoExpiraSenha = Convert.ToInt16(ConfigurationManager.AppSettings["TempoExpiraSenha"]);
        string sUsuRede = "";
        string sMsg = "";

        if (Convert.ToInt16(Request["Msg"]) == 1)
        {
            Msg.Text = "A Sess?o expirou. Efetue o logon novamente";
        }

        //Logar no Sistema verificando usu?rio logado no Windows
        #region LogarRede

        if (LogarRede == true)
        {
            sUsuRede = Request.ServerVariables["REMOTE_USER"];
            int pos = sUsuRede.IndexOf(@"\", 0);
            sUsuRede = sUsuRede.Substring(pos + 1, sUsuRede.Length - pos - 1);
            Usuario Login = new Usuario();

            Login.USR_COD = sUsuRede;
            DataSet dtLogin = Login.ConsultarLogin();

            DataTable tblLogin = dtLogin.Tables[0];
            if (tblLogin.Rows.Count > 0)
            {
                DataRow drCurrent = tblLogin.Rows[0];
                DateTime dtExpiracao;
                if (!String.IsNullOrEmpty(drCurrent["USR_DAT_EXI"].ToString()))
                {
                    dtExpiracao = Convert.ToDateTime(drCurrent["USR_DAT_EXI"].ToString());
                }
                else
                {
                    dtExpiracao = DateTime.Now.AddDays(1);
                }
                if (Convert.ToDateTime(dtExpiracao.ToString("dd/MM/yyyy")) <= Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    Msg.Text = "N?o foi poss?vel efetuar o login. O Tempo de uso desse usu?rio expirou.";
                }
                else
                {

                    Session["USR"] = drCurrent["USR_COD"].ToString();
                    Session["USR_ID"] = drCurrent["USR_ID"].ToString();
                    Session["PFL_ID"] = drCurrent["USR_PFL_ID"].ToString();
                    Session["PFL"] = drCurrent["PFL_DES"].ToString();

                    Acesso LogAcesso = new Acesso();

                    LogAcesso.ACS_IP = Context.Request.UserHostAddress;
                    LogAcesso.ACS_USR_ID = Convert.ToInt32(drCurrent["USR_ID"].ToString());
                    LogAcesso.ACS_USR_COD = sUsuRede;
                    LogAcesso.ACS_DAT_INI = DateTime.Now;
                    LogAcesso.ACS_SCS = 1;
                    sMsg = LogAcesso.Inserir();

                    if (sMsg.Substring(0, 1) == "E")
                    {
                        Msg.Text = Msg.Text + "<br>" + sMsg;
                    }
                    else
                    {
                        Session["ACS_ID"] = sMsg;
                    }

                    DateTime dtAtlSenha = DateTime.Now;
                    if (!String.IsNullOrEmpty(drCurrent["USR_DAT_ATL_SNH"].ToString()))
                    {
                        dtAtlSenha = Convert.ToDateTime(drCurrent["USR_DAT_ATL_SNH"].ToString()).AddDays(TempoExpiraSenha);
                    }

                    Response.Redirect("Home.aspx");
                }

            }
            else
            {
                string sMsgErro = "";

                Acesso LogAcesso = new Acesso();

                LogAcesso.ACS_IP = Context.Request.UserHostAddress;
                LogAcesso.ACS_USR_COD = sUsuRede;
                LogAcesso.ACS_USR_SNH = "";
                LogAcesso.ACS_DAT_INI = DateTime.Now;
                LogAcesso.ACS_SCS = 0;
                sMsg = LogAcesso.Inserir();

                if (sMsgErro != "")
                {
                    Msg.Text = sMsgErro;
                }
                else
                {
                    Msg.Text = "N?o foi poss?vel efetuar o login. Por favor, tente novamente.";
                }
                if (sMsg.Substring(0, 1) == "E")
                {
                    Msg.Text = Msg.Text + "<br>" + sMsg;
                }
            }
            tblLogin.Dispose();
            dtLogin.Dispose();
            Dispose();

        }
        #endregion

    }

    protected void bt_log_Click(object sender, EventArgs e)
    {
        string sMsg = "";
        int TentativasIncorretas = Convert.ToInt16(ConfigurationManager.AppSettings["TentativasIncorretas"]);
        int TempoExpiraSenha = Convert.ToInt16(ConfigurationManager.AppSettings["TempoExpiraSenha"]);

        ObLogin.Text = "";
        ObSenha.Text = "";
        if (txt_nom_usr.Text == "")
        {
            ObLogin.Text = "*";
        }

        if (txt_snh.Text == "")
        {
            ObSenha.Text = "*";
        }

        if (txt_nom_usr.Text != "" && txt_snh.Text != "")
        {
            Usuario Login = new Usuario();

            Login.USR_COD = txt_nom_usr.Text;
            Login.USR_SNH = txt_snh.Text;
            DataSet dtLogin = Login.ConsultarLogin();

            DataTable tblLogin = dtLogin.Tables[0];
            if (tblLogin.Rows.Count > 0)
            {
                DataRow drCurrent = tblLogin.Rows[0];

                if (Convert.ToInt16(drCurrent["USR_NUM_TTT"].ToString()) == TentativasIncorretas)
                {
                    Msg.Text = "N?o foi poss?vel efetuar o login. Esse usu?rio est? bloqueado por exceder o limite de tentativas incorretas.";
                }
                else
                {
                    if (Convert.ToInt16(drCurrent["USR_NUM_TTT"].ToString()) >= 0)
                    {
                        Usuario Usu = new Usuario();
                        Usu.USR_ID = Convert.ToInt32(drCurrent["USR_ID"].ToString());
                        Usu.USR_NUM_TTT = 0;
                        Usu.AtualizaTentativas = true;
                        sMsg = Usu.Alterar();
                        if (!String.IsNullOrEmpty(sMsg))
                        {
                            Msg.Text = sMsg;
                        }

                    }
                    DateTime dtExpiracao;
                    if (!String.IsNullOrEmpty(drCurrent["USR_DAT_EXI"].ToString()))
                    {
                        dtExpiracao = Convert.ToDateTime(drCurrent["USR_DAT_EXI"].ToString());
                    }
                    else
                    {
                        dtExpiracao = DateTime.Now.AddDays(1);
                    }
                    if (Convert.ToDateTime(dtExpiracao.ToString("dd/MM/yyyy")) <= Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                    {
                        Msg.Text = "N?o foi poss?vel efetuar o login. O Tempo de uso desse usu?rio expirou.";
                    }
                    else
                    {

                        Session["USR"] = drCurrent["USR_COD"].ToString();
                        Session["USR_ID"] = drCurrent["USR_ID"].ToString();
                        Session["PFL_ID"] = drCurrent["USR_PFL_ID"].ToString();
                        Session["PFL"] = drCurrent["PFL_DES"].ToString();
                        Session["PFL_URL_INI"] = drCurrent["PFL_URL_INI"].ToString();

                        Acesso LogAcesso = new Acesso();

                        LogAcesso.ACS_IP = Context.Request.UserHostAddress;
                        LogAcesso.ACS_USR_ID = Convert.ToInt32(drCurrent["USR_ID"].ToString());
                        LogAcesso.ACS_USR_COD = txt_nom_usr.Text;
                        LogAcesso.ACS_DAT_INI = DateTime.Now;
                        LogAcesso.ACS_SCS = 1;
                        sMsg = LogAcesso.Inserir();

                        if (sMsg.Substring(0, 1) == "E")
                        {
                            Msg.Text = Msg.Text + "<br>" + sMsg;
                        }
                        else
                        {
                            Session["ACS_ID"] = sMsg;
                        }

                        if (TempoExpiraSenha != 0)
                        {
                            DateTime dtAtlSenha = DateTime.Now;
                            if (!String.IsNullOrEmpty(drCurrent["USR_DAT_ATL_SNH"].ToString()))
                            {
                                dtAtlSenha = Convert.ToDateTime(drCurrent["USR_DAT_ATL_SNH"].ToString()).AddDays(TempoExpiraSenha);
                            }

                            if (Convert.ToDateTime(dtAtlSenha.ToString("dd/MM/yyyy")) <= Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                            {
                                Response.Redirect("AlterarSenha.aspx?Msg=Expira");
                            }
                            else
                            {
                                Response.Redirect("Home.aspx");
                            }
                        }
                            else
                        {
                            Response.Redirect("Home.aspx");
                        }
                   }
                }
            }
            else
            {
                string sMsgErro = "";

                Usuario Login2 = new Usuario();

                Login2.USR_COD = txt_nom_usr.Text;
                DataSet dtLogin2 = Login2.ConsultarLogin();

                DataTable tblLogin2 = dtLogin2.Tables[0];
                if (tblLogin2.Rows.Count > 0)
                {
                    DataRow drCurrent2 = tblLogin2.Rows[0];

                    if (Convert.ToInt16(drCurrent2["USR_NUM_TTT"].ToString()) == TentativasIncorretas)
                    {
                        sMsgErro = "N?o foi poss?vel efetuar o login. Esse usu?rio est? bloqueado por exceder o limite de tentativas incorretas.";
                    }
                    else
                    {
                        if (Convert.ToInt16(drCurrent2["USR_NUM_TTT"].ToString()) >= 0)
                        {

                            Usuario Usu2 = new Usuario();
                            Usu2.USR_ID = Convert.ToInt32(drCurrent2["USR_ID"].ToString());
                            Usu2.USR_NUM_TTT = Convert.ToInt16(drCurrent2["USR_NUM_TTT"].ToString()) + 1;
                            Usu2.AtualizaTentativas = true;
                            sMsg = Usu2.Alterar();
                            if (!String.IsNullOrEmpty(sMsg))
                            {
                                Msg.Text = sMsg;
                            }

                        }
                    }

                }

                tblLogin2.Dispose();
                dtLogin2.Dispose();


                Acesso LogAcesso = new Acesso();

                LogAcesso.ACS_IP = Context.Request.UserHostAddress;
                LogAcesso.ACS_USR_COD = txt_nom_usr.Text;
                LogAcesso.ACS_USR_SNH = txt_snh.Text;
                LogAcesso.ACS_DAT_INI = DateTime.Now;
                LogAcesso.ACS_SCS = 0;
                sMsg = LogAcesso.Inserir();

                if (sMsgErro != "")
                {
                    Msg.Text = sMsgErro;
                }
                else
                {
                    Msg.Text = "N?o foi poss?vel efetuar o login. Por favor, tente novamente.";
                }
                if (sMsg.Substring(0, 1) == "E")
                {
                    Msg.Text = Msg.Text + "<br>" + sMsg;
                }
            }
            tblLogin.Dispose();
            dtLogin.Dispose();
            Dispose();
        }

    }

}
