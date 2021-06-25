using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Util.CL_Files.WriteOnTheLog("--------------------------------------Iniciando sistema", Util.Global.TipoLog.SIMPLES);
            Util.CL_Files.CreateMainDirectories();

            // Abre a conexão com o banco de dados
            DataBase.Connection.OpenConection(Util.Global.app_base_file, Util.Enumerator.BancoDados.SQLite);

            // Seta o caminho padrão da destino dos artefatos
            Util.Global.caminhoArtefatosDestino = DataBase.Connection.GetArtefatosDestino();

            // Seta o caminho padrão da origem dos artefatos
            Util.Global.caminhoArtefatosOrigem = DataBase.Connection.GetArtefatosOrigem();

            // Seta o diretório relativo da bat para parar o robo
            Util.Global.caminhoFilePararRobo = DataBase.Connection.GetCaminhoFilePararRobo();

            // Seta o diretório relativo da bat para iniciar o robo
            Util.Global.caminhoFileIniciarRobo = DataBase.Connection.GetCaminhoFileIniciaRobo();

            // Seta o diretório relativo da bat para reiniciar o robo
            Util.Global.caminhoFileReiniciarRobo = DataBase.Connection.GetCaminhoFileReiniciaRobo();

            // Seta o diretório relativo da bat para reiniciar a VM
            Util.Global.caminhoFileReiniciarVM = DataBase.Connection.GetCaminhoFileReiniciaVM();

            // Captura se carrega o treeview automaticamente
            Util.Global.CarregarAutomaticamente =  DataBase.Connection.GetAutomatico();

            // Captura o tipo de log
            Util.Global.log_system = DataBase.Connection.GetLog();

            Application.Run(new View.Principal());

            DataBase.Connection.CloseConnection();
            Util.CL_Files.WriteOnTheLog("--------------------------------------Finalizando sistema", Util.Global.TipoLog.SIMPLES);
        }
    }
}
