using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules
{
    public static class CopiarArquivos
    {

        /// <summary>
        /// Método que copiar os arquivos
        /// </summary>
        /// <returns></returns>
        public static bool Copiar(Model.MD_Servidores servidor, out string mensagemErro)
        {
            try
            {
                string dirDestino = "\\\\" + servidor.DAO.Link + "\\" + Util.Global.caminhoArtefatosDestino.Replace("C:", "C$");

                DirectoryInfo dir = new DirectoryInfo(dirDestino);
                if (!dir.Exists)
                {
                    dir.Create();
                }
                else
                {

                    string newDir = dir.Parent.FullName + "\\" + dir.Name + dir.CreationTime.Year + (dir.CreationTime.Month < 10 ? "0" + dir.CreationTime.Month.ToString() : dir.CreationTime.Month.ToString()) + (dir.CreationTime.Day < 10 ? "0" + dir.CreationTime.Day.ToString() : dir.CreationTime.Day.ToString());

                    TrataPastaBackup(newDir);
                    Backup(dir.Parent.FullName + "\\" + dir.Name, newDir);


                    Model.MD_Tarefas tarefa = new Model.MD_Tarefas(DataBase.Connection.GetIncrement(new DAO.MD_Tarefas().table.Table_Name));
                    tarefa.DAO.Dataexecucao = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                    tarefa.DAO.Descricao = "Fazendo backup " + dir.FullName + " para " + newDir;
                    tarefa.DAO.Status = "1";
                    tarefa.DAO.Tipo = "0";
                    tarefa.DAO.Insert();
                }

                System.Threading.Thread.Sleep(1000);
                dir.Delete(true);
                System.Threading.Thread.Sleep(1000);

                DirectoryInfo dirOrigem = new DirectoryInfo(Util.Global.caminhoArtefatosOrigem);
                string origem = dirOrigem.Parent.FullName + "\\" + dirOrigem.Name;

                Directory.GetFiles(origem).ToList().ForEach(file => CopiarFile(servidor, file));
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                mensagemErro = e.Message;
                return false;
            }

            mensagemErro = string.Empty;
            return true;
        }

        /// <summary>
        /// Método que copia o arquivo para o servidor
        /// </summary>
        /// <param name="servidor">Caminho para acesso no servidor</param>
        /// <param name="path">caminho do arquivo de origem</param>
        private static void CopiarFile(Model.MD_Servidores servidor, string path)
        {
            FileInfo file = new FileInfo(path);
            DirectoryInfo dirOrigem = new DirectoryInfo(Util.Global.caminhoArtefatosDestino);
            string origem = dirOrigem.Parent.FullName + "\\" + dirOrigem.Name;
            string dirDestino = "\\\\" + servidor.DAO.Link + "\\" + origem.Replace("C:", "C$");

            if (!Directory.Exists(dirDestino))
            {
                Directory.CreateDirectory(dirDestino);
            }

            File.Copy(file.FullName, dirDestino + "\\" + file.Name);

            Model.MD_Tarefas tarefa = new Model.MD_Tarefas(DataBase.Connection.GetIncrement(new DAO.MD_Tarefas().table.Table_Name));
            tarefa.DAO.Dataexecucao = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
            tarefa.DAO.Descricao = "Copiando arquivos da pasta " + file.FullName + " para " + dirDestino + "\\" + file.Name + "." + file.Extension;
            tarefa.DAO.Status = "1";
            tarefa.DAO.Tipo = "0";
            tarefa.DAO.Insert();

            System.Threading.Thread.Sleep(100);
        }
        
        /// <summary>
        /// Método que faz backup do backup
        /// </summary>
        /// <param name="newDir"></param>
        private static void TrataPastaBackup(string newDir)
        {
            try
            {
                if (Directory.Exists(newDir))
                {
                    if (Directory.Exists(newDir + " - old"))
                    {
                        Directory.Delete(newDir + " - old", true);
                    }

                    Directory.Move(newDir, newDir + " - old");
                    Directory.Delete(newDir, true);
                }
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }
        }

        /// <summary>
        /// Método que faz backup do backup
        /// </summary>
        /// <param name="newDir"></param>
        private static void Backup(string dir, string newDir)
        {
            try
            {
                if (!Directory.Exists(newDir))
                {
                    Directory.CreateDirectory(newDir);
                }

                Directory.GetDirectories(dir).ToList().ForEach(d => Backup(d, newDir + "\\" + d));
                Directory.GetFiles(dir).ToList().ForEach(f => File.Copy(f, newDir + "\\" + new FileInfo(f).Name));
                Directory.GetFiles(dir).ToList().ForEach(f => new DAO.MD_Tarefas() { Codigo = DataBase.Connection.GetIncrement(new DAO.MD_Tarefas().table.Table_Name), Dataexecucao = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), Descricao = "Copiando arquivo " + f + " para o diretório " + newDir + new FileInfo(f).Name + "." + new FileInfo(f).Extension, Status = "1", Tipo = "0" }.Insert());
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }
        }
    }
}
