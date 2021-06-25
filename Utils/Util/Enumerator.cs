using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Enumerator
    {

        /// <summary>
        /// Enumerator do tipo do banco
        /// </summary>
        public enum BancoDados
        {
            SQL_SERVER = 0,
            SQLite = 1,
            ORACLE = 2
        }

        /// <summary>
        /// Enum referente à tela a ser aberta
        /// </summary>
        public enum Telas
        {
            CADASTRO_SERVIDOR = 0,
            COPIAR_ARQUIVOS = 1,
            TELA_TAREFAS = 2
        }

        /// <summary>
        /// Tarefa sendo executada na tela
        /// </summary>
        public enum Tarefa
        {
            INCLUINDO = 0,
            EDITANDO = 1,
            EXCLUINDO = 2,
            VISUALIZANDO = 3
        }

        /// <summary>
        /// Enumerator for type of data
        /// </summary>
        public enum DataType
        {
            DATE = 1,
            INT = 2,
            STRING = 3,
            CHAR = 4,
            DECIMAL
        }

        public enum Status
        {
            // Status desativado
            DESATIVADO = 0,
            // Status ativado
            ATIVO = 1
        }

        public enum ArquivosGerados
        {
            // Arquivos da UTIL
            UTIL = 0,
            // Arquivos do Model
            MODEL = 1
        }
    }
}
