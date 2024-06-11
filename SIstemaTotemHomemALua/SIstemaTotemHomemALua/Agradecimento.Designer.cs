namespace SIstemaTotemHomemALua
{
    partial class Agradecimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agradecimento));
            pctAgradecimentoFaixa = new PictureBox();
            tmrFecharJanela = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pctAgradecimentoFaixa).BeginInit();
            SuspendLayout();
            // 
            // pctAgradecimentoFaixa
            // 
            pctAgradecimentoFaixa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pctAgradecimentoFaixa.BackColor = Color.Transparent;
            pctAgradecimentoFaixa.Image = Properties.Resources.AgradecimentoFaixa;
            pctAgradecimentoFaixa.Location = new Point(273, 308);
            pctAgradecimentoFaixa.Name = "pctAgradecimentoFaixa";
            pctAgradecimentoFaixa.Size = new Size(813, 219);
            pctAgradecimentoFaixa.SizeMode = PictureBoxSizeMode.Zoom;
            pctAgradecimentoFaixa.TabIndex = 0;
            pctAgradecimentoFaixa.TabStop = false;
            pctAgradecimentoFaixa.Click += pictureBox1_Click;
            // 
            // tmrFecharJanela
            // 
            tmrFecharJanela.Enabled = true;
            tmrFecharJanela.Interval = 10000;
            tmrFecharJanela.Tick += tmrFecharJanela_Tick;
            // 
            // Agradecimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaAgradecimento;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1366, 768);
            Controls.Add(pctAgradecimentoFaixa);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "Agradecimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agradecimento";
            Click += Agradecimento_Click;
            ((System.ComponentModel.ISupportInitialize)pctAgradecimentoFaixa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctAgradecimentoFaixa;
        private System.Windows.Forms.Timer tmrFecharJanela;
    }
}