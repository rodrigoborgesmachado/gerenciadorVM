using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Util.Enumerator;

namespace View
{
    public partial class Principal : Form
    {
        #region Atributos e Propriedades
        
        /// <summary>
        /// Controle de eventos da tela
        /// </summary>
        bool lockchange = false;

        List<TabPage> pages = new List<TabPage>();
        /// <summary>
        /// Páginas abertas
        /// </summary>
        public List<TabPage> Pages
        {
            get
            {
                return pages;
            }
            set
            {
                this.pages = value;
            }
        }

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão atualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.btn_atualizar_Click()", Util.Global.TipoLog.DETALHADO);

            this.CarregaTreeView();
        }

        /// <summary>
        /// Evento lançado no clique de novo projeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_servidor_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.btn_novo_projeto_Click()", Util.Global.TipoLog.DETALHADO);

            AbrirJanelaDeCadastroServidor(Util.Enumerator.Tarefa.INCLUINDO);
        }

        /// <summary>
        /// CArrega informações após seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trv_projetos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.trv_projetos_AfterSelect()", Util.Global.TipoLog.DETALHADO);

            if (this.trv_servidores.SelectedNode == null)
                return;
            else if (this.trv_servidores.SelectedNode.Tag == null)
                return;

            string codigo = this.trv_servidores.SelectedNode.Tag.ToString();
            this.AbrirJanela(codigo);
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_editarServidor_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_editar_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            this.AbrirJanelaDeCadastroServidor(Tarefa.EDITANDO, int.Parse(codigo));
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_excluirServidor_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_excluir_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Servidores project = new Model.MD_Servidores(int.Parse(codigo));
            if (MessageBox.Show("Deseja excluir o servidor " + project.DAO.Link + "?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (project.DAO.Delete())
                    MessageBox.Show("Excluído com sucesso!");
                else
                    MessageBox.Show("Erro ao excluir!");

                this.CarregaTreeViewAutomaticamente();
                this.FecharTela(Telas.CADASTRO_SERVIDOR);
            }
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IniciarRobos_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IniciarRobos_click()", Util.Global.TipoLog.DETALHADO);

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Iniciando Robos");
            barra.Show();
            Rules.FuncoesRobos.IniciarRobos();
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("Robos inicializados");
        }

        /// <summary>
        /// Método para reiniciar a vm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reiniciarVMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.reiniciarVMToolStripMenuItem_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Reiniciando VMS");
            barra.Show();
            Rules.FuncoesRobos.ReiniciarVM();
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("VMS Reiniciadas");
        }

        /// <summary>
        /// Evento lançado na opção de copiar arquivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copiarArquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IniciarRobos_click()", Util.Global.TipoLog.DETALHADO);

            this.AbrirJanelaCopiar();
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copiar_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IniciarRobos_click()", Util.Global.TipoLog.DETALHADO);

            this.AbrirJanelaCopiar();
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copiarUnico_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IniciarRobos_click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            this.AbrirJanelaCopiar(new Model.MD_Servidores(int.Parse(codigo)));
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iniciar_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IniciarRobos_click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Servidores servidor = new Model.MD_Servidores(int.Parse(codigo));

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Iniciando Robo " + servidor.DAO.Link);
            barra.Show();
            Rules.FuncoesRobos.IniciarRobos(servidor);
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("Robos inicializado");
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void parar_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IniciarRobos_click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Servidores servidor = new Model.MD_Servidores(int.Parse(codigo));

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Parando Robo " + servidor.DAO.Link);
            barra.Show();
            Rules.FuncoesRobos.PararRobos(servidor);
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("Robo parado");
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reiniciar_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IniciarRobos_click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Servidores servidor = new Model.MD_Servidores(int.Parse(codigo));

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Reiniciando Robo " + servidor.DAO.Link);
            barra.Show();
            Rules.FuncoesRobos.ReiniciarRobos(servidor);
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("Robo reiniciado");
        }

        /// <summary>
        /// Evento disparado no clique do botão de reiniciar a VM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reiniciarVM_click_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.reiniciarVM_click_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Servidores servidor = new Model.MD_Servidores(int.Parse(codigo));

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Reiniciando a VM " + servidor.DAO.Link);
            barra.Show();
            Rules.FuncoesRobos.ReiniciarVM(servidor);
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("VM reiniciado");
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PararRobo_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.PararRobo_click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Parando Robos");
            barra.Show();
            Rules.FuncoesRobos.PararRobos();
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("Robos parados");
        }

        /// <summary>
        /// Método que reinicia os robôs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reiniciarRobosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.reiniciarRobosToolStripMenuItem_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Parando Robos");
            barra.Show();
            Rules.FuncoesRobos.ReiniciarRobos();
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("Robos parados");
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PararRobos_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.PararRobos_click()", Util.Global.TipoLog.DETALHADO);

            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Parando Robos");
            barra.Show();
            Rules.FuncoesRobos.PararRobos();
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("Robos parados");
        }

        /// <summary>
        /// Evento lançado no clique das opções do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reiniciarRobos_click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.PararRobos_click()", Util.Global.TipoLog.DETALHADO);
            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(10, "Parando Robos");
            barra.Show();
            Rules.FuncoesRobos.ReiniciarRobos();
            barra.AvancaBarra(10);
            barra.Dispose();
            Visao.Message.MensagemSucesso("Robos parados");

        }

        /// <summary>
        /// Evento lançado quando a opção de log é alterada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsp_log_simples_CheckedChanged(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.Tsp_log_simples_CheckedChanged()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tsp_log_simples.Checked = true;
            tsp_log_detalhado.Checked = !tsp_log_simples.Checked;
            DataBase.Connection.SetLog(Util.Global.TipoLog.SIMPLES);
            Util.Global.log_system = DataBase.Connection.GetLog();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado quando o texto de origem dos artefatos é alterado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsp_tbx_origemArtefatos_TextChanged(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.tsp_tbx_origemArtefatos_TextChanged()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            DataBase.Connection.SetArtefatosOrigem(this.tsp_tbx_origemArtefatos.Text);
            Util.Global.caminhoArtefatosOrigem = this.tsp_tbx_origemArtefatos.Text;

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado quando o campo de destino dos artefatos é alterado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsp_tbx_destinoArtefatos_TextChanged(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.tsp_tbx_origemArtefatos_TextChanged()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            DataBase.Connection.SetArtefatosDestino(this.tsp_tbx_destinoArtefatos.Text);
            Util.Global.caminhoArtefatosDestino = this.tsp_tbx_destinoArtefatos.Text;

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado quando a opção de log é alterada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsp_log_detalhado_CheckedChanged(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.Tsp_log_detalhado_CheckedChanged()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tsp_log_detalhado.Checked = true;
            tsp_log_simples.Checked = !tsp_log_detalhado.Checked;
            DataBase.Connection.SetLog(Util.Global.TipoLog.DETALHADO);
            Util.Global.log_system = DataBase.Connection.GetLog();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado quando a opção de carregar tree view manual é alterada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TspNao_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.TspNao_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tspNao.Checked = true;
            tspSim.Checked = !tspNao.Checked;
            DataBase.Connection.SetAutomatico(Util.Global.Automatico.Manual);
            Util.Global.CarregarAutomaticamente = DataBase.Connection.GetAutomatico();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado quando a opção de carregar tree view automático é alterada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TspSim_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.TspSim_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tspSim.Checked = true;
            tspNao.Checked = !tspSim.Checked;
            DataBase.Connection.SetAutomatico(Util.Global.Automatico.Automatico);
            Util.Global.CarregarAutomaticamente = DataBase.Connection.GetAutomatico();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado no clique do botão expandir do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_expandTree_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.btn_expandTree_Click()", Util.Global.TipoLog.DETALHADO);

            this.trv_servidores.ExpandAll();
        }

        /// <summary>
        /// Evento lançado no clique do botão recolher do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_inplandsTree_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.btn_inplandsTree_Click()", Util.Global.TipoLog.DETALHADO);

            this.trv_servidores.CollapseAll();
        }

        /// <summary>
        /// Evento lançado no clique da opção de abrir as tarefas executadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tarefasExecutadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirJanelaLogs();
        }

        #endregion Eventos

        #region Contrutores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public Principal()
        {
            InitializeComponent();
            this.IniciaForm();
        }

        #endregion Contrutores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        private void IniciaForm()
        {
            this.lbl_valorVersao.Text = Application.ProductVersion;
            this.CarregaMenuAutomatico();
            this.CarregaMenuOpcoes();
            this.CarregaMenuCaminho();
            this.CarregaTreeView();
        }

        /// <summary>
        /// Método que carrega o menu de opções
        /// </summary>
        public void CarregaMenuCaminho()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaMenuCaminho()", Util.Global.TipoLog.DETALHADO);

            lockchange = true;

            this.tsp_tbx_origemArtefatos.Text = Util.Global.caminhoArtefatosOrigem;
            this.tsp_tbx_destinoArtefatos.Text = Util.Global.caminhoArtefatosDestino;
            this.tsp_tbx_paraRobo.Text = Util.Global.caminhoFilePararRobo;
            this.tsp_tbx_reiniciaRobo.Text = Util.Global.caminhoFileReiniciarRobo;
            this.tsp_tbx_reniciaVM.Text = Util.Global.caminhoFileReiniciarVM;

            lockchange = false;
        }

        /// <summary>
        /// Método que carrega o menu de opções
        /// </summary>
        public void CarregaMenuOpcoes()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaMenuOpcoes()", Util.Global.TipoLog.DETALHADO);

            lockchange = true;

            this.tsp_log_simples.Click += Tsp_log_simples_CheckedChanged;
            this.tsp_log_detalhado.Click += Tsp_log_detalhado_CheckedChanged;

            this.tsp_log_detalhado.Checked = Util.Global.log_system == Util.Global.TipoLog.DETALHADO;
            this.tsp_log_simples.Checked = !tsp_log_detalhado.Checked;

            lockchange = false;
        }

        /// <summary>
        /// Método que carrega as opções de carrega tree view automaticamente
        /// </summary>
        public void CarregaMenuAutomatico()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaMenuAutomatico()", Util.Global.TipoLog.DETALHADO);

            lockchange = true;

            tspSim.Click += TspSim_Click;
            tspNao.Click += TspNao_Click;

            tspSim.Checked = Util.Global.CarregarAutomaticamente == Util.Global.Automatico.Automatico;
            tspNao.Checked = !tspSim.Checked;

            lockchange = false;
        }


        /// <summary>
        /// Método que carrega treeview se o mesmo for automático
        /// </summary>
        public void CarregaTreeViewAutomaticamente()
        {
            if(Util.Global.CarregarAutomaticamente == Util.Global.Automatico.Automatico)
            {
                this.CarregaTreeView();
            }
        }

        /// <summary>
        /// Método que carrega o treeView
        /// </summary>
        private void CarregaTreeView()
        {
            this.trv_servidores.Nodes.Clear();
            Visao.BarraDeCarregamento aguarde = new Visao.BarraDeCarregamento(Model.MD_Servidores.ListaServidores().Count(), "Carregando TreeView");

            this.trv_servidores.Nodes.Add(this.MontaServidores(ref aguarde));
        }

        /// <summary>
        /// Método que carrega os projetos cadastrados e os coloca no treeView
        /// </summary>
        private TreeNode MontaServidores(ref Visao.BarraDeCarregamento aguarde)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.MontaServidores()", Util.Global.TipoLog.DETALHADO);

            TreeNode servidores = new TreeNode("Servidores");

            foreach(Model.MD_Servidores servidor in Model.MD_Servidores.ListaServidores())
            {
                aguarde.AvancaBarra(1);

                TreeNode node = new TreeNode(servidor.DAO.Link);
                node.Tag = "servidor:" + servidor.DAO.Codigo;
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;

                node.ContextMenu = this.MontaMenuServidor(servidor);

                servidores.Nodes.Add(node);
            }

            servidores.ContextMenu = this.MontaMenuPrincipal();
            servidores.Expand();

            return servidores;
        }

        /// <summary>
        /// Método que preenche o menu do node de servidor
        /// </summary>
        /// <param name="servidor"></param>
        /// <param name="node"></param>
        private ContextMenu MontaMenuServidor(Model.MD_Servidores servidor)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.MontaMenuServidor()", Util.Global.TipoLog.DETALHADO);

            ContextMenu menu = new ContextMenu();

            MenuItem item_editar = new MenuItem("Editar", item_editarServidor_Click);
            item_editar.Tag = servidor.DAO.Codigo;

            MenuItem item_excluir = new MenuItem("Excluir", item_excluirServidor_selected_Click);
            item_excluir.Tag = servidor.DAO.Codigo;

            MenuItem item_copiar = new MenuItem("Copiar Arquivos", copiarUnico_click);
            item_copiar.Tag = servidor.DAO.Codigo;

            MenuItem item_fechar = new MenuItem("Parar Robo", parar_click);
            item_fechar.Tag = servidor.DAO.Codigo;

            MenuItem item_reiniciar = new MenuItem("Reiniciar Robo", reiniciar_click);
            item_reiniciar.Tag = servidor.DAO.Codigo;

            MenuItem item_reiniciarVM = new MenuItem("Reiniciar VM", reiniciarVM_click_Click);
            item_reiniciarVM.Tag = servidor.DAO.Codigo;

            menu.MenuItems.Add(item_editar);
            menu.MenuItems.Add(item_excluir);
            menu.MenuItems.Add(item_copiar);
            menu.MenuItems.Add(item_fechar);
            menu.MenuItems.Add(item_reiniciar);
            menu.MenuItems.Add(item_reiniciarVM);
            
            return menu;
        }

        /// <summary>
        /// Método que preenche o menu do node de servidor
        /// </summary>
        /// <param name="servidor"></param>
        /// <param name="node"></param>
        private ContextMenu MontaMenuPrincipal()
        {
            ContextMenu menu = new ContextMenu();

            MenuItem item_incluir = new MenuItem("Incluir Servidor", this.btn_novo_servidor_Click);
            MenuItem item_copiarArquivos = new MenuItem("Copiar Arquivos", this.copiar_click);
            MenuItem item_iniciarRobos = new MenuItem("Iniciar Robos", this.IniciarRobos_click);
            MenuItem item_pararRobos = new MenuItem("Parar Robos", this.PararRobos_click);
            MenuItem item_reiniciarRobos = new MenuItem("Reiniciar Robos", this.reiniciarRobos_click);
            MenuItem item_reiniciarVMS = new MenuItem("Reiniciar VMs", this.reiniciarVMToolStripMenuItem_Click);

            menu.MenuItems.Add(item_incluir);
            menu.MenuItems.Add(item_copiarArquivos);
            menu.MenuItems.Add(item_iniciarRobos);
            menu.MenuItems.Add(item_pararRobos);
            menu.MenuItems.Add(item_reiniciarRobos);
            menu.MenuItems.Add(item_reiniciarVMS);
            
            return menu;
        }

        /// <summary>
        /// Método que abre a janela de cadastro de projeto
        /// </summary>
        public void AbrirJanelaDeCadastroServidor(Util.Enumerator.Tarefa tarefa, int codigo = -1)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirJanelaDeCadastroProjeto()", Util.Global.TipoLog.DETALHADO);

            Model.MD_Servidores proj = new Model.MD_Servidores(codigo);
            this.AbreJanela(new UC_CadastroServidor(tarefa, proj, this), "Cadastro de Projeto", Telas.CADASTRO_SERVIDOR);
        }

        /// <summary>
        /// Método que abre a janela para visualização
        /// </summary>
        /// <param name="code">Código da janela a ser aberta</param>
        public void AbrirJanela(string code)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirJanela()", Util.Global.TipoLog.DETALHADO);

            string janela = code.Split(':')[0];

            if (janela.Equals("servidor"))
            {
                int cod = int.Parse(code.Split(':')[1]);
                this.AbrirJanelaDeCadastroServidor(Tarefa.VISUALIZANDO, cod);
            }
        }

        /// <summary>
        /// Método que abre a janela de copiar os arquivos
        /// </summary>
        public void AbrirJanelaCopiar(Model.MD_Servidores servidor = null)
        {
            UC_CopiarArquivos copiar = servidor == null ? new UC_CopiarArquivos(this) : new UC_CopiarArquivos(this, servidor);
            AbreJanela(copiar, "Copiar Arquivos", Telas.COPIAR_ARQUIVOS);
        }

        /// <summary>
        /// Método que abre a janela de logs
        /// </summary>
        public void AbrirJanelaLogs()
        {
            AbreJanela(new UC_Historico(this), "Histórico de Tarefas", Telas.TELA_TAREFAS);
        }

        /// <summary>
        /// Método que abre uma nova aba no tab page
        /// </summary>
        /// <param name="control">User control a ser aberto dentro da page</param>
        /// <param name="titulo">Título da aba da página a ser aberta</param>
        public void AbreJanela(UserControl control, string titulo, Telas tag)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbreJanela()", Util.Global.TipoLog.DETALHADO);

            int index = 0;
            Telas tag_aberto = Telas.CADASTRO_SERVIDOR;
            bool aberto = false;
            foreach (TabPage p in pages)
            {
                if ((int)p.Tag == (int)tag)
                {
                    tag_aberto = (Telas)p.Tag;
                    aberto = true;
                    break;
                }
                else index++;
            }

            if (aberto)
                FecharTela(tag_aberto);
            TabPage page = new TabPage(titulo);

            TabPage tabPage1 = new TabPage(titulo);
            tabPage1.Tag = (int)tag;
            pages.Add(tabPage1);

            tabPage1.Controls.Add(control);
            this.tbc_table_control.Controls.Add(tabPage1);
            this.tbc_table_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_table_control.Name = titulo;

            index = 0;
            foreach (TabPage p in this.tbc_table_control.Controls)
            {
                if ((int)p.Tag == (int)tag)
                    break;
                index++;
            }

            this.tbc_table_control.TabIndex = index;
            this.tbc_table_control.SelectedIndex = index;
        }

        /// <summary>
        /// Método que fecha a tela
        /// </summary>
        /// <param name="tag"></param>
        public void FecharTela(Util.Enumerator.Telas tag)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.FecharTela()", Util.Global.TipoLog.DETALHADO);

            int index = 0;
            foreach (TabPage p in pages)
            {
                if ((int)p.Tag == (int)tag)
                {
                    p.Dispose();
                    break;
                }
                else index++;
            }

            if (index < pages.Count)
                pages.RemoveAt(index);
        }

        #endregion Métodos

        
    }
}
