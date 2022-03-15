namespace JossemarProMegaFinalSinoDaMeSuicido
{
    partial class FrmHistorialVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialVentas));
            this.PnlBarraSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvHistorialV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RbtnCancelarV = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RbtnEditarVenta = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Rbtb3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Rbn4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.PanelRbtn = new Guna.UI2.WinForms.Guna2Panel();
            this.TxtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnBuscar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PnlBarraSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialV)).BeginInit();
            this.PanelRbtn.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBarraSuperior
            // 
            this.PnlBarraSuperior.Controls.Add(this.LblUsuario);
            this.PnlBarraSuperior.Controls.Add(this.BtnSalir);
            this.PnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraSuperior.FillColor = System.Drawing.Color.Gray;
            this.PnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraSuperior.Name = "PnlBarraSuperior";
            this.PnlBarraSuperior.ShadowDecoration.Parent = this.PnlBarraSuperior;
            this.PnlBarraSuperior.Size = new System.Drawing.Size(1369, 40);
            this.PnlBarraSuperior.TabIndex = 109;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Location = new System.Drawing.Point(455, 9);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(13, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "a";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FillColor = System.Drawing.Color.Gray;
            this.BtnSalir.HoverState.Parent = this.BtnSalir;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(1324, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ShadowDecoration.Parent = this.BtnSalir;
            this.BtnSalir.Size = new System.Drawing.Size(45, 40);
            this.BtnSalir.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DgvHistorialV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1345, 492);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Ventas Realizadas";
            // 
            // DgvHistorialV
            // 
            this.DgvHistorialV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvHistorialV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHistorialV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHistorialV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHistorialV.BackgroundColor = System.Drawing.Color.White;
            this.DgvHistorialV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHistorialV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvHistorialV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistorialV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHistorialV.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHistorialV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvHistorialV.EnableHeadersVisualStyles = false;
            this.DgvHistorialV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvHistorialV.Location = new System.Drawing.Point(6, 23);
            this.DgvHistorialV.Name = "DgvHistorialV";
            this.DgvHistorialV.RowHeadersVisible = false;
            this.DgvHistorialV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHistorialV.Size = new System.Drawing.Size(1333, 463);
            this.DgvHistorialV.TabIndex = 0;
            this.DgvHistorialV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DgvHistorialV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvHistorialV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvHistorialV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvHistorialV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvHistorialV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvHistorialV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvHistorialV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvHistorialV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvHistorialV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvHistorialV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvHistorialV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvHistorialV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvHistorialV.ThemeStyle.HeaderStyle.Height = 34;
            this.DgvHistorialV.ThemeStyle.ReadOnly = false;
            this.DgvHistorialV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvHistorialV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvHistorialV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvHistorialV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvHistorialV.ThemeStyle.RowsStyle.Height = 22;
            this.DgvHistorialV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvHistorialV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvHistorialV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistorialV_CellClick);
            this.DgvHistorialV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvHistorialV_CellFormatting);
            this.DgvHistorialV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvHistorialV_CellPainting);
            // 
            // RbtnCancelarV
            // 
            this.RbtnCancelarV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbtnCancelarV.AutoSize = true;
            this.RbtnCancelarV.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RbtnCancelarV.CheckedState.BorderThickness = 0;
            this.RbtnCancelarV.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RbtnCancelarV.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RbtnCancelarV.CheckedState.InnerOffset = -4;
            this.RbtnCancelarV.Enabled = false;
            this.RbtnCancelarV.Location = new System.Drawing.Point(6, 22);
            this.RbtnCancelarV.Name = "RbtnCancelarV";
            this.RbtnCancelarV.Size = new System.Drawing.Size(106, 17);
            this.RbtnCancelarV.TabIndex = 111;
            this.RbtnCancelarV.TabStop = true;
            this.RbtnCancelarV.Text = "Cancelar Factura";
            this.RbtnCancelarV.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RbtnCancelarV.UncheckedState.BorderThickness = 2;
            this.RbtnCancelarV.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RbtnCancelarV.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RbtnCancelarV.UseVisualStyleBackColor = true;
            this.RbtnCancelarV.Visible = false;
            this.RbtnCancelarV.CheckedChanged += new System.EventHandler(this.RbtnCancelarV_CheckedChanged);
            // 
            // RbtnEditarVenta
            // 
            this.RbtnEditarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbtnEditarVenta.AutoSize = true;
            this.RbtnEditarVenta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RbtnEditarVenta.CheckedState.BorderThickness = 0;
            this.RbtnEditarVenta.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RbtnEditarVenta.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RbtnEditarVenta.CheckedState.InnerOffset = -4;
            this.RbtnEditarVenta.Enabled = false;
            this.RbtnEditarVenta.Location = new System.Drawing.Point(127, 22);
            this.RbtnEditarVenta.Name = "RbtnEditarVenta";
            this.RbtnEditarVenta.Size = new System.Drawing.Size(83, 17);
            this.RbtnEditarVenta.TabIndex = 112;
            this.RbtnEditarVenta.TabStop = true;
            this.RbtnEditarVenta.Text = "Editar Venta";
            this.RbtnEditarVenta.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RbtnEditarVenta.UncheckedState.BorderThickness = 2;
            this.RbtnEditarVenta.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RbtnEditarVenta.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RbtnEditarVenta.UseVisualStyleBackColor = true;
            this.RbtnEditarVenta.Visible = false;
            // 
            // Rbtb3
            // 
            this.Rbtb3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rbtb3.AutoSize = true;
            this.Rbtb3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rbtb3.CheckedState.BorderThickness = 0;
            this.Rbtb3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rbtb3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rbtb3.CheckedState.InnerOffset = -4;
            this.Rbtb3.Enabled = false;
            this.Rbtb3.Location = new System.Drawing.Point(6, 54);
            this.Rbtb3.Name = "Rbtb3";
            this.Rbtb3.Size = new System.Drawing.Size(98, 17);
            this.Rbtb3.TabIndex = 113;
            this.Rbtb3.TabStop = true;
            this.Rbtb3.Text = "Cancelar Venta";
            this.Rbtb3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rbtb3.UncheckedState.BorderThickness = 2;
            this.Rbtb3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rbtb3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Rbtb3.UseVisualStyleBackColor = true;
            this.Rbtb3.Visible = false;
            // 
            // Rbn4
            // 
            this.Rbn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rbn4.AutoSize = true;
            this.Rbn4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rbn4.CheckedState.BorderThickness = 0;
            this.Rbn4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rbn4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rbn4.CheckedState.InnerOffset = -4;
            this.Rbn4.Enabled = false;
            this.Rbn4.Location = new System.Drawing.Point(127, 54);
            this.Rbn4.Name = "Rbn4";
            this.Rbn4.Size = new System.Drawing.Size(98, 17);
            this.Rbn4.TabIndex = 114;
            this.Rbn4.TabStop = true;
            this.Rbn4.Text = "Cancelar Venta";
            this.Rbn4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rbn4.UncheckedState.BorderThickness = 2;
            this.Rbn4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rbn4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Rbn4.UseVisualStyleBackColor = true;
            this.Rbn4.Visible = false;
            // 
            // PanelRbtn
            // 
            this.PanelRbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelRbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelRbtn.BorderRadius = 2;
            this.PanelRbtn.BorderThickness = 1;
            this.PanelRbtn.Controls.Add(this.RbtnEditarVenta);
            this.PanelRbtn.Controls.Add(this.Rbn4);
            this.PanelRbtn.Controls.Add(this.RbtnCancelarV);
            this.PanelRbtn.Controls.Add(this.Rbtb3);
            this.PanelRbtn.Location = new System.Drawing.Point(12, 603);
            this.PanelRbtn.Name = "PanelRbtn";
            this.PanelRbtn.ShadowDecoration.Parent = this.PanelRbtn;
            this.PanelRbtn.Size = new System.Drawing.Size(238, 100);
            this.PanelRbtn.TabIndex = 115;
            this.PanelRbtn.Visible = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderRadius = 3;
            this.TxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscar.DefaultText = "";
            this.TxtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscar.DisabledState.Parent = this.TxtBuscar;
            this.TxtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscar.FocusedState.Parent = this.TxtBuscar;
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscar.HoverState.Parent = this.TxtBuscar;
            this.TxtBuscar.Location = new System.Drawing.Point(904, 46);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.ShadowDecoration.Parent = this.TxtBuscar;
            this.TxtBuscar.Size = new System.Drawing.Size(382, 39);
            this.TxtBuscar.TabIndex = 117;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Location = new System.Drawing.Point(533, 675);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(238, 28);
            this.guna2Panel1.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "Facturas Canceladas";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUpdate.CheckedState.Parent = this.BtnUpdate;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.CustomImages.Parent = this.BtnUpdate;
            this.BtnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.HoverState.Parent = this.BtnUpdate;
            this.BtnUpdate.Image = global::JossemarProMegaFinalSinoDaMeSuicido.Properties.Resources.update_64px1;
            this.BtnUpdate.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnUpdate.Location = new System.Drawing.Point(1292, 658);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.ShadowDecoration.Parent = this.BtnUpdate;
            this.BtnUpdate.Size = new System.Drawing.Size(59, 45);
            this.BtnUpdate.TabIndex = 118;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::JossemarProMegaFinalSinoDaMeSuicido.Properties.Resources.NavajoColor;
            this.guna2ImageButton1.Location = new System.Drawing.Point(3, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(24, 16);
            this.guna2ImageButton1.TabIndex = 118;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.CheckedState.Parent = this.BtnBuscar;
            this.BtnBuscar.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnBuscar.HoverState.Parent = this.BtnBuscar;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnBuscar.Location = new System.Drawing.Point(862, 46);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.PressedState.Parent = this.BtnBuscar;
            this.BtnBuscar.Size = new System.Drawing.Size(46, 39);
            this.BtnBuscar.TabIndex = 116;
            // 
            // FrmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1369, 715);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.PanelRbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistorialVentas";
            this.Text = "FrmHistorialVentas";
            this.Load += new System.EventHandler(this.FrmHistorialVentas_Load);
            this.PnlBarraSuperior.ResumeLayout(false);
            this.PnlBarraSuperior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialV)).EndInit();
            this.PanelRbtn.ResumeLayout(false);
            this.PanelRbtn.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlBarraSuperior;
        private System.Windows.Forms.Label LblUsuario;
        private Guna.UI2.WinForms.Guna2ControlBox BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DgvHistorialV;
        private Guna.UI2.WinForms.Guna2RadioButton RbtnCancelarV;
        private Guna.UI2.WinForms.Guna2RadioButton RbtnEditarVenta;
        private Guna.UI2.WinForms.Guna2RadioButton Rbtb3;
        private Guna.UI2.WinForms.Guna2RadioButton Rbn4;
        private Guna.UI2.WinForms.Guna2Panel PanelRbtn;
        private Guna.UI2.WinForms.Guna2TextBox TxtBuscar;
        private Guna.UI2.WinForms.Guna2ImageButton BtnBuscar;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
    }
}