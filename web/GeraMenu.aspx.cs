using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



public partial class GeraMenu : System.Web.UI.Page
{
    public int i = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            MenuItem submi = new MenuItem("Cadastro", "[Cadastro]");
            submi.Selected = true;
            mnu.Items.Add(submi);
            
            MenuItem mi = mnu.SelectedItem;
            submi = new MenuItem("Cliente", "Cliente.aspx");
            submi.ToolTip = "Cliente.aspx";
            mi.ChildItems.Add(submi);
            
            mi = mnu.SelectedItem;
            submi = new MenuItem("Segurança", "[Segurança]");
            submi.Selected = true;
            mi.ChildItems.Add(submi);

            mi = mnu.SelectedItem;
            submi = new MenuItem("Perfil", "Perfil.aspx");
            submi.ToolTip = "Perfil.aspx";
            mi.ChildItems.Add(submi);

            mi = mnu.SelectedItem;
            submi = new MenuItem("Usuário", "Usuario.aspx");
            submi.ToolTip = "Usuario.aspx";
            mi.ChildItems.Add(submi);

            submi = new MenuItem("Lançamento", "Lancamento.aspx");
            submi.ToolTip = "Lancamento.aspx";
            mnu.Items.Add(submi);

            submi = new MenuItem("Relatório", "[Relatório]");
            submi.Selected = true;
            mnu.Items.Add(submi);

            mi = mnu.SelectedItem;
            submi = new MenuItem("Painel de Controle", "RelatorioPainelControle.aspx");
            submi.ToolTip = "RelatorioPainelControle.aspx";
            mi.ChildItems.Add(submi);

