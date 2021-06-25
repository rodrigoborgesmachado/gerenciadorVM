using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace View
{
    public partial class UC_CopiarArquivos : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Controle da tela principal
        /// </summary>
        Principal principal = null;

        /// <summary>
        /// Lista dos seridores cadastrados
        /// </summary>
        List<Model.MD_Servidores> servidoresCadastrados = new List<Model.MD_Servidores>();

        /// <summary>
        /// Lista dos servidores que serão feito copias
        /// </summary>
        List<Model.MD_Servidores> servidoresCopiados = new List<Model.MD_Servidores>();

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Eveto lançado no clique do botão fechar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.COPIAR_ARQUIVOS);
            this.Dispose();
        }

        /// <summary>
        /// Evento lançado no clique do botão de informações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_origem_Click(object sender, EventArgs e)
        {
            Visao.Message.MensagemInformacao("Caminho da pasta de origem dos arquivos");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_detino_Click(object sender, EventArgs e)
        {
            Visao.Message.MensagemInformacao("Caminho relativo da pasta de destino dos arquivos. Esse caminho será selecionado na VM.");
        }

        /// <summary>
        /// Evento lançado quando o textbox do diretório de origem recebe um valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_diretorioOrigem_TextChanged(object sender, EventArgs e)
        {
            DataBase.Connection.SetArtefatosOrigem(this.tbx_diretorioOrigem.Text);
        }

        /// <summary>
        /// Evento lançado quando o textbox do diretório de destino recebe um valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_diretorioDestino_TextChanged(object sender, EventArgs e)
        {
            DataBase.Connection.SetArtefatosDestino(this.tbx_diretorioDestino.Text);
        }

        /// <summary>
        /// Evento disparado no clique do botão origem para selecionar a pasta de origem dos arquivos a serem copiados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_origem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Diretório onde estão os arquivos a serem copiados";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.tbx_diretorioOrigem.Text = dialog.SelectedPath.ToString() + "\\";
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de incluir vínculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionarCopiar_Click(object sender, EventArgs e)
        {
            AdicionarCopiar();
        }

        /// <summary>
        /// Evento lançado no cliqye do botão para incluir vínculo com todos os servidores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionartodosCopias_Click(object sender, EventArgs e)
        {
            this.servidoresCadastrados = new List<Model.MD_Servidores>();
            this.servidoresCopiados = Model.MD_Servidores.ListaServidores();
            this.servidoresCopiados.ForEach(servidor => this.FillGridCopiasCadastrados(servidor));
            this.dgv_servidoresCadastradas.Rows.Clear();
        }

        /// <summary>
        /// Evento lançado no clique do botão de remover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerVinculoMarca_Click(object sender, EventArgs e)
        {
            this.RemoverCopiar();
        }

        /// <summary>
        /// Evento lançado no clique do botão de remover todos os servidores a serem copiados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerVinculos_Click(object sender, EventArgs e)
        {
            this.servidoresCopiados = new List<Model.MD_Servidores>();
            this.servidoresCadastrados = Model.MD_Servidores.ListaServidores();
            this.servidoresCadastrados.ForEach(servidor => this.FillGridCopiasCadastrados(servidor));
            this.dgv_servidorCopiar.Rows.Clear();
            this.FillGridCadastrados();
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            this.Copiar();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="principal"></param>
        public UC_CopiarArquivos(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
            this.InicializaForm();
        }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="principal"></param>
        public UC_CopiarArquivos(Principal principal, Model.MD_Servidores servidor)
            : this(principal)
        {
            this.servidoresCadastrados.RemoveAll(serv => serv.DAO.Codigo == servidor.DAO.Codigo);
            this.FillGridCadastrados();
            this.servidoresCopiados.Add(servidor);
            this.FillGridCopiasCadastrados(servidor);
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        private void InicializaForm()
        {
            this.Dock = DockStyle.Fill;
            this.tbx_diretorioOrigem.Text = Util.Global.caminhoArtefatosOrigem;
            this.tbx_diretorioDestino.Text = Util.Global.caminhoArtefatosDestino;
            this.FillGrid();
        }

        /// <summary>
        /// Método que preenche os grids
        /// </summary>
        private void FillGrid()
        {
            this.servidoresCadastrados = Model.MD_Servidores.ListaServidores();
            this.FillGridCadastrados();
        }

        /// <summary>
        /// Método que preenche o grid dos servidores cadastrados
        /// </summary>
        private void FillGridCadastrados()
        {
            this.dgv_servidoresCadastradas.Columns.Clear();
            this.dgv_servidoresCadastradas.Rows.Clear();

            this.dgv_servidoresCadastradas.Columns.Add("SERVIDOR", "SERVIDOR");

            this.servidoresCadastrados.ForEach(servidor => FillGridCadastrados(servidor));
        }

        /// <summary>
        /// Método que insere no grid cadastrado o servidor passado em referencia
        /// </summary>
        /// <param name="servidor"></param>
        private void FillGridCadastrados(Model.MD_Servidores servidor)
        {
            if(this.dgv_servidoresCadastradas.Columns.Count == 0)
            {
                this.FillGridCadastrados();
            }
            else
            {
                List<string> lista = new List<string>();
                lista.Add(servidor.DAO.Link);

                this.dgv_servidoresCadastradas.Rows.Add(lista.ToArray());
            }
        }

        /// <summary>
        /// Método que insere no grid cadastrado o servidor passado em referencia
        /// </summary>
        /// <param name="servidor"></param>
        private void FillGridCopiasCadastrados(Model.MD_Servidores servidor)
        {
            if (this.dgv_servidorCopiar.Columns.Count == 0)
            {
                this.dgv_servidorCopiar.Columns.Clear();
                this.dgv_servidorCopiar.Rows.Clear();

                this.dgv_servidorCopiar.Columns.Add("SERVIDOR", "SERVIDOR");
            }

            List<string> lista = new List<string>();
            lista.Add(servidor.DAO.Link);

            this.dgv_servidorCopiar.Rows.Add(lista.ToArray());
        }

        /// <summary>
        /// Método que adiciona a lista de cadastrado para a de copias
        /// </summary>
        private void AdicionarCopiar()
        {
            if(this.dgv_servidoresCadastradas.SelectedRows.Count <= 0)
            {
                Visao.Message.MensagemAlerta("Selecione um servidor na tabela!");
            }
            else
            {
                int index = this.dgv_servidoresCadastradas.SelectedRows[0].Index;
                Model.MD_Servidores servidor = this.servidoresCadastrados.ElementAt(index);
                this.servidoresCopiados.Add(servidor);
                this.FillGridCopiasCadastrados(servidor);
                this.servidoresCadastrados.Remove(servidor);
                this.dgv_servidoresCadastradas.Rows.RemoveAt(index);
            }
        }

        /// <summary>
        /// Método que remove vínculo do servidor
        /// </summary>
        private void RemoverCopiar()
        {
            if (this.dgv_servidorCopiar.SelectedRows.Count <= 0)
            {
                Visao.Message.MensagemAlerta("Selecione um servidor na tabela!");
            }
            else
            {
                int index = this.dgv_servidorCopiar.SelectedRows[0].Index;
                Model.MD_Servidores servidor = this.servidoresCopiados.ElementAt(index);
                this.servidoresCadastrados.Add(servidor);
                this.FillGridCadastrados(servidor);
                this.servidoresCopiados.Remove(servidor);
                this.dgv_servidorCopiar.Rows.RemoveAt(index);
            }
        }

        /// <summary>
        /// Método que copia os arquivos do diretório de entrada para o de saída em cada servidor selecionado
        /// </summary>
        private void Copiar()
        {
            if (this.servidoresCopiados.Count == 0)
            {
                Visao.Message.MensagemAlerta("Nenhum servidor foi selecionado!");
            }
            else if (string.IsNullOrEmpty(this.tbx_diretorioOrigem.Text))
            {
                Visao.Message.MensagemAlerta("Diretório de origem não foi preenchido!");
                this.tbx_diretorioOrigem.Focus();
            }
            else if (!Directory.Exists(this.tbx_diretorioOrigem.Text))
            {
                Visao.Message.MensagemAlerta("Diretório de origem não foi preenchido corretamente, o diretório não existe!");
                this.tbx_diretorioOrigem.Focus();
            }
            else
            {
                if (!this.tbx_diretorioOrigem.Text[tbx_diretorioOrigem.Text.Count()-1].Equals('\\'))
                {
                    this.tbx_diretorioOrigem.Text = this.tbx_diretorioOrigem.Text + "\\";
                }

                Visao.Message.MensagemInformacao("Os arquivos do diretório " + this.tbx_diretorioOrigem.Text + " serão copiados para cada servidor no diretório relativo " + this.tbx_diretorioDestino.Text);

                Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(this.servidoresCopiados.Count, "Tratanto servidor");
                bool sucesso = false;
                barra.Show();
                this.servidoresCopiados.ForEach(servidor => Copiar(servidor, ref barra, ref sucesso));
                barra.Dispose();

                if (sucesso)
                {
                    Visao.Message.MensagemSucesso("Arquivos copiados com sucesso!");
                }
                else
                {
                    Visao.Message.MensagemErro("Erro ao copiar os arquivos!");
                }
            }
        }

        /// <summary>
        /// Método que copia para o servidor
        /// </summary>
        /// <param name="servidor"></param>
        private void Copiar(Model.MD_Servidores servidor, ref Visao.BarraDeCarregamento barra, ref bool sucesso)
        {
            string mensagem = string.Empty;
            Rules.CopiarArquivos.Copiar(servidor, out mensagem);
            barra.AvancaBarra(1);

            if (!string.IsNullOrEmpty(mensagem))
            {
                Visao.Message.MensagemErro("Erro no servidor " + servidor.DAO.Link + "\nErro: " + mensagem);
                sucesso = false;
            }
            else
            {
                sucesso = true;
            }
        }

        #endregion Métodos

    }
}
