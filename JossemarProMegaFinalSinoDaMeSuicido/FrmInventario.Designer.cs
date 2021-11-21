namespace JossemarProMegaFinalSinoDaMeSuicido
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.PnlBarraSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TxtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnBuscar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LblFiltrar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RbtnMarca = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.PnlBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBarraSuperior
            // 
            this.PnlBarraSuperior.Controls.Add(this.BtnSalir);
            this.PnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraSuperior.FillColor = System.Drawing.Color.Gray;
            this.PnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraSuperior.Name = "PnlBarraSuperior";
            this.PnlBarraSuperior.ShadowDecoration.Parent = this.PnlBarraSuperior;
            this.PnlBarraSuperior.Size = new System.Drawing.Size(1221, 31);
            this.PnlBarraSuperior.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FillColor = System.Drawing.Color.Gray;
            this.BtnSalir.HoverState.Parent = this.BtnSalir;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(1176, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ShadowDecoration.Parent = this.BtnSalir;
            this.BtnSalir.Size = new System.Drawing.Size(45, 31);
            this.BtnSalir.TabIndex = 0;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderRadius = 15;
            this.TxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscar.DefaultText = "";
            this.TxtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscar.DisabledState.Parent = this.TxtBuscar;
            this.TxtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscar.Enabled = false;
            this.TxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscar.FocusedState.Parent = this.TxtBuscar;
            this.TxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscar.HoverState.Parent = this.TxtBuscar;
            this.TxtBuscar.Location = new System.Drawing.Point(376, 48);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.ShadowDecoration.Parent = this.TxtBuscar;
            this.TxtBuscar.Size = new System.Drawing.Size(444, 39);
            this.TxtBuscar.TabIndex = 73;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.CheckedState.Parent = this.BtnBuscar;
            this.BtnBuscar.Enabled = false;
            this.BtnBuscar.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnBuscar.HoverState.Parent = this.BtnBuscar;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnBuscar.Location = new System.Drawing.Point(334, 48);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.PressedState.Parent = this.BtnBuscar;
            this.BtnBuscar.Size = new System.Drawing.Size(56, 39);
            this.BtnBuscar.TabIndex = 72;
            // 
            // LblFiltrar
            // 
            this.LblFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.LblFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltrar.Location = new System.Drawing.Point(60, 48);
            this.LblFiltrar.Name = "LblFiltrar";
            this.LblFiltrar.Size = new System.Drawing.Size(69, 19);
            this.LblFiltrar.TabIndex = 74;
            this.LblFiltrar.Text = "Filtrar por:";
            // 
            // RbtnMarca
            // 
            this.RbtnMarca.AutoSize = true;
            this.RbtnMarca.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RbtnMarca.CheckedState.BorderThickness = 0;
            this.RbtnMarca.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RbtnMarca.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RbtnMarca.CheckedState.InnerOffset = -4;
            this.RbtnMarca.Location = new System.Drawing.Point(60, 73);
            this.RbtnMarca.Name = "RbtnMarca";
            this.RbtnMarca.Size = new System.Drawing.Size(55, 17);
            this.RbtnMarca.TabIndex = 75;
            this.RbtnMarca.TabStop = true;
            this.RbtnMarca.Text = "Marca";
            this.RbtnMarca.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RbtnMarca.UncheckedState.BorderThickness = 2;
            this.RbtnMarca.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RbtnMarca.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RbtnMarca.UseVisualStyleBackColor = true;
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.Location = new System.Drawing.Point(60, 96);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(120, 17);
            this.guna2RadioButton2.TabIndex = 76;
            this.guna2RadioButton2.TabStop = true;
            this.guna2RadioButton2.Text = "guna2RadioButton2";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UseVisualStyleBackColor = true;
            // 
            // guna2RadioButton3
            // 
            this.guna2RadioButton3.AutoSize = true;
            this.guna2RadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton3.CheckedState.BorderThickness = 0;
            this.guna2RadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton3.CheckedState.InnerOffset = -4;
            this.guna2RadioButton3.Location = new System.Drawing.Point(60, 119);
            this.guna2RadioButton3.Name = "guna2RadioButton3";
            this.guna2RadioButton3.Size = new System.Drawing.Size(120, 17);
            this.guna2RadioButton3.TabIndex = 77;
            this.guna2RadioButton3.TabStop = true;
            this.guna2RadioButton3.Text = "guna2RadioButton3";
            this.guna2RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton3.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton3.UseVisualStyleBackColor = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 683);
            this.Controls.Add(this.guna2RadioButton3);
            this.Controls.Add(this.guna2RadioButton2);
            this.Controls.Add(this.RbtnMarca);
            this.Controls.Add(this.LblFiltrar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.PnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.PnlBarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlBarraSuperior;
        private Guna.UI2.WinForms.Guna2ControlBox BtnSalir;
        private Guna.UI2.WinForms.Guna2TextBox TxtBuscar;
        private Guna.UI2.WinForms.Guna2ImageButton BtnBuscar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFiltrar;
        private Guna.UI2.WinForms.Guna2RadioButton RbtnMarca;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton3;
    }
}