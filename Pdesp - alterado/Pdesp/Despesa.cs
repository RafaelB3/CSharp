using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PDesp
{
    class Despesa
    {
        private int iddespesa;
        private int tipodespesa; // puxa da classe TipoDespesa
        private int idmembro; // puxa da classe Membro
        private DateTime datadespesa;
        private float valordespesa;
        string obsdespesa;

        public int Iddespesa
        {
            get
            {
                return iddespesa;
            }
            set
            {
                iddespesa = value;
            }
        }

        public int Tipodespesa
        {
            get
            {
                return tipodespesa;
            }
            set
            {
                tipodespesa = value;
            }
        }
        public int Idmembro
        {
            get
            {
                return idmembro;
            }
            set
            {
                idmembro = value;
            }
        }

        public DateTime Datadespesa
        {
            get
            {
                return datadespesa;
            }
            set
            {
                datadespesa = value;
            }
        }

        public float Valordespesa
        {
            get
            {
                return valordespesa;
            }
            set
            {
                valordespesa = value;
            }
        }

        public string Obsdespesa
        {
            get
            {
                return obsdespesa;
            }
            set
            {
                obsdespesa = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daDespesa;

            DataTable dtDespesa = new DataTable();

            try
            {
                daDespesa = new SqlDataAdapter("SELECT * FROM DESPESA",frmPrincipal.conexao);
                daDespesa.Fill(dtDespesa);
                daDespesa.FillSchema(dtDespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtDespesa;
        }


        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO DESPESA VALUES (@nome_despesa)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_odespesa", SqlDbType.VarChar));

                mycommand.Parameters["@nome_despesa"].Value = iddespesa;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycomand;
                int nReg = 0;
                mycomand = new SqlCommand("UPDATE DESPESA SET nome_despesa" +
                    "= @nome_despesa WHERE id_despesa = @id_iddespesa", frmPrincipal.conexao);

                mycomand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));
                mycomand.Parameters.Add(new SqlParameter("@nome_despesa", SqlDbType.VarChar));

                mycomand.Parameters["@id_despesa"].Value = iddespesa;

                nReg = mycomand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycomand;

                mycomand = new SqlCommand("DELETE FROM DESPESA WHERE " +
                "id_despesa = @id_iddespesa", frmPrincipal.conexao);
                mycomand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));
                mycomand.Parameters["@id_despesa"].Value = iddespesa;

                nReg = mycomand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nReg;
        }
    }
}
