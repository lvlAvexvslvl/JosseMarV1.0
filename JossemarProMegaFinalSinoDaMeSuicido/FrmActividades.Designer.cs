namespace JossemarProMegaFinalSinoDaMeSuicido
{
    partial class FrmActividades
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
            this.gbAbrir = new System.Windows.Forms.GroupBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVerMov = new System.Windows.Forms.DataGridView();
            this.gbCerrar = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.gbAbrir.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerMov)).BeginInit();
            this.gbCerrar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAbrir
            // 
            this.gbAbrir.Controls.Add(this.btnAbrir);
            this.gbAbrir.Controls.Add(this.txtMonto);
            this.gbAbrir.Controls.Add(this.label1);
            this.gbAbrir.Location = new System.Drawing.Point(30, 26);
            this.gbAbrir.Name = "gbAbrir";
            this.gbAbrir.Size = new System.Drawing.Size(342, 130);
            this.gbAbrir.TabIndex = 0;
            this.gbAbrir.TabStop = false;
            this.gbAbrir.Text = "Abrir caja";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(136, 91);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(124, 39);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(152, 29);
            this.txtMonto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvVerMov);
            this.groupBox2.Location = new System.Drawing.Point(30, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimientos";
            // 
            // dgvVerMov
            // 
            this.dgvVerMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerMov.Location = new System.Drawing.Point(0, 19);
            this.dgvVerMov.Name = "dgvVerMov";
            this.dgvVerMov.RowHeadersWidth = 10;
            this.dgvVerMov.Size = new System.Drawing.Size(449, 200);
            this.dgvVerMov.TabIndex = 0;
            // 
            // gbCerrar
            // 
            this.gbCerrar.Controls.Add(this.btnCerrar);
            this.gbCerrar.Controls.Add(this.lblMonto);
            this.gbCerrar.Location = new System.Drawing.Point(469, 26);
            this.gbCerrar.Name = "gbCerrar";
            this.gbCerrar.Size = new System.Drawing.Size(369, 141);
            this.gbCerrar.TabIndex = 1;
            this.gbCerrar.TabStop = false;
            this.gbCerrar.Text = "Cerrar Caja";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(155, 91);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Arial", 25F);
            this.lblMonto.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMonto.Location = new System.Drawing.Point(131, 25);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(89, 39);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "C$ 0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDetalles);
            this.groupBox4.Location = new System.Drawing.Point(506, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 225);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ventas";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(6, 19);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(382, 200);
            this.dgvDetalles.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCompras);
            this.groupBox1.Location = new System.Drawing.Point(924, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 225);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras";
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(6, 19);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(382, 200);
            this.dgvCompras.TabIndex = 0;
            // 
            // FrmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCerrar);
            this.Controls.Add(this.gbAbrir);
            this.Name = "FrmActividades";
            this.Text = "FrmActividades";
            this.Load += new System.EventHandler(this.FrmActividades_Load);
            this.gbAbrir.ResumeLayout(false);
            this.gbAbrir.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerMov)).EndInit();
            this.gbCerrar.ResumeLayout(false);
            this.gbCerrar.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAbrir;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvVerMov;
        private System.Windows.Forms.GroupBox gbCerrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCompras;
    }
}