namespace View
{
    partial class UC_CadastroServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CadastroServidor));
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.gpb_cadastroGeral = new System.Windows.Forms.GroupBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_info_tipo = new System.Windows.Forms.Button();
            this.btn_info_ip = new System.Windows.Forms.Button();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.tbx_link = new System.Windows.Forms.TextBox();
            this.lbl_link = new System.Windows.Forms.Label();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_top.SuspendLayout();
            this.gpb_cadastroGeral.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 0;
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
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // gpb_cadastroGeral
            // 
            this.gpb_cadastroGeral.Controls.Add(this.cmb_tipo);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_tipo);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_ip);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_tipo);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_link);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_link);
            this.gpb_cadastroGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastroGeral.Location = new System.Drawing.Point(0, 20);
            this.gpb_cadastroGeral.Name = "gpb_cadastroGeral";
            this.gpb_cadastroGeral.Size = new System.Drawing.Size(740, 507);
            this.gpb_cadastroGeral.TabIndex = 1;
            this.gpb_cadastroGeral.TabStop = false;
            this.gpb_cadastroGeral.Text = "Cadastro de Servidor";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "DESENVOLVIMENTO",
            "PRODUÇÃO"});
            this.cmb_tipo.Location = new System.Drawing.Point(97, 56);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(255, 23);
            this.cmb_tipo.TabIndex = 3;
            // 
            // btn_info_tipo
            // 
            this.btn_info_tipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_tipo.BackgroundImage")));
            this.btn_info_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tipo.Location = new System.Drawing.Point(358, 56);
            this.btn_info_tipo.Name = "btn_info_tipo";
            this.btn_info_tipo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tipo.TabIndex = 4;
            this.btn_info_tipo.UseVisualStyleBackColor = true;
            this.btn_info_tipo.Click += new System.EventHandler(this.btn_tipo_Click);
            // 
            // btn_info_ip
            // 
            this.btn_info_ip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_ip.BackgroundImage")));
            this.btn_info_ip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_ip.Location = new System.Drawing.Point(358, 26);
            this.btn_info_ip.Name = "btn_info_ip";
            this.btn_info_ip.Size = new System.Drawing.Size(20, 20);
            this.btn_info_ip.TabIndex = 2;
            this.btn_info_ip.UseVisualStyleBackColor = true;
            this.btn_info_ip.Click += new System.EventHandler(this.btn_info_ip_Click);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(6, 62);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(89, 16);
            this.lbl_tipo.TabIndex = 5;
            this.lbl_tipo.Text = "Tipo Servidor:";
            // 
            // tbx_link
            // 
            this.tbx_link.Location = new System.Drawing.Point(97, 25);
            this.tbx_link.MaxLength = 200;
            this.tbx_link.Name = "tbx_link";
            this.tbx_link.Size = new System.Drawing.Size(255, 23);
            this.tbx_link.TabIndex = 1;
            // 
            // lbl_link
            // 
            this.lbl_link.AutoSize = true;
            this.lbl_link.Location = new System.Drawing.Point(6, 28);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(24, 16);
            this.lbl_link.TabIndex = 5;
            this.lbl_link.Text = "IP:";
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_excluir);
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 8;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(579, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(662, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 5;
            this.btn_confirmar.Text = "Cadastrar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // UC_CadastroServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.gpb_cadastroGeral);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroServidor";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_top.ResumeLayout(false);
            this.gpb_cadastroGeral.ResumeLayout(false);
            this.gpb_cadastroGeral.PerformLayout();
            this.pan_botton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.GroupBox gpb_cadastroGeral;
        private System.Windows.Forms.Button btn_info_ip;
        private System.Windows.Forms.TextBox tbx_link;
        private System.Windows.Forms.Label lbl_link;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Button btn_info_tipo;
    }
}
