namespace SIstemaTotemHomemALua
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pcbMapa = new PictureBox();
            pcbObras = new PictureBox();
            pcbQuestionario = new PictureBox();
            pcbPreencherTabela = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMapa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbObras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbQuestionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPreencherTabela).BeginInit();
            SuspendLayout();
            // 
            // pcbMapa
            // 
            pcbMapa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pcbMapa.BackColor = Color.Transparent;
            pcbMapa.Image = Properties.Resources.BotãoMapa;
            pcbMapa.Location = new Point(505, 91);
            pcbMapa.Name = "pcbMapa";
            pcbMapa.Size = new Size(326, 144);
            pcbMapa.SizeMode = PictureBoxSizeMode.AutoSize;
            pcbMapa.TabIndex = 5;
            pcbMapa.TabStop = false;
            pcbMapa.Click += pcbMapa_Click;
            // 
            // pcbObras
            // 
            pcbObras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbObras.BackColor = Color.Transparent;
            pcbObras.Image = Properties.Resources.BotãoObra;
            pcbObras.Location = new Point(505, 295);
            pcbObras.Name = "pcbObras";
            pcbObras.Size = new Size(326, 144);
            pcbObras.SizeMode = PictureBoxSizeMode.AutoSize;
            pcbObras.TabIndex = 6;
            pcbObras.TabStop = false;
            pcbObras.Click += pcbObras_Click;
            // 
            // pcbQuestionario
            // 
            pcbQuestionario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbQuestionario.BackColor = Color.Transparent;
            pcbQuestionario.Image = Properties.Resources.BotãoQuestionario;
            pcbQuestionario.Location = new Point(505, 493);
            pcbQuestionario.Name = "pcbQuestionario";
            pcbQuestionario.Size = new Size(326, 144);
            pcbQuestionario.SizeMode = PictureBoxSizeMode.AutoSize;
            pcbQuestionario.TabIndex = 7;
            pcbQuestionario.TabStop = false;
            pcbQuestionario.Click += pcbQuestionario_Click;
            // 
            // pcbPreencherTabela
            // 
            pcbPreencherTabela.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbPreencherTabela.BackColor = Color.Transparent;
            pcbPreencherTabela.Image = (Image)resources.GetObject("pcbPreencherTabela.Image");
            pcbPreencherTabela.Location = new Point(12, 696);
            pcbPreencherTabela.Name = "pcbPreencherTabela";
            pcbPreencherTabela.Size = new Size(268, 60);
            pcbPreencherTabela.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPreencherTabela.TabIndex = 33;
            pcbPreencherTabela.TabStop = false;
            pcbPreencherTabela.Click += pcbPreencherTabela_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1366, 768);
            Controls.Add(pcbPreencherTabela);
            Controls.Add(pcbQuestionario);
            Controls.Add(pcbObras);
            Controls.Add(pcbMapa);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1364, 766);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            FormClosed += Form1_FormClosed;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pcbMapa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbObras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbQuestionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPreencherTabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbMapa;
        private PictureBox pcbObras;
        private PictureBox pcbQuestionario;
        private PictureBox pcbPreencherTabela;
    }
}
