using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace FWBDS
{
    public class Email
    {
        #region Propriedades

        private int? _EML_ID;
        private int? _EML_DST_ID;
        private string _EML_OUT;
        private string _EML_TIT;
        private string _EML_ASS;
        private int? _EML_USR_INC_ID;
        private int? _EML_USR_ALT_ID;

        private string _EML_ENV_END_EML;

        private DateTime? _EML_DAT_INI;
        private DateTime? _EML_DAT_FIM;

        public int? EML_ID
        {
            get { return _EML_ID; }
            set { _EML_ID = value; }
        }
        public int? EML_DST_ID
        {
            get { return _EML_DST_ID; }
            set { _EML_DST_ID = value; }
        }
        public string EML_OUT
        {
            get { return _EML_OUT; }
            set { _EML_OUT = value.ToUpper(); }
        }
        public string EML_TIT
        {
            get { return _EML_TIT; }
            set { _EML_TIT = value.ToUpper(); }
        }
        public string EML_ASS
        {
            get { return _EML_ASS; }
            set { _EML_ASS = value.ToUpper(); }
        }
        public int? EML_USR_INC_ID
        {
            get { return _EML_USR_INC_ID; }
            set { _EML_USR_INC_ID = value; }
        }
        public int? EML_USR_ALT_ID
        {
            get { return _EML_USR_ALT_ID; }
            set { _EML_USR_ALT_ID = value; }
        }

        public string EML_ENV_END_EML
        {
            get { return _EML_ENV_END_EML; }
            set { _EML_ENV_END_EML = value; }
        }

        public DateTime? EML_DAT_INI
        {
            get { return _EML_DAT_INI; }
            set { _EML_DAT_INI = value; }
        }
        public DateTime? EML_DAT_FIM
        {
            get { return _EML_DAT_FIM; }
            set { _EML_DAT_FIM = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO EML ";
            sSQL = sSQL + " (EML_DST_ID, EML_OUT, EML_TIT, EML_ASS, EML_USR_INC_ID, EML_TMS_ATL)";
            sSQL = sSQL + " VALUES (" + EML_DST_ID;
            sSQL = sSQL + ",'" + EML_OUT.Replace("'", "''") + "'";
            sSQL = sSQL + ",'" + EML_TIT.Replace("'", "''") + "'";
            sSQL = sSQL + ",'" + EML_ASS.Replace("'", "''") + "'";
            if (!String.IsNullOrEmpty(EML_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + EML_USR_INC_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + ",GetDate())";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE EML ";
            sSQL = sSQL + " SET EML_DST_ID = " + EML_DST_ID;
            sSQL = sSQL + ", EML_OUT = '" + EML_OUT.Replace("'", "''") + "'";
            sSQL = sSQL + ", EML_TIT = '" + EML_TIT.Replace("'", "''") + "'";
            sSQL = sSQL + ", EML_ASS = '" + EML_ASS.Replace("'", "''") + "'";

            if (!String.IsNullOrEmpty(EML_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + ", EML_USR_ALT_ID = " + EML_USR_ALT_ID;
            }
            sSQL = sSQL + ", EML_TMS_ATL = GetDate() ";
            sSQL = sSQL + " WHERE EML_ID = " + EML_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM EML ";
            sSQL = sSQL + " WHERE EML_ID = " + EML_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT EML_ID, EML_DST_ID, EML_OUT, EML_TIT, EML_ASS, EML_TMS_ATL ";

            sSQL = sSQL + " FROM EML ";

            if (!String.IsNullOrEmpty(Convert.ToString(EML_DST_ID)))
            {
                sCond = sCond + " EML_DST_ID = " + EML_DST_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(EML_OUT))
            {
                sCond = sCond + " EML_OUT like '%" + EML_OUT.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(EML_TIT))
            {
                sCond = sCond + " EML_TIT like '%" + EML_TIT.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EML_DAT_INI)))
            {
                sCond = sCond + " EML_TMS_ATL >= Convert(datetime, '" + EML_DAT_INI + "', 103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EML_DAT_FIM)))
            {
                sCond = sCond + " EML_TMS_ATL <= Convert(datetime, '" + EML_DAT_FIM + "', 103) + 9.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EML_ID)))
            {
                sCond = sCond + " EML_ID = " + EML_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY EML_TMS_ATL ";
            return dbConn.ExecutarRetorno(sSQL);

        }

        public string InserirEnvio(int EML_ID)
        {
            string sSQL = "INSERT INTO EML_ENV ";
            sSQL = sSQL + " (EML_ENV_EML_ID, EML_ENV_END_EML, EML_ENV_USR_INC_ID, EML_ENV_TMS_ATL)";
            sSQL = sSQL + " VALUES (" + EML_ID;
            sSQL = sSQL + ",'" + EML_ENV_END_EML.Replace("'", "''") + "'";
            if (!String.IsNullOrEmpty(EML_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + EML_USR_INC_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + ",GetDate())";

            return dbConn.ExecutarInserir(sSQL);
        }

        public DataSet ConsultarEnvio()
        {
            string sCond = "";
            string sSQL = "SELECT EML_ID, EML_DST_ID, EML_OUT, EML_TIT, EML_ASS, EML_TMS_ATL, EML_ENV_END_EML, ";
            sSQL = sSQL + " CASE EML_DST_ID ";
            sSQL = sSQL + "    WHEN 1 THEN 'INDICADORES' ";
            sSQL = sSQL + "    WHEN 2 THEN 'PARCEIROS' ";
            sSQL = sSQL + "    WHEN 3 THEN 'INDICADORES e PARCEIROS' ";
            sSQL = sSQL + "    WHEN 4 THEN 'OUTROS' ";
            sSQL = sSQL + "    ELSE '' ";
            sSQL = sSQL + " END AS EML_DST_DES ";

            sSQL = sSQL + " FROM EML ";
            sSQL = sSQL + " INNER JOIN EML_ENV ON EML.EML_ID = EML_ENV.EML_ENV_EML_ID ";

            if (!String.IsNullOrEmpty(Convert.ToString(EML_DST_ID)))
            {
                sCond = sCond + " EML_DST_ID = " + EML_DST_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(EML_OUT))
            {
                sCond = sCond + " EML_OUT like '%" + EML_OUT.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(EML_TIT))
            {
                sCond = sCond + " EML_TIT like '%" + EML_TIT.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EML_DAT_INI)))
            {
                sCond = sCond + " EML_TMS_ATL >= Convert(datetime, '" + EML_DAT_INI + "', 103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EML_DAT_FIM)))
            {
                sCond = sCond + " EML_TMS_ATL <= Convert(datetime, '" + EML_DAT_FIM + "', 103) + 9.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EML_ID)))
            {
                sCond = sCond + " EML_ID = " + EML_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY EML_TMS_ATL ";
            return dbConn.ExecutarRetorno(sSQL);

        }

        public string ProcessaEnvio(int iEML_ID, string sEML_TIT, string sEML_ASS, string sListaEND_EML)
        {
            string sMsg = "";          
            
            string sRemetente = ConfigurationManager.AppSettings["EnderecoSMTP"];
            string sListaDestinatario = "";
            string sListaCopia = "";
            string sListaCopiaOculta = "";
            bool bFormatoHTML = true;
            string sTitulo = sEML_TIT;
            string sAssunto = sEML_ASS;
            string sListaCaminhoAnexo = "";
            string sServer = ConfigurationManager.AppSettings["ServidorSMTP"];
            string sUsuario = ConfigurationManager.AppSettings["UsuarioSMTP"];
            string sSenha = ConfigurationManager.AppSettings["SenhaSMTP"];
            bool bSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["SSLSMTP"]);
            int iPortaSmtp = Convert.ToInt32(ConfigurationManager.AppSettings["PortaSMTP"]);
            
            string[] aListaEND_EML = sListaEND_EML.Split(';');

            foreach (string sEND_EML in aListaEND_EML)
            {
                if (sEND_EML != "")
                {
                    EML_ENV_END_EML = sEND_EML;
                    sMsg = InserirEnvio(Convert.ToInt32(EML_ID));

                    if (sMsg.Substring(0, 1) == "E")
                    {
                        return sMsg;
                    }

                    sListaDestinatario = sEND_EML;

                    EnviarEmail(sRemetente, sListaDestinatario, sListaCopia, sListaCopiaOculta, bFormatoHTML, sTitulo, sAssunto, sListaCaminhoAnexo, sServer, bSSL, iPortaSmtp, sUsuario, sSenha);
                }

            }
            return sMsg;
        }

        public void EnviarEmail(string sRemetente, string sListaDestinatario, string sListaCopia, string sListaCopiaOculta, bool bFormatoHTML, string sTitulo, string sAssunto, string sListaCaminhoAnexo, string sServer, bool bSSL, int iPortaSmtp, string sUsuario, string sSenha)
        {
            MailMessage objEmail = new MailMessage();

            //Remetente do e-mail.
            objEmail.From = new MailAddress(sRemetente);

            //Destinatários do e-mail.
            string[] sDestinatarios = sListaDestinatario.Split(';');
            foreach (string sDestinatario in sDestinatarios)
            {
                if (sDestinatario != "")
                {
                    objEmail.To.Add(sDestinatario);
                }
            }

            //Enviar cópia para.
            string[] sCopias = sListaCopia.Split(';');
            foreach (string sCopia in sCopias)
            {
                if (sCopia != "")
                {
                    objEmail.To.Add(sCopia);
                }
            }

            //Enviar cópia oculta para.
            string[] sCopiasOculta = sListaCopiaOculta.Split(';');
            foreach (string sCopiaOculta in sCopiasOculta)
            {
                if (sCopiaOculta != "")
                {
                    objEmail.Bcc.Add(sCopiaOculta);
                }
            }

            //Define a prioridade do e-mail.
            objEmail.Priority = MailPriority.High;

            //Formato do e-mail HTML
            objEmail.IsBodyHtml = bFormatoHTML;

            //Título do e-mail.
            objEmail.Subject = sTitulo;

            //Assunto do e-mail.
            objEmail.Body = sAssunto;

            //Anexa arquivos.
            string[] sCaminhosAnexos = sListaCaminhoAnexo.Split(';');
            foreach (string sCaminhoAnexo in sCaminhosAnexos)
            {
                if (sCaminhoAnexo != "")
                {
                    Attachment aArquivo = new Attachment(sCaminhoAnexo);
                    objEmail.Attachments.Add(aArquivo);
                }
            }

            //Para caracteres especiais charset para "ISO-8859-1"
            objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

            //Cria objeto com os dados do SMTP
            SmtpClient objSmtp = new SmtpClient();

            //Servidor de E-mail
            objSmtp.Host = sServer;
            //Envio pela Rede em vez de pasta em disco
            objSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //Utilizar SSL
            objSmtp.EnableSsl = bSSL;
            //Porta de comunicação
            objSmtp.Port = iPortaSmtp;
            //Timeout em milisegundos (1000 = 1 seg)
            objSmtp.Timeout = 10000;
            //Não Utilizar crediciais default
            objSmtp.UseDefaultCredentials = false;

            if (sUsuario != "" && sSenha != "")
            {
                objSmtp.Credentials = new NetworkCredential(sUsuario, sSenha); 
            }

            objSmtp.Send(objEmail);
            objEmail.Dispose();
        }

        #endregion

        public void EnviarCalendario(string sRemetente, string sListaDestinatario, string sListaCopia, string sListaCopiaOculta, bool bFormatoHTML, string sTitulo, string sAssunto, DateTime dtInicio, DateTime dtTermino, string sLocal, string sListaCaminhoAnexo, string sServer, bool bSSL, int iPortaSmtp, string sUsuario, string sSenha)
        {
            MailMessage objEmail = new MailMessage();

            //Remetente do e-mail.
            objEmail.From = new MailAddress(sRemetente);

            //Destinatários do e-mail.
            string[] sDestinatarios = sListaDestinatario.Split(';');
            foreach (string sDestinatario in sDestinatarios)
            {
                if (sDestinatario != "")
                {
                    objEmail.To.Add(sDestinatario);
                }
            }

            //Enviar cópia para.
            string[] sCopias = sListaCopia.Split(';');
            foreach (string sCopia in sCopias)
            {
                if (sCopia != "")
                {
                    objEmail.To.Add(sCopia);
                }
            }

            //Enviar cópia oculta para.
            string[] sCopiasOculta = sListaCopiaOculta.Split(';');
            foreach (string sCopiaOculta in sCopiasOculta)
            {
                if (sCopiaOculta != "")
                {
                    objEmail.Bcc.Add(sCopiaOculta);
                }
            }

            //Define a prioridade do e-mail.
            objEmail.Priority = MailPriority.High;

            //Formato do e-mail HTML
            objEmail.IsBodyHtml = bFormatoHTML;

            //Título do e-mail.
            objEmail.Subject = sTitulo;

            //Assunto do e-mail.
            objEmail.Body = sAssunto;

            //Anexa arquivos.
            string[] sCaminhosAnexos = sListaCaminhoAnexo.Split(';');
            foreach (string sCaminhoAnexo in sCaminhosAnexos)
            {
                if (sCaminhoAnexo != "")
                {
                    Attachment aArquivo = new Attachment(sCaminhoAnexo);
                    objEmail.Attachments.Add(aArquivo);
                }
            }

            //Para caracteres especiais charset para "ISO-8859-1"
            objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

            //Cria objeto com os dados do SMTP
            SmtpClient objSmtp = new SmtpClient();

            //Servidor de E-mail
            objSmtp.Host = sServer;
            //Envio pela Rede em vez de pasta em disco
            objSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //Utilizar SSL
            objSmtp.EnableSsl = bSSL;
            //Porta de comunicação
            objSmtp.Port = iPortaSmtp;
            //Timeout em milisegundos (1000 = 1 seg)
            objSmtp.Timeout = 10000;
            //Não Utilizar crediciais default
            objSmtp.UseDefaultCredentials = false;

            if (sUsuario != "" && sSenha != "")
            {
                objSmtp.Credentials = new NetworkCredential(sUsuario, sSenha);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN:VCALENDAR");
            sb.AppendLine("PRODID:-//FW");
            sb.AppendLine("METHOD:REQUEST");
            sb.AppendLine("BEGIN:VEVENT");
            sb.AppendLine(string.Format("DTSTART:{0:yyyyMMddTHHmmssZ}", dtInicio.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z")));
            sb.AppendLine(string.Format("DTSTAMP:{0:yyyyMMddTHHmmssZ}", DateTime.UtcNow));
            sb.AppendLine(string.Format("DTEND:{0:yyyyMMddTHHmmssZ}", dtTermino.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z")));
            sb.AppendLine("LOCATION: " + sLocal);
            sb.AppendLine(string.Format("UID:{0}", Guid.NewGuid()));
            sb.AppendLine(string.Format("DESCRIPTION:{0}", objEmail.Body));
            sb.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", objEmail.Body));
            sb.AppendLine(string.Format("SUMMARY:{0}", objEmail.Subject));
            sb.AppendLine(string.Format("ORGANIZER:MAILTO:{0}", objEmail.From.Address));
            sb.AppendLine(string.Format("ATTENDEE;CN=\"{0}\";RSVP=TRUE:mailto:{1}", objEmail.To[0].DisplayName, objEmail.To[0].Address));
            sb.AppendLine("BEGIN:VALARM");
            sb.AppendLine("TRIGGER:-PT15M");
            sb.AppendLine("ACTION:DISPLAY");
            sb.AppendLine("DESCRIPTION:Reminder");
            sb.AppendLine("END:VALARM");
            sb.AppendLine("END:VEVENT");
            sb.AppendLine("END:VCALENDAR");

            ContentType ct = new ContentType("text/calendar");
            ct.Parameters.Add("method", "REQUEST");
            AlternateView av = AlternateView.CreateAlternateViewFromString(sb.ToString(), ct);
            objEmail.AlternateViews.Add(av);

            objSmtp.Send(objEmail);
            objEmail.Dispose();
        }
    }
}
