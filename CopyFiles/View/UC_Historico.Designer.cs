namespace View
{
    partial class UC_Historico
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
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_reloadData = new System.Windows.Forms.Button();
            this.pan_resposta = new System.Windows.Forms.Panel();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.lbl_chamado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_dataexecucao = new System.Windows.Forms.Label();
            this.lbl_data_valor = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_codigo_valor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pan_codigo = new System.Windows.Forms.Panel();
            this.grb_cadastrados = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_status_valor = new System.Windows.Forms.Label();
            this.dgv_tarefas = new System.Windows.Forms.DataGridView();
            this.grb_chamados = new System.Windows.Forms.GroupBox();
            this.pan_completo = new System.Windows.Forms.Panel();
            this.pan_top.SuspendLayout();
            this.pan_resposta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grb_cadastrados.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarefas)).BeginInit();
            this.grb_chamados.SuspendLayout();
            this.pan_completo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Controls.Add(this.btn_reloadData);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 26;
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
            this.btn_fechar.TabIndex = 20;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_reloadData
            // 
            this.btn_reloadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reloadData.BackgroundImage = global::GerenciadorVM.Properties.Resources.loop_100px20x20;
            this.btn_reloadData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reloadData.Location = new System.Drawing.Point(694, 0);
            this.btn_reloadData.Name = "btn_reloadData";
            this.btn_reloadData.Size = new System.Drawing.Size(20, 20);
            this.btn_reloadData.TabIndex = 19;
            this.btn_reloadData.UseVisualStyleBackColor = true;
            this.btn_reloadData.Click += new System.EventHandler(this.btn_reloadData_Click);
            // 
            // pan_resposta
            // 
            this.pan_resposta.Controls.Add(this.tbx_descricao);
            this.pan_resposta.Controls.Add(this.lbl_chamado);
            this.pan_resposta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_resposta.Location = new System.Drawing.Point(3, 123);
            this.pan_resposta.Name = "pan_resposta";
            this.pan_resposta.Size = new System.Drawing.Size(252, 212);
            this.pan_resposta.TabIndex = 10;
            // 
            // tbx_descricao
            // 
            this.tbx_descricao.AcceptsTab = true;
            this.tbx_descricao.Location = new System.Drawing.Point(3, 31);
            this.tbx_descricao.MaxLength = 2000;
            this.tbx_descricao.Multiline = true;
            this.tbx_descricao.Name = "tbx_descricao";
            this.tbx_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_descricao.Size = new System.Drawing.Size(246, 171);
            this.tbx_descricao.TabIndex = 8;
            // 
            // lbl_chamado
            // 
            this.lbl_chamado.AutoSize = true;
            this.lbl_chamado.Location = new System.Drawing.Point(19, 12);
            this.lbl_chamado.Name = "lbl_chamado";
            this.lbl_chamado.Size = new System.Drawing.Size(64, 16);
            this.lbl_chamado.TabIndex = 7;
            this.lbl_chamado.Text = "Descrição";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_dataexecucao);
            this.panel2.Controls.Add(this.lbl_data_valor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 41);
            this.panel2.TabIndex = 9;
            // 
            // lbl_dataexecucao
            // 
            this.lbl_dataexecucao.AutoSize = true;
            this.lbl_dataexecucao.Location = new System.Drawing.Point(19, 13);
            this.lbl_dataexecucao.Name = "lbl_dataexecucao";
            this.lbl_dataexecucao.Size = new System.Drawing.Size(34, 16);
            this.lbl_dataexecucao.TabIndex = 6;
            this.lbl_dataexecucao.Text = "Data";
            // 
            // lbl_data_valor
            // 
            this.lbl_data_valor.AutoSize = true;
            this.lbl_data_valor.Location = new System.Drawing.Point(91, 13);
            this.lbl_data_valor.Name = "lbl_data_valor";
            this.lbl_data_valor.Size = new System.Drawing.Size(47, 16);
            this.lbl_data_valor.TabIndex = 6;
            this.lbl_data_valor.Text = "<data>";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(19, 12);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(48, 16);
            this.lbl_codigo.TabIndex = 6;
            this.lbl_codigo.Text = "Codigo";
            // 
            // lbl_codigo_valor
            // 
            this.lbl_codigo_valor.AutoSize = true;
            this.lbl_codigo_valor.Location = new System.Drawing.Point(91, 12);
            this.lbl_codigo_valor.Name = "lbl_codigo_valor";
            this.lbl_codigo_valor.Size = new System.Drawing.Size(46, 16);
            this.lbl_codigo_valor.TabIndex = 6;
            this.lbl_codigo_valor.Text = "codigo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_codigo);
            this.panel1.Controls.Add(this.lbl_codigo_valor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 41);
            this.panel1.TabIndex = 8;
            // 
            // pan_codigo
            // 
            this.pan_codigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_codigo.Location = new System.Drawing.Point(3, 19);
            this.pan_codigo.Name = "pan_codigo";
            this.pan_codigo.Size = new System.Drawing.Size(252, 22);
            this.pan_codigo.TabIndex = 7;
            // 
            // grb_cadastrados
            // 
            this.grb_cadastrados.Controls.Add(this.panel3);
            this.grb_cadastrados.Controls.Add(this.pan_resposta);
            this.grb_cadastrados.Controls.Add(this.panel2);
            this.grb_cadastrados.Controls.Add(this.panel1);
            this.grb_cadastrados.Controls.Add(this.pan_codigo);
            this.grb_cadastrados.Dock = System.Windows.Forms.DockStyle.Right;
            this.grb_cadastrados.Location = new System.Drawing.Point(482, 20);
            this.grb_cadastrados.Name = "grb_cadastrados";
            this.grb_cadastrados.Size = new System.Drawing.Size(258, 542);
            this.grb_cadastrados.TabIndex = 29;
            this.grb_cadastrados.TabStop = false;
            this.grb_cadastrados.Text = "Dados";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Controls.Add(this.lbl_status_valor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 41);
            this.panel3.TabIndex = 11;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(19, 13);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 16);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status";
            // 
            // lbl_status_valor
            // 
            this.lbl_status_valor.AutoSize = true;
            this.lbl_status_valor.Location = new System.Drawing.Point(91, 13);
            this.lbl_status_valor.Name = "lbl_status_valor";
            this.lbl_status_valor.Size = new System.Drawing.Size(57, 16);
            this.lbl_status_valor.TabIndex = 6;
            this.lbl_status_valor.Text = "<status>";
            // 
            // dgv_tarefas
            // 
            this.dgv_tarefas.AllowUserToAddRows = false;
            this.dgv_tarefas.AllowUserToDeleteRows = false;
            this.dgv_tarefas.AllowUserToOrderColumns = true;
            this.dgv_tarefas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tarefas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tarefas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_tarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_tarefas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tarefas.EnableHeadersVisualStyles = false;
            this.dgv_tarefas.Location = new System.Drawing.Point(6, 35);
            this.dgv_tarefas.MultiSelect = false;
            this.dgv_tarefas.Name = "dgv_tarefas";
            this.dgv_tarefas.RowHeadersVisible = false;
            this.dgv_tarefas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_tarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tarefas.ShowCellErrors = false;
            this.dgv_tarefas.ShowCellToolTips = false;
            this.dgv_tarefas.Size = new System.Drawing.Size(470, 498);
            this.dgv_tarefas.StandardTab = true;
            this.dgv_tarefas.TabIndex = 12;
            this.dgv_tarefas.SelectionChanged += new System.EventHandler(this.dgv_chamados_SelectionChanged);
            // 
            // grb_chamados
            // 
            this.grb_chamados.Controls.Add(this.dgv_tarefas);
            this.grb_chamados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_chamados.Location = new System.Drawing.Point(0, 20);
            this.grb_chamados.Name = "grb_chamados";
            this.grb_chamados.Size = new System.Drawing.Size(482, 542);
            this.grb_chamados.TabIndex = 28;
            this.grb_chamados.TabStop = false;
            this.grb_chamados.Text = "Tarefas";
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.grb_chamados);
            this.pan_completo.Controls.Add(this.grb_cadastrados);
            this.pan_completo.Controls.Add(this.pan_top);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(740, 562);
            this.pan_completo.TabIndex = 1;
            // 
            // UC_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_completo);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_Historico";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_top.ResumeLayout(false);
            this.pan_resposta.ResumeLayout(false);
            this.pan_resposta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_cadastrados.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarefas)).EndInit();
            this.grb_chamados.ResumeLayout(false);
            this.pan_completo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_reloadData;
        private System.Windows.Forms.Panel pan_resposta;
        private System.Windows.Forms.TextBox tbx_descricao;
        private System.Windows.Forms.Label lbl_chamado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_dataexecucao;
        private System.Windows.Forms.Label lbl_data_valor;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_codigo_valor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pan_codigo;
        private System.Windows.Forms.GroupBox grb_cadastrados;
        private System.Windows.Forms.DataGridView dgv_tarefas;
        private System.Windows.Forms.GroupBox grb_chamados;
        private System.Windows.Forms.Panel pan_completo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_status_valor;
    }
}
