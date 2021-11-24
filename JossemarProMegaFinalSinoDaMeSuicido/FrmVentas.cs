using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FrmVentas : Form
    {
        public FrmVentas(string ids)
        {
            InitializeComponent();
            id = ids;
        }

        string id, IdCliente, Descripcion, PrecioVenta, IdProducto, res;
        int contador=0;
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaAgregarClientes addC = new CLogicaAgregarClientes();
        CLogicaAgregarClientesCredito addcc = new CLogicaAgregarClientesCredito();
        CLogicaContadorCedula contCedula = new CLogicaContadorCedula();
        CDatosValidarCedula validation = new CDatosValidarCedula();
        CLogicaVentas vtc = new CLogicaVentas();

        void ProductosG(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%" + a + "%'");
           
        }

        void ProductosMarca(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%"+a+"%' ORDER BY vs_BtnViewInventario.Marca");

        }

        void ProductosPrecioASC(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%"+a+"%' ORDER BY vs_BtnViewInventario.PrecioVenta ASC");

        }

        void ProductosPrecioDesc(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%"+a+"%' ORDER BY vs_BtnViewInventario.PrecioVenta DESC");

        }

        void ProductosFechaDesc(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%"+a+"%' ORDER BY vs_BtnViewInventario.FechaCaducidad DESC");

        }
        void ProductosFechaASC(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%"+a+"%' ORDER BY vs_BtnViewInventario.FechaCaducidad ASC");

        }

        void ProductosCategoria(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%"+a+"%' ORDER BY vs_BtnViewInventario.DescripcionC");

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = id;
            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosG("");
        
            DgvProductos.Columns["ID"].Visible = false;
            DgvProductos.Columns["NFactura"].Visible = false;
            DgvProductos.Columns["FechaIngreso"].Visible = false;
            DgvProductos.Columns["Proveedor"].Visible = false;

            foreach (DataGridViewColumn c in DgvCarrito.Columns)
                if (c.Name != "Cantidad") c.ReadOnly = true;

            TxtDescuento.Text = "0";
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (RbtnMarca.Checked ==true)
            {
                ProductosMarca(TxtBuscar.Text);
            }
           else if (RbtnPrecio.Checked == true)
            {
                ProductosPrecioASC(TxtBuscar.Text);
                ProductosPrecioDesc(TxtBuscar.Text);
            }
            else if (RbtnFecha.Checked ==true)
            {
                ProductosFechaASC(TxtBuscar.Text);
                ProductosFechaDesc(TxtBuscar.Text);
            }
            else if (RbtnCategoria.Checked==true)
            {
                ProductosCategoria(TxtBuscar.Text);
            }
            else
            {
                ProductosG(TxtBuscar.Text);
            }
        }


        //METODO PARA CAPTURAR DATOS DE CLIENTES CORRIENTE
        void ClientesCorriente()
        {
            if (TxtNombreFull.Text != "" && TxtApellido.Text != "")
            {
               res = addC.AddClientes(TxtNombreFull.Text.Trim(), TxtApellido.Text.Trim());
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //void ClientesCredito()
        //{
        //    string a = Convert.ToString(validation.ValidarCedula(TxtCedulaV.Text));
        //    MessageBox.Show(a);

        //    if (MetodoValidarAll() == 5)
        //    {
        //       addcc.AddClientes(TxtNombreFull.Text.Trim(), TxtApellido.Text.Trim(), TxtTelefono.Text.Trim(), 1, TxtDireccion.Text.Trim(), TxtCedulaV.Text.Trim());
        //    }
        //    else
        //    {
        //        MessageBox.Show("Uno o mas campos están vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private void BtnAgregarDV_Click(object sender, EventArgs e)
        {

            if (RbtnCorriente.Checked == true)
            {
                if (TxtNombreFull.Text != "" && TxtApellido.Text != "" && TxtSubTotal.Text != "" && TxtDescuento.Text != "" && TxtTotal.Text != "")
                {
                    int a = DgvSave.RowCount;
                    for (int i = 0; i < a; i++)
                    {
                        DgvSave.Rows.Add();
                        DgvSave.Rows[i].Cells[0].Value = DgvCarrito.CurrentRow.Cells[0].Value;
                        DgvSave.Rows[i].Cells[1].Value = 19;
                        DgvSave.Rows[i].Cells[2].Value = TxtDescuento.Text;
                        DgvSave.Rows[i].Cells[3].Value = DgvCarrito.CurrentRow.Cells[4].Value;
                        DgvSave.Rows[i].Cells[4].Value = DtpFechaFact.Value.ToString("yyy/MM/dd");
                        DgvSave.Rows[i].Cells[5].Value = TxtSubTotal.Text;
                        DgvSave.Rows[i].Cells[6].Value = TxtTotal.Text;
                        DgvSave.Rows[i].Cells[7].Value = id;


                        int IdProd = Convert.ToInt32(DgvSave.Rows[i].Cells[0].Value);
                        int IdCliente = Convert.ToInt32(DgvSave.Rows[i].Cells[1].Value);
                        double descu = Convert.ToDouble(DgvSave.Rows[i].Cells[2].Value);
                        double Cant = Convert.ToDouble(DgvSave.Rows[i].Cells[3].Value);
                        string fhc = Convert.ToString(DgvSave.Rows[i].Cells[4].Value);
                        double Subt2 = Convert.ToDouble(DgvSave.Rows[i].Cells[5].Value);
                        double Total2 = Convert.ToDouble(DgvSave.Rows[i].Cells[6].Value);
                        int IdUser = Convert.ToInt32(DgvSave.Rows[i].Cells[7].Value);

                        res = vtc.AddVenta(IdProd, IdCliente, descu, Cant, fhc, Subt2, Total2, IdUser);
                    }
                    if (res == "G")
                    {
                        MessageBox.Show("La venta se realizó con éxito :)");
                    }
                    else if (res == "N")
                    {
                        MessageBox.Show("La venta no se realizó con éxito :(");
                    }
                }
                else
                {
                    MessageBox.Show("Uno o mas campos están vacíos. :(");
                }
            }
            else if (RbtnCredito.Checked == true)
            {
                if (TxtNombreFull.Text != "" && TxtApellido.Text != "" && TxtTelefono.Text != "" && TxtDireccion.Text != "" && TxtCedulaV.Text != "")
                {

                }
            }
            /*ClientesCorriente();*/
        }

      

        private void RbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            ProductosMarca("");
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnPrecio.Checked == true) { 
            DialogResult result = MessageBox.Show("Ordenar Precio Ascendente <Si>\nOrdenar Precio Descendete <No>", "Avíso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                ProductosPrecioASC("");
            }
            else if (result == DialogResult.No)
            {
                ProductosPrecioDesc("");
            }
            }


        }

        private void RbtnFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(RbtnFecha.Checked == true) { 
            DialogResult result = MessageBox.Show("Ordenar Fecha Ascendente <Si>\nOrdenar Fecha Descendete <No>", "Avíso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                ProductosFechaASC("");
            }
            else if (result == DialogResult.No)
            {
                ProductosFechaDesc("");
            }
            }
        }

        private void RbtnCategoria_CheckedChanged(object sender, EventArgs e)
        {
            ProductosCategoria("");
        }

        //METODO PARA CAMPTURAR VENTA
        void AgregarVenta()
        {

            int filas = DgvCarrito.Rows.Count;


            // Verificar si ya esta agegado
            Boolean esta = false;
            if (filas != 0)
            {
                for (int i = 0; i < filas; i++)
                {
                    if (Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value) == Convert.ToInt32(DgvCarrito.Rows[i].Cells[0].Value))
                    {
                        esta = true;

                        break;

                    }
                }

            }

            if (esta)
            {
                MessageBox.Show("El Paquete ya está en la orden");
            }
            else
            {
                //int filas = 0 + contador;
                //contador++;
                DgvCarrito.Rows.Add();
                DgvCarrito.Rows[filas].Cells[0].Value = DgvProductos.CurrentRow.Cells[0].Value;
                DgvCarrito.Rows[filas].Cells[1].Value = DgvProductos.CurrentRow.Cells[2].Value;
                DgvCarrito.Rows[filas].Cells[2].Value = DgvProductos.CurrentRow.Cells[5].Value;
                DgvCarrito.Rows[filas].Cells[3].Value = DgvProductos.CurrentRow.Cells[10].Value;

                string nomCli = TxtNombreFull.Text.Trim();
                string apllidoCli = TxtApellido.Text.Trim();


                string result = sql.ConsultaSimple("SELECT COUNT(*) FROM dbo.Clientes WHERE NombreCli = '" + nomCli + "' AND ApellidoCli = '" + apllidoCli + "'");
                if (Convert.ToInt32(result) > 0)
                {
                    IdCliente = sql.ConsultaSimple("SELECT MAX(dbo.Clientes.IdClientes) FROM Clientes");
                }
                else if (Convert.ToInt32(result) == 0)
                {
                    IdCliente = addC.AddClientes(nomCli, apllidoCli);
                }
                DgvCarrito.Rows[filas].Cells[5].Value = IdCliente;
                DgvCarrito.Rows[filas].Cells[6].Value = TxtDescuento.Text;
                DgvCarrito.Rows[filas].Cells[7].Value = DtpFechaFact.Value.ToString("yyy/MM/dd");
                DgvCarrito.Rows[filas].Cells[8].Value = TxtSubTotal.Text;
                DgvCarrito.Rows[filas].Cells[9].Value = TxtTotal.Text;
                DgvCarrito.Rows[filas].Cells[10].Value = id;
            }

            //..............................................................UnU uWu UwU UuU 


        }

       /* void MetodoSave()
        {
            string idC;
            int conteo2;
            if (RbtnCorriente.Checked ==true)
            {
                //idC = addC.AddClientes(TxtNombreFull.Text.Trim(), TxtApellido.Text.Trim());
                
                //if (idC.Trim() != "")
                //{
                    int conteo = DgvCarrito.Rows.Count;

                    if (conteo > 0)
                    {
                    ClientesCorriente();
                    MessageBox.Show("IDC = " + res);
                    for (int i = 0; i < conteo; i++)
                        {
                            DgvSave.Rows.Add();
                            DgvSave.Rows[i].Cells[0].Value = DgvCarrito.CurrentRow.Cells[0].Value;
                            DgvSave.Rows[i].Cells[1].Value = 19;
                            DgvSave.Rows[i].Cells[2].Value = TxtDescuento.Text;
                            DgvSave.Rows[i].Cells[3].Value = DgvCarrito.CurrentRow.Cells[4].Value;
                            DgvSave.Rows[i].Cells[4].Value = DtpFechaFact.Value.ToString("yyy/MM/dd");
                            DgvSave.Rows[i].Cells[5].Value = TxtSubTotal.Text;
                            DgvSave.Rows[i].Cells[6].Value = TxtTotal.Text;
                            DgvSave.Rows[i].Cells[7].Value = id;

                            int IdProd = Convert.ToInt32(DgvSave.Rows[i].Cells[0].Value);
                            int IdCliente = Convert.ToInt32(DgvSave.Rows[i].Cells[1].Value);
                            double descu = Convert.ToDouble(DgvSave.Rows[i].Cells[2].Value);
                            double Cant = Convert.ToDouble(DgvSave.Rows[i].Cells[3].Value);
                            string fhc = Convert.ToString(DgvSave.Rows[i].Cells[4].Value);
                            double Subt2 = Convert.ToDouble(DgvSave.Rows[i].Cells[5].Value);
                            double Total2 = Convert.ToDouble(DgvSave.Rows[i].Cells[6].Value);
                            int IdUser = Convert.ToInt32(DgvSave.Rows[i].Cells[7].Value);

                           res = vtc.AddVenta(IdProd, IdCliente, descu, Cant, fhc, Subt2, Total2, IdUser);
                        }
                        if (res=="G")
                        {
                            MessageBox.Show("La venta se realizó con éxito :)");
                        }
                        else if (res == "N")
                        {
                            MessageBox.Show("La venta no se realizó con éxito :(");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Antes de guardar añada productos al carrito. :)", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                //}
            }
            else if (RbtnCredito.Checked==true)
            {
                idC = addcc.AddClientes2(TxtNombreFull.Text.Trim(), TxtApellido.Text.Trim(), TxtTelefono.Text.Trim(), 1, TxtDireccion.Text.Trim(), TxtCedulaV.Text.Trim());
                if (idC == "C")
                {
                    string contCed = sql.ConsultaSimple("SELECT ClientesCredito.IdClientes FROM ClientesCredito WHERE ClientesCredito.Cedula = '"+TxtCedulaV.Text.Trim()+"'");
                    
                        int conteo = DgvCarrito.Rows.Count;

                        for (int i = 0; i < conteo; i++)
                        {
                        DgvSave.Rows.Add();
                        DgvSave.Rows[i].Cells[0].Value = DgvCarrito.CurrentRow.Cells[0].Value;
                        DgvSave.Rows[i].Cells[1].Value = idC;
                        DgvSave.Rows[i].Cells[2].Value = TxtDescuento.Text;
                        DgvSave.Rows[i].Cells[3].Value = DgvCarrito.CurrentRow.Cells[4].Value;
                        DgvSave.Rows[i].Cells[4].Value = DtpFechaFact.Value.ToString("yyy/MM/dd");
                        DgvSave.Rows[i].Cells[5].Value = TxtSubTotal.Text;
                        DgvSave.Rows[i].Cells[6].Value = TxtTotal.Text;
                        DgvSave.Rows[i].Cells[7].Value = id;
                    }
                    
                }
                else if (idC == "G")
                {
                    string idCg = sql.ConsultaSimple("SELECT MAX(dbo.ClientesCredito.IdClientes) FROM ClientesCredito");
                     conteo2 = DgvCarrito.Rows.Count;

                    for (int i = 0; i < conteo2; i++)
                    {
                        DgvSave.Rows.Add();
                        DgvSave.Rows[i].Cells[0].Value = DgvCarrito.CurrentRow.Cells[0].Value;
                        DgvSave.Rows[i].Cells[1].Value = idC;
                        DgvSave.Rows[i].Cells[2].Value = TxtDescuento.Text;
                        DgvSave.Rows[i].Cells[3].Value = DgvCarrito.CurrentRow.Cells[4].Value;
                        DgvSave.Rows[i].Cells[4].Value = DtpFechaFact.Value.ToString("yyy/MM/dd");
                        DgvSave.Rows[i].Cells[5].Value = TxtSubTotal.Text;
                        DgvSave.Rows[i].Cells[6].Value = TxtTotal.Text;
                        DgvSave.Rows[i].Cells[7].Value = id;
                    }
                }
                
            
            }

            
        }*/

        //METODO PARA CAPTURAR DATOS DE LA VENTA 
        void CapturarVenta()
        {
            string nomCli = TxtNombreFull.Text.Trim();
            string apllidoCli = TxtApellido.Text.Trim();


            string result = sql.ConsultaSimple("SELECT COUNT(*) FROM dbo.Clientes WHERE NombreCli = '"+nomCli+"' AND ApellidoCli = '"+apllidoCli+"'");
            if (Convert.ToInt32(result) > 0)
            {
                IdCliente = sql.ConsultaSimple("SELECT MAX(dbo.Clientes.IdClientes) FROM Clientes");
            }
            else if(Convert.ToInt32(result) == 0)
            {
                IdCliente = addC.AddClientes(nomCli, apllidoCli);
            }

            int filas = 0 + contador;
            contador++;
            DgvSave.Rows.Add();
            DgvSave.Rows[filas].Cells[0].Value = DgvCarrito.CurrentRow.Cells[0].Value;
            DgvSave.Rows[filas].Cells[1].Value = IdCliente;
            DgvSave.Rows[filas].Cells[2].Value = TxtDescuento.Text;
            DgvSave.Rows[filas].Cells[3].Value = DgvCarrito.CurrentRow.Cells[4].Value;
            DgvSave.Rows[filas].Cells[4].Value = DtpFechaFact.Value.ToString("yyy/MM/dd");
            DgvSave.Rows[filas].Cells[5].Value = TxtSubTotal.Text;
            DgvSave.Rows[filas].Cells[6].Value = TxtTotal.Text;
            DgvSave.Rows[filas].Cells[7].Value = id;

        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AgregarVenta();
            double Subt = 0;
            double descuento = Convert.ToDouble(TxtDescuento.Text);
            double Total = 0;
            double PreTotal = 0;

            int contCarrito = DgvCarrito.Rows.Count;

            if (contCarrito > 0)
            {
                for (int i = 0; i < contCarrito; i++)
                {
                    double PVenta = Convert.ToDouble(DgvCarrito.Rows[i].Cells[3].Value);
                    double Cantidad = Convert.ToInt32(DgvCarrito.Rows[i].Cells[4].Value);

                    Subt = Subt + (PVenta * Cantidad);
                    TxtSubTotal.Text = Convert.ToString(Subt);

                }
                PreTotal = Convert.ToDouble(TxtSubTotal.Text);
                Total = PreTotal - descuento;
                TxtTotal.Text = Convert.ToString(Total);

            }
            //contador++;
        }

        private void DgvCarrito_SelectionChanged(object sender, EventArgs e)
        {
            DgvCarrito.CurrentCell = DgvCarrito.CurrentRow.Cells["Cantidad"];
            DgvCarrito.BeginEdit(true);
           // MessageBox.Show("asi es");
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Subt = 0;
            double descuento = Convert.ToDouble(TxtDescuento.Text);
            double Total = 0;
            double PreTotal = 0;

            int contCarrito = DgvCarrito.Rows.Count;

            if (contCarrito > 0)
            {
                for (int i = 0; i < contCarrito; i++)
                {
                    double PVenta = Convert.ToDouble(DgvCarrito.Rows[i].Cells[3].Value);
                    double Cantidad = Convert.ToInt32(DgvCarrito.Rows[i].Cells[4].Value);

                    Subt = Subt + (PVenta * Cantidad);
                    TxtSubTotal.Text = Convert.ToString(Subt);
                    
                }
                PreTotal = Convert.ToDouble(TxtSubTotal.Text);
                Total = PreTotal - descuento;
                TxtTotal.Text = Convert.ToString(Total);
                
            }
            else
            {
                MessageBox.Show("Añada productos al carrito antes de calcular :)");
            }
            
        }

        private void RbtnCorriente_CheckedChanged(object sender, EventArgs e)
        {
            TxtInteres.Enabled = false;
            TxtAbono.Enabled = false;
            TxtDeuda.Enabled = false;
            DtpFechaPago.Enabled = false;
            TxtNombreFull.Enabled = true;
            TxtApellido.Enabled = true;
            TxtTelefono.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtCedulaV.Enabled = false;

            //-----------------------------
            TxtDescuento.Enabled = true;
        }

        private void RbtnCredito_CheckedChanged(object sender, EventArgs e)
        {
            TxtInteres.Enabled = true;
            TxtAbono.Enabled = true;
            TxtDeuda.Enabled = true;
            DtpFechaPago.Enabled = true;
            TxtNombreFull.Enabled = true;
            TxtApellido.Enabled = true;
            TxtTelefono.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtCedulaV.Enabled = true;
            //-------------------------
            TxtDescuento.Enabled = false;

        }

        //METODO PARA VALIDAR CAMPOS
        int MetodoValidarAll()
        {
            int validation = 0;
            if (TxtNombreFull.Text != "")
                validation++;

            else
                validation--;

            if (TxtApellido.Text != "")
                validation++;

            else
                validation--;

            if (TxtCedulaV.Text != "")
                validation++;
            else
                validation--;

            if (TxtTelefono.Text != "")
                validation++;
            else
                validation--;

            if (TxtDireccion.Text != "")
                validation++;
            else
                validation--;

            return validation;
        }


    }
}
