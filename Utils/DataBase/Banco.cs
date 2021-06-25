using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DataBase
{
    abstract class Banco
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Checker is the connection is opened
        /// </summary>
        protected bool is_open = false;

        /// <summary>
        /// Checker if the transaction is opened
        /// </summary>
        protected bool is_in_transaction = false;

        /// <summary>
        /// Name of the data_base of tests
        /// </summary>
        protected string name_table_test = "TESTE";

        #endregion Atributos e Propriedades

        /// <summary>
        /// Método que abre a conexão
        /// </summary>
        /// <param name="directory_database">string de conexão</param>
        /// <returns>True - conectado com sucesso; False - erro ao conectar</returns>
        public abstract bool OpenConnection(string directory_database = "");

        /// <summary>
        /// Método que fecha a conexão
        /// </summary>
        /// <returns></returns>
        public abstract bool CloseConnection();

        /// <summary>
        /// Método que faz o select
        /// </summary>
        /// <param name="command_sql">Comando Select</param>
        /// <returns>DataReader com o resultado</returns>
        public abstract DbDataReader Select(string command_sql);

        /// <summary>
        /// Método que faz o create da tabela
        /// </summary>
        /// <param name="command_sql">SQL</param>
        /// <returns>True - foi criado; False - erro</returns>
        public bool CreateTable(string command_sql)
        {
            try
            {
                return Execute(command_sql);
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro no delete: " + command_sql + ". Erro: " + e.Message, Global.TipoLog.SIMPLES);
                return false;
            }
        }

        /// <summary>
        /// Método que faz o insert
        /// </summary>
        /// <param name="command_sql">Comando insert</param>
        /// <returns>True - insert efetuado com sucesso</returns>
        public bool Insert(string command_sql)
        {
            try
            {
                return Execute(command_sql);
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro no delete: " + command_sql + ". Erro: " + e.Message, Global.TipoLog.SIMPLES);
                return false;
            }
        }

        /// <summary>
        /// Método que faz o Update
        /// </summary>
        /// <param name="command_sql">Comando update</param>
        /// <returns>True - update com sucesso; False - erro</returns>
        public bool Update(string command_sql)
        {
            try
            {
                return Execute(command_sql);
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro no delete: " + command_sql + ". Erro: " + e.Message, Global.TipoLog.SIMPLES);
                return false;
            }
        }

        /// <summary>
        /// Método que faz o Delete da classe
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public bool Delete(string command)
        {
            try
            {
                return Execute(command);
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro no delete: " + command + ". Erro: " + e.Message, Global.TipoLog.SIMPLES);
                return false;
            }
        }

        /// <summary>
        /// Método que executa os comandos
        /// </summary>
        /// <param name="command_sql">Comando a ser executado</param>
        /// <returns></returns>
        public abstract bool Execute(string command_sql);

        /// <summary>
        /// Method that verify if the data base exists
        /// </summary>
        /// <param name="table">Name of the table</param>
        /// <returns>True - exists; False - don't exists</returns>
        public bool ExistsTable(string table)
        {
            return Select("SELECT 1 FROM " + table) != null;
        }

        /// <summary>
        /// Método que pega o incremental da tabela
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public int GetIncrement(string table)
        {
            if (!ExistsTable("CODIGOS_TABLE"))
            {
                CriaTabelaIncrementais();
            }
            AtualizaIncrementais(table);

            string senteca = "SELECT CODIGO FROM CODIGOS_TABLE WHERE TABELA = '" + table + "'";
            DbDataReader reader = Select(senteca);
            if (reader == null)
            {
                return -1;
            }
            else if (reader.Read())
            {
                int retorno = int.Parse(reader["CODIGO"].ToString());
                reader.Close();

                senteca = "UPDATE CODIGOS_TABLE SET CODIGO = CODIGO+1 WHERE TABELA = '" + table + "'";
                Update(senteca);

                return retorno;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Método que cria tabela de incrementais
        /// </summary>
        public void CriaTabelaIncrementais()
        {
            string sentenca = "CREATE TABLE CODIGOS_TABLE (TABELA VARCHAR(30) NOT NULL, CODIGO INT DEFAULT 0 NOT NULL, PRIMARY KEY(TABELA))";
            CreateTable(sentenca);
        }

        /// <summary>
        /// Método que atualiza os incrementais
        /// </summary>
        public void AtualizaIncrementais(string table)
        {
            string sentenca = "SELECT 1 FROM CODIGOS_TABLE WHERE TABELA = '" + table +"'";
            if (!Select(sentenca).HasRows)
            {
                sentenca = "INSERT INTO CODIGOS_TABLE (TABELA, CODIGO) VALUES ('" + table + "', 0)";
                Insert(sentenca);
            }
        }

        /// <summary>
        /// Método que pega o tipo de sistema
        /// </summary>
        public Global.TipoLog GetLog()
        {
            Global.TipoLog tipo = Global.TipoLog.SIMPLES;

            if (!ExistsTable("LOGG"))
            {
                CreateTable("CREATE TABLE LOGG( TIPO_LOG CHAR(1) DEFAULT '0' NOT NULL, PRIMARY KEY(TIPO_LOG))");
            }
            if (Select("SELECT 1 FROM LOGG") != null)
            {
                if (!Select("SELECT 1 FROM LOGG").Read())
                {
                    Insert("INSERT INTO LOGG (TIPO_LOG) VALUES ('0')");
                }
            }

            DbDataReader reader = Select("SELECT TIPO_LOG FROM LOGG");
            reader.Read();
            tipo = (reader["TIPO_LOG"].ToString().Equals("0") ? Global.TipoLog.SIMPLES : Global.TipoLog.DETALHADO);
            reader.Close();

            return tipo;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public void SetLog(Global.TipoLog tipo)
        {
            if (!ExistsTable("LOGG"))
            {
                CreateTable("CREATE TABLE LOGG( TIPO_LOG CHAR(1) DEFAULT '0' NOT NULL, PRIMARY KEY(TIPO_LOG))");
            }
            if (!Select("SELECT 1 FROM LOGG").Read())
            {
                Insert("INSERT INTO LOGG (TIPO_LOG) VALUES ('0')");
            }

            Update("UPDATE LOGG SET TIPO_LOG = '" + (tipo == Global.TipoLog.DETALHADO ? '1' : '0') + "'");
            Global.log_system = tipo;
        }

        /// <summary>
        /// Método que pega a flag de automático
        /// </summary>
        public Global.Automatico GetAutomatico()
        {
            Global.Automatico tipo = Global.Automatico.Automatico;

            if (!ExistsTable("AUTOMATICO"))
            {
                CreateTable("CREATE TABLE AUTOMATICO( AUTOMATICO CHAR(1) DEFAULT '0' NOT NULL, PRIMARY KEY(AUTOMATICO))");
            }
            if (Select("SELECT 1 FROM AUTOMATICO") != null)
                if (!Select("SELECT 1 FROM AUTOMATICO").Read())
                {
                    Insert("INSERT INTO AUTOMATICO (AUTOMATICO) VALUES ('0')");
                }

            DbDataReader reader = Select("SELECT AUTOMATICO FROM AUTOMATICO");
            reader.Read();
            tipo = (reader["AUTOMATICO"].ToString().Equals("0") ? Global.Automatico.Automatico: Global.Automatico.Manual);
            reader.Close();

            return tipo;
        }

        /// <summary>
        /// Método que seta a flag de automático
        /// </summary>
        public void SetAutomatico(Global.Automatico tipo)
        {
            if (!ExistsTable("LOGG"))
            {
                CreateTable("CREATE TABLE AUTOMATICO( AUTOMATICO CHAR(1) DEFAULT '0' NOT NULL, PRIMARY KEY(AUTOMATICO))");
            }
            if (!Select("SELECT 1 FROM AUTOMATICO").Read())
            {
                Insert("INSERT INTO AUTOMATICO (AUTOMATICO) VALUES ('0')");
            }

            Update("UPDATE AUTOMATICO SET AUTOMATICO = '" + (tipo == Global.Automatico.Automatico ? '0' : '1') + "'");
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public void SetArtefatosOrigem(string caminho)
        {
            if (!ExistsTable("ARTEFATOSORIGEM"))
            {
                CreateTable("CREATE TABLE ARTEFATOSORIGEM( CAMINHO VARCHAR(1000) DEFAULT 'C:\\Users' NOT NULL)");
            }
            if (!Select("SELECT 1 FROM ARTEFATOSORIGEM").Read())
            {
                Insert("INSERT INTO ARTEFATOSORIGEM (CAMINHO) VALUES ('C:\\Users')");
            }

            Update("UPDATE ARTEFATOSORIGEM SET CAMINHO = '" + caminho + "'");
            Global.caminhoArtefatosOrigem = caminho;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public string GetArtefatosOrigem()
        {
            string tipo = string.Empty;
            if (!ExistsTable("ARTEFATOSORIGEM"))
            {
                this.SetArtefatosOrigem("C:\\Users");
            }

            DbDataReader reader = Select("SELECT CAMINHO FROM ARTEFATOSORIGEM");
            reader.Read();
            tipo = reader["CAMINHO"].ToString();
            reader.Close();

            return tipo;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public void SetArtefatosDestino(string caminho)
        {
            if (!ExistsTable("ARTEFATOSDESTINO"))
            {
                CreateTable("CREATE TABLE ARTEFATOSDESTINO( CAMINHO VARCHAR(1000) DEFAULT 'C:\\Openspan\\automacao\\current' NOT NULL)");
            }
            if (!Select("SELECT 1 FROM ARTEFATOSDESTINO").Read())
            {
                Insert("INSERT INTO ARTEFATOSDESTINO (CAMINHO) VALUES ('C:\\Openspan\\automacao\\current')");
            }

            Update("UPDATE ARTEFATOSDESTINO SET CAMINHO = '" + caminho + "'");
            Global.caminhoArtefatosDestino = caminho;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public string GetArtefatosDestino()
        {
            string tipo = string.Empty;
            if (!ExistsTable("ARTEFATOSDESTINO"))
            {
                this.SetArtefatosDestino("C:\\Openspan\\automacao\\current");
            }

            DbDataReader reader = Select("SELECT CAMINHO FROM ARTEFATOSDESTINO");
            reader.Read();
            tipo = reader["CAMINHO"].ToString();
            reader.Close();

            return tipo;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public void SetCaminhoFilePararRobo(string caminho)
        {
            if (!ExistsTable("BATPARARROBO"))
            {
                CreateTable("CREATE TABLE BATPARARROBO( CAMINHO VARCHAR(1000) DEFAULT 'C:\\openspan\\parar_agendado_robo.txt' NOT NULL)");
            }
            if (!Select("SELECT 1 FROM BATPARARROBO").Read())
            {
                Insert("INSERT INTO BATPARARROBO (CAMINHO) VALUES ('C:\\openspan\\parar_agendado_robo.txt')");
            }

            Update("UPDATE BATPARARROBO SET CAMINHO = '" + caminho + "'");
            Global.caminhoArtefatosDestino = caminho;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public string GetCaminhoFilePararRobo()
        {
            string tipo = string.Empty;
            if (!ExistsTable("BATPARARROBO"))
            {
                this.SetCaminhoFilePararRobo("C:\\openspan\\parar_agendado_robo.txt");
            }

            DbDataReader reader = Select("SELECT CAMINHO FROM BATPARARROBO");
            reader.Read();
            tipo = reader["CAMINHO"].ToString();
            reader.Close();

            return tipo;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public void SetCaminhoFileIniciaRobo(string caminho)
        {
            if (!ExistsTable("BATINICIARROBO"))
            {
                CreateTable("CREATE TABLE BATINICIARROBO( CAMINHO VARCHAR(1000) DEFAULT 'C:\\openspan\\iniciar_agendado_robo.txt' NOT NULL)");
            }
            if (!Select("SELECT 1 FROM BATINICIARROBO").Read())
            {
                Insert("INSERT INTO BATINICIARROBO (CAMINHO) VALUES ('C:\\openspan\\iniciar_agendado_robo.txt')");
            }

            Update("UPDATE BATINICIARROBO SET CAMINHO = '" + caminho + "'");
            Global.caminhoArtefatosDestino = caminho;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public string GetCaminhoFileIniciaRobo()
        {
            string tipo = string.Empty;
            if (!ExistsTable("BATINICIARROBO"))
            {
                this.SetCaminhoFileIniciaRobo("C:\\openspan\\iniciar_agendado_robo.txt");
            }

            DbDataReader reader = Select("SELECT CAMINHO FROM BATINICIARROBO");
            reader.Read();
            tipo = reader["CAMINHO"].ToString();
            reader.Close();

            return tipo;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public void SetCaminhoFileReiniciaRobo(string caminho)
        {
            if (!ExistsTable("BATREINICIARROBO"))
            {
                CreateTable("CREATE TABLE BATREINICIARROBO( CAMINHO VARCHAR(1000) DEFAULT 'C:\\openspan\\restart_agendado_robo.txt' NOT NULL)");
            }
            if (!Select("SELECT 1 FROM BATREINICIARROBO").Read())
            {
                Insert("INSERT INTO BATREINICIARROBO (CAMINHO) VALUES ('C:\\openspan\\restart_agendado_robo.txt')");
            }

            Update("UPDATE BATREINICIARROBO SET CAMINHO = '" + caminho + "'");
            Global.caminhoArtefatosDestino = caminho;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public string GetCaminhoFileReiniciaRobo()
        {
            string tipo = string.Empty;
            if (!ExistsTable("BATREINICIARROBO"))
            {
                this.SetCaminhoFileReiniciaRobo("C:\\openspan\\restart_agendado_robo.txt");
            }

            DbDataReader reader = Select("SELECT CAMINHO FROM BATREINICIARROBO");
            reader.Read();
            tipo = reader["CAMINHO"].ToString();
            reader.Close();

            return tipo;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public void SetCaminhoFileReiniciaVM(string caminho)
        {
            if (!ExistsTable("BATREINICIARVM"))
            {
                CreateTable("CREATE TABLE BATREINICIARVM( CAMINHO VARCHAR(1000) DEFAULT 'C:\\openspan\\restart_agendado_vm.txt' NOT NULL)");
            }
            if (!Select("SELECT 1 FROM BATREINICIARVM").Read())
            {
                Insert("INSERT INTO BATREINICIARVM (CAMINHO) VALUES ('C:\\openspan\\restart_agendado_vm.txt')");
            }

            Update("UPDATE BATREINICIARVM SET CAMINHO = '" + caminho + "'");
            Global.caminhoArtefatosDestino = caminho;
        }

        /// <summary>
        /// Método que seta o Log
        /// </summary>
        public string GetCaminhoFileReiniciaVM()
        {
            string tipo = string.Empty;
            if (!ExistsTable("BATREINICIARVM"))
            {
                this.SetCaminhoFileReiniciaVM("C:\\openspan\\restart_agendado_vm.txt");
            }

            DbDataReader reader = Select("SELECT CAMINHO FROM BATREINICIARVM");
            reader.Read();
            tipo = reader["CAMINHO"].ToString();
            reader.Close();

            return tipo;
        }

        /// <summary>
        /// Método que converte a data para int 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public abstract int Date_to_Int(DateTime date);

    }
}
