namespace SIstemaTotemHomemALua
{
    partial class Mapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mapa));
            pbxBotaoMenu = new PictureBox();
            pcbMapa = new PictureBox();
            tmrTempoAusencia = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxBotaoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMapa).BeginInit();
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
            // pcbMapa
            // 
            pcbMapa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbMapa.BackColor = Color.Transparent;
            pcbMapa.Image = Properties.Resources.Mapa;
            pcbMapa.Location = new Point(120, 90);
            pcbMapa.Name = "pcbMapa";
            pcbMapa.Size = new Size(1101, 615);
            pcbMapa.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMapa.TabIndex = 10;
            pcbMapa.TabStop = false;
            pcbMapa.Click += pcbMapa_Click;
            // 
            // tmrTempoAusencia
            // 
            tmrTempoAusencia.Enabled = true;
            tmrTempoAusencia.Interval = 30000;
            tmrTempoAusencia.Tick += tmrTempoAusencia_Tick;
            // 
            // Mapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(pcbMapa);
            Controls.Add(pbxBotaoMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "Mapa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mapa";
            Click += Mapa_Click;
            ((System.ComponentModel.ISupportInitialize)pbxBotaoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMapa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxBotaoMenu;
        private PictureBox pcbMapa;
        private System.Windows.Forms.Timer tmrTempoAusencia;
    }
}