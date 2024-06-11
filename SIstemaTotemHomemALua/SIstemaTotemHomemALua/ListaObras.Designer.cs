namespace SIstemaTotemHomemALua
{
    partial class ListaObras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaObras));
            pcbQuadroId1 = new PictureBox();
            pcbQuadroId2 = new PictureBox();
            lblQuadroId1 = new Label();
            lblQuadroId2 = new Label();
            pbxBotaoMenu = new PictureBox();
            pbxBotaoPaginaDown = new PictureBox();
            pbxBotaoPaginaUp = new PictureBox();
            tmrTempoAusencia = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pcbQuadroId1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbQuadroId2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoPaginaDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoPaginaUp).BeginInit();
            SuspendLayout();
            // 
            // pcbQuadroId1
            // 
            pcbQuadroId1.Image = Properties.Resources.ImagemPadraoQuadros;
            pcbQuadroId1.Location = new Point(12, 123);
            pcbQuadroId1.Name = "pcbQuadroId1";
            pcbQuadroId1.Size = new Size(602, 464);
            pcbQuadroId1.SizeMode = PictureBoxSizeMode.Zoom;
            pcbQuadroId1.TabIndex = 0;
            pcbQuadroId1.TabStop = false;
            pcbQuadroId1.Click += pcbQuadroId1_Click;
            // 
            // pcbQuadroId2
            // 
            pcbQuadroId2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbQuadroId2.Image = Properties.Resources.ImagemPadraoQuadros;
            pcbQuadroId2.Location = new Point(752, 123);
            pcbQuadroId2.Name = "pcbQuadroId2";
            pcbQuadroId2.Size = new Size(602, 464);
            pcbQuadroId2.SizeMode = PictureBoxSizeMode.Zoom;
            pcbQuadroId2.TabIndex = 1;
            pcbQuadroId2.TabStop = false;
            pcbQuadroId2.Click += pcbQuadroId2_Click;
            // 
            // lblQuadroId1
            // 
            lblQuadroId1.AutoSize = true;
            lblQuadroId1.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            lblQuadroId1.ForeColor = Color.White;
            lblQuadroId1.Location = new Point(81, 607);
            lblQuadroId1.Name = "lblQuadroId1";
            lblQuadroId1.Size = new Size(209, 41);
            lblQuadroId1.TabIndex = 4;
            lblQuadroId1.Text = "Quadro Id 1";
            lblQuadroId1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuadroId2
            // 
            lblQuadroId2.AutoSize = true;
            lblQuadroId2.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            lblQuadroId2.ForeColor = Color.White;
            lblQuadroId2.Location = new Point(816, 607);
            lblQuadroId2.Name = "lblQuadroId2";
            lblQuadroId2.Size = new Size(209, 41);
            lblQuadroId2.TabIndex = 5;
            lblQuadroId2.Text = "Quadro Id 2";
            lblQuadroId2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbxBotaoMenu
            // 
            pbxBotaoMenu.Image = Properties.Resources.BotãoMenu;
            pbxBotaoMenu.Location = new Point(12, 12);
            pbxBotaoMenu.Name = "pbxBotaoMenu";
            pbxBotaoMenu.Size = new Size(262, 72);
            pbxBotaoMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxBotaoMenu.TabIndex = 8;
            pbxBotaoMenu.TabStop = false;
            pbxBotaoMenu.Click += pbxBotaoMenu_Click;
            // 
            // pbxBotaoPaginaDown
            // 
            pbxBotaoPaginaDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxBotaoPaginaDown.Image = Properties.Resources.BotãoProximaPagina;
            pbxBotaoPaginaDown.Location = new Point(631, 607);
            pbxBotaoPaginaDown.Name = "pbxBotaoPaginaDown";
            pbxBotaoPaginaDown.Size = new Size(110, 110);
            pbxBotaoPaginaDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBotaoPaginaDown.TabIndex = 9;
            pbxBotaoPaginaDown.TabStop = false;
            pbxBotaoPaginaDown.Click += pbxBotaoPaginaDown_Click;
            // 
            // pbxBotaoPaginaUp
            // 
            pbxBotaoPaginaUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbxBotaoPaginaUp.Image = (Image)resources.GetObject("pbxBotaoPaginaUp.Image");
            pbxBotaoPaginaUp.Location = new Point(631, 12);
            pbxBotaoPaginaUp.Name = "pbxBotaoPaginaUp";
            pbxBotaoPaginaUp.Size = new Size(110, 110);
            pbxBotaoPaginaUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBotaoPaginaUp.TabIndex = 10;
            pbxBotaoPaginaUp.TabStop = false;
            pbxBotaoPaginaUp.Visible = false;
            pbxBotaoPaginaUp.Click += pbxBotaoPaginaUp_Click;
            // 
            // tmrTempoAusencia
            // 
            tmrTempoAusencia.Enabled = true;
            tmrTempoAusencia.Interval = 30000;
            tmrTempoAusencia.Tick += tmrTempoAusencia_Tick;
            // 
            // ListaObras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 41, 90);
            ClientSize = new Size(1366, 768);
            ControlBox = false;
            Controls.Add(pbxBotaoPaginaUp);
            Controls.Add(pbxBotaoPaginaDown);
            Controls.Add(pbxBotaoMenu);
            Controls.Add(lblQuadroId2);
            Controls.Add(lblQuadroId1);
            Controls.Add(pcbQuadroId2);
            Controls.Add(pcbQuadroId1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "ListaObras";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaObras";
            Click += ListaObras_Click;
            ((System.ComponentModel.ISupportInitialize)pcbQuadroId1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbQuadroId2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoPaginaDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoPaginaUp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbQuadroId1;
        private PictureBox pcbQuadroId2;
        private Label lblQuadroId1;
        private Label lblQuadroId2;
        private PictureBox pbxBotaoMenu;
        private PictureBox pbxBotaoPaginaDown;
        private PictureBox pbxBotaoPaginaUp;
        private System.Windows.Forms.Timer tmrTempoAusencia;
    }
}