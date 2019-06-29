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
            resources.ApplyResources(this.dgvMusicas, "dgvMusicas");
            this.dgvMusicas.Name = "dgvMusicas";
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
    }
}