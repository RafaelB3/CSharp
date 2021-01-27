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
    class TipoDespesa
    {
        private int idtipodespesa;
        private string nometipodespesa;

        public int Idtipodespesa
        {
            get
            {
                return idtipodespesa;
            }
            set
            {
                idtipodespesa = value;
            }
        }

        public string Nometipodespesa
        {
            get
            {
                return nometipodespesa;
            }
            set
            {
                nometipodespesa = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daTipodespesa;

            DataTable dtTipodespesa = new DataTable();

            try
            {
                daTipodespesa = new SqlDataAdapter("SELECT * FROM TIPODESPESA",
                    frmPrincipal.conexao);
                daTipodespesa.Fill(dtTipodespesa);
                daTipodespesa.FillSchema(dtTipodespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtTipodespesa;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO TIPODESPESA VALUES (@nome_tipodespesa)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_tipodespesa", SqlDbType.VarChar));
                
                mycommand.Parameters["@nome_tipodespesa"].Value = nometipodespesa;
                
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
                mycomand = new SqlCommand("UPDATE TIPODESPESA SET nome_tipodespesa" +
                    "= @nome_tipodespesa WHERE id_tipodespesa = @id_tipodespesa", frmPrincipal.conexao);

                mycomand.Parameters.Add(new SqlParameter("@id_tipodespesa", SqlDbType.Int));
                mycomand.Parameters.Add(new SqlParameter("@nome_tipodespesa", SqlDbType.VarChar));
              
                mycomand.Parameters["@id_tipodespesa"].Value = idtipodespesa;
                mycomand.Parameters["@nome_tipodespesa"].Value = nometipodespesa;
                
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

                mycomand = new SqlCommand("DELETE FROM TIPODESPESA WHERE " +
                "id_tipodespesa = @id_tipodespesa", frmPrincipal.conexao);
                mycomand.Parameters.Add(new SqlParameter("@id_tipodespesa",SqlDbType.Int));
                mycomand.Parameters["@id_tipodespesa"].Value = idtipodespesa;

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