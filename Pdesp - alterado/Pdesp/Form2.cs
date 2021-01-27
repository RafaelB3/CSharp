using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Pdesp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            class Membro
            {
                private int idmembro;
                private string nomemembro;
                private string papelmembro;

            public int Idmembro
            {
                get
                {
                    return idmembro;
                }
                set
                {
                    idmembro=value;
                }

            }
                SqlDataAdapter daMembro;

                try
            {
                daMembro = new SqlDataAdapter("SELECT * FROM MEMBRO",frmPrincipal.conexao);
                daMembro.Fill(dtMembro);
                daMembro.FillShema(dtMembro, SchemaType);
            }

       
        public int Salvar()
        {
            int retorno = 0;
            try
        }
        mycomand = new SqlCommand("INSERT INTO MEMBRO VALUES ")

        mycomand.parameters.add(new SqlParameter("@nome_membro",sqlBDtype))

        nReg = mycomand.ExecuteNonQuery();

        if(nReg > 0)
    {
        retorno = nReg;

    }
    catch (Exception ex)
{
    throw ex;
}
    return retorno;

    public int Alterar()
{
    int retorno = 0;
}
            }
        }
    }
}
