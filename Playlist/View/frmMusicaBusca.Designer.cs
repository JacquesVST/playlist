namespace Playlist.View
{
    partial class frmMusicaBusca
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
            this.btnFiltroId = new System.Windows.Forms.Button();
            this.txtFiltroId = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.pnlBio = new System.Windows.Forms.Panel();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblBpm = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.dsbPlay = new System.Windows.Forms.CheckBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.pnlBio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltroId
            // 
            this.btnFiltroId.Location = new System.Drawing.Point(12, 64);
            this.btnFiltroId.Name = "btnFiltroId";
            this.btnFiltroId.Size = new System.Drawing.Size(250, 27);
            this.btnFiltroId.TabIndex = 38;
            this.btnFiltroId.Text = "Buscar";
            this.btnFiltroId.UseVisualStyleBackColor = true;
            this.btnFiltroId.Click += new System.EventHandler(this.btnFiltroId_Click);
            // 
            // txtFiltroId
            // 
            this.txtFiltroId.Location = new System.Drawing.Point(12, 31);
            this.txtFiltroId.Name = "txtFiltroId";
            this.txtFiltroId.Size = new System.Drawing.Size(250, 27);
            this.txtFiltroId.TabIndex = 37;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 9);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(74, 19);
            this.lblFiltro.TabIndex = 36;
            this.lblFiltro.Text = "Buscar ID:";
            // 
            // pnlBio
            // 
            this.pnlBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBio.Controls.Add(this.lblDuracao);
            this.pnlBio.Controls.Add(this.dsbPlay);
            this.pnlBio.Controls.Add(this.rtbDescricao);
            this.pnlBio.Controls.Add(this.lblDescricao);
            this.pnlBio.Controls.Add(this.lblSobre);
            this.pnlBio.Controls.Add(this.lblBpm);
            this.pnlBio.Location = new System.Drawing.Point(12, 97);
            this.pnlBio.Name = "pnlBio";
            this.pnlBio.Size = new System.Drawing.Size(502, 250);
            this.pnlBio.TabIndex = 35;
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescricao.Location = new System.Drawing.Point(5, 37);
            this.rtbDescricao.Margin = new System.Windows.Forms.Padding(5);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.ReadOnly = true;
            this.rtbDescricao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDescricao.Size = new System.Drawing.Size(240, 208);
            this.rtbDescricao.TabIndex = 2;
            this.rtbDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(8, 27);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(0, 19);
            this.lblDescricao.TabIndex = 1;
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(8, 8);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(47, 19);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = "Sobre";
            // 
            // lblBpm
            // 
            this.lblBpm.AutoSize = true;
            this.lblBpm.Location = new System.Drawing.Point(253, 37);
            this.lblBpm.Name = "lblBpm";
            this.lblBpm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBpm.Size = new System.Drawing.Size(43, 19);
            this.lblBpm.TabIndex = 17;
            this.lblBpm.Text = "BPM:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(286, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(116, 19);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Titulo da musica";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.Location = new System.Drawing.Point(285, 31);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblArtista.Size = new System.Drawing.Size(149, 25);
            this.lblArtista.TabIndex = 32;
            this.lblArtista.Text = "Nome do Artista";
            // 
            // dsbPlay
            // 
            this.dsbPlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.dsbPlay.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dsbPlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dsbPlay.Location = new System.Drawing.Point(253, 178);
            this.dsbPlay.Name = "dsbPlay";
            this.dsbPlay.Size = new System.Drawing.Size(240, 67);
            this.dsbPlay.TabIndex = 39;
            this.dsbPlay.Text = "Play";
            this.dsbPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dsbPlay.UseVisualStyleBackColor = true;
            this.dsbPlay.CheckedChanged += new System.EventHandler(this.dsbPlay_CheckedChanged);
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(253, 56);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(66, 19);
            this.lblDuracao.TabIndex = 40;
            this.lblDuracao.Text = "Duração:";
            // 
            // frmMusicaBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 685);
            this.Controls.Add(this.btnFiltroId);
            this.Controls.Add(this.txtFiltroId);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pnlBio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblArtista);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMusicaBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusicaBusca";
            this.Load += new System.EventHandler(this.frmMusicaBusca_Load);
            this.pnlBio.ResumeLayout(false);
            this.pnlBio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltroId;
        private System.Windows.Forms.TextBox txtFiltroId;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel pnlBio;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblBpm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.CheckBox dsbPlay;
        private System.Windows.Forms.Label lblDuracao;
    }
}