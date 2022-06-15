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

public partial class Endereco : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregaPais();
            CarregaEstado("SÃO PAULO");
            cbo_sta.SelectedValue = cbo_sta.Items.FindByText("SÃO PAULO").Value;
            CarregaCidade("SÃO PAULO");
            cbo_cid.SelectedValue = cbo_cid.Items.FindByText("SÃO PAULO").Value;

        }
    }

    protected void txt_cep_OnTextChanged(object sender, EventArgs e)
    {
        if (txt_cep.Text.Length == 8)
        {
            CarregaCEP();
        }
    }

    protected void cbo_pas_SelectedIndexChanged(object sender, EventArgs e)
    {
        CarregaEstado(cbo_pas.SelectedItem.Text);
    }

    protected void cbo_sta_SelectedIndexChanged(object sender, EventArgs e)
    {
        CarregaCidade(cbo_sta.SelectedItem.Text);
    }
 
    protected void CarregaCEP()
    {
            CEP CEP = new CEP();
            CEP.CEP_COD = txt_cep.Text;
            DataSet dsCEP = CEP.Consultar();
            
            DataTable dtCEP = dsCEP.Tables[0];
            if (dtCEP.Rows.Count > 0)
            {
                DataRow drCep = dtCEP.Rows[0];
                txt_edr.Text = drCep["CEP_TIP_LGO"].ToString() + " " + drCep["CEP_NOM_LGO"].ToString();
                txt_brr.Text = drCep["CEP_BRR"].ToString();
                CarregaPais();
                CarregaEstado(drCep["CEP_PAS"].ToString());
                cbo_sta.SelectedValue = cbo_sta.Items.FindByText(drCep["CEP_STA"].ToString()).Value;
                CarregaCidade(drCep["CEP_STA"].ToString());
                try
                {
                    cbo_cid.SelectedValue = cbo_cid.Items.FindByText(drCep["CEP_CID"].ToString()).Value;
                }
                catch
                {
                    //Msg.Text = "<br> Cidade não localizada (" + drCep["CEP_CID"].ToString() + "). ";
                    Response.Write("<script language=\"javascript\">alert('Cidade não localizada (" + drCep["CEP_CID"].ToString() + "). ');document.all.txt_cep.focus();</script>");
                    //Response.Write("Cidade não localizada (" + drCep["CEP_CID"].ToString() + "). "
                    //Msg.NavigateUrl = "JavaScript:document.all.txt_cep.focus();";
                    //Msg.Focus();
                    return;
                }
            }

            dtCEP.Dispose();
            Dispose();

    }

    public void CarregaPais()
    {
        Pais Pais = new Pais();
        DataSet dsPais = Pais.Consultar();

        cbo_pas.DataTextField = "PAS_NOM";
        cbo_pas.DataValueField = "PAS_ID";

        cbo_pas.DataSource = dsPais;
        cbo_pas.DataBind();

        dsPais.Dispose();
        Dispose();

    }

    public void CarregaEstado(string sPais)
    {

        Estado Estado = new Estado();
        Estado.PAS_NOM = sPais;
        DataSet dsEstado = Estado.Consultar();

        cbo_sta.DataTextField = "STA_NOM";
        cbo_sta.DataValueField = "STA_ID";

        cbo_sta.DataSource = dsEstado;
        cbo_sta.DataBind();

        dsEstado.Dispose();
        Dispose();

    }

    public void CarregaCidade(string sEstado)
    {
        Cidade Cidade = new Cidade();
        Cidade.STA_NOM = sEstado;
        DataSet dsCidade = Cidade.Consultar();

        cbo_cid.DataTextField = "CID_NOM";
        cbo_cid.DataValueField = "CID_ID";

        cbo_cid.DataSource = dsCidade;
        cbo_cid.DataBind();

        dsCidade.Dispose();
        Dispose();

    }

}
