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
    public partial class UC_Historico : UserControl
    {
        #region Atributos e Propriedades

        bool lockchange = false;

        /// <summary>
        /// Controle da tela principal
        /// </summary>
        Principal principal = null;

        /// <summary>
        /// Lista dos chamados
        /// </summary>
        List<Model.MD_Tarefas> listaTarefas = new List<Model.MD_Tarefas>();

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento disparado no clique do botão de fechar a tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.TELA_TAREFAS);
        }

        /// <summary>
        /// Evento disparado no clique do botão de recarregar o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reloadData_Click(object sender, EventArgs e)
        {
            this.FillGrid();
        }

        /// <summary>
        /// Evento disparado quando se seleciona um item no grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_chamados_SelectionChanged(object sender, EventArgs e)
        {
            this.PopulaLabels();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="principal"></param>
        public UC_Historico(Principal principal)
        {
            this.principal = principal;
            this.InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.IniciaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        private void IniciaForm()
        {
            lockchange = true;

            this.FillGrid();

            lockchange = false;
        }

        /// <summary>
        /// Método que popula as labels
        /// </summary>
        private void PopulaLabels()
        {
            if (this.dgv_tarefas.SelectedRows.Count == 0)
                return;

            Model.MD_Tarefas tarefa = this.listaTarefas.ElementAt(this.dgv_tarefas.SelectedRows[0].Index);
            this.lbl_codigo_valor.Text = tarefa.DAO.Codigo.ToString();
            this.lbl_data_valor.Text = tarefa.DAO.Dataexecucao;
            this.tbx_descricao.Text = tarefa.DAO.Descricao;
            this.lbl_status_valor.Text = tarefa.DAO.Status.Equals("0") ? "ERRO" : "SUCESSO";
            this.lbl_status_valor.ForeColor = tarefa.DAO.Status.Equals("0") ? Util.Cor.Red() : Util.Cor.Green();
        }

        /// <summary>
        /// Método que preenche o grid de chamados
        /// </summary>
        private void FillGrid()
        {
            this.listaTarefas = Model.MD_Tarefas.RetornaTodasTarefas();

            this.dgv_tarefas.Rows.Clear();
            this.dgv_tarefas.Columns.Clear();

            this.listaTarefas.ForEach(c => FillGrid(c));
        }

        /// <summary>
        /// Método que preenche o grid com o chamado
        /// </summary>
        /// <param name="suporte"></param>
        private void FillGrid(Model.MD_Tarefas suporte)
        {
            if (this.dgv_tarefas.Columns.Count == 0)
            {
                this.dgv_tarefas.Columns.Add("Código", "Código");
                this.dgv_tarefas.Columns.Add("Data de Execução", "Data de Execução");
                this.dgv_tarefas.Columns.Add("Descrição", "Descição");
                this.dgv_tarefas.Columns.Add("Status", "Status");
                this.dgv_tarefas.Columns.Add("Tipo", "Tipo");
            }

            List<string> linhas = new List<string>();
            linhas.Add(suporte.DAO.Codigo.ToString());
            linhas.Add(suporte.DAO.Dataexecucao);
            linhas.Add(suporte.DAO.Descricao);
            linhas.Add(suporte.DAO.Status.Equals("0") ? "ERRO" : "SUCESSO");
            linhas.Add(suporte.DAO.Tipo.Equals("0") ? "Copia de arquivos" : "Tarefa do robô");

            this.dgv_tarefas.Rows.Add(linhas.ToArray());
            DataGridViewRow row = this.dgv_tarefas.Rows[this.dgv_tarefas.Rows.Count - 1];

            row.DefaultCellStyle.BackColor = suporte.DAO.Status.Equals("1") ? Util.Cor.Green() : Util.Cor.Red();
            row.DefaultCellStyle.ForeColor = Util.Cor.Black();
        }

        #endregion Métodos
    }
}
