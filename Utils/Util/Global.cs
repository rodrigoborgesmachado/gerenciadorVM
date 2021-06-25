using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class Global
    {
        public static string tempTable = "TESTE";

        // Caminho principal da aplicação
        public static string app_main_directoty = System.IO.Directory.GetCurrentDirectory() + "\\";

        // Caminho da pasta de logs do sistema
        public static string app_logs_directoty = app_main_directoty + "Log\\";

        // Caminho da pasta de arquivos temporários
        public static string app_temp_directory = app_main_directoty + "TEMP\\";

        // Nome do diretório do banco de dados
        public static string app_base_directory = app_main_directoty + "BASE\\";

        // Nome do diretório do Img do html
        public static string app_Img_directory = app_main_directoty + "Img\\";

        // Nome do arquivo sqlite de configuração
        public static string app_base_file = app_base_directory + "pckdb.db3";

        // Nome do arquivo html temporário
        public static string app_temp_html_file = app_temp_directory + "file_html.html";

        /// <summary>
        /// Enumerador referente ao tipo de log que o sistema irá persistir
        /// </summary>
        public enum TipoLog
        {
            DETALHADO = 0,
            SIMPLES = 1
        }

        /// <summary>
        /// Enum responsável por verificar se deve carregar o tree view automaticamente ou não
        /// </summary>
        public enum Automatico
        {
            Automatico = 0,
            Manual = 1
        }

        /// <summary>
        /// Tipo mde log que o sistema está utilizando
        /// </summary>
        public static TipoLog log_system = TipoLog.SIMPLES;

        /// <summary>
        /// Carregar automaticamente ou não o tree view da tela principal
        /// </summary>
        public static Automatico CarregarAutomaticamente = Automatico.Automatico;

        /// <summary>
        /// Caminho dos artefatos - origem
        /// </summary>
        public static string caminhoArtefatosOrigem = string.Empty;

        /// <summary>
        /// Caminho dos artefatos - destino
        /// </summary>
        public static string caminhoArtefatosDestino = string.Empty;

        /// <summary>
        /// Caminho relativo das bat para parar o robo
        /// </summary>
        public static string caminhoFilePararRobo = string.Empty;

        /// <summary>
        /// Caminho relativo das bat para iniciar o robo
        /// </summary>
        public static string caminhoFileIniciarRobo = string.Empty;

        /// <summary>
        /// Caminho relativo das bat para reiniciar o robo
        /// </summary>
        public static string caminhoFileReiniciarRobo = string.Empty;

        /// <summary>
        /// Caminho relativo das bat para reiniciar o VM
        /// </summary>
        public static string caminhoFileReiniciarVM = string.Empty;
    }
}
