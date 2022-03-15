namespace JossemarProMegaFinalSinoDaMeSuicido
{
    partial class FrmMessage
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
            this.label2 = new System.Windows.Forms.Label();
            this.CmbMD = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Motivo de Devolución";
            // 
            // CmbMD
            // 
            this.CmbMD.FormattingEnabled = true;
            this.CmbMD.Location = new System.Drawing.Point(75, 25);
            this.CmbMD.Name = "CmbMD";
            this.CmbMD.Size = new System.Drawing.Size(149, 21);
            this.CmbMD.TabIndex = 116;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.CheckedState.Parent = this.BtnAceptar;
            this.BtnAceptar.CustomImages.Parent = this.BtnAceptar;
            this.BtnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.HoverState.Parent = this.BtnAceptar;
            this.BtnAceptar.Location = new System.Drawing.Point(90, 66);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.ShadowDecoration.Parent = this.BtnAceptar;
            this.BtnAceptar.Size = new System.Drawing.Size(108, 31);
            this.BtnAceptar.TabIndex = 118;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 109);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbMD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessage";
            this.Load += new System.EventHandler(this.FrmMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbMD;
        private Guna.UI2.WinForms.Guna2Button BtnAceptar;
    }
}