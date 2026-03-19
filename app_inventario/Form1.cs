using app_inventario.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario
{
    public partial class Form1 : Form
    {




        // Constructor de la clase Form1 inicializa los componentes y carga los datos iniciales
        public Form1()
        {
            InitializeComponent();
            //LOGEO CODIGO ****
            //F_Log frm = new F_Log();  frm.StartPosition = FormStartPosition.CenterParent;  frm.ShowDialog();


            //validar comboBox
            cb_ing_prov_comp.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ing_tipo_comp.DropDownStyle = ComboBoxStyle.DropDownList;


            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;

            comando.CommandText = "SELECT compras.id_compra, " +
                                        "compras.nom_compra, " +
                                        "compras.precio_compra, " +
                                        "compras.nom_tipo_prod, " +
                                        "compras.fecha_compra, " +
                                        "compras.prov_compra, " +
                                        "valor_venta.precio_venta " +
                                        "FROM compras INNER JOIN valor_venta ON valor_venta.id_venta = compras.id_compra;";

            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;
            


            //inicializando textbox con ids para ingresar datos
            tb_ing_tipo_id.Enabled = false;
            tb_ing_id_prov.Enabled = false;
            tb_ing_id_comp.Enabled = false;

            //tomando el maximo id de tipo producto
            MySqlCommand comidpro = new MySqlCommand();
            comidpro.Connection = conexionbd;   
            comidpro.CommandText = "SELECT MAX(id_tipo_producto) FROM tipo_productos;";
            object res_id_prod = comidpro.ExecuteScalar();
            int maxIdprod = res_id_prod != DBNull.Value ? Convert.ToInt32(res_id_prod) :0;
            maxIdprod++;    
            tb_ing_tipo_id.Text = maxIdprod.ToString();

            //tomando el maximo id de proveedor
            MySqlCommand comidprov = new MySqlCommand();
            comidprov.Connection = conexionbd;
            comidprov.CommandText = "SELECT MAX(id_proveedor) FROM proveedores;";
            object res_id_prov = comidprov.ExecuteScalar();
            int maxIdProv = res_id_prov != DBNull.Value ? Convert.ToInt32(res_id_prov) : 0;
            maxIdProv++;
            tb_ing_id_prov.Text = maxIdProv.ToString();

            //tomando el maximo id de compra
            MySqlCommand comidcomp = new MySqlCommand();
            comidcomp.Connection = conexionbd;
            comidcomp.CommandText = "SELECT MAX(id_compra) FROM compras;";
            object res_id_comp = comidcomp.ExecuteScalar();
            int maxIdComp = res_id_comp != DBNull.Value ? Convert.ToInt32(res_id_comp) : 0;
            maxIdComp++;
            tb_ing_id_comp.Text = maxIdComp.ToString();


            // Cargar proveedores en el ComboBox
            MySqlCommand comandoProveedores = new MySqlCommand("SELECT nom_proveedor FROM proveedores", conexionbd);
            MySqlDataReader readerProveedores = comandoProveedores.ExecuteReader();
            while (readerProveedores.Read())
            {
                cb_ing_prov_comp.Items.Add(readerProveedores["nom_proveedor"].ToString());
            }
            readerProveedores.Close();

            // Cargar tipos de productos en el ComboBox
            MySqlCommand comandoTipos = new MySqlCommand("SELECT nom_tipo_producto FROM tipo_productos", conexionbd);
            MySqlDataReader readerTipos = comandoTipos.ExecuteReader();
            while (readerTipos.Read())
            {
                cb_ing_tipo_comp.Items.Add(readerTipos["nom_tipo_producto"].ToString());
            }
            readerTipos.Close();

            conexionbd.Close();
        }

        // Evento para buscar en el DataGridView de consultar
        private void tBBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = tBBuscar.Text.Trim();

            using (MySqlConnection conexionbd = Clases.conexion.establecerConexion())
            {
                conexionbd.Open();
                string consulta = "SELECT * FROM compras WHERE nom_compra LIKE @busqueda";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexionbd))
                {
                    comando.Parameters.AddWithValue("@busqueda", "%" + textoBusqueda + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
            }
        }

        // Evento para agregar un nuevo proveedor
        private void btn_ing_prov_Click(object sender, EventArgs e)
        {
            string nombreProveedor = tb_ing_nom_prov.Text.Trim();
            string telefonoProveedor = tb_ing_tel_prov.Text.Trim();
            string direccionProveedor = tb_ing_ubi_prov.Text.Trim();
            string descripcionProveedor = tb_ing_desc_prov.Text.Trim();
            if (string.IsNullOrEmpty(nombreProveedor) || string.IsNullOrEmpty(telefonoProveedor) || string.IsNullOrEmpty(direccionProveedor))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            else
            {
                using (MySqlConnection conexionbd = Clases.conexion.establecerConexion())
                {
                    conexionbd.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO proveedores (id_proveedor, nom_proveedor, tel_proveedor, ubi_proveedor, des_proveedor) VALUES (@id, @nombre, @telefono, @direccion, @descripcion)", conexionbd);
                    comando.Parameters.AddWithValue("@id", tb_ing_id_prov.Text);
                    comando.Parameters.AddWithValue("@nombre", nombreProveedor);
                    comando.Parameters.AddWithValue("@telefono", telefonoProveedor);
                    comando.Parameters.AddWithValue("@direccion", direccionProveedor);
                    comando.Parameters.AddWithValue("@descripcion", descripcionProveedor);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Proveedor agregado exitosamente.");
                        tb_ing_nom_prov.Clear();
                        tb_ing_tel_prov.Clear();
                        tb_ing_ubi_prov.Clear();
                        tb_ing_desc_prov.Clear();
                        int id_prov = Convert.ToInt32(tb_ing_id_prov.Text);
                        id_prov++;
                        tb_ing_id_prov.Text = id_prov.ToString();   
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el proveedor: " + ex.Message);
                    }
                }
            }

        }

        // Evento para agregar un nuevo tipo de producto
        private void btn_ing_tipo_prod_Click(object sender, EventArgs e)
        {
            string nombreTipo = tb_ing_tipo_nombre.Text.Trim();
            if (string.IsNullOrEmpty(nombreTipo))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el tipo de producto.");
                return;
            }
            else
            {

                using (MySqlConnection conexionbd = Clases.conexion.establecerConexion())
                {
                    conexionbd.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO tipo_productos (id_tipo_producto, nom_tipo_producto) VALUES (@id, @nombre)", conexionbd);
                    comando.Parameters.AddWithValue("@id", tb_ing_tipo_id.Text);
                    comando.Parameters.AddWithValue("@nombre", nombreTipo);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Tipo de producto agregado exitosamente.");
                        tb_ing_tipo_nombre.Clear();
                        int id_tipo = Convert.ToInt32(tb_ing_tipo_id.Text);
                        id_tipo++;
                        tb_ing_tipo_id.Text = id_tipo.ToString();   

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el tipo de producto: " + ex.Message);
                    }
                }
            }
        }

        // Evento para agregar una nueva compra-venta
        private void btn_ing_compra_Click(object sender, EventArgs e)
        {
            string nombreCompra = tb_ing_nom_comp.Text.Trim();
            string precioCompra = tb_ing_prec_comp.Text.Trim();
            string tipoProducto = cb_ing_tipo_comp.Text.Trim();
            string fechaCompra = dtp_ing_fecha_comp.Value.ToString("yyyy-MM-dd");
            string proveedorCompra = cb_ing_prov_comp.Text.Trim();
            string precioventa = tb_ing_prec_venta.Text.Trim();
            if (string.IsNullOrEmpty(nombreCompra) || string.IsNullOrEmpty(precioCompra) || string.IsNullOrEmpty(tipoProducto) || string.IsNullOrEmpty(proveedorCompra))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            else
            {
                using (MySqlConnection conexionbd = Clases.conexion.establecerConexion())
                {
                    conexionbd.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO compras (id_compra, nom_compra, precio_compra, nom_tipo_prod, fecha_compra, prov_compra) VALUES (@id, @nombre, @precio, @tipo, @fecha, @proveedor)", conexionbd);
                    MySqlCommand comandoValorVenta = new MySqlCommand("INSERT INTO valor_venta (id_venta, nom_item_venta, precio_venta) VALUES (@id, @nombre, @precioventa)", conexionbd);

                    // Parámetros para compras
                    comando.Parameters.AddWithValue("@id", tb_ing_id_comp.Text);
                    comando.Parameters.AddWithValue("@nombre", nombreCompra);
                    comando.Parameters.AddWithValue("@precio", precioCompra);
                    comando.Parameters.AddWithValue("@tipo", tipoProducto);
                    comando.Parameters.AddWithValue("@fecha", fechaCompra);
                    comando.Parameters.AddWithValue("@proveedor", proveedorCompra);

                    // Parámetros para valor_venta
                    comandoValorVenta.Parameters.AddWithValue("@id", tb_ing_id_comp.Text);
                    comandoValorVenta.Parameters.AddWithValue("@nombre", nombreCompra);
                    comandoValorVenta.Parameters.AddWithValue("@precioventa", precioventa);

                    try
                    {
                        comando.ExecuteNonQuery();
                        comandoValorVenta.ExecuteNonQuery();    
                        MessageBox.Show("Compra agregada exitosamente.");
                        tb_ing_nom_comp.Clear();
                        tb_ing_prec_comp.Clear();
                        tb_ing_prec_venta.Clear();
                        cb_ing_tipo_comp.SelectedIndex = -1;
                        cb_ing_prov_comp.SelectedIndex = -1;
                        int id_comp = Convert.ToInt32(tb_ing_id_comp.Text);
                        id_comp++;
                        tb_ing_id_comp.Text = id_comp.ToString();   
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar la compra: " + ex.Message);
                    }
                }
            }

        }

        // Evento para actualizar el DataGridView al precionar el botón de actualizar
        private void btn_cons_actualizar_Click(object sender, EventArgs e)
        {
            if (tab_inventario.SelectedTab == tab_inv_consultar)
            {
                using (MySqlConnection conexionbd = Clases.conexion.establecerConexion())
                {
                    conexionbd.Open();
                    MySqlCommand comando = new MySqlCommand("SELECT compras.id_compra, " +
                                                            "compras.nom_compra, " +
                                                            "compras.precio_compra, " +
                                                            "compras.nom_tipo_prod, " +
                                                            "compras.fecha_compra, " +
                                                            "compras.prov_compra, " +
                                                            "valor_venta.precio_venta " +
                                                            "FROM compras INNER JOIN valor_venta ON valor_venta.id_venta = compras.id_compra;", conexionbd);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
            }
        }

        // Evento para validar la entrada de texto en el campo de precio de compra
        private void tb_ing_prec_comp_KeyPress(object sender, KeyPressEventArgs e)

    
        {
            // Permite solo números y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
