namespace Playlist.View
{
    partial class frmMusicaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusicaCadastro));
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblBpm = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.nudBpm = new System.Windows.Forms.NumericUpDown();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.pnlExibicao = new System.Windows.Forms.Panel();
            this.dsbPlay = new System.Windows.Forms.CheckBox();
            this.lblExibicao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvMusicas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_tela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagem_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudBpm)).BeginInit();
            this.pnlExibicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloForm
            // 
            resources.ApplyResources(this.lblTituloForm, "lblTituloForm");
            this.lblTituloForm.Name = "lblTituloForm";
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Name = "lblTitulo";
            // 
            // lblArtista
            // 
            resources.ApplyResources(this.lblArtista, "lblArtista");
            this.lblArtista.Name = "lblArtista";
            // 
            // lblBpm
            // 
            resources.ApplyResources(this.lblBpm, "lblBpm");
            this.lblBpm.Name = "lblBpm";
            // 
            // lblDescricao
            // 
            resources.ApplyResources(this.lblDescricao, "lblDescricao");
            this.lblDescricao.Name = "lblDescricao";
            // 
            // txtArtista
            // 
            resources.ApplyResources(this.txtArtista, "txtArtista");
            this.txtArtista.Name = "txtArtista";
            // 
            // txtTitulo
            // 
            resources.ApplyResources(this.txtTitulo, "txtTitulo");
            this.txtTitulo.Name = "txtTitulo";
            // 
            // nudBpm
            // 
            this.nudBpm.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.nudBpm, "nudBpm");
            this.nudBpm.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBpm.Name = "nudBpm";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rtbDescricao, "rtbDescricao");
            this.rtbDescricao.Name = "rtbDescricao";
            // 
            // btnArquivo
            // 
            resources.ApplyResources(this.btnArquivo, "btnArquivo");
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // pnlExibicao
            // 
            this.pnlExibicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExibicao.Controls.Add(this.dsbPlay);
            this.pnlExibicao.Controls.Add(this.lblExibicao);
            resources.ApplyResources(this.pnlExibicao, "pnlExibicao");
            this.pnlExibicao.Name = "pnlExibicao";
            // 
            // dsbPlay
            // 
            resources.ApplyResources(this.dsbPlay, "dsbPlay");
            this.dsbPlay.Name = "dsbPlay";
            this.dsbPlay.UseVisualStyleBackColor = true;
            this.dsbPlay.CheckedChanged += new System.EventHandler(this.dsbPlay_CheckedChanged);
            // 
            // lblExibicao
            // 
            resources.ApplyResources(this.lblExibicao, "lblExibicao");
            this.lblExibicao.Name = "lblExibicao";
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvMusicas
            // 
            this.dgvMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome_usuario,
            this.nome_tela,
            this.data_nascimento,
            this.imagem_perfil,
            this.BPM,
            this.descricao});
            resources.ApplyResources(this.dgvMusicas, "dgvMusicas");
            this.dgvMusicas.Name = "dgvMusicas";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome_usuario
            // 
            this.nome_usuario.DataPropertyName = "titulo";
            resources.ApplyResources(this.nome_usuario, "nome_usuario");
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.ReadOnly = true;
            // 
            // nome_tela
            // 
            this.nome_tela.DataPropertyName = "artista";
            resources.ApplyResources(this.nome_tela, "nome_tela");
            this.nome_tela.Name = "nome_tela";
            this.nome_tela.ReadOnly = true;
            // 
            // data_nascimento
            // 
            this.data_nascimento.DataPropertyName = "data";
            resources.ApplyResources(this.data_nascimento, "data_nascimento");
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.ReadOnly = true;
            // 
            // imagem_perfil
            // 
            this.imagem_perfil.DataPropertyName = "local";
            resources.ApplyResources(this.imagem_perfil, "imagem_perfil");
            this.imagem_perfil.Name = "imagem_perfil";
            this.imagem_perfil.ReadOnly = true;
            // 
            // BPM
            // 
            this.BPM.DataPropertyName = "bpm";
            resources.ApplyResources(this.BPM, "BPM");
            this.BPM.Name = "BPM";
            this.BPM.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            resources.ApplyResources(this.descricao, "descricao");
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // frmMusicaCadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMusicas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pnlExibicao);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.nudBpm);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblBpm);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTituloForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusicaCadastro";
            this.Load += new System.EventHandler(this.frmMusicaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBpm)).EndInit();
            this.pnlExibicao.ResumeLayout(false);
            this.pnlExibicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblBpm;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.NumericUpDown nudBpm;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Panel pnlExibicao;
        private System.Windows.Forms.Label lblExibicao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvMusicas;
        private System.Windows.Forms.CheckBox dsbPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_tela;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagem_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}