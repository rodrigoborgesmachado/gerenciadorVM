using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [SERVIDORES] Tabela da classe
    /// </summary>
    public class MD_Servidores 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Servidores DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Servidores(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Servidores()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Servidores( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna a lista de todos os servidores
        /// </summary>
        /// <returns>Lista com os servidores</returns>
        public static List<Model.MD_Servidores> ListaServidores()
        {
            Util.CL_Files.WriteOnTheLog("MD_Servidores().ListaServidores()", Util.Global.TipoLog.DETALHADO);

            string sentenca = new DAO.MD_Servidores().table.CreateCommandSQLTable();

            List<Model.MD_Servidores> clientes = new List<MD_Servidores>();
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            while (reader.Read())
            {
                clientes.Add(new MD_Servidores(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return clientes;
        }

        #endregion Métodos

    }
}
