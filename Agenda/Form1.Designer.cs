namespace Agenda
{
    partial class Agenda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.lstContatos = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarContato = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(12, 42);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(214, 20);
            this.txtNome.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbCancelar,
            this.tsbExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(659, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Visible = false;
            this.tsbExcluir.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 101);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(12, 162);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 5;
            this.Telefone.Text = "Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(15, 178);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(101, 20);
            this.mskTelefone.TabIndex = 6;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(151, 178);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 7;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstContatos
            // 
            this.lstContatos.ContextMenuStrip = this.contextMenuStrip1;
            this.lstContatos.HideSelection = false;
            this.lstContatos.Location = new System.Drawing.Point(293, 84);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.Size = new System.Drawing.Size(354, 157);
            this.lstContatos.TabIndex = 8;
            this.lstContatos.UseCompatibleStateImageBehavior = false;
            this.lstContatos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstContatos_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem1.Text = "Excluir Contato";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // BuscarContato
            // 
            this.BuscarContato.AutoSize = true;
            this.BuscarContato.Location = new System.Drawing.Point(293, 42);
            this.BuscarContato.Name = "BuscarContato";
            this.BuscarContato.Size = new System.Drawing.Size(83, 13);
            this.BuscarContato.TabIndex = 9;
            this.BuscarContato.Text = "Buscar Contato:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(293, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(214, 20);
            this.txtBuscar.TabIndex = 10;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(520, 56);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(56, 23);
            this.Buscar.TabIndex = 11;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 253);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.BuscarContato);
            this.Controls.Add(this.lstContatos);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.ListView lstContatos;
        private System.Windows.Forms.Label BuscarContato;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