            txt_app.Text = txt_app.Text.ToUpper();
        }
    }

    protected void btCarregar_Click(object sender, EventArgs e)
    {

        string sConnectionString = "";
        sConnectionString = "Data Source=" + txt_srv.Text + ";";
        sConnectionString += "Initial Catalog=" + txt_bco.Text + ";";
        sConnectionString += "User ID=" + txt_usr.Text + ";";
        sConnectionString += "Password=" + txt_snh.Text + ";";

        String sSelectCommand = "SELECT * FROM MNU ORDER BY MNU_ORD";
        SqlDataAdapter sdaPro = new SqlDataAdapter(sSelectCommand, sConnectionString);

        DataSet dsPro = new DataSet();
        sdaPro.Fill(dsPro);

        CarregaMNU(dsPro);

        dsPro.Dispose();
        sdaPro.Dispose();
        Dispose();

    }

    protected void mnu_Click(object sender, EventArgs e)
    {
        txt_tit.Text = mnu.SelectedItem.Text;
        txt_pag.Text = mnu.SelectedItem.Value;
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        mnu.SelectedItem.Text = txt_tit.Text;

        if (txt_pag.Text == "")
        {
            txt_pag.Text = "[" + txt_tit.Text + "]";
        }

        mnu.SelectedItem.Value = txt_pag.Text;
        mnu.SelectedItem.ToolTip = txt_pag.Text;
    }

    protected void btExcluir_Click(object sender, EventArgs e)
    {
        //Exclui Menu
        if (mnu.SelectedItem.Depth == 0)
        {
            mnu.Items.Remove(mnu.SelectedItem);
        }
        else
        //Exclui Sub Menu
        {
            mnu.SelectedItem.Parent.ChildItems.Remove(mnu.SelectedItem);
        }

        txt_tit.Text = "";
        txt_pag.Text = "";
    }

    protected void btNovoMenu_Click(object sender, EventArgs e)
    {
        MenuItem mi = new MenuItem("Novo_Menu", "[Novo_Menu]");
        mi.Selected = true;
        mnu.Items.Add(mi);

        mnu_Click(sender, e);
    }

    protected void btNovoSubMenu_Click(object sender, EventArgs e)
    {
        MenuItem mi = mnu.SelectedItem;
        MenuItem submi = new MenuItem("Novo_Sub_Menu", "[Novo_Sub_Menu]");
        submi.Selected = true;
        mi.ChildItems.Add(submi);

        mnu_Click(sender, e);
    }

    protected void btGerar_Click(object sender, EventArgs e)
    {
        pre_sql.InnerText = "";

        pre_sql.InnerText += "SET IDENTITY_INSERT MNU ON\n";
        pre_sql.InnerText += "\n";

        //Pai Regedor para os Filhos
        int iPai = 0;
        //Ordem para os Filhos
        int iOrd = 0;
        i = 0;
        foreach (MenuItem mi in mnu.Items)
        {
            iOrd = iOrd + 1;
            string sOrd = iOrd.ToString().PadLeft(2, '0');

            GeraMNU(mi, iPai, sOrd);
        }

        pre_sql.InnerText += "SET IDENTITY_INSERT MNU OFF\n";
        pre_sql.InnerText += "\n";


        pre_sql.InnerText += "SET IDENTITY_INSERT MNU_FHO ON\n";
        pre_sql.InnerText += "\n";

        i = 0;
        foreach (MenuItem mi in mnu.Items)
        {
            GeraMNUFHO(mi);
        }

        //Gera Menus Filhos Fixos
        i = i + 1;
        InsereMNUFHO(i, "AlterarSenha.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "Banner.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "BemVindo.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "Default.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "ErroGenerico.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "Finaliza.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "FWMNUSUB.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "Home.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "CadastroPerfil.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "CadastroPermissoes.aspx", true);
        i = i + 1;
        InsereMNUFHO(i, "CadastroUsuario.aspx", true);
        
        pre_sql.InnerText += "SET IDENTITY_INSERT MNU_FHO OFF\n";
        pre_sql.InnerText += "\n";

        pre_sql.InnerText += "-- CRIA PFL ADMINISTRADOR\n";
        pre_sql.InnerText += "SET IDENTITY_INSERT PFL ON\n";
        pre_sql.InnerText += "INSERT INTO PFL\n";
        pre_sql.InnerText += "(PFL_ID, PFL_DES, PFL_STS, PFL_STM, PFL_USR_INC_ID, PFL_TMS_ATL)\n";
        pre_sql.InnerText += "VALUES\n";
        pre_sql.InnerText += "(1,'ADMINISTRADOR', 1, 1, 1, GETDATE())\n";
        pre_sql.InnerText += "SET IDENTITY_INSERT PFL OFF\n";
        pre_sql.InnerText += "\n";

        pre_sql.InnerText += "-- CRIA USR ADMINISTRADOR\n";
        pre_sql.InnerText += "SET IDENTITY_INSERT USR ON\n";
        pre_sql.InnerText += "INSERT INTO USR\n";
        pre_sql.InnerText += "(USR_ID, USR_PFL_ID, USR_COD, USR_SNH, USR_NOM, USR_STS, USR_NUM_TTT, USR_STM, USR_USR_INC_ID, USR_TMS_ATL)\n";
        pre_sql.InnerText += "VALUES\n";
        pre_sql.InnerText += "(1, 1, 'ADMINISTRADOR', 'BRANCO', 'ADMINISTRADOR', 1, 1, 1, 1, GETDATE())\n";
        pre_sql.InnerText += "SET IDENTITY_INSERT USR OFF\n";
        pre_sql.InnerText += "\n";

        pre_sql.InnerText += "-- CRIA PFL_MNU ADMINISTRADOR\n";
        pre_sql.InnerText += "INSERT INTO PFL_MNU\n";
        pre_sql.InnerText += "(PFL_MNU_PFL_ID, PFL_MNU_MNU_ID, PFL_MNU_CSU, PFL_MNU_ALT, PFL_MNU_NOO, PFL_MNU_EXL, PFL_MNU_USR_INC_ID, PFL_MNU_TMS_ATL)\n";
        pre_sql.InnerText += "SELECT PFL_ID, MNU_ID, 1, 1, 1, 1, 1, GETDATE()\n";
        pre_sql.InnerText += "FROM PFL,MNU\n";
        pre_sql.InnerText += "\n";

    }

    protected void CarregaMNU(DataSet dsPro)
    {
        mnu.Items.Clear();

        int i = 0;
        foreach (DataRow drPro in dsPro.Tables[0].Rows)
        {
            //Novo Sub Menu
            if (drPro["MNU_NVL"].ToString() != "0")
            {

                MenuItem mi = CarregarPai(drPro["MNU_REG_ID"].ToString());

                if (mi != null)
                {
                    MenuItem submi = new MenuItem();
                    submi.Text = drPro["MNU_TIT"].ToString();

                    if (drPro["MNU_URL"].ToString() != "")
                    {
                        submi.Value = drPro["MNU_URL"].ToString();
                        submi.ToolTip = drPro["MNU_URL"].ToString();
                    }
                    else
                    {
                        submi.Value = "[" + drPro["MNU_TIT"].ToString() + "]";
                        submi.ToolTip = "[" + drPro["MNU_TIT"].ToString() + "]";
                    }
                    mi.ChildItems.Add(submi);
                }
                else
                {
                    Response.Write("Menu não Encontrado: " + drPro["MNU_REG_ID"].ToString());
                }
            }
            else
            //Novo Menu
            {
                MenuItem mi = new MenuItem();
                mi.Text = drPro["MNU_TIT"].ToString();

                if (drPro["MNU_URL"].ToString() != "")
                {
                    mi.Value = drPro["MNU_URL"].ToString();
                    mi.ToolTip = drPro["MNU_URL"].ToString();
                }
                else
                {
                    mi.Value = "[" + drPro["MNU_TIT"].ToString() + "]";
                    mi.ToolTip = "[" + drPro["MNU_TIT"].ToString() + "]";
                }
                mnu.Items.Add(mi);

                txt_app.Text = drPro["MNU_COD_APL"].ToString();
            }

            i = i + 1;

        }

    }

    protected MenuItem CarregarPai(string sREG)
    {

        string sConnectionString = "";
        sConnectionString = "Data Source=" + txt_srv.Text + ";";
        sConnectionString += "Initial Catalog=" + txt_bco.Text + ";";
        sConnectionString += "User ID=" + txt_usr.Text + ";";
        sConnectionString += "Password=" + txt_snh.Text + ";";

        String sSelectCommand = "SELECT * FROM MNU WHERE MNU_ID = " + sREG;
        SqlDataAdapter sdaPro = new SqlDataAdapter(sSelectCommand, sConnectionString);

        DataSet dsPro = new DataSet();
        sdaPro.Fill(dsPro);

        DataTable dtPro = dsPro.Tables[0];
        if (dtPro.Rows.Count > 0)
        {
            DataRow drPro = dtPro.Rows[0];

            foreach (MenuItem mi in mnu.Items)
            {
                MenuItem miPai = LocalizarMenu(mi, drPro["MNU_TIT"].ToString(), drPro["MNU_URL"].ToString());

                if (miPai != null)
                {
                    return miPai;
                }
            }
        }
        
        dsPro.Dispose();
        sdaPro.Dispose();
        Dispose();

        return null;
    }

    protected MenuItem LocalizarMenu(MenuItem mi, string sTIT, string sURL)
    {

        if (sURL == "")
        {
            sURL = "[" + sTIT + "]";
        }

        if (mi.Text == sTIT && mi.Value.Trim() == sURL)
        {
            return mi;
        }
        else
        {
            foreach (MenuItem miFilhos in mi.ChildItems)
            {
                MenuItem miFilho = LocalizarMenu(miFilhos, sTIT, sURL);
                if (miFilho != null)
                {
                    return miFilho;
                }
            }
            return null;
        }
    }

    protected void GeraMNU(MenuItem mi, int iPai, string sOrdPai)
    {
        string sID, sApp, sTit, sOrd, sUrl, sAlu, sLar, sNvl, sReg;

        i = i + 1;

        sID = i.ToString();
        sApp = txt_app.Text;
        sTit = mi.Text;

        sOrd = sOrdPai;

        //Sub Menos com Ordem do Pai
        if (iPai > 0)
        {
            sOrd = sOrd + "_" + i.ToString().PadLeft(2, '0');
        }
        
        if (!mi.Value.StartsWith("["))
        {
            sUrl = mi.Value.Trim();
        }
        else
        {
            sUrl = "";
        }
        sAlu = "17";

        //Sub Menus com Largura 200px
        if (mi.Depth > 0)
        {
            sLar = "200";
        }
        else
        {
            sLar = "180";
        }

        sNvl = mi.Depth.ToString();

        //Sub Menus com Regedor do Pai
        if (iPai > 0)
        {
            sReg = iPai.ToString();
        }
        else
        {
            sReg = "NULL";
        }

        pre_sql.InnerText += "INSERT INTO MNU \n";
        pre_sql.InnerText += "(MNU_ID, MNU_COD_APL, MNU_TIT, MNU_ORD, MNU_URL, MNU_IMG, MNU_ALU, MNU_LAR, MNU_NVL, MNU_REG_ID, MNU_USR_INC_ID, MNU_TMS_ATL)\n";
        pre_sql.InnerText += "VALUES\n";
        pre_sql.InnerText += "(" + sID + ",'" + sApp + "','" + sTit+ "','" + sOrd + "','" + sUrl + "'," + "NULL" + "," + sAlu + "," + sLar + "," + sNvl + "," + sReg + "," + 1 + "," + "GETDATE()";
        pre_sql.InnerText += ")\n";
        pre_sql.InnerText += "\n";

        //Pai Regedor para os Filhos
        int iPaiFilho = i;
        //Ordem para os Filhos
        string sOrdFilho = sOrd;
        foreach (MenuItem mic in mi.ChildItems)
        {
            GeraMNU(mic, iPaiFilho, sOrdFilho);
        }

    }

    protected void GeraMNUFHO(MenuItem mi)
    {

        i = i + 1;

        if ((mi.Value.Trim() != "") & (!mi.Value.StartsWith("[")))
        {
            InsereMNUFHO(i, mi.Value, false);
        }


        foreach (MenuItem mic in mi.ChildItems)
        {
            GeraMNUFHO(mic);
        }
    }

    protected void InsereMNUFHO(int i, string sPag, bool bFixo)
    {
        pre_sql.InnerText += "INSERT INTO MNU_FHO \n";
        pre_sql.InnerText += "(MNU_FHO_ID, MNU_FHO_MNU_ID, MNU_FHO_URL, MNU_FHO_USR_INC_ID, MNU_FHO_TMS_ATL)\n";
        pre_sql.InnerText += "VALUES\n";
        if (!bFixo)
        {
            pre_sql.InnerText += "(" + i + "," + i + ",'" + sPag + "'," + 1 + "," + "GETDATE()";
        }
        else
        {
            pre_sql.InnerText += "(" + i + ",NULL,'" + sPag + "'," + 1 + "," + "GETDATE()";
        }
        pre_sql.InnerText += ")\n";
        pre_sql.InnerText += "\n";
    }
}

