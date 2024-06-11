namespace SIstemaTotemHomemALua
{
    partial class Questionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questionario));
            lblPergunta = new Label();
            pbxBotaoMenu = new PictureBox();
            pbxBotaoContinuar = new PictureBox();
            lblMensagem = new Label();
            tmrTempoAusencia = new System.Windows.Forms.Timer(components);
            pcbAlternativaA = new PictureBox();
            lblAlternativaA = new Label();
            pcbAlternativaB = new PictureBox();
            lblAlternativaB = new Label();
            pcbAlternativaC = new PictureBox();
            lblAlternativaC = new Label();
            pcbAlternativaD = new PictureBox();
            lblAlternativaD = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoContinuar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlternativaA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlternativaB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlternativaC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlternativaD).BeginInit();
            SuspendLayout();
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta.ForeColor = Color.White;
            lblPergunta.Location = new Point(293, 12);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(220, 55);
            lblPergunta.TabIndex = 4;
            lblPergunta.Text = "Pergunta";
            lblPergunta.TextAlign = ContentAlignment.MiddleLeft;
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
            // pbxBotaoContinuar
            // 
            pbxBotaoContinuar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbxBotaoContinuar.Image = (Image)resources.GetObject("pbxBotaoContinuar.Image");
            pbxBotaoContinuar.Location = new Point(1076, 645);
            pbxBotaoContinuar.Name = "pbxBotaoContinuar";
            pbxBotaoContinuar.Size = new Size(262, 72);
            pbxBotaoContinuar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBotaoContinuar.TabIndex = 10;
            pbxBotaoContinuar.TabStop = false;
            pbxBotaoContinuar.Click += pbxBotaoContinuar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.IndianRed;
            lblMensagem.Location = new Point(293, 645);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(185, 40);
            lblMensagem.TabIndex = 11;
            lblMensagem.Text = "Mensagem";
            lblMensagem.TextAlign = ContentAlignment.MiddleLeft;
            lblMensagem.Visible = false;
            // 
            // tmrTempoAusencia
            // 
            tmrTempoAusencia.Enabled = true;
            tmrTempoAusencia.Interval = 60000;
            tmrTempoAusencia.Tick += tmrTempoAusencia_Tick;
            // 
            // pcbAlternativaA
            // 
            pcbAlternativaA.Image = Properties.Resources.BotaoA;
            pcbAlternativaA.Location = new Point(229, 232);
            pcbAlternativaA.Name = "pcbAlternativaA";
            pcbAlternativaA.Size = new Size(94, 89);
            pcbAlternativaA.SizeMode = PictureBoxSizeMode.Zoom;
            pcbAlternativaA.TabIndex = 12;
            pcbAlternativaA.TabStop = false;
            pcbAlternativaA.Click += pcbAlternativaA_Click;
            // 
            // lblAlternativaA
            // 
            lblAlternativaA.AutoSize = true;
            lblAlternativaA.Font = new Font("Arial", 32F);
            lblAlternativaA.ForeColor = Color.White;
            lblAlternativaA.Location = new Point(270, 249);
            lblAlternativaA.Name = "lblAlternativaA";
            lblAlternativaA.Size = new Size(257, 49);
            lblAlternativaA.TabIndex = 13;
            lblAlternativaA.Text = "AlternativaA";
            lblAlternativaA.TextAlign = ContentAlignment.MiddleLeft;
            lblAlternativaA.Click += lblAlternativaA_Click;
            // 
            // pcbAlternativaB
            // 
            pcbAlternativaB.Image = (Image)resources.GetObject("pcbAlternativaB.Image");
            pcbAlternativaB.Location = new Point(229, 327);
            pcbAlternativaB.Name = "pcbAlternativaB";
            pcbAlternativaB.Size = new Size(94, 89);
            pcbAlternativaB.SizeMode = PictureBoxSizeMode.Zoom;
            pcbAlternativaB.TabIndex = 14;
            pcbAlternativaB.TabStop = false;
            pcbAlternativaB.Click += pcbAlternativaB_Click;
            // 
            // lblAlternativaB
            // 
            lblAlternativaB.AutoSize = true;
            lblAlternativaB.Font = new Font("Arial", 32F);
            lblAlternativaB.ForeColor = Color.White;
            lblAlternativaB.Location = new Point(270, 348);
            lblAlternativaB.Name = "lblAlternativaB";
            lblAlternativaB.Size = new Size(257, 49);
            lblAlternativaB.TabIndex = 15;
            lblAlternativaB.Text = "AlternativaB";
            lblAlternativaB.TextAlign = ContentAlignment.MiddleLeft;
            lblAlternativaB.Click += lblAlternativaB_Click;
            // 
            // pcbAlternativaC
            // 
            pcbAlternativaC.Image = (Image)resources.GetObject("pcbAlternativaC.Image");
            pcbAlternativaC.Location = new Point(229, 423);
            pcbAlternativaC.Name = "pcbAlternativaC";
            pcbAlternativaC.Size = new Size(94, 89);
            pcbAlternativaC.SizeMode = PictureBoxSizeMode.Zoom;
            pcbAlternativaC.TabIndex = 16;
            pcbAlternativaC.TabStop = false;
            pcbAlternativaC.Click += pcbAlternativaC_Click;
            // 
            // lblAlternativaC
            // 
            lblAlternativaC.AutoSize = true;
            lblAlternativaC.Font = new Font("Arial", 32F);
            lblAlternativaC.ForeColor = Color.White;
            lblAlternativaC.Location = new Point(270, 444);
            lblAlternativaC.Name = "lblAlternativaC";
            lblAlternativaC.Size = new Size(259, 49);
            lblAlternativaC.TabIndex = 17;
            lblAlternativaC.Text = "AlternativaC";
            lblAlternativaC.TextAlign = ContentAlignment.MiddleLeft;
            lblAlternativaC.Click += lblAlternativaC_Click;
            // 
            // pcbAlternativaD
            // 
            pcbAlternativaD.BackColor = Color.Transparent;
            pcbAlternativaD.Image = (Image)resources.GetObject("pcbAlternativaD.Image");
            pcbAlternativaD.Location = new Point(229, 517);
            pcbAlternativaD.Name = "pcbAlternativaD";
            pcbAlternativaD.Size = new Size(94, 89);
            pcbAlternativaD.SizeMode = PictureBoxSizeMode.Zoom;
            pcbAlternativaD.TabIndex = 18;
            pcbAlternativaD.TabStop = false;
            pcbAlternativaD.Click += pcbAlternativaD_Click;
            // 
            // lblAlternativaD
            // 
            lblAlternativaD.AutoSize = true;
            lblAlternativaD.Font = new Font("Arial", 32F);
            lblAlternativaD.ForeColor = Color.White;
            lblAlternativaD.Location = new Point(270, 538);
            lblAlternativaD.Name = "lblAlternativaD";
            lblAlternativaD.Size = new Size(259, 49);
            lblAlternativaD.TabIndex = 19;
            lblAlternativaD.Text = "AlternativaD";
            lblAlternativaD.TextAlign = ContentAlignment.MiddleLeft;
            lblAlternativaD.Click += lblAlternativaD_Click;
            // 
            // Questionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(pcbAlternativaA);
            Controls.Add(pcbAlternativaD);
            Controls.Add(lblAlternativaD);
            Controls.Add(pcbAlternativaC);
            Controls.Add(lblAlternativaC);
            Controls.Add(pcbAlternativaB);
            Controls.Add(lblAlternativaB);
            Controls.Add(lblMensagem);
            Controls.Add(pbxBotaoContinuar);
            Controls.Add(pbxBotaoMenu);
            Controls.Add(lblPergunta);
            Controls.Add(lblAlternativaA);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "Questionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questionario";
            Click += Questionario_Click;
            ((System.ComponentModel.ISupportInitialize)pbxBotaoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoContinuar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlternativaA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlternativaB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlternativaC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlternativaD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPergunta;
        private PictureBox pbxBotaoMenu;
        private PictureBox pbxBotaoContinuar;
        private Label lblMensagem;
        private System.Windows.Forms.Timer tmrTempoAusencia;
        private PictureBox pcbAlternativaA;
        private Label lblAlternativaA;
        private PictureBox pcbAlternativaB;
        private Label lblAlternativaB;
        private PictureBox pcbAlternativaC;
        private Label lblAlternativaC;
        private PictureBox pcbAlternativaD;
        private Label lblAlternativaD;
    }
}