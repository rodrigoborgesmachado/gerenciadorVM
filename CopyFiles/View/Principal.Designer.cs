namespace View
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pan_central = new System.Windows.Forms.Panel();
            this.pan_principal = new System.Windows.Forms.Panel();
            this.tbc_table_control = new System.Windows.Forms.TabControl();
            this.pan_descricoes = new System.Windows.Forms.Panel();
            this.lbl_valorVersao = new System.Windows.Forms.Label();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.pan_left = new System.Windows.Forms.Panel();
            this.pan_projetos = new System.Windows.Forms.Panel();
            this.trv_servidores = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pan_opções = new System.Windows.Forms.Panel();
            this.btn_novo_projeto = new System.Windows.Forms.Button();
            this.pan_titulo = new System.Windows.Forms.Panel();
            this.lbl_título = new System.Windows.Forms.Label();
            this.mst_opcoes = new System.Windows.Forms.MenuStrip();
            this.tsm_opcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_tipLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_log_simples = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_log_detalhado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_carregarTreeViewAutomaticamente = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSim = new System.Windows.Forms.ToolStripMenuItem();
            this.tspNao = new System.Windows.Forms.ToolStripMenuItem();
            this.origemDosArtefatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_tbx_origemArtefatos = new System.Windows.Forms.ToolStripTextBox();
            this.destinoDosArtefatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_tbx_destinoArtefatos = new System.Windows.Forms.ToolStripTextBox();
            this.pathsIniciarRobosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_tbx_paraRobo = new System.Windows.Forms.ToolStripTextBox();
            this.pathReiniciarRobosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_tbx_reiniciaRobo = new System.Windows.Forms.ToolStripTextBox();
            this.pathReiniciaVMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_tbx_reniciaVM = new System.Windows.Forms.ToolStripTextBox();
            this.pararRobosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarRobosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarVMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarArquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_expandTree = new System.Windows.Forms.Button();
            this.btn_inplandsTree = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.tarefasExecutadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_central.SuspendLayout();
            this.pan_principal.SuspendLayout();
            this.pan_descricoes.SuspendLayout();
            this.pan_left.SuspendLayout();
            this.pan_projetos.SuspendLayout();
            this.pan_opções.SuspendLayout();
            this.pan_titulo.SuspendLayout();
            this.mst_opcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_central
            // 
            this.pan_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.pan_central.Controls.Add(this.pan_principal);
            this.pan_central.Controls.Add(this.pan_left);
            this.pan_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_central.Location = new System.Drawing.Point(0, 0);
            this.pan_central.Name = "pan_central";
            this.pan_central.Size = new System.Drawing.Size(831, 483);
            this.pan_central.TabIndex = 0;
            // 
            // pan_principal
            // 
            this.pan_principal.Controls.Add(this.tbc_table_control);
            this.pan_principal.Controls.Add(this.pan_descricoes);
            this.pan_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_principal.Location = new System.Drawing.Point(216, 0);
            this.pan_principal.Name = "pan_principal";
            this.pan_principal.Size = new System.Drawing.Size(615, 483);
            this.pan_principal.TabIndex = 3;
            // 
            // tbc_table_control
            // 
            this.tbc_table_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_table_control.Location = new System.Drawing.Point(0, 0);
            this.tbc_table_control.Name = "tbc_table_control";
            this.tbc_table_control.SelectedIndex = 0;
            this.tbc_table_control.Size = new System.Drawing.Size(615, 465);
            this.tbc_table_control.TabIndex = 0;
            // 
            // pan_descricoes
            // 
            this.pan_descricoes.Controls.Add(this.lbl_valorVersao);
            this.pan_descricoes.Controls.Add(this.lbl_empresa);
            this.pan_descricoes.Controls.Add(this.lbl_versao);
            this.pan_descricoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_descricoes.Location = new System.Drawing.Point(0, 465);
            this.pan_descricoes.Name = "pan_descricoes";
            this.pan_descricoes.Size = new System.Drawing.Size(615, 18);
            this.pan_descricoes.TabIndex = 2;
            // 
            // lbl_valorVersao
            // 
            this.lbl_valorVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_valorVersao.AutoSize = true;
            this.lbl_valorVersao.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lbl_valorVersao.Location = new System.Drawing.Point(574, 0);
            this.lbl_valorVersao.Name = "lbl_valorVersao";
            this.lbl_valorVersao.Size = new System.Drawing.Size(38, 15);
            this.lbl_valorVersao.TabIndex = 1;
            this.lbl_valorVersao.Text = "versao";
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lbl_empresa.Location = new System.Drawing.Point(456, -1);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(61, 15);
            this.lbl_empresa.TabIndex = 1;
            this.lbl_empresa.Text = "Copy Files";
            // 
            // lbl_versao
            // 
            this.lbl_versao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lbl_versao.Location = new System.Drawing.Point(518, -1);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(53, 15);
            this.lbl_versao.TabIndex = 1;
            this.lbl_versao.Text = "|   Versão:";
            // 
            // pan_left
            // 
            this.pan_left.Controls.Add(this.pan_projetos);
            this.pan_left.Controls.Add(this.pan_opções);
            this.pan_left.Controls.Add(this.pan_titulo);
            this.pan_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_left.Location = new System.Drawing.Point(0, 0);
            this.pan_left.Name = "pan_left";
            this.pan_left.Size = new System.Drawing.Size(216, 483);
            this.pan_left.TabIndex = 2;
            // 
            // pan_projetos
            // 
            this.pan_projetos.Controls.Add(this.trv_servidores);
            this.pan_projetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_projetos.Location = new System.Drawing.Point(0, 68);
            this.pan_projetos.Name = "pan_projetos";
            this.pan_projetos.Size = new System.Drawing.Size(216, 388);
            this.pan_projetos.TabIndex = 1;
            // 
            // trv_servidores
            // 
            this.trv_servidores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.trv_servidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_servidores.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.trv_servidores.ImageIndex = 0;
            this.trv_servidores.ImageList = this.imgList;
            this.trv_servidores.Location = new System.Drawing.Point(0, 0);
            this.trv_servidores.Name = "trv_servidores";
            this.trv_servidores.SelectedImageIndex = 0;
            this.trv_servidores.Size = new System.Drawing.Size(216, 388);
            this.trv_servidores.TabIndex = 0;
            this.trv_servidores.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_projetos_AfterSelect);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "database20x20.png");
            // 
            // pan_opções
            // 
            this.pan_opções.Controls.Add(this.btn_novo_projeto);
            this.pan_opções.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_opções.Location = new System.Drawing.Point(0, 456);
            this.pan_opções.Name = "pan_opções";
            this.pan_opções.Size = new System.Drawing.Size(216, 27);
            this.pan_opções.TabIndex = 0;
            // 
            // btn_novo_projeto
            // 
            this.btn_novo_projeto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_novo_projeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_novo_projeto.Location = new System.Drawing.Point(0, 0);
            this.btn_novo_projeto.Name = "btn_novo_projeto";
            this.btn_novo_projeto.Size = new System.Drawing.Size(216, 27);
            this.btn_novo_projeto.TabIndex = 0;
            this.btn_novo_projeto.Text = "Novo Servidor";
            this.btn_novo_projeto.UseVisualStyleBackColor = true;
            this.btn_novo_projeto.Click += new System.EventHandler(this.btn_novo_servidor_Click);
            // 
            // pan_titulo
            // 
            this.pan_titulo.Controls.Add(this.btn_expandTree);
            this.pan_titulo.Controls.Add(this.btn_inplandsTree);
            this.pan_titulo.Controls.Add(this.btn_atualizar);
            this.pan_titulo.Controls.Add(this.lbl_título);
            this.pan_titulo.Controls.Add(this.mst_opcoes);
            this.pan_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_titulo.Location = new System.Drawing.Point(0, 0);
            this.pan_titulo.Name = "pan_titulo";
            this.pan_titulo.Size = new System.Drawing.Size(216, 68);
            this.pan_titulo.TabIndex = 2;
            // 
            // lbl_título
            // 
            this.lbl_título.AutoSize = true;
            this.lbl_título.Location = new System.Drawing.Point(14, 47);
            this.lbl_título.Name = "lbl_título";
            this.lbl_título.Size = new System.Drawing.Size(68, 16);
            this.lbl_título.TabIndex = 0;
            this.lbl_título.Text = "Servidores";
            // 
            // mst_opcoes
            // 
            this.mst_opcoes.BackColor = System.Drawing.Color.White;
            this.mst_opcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_opcoes});
            this.mst_opcoes.Location = new System.Drawing.Point(0, 0);
            this.mst_opcoes.Name = "mst_opcoes";
            this.mst_opcoes.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mst_opcoes.Size = new System.Drawing.Size(216, 24);
            this.mst_opcoes.TabIndex = 1;
            this.mst_opcoes.Text = "menuStrip1";
            // 
            // tsm_opcoes
            // 
            this.tsm_opcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_tipLog,
            this.tsp_carregarTreeViewAutomaticamente,
            this.origemDosArtefatosToolStripMenuItem,
            this.destinoDosArtefatosToolStripMenuItem,
            this.pathsIniciarRobosToolStripMenuItem,
            this.pathReiniciarRobosToolStripMenuItem,
            this.pathReiniciaVMsToolStripMenuItem,
            this.pararRobosToolStripMenuItem,
            this.reiniciarRobosToolStripMenuItem,
            this.reiniciarVMToolStripMenuItem,
            this.copiarArquivosToolStripMenuItem,
            this.tarefasExecutadasToolStripMenuItem});
            this.tsm_opcoes.Name = "tsm_opcoes";
            this.tsm_opcoes.Size = new System.Drawing.Size(59, 20);
            this.tsm_opcoes.Text = "Opções";
            // 
            // tsp_tipLog
            // 
            this.tsp_tipLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_log_simples,
            this.tsp_log_detalhado});
            this.tsp_tipLog.Name = "tsp_tipLog";
            this.tsp_tipLog.Size = new System.Drawing.Size(192, 22);
            this.tsp_tipLog.Text = "Log";
            // 
            // tsp_log_simples
            // 
            this.tsp_log_simples.Name = "tsp_log_simples";
            this.tsp_log_simples.Size = new System.Drawing.Size(128, 22);
            this.tsp_log_simples.Text = "Simples";
            // 
            // tsp_log_detalhado
            // 
            this.tsp_log_detalhado.Name = "tsp_log_detalhado";
            this.tsp_log_detalhado.Size = new System.Drawing.Size(128, 22);
            this.tsp_log_detalhado.Text = "Detalhado";
            // 
            // tsp_carregarTreeViewAutomaticamente
            // 
            this.tsp_carregarTreeViewAutomaticamente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspSim,
            this.tspNao});
            this.tsp_carregarTreeViewAutomaticamente.Name = "tsp_carregarTreeViewAutomaticamente";
            this.tsp_carregarTreeViewAutomaticamente.Size = new System.Drawing.Size(192, 22);
            this.tsp_carregarTreeViewAutomaticamente.Text = "Tree view automatico";
            // 
            // tspSim
            // 
            this.tspSim.Name = "tspSim";
            this.tspSim.Size = new System.Drawing.Size(142, 22);
            this.tspSim.Text = "Carregar";
            // 
            // tspNao
            // 
            this.tspNao.Name = "tspNao";
            this.tspNao.Size = new System.Drawing.Size(142, 22);
            this.tspNao.Text = "Não carregar";
            // 
            // origemDosArtefatosToolStripMenuItem
            // 
            this.origemDosArtefatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_tbx_origemArtefatos});
            this.origemDosArtefatosToolStripMenuItem.Name = "origemDosArtefatosToolStripMenuItem";
            this.origemDosArtefatosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.origemDosArtefatosToolStripMenuItem.Text = "Origem dos Artefatos";
            // 
            // tsp_tbx_origemArtefatos
            // 
            this.tsp_tbx_origemArtefatos.Name = "tsp_tbx_origemArtefatos";
            this.tsp_tbx_origemArtefatos.Size = new System.Drawing.Size(100, 23);
            this.tsp_tbx_origemArtefatos.TextChanged += new System.EventHandler(this.tsp_tbx_origemArtefatos_TextChanged);
            // 
            // destinoDosArtefatosToolStripMenuItem
            // 
            this.destinoDosArtefatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_tbx_destinoArtefatos});
            this.destinoDosArtefatosToolStripMenuItem.Name = "destinoDosArtefatosToolStripMenuItem";
            this.destinoDosArtefatosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.destinoDosArtefatosToolStripMenuItem.Text = "Destino dos Artefatos";
            // 
            // tsp_tbx_destinoArtefatos
            // 
            this.tsp_tbx_destinoArtefatos.Enabled = false;
            this.tsp_tbx_destinoArtefatos.Name = "tsp_tbx_destinoArtefatos";
            this.tsp_tbx_destinoArtefatos.Size = new System.Drawing.Size(100, 23);
            this.tsp_tbx_destinoArtefatos.TextChanged += new System.EventHandler(this.tsp_tbx_destinoArtefatos_TextChanged);
            // 
            // pathsIniciarRobosToolStripMenuItem
            // 
            this.pathsIniciarRobosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_tbx_paraRobo});
            this.pathsIniciarRobosToolStripMenuItem.Name = "pathsIniciarRobosToolStripMenuItem";
            this.pathsIniciarRobosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pathsIniciarRobosToolStripMenuItem.Text = "Path Parar Robos";
            // 
            // tsp_tbx_paraRobo
            // 
            this.tsp_tbx_paraRobo.Enabled = false;
            this.tsp_tbx_paraRobo.Name = "tsp_tbx_paraRobo";
            this.tsp_tbx_paraRobo.Size = new System.Drawing.Size(100, 23);
            this.tsp_tbx_paraRobo.Text = "C:\\openspan\\ReiniciaRobo\\KillWatcher.bat";
            // 
            // pathReiniciarRobosToolStripMenuItem
            // 
            this.pathReiniciarRobosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_tbx_reiniciaRobo});
            this.pathReiniciarRobosToolStripMenuItem.Name = "pathReiniciarRobosToolStripMenuItem";
            this.pathReiniciarRobosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pathReiniciarRobosToolStripMenuItem.Text = "Path Reiniciar Robos";
            // 
            // tsp_tbx_reiniciaRobo
            // 
            this.tsp_tbx_reiniciaRobo.Enabled = false;
            this.tsp_tbx_reiniciaRobo.Name = "tsp_tbx_reiniciaRobo";
            this.tsp_tbx_reiniciaRobo.Size = new System.Drawing.Size(100, 23);
            this.tsp_tbx_reiniciaRobo.Text = "C:\\openspan\\ReiniciaRobo\\ReiniciarWatcher.bat";
            // 
            // pathReiniciaVMsToolStripMenuItem
            // 
            this.pathReiniciaVMsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_tbx_reniciaVM});
            this.pathReiniciaVMsToolStripMenuItem.Name = "pathReiniciaVMsToolStripMenuItem";
            this.pathReiniciaVMsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pathReiniciaVMsToolStripMenuItem.Text = "Path Reinicia VMs";
            // 
            // tsp_tbx_reniciaVM
            // 
            this.tsp_tbx_reniciaVM.Enabled = false;
            this.tsp_tbx_reniciaVM.Name = "tsp_tbx_reniciaVM";
            this.tsp_tbx_reniciaVM.Size = new System.Drawing.Size(100, 23);
            // 
            // pararRobosToolStripMenuItem
            // 
            this.pararRobosToolStripMenuItem.Name = "pararRobosToolStripMenuItem";
            this.pararRobosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.pararRobosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pararRobosToolStripMenuItem.Text = "Parar robos";
            this.pararRobosToolStripMenuItem.Click += new System.EventHandler(this.PararRobos_click);
            // 
            // reiniciarRobosToolStripMenuItem
            // 
            this.reiniciarRobosToolStripMenuItem.Name = "reiniciarRobosToolStripMenuItem";
            this.reiniciarRobosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.reiniciarRobosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.reiniciarRobosToolStripMenuItem.Text = "Reiniciar Robos";
            this.reiniciarRobosToolStripMenuItem.Click += new System.EventHandler(this.reiniciarRobosToolStripMenuItem_Click);
            // 
            // reiniciarVMToolStripMenuItem
            // 
            this.reiniciarVMToolStripMenuItem.Name = "reiniciarVMToolStripMenuItem";
            this.reiniciarVMToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.reiniciarVMToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.reiniciarVMToolStripMenuItem.Text = "Reiniciar VM";
            this.reiniciarVMToolStripMenuItem.Click += new System.EventHandler(this.reiniciarVMToolStripMenuItem_Click);
            // 
            // copiarArquivosToolStripMenuItem
            // 
            this.copiarArquivosToolStripMenuItem.Name = "copiarArquivosToolStripMenuItem";
            this.copiarArquivosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.copiarArquivosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.copiarArquivosToolStripMenuItem.Text = "Copiar Arquivos";
            this.copiarArquivosToolStripMenuItem.Click += new System.EventHandler(this.copiarArquivosToolStripMenuItem_Click);
            // 
            // btn_expandTree
            // 
            this.btn_expandTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_expandTree.BackgroundImage = global::GerenciadorVM.Properties.Resources.impand20x20;
            this.btn_expandTree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_expandTree.Location = new System.Drawing.Point(126, 44);
            this.btn_expandTree.Name = "btn_expandTree";
            this.btn_expandTree.Size = new System.Drawing.Size(20, 20);
            this.btn_expandTree.TabIndex = 3;
            this.btn_expandTree.UseVisualStyleBackColor = true;
            this.btn_expandTree.Click += new System.EventHandler(this.btn_inplandsTree_Click);
            // 
            // btn_inplandsTree
            // 
            this.btn_inplandsTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inplandsTree.BackgroundImage = global::GerenciadorVM.Properties.Resources.expand20x20;
            this.btn_inplandsTree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inplandsTree.Location = new System.Drawing.Point(156, 44);
            this.btn_inplandsTree.Name = "btn_inplandsTree";
            this.btn_inplandsTree.Size = new System.Drawing.Size(20, 20);
            this.btn_inplandsTree.TabIndex = 3;
            this.btn_inplandsTree.UseVisualStyleBackColor = true;
            this.btn_inplandsTree.Click += new System.EventHandler(this.btn_expandTree_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_atualizar.BackgroundImage = global::GerenciadorVM.Properties.Resources.loop_100px20x20;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_atualizar.Location = new System.Drawing.Point(187, 44);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(20, 20);
            this.btn_atualizar.TabIndex = 3;
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // tarefasExecutadasToolStripMenuItem
            // 
            this.tarefasExecutadasToolStripMenuItem.Name = "tarefasExecutadasToolStripMenuItem";
            this.tarefasExecutadasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tarefasExecutadasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tarefasExecutadasToolStripMenuItem.Text = "Tarefas Executadas";
            this.tarefasExecutadasToolStripMenuItem.Click += new System.EventHandler(this.tarefasExecutadasToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 483);
            this.Controls.Add(this.pan_central);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlador de arquivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pan_central.ResumeLayout(false);
            this.pan_principal.ResumeLayout(false);
            this.pan_descricoes.ResumeLayout(false);
            this.pan_descricoes.PerformLayout();
            this.pan_left.ResumeLayout(false);
            this.pan_projetos.ResumeLayout(false);
            this.pan_opções.ResumeLayout(false);
            this.pan_titulo.ResumeLayout(false);
            this.pan_titulo.PerformLayout();
            this.mst_opcoes.ResumeLayout(false);
            this.mst_opcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_central;
        private System.Windows.Forms.Panel pan_principal;
        private System.Windows.Forms.TabControl tbc_table_control;
        private System.Windows.Forms.Panel pan_descricoes;
        private System.Windows.Forms.Label lbl_valorVersao;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.Label lbl_versao;
        private System.Windows.Forms.Panel pan_left;
        private System.Windows.Forms.Panel pan_projetos;
        private System.Windows.Forms.TreeView trv_servidores;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Panel pan_opções;
        private System.Windows.Forms.Button btn_novo_projeto;
        private System.Windows.Forms.Panel pan_titulo;
        private System.Windows.Forms.Button btn_expandTree;
        private System.Windows.Forms.Button btn_inplandsTree;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label lbl_título;
        private System.Windows.Forms.MenuStrip mst_opcoes;
        private System.Windows.Forms.ToolStripMenuItem tsm_opcoes;
        private System.Windows.Forms.ToolStripMenuItem tsp_tipLog;
        private System.Windows.Forms.ToolStripMenuItem tsp_log_simples;
        private System.Windows.Forms.ToolStripMenuItem tsp_log_detalhado;
        private System.Windows.Forms.ToolStripMenuItem tsp_carregarTreeViewAutomaticamente;
        private System.Windows.Forms.ToolStripMenuItem tspSim;
        private System.Windows.Forms.ToolStripMenuItem tspNao;
        private System.Windows.Forms.ToolStripMenuItem origemDosArtefatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsp_tbx_origemArtefatos;
        private System.Windows.Forms.ToolStripMenuItem pararRobosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinoDosArtefatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsp_tbx_destinoArtefatos;
        private System.Windows.Forms.ToolStripMenuItem copiarArquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarRobosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathsIniciarRobosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsp_tbx_paraRobo;
        private System.Windows.Forms.ToolStripMenuItem pathReiniciarRobosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsp_tbx_reiniciaRobo;
        private System.Windows.Forms.ToolStripMenuItem pathReiniciaVMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsp_tbx_reniciaVM;
        private System.Windows.Forms.ToolStripMenuItem reiniciarVMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasExecutadasToolStripMenuItem;
    }
}

