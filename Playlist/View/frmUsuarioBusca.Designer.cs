namespace Playlist.View
{
    partial class frmUsuarioBusca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioBusca));
            this.pnlBio = new System.Windows.Forms.Panel();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltroId = new System.Windows.Forms.TextBox();
            this.btnFiltroId = new System.Windows.Forms.Button();
            this.pnlBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBio
            // 
            this.pnlBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBio.Controls.Add(this.rtbDescricao);
            this.pnlBio.Controls.Add(this.lblPlaylist);
            this.pnlBio.Controls.Add(this.lblEnvio);
            this.pnlBio.Controls.Add(this.lblCompras);
            this.pnlBio.Controls.Add(this.lblDescricao);
            this.pnlBio.Controls.Add(this.lblSobre);
            this.pnlBio.Controls.Add(this.lblIdade);
            this.pnlBio.Location = new System.Drawing.Point(524, 12);
            this.pnlBio.Name = "pnlBio";
            this.pnlBio.Size = new System.Drawing.Size(437, 250);
            this.pnlBio.TabIndex = 25;
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescricao.Location = new System.Drawing.Point(5, 35);
            this.rtbDescricao.Margin = new System.Windows.Forms.Padding(5);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.ReadOnly = true;
            this.rtbDescricao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDescricao.Size = new System.Drawing.Size(240, 208);
            this.rtbDescricao.TabIndex = 2;
            this.rtbDescricao.Text = "";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Location = new System.Drawing.Point(253, 149);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlaylist.Size = new System.Drawing.Size(114, 19);
            this.lblPlaylist.TabIndex = 18;
            this.lblPlaylist.Text = "Playlist Criadas:";
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(253, 111);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnvio.Size = new System.Drawing.Size(128, 19);
            this.lblEnvio.TabIndex = 19;
            this.lblEnvio.Text = "Músicas Enviadas:";
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Location = new System.Drawing.Point(253, 73);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCompras.Size = new System.Drawing.Size(143, 19);
            this.lblCompras.TabIndex = 20;
            this.lblCompras.Text = "Músicas Compradas:";
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
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(253, 37);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdade.Size = new System.Drawing.Size(49, 19);
            this.lblIdade.TabIndex = 17;
            this.lblIdade.Text = "Idade:";
            // 
            // picPerfil
            // 
            this.picPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPerfil.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPerfil.InitialImage")));
            this.picPerfil.Location = new System.Drawing.Point(268, 12);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(250, 250);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfil.TabIndex = 24;
            this.picPerfil.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(55, 19);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "(Email)";
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenName.Location = new System.Drawing.Point(7, 124);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScreenName.Size = new System.Drawing.Size(219, 25);
            this.lblScreenName.TabIndex = 22;
            this.lblScreenName.Text = "Nome de Tela do Usuário";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 12);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(209, 19);
            this.lblFiltro.TabIndex = 27;
            this.lblFiltro.Text = "Buscar ID ou Nome de Usuário:";
            // 
            // txtFiltroId
            // 
            this.txtFiltroId.Location = new System.Drawing.Point(12, 34);
            this.txtFiltroId.Name = "txtFiltroId";
            this.txtFiltroId.Size = new System.Drawing.Size(250, 27);
            this.txtFiltroId.TabIndex = 28;
            // 
            // btnFiltroId
            // 
            this.btnFiltroId.Location = new System.Drawing.Point(12, 67);
            this.btnFiltroId.Name = "btnFiltroId";
            this.btnFiltroId.Size = new System.Drawing.Size(250, 27);
            this.btnFiltroId.TabIndex = 31;
            this.btnFiltroId.Text = "Buscar";
            this.btnFiltroId.UseVisualStyleBackColor = true;
            this.btnFiltroId.Click += new System.EventHandler(this.btnFiltroId_Click);
            // 
            // frmUsuarioBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 685);
            this.Controls.Add(this.btnFiltroId);
            this.Controls.Add(this.txtFiltroId);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pnlBio);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblScreenName);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsuarioBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarioBusca";
            this.pnlBio.ResumeLayout(false);
            this.pnlBio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBio;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltroId;
        private System.Windows.Forms.Button btnFiltroId;
    }
}