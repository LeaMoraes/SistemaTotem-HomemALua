namespace SIstemaTotemHomemALua
{
    partial class ObrasDescricoes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObrasDescricoes));
            pcbObraImagem = new PictureBox();
            lblObraDescricao = new Label();
            pbxBotaoVoltar = new PictureBox();
            lblObraTitulo = new Label();
            tmrTempoAusencia = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pcbObraImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoVoltar).BeginInit();
            SuspendLayout();
            // 
            // pcbObraImagem
            // 
            pcbObraImagem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pcbObraImagem.Image = (Image)resources.GetObject("pcbObraImagem.Image");
            pcbObraImagem.Location = new Point(293, 84);
            pcbObraImagem.Name = "pcbObraImagem";
            pcbObraImagem.Size = new Size(812, 436);
            pcbObraImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pcbObraImagem.TabIndex = 0;
            pcbObraImagem.TabStop = false;
            pcbObraImagem.Click += pcbObraImagem_Click;
            // 
            // lblObraDescricao
            // 
            lblObraDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblObraDescricao.AutoSize = true;
            lblObraDescricao.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObraDescricao.ForeColor = Color.White;
            lblObraDescricao.Location = new Point(179, 546);
            lblObraDescricao.MaximumSize = new Size(1366, 768);
            lblObraDescricao.Name = "lblObraDescricao";
            lblObraDescricao.Size = new Size(287, 37);
            lblObraDescricao.TabIndex = 1;
            lblObraDescricao.Text = "DescriçãoDaObra";
            lblObraDescricao.Click += lblObraDescricao_Click;
            // 
            // pbxBotaoVoltar
            // 
            pbxBotaoVoltar.Image = Properties.Resources.BotãoVoltar;
            pbxBotaoVoltar.Location = new Point(12, 12);
            pbxBotaoVoltar.Name = "pbxBotaoVoltar";
            pbxBotaoVoltar.Size = new Size(110, 110);
            pbxBotaoVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBotaoVoltar.TabIndex = 2;
            pbxBotaoVoltar.TabStop = false;
            pbxBotaoVoltar.Click += pbxBotaoVoltar_Click;
            // 
            // lblObraTitulo
            // 
            lblObraTitulo.AutoSize = true;
            lblObraTitulo.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObraTitulo.ForeColor = Color.White;
            lblObraTitulo.Location = new Point(179, 12);
            lblObraTitulo.Name = "lblObraTitulo";
            lblObraTitulo.Size = new Size(327, 56);
            lblObraTitulo.TabIndex = 3;
            lblObraTitulo.Text = "TituloDaObra";
            lblObraTitulo.Click += lblObraTitulo_Click;
            // 
            // tmrTempoAusencia
            // 
            tmrTempoAusencia.Enabled = true;
            tmrTempoAusencia.Interval = 30000;
            tmrTempoAusencia.Tick += tmrTempoAusencia_Tick;
            // 
            // ObrasDescricoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 41, 90);
            ClientSize = new Size(1366, 768);
            Controls.Add(lblObraTitulo);
            Controls.Add(pbxBotaoVoltar);
            Controls.Add(lblObraDescricao);
            Controls.Add(pcbObraImagem);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "ObrasDescricoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ObrasDescricoes";
            Click += ObrasDescricoes_Click;
            ((System.ComponentModel.ISupportInitialize)pcbObraImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoVoltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbObraImagem;
        private Label lblObraDescricao;
        private PictureBox pbxBotaoVoltar;
        private Label lblObraTitulo;
        private System.Windows.Forms.Timer tmrTempoAusencia;
    }
}