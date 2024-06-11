namespace SIstemaTotemHomemALua
{
    partial class TabelaDeLideranca
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaDeLideranca));
            dgvTabelaLideranca = new DataGridView();
            lblRelatorio = new Label();
            pbxBotaoContinuar = new PictureBox();
            tmrTempoAusencia = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvTabelaLideranca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoContinuar).BeginInit();
            SuspendLayout();
            // 
            // dgvTabelaLideranca
            // 
            dgvTabelaLideranca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTabelaLideranca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTabelaLideranca.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTabelaLideranca.BackgroundColor = Color.FromArgb(0, 20, 44);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTabelaLideranca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTabelaLideranca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTabelaLideranca.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTabelaLideranca.Location = new Point(114, 124);
            dgvTabelaLideranca.MultiSelect = false;
            dgvTabelaLideranca.Name = "dgvTabelaLideranca";
            dgvTabelaLideranca.ReadOnly = true;
            dgvTabelaLideranca.RowHeadersVisible = false;
            dgvTabelaLideranca.Size = new Size(1133, 481);
            dgvTabelaLideranca.TabIndex = 12;
            dgvTabelaLideranca.Click += dgvRelatorio_Click;
            // 
            // lblRelatorio
            // 
            lblRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRelatorio.AutoSize = true;
            lblRelatorio.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRelatorio.ForeColor = Color.White;
            lblRelatorio.Location = new Point(114, 33);
            lblRelatorio.Name = "lblRelatorio";
            lblRelatorio.Size = new Size(612, 72);
            lblRelatorio.TabIndex = 13;
            lblRelatorio.Text = "Tabela de Liderança";
            lblRelatorio.TextAlign = ContentAlignment.MiddleCenter;
            lblRelatorio.Click += lblRelatorio_Click;
            // 
            // pbxBotaoContinuar
            // 
            pbxBotaoContinuar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbxBotaoContinuar.Image = (Image)resources.GetObject("pbxBotaoContinuar.Image");
            pbxBotaoContinuar.Location = new Point(1076, 645);
            pbxBotaoContinuar.Name = "pbxBotaoContinuar";
            pbxBotaoContinuar.Size = new Size(262, 72);
            pbxBotaoContinuar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBotaoContinuar.TabIndex = 14;
            pbxBotaoContinuar.TabStop = false;
            pbxBotaoContinuar.Click += pbxBotaoContinuar_Click;
            // 
            // tmrTempoAusencia
            // 
            tmrTempoAusencia.Enabled = true;
            tmrTempoAusencia.Interval = 40000;
            tmrTempoAusencia.Tick += tmrTempoAusencia_Tick;
            // 
            // TabelaDeLideranca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 41, 90);
            ClientSize = new Size(1366, 768);
            Controls.Add(pbxBotaoContinuar);
            Controls.Add(lblRelatorio);
            Controls.Add(dgvTabelaLideranca);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TabelaDeLideranca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabelaDeLideranca";
            Click += TabelaDeLideranca_Click;
            ((System.ComponentModel.ISupportInitialize)dgvTabelaLideranca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBotaoContinuar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTabelaLideranca;
        private Label lblRelatorio;
        private PictureBox pbxBotaoContinuar;
        private System.Windows.Forms.Timer tmrTempoAusencia;
    }
}