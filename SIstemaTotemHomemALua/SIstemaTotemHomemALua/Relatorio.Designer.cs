namespace SIstemaTotemHomemALua
{
    partial class Relatorio
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            pbxBotaoMenu = new PictureBox();
            lblRelatorio = new Label();
            pcbFecharSistema = new PictureBox();
            pcbMostrarBancoDeDados = new PictureBox();
            lblMensagem = new Label();
            dgvRelatorio = new DataGridView();
            pcbRelatorioPerguntas = new PictureBox();
            lblQualidadeObras = new Label();
            lblExperienciaVisita = new Label();
            lblMedia = new Label();
            lblRecomendacao = new Label();
            lblQualidadeObrasMedia = new Label();
            lblExperienciaVisitaMedia = new Label();
            lblRecomendacaoMedia = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFecharSistema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMostrarBancoDeDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbRelatorioPerguntas).BeginInit();
            SuspendLayout();
            // 
            // pbxBotaoMenu
            // 
            pbxBotaoMenu.Image = Properties.Resources.BotãoMenu;
            pbxBotaoMenu.Location = new Point(12, 12);
            pbxBotaoMenu.Name = "pbxBotaoMenu";
            pbxBotaoMenu.Size = new Size(262, 72);
            pbxBotaoMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxBotaoMenu.TabIndex = 9;
            pbxBotaoMenu.TabStop = false;
            pbxBotaoMenu.Click += pbxBotaoMenu_Click;
            // 
            // lblRelatorio
            // 
            lblRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRelatorio.AutoSize = true;
            lblRelatorio.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRelatorio.ForeColor = Color.White;
            lblRelatorio.Location = new Point(531, 9);
            lblRelatorio.Name = "lblRelatorio";
            lblRelatorio.Size = new Size(310, 75);
            lblRelatorio.TabIndex = 10;
            lblRelatorio.Text = "Relatorio";
            lblRelatorio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pcbFecharSistema
            // 
            pcbFecharSistema.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbFecharSistema.Image = Properties.Resources.BotaoFecharSistema;
            pcbFecharSistema.Location = new Point(1102, 12);
            pcbFecharSistema.Name = "pcbFecharSistema";
            pcbFecharSistema.Size = new Size(252, 72);
            pcbFecharSistema.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFecharSistema.TabIndex = 14;
            pcbFecharSistema.TabStop = false;
            pcbFecharSistema.Click += pcbFecharSistema_Click;
            // 
            // pcbMostrarBancoDeDados
            // 
            pcbMostrarBancoDeDados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbMostrarBancoDeDados.Image = Properties.Resources.BotãoMostrarBancoDeDados;
            pcbMostrarBancoDeDados.Location = new Point(987, 696);
            pcbMostrarBancoDeDados.Name = "pcbMostrarBancoDeDados";
            pcbMostrarBancoDeDados.Size = new Size(268, 60);
            pcbMostrarBancoDeDados.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMostrarBancoDeDados.TabIndex = 15;
            pcbMostrarBancoDeDados.TabStop = false;
            pcbMostrarBancoDeDados.Click += pcbMostrarBancoDeDados_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = Color.Transparent;
            lblMensagem.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.IndianRed;
            lblMensagem.Location = new Point(108, 696);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(185, 40);
            lblMensagem.TabIndex = 16;
            lblMensagem.Text = "Mensagem";
            lblMensagem.TextAlign = ContentAlignment.MiddleLeft;
            lblMensagem.Visible = false;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRelatorio.BackgroundColor = Color.FromArgb(0, 20, 44);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRelatorio.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRelatorio.Location = new Point(108, 90);
            dgvRelatorio.MultiSelect = false;
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.RowHeadersVisible = false;
            dgvRelatorio.Size = new Size(598, 600);
            dgvRelatorio.TabIndex = 17;
            // 
            // pcbRelatorioPerguntas
            // 
            pcbRelatorioPerguntas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbRelatorioPerguntas.Image = (Image)resources.GetObject("pcbRelatorioPerguntas.Image");
            pcbRelatorioPerguntas.Location = new Point(713, 696);
            pcbRelatorioPerguntas.Name = "pcbRelatorioPerguntas";
            pcbRelatorioPerguntas.Size = new Size(268, 60);
            pcbRelatorioPerguntas.SizeMode = PictureBoxSizeMode.Zoom;
            pcbRelatorioPerguntas.TabIndex = 18;
            pcbRelatorioPerguntas.TabStop = false;
            pcbRelatorioPerguntas.Click += pcbRelatorioPerguntas_Click;
            // 
            // lblQualidadeObras
            // 
            lblQualidadeObras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblQualidadeObras.AutoSize = true;
            lblQualidadeObras.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQualidadeObras.ForeColor = Color.White;
            lblQualidadeObras.Location = new Point(824, 146);
            lblQualidadeObras.Name = "lblQualidadeObras";
            lblQualidadeObras.Size = new Size(337, 37);
            lblQualidadeObras.TabIndex = 19;
            lblQualidadeObras.Text = "Qualidade das Obras";
            lblQualidadeObras.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExperienciaVisita
            // 
            lblExperienciaVisita.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblExperienciaVisita.AutoSize = true;
            lblExperienciaVisita.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExperienciaVisita.ForeColor = Color.White;
            lblExperienciaVisita.Location = new Point(773, 282);
            lblExperienciaVisita.Name = "lblExperienciaVisita";
            lblExperienciaVisita.Size = new Size(452, 37);
            lblExperienciaVisita.TabIndex = 20;
            lblExperienciaVisita.Text = "Experiencia Durante a Visita";
            lblExperienciaVisita.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMedia
            // 
            lblMedia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedia.ForeColor = Color.White;
            lblMedia.Location = new Point(893, 90);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(188, 56);
            lblMedia.TabIndex = 21;
            lblMedia.Text = "Médias";
            lblMedia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecomendacao
            // 
            lblRecomendacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRecomendacao.AutoSize = true;
            lblRecomendacao.Font = new Font("Arial", 25F, FontStyle.Bold);
            lblRecomendacao.ForeColor = Color.White;
            lblRecomendacao.Location = new Point(816, 418);
            lblRecomendacao.Name = "lblRecomendacao";
            lblRecomendacao.Size = new Size(352, 80);
            lblRecomendacao.TabIndex = 22;
            lblRecomendacao.Text = "Recomendação para\r\nParentes ou Amigos";
            lblRecomendacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQualidadeObrasMedia
            // 
            lblQualidadeObrasMedia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblQualidadeObrasMedia.AutoSize = true;
            lblQualidadeObrasMedia.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQualidadeObrasMedia.ForeColor = Color.White;
            lblQualidadeObrasMedia.Location = new Point(921, 196);
            lblQualidadeObrasMedia.Name = "lblQualidadeObrasMedia";
            lblQualidadeObrasMedia.Size = new Size(122, 75);
            lblQualidadeObrasMedia.TabIndex = 23;
            lblQualidadeObrasMedia.Text = "0.0";
            lblQualidadeObrasMedia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExperienciaVisitaMedia
            // 
            lblExperienciaVisitaMedia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblExperienciaVisitaMedia.AutoSize = true;
            lblExperienciaVisitaMedia.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExperienciaVisitaMedia.ForeColor = Color.White;
            lblExperienciaVisitaMedia.Location = new Point(921, 334);
            lblExperienciaVisitaMedia.Name = "lblExperienciaVisitaMedia";
            lblExperienciaVisitaMedia.Size = new Size(122, 75);
            lblExperienciaVisitaMedia.TabIndex = 24;
            lblExperienciaVisitaMedia.Text = "0.0";
            lblExperienciaVisitaMedia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecomendacaoMedia
            // 
            lblRecomendacaoMedia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRecomendacaoMedia.AutoSize = true;
            lblRecomendacaoMedia.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecomendacaoMedia.ForeColor = Color.White;
            lblRecomendacaoMedia.Location = new Point(921, 522);
            lblRecomendacaoMedia.Name = "lblRecomendacaoMedia";
            lblRecomendacaoMedia.Size = new Size(122, 75);
            lblRecomendacaoMedia.TabIndex = 25;
            lblRecomendacaoMedia.Text = "0.0";
            lblRecomendacaoMedia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 41, 90);
            ClientSize = new Size(1366, 768);
            Controls.Add(lblRecomendacaoMedia);
            Controls.Add(lblExperienciaVisitaMedia);
            Controls.Add(lblQualidadeObrasMedia);
            Controls.Add(lblRecomendacao);
            Controls.Add(lblMedia);
            Controls.Add(lblExperienciaVisita);
            Controls.Add(lblQualidadeObras);
            Controls.Add(pcbRelatorioPerguntas);
            Controls.Add(dgvRelatorio);
            Controls.Add(lblMensagem);
            Controls.Add(pcbMostrarBancoDeDados);
            Controls.Add(pcbFecharSistema);
            Controls.Add(lblRelatorio);
            Controls.Add(pbxBotaoMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1364, 726);
            Name = "Relatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatorio";
            ((System.ComponentModel.ISupportInitialize)pbxBotaoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFecharSistema).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMostrarBancoDeDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbRelatorioPerguntas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxBotaoMenu;
        private Label lblRelatorio;
        private PictureBox pcbFecharSistema;
        private PictureBox pcbMostrarBancoDeDados;
        private Label lblMensagem;
        private DataGridView dgvRelatorio;
        private PictureBox pcbRelatorioPerguntas;
        private Label lblQualidadeObras;
        private Label lblExperienciaVisita;
        private Label lblMedia;
        private Label lblRecomendacao;
        private Label lblQualidadeObrasMedia;
        private Label lblExperienciaVisitaMedia;
        private Label lblRecomendacaoMedia;
    }
}