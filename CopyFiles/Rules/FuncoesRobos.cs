using System;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rules
{
    public static class FuncoesRobos
    {
        /// <summary>
        /// Método que inicializaTodosRobos
        /// </summary>
        /// <returns></returns>
        public static bool IniciarRobos()
        {
            Model.MD_Servidores.ListaServidores().Where(servidor => servidor.DAO.Tipo.Equals("1")).ToList().ForEach(servidor => IniciarRobos(servidor));            
            return true;
        }

        /// <summary>
        /// Método que inicializa o robo
        /// </summary>
        /// <param name="servidor">robo</param>
        /// <returns></returns>
        public static bool IniciarRobos(Model.MD_Servidores servidor)
        {
            try
            {
                string dirDestino = "\\\\" + servidor.DAO.Link + "\\" + Util.Global.caminhoFileIniciarRobo.Replace("C:", "C$").Replace("IniciarWatcher.bat", "");
                
                if (File.Exists(dirDestino))
                {
                    File.Delete(dirDestino);
                    System.Threading.Thread.Sleep(1000);
                }

                Util.CL_Files.WriteOnTheLog("Criou o arquivo " + dirDestino, Util.Global.TipoLog.SIMPLES);
                var file = File.Create(dirDestino);
                file.Close();

                Model.MD_Tarefas tarefa = new Model.MD_Tarefas(DataBase.Connection.GetIncrement(new DAO.MD_Tarefas().table.Table_Name));
                tarefa.DAO.Dataexecucao = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
                tarefa.DAO.Descricao = "Criando arquivo " + dirDestino;
                tarefa.DAO.Status = "1";
                tarefa.DAO.Tipo = "1";
                tarefa.DAO.Insert();
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Método que inicializaTodosRobos
        /// </summary>
        /// <returns></returns>
        public static bool PararRobos()
        {
            Model.MD_Servidores.ListaServidores().Where(servidor => servidor.DAO.Tipo.Equals("1")).ToList().ForEach(servidor => PararRobos(servidor));
            return true;
        }

        /// <summary>
        /// Método que inicializa o robo
        /// </summary>
        /// <param name="servidor">robo</param>
        /// <returns></returns>
        public static bool PararRobos(Model.MD_Servidores servidor)
        {
            try
            {
                string dirDestino = "\\\\" + servidor.DAO.Link + "\\" + Util.Global.caminhoFilePararRobo.Replace("C:", "C$").Replace("KillWatcher.bat", "");

                if (File.Exists(dirDestino))
                {
                    File.Delete(dirDestino);
                    System.Threading.Thread.Sleep(1000);
                }

                Util.CL_Files.WriteOnTheLog("Criou o arquivo " + dirDestino, Util.Global.TipoLog.SIMPLES);
                var file = File.Create(dirDestino);
                file.Close();

                Model.MD_Tarefas tarefa = new Model.MD_Tarefas(DataBase.Connection.GetIncrement(new DAO.MD_Tarefas().table.Table_Name));
                tarefa.DAO.Dataexecucao = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
                tarefa.DAO.Descricao = "Criando arquivo " + dirDestino;
                tarefa.DAO.Status = "1";
                tarefa.DAO.Tipo = "1";
                tarefa.DAO.Insert();
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Método que inicializaTodosRobos
        /// </summary>
        /// <returns></returns>
        public static bool ReiniciarRobos()
        {
            Model.MD_Servidores.ListaServidores().Where(servidor => servidor.DAO.Tipo.Equals("1")).ToList().ForEach(servidor => ReiniciarRobos(servidor));
            return true;
        }

        /// <summary>
        /// Método que inicializa o robo
        /// </summary>
        /// <param name="servidor">robo</param>
        /// <returns></returns>
        public static bool ReiniciarRobos(Model.MD_Servidores servidor)
        {
            try
            {
                string dirDestino = "\\\\" + servidor.DAO.Link + "\\" + Util.Global.caminhoFileReiniciarRobo.Replace("C:", "C$").Replace("reiniciarWatcher.bat", "");

                if (File.Exists(dirDestino))
                {
                    File.Delete(dirDestino);
                    System.Threading.Thread.Sleep(1000);
                }

                Util.CL_Files.WriteOnTheLog("Criou o arquivo " + dirDestino, Util.Global.TipoLog.SIMPLES);
                var file = File.Create(dirDestino);
                file.Close();

                Model.MD_Tarefas tarefa = new Model.MD_Tarefas(DataBase.Connection.GetIncrement(new DAO.MD_Tarefas().table.Table_Name));
                tarefa.DAO.Dataexecucao = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
                tarefa.DAO.Descricao = "Criando arquivo " + dirDestino;
                tarefa.DAO.Status = "1";
                tarefa.DAO.Tipo = "1";
                tarefa.DAO.Insert();
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Método que inicializaTodosRobos
        /// </summary>
        /// <returns></returns>
        public static bool ReiniciarVM()
        {
            Model.MD_Servidores.ListaServidores().Where(servidor => servidor.DAO.Tipo.Equals("1")).ToList().ForEach(servidor => ReiniciarVM(servidor));
            return true;
        }

        /// <summary>
        /// Método que inicializa o robo
        /// </summary>
        /// <param name="servidor">robo</param>
        /// <returns></returns>
        public static bool ReiniciarVM(Model.MD_Servidores servidor)
        {
            try
            {
                string dirDestino = "\\\\" + servidor.DAO.Link + "\\" + Util.Global.caminhoFileReiniciarVM.Replace("C:", "C$").Replace("reiniciarWatcher.bat", "");

                if (File.Exists(dirDestino))
                {
                    File.Delete(dirDestino);
                    System.Threading.Thread.Sleep(1000);
                }

                Util.CL_Files.WriteOnTheLog("Criou o arquivo " + dirDestino, Util.Global.TipoLog.SIMPLES);
                var file = File.Create(dirDestino);
                file.Close();

                Model.MD_Tarefas tarefa = new Model.MD_Tarefas(DataBase.Connection.GetIncrement(new DAO.MD_Tarefas().table.Table_Name));
                tarefa.DAO.Dataexecucao = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
                tarefa.DAO.Descricao = "Criando arquivo " + dirDestino;
                tarefa.DAO.Status = "1";
                tarefa.DAO.Tipo = "1";
                tarefa.DAO.Insert();
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                return false;
            }

            return true;
        }
    }
}
