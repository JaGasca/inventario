namespace app_inventario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_inventario = new System.Windows.Forms.TabControl();
            this.tab_inv_consultar = new System.Windows.Forms.TabPage();
            this.btn_cons_actualizar = new System.Windows.Forms.Button();
            this.tBBuscar = new System.Windows.Forms.TextBox();
            this.lb_consultar_buscar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_inv_ingresar = new System.Windows.Forms.TabPage();
            this.tab_ingresar = new System.Windows.Forms.TabControl();
            this.tab_ing_compra = new System.Windows.Forms.TabPage();
            this.btn_ing_compra = new System.Windows.Forms.Button();
            this.lb_ing_prec_venta = new System.Windows.Forms.Label();
            this.tb_ing_prec_venta = new System.Windows.Forms.TextBox();
            this.lab_ing_prec_comp = new System.Windows.Forms.Label();
            this.tb_ing_prec_comp = new System.Windows.Forms.TextBox();
            this.lb_ing_fecha_comp = new System.Windows.Forms.Label();
            this.dtp_ing_fecha_comp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ing_prov_comp = new System.Windows.Forms.ComboBox();
            this.cb_ing_tipo_comp = new System.Windows.Forms.ComboBox();
            this.tb_ing_nom_comp = new System.Windows.Forms.TextBox();
            this.tb_ing_id_comp = new System.Windows.Forms.TextBox();
            this.lb_ing_tipo_comp = new System.Windows.Forms.Label();
            this.lb_ing_nom_comp = new System.Windows.Forms.Label();
            this.lb_ing_comp = new System.Windows.Forms.Label();
            this.tab_ing_proveedor = new System.Windows.Forms.TabPage();
            this.btn_ing_prov = new System.Windows.Forms.Button();
            this.tb_ing_desc_prov = new System.Windows.Forms.TextBox();
            this.tb_ing_ubi_prov = new System.Windows.Forms.TextBox();
            this.tb_ing_tel_prov = new System.Windows.Forms.TextBox();
            this.tb_ing_nom_prov = new System.Windows.Forms.TextBox();
            this.tb_ing_id_prov = new System.Windows.Forms.TextBox();
            this.lb_ing_ubi_prov = new System.Windows.Forms.Label();
            this.lb_ing_desc_prov = new System.Windows.Forms.Label();
            this.lb_ing_tel_prov = new System.Windows.Forms.Label();
            this.lb_ing_nom_prov = new System.Windows.Forms.Label();
            this.lb_ing_id_prov = new System.Windows.Forms.Label();
            this.tab_ing_tipo_prod = new System.Windows.Forms.TabPage();
            this.btn_ing_tipo_prod = new System.Windows.Forms.Button();
            this.tb_ing_tipo_nombre = new System.Windows.Forms.TextBox();
            this.tb_ing_tipo_id = new System.Windows.Forms.TextBox();
            this.lb_ing_tipo_prod = new System.Windows.Forms.Label();
            this.lb_ing_prod_id = new System.Windows.Forms.Label();
            this.tab_inv_modificar = new System.Windows.Forms.TabPage();
            this.tab_inv_eliminar = new System.Windows.Forms.TabPage();
            this.lb_titulo_inventario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_inventario.SuspendLayout();
            this.tab_inv_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_inv_ingresar.SuspendLayout();
            this.tab_ingresar.SuspendLayout();
            this.tab_ing_compra.SuspendLayout();
            this.tab_ing_proveedor.SuspendLayout();
            this.tab_ing_tipo_prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_inventario
            // 
            this.tab_inventario.Controls.Add(this.tab_inv_consultar);
            this.tab_inventario.Controls.Add(this.tab_inv_ingresar);
            this.tab_inventario.Controls.Add(this.tab_inv_modificar);
            this.tab_inventario.Controls.Add(this.tab_inv_eliminar);
            this.tab_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_inventario.ItemSize = new System.Drawing.Size(50, 30);
            this.tab_inventario.Location = new System.Drawing.Point(26, 172);
            this.tab_inventario.Name = "tab_inventario";
            this.tab_inventario.Padding = new System.Drawing.Point(10, 3);
            this.tab_inventario.SelectedIndex = 0;
            this.tab_inventario.Size = new System.Drawing.Size(1226, 553);
            this.tab_inventario.TabIndex = 0;
            // 
            // tab_inv_consultar
            // 
            this.tab_inv_consultar.Controls.Add(this.btn_cons_actualizar);
            this.tab_inv_consultar.Controls.Add(this.tBBuscar);
            this.tab_inv_consultar.Controls.Add(this.lb_consultar_buscar);
            this.tab_inv_consultar.Controls.Add(this.dataGridView1);
            this.tab_inv_consultar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_inv_consultar.Location = new System.Drawing.Point(4, 34);
            this.tab_inv_consultar.Name = "tab_inv_consultar";
            this.tab_inv_consultar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inv_consultar.Size = new System.Drawing.Size(1218, 515);
            this.tab_inv_consultar.TabIndex = 0;
            this.tab_inv_consultar.Text = "CONSULTAR";
            this.tab_inv_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_cons_actualizar
            // 
            this.btn_cons_actualizar.Location = new System.Drawing.Point(523, 31);
            this.btn_cons_actualizar.Name = "btn_cons_actualizar";
            this.btn_cons_actualizar.Size = new System.Drawing.Size(145, 23);
            this.btn_cons_actualizar.TabIndex = 3;
            this.btn_cons_actualizar.Text = "ACTUALIZAR TABLA";
            this.btn_cons_actualizar.UseVisualStyleBackColor = true;
            this.btn_cons_actualizar.Click += new System.EventHandler(this.btn_cons_actualizar_Click);
            // 
            // tBBuscar
            // 
            this.tBBuscar.Location = new System.Drawing.Point(156, 31);
            this.tBBuscar.Name = "tBBuscar";
            this.tBBuscar.Size = new System.Drawing.Size(317, 23);
            this.tBBuscar.TabIndex = 2;
            this.tBBuscar.TextChanged += new System.EventHandler(this.tBBuscar_TextChanged);
            // 
            // lb_consultar_buscar
            // 
            this.lb_consultar_buscar.AutoSize = true;
            this.lb_consultar_buscar.Location = new System.Drawing.Point(94, 34);
            this.lb_consultar_buscar.Name = "lb_consultar_buscar";
            this.lb_consultar_buscar.Size = new System.Drawing.Size(58, 16);
            this.lb_consultar_buscar.TabIndex = 1;
            this.lb_consultar_buscar.Text = "BUSCAR : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(977, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // tab_inv_ingresar
            // 
            this.tab_inv_ingresar.Controls.Add(this.tab_ingresar);
            this.tab_inv_ingresar.Location = new System.Drawing.Point(4, 34);
            this.tab_inv_ingresar.Name = "tab_inv_ingresar";
            this.tab_inv_ingresar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inv_ingresar.Size = new System.Drawing.Size(1218, 515);
            this.tab_inv_ingresar.TabIndex = 1;
            this.tab_inv_ingresar.Text = "INGRESAR";
            this.tab_inv_ingresar.UseVisualStyleBackColor = true;
            // 
            // tab_ingresar
            // 
            this.tab_ingresar.Controls.Add(this.tab_ing_compra);
            this.tab_ingresar.Controls.Add(this.tab_ing_proveedor);
            this.tab_ingresar.Controls.Add(this.tab_ing_tipo_prod);
            this.tab_ingresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_ingresar.Location = new System.Drawing.Point(28, 22);
            this.tab_ingresar.Name = "tab_ingresar";
            this.tab_ingresar.Padding = new System.Drawing.Point(8, 6);
            this.tab_ingresar.SelectedIndex = 0;
            this.tab_ingresar.Size = new System.Drawing.Size(964, 409);
            this.tab_ingresar.TabIndex = 0;
            // 
            // tab_ing_compra
            // 
            this.tab_ing_compra.Controls.Add(this.btn_ing_compra);
            this.tab_ing_compra.Controls.Add(this.lb_ing_prec_venta);
            this.tab_ing_compra.Controls.Add(this.tb_ing_prec_venta);
            this.tab_ing_compra.Controls.Add(this.lab_ing_prec_comp);
            this.tab_ing_compra.Controls.Add(this.tb_ing_prec_comp);
            this.tab_ing_compra.Controls.Add(this.lb_ing_fecha_comp);
            this.tab_ing_compra.Controls.Add(this.dtp_ing_fecha_comp);
            this.tab_ing_compra.Controls.Add(this.label1);
            this.tab_ing_compra.Controls.Add(this.cb_ing_prov_comp);
            this.tab_ing_compra.Controls.Add(this.cb_ing_tipo_comp);
            this.tab_ing_compra.Controls.Add(this.tb_ing_nom_comp);
            this.tab_ing_compra.Controls.Add(this.tb_ing_id_comp);
            this.tab_ing_compra.Controls.Add(this.lb_ing_tipo_comp);
            this.tab_ing_compra.Controls.Add(this.lb_ing_nom_comp);
            this.tab_ing_compra.Controls.Add(this.lb_ing_comp);
            this.tab_ing_compra.Location = new System.Drawing.Point(4, 29);
            this.tab_ing_compra.Name = "tab_ing_compra";
            this.tab_ing_compra.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ing_compra.Size = new System.Drawing.Size(956, 376);
            this.tab_ing_compra.TabIndex = 0;
            this.tab_ing_compra.Text = "INGRESAR COMPRA";
            this.tab_ing_compra.UseVisualStyleBackColor = true;
            // 
            // btn_ing_compra
            // 
            this.btn_ing_compra.Location = new System.Drawing.Point(115, 295);
            this.btn_ing_compra.Name = "btn_ing_compra";
            this.btn_ing_compra.Size = new System.Drawing.Size(152, 32);
            this.btn_ing_compra.TabIndex = 16;
            this.btn_ing_compra.Text = "INGRESAR COMPRA";
            this.btn_ing_compra.UseVisualStyleBackColor = true;
            this.btn_ing_compra.Click += new System.EventHandler(this.btn_ing_compra_Click);
            // 
            // lb_ing_prec_venta
            // 
            this.lb_ing_prec_venta.AutoSize = true;
            this.lb_ing_prec_venta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ing_prec_venta.Location = new System.Drawing.Point(17, 145);
            this.lb_ing_prec_venta.Name = "lb_ing_prec_venta";
            this.lb_ing_prec_venta.Size = new System.Drawing.Size(107, 14);
            this.lb_ing_prec_venta.TabIndex = 15;
            this.lb_ing_prec_venta.Text = "PRECIO VENTA :";
            // 
            // tb_ing_prec_venta
            // 
            this.tb_ing_prec_venta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ing_prec_venta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ing_prec_venta.Location = new System.Drawing.Point(130, 142);
            this.tb_ing_prec_venta.MaxLength = 10;
            this.tb_ing_prec_venta.Name = "tb_ing_prec_venta";
            this.tb_ing_prec_venta.Size = new System.Drawing.Size(132, 21);
            this.tb_ing_prec_venta.TabIndex = 14;
            this.tb_ing_prec_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ing_prec_comp_KeyPress);
            // 
            // lab_ing_prec_comp
            // 
            this.lab_ing_prec_comp.AutoSize = true;
            this.lab_ing_prec_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ing_prec_comp.Location = new System.Drawing.Point(7, 109);
            this.lab_ing_prec_comp.Name = "lab_ing_prec_comp";
            this.lab_ing_prec_comp.Size = new System.Drawing.Size(120, 14);
            this.lab_ing_prec_comp.TabIndex = 13;
            this.lab_ing_prec_comp.Text = "PRECIO COMPRA :";
            // 
            // tb_ing_prec_comp
            // 
            this.tb_ing_prec_comp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ing_prec_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ing_prec_comp.Location = new System.Drawing.Point(129, 106);
            this.tb_ing_prec_comp.MaxLength = 10;
            this.tb_ing_prec_comp.Name = "tb_ing_prec_comp";
            this.tb_ing_prec_comp.Size = new System.Drawing.Size(132, 21);
            this.tb_ing_prec_comp.TabIndex = 12;
            this.tb_ing_prec_comp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ing_prec_comp_KeyPress);
            // 
            // lb_ing_fecha_comp
            // 
            this.lb_ing_fecha_comp.AutoSize = true;
            this.lb_ing_fecha_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ing_fecha_comp.Location = new System.Drawing.Point(65, 221);
            this.lb_ing_fecha_comp.Name = "lb_ing_fecha_comp";
            this.lb_ing_fecha_comp.Size = new System.Drawing.Size(56, 14);
            this.lb_ing_fecha_comp.TabIndex = 11;
            this.lb_ing_fecha_comp.Text = "FECHA :";
            // 
            // dtp_ing_fecha_comp
            // 
            this.dtp_ing_fecha_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ing_fecha_comp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ing_fecha_comp.Location = new System.Drawing.Point(127, 216);
            this.dtp_ing_fecha_comp.Name = "dtp_ing_fecha_comp";
            this.dtp_ing_fecha_comp.Size = new System.Drawing.Size(134, 21);
            this.dtp_ing_fecha_comp.TabIndex = 10;
            this.dtp_ing_fecha_comp.Value = new System.DateTime(2025, 8, 11, 17, 8, 9, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "PROVEEDOR :";
            // 
            // cb_ing_prov_comp
            // 
            this.cb_ing_prov_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ing_prov_comp.FormattingEnabled = true;
            this.cb_ing_prov_comp.Location = new System.Drawing.Point(127, 251);
            this.cb_ing_prov_comp.Name = "cb_ing_prov_comp";
            this.cb_ing_prov_comp.Size = new System.Drawing.Size(186, 22);
            this.cb_ing_prov_comp.TabIndex = 8;
            // 
            // cb_ing_tipo_comp
            // 
            this.cb_ing_tipo_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ing_tipo_comp.FormattingEnabled = true;
            this.cb_ing_tipo_comp.Location = new System.Drawing.Point(129, 181);
            this.cb_ing_tipo_comp.Name = "cb_ing_tipo_comp";
            this.cb_ing_tipo_comp.Size = new System.Drawing.Size(152, 22);
            this.cb_ing_tipo_comp.TabIndex = 7;
            // 
            // tb_ing_nom_comp
            // 
            this.tb_ing_nom_comp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ing_nom_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ing_nom_comp.Location = new System.Drawing.Point(129, 69);
            this.tb_ing_nom_comp.MaxLength = 50;
            this.tb_ing_nom_comp.Name = "tb_ing_nom_comp";
            this.tb_ing_nom_comp.Size = new System.Drawing.Size(186, 21);
            this.tb_ing_nom_comp.TabIndex = 4;
            // 
            // tb_ing_id_comp
            // 
            this.tb_ing_id_comp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ing_id_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ing_id_comp.Location = new System.Drawing.Point(130, 34);
            this.tb_ing_id_comp.Name = "tb_ing_id_comp";
            this.tb_ing_id_comp.Size = new System.Drawing.Size(100, 21);
            this.tb_ing_id_comp.TabIndex = 3;
            // 
            // lb_ing_tipo_comp
            // 
            this.lb_ing_tipo_comp.AutoSize = true;
            this.lb_ing_tipo_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ing_tipo_comp.Location = new System.Drawing.Point(21, 184);
            this.lb_ing_tipo_comp.Name = "lb_ing_tipo_comp";
            this.lb_ing_tipo_comp.Size = new System.Drawing.Size(102, 14);
            this.lb_ing_tipo_comp.TabIndex = 2;
            this.lb_ing_tipo_comp.Text = "TIPO COMPRA :";
            // 
            // lb_ing_nom_comp
            // 
            this.lb_ing_nom_comp.AutoSize = true;
            this.lb_ing_nom_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ing_nom_comp.Location = new System.Drawing.Point(0, 72);
            this.lb_ing_nom_comp.Name = "lb_ing_nom_comp";
            this.lb_ing_nom_comp.Size = new System.Drawing.Size(127, 14);
            this.lb_ing_nom_comp.TabIndex = 1;
            this.lb_ing_nom_comp.Text = "NOMBRE COMPRA :";
            // 
            // lb_ing_comp
            // 
            this.lb_ing_comp.AutoSize = true;
            this.lb_ing_comp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ing_comp.Location = new System.Drawing.Point(97, 37);
            this.lb_ing_comp.Name = "lb_ing_comp";
            this.lb_ing_comp.Size = new System.Drawing.Size(27, 14);
            this.lb_ing_comp.TabIndex = 0;
            this.lb_ing_comp.Text = "ID :";
            // 
            // tab_ing_proveedor
            // 
            this.tab_ing_proveedor.Controls.Add(this.btn_ing_prov);
            this.tab_ing_proveedor.Controls.Add(this.tb_ing_desc_prov);
            this.tab_ing_proveedor.Controls.Add(this.tb_ing_ubi_prov);
            this.tab_ing_proveedor.Controls.Add(this.tb_ing_tel_prov);
            this.tab_ing_proveedor.Controls.Add(this.tb_ing_nom_prov);
            this.tab_ing_proveedor.Controls.Add(this.tb_ing_id_prov);
            this.tab_ing_proveedor.Controls.Add(this.lb_ing_ubi_prov);
            this.tab_ing_proveedor.Controls.Add(this.lb_ing_desc_prov);
            this.tab_ing_proveedor.Controls.Add(this.lb_ing_tel_prov);
            this.tab_ing_proveedor.Controls.Add(this.lb_ing_nom_prov);
            this.tab_ing_proveedor.Controls.Add(this.lb_ing_id_prov);
            this.tab_ing_proveedor.Location = new System.Drawing.Point(4, 29);
            this.tab_ing_proveedor.Name = "tab_ing_proveedor";
            this.tab_ing_proveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ing_proveedor.Size = new System.Drawing.Size(956, 376);
            this.tab_ing_proveedor.TabIndex = 1;
            this.tab_ing_proveedor.Text = "INGRESAR PROVEEDOR";
            this.tab_ing_proveedor.UseVisualStyleBackColor = true;
            // 
            // btn_ing_prov
            // 
            this.btn_ing_prov.Location = new System.Drawing.Point(168, 230);
            this.btn_ing_prov.Name = "btn_ing_prov";
            this.btn_ing_prov.Size = new System.Drawing.Size(138, 37);
            this.btn_ing_prov.TabIndex = 10;
            this.btn_ing_prov.Text = "INGRESAR NUEVO PROVEEDOR";
            this.btn_ing_prov.UseVisualStyleBackColor = true;
            this.btn_ing_prov.Click += new System.EventHandler(this.btn_ing_prov_Click);
            // 
            // tb_ing_desc_prov
            // 
            this.tb_ing_desc_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ing_desc_prov.Location = new System.Drawing.Point(188, 173);
            this.tb_ing_desc_prov.MaxLength = 100;
            this.tb_ing_desc_prov.Multiline = true;
            this.tb_ing_desc_prov.Name = "tb_ing_desc_prov";
            this.tb_ing_desc_prov.Size = new System.Drawing.Size(246, 35);
            this.tb_ing_desc_prov.TabIndex = 9;
            // 
            // tb_ing_ubi_prov
            // 
            this.tb_ing_ubi_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ing_ubi_prov.Location = new System.Drawing.Point(188, 137);
            this.tb_ing_ubi_prov.MaxLength = 80;
            this.tb_ing_ubi_prov.Name = "tb_ing_ubi_prov";
            this.tb_ing_ubi_prov.Size = new System.Drawing.Size(246, 21);
            this.tb_ing_ubi_prov.TabIndex = 8;
            // 
            // tb_ing_tel_prov
            // 
            this.tb_ing_tel_prov.Location = new System.Drawing.Point(188, 100);
            this.tb_ing_tel_prov.MaxLength = 12;
            this.tb_ing_tel_prov.Name = "tb_ing_tel_prov";
            this.tb_ing_tel_prov.Size = new System.Drawing.Size(100, 21);
            this.tb_ing_tel_prov.TabIndex = 7;
            // 
            // tb_ing_nom_prov
            // 
            this.tb_ing_nom_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ing_nom_prov.Location = new System.Drawing.Point(188, 65);
            this.tb_ing_nom_prov.MaxLength = 60;
            this.tb_ing_nom_prov.Name = "tb_ing_nom_prov";
            this.tb_ing_nom_prov.Size = new System.Drawing.Size(246, 21);
            this.tb_ing_nom_prov.TabIndex = 6;
            // 
            // tb_ing_id_prov
            // 
            this.tb_ing_id_prov.Location = new System.Drawing.Point(188, 30);
            this.tb_ing_id_prov.Name = "tb_ing_id_prov";
            this.tb_ing_id_prov.Size = new System.Drawing.Size(100, 21);
            this.tb_ing_id_prov.TabIndex = 5;
            // 
            // lb_ing_ubi_prov
            // 
            this.lb_ing_ubi_prov.AutoSize = true;
            this.lb_ing_ubi_prov.Location = new System.Drawing.Point(19, 140);
            this.lb_ing_ubi_prov.Name = "lb_ing_ubi_prov";
            this.lb_ing_ubi_prov.Size = new System.Drawing.Size(167, 14);
            this.lb_ing_ubi_prov.TabIndex = 4;
            this.lb_ing_ubi_prov.Text = "DIRECCION PROVEEDOR :";
            // 
            // lb_ing_desc_prov
            // 
            this.lb_ing_desc_prov.AutoSize = true;
            this.lb_ing_desc_prov.Location = new System.Drawing.Point(5, 176);
            this.lb_ing_desc_prov.Name = "lb_ing_desc_prov";
            this.lb_ing_desc_prov.Size = new System.Drawing.Size(183, 14);
            this.lb_ing_desc_prov.TabIndex = 3;
            this.lb_ing_desc_prov.Text = "DESCRIPCION PROVEEDOR :";
            // 
            // lb_ing_tel_prov
            // 
            this.lb_ing_tel_prov.AutoSize = true;
            this.lb_ing_tel_prov.Location = new System.Drawing.Point(21, 103);
            this.lb_ing_tel_prov.Name = "lb_ing_tel_prov";
            this.lb_ing_tel_prov.Size = new System.Drawing.Size(163, 14);
            this.lb_ing_tel_prov.TabIndex = 2;
            this.lb_ing_tel_prov.Text = "TELEFONO PROVEEDOR :";
            // 
            // lb_ing_nom_prov
            // 
            this.lb_ing_nom_prov.AutoSize = true;
            this.lb_ing_nom_prov.Location = new System.Drawing.Point(31, 68);
            this.lb_ing_nom_prov.Name = "lb_ing_nom_prov";
            this.lb_ing_nom_prov.Size = new System.Drawing.Size(151, 14);
            this.lb_ing_nom_prov.TabIndex = 1;
            this.lb_ing_nom_prov.Text = "NOMBRE PROVEEDOR :";
            // 
            // lb_ing_id_prov
            // 
            this.lb_ing_id_prov.AutoSize = true;
            this.lb_ing_id_prov.Location = new System.Drawing.Point(155, 33);
            this.lb_ing_id_prov.Name = "lb_ing_id_prov";
            this.lb_ing_id_prov.Size = new System.Drawing.Size(27, 14);
            this.lb_ing_id_prov.TabIndex = 0;
            this.lb_ing_id_prov.Text = "ID :";
            // 
            // tab_ing_tipo_prod
            // 
            this.tab_ing_tipo_prod.Controls.Add(this.btn_ing_tipo_prod);
            this.tab_ing_tipo_prod.Controls.Add(this.tb_ing_tipo_nombre);
            this.tab_ing_tipo_prod.Controls.Add(this.tb_ing_tipo_id);
            this.tab_ing_tipo_prod.Controls.Add(this.lb_ing_tipo_prod);
            this.tab_ing_tipo_prod.Controls.Add(this.lb_ing_prod_id);
            this.tab_ing_tipo_prod.Location = new System.Drawing.Point(4, 29);
            this.tab_ing_tipo_prod.Name = "tab_ing_tipo_prod";
            this.tab_ing_tipo_prod.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ing_tipo_prod.Size = new System.Drawing.Size(956, 376);
            this.tab_ing_tipo_prod.TabIndex = 2;
            this.tab_ing_tipo_prod.Text = "NUEVO TIPO DE PRODUCTO";
            this.tab_ing_tipo_prod.UseVisualStyleBackColor = true;
            // 
            // btn_ing_tipo_prod
            // 
            this.btn_ing_tipo_prod.Location = new System.Drawing.Point(157, 122);
            this.btn_ing_tipo_prod.Name = "btn_ing_tipo_prod";
            this.btn_ing_tipo_prod.Size = new System.Drawing.Size(164, 36);
            this.btn_ing_tipo_prod.TabIndex = 4;
            this.btn_ing_tipo_prod.Text = "AGREGAR TIPO PRODUCTO";
            this.btn_ing_tipo_prod.UseVisualStyleBackColor = true;
            this.btn_ing_tipo_prod.Click += new System.EventHandler(this.btn_ing_tipo_prod_Click);
            // 
            // tb_ing_tipo_nombre
            // 
            this.tb_ing_tipo_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ing_tipo_nombre.Location = new System.Drawing.Point(157, 76);
            this.tb_ing_tipo_nombre.MaxLength = 30;
            this.tb_ing_tipo_nombre.Name = "tb_ing_tipo_nombre";
            this.tb_ing_tipo_nombre.Size = new System.Drawing.Size(273, 21);
            this.tb_ing_tipo_nombre.TabIndex = 3;
            // 
            // tb_ing_tipo_id
            // 
            this.tb_ing_tipo_id.Location = new System.Drawing.Point(157, 38);
            this.tb_ing_tipo_id.Name = "tb_ing_tipo_id";
            this.tb_ing_tipo_id.Size = new System.Drawing.Size(100, 21);
            this.tb_ing_tipo_id.TabIndex = 2;
            // 
            // lb_ing_tipo_prod
            // 
            this.lb_ing_tipo_prod.AutoSize = true;
            this.lb_ing_tipo_prod.Location = new System.Drawing.Point(9, 76);
            this.lb_ing_tipo_prod.Name = "lb_ing_tipo_prod";
            this.lb_ing_tipo_prod.Size = new System.Drawing.Size(142, 14);
            this.lb_ing_tipo_prod.TabIndex = 1;
            this.lb_ing_tipo_prod.Text = "TIPO DE PRODUCTO  :";
            // 
            // lb_ing_prod_id
            // 
            this.lb_ing_prod_id.AutoSize = true;
            this.lb_ing_prod_id.Location = new System.Drawing.Point(108, 41);
            this.lb_ing_prod_id.Name = "lb_ing_prod_id";
            this.lb_ing_prod_id.Size = new System.Drawing.Size(27, 14);
            this.lb_ing_prod_id.TabIndex = 0;
            this.lb_ing_prod_id.Text = "ID :";
            // 
            // tab_inv_modificar
            // 
            this.tab_inv_modificar.Location = new System.Drawing.Point(4, 34);
            this.tab_inv_modificar.Name = "tab_inv_modificar";
            this.tab_inv_modificar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inv_modificar.Size = new System.Drawing.Size(1218, 515);
            this.tab_inv_modificar.TabIndex = 2;
            this.tab_inv_modificar.Text = "MODIFICAR";
            this.tab_inv_modificar.UseVisualStyleBackColor = true;
            // 
            // tab_inv_eliminar
            // 
            this.tab_inv_eliminar.Location = new System.Drawing.Point(4, 34);
            this.tab_inv_eliminar.Name = "tab_inv_eliminar";
            this.tab_inv_eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inv_eliminar.Size = new System.Drawing.Size(1218, 515);
            this.tab_inv_eliminar.TabIndex = 3;
            this.tab_inv_eliminar.Text = "ELIMINAR";
            this.tab_inv_eliminar.UseVisualStyleBackColor = true;
            // 
            // lb_titulo_inventario
            // 
            this.lb_titulo_inventario.AutoSize = true;
            this.lb_titulo_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo_inventario.Location = new System.Drawing.Point(37, 128);
            this.lb_titulo_inventario.Name = "lb_titulo_inventario";
            this.lb_titulo_inventario.Size = new System.Drawing.Size(165, 28);
            this.lb_titulo_inventario.TabIndex = 1;
            this.lb_titulo_inventario.Text = "INVENTARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_titulo_inventario);
            this.Controls.Add(this.tab_inventario);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tab_inventario.ResumeLayout(false);
            this.tab_inv_consultar.ResumeLayout(false);
            this.tab_inv_consultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_inv_ingresar.ResumeLayout(false);
            this.tab_ingresar.ResumeLayout(false);
            this.tab_ing_compra.ResumeLayout(false);
            this.tab_ing_compra.PerformLayout();
            this.tab_ing_proveedor.ResumeLayout(false);
            this.tab_ing_proveedor.PerformLayout();
            this.tab_ing_tipo_prod.ResumeLayout(false);
            this.tab_ing_tipo_prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_inventario;
        private System.Windows.Forms.TabPage tab_inv_consultar;
        private System.Windows.Forms.TabPage tab_inv_ingresar;
        private System.Windows.Forms.TabPage tab_inv_modificar;
        private System.Windows.Forms.TabPage tab_inv_eliminar;
        private System.Windows.Forms.Label lb_titulo_inventario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBBuscar;
        private System.Windows.Forms.Label lb_consultar_buscar;
        private System.Windows.Forms.TabControl tab_ingresar;
        private System.Windows.Forms.TabPage tab_ing_compra;
        private System.Windows.Forms.TabPage tab_ing_proveedor;
        private System.Windows.Forms.TabPage tab_ing_tipo_prod;
        private System.Windows.Forms.Label lb_ing_tipo_prod;
        private System.Windows.Forms.Label lb_ing_prod_id;
        private System.Windows.Forms.TextBox tb_ing_tipo_id;
        private System.Windows.Forms.TextBox tb_ing_tipo_nombre;
        private System.Windows.Forms.Button btn_ing_tipo_prod;
        private System.Windows.Forms.Label lb_ing_tel_prov;
        private System.Windows.Forms.Label lb_ing_nom_prov;
        private System.Windows.Forms.Label lb_ing_id_prov;
        private System.Windows.Forms.Label lb_ing_desc_prov;
        private System.Windows.Forms.Label lb_ing_ubi_prov;
        private System.Windows.Forms.TextBox tb_ing_tel_prov;
        private System.Windows.Forms.TextBox tb_ing_nom_prov;
        private System.Windows.Forms.TextBox tb_ing_id_prov;
        private System.Windows.Forms.TextBox tb_ing_desc_prov;
        private System.Windows.Forms.TextBox tb_ing_ubi_prov;
        private System.Windows.Forms.Button btn_ing_prov;
        private System.Windows.Forms.Label lb_ing_tipo_comp;
        private System.Windows.Forms.Label lb_ing_nom_comp;
        private System.Windows.Forms.Label lb_ing_comp;
        private System.Windows.Forms.TextBox tb_ing_nom_comp;
        private System.Windows.Forms.TextBox tb_ing_id_comp;
        private System.Windows.Forms.ComboBox cb_ing_prov_comp;
        private System.Windows.Forms.ComboBox cb_ing_tipo_comp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ing_fecha_comp;
        private System.Windows.Forms.Label lb_ing_fecha_comp;
        private System.Windows.Forms.TextBox tb_ing_prec_comp;
        private System.Windows.Forms.Label lb_ing_prec_venta;
        private System.Windows.Forms.TextBox tb_ing_prec_venta;
        private System.Windows.Forms.Label lab_ing_prec_comp;
        private System.Windows.Forms.Button btn_ing_compra;
        private System.Windows.Forms.Button btn_cons_actualizar;
    }
}

