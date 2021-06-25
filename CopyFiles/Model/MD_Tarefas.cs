using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [TAREFAS] Tabela da classe
    /// </summary>
    public class MD_Tarefas 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Tarefas DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Tarefas(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Tarefas()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Tarefas(codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna os projetos
        /// </summary>
        /// <returns>Lista com os projetos</returns>
        public static List<MD_Tarefas> RetornaTodasTarefas()
        {
            Util.CL_Files.WriteOnTheLog("MD_Projeto.GetProjetos()", Util.Global.TipoLog.DETALHADO);

            List<MD_Tarefas> projeto = new List<MD_Tarefas>();
            string sentenca = new DAO.MD_Tarefas().table.CreateCommandSQLTable();

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            while (reader.Read())
            {
                projeto.Add(new MD_Tarefas(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return projeto;
        }

        #endregion Métodos

    }
}
