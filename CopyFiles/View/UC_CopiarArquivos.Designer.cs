namespace View
{
    partial class UC_CopiarArquivos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CopiarArquivos));
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.grb_cadastro = new System.Windows.Forms.GroupBox();
            this.grb_servidores = new System.Windows.Forms.GroupBox();
            this.lbl_aseremCopiados = new System.Windows.Forms.Label();
            this.lbl_cadastrados = new System.Windows.Forms.Label();
            this.btn_removerTodosCopiar = new System.Windows.Forms.Button();
            this.btn_removerCopiar = new System.Windows.Forms.Button();
            this.btn_adicionarTodosCopiar = new System.Windows.Forms.Button();
            this.btn_adicionarCopiar = new System.Windows.Forms.Button();
            this.dgv_servidorCopiar = new System.Windows.Forms.DataGridView();
            this.dgv_servidoresCadastradas = new System.Windows.Forms.DataGridView();
            this.grb_diretorios = new System.Windows.Forms.GroupBox();
            this.btn_origem = new System.Windows.Forms.Button();
            this.btn_info_detino = new System.Windows.Forms.Button();
            this.btn_info_origem = new System.Windows.Forms.Button();
            this.tbx_diretorioDestino = new System.Windows.Forms.TextBox();
            this.lbl_diretorioDestino = new System.Windows.Forms.Label();
            this.tbx_diretorioOrigem = new System.Windows.Forms.TextBox();
            this.lbl_diretorioOrigem = new System.Windows.Forms.Label();
            this.pan_top.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.grb_cadastro.SuspendLayout();
            this.grb_servidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servidorCopiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servidoresCadastradas)).BeginInit();
            this.grb_diretorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 1;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.BackColor = System.Drawing.Color.Red;
            this.btn_fechar.BackgroundImage = global::GerenciadorVM.Properties.Resources.window_close_100px20x20;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechar.Location = new System.Drawing.Point(720, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(20, 20);
            this.btn_fechar.TabIndex = 13;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 9;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(662, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 12;
            this.btn_confirmar.Text = "Copiar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // grb_cadastro
            // 
            this.grb_cadastro.Controls.Add(this.grb_servidores);
            this.grb_cadastro.Controls.Add(this.grb_diretorios);
            this.grb_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_cadastro.Location = new System.Drawing.Point(0, 20);
            this.grb_cadastro.Name = "grb_cadastro";
            this.grb_cadastro.Size = new System.Drawing.Size(740, 507);
            this.grb_cadastro.TabIndex = 10;
            this.grb_cadastro.TabStop = false;
            this.grb_cadastro.Text = "Copiar Arquivos";
            // 
            // grb_servidores
            // 
            this.grb_servidores.Controls.Add(this.lbl_aseremCopiados);
            this.grb_servidores.Controls.Add(this.lbl_cadastrados);
            this.grb_servidores.Controls.Add(this.btn_removerTodosCopiar);
            this.grb_servidores.Controls.Add(this.btn_removerCopiar);
            this.grb_servidores.Controls.Add(this.btn_adicionarTodosCopiar);
            this.grb_servidores.Controls.Add(this.btn_adicionarCopiar);
            this.grb_servidores.Controls.Add(this.dgv_servidorCopiar);
            this.grb_servidores.Controls.Add(this.dgv_servidoresCadastradas);
            this.grb_servidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_servidores.Location = new System.Drawing.Point(3, 107);
            this.grb_servidores.Name = "grb_servidores";
            this.grb_servidores.Size = new System.Drawing.Size(734, 397);
            this.grb_servidores.TabIndex = 1;
            this.grb_servidores.TabStop = false;
            this.grb_servidores.Text = "Servidores";
            // 
            // lbl_aseremCopiados
            // 
            this.lbl_aseremCopiados.AutoSize = true;
            this.lbl_aseremCopiados.Location = new System.Drawing.Point(272, 19);
            this.lbl_aseremCopiados.Name = "lbl_aseremCopiados";
            this.lbl_aseremCopiados.Size = new System.Drawing.Size(190, 16);
            this.lbl_aseremCopiados.TabIndex = 24;
            this.lbl_aseremCopiados.Text = "Servidores que serão acessados:";
            // 
            // lbl_cadastrados
            // 
            this.lbl_cadastrados.AutoSize = true;
            this.lbl_cadastrados.Location = new System.Drawing.Point(22, 19);
            this.lbl_cadastrados.Name = "lbl_cadastrados";
            this.lbl_cadastrados.Size = new System.Drawing.Size(80, 16);
            this.lbl_cadastrados.TabIndex = 24;
            this.lbl_cadastrados.Text = "Cadastrados:";
            // 
            // btn_removerTodosCopiar
            // 
            this.btn_removerTodosCopiar.BackgroundImage = global::GerenciadorVM.Properties.Resources.arrow_left_box_100px20x20;
            this.btn_removerTodosCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removerTodosCopiar.Location = new System.Drawing.Point(245, 184);
            this.btn_removerTodosCopiar.Name = "btn_removerTodosCopiar";
            this.btn_removerTodosCopiar.Size = new System.Drawing.Size(20, 20);
            this.btn_removerTodosCopiar.TabIndex = 10;
            this.btn_removerTodosCopiar.UseVisualStyleBackColor = true;
            this.btn_removerTodosCopiar.Click += new System.EventHandler(this.btn_removerVinculos_Click);
            // 
            // btn_removerCopiar
            // 
            this.btn_removerCopiar.BackgroundImage = global::GerenciadorVM.Properties.Resources.arrow_left_100px20x20;
            this.btn_removerCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removerCopiar.Location = new System.Drawing.Point(245, 158);
            this.btn_removerCopiar.Name = "btn_removerCopiar";
            this.btn_removerCopiar.Size = new System.Drawing.Size(20, 20);
            this.btn_removerCopiar.TabIndex = 9;
            this.btn_removerCopiar.UseVisualStyleBackColor = true;
            this.btn_removerCopiar.Click += new System.EventHandler(this.btn_removerVinculoMarca_Click);
            // 
            // btn_adicionarTodosCopiar
            // 
            this.btn_adicionarTodosCopiar.BackgroundImage = global::GerenciadorVM.Properties.Resources.arrow_right_box_100px20x20;
            this.btn_adicionarTodosCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionarTodosCopiar.Location = new System.Drawing.Point(245, 97);
            this.btn_adicionarTodosCopiar.Name = "btn_adicionarTodosCopiar";
            this.btn_adicionarTodosCopiar.Size = new System.Drawing.Size(20, 20);
            this.btn_adicionarTodosCopiar.TabIndex = 8;
            this.btn_adicionarTodosCopiar.UseVisualStyleBackColor = true;
            this.btn_adicionarTodosCopiar.Click += new System.EventHandler(this.btn_adicionartodosCopias_Click);
            // 
            // btn_adicionarCopiar
            // 
            this.btn_adicionarCopiar.BackgroundImage = global::GerenciadorVM.Properties.Resources.arrow_right_100px20x20;
            this.btn_adicionarCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionarCopiar.Location = new System.Drawing.Point(245, 71);
            this.btn_adicionarCopiar.Name = "btn_adicionarCopiar";
            this.btn_adicionarCopiar.Size = new System.Drawing.Size(20, 20);
            this.btn_adicionarCopiar.TabIndex = 7;
            this.btn_adicionarCopiar.UseVisualStyleBackColor = true;
            this.btn_adicionarCopiar.Click += new System.EventHandler(this.btn_adicionarCopiar_Click);
            // 
            // dgv_servidorCopiar
            // 
            this.dgv_servidorCopiar.AllowUserToAddRows = false;
            this.dgv_servidorCopiar.AllowUserToDeleteRows = false;
            this.dgv_servidorCopiar.AllowUserToOrderColumns = true;
            this.dgv_servidorCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_servidorCopiar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_servidorCopiar.BackgroundColor = System.Drawing.Color.White;
            this.dgv_servidorCopiar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_servidorCopiar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_servidorCopiar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_servidorCopiar.EnableHeadersVisualStyles = false;
            this.dgv_servidorCopiar.Location = new System.Drawing.Point(275, 41);
            this.dgv_servidorCopiar.MultiSelect = false;
            this.dgv_servidorCopiar.Name = "dgv_servidorCopiar";
            this.dgv_servidorCopiar.RowHeadersVisible = false;
            this.dgv_servidorCopiar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_servidorCopiar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servidorCopiar.ShowCellErrors = false;
            this.dgv_servidorCopiar.ShowCellToolTips = false;
            this.dgv_servidorCopiar.Size = new System.Drawing.Size(215, 285);
            this.dgv_servidorCopiar.StandardTab = true;
            this.dgv_servidorCopiar.TabIndex = 11;
            // 
            // dgv_servidoresCadastradas
            // 
            this.dgv_servidoresCadastradas.AllowUserToAddRows = false;
            this.dgv_servidoresCadastradas.AllowUserToDeleteRows = false;
            this.dgv_servidoresCadastradas.AllowUserToOrderColumns = true;
            this.dgv_servidoresCadastradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_servidoresCadastradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_servidoresCadastradas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_servidoresCadastradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_servidoresCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_servidoresCadastradas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_servidoresCadastradas.EnableHeadersVisualStyles = false;
            this.dgv_servidoresCadastradas.Location = new System.Drawing.Point(24, 41);
            this.dgv_servidoresCadastradas.MultiSelect = false;
            this.dgv_servidoresCadastradas.Name = "dgv_servidoresCadastradas";
            this.dgv_servidoresCadastradas.RowHeadersVisible = false;
            this.dgv_servidoresCadastradas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_servidoresCadastradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servidoresCadastradas.ShowCellErrors = false;
            this.dgv_servidoresCadastradas.ShowCellToolTips = false;
            this.dgv_servidoresCadastradas.Size = new System.Drawing.Size(215, 285);
            this.dgv_servidoresCadastradas.StandardTab = true;
            this.dgv_servidoresCadastradas.TabIndex = 6;
            // 
            // grb_diretorios
            // 
            this.grb_diretorios.Controls.Add(this.btn_origem);
            this.grb_diretorios.Controls.Add(this.btn_info_detino);
            this.grb_diretorios.Controls.Add(this.btn_info_origem);
            this.grb_diretorios.Controls.Add(this.tbx_diretorioDestino);
            this.grb_diretorios.Controls.Add(this.lbl_diretorioDestino);
            this.grb_diretorios.Controls.Add(this.tbx_diretorioOrigem);
            this.grb_diretorios.Controls.Add(this.lbl_diretorioOrigem);
            this.grb_diretorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_diretorios.Location = new System.Drawing.Point(3, 19);
            this.grb_diretorios.Name = "grb_diretorios";
            this.grb_diretorios.Size = new System.Drawing.Size(734, 88);
            this.grb_diretorios.TabIndex = 0;
            this.grb_diretorios.TabStop = false;
            this.grb_diretorios.Text = "Diretórios";
            // 
            // btn_origem
            // 
            this.btn_origem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_origem.Location = new System.Drawing.Point(523, 14);
            this.btn_origem.Name = "btn_origem";
            this.btn_origem.Size = new System.Drawing.Size(67, 23);
            this.btn_origem.TabIndex = 2;
            this.btn_origem.Text = "Diretório";
            this.btn_origem.UseVisualStyleBackColor = true;
            this.btn_origem.Click += new System.EventHandler(this.btn_origem_Click);
            // 
            // btn_info_detino
            // 
            this.btn_info_detino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_detino.BackgroundImage")));
            this.btn_info_detino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_detino.Location = new System.Drawing.Point(523, 44);
            this.btn_info_detino.Name = "btn_info_detino";
            this.btn_info_detino.Size = new System.Drawing.Size(20, 20);
            this.btn_info_detino.TabIndex = 5;
            this.btn_info_detino.UseVisualStyleBackColor = true;
            this.btn_info_detino.Click += new System.EventHandler(this.btn_info_detino_Click);
            // 
            // btn_info_origem
            // 
            this.btn_info_origem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_origem.BackgroundImage")));
            this.btn_info_origem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_origem.Location = new System.Drawing.Point(596, 16);
            this.btn_info_origem.Name = "btn_info_origem";
            this.btn_info_origem.Size = new System.Drawing.Size(20, 20);
            this.btn_info_origem.TabIndex = 3;
            this.btn_info_origem.UseVisualStyleBackColor = true;
            this.btn_info_origem.Click += new System.EventHandler(this.btn_info_origem_Click);
            // 
            // tbx_diretorioDestino
            // 
            this.tbx_diretorioDestino.Location = new System.Drawing.Point(148, 43);
            this.tbx_diretorioDestino.MaxLength = 200;
            this.tbx_diretorioDestino.Name = "tbx_diretorioDestino";
            this.tbx_diretorioDestino.Size = new System.Drawing.Size(369, 23);
            this.tbx_diretorioDestino.TabIndex = 4;
            this.tbx_diretorioDestino.TextChanged += new System.EventHandler(this.tbx_diretorioDestino_TextChanged);
            // 
            // lbl_diretorioDestino
            // 
            this.lbl_diretorioDestino.AutoSize = true;
            this.lbl_diretorioDestino.Location = new System.Drawing.Point(21, 48);
            this.lbl_diretorioDestino.Name = "lbl_diretorioDestino";
            this.lbl_diretorioDestino.Size = new System.Drawing.Size(122, 16);
            this.lbl_diretorioDestino.TabIndex = 8;
            this.lbl_diretorioDestino.Text = "Diretório de destino:";
            // 
            // tbx_diretorioOrigem
            // 
            this.tbx_diretorioOrigem.Location = new System.Drawing.Point(148, 14);
            this.tbx_diretorioOrigem.MaxLength = 200;
            this.tbx_diretorioOrigem.Name = "tbx_diretorioOrigem";
            this.tbx_diretorioOrigem.Size = new System.Drawing.Size(369, 23);
            this.tbx_diretorioOrigem.TabIndex = 1;
            this.tbx_diretorioOrigem.TextChanged += new System.EventHandler(this.tbx_diretorioOrigem_TextChanged);
            // 
            // lbl_diretorioOrigem
            // 
            this.lbl_diretorioOrigem.AutoSize = true;
            this.lbl_diretorioOrigem.Location = new System.Drawing.Point(21, 19);
            this.lbl_diretorioOrigem.Name = "lbl_diretorioOrigem";
            this.lbl_diretorioOrigem.Size = new System.Drawing.Size(121, 16);
            this.lbl_diretorioOrigem.TabIndex = 8;
            this.lbl_diretorioOrigem.Text = "Diretório de origem:";
            // 
            // UC_CopiarArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.grb_cadastro);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CopiarArquivos";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_top.ResumeLayout(false);
            this.pan_botton.ResumeLayout(false);
            this.grb_cadastro.ResumeLayout(false);
            this.grb_servidores.ResumeLayout(false);
            this.grb_servidores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servidorCopiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servidoresCadastradas)).EndInit();
            this.grb_diretorios.ResumeLayout(false);
            this.grb_diretorios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.GroupBox grb_cadastro;
        private System.Windows.Forms.GroupBox grb_diretorios;
        private System.Windows.Forms.GroupBox grb_servidores;
        private System.Windows.Forms.Button btn_removerTodosCopiar;
        private System.Windows.Forms.Button btn_removerCopiar;
        private System.Windows.Forms.Button btn_adicionarTodosCopiar;
        private System.Windows.Forms.Button btn_adicionarCopiar;
        private System.Windows.Forms.DataGridView dgv_servidorCopiar;
        private System.Windows.Forms.DataGridView dgv_servidoresCadastradas;
        private System.Windows.Forms.Button btn_info_origem;
        private System.Windows.Forms.TextBox tbx_diretorioOrigem;
        private System.Windows.Forms.Label lbl_diretorioOrigem;
        private System.Windows.Forms.Button btn_origem;
        private System.Windows.Forms.Button btn_info_detino;
        private System.Windows.Forms.TextBox tbx_diretorioDestino;
        private System.Windows.Forms.Label lbl_diretorioDestino;
        private System.Windows.Forms.Label lbl_aseremCopiados;
        private System.Windows.Forms.Label lbl_cadastrados;
    }
}
