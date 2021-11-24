namespace JossemarProMegaFinalSinoDaMeSuicido
{
    partial class FrmSaldos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMensual = new System.Windows.Forms.DataGridView();
            this.dgvDiario = new System.Windows.Forms.DataGridView();
            this.lblHoy = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMensual);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saldo Mensual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDiario);
            this.groupBox2.Location = new System.Drawing.Point(294, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo Diario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblHoy);
            this.groupBox3.Location = new System.Drawing.Point(587, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 108);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ganancias de hoy";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDev);
            this.groupBox4.Location = new System.Drawing.Point(587, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Devoluciones";
            // 
            // dgvMensual
            // 
            this.dgvMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensual.Location = new System.Drawing.Point(6, 19);
            this.dgvMensual.Name = "dgvMensual";
            this.dgvMensual.Size = new System.Drawing.Size(215, 265);
            this.dgvMensual.TabIndex = 0;
            // 
            // dgvDiario
            // 
            this.dgvDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiario.Location = new System.Drawing.Point(6, 19);
            this.dgvDiario.Name = "dgvDiario";
            this.dgvDiario.Size = new System.Drawing.Size(215, 265);
            this.dgvDiario.TabIndex = 1;
            // 
            // lblHoy
            // 
            this.lblHoy.AutoSize = true;
            this.lblHoy.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.lblHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHoy.Location = new System.Drawing.Point(31, 30);
            this.lblHoy.Name = "lblHoy";
            this.lblHoy.Size = new System.Drawing.Size(216, 56);
            this.lblHoy.TabIndex = 0;
            this.lblHoy.Text = "C$ 0.000";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.lblDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDev.Location = new System.Drawing.Point(31, 22);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(216, 56);
            this.lblDev.TabIndex = 1;
            this.lblDev.Text = "C$ 0.000";
            // 
            // FrmSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSaldos";
            this.Text = "FrmSaldos";
            this.Load += new System.EventHandler(this.FrmSaldos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMensual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDiario;
        private System.Windows.Forms.Label lblHoy;
        private System.Windows.Forms.Label lblDev;
    }
}