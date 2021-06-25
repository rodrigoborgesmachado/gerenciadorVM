using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class UC_CadastroServidor : UserControl
    {
        #region Atributos

        /// <summary>
        /// Constrolador da tarefa que a tela está executando
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUINDO;

        /// <summary>
        /// Controle da classe tabela da tela
        /// </summary>
        Model.MD_Servidores servidorCorrente = null;

        /// <summary>
        /// Controle da classe da tela principal
        /// </summary>
        Principal principal;

        #endregion Atributos

        #region Eventos

        /// <summary>
        /// Evento lançado no clique de fechar o botão fechar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_SERVIDOR);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre o nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_ip_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.btn_info_ip_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.Message.MensagemInformacao("IP para acesso ao servidor.");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre a descrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tipo_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.btn_tipo_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.Message.MensagemInformacao("Tipo servidor (desenvolvimento ou produção).");
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            this.Inserir();
        }

        /// <summary>
        /// Evento lançado no botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.btn_excluir_Click()", Util.Global.TipoLog.DETALHADO);

            this.Excluir();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tarefa">tarefa a ser realizada na tela</param>
        /// <param name="servidor">Instancia da classe de tabela</param>
        /// <param name="principal">Tela principal para controle do visual</param>
        public UC_CadastroServidor(Util.Enumerator.Tarefa tarefa, Model.MD_Servidores servidor, Principal principal)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor()", Util.Global.TipoLog.DETALHADO);

            this.InitializeComponent();

            this.servidorCorrente = servidor;
            this.principal = principal;
            this.tarefa = tarefa;
            this.InicializaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        public void InicializaUserControl()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.InicializaUserControl()", Util.Global.TipoLog.DETALHADO);

            this.Dock = DockStyle.Fill;
            if (this.tarefa != Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.PreecheCampos();
            }

            this.CarregaBotoes();
        }

        /// <summary>
        /// Método que preenche os campos
        /// </summary>
        private void PreecheCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.PreecheCampos()", Util.Global.TipoLog.DETALHADO);

            if (this.servidorCorrente != null)
            {
                this.tbx_link.Text = this.servidorCorrente.DAO.Link;
                this.cmb_tipo.SelectedIndex = this.servidorCorrente.DAO.Tipo.Equals("0") ? 0 : 1;
            }

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tbx_link.Enabled = false;
                this.cmb_tipo.Enabled = false;
            }
            else
            {
                this.tbx_link.Enabled = true;
                this.cmb_tipo.Enabled = true;
            }
        }

        /// <summary>
        /// Método que carrega os botões
        /// </summary>
        private void CarregaBotoes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.CarregaBotoes()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }
        }

        /// <summary>
        /// Método que faz a validação dos campos do formulário
        /// </summary>
        /// <returns>True - Correto; False - incorreto</returns>
        private bool ValidaCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.ValidaCampos()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_link.Text))
            {
                retorno = false;
                this.tbx_link.Focus();
                Visao.Message.MensagemAlerta("Deve ser fornecido o nome da tabela!");
            }
            else if(this.cmb_tipo.SelectedIndex < 0)
            {
                retorno = false;
                this.cmb_tipo.Focus();
                Visao.Message.MensagemAlerta("Não foi selecionado o tipo do servidor");
            }

            return retorno;
        }

        /// <summary>
        /// Método que faz a inserção
        /// </summary>
        private void Inserir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.Inserir()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.InicializaUserControl();
            }
            else
            {
                if (this.ValidaCampos())
                {
                    this.CarregaCampos();

                    this.Insere();
                    this.principal.CarregaTreeViewAutomaticamente();

                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                    this.InicializaUserControl();
                }
            }
        }

        /// <summary>
        /// Método que carrega os campos no objeto
        /// </summary>
        private void CarregaCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.CarregaCampos()", Util.Global.TipoLog.DETALHADO);

            if(this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.servidorCorrente = new Model.MD_Servidores(DataBase.Connection.GetIncrement(new DAO.MD_Servidores().table.Table_Name));
            }

            servidorCorrente.DAO.Link = this.tbx_link.Text;
            servidorCorrente.DAO.Tipo = this.cmb_tipo.SelectedIndex == 0 ? "0" : "1";
        }

        /// <summary>
        /// Método que insere o objeto
        /// </summary>
        private void Insere()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.Insere()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                if (this.servidorCorrente.DAO.Insert())
                {
                    MessageBox.Show("Tabela incluída com sucesso!", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao incluir!", "ERRO");
                }
            }
            else
            {
                if (this.servidorCorrente.DAO.Update())
                {
                    MessageBox.Show("Tabela alterada com sucesso!", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao alterar!", "ERRO");
                }
            }
        }

        /// <summary>
        /// Método que faz a exclusão
        /// </summary>
        private void Excluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroServidor.Excluir()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                if (Visao.Message.MensagemConfirmaçãoYesNo("Deseja excluir o servidor " + this.servidorCorrente.DAO.Link + "?") == DialogResult.Yes)
                {
                    if (this.servidorCorrente.DAO.Delete())
                    {
                        MessageBox.Show("Excluído com sucesso!", "Sucesso");
                        this.principal.CarregaTreeViewAutomaticamente();
                        this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_SERVIDOR);
                    }
                }
            }
            else
            {
                if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
                {
                    this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_SERVIDOR);
                }
                else
                {
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                    this.InicializaUserControl();
                }
            }
        }

        #endregion Métodos
        
    }
}
