namespace Playlist.View
{
    partial class frmUsuarioPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioPerfil));
            this.lblScreenName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.pnlBio = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.pnlBio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenName.Location = new System.Drawing.Point(12, 13);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScreenName.Size = new System.Drawing.Size(219, 25);
            this.lblScreenName.TabIndex = 0;
            this.lblScreenName.Text = "Nome de Tela do Usuário";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(55, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "(Email)";
            // 
            // picPerfil
            // 
            this.picPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPerfil.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPerfil.InitialImage")));
            this.picPerfil.Location = new System.Drawing.Point(248, 13);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(250, 250);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfil.TabIndex = 15;
            this.picPerfil.TabStop = false;
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
            this.pnlBio.Location = new System.Drawing.Point(504, 13);
            this.pnlBio.Name = "pnlBio";
            this.pnlBio.Size = new System.Drawing.Size(437, 212);
            this.pnlBio.TabIndex = 16;
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
            // rtbDescricao
            // 
            this.rtbDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescricao.Location = new System.Drawing.Point(5, 35);
            this.rtbDescricao.Margin = new System.Windows.Forms.Padding(5);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.ReadOnly = true;
            this.rtbDescricao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDescricao.Size = new System.Drawing.Size(240, 170);
            this.rtbDescricao.TabIndex = 2;
            this.rtbDescricao.Text = "";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(504, 231);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(437, 32);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar Perfil";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmUsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 685);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlBio);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblScreenName);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuarioPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.pnlBio.ResumeLayout(false);
            this.pnlBio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Panel pnlBio;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Button btnEditar;
    }
}