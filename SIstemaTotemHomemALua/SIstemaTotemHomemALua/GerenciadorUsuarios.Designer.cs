namespace SIstemaTotemHomemALua
{
    partial class GerenciadorUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciadorUsuarios));
            lblTituloDev = new Label();
            dgvDev = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDev).BeginInit();
            SuspendLayout();
            // 
            // lblTituloDev
            // 
            lblTituloDev.AutoSize = true;
            lblTituloDev.Location = new Point(31, 9);
            lblTituloDev.Name = "lblTituloDev";
            lblTituloDev.Size = new Size(494, 105);
            lblTituloDev.TabIndex = 0;
            lblTituloDev.Text = resources.GetString("lblTituloDev.Text");
            // 
            // dgvDev
            // 
            dgvDev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDev.Location = new Point(31, 117);
            dgvDev.Name = "dgvDev";
            dgvDev.RowHeadersVisible = false;
            dgvDev.Size = new Size(494, 249);
            dgvDev.TabIndex = 3;
            // 
            // GerenciadorUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 396);
            Controls.Add(dgvDev);
            Controls.Add(lblTituloDev);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GerenciadorUsuarios";
            Text = "Dev Gerenciador de Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvDev).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloDev;
        private Button button1;
        private DataGridView dgvDev;
    }
}