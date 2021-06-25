using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAO
{

    /// <summary>
    /// [TAREFAS] Tabela TAREFAS
    /// </summary>
    public class MD_Tarefas : MDN_Model
    {
        #region Atributos e Propriedades

        private int codigo;
        /// <summary>
        /// [CODIGO] Código da tarefa
        /// <summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        private string descricao;
        /// <summary>
        /// [DESCRICAO] Descrição da tarefa
        /// <summary>
        public string Descricao
        {
            get
            {
                return this.descricao;
            }
            set
            {
                this.descricao = value;
            }
        }

        private string dataexecucao;
        /// <summary>
        /// [DATAEXECUCAO] Data que a tarefa executou
        /// <summary>
        public string Dataexecucao
        {
            get
            {
                return this.dataexecucao;
            }
            set
            {
                this.dataexecucao = value;
            }
        }

        private string tipo;
        /// <summary>
        /// [TIPO] Tipo da tarefa (0 - Copia de arquivos; 1 - Execução do robô)
        /// <summary>
        public string Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        private string status;
        /// <summary>
        /// [STATUS] Status da tarefa (0 - Erro; 1 - Sucesso)
        /// <summary>
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Tarefas()
            : base()
        {
            base.table = new MDN_Table("TAREFAS");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DESCRICAO", false, Util.Enumerator.DataType.STRING, "", false, false, 200, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DATAEXECUCAO", true, Util.Enumerator.DataType.STRING, "", false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("TIPO", true, Util.Enumerator.DataType.CHAR, "", false, false, 1, 0));
            this.table.Fields_Table.Add(new MDN_Campo("STATUS", true, Util.Enumerator.DataType.CHAR, "", false, false, 1, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        public MD_Tarefas(int codigo)
            :this()
        {
            this.codigo = codigo;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Tarefas.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + this.codigo;
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Codigo = int.Parse(reader["CODIGO"].ToString());
                this.Descricao = reader["DESCRICAO"].ToString();
                this.Dataexecucao = reader["DATAEXECUCAO"].ToString();
                this.Tipo = reader["TIPO"].ToString();
                this.Status = reader["STATUS"].ToString();

                this.Empty = false;
                reader.Close();
            }
            else
            {
                this.Empty = true;
                reader.Close();
            }
        }

        /// <summary>
        /// Método que faz o delete da classe
        /// </summary>
        /// <returns>True - sucesso; False - erro</returns>
        public override bool Delete()
        {
            string sentenca = "DELETE FROM " + this.table.Table_Name + " WHERE CODIGO = " + this.codigo;
            return DataBase.Connection.Delete(sentenca);
        }

        /// <summary>
        /// Método que faz o insert da classe
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            string sentenca = string.Empty;

            sentenca = "INSERT INTO " + table.Table_Name + " (" + table.TodosCampos() + ")" + 
                              " VALUES (" + this.codigo + ",  '" + this.descricao + "',  '" + this.dataexecucao + "',  '" + this.tipo + "',  '" + this.status + "')";
            if (DataBase.Connection.Insert(sentenca))
            {
                Empty = false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método que faz o update da classe
        /// </summary>
        /// <returns>True - sucesso; False - erro</returns>
        public override bool Update()
        {
            string sentenca = string.Empty;

            sentenca = "UPDATE " + table.Table_Name + " SET " + 
                        "CODIGO = " + Codigo + ", DESCRICAO = '" + Descricao + "', DATAEXECUCAO = '" + Dataexecucao + "', TIPO = '" + Tipo + "', STATUS = '" + Status + "'" +
                        " WHERE CODIGO = " + this.codigo;

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
