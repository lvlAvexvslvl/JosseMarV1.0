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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBarraSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TxtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnBuscar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LblFiltrar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RbtnMarca = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DgvInventario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PnlBarraSuperior.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).BeginInit();
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
            this.PnlBarraSuperior.Size = new System.Drawing.Size(1568, 31);
            this.PnlBarraSuperior.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FillColor = System.Drawing.Color.Gray;
            this.BtnSalir.HoverState.Parent = this.BtnSalir;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(1523, 0);
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
            this.TxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscar.FocusedState.Parent = this.TxtBuscar;
            this.TxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscar.HoverState.Parent = this.TxtBuscar;
            this.TxtBuscar.Location = new System.Drawing.Point(555, 48);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.ShadowDecoration.Parent = this.TxtBuscar;
            this.TxtBuscar.Size = new System.Drawing.Size(444, 39);
            this.TxtBuscar.TabIndex = 73;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.CheckedState.Parent = this.BtnBuscar;
            this.BtnBuscar.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnBuscar.HoverState.Parent = this.BtnBuscar;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnBuscar.Location = new System.Drawing.Point(513, 48);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.PressedState.Parent = this.BtnBuscar;
            this.BtnBuscar.Size = new System.Drawing.Size(56, 39);
            this.BtnBuscar.TabIndex = 72;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblFiltrar
            // 
            this.LblFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.LblFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltrar.Location = new System.Drawing.Point(21, 48);
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
            this.RbtnMarca.Location = new System.Drawing.Point(21, 70);
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
            this.guna2RadioButton2.Location = new System.Drawing.Point(82, 70);
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
            this.guna2RadioButton3.Location = new System.Drawing.Point(208, 70);
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
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.DgvInventario);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(5, 102);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(1551, 569);
            this.guna2GroupBox2.TabIndex = 78;
            this.guna2GroupBox2.Text = "Inventario";
            // 
            // DgvInventario
            // 
            this.DgvInventario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.DgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvInventario.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInventario.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvInventario.EnableHeadersVisualStyles = false;
            this.DgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventario.Location = new System.Drawing.Point(4, 34);
            this.DgvInventario.Name = "DgvInventario";
            this.DgvInventario.ReadOnly = true;
            this.DgvInventario.RowHeadersVisible = false;
            this.DgvInventario.RowHeadersWidth = 51;
            this.DgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInventario.Size = new System.Drawing.Size(1544, 520);
            this.DgvInventario.TabIndex = 0;
            this.DgvInventario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvInventario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvInventario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvInventario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInventario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvInventario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvInventario.ThemeStyle.HeaderStyle.Height = 32;
            this.DgvInventario.ThemeStyle.ReadOnly = true;
            this.DgvInventario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvInventario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInventario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvInventario.ThemeStyle.RowsStyle.Height = 22;
            this.DgvInventario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventario_CellClick);
            this.DgvInventario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvInventario_CellPainting);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 722);
            this.Controls.Add(this.guna2GroupBox2);
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
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.PnlBarraSuperior.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).EndInit();
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
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView DgvInventario;
    }
}