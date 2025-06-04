namespace GUI
{
    partial class agregar_productos
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
            this.panel_agregarproduct = new System.Windows.Forms.Panel();
            this.btn_agregar_product = new System.Windows.Forms.Button();
            this.comboproduct = new System.Windows.Forms.ComboBox();
            this.labelcategoria = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_cantidadproduct = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_precioproduct = new System.Windows.Forms.TextBox();
            this.lbltituloproducto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_nombreproduct = new System.Windows.Forms.TextBox();
            this.DataProductos = new System.Windows.Forms.DataGridView();
            this.Nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_agregarproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_agregarproduct
            // 
            this.panel_agregarproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.panel_agregarproduct.Controls.Add(this.btn_agregar_product);
            this.panel_agregarproduct.Controls.Add(this.comboproduct);
            this.panel_agregarproduct.Controls.Add(this.labelcategoria);
            this.panel_agregarproduct.Controls.Add(this.panel4);
            this.panel_agregarproduct.Controls.Add(this.txt_cantidadproduct);
            this.panel_agregarproduct.Controls.Add(this.panel3);
            this.panel_agregarproduct.Controls.Add(this.txt_precioproduct);
            this.panel_agregarproduct.Controls.Add(this.lbltituloproducto);
            this.panel_agregarproduct.Controls.Add(this.panel2);
            this.panel_agregarproduct.Controls.Add(this.txt_nombreproduct);
            this.panel_agregarproduct.Location = new System.Drawing.Point(3, 38);
            this.panel_agregarproduct.Name = "panel_agregarproduct";
            this.panel_agregarproduct.Size = new System.Drawing.Size(406, 407);
            this.panel_agregarproduct.TabIndex = 0;
            // 
            // btn_agregar_product
            // 
            this.btn_agregar_product.BackColor = System.Drawing.Color.Green;
            this.btn_agregar_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_product.FlatAppearance.BorderSize = 0;
            this.btn_agregar_product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_agregar_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregar_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_product.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_agregar_product.Location = new System.Drawing.Point(53, 342);
            this.btn_agregar_product.Name = "btn_agregar_product";
            this.btn_agregar_product.Size = new System.Drawing.Size(294, 40);
            this.btn_agregar_product.TabIndex = 22;
            this.btn_agregar_product.Text = "AGREGAR PRODUCTO";
            this.btn_agregar_product.UseVisualStyleBackColor = false;
            // 
            // comboproduct
            // 
            this.comboproduct.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboproduct.ForeColor = System.Drawing.Color.White;
            this.comboproduct.FormattingEnabled = true;
            this.comboproduct.Items.AddRange(new object[] {
            "Alimentos y Bebidas"});
            this.comboproduct.Location = new System.Drawing.Point(15, 186);
            this.comboproduct.Name = "comboproduct";
            this.comboproduct.Size = new System.Drawing.Size(388, 21);
            this.comboproduct.TabIndex = 50;
            // 
            // labelcategoria
            // 
            this.labelcategoria.AutoSize = true;
            this.labelcategoria.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategoria.ForeColor = System.Drawing.Color.White;
            this.labelcategoria.Location = new System.Drawing.Point(12, 165);
            this.labelcategoria.Name = "labelcategoria";
            this.labelcategoria.Size = new System.Drawing.Size(220, 18);
            this.labelcategoria.TabIndex = 49;
            this.labelcategoria.Text = "CATEGORIA DEL PRODUCTO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Location = new System.Drawing.Point(15, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 1);
            this.panel4.TabIndex = 47;
            // 
            // txt_cantidadproduct
            // 
            this.txt_cantidadproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_cantidadproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidadproduct.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadproduct.ForeColor = System.Drawing.Color.White;
            this.txt_cantidadproduct.Location = new System.Drawing.Point(15, 286);
            this.txt_cantidadproduct.Name = "txt_cantidadproduct";
            this.txt_cantidadproduct.Size = new System.Drawing.Size(388, 19);
            this.txt_cantidadproduct.TabIndex = 48;
            this.txt_cantidadproduct.Text = "CANTIDAD DEL PRODUCTO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Location = new System.Drawing.Point(15, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 1);
            this.panel3.TabIndex = 45;
            // 
            // txt_precioproduct
            // 
            this.txt_precioproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_precioproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_precioproduct.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioproduct.ForeColor = System.Drawing.Color.White;
            this.txt_precioproduct.Location = new System.Drawing.Point(15, 229);
            this.txt_precioproduct.Name = "txt_precioproduct";
            this.txt_precioproduct.Size = new System.Drawing.Size(388, 19);
            this.txt_precioproduct.TabIndex = 46;
            this.txt_precioproduct.Text = "PRECIO DEL PRODUCTO";
            // 
            // lbltituloproducto
            // 
            this.lbltituloproducto.AutoSize = true;
            this.lbltituloproducto.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloproducto.Font = new System.Drawing.Font("Rockwell", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloproducto.ForeColor = System.Drawing.Color.White;
            this.lbltituloproducto.Location = new System.Drawing.Point(39, 13);
            this.lbltituloproducto.Name = "lbltituloproducto";
            this.lbltituloproducto.Size = new System.Drawing.Size(308, 36);
            this.lbltituloproducto.TabIndex = 44;
            this.lbltituloproducto.Text = "AÑADIR PRODUCTO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(15, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 1);
            this.panel2.TabIndex = 34;
            // 
            // txt_nombreproduct
            // 
            this.txt_nombreproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_nombreproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombreproduct.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreproduct.ForeColor = System.Drawing.Color.White;
            this.txt_nombreproduct.Location = new System.Drawing.Point(15, 109);
            this.txt_nombreproduct.Name = "txt_nombreproduct";
            this.txt_nombreproduct.Size = new System.Drawing.Size(388, 19);
            this.txt_nombreproduct.TabIndex = 35;
            this.txt_nombreproduct.Text = "NOMBRE DEL PRODUCTO";
            // 
            // DataProductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.DataProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.DataProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_producto,
            this.Categoria_producto,
            this.Precio_producto,
            this.Cantidad_producto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataProductos.EnableHeadersVisualStyles = false;
            this.DataProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataProductos.Location = new System.Drawing.Point(415, 38);
            this.DataProductos.Name = "DataProductos";
            this.DataProductos.Size = new System.Drawing.Size(335, 280);
            this.DataProductos.TabIndex = 51;
            // 
            // Nombre_producto
            // 
            this.Nombre_producto.HeaderText = "Nombre";
            this.Nombre_producto.Name = "Nombre_producto";
            // 
            // Categoria_producto
            // 
            this.Categoria_producto.HeaderText = "Categoria";
            this.Categoria_producto.Name = "Categoria_producto";
            // 
            // Precio_producto
            // 
            this.Precio_producto.HeaderText = "Precio";
            this.Precio_producto.Name = "Precio_producto";
            // 
            // Cantidad_producto
            // 
            this.Cantidad_producto.HeaderText = "Stock";
            this.Cantidad_producto.Name = "Cantidad_producto";
            // 
            // agregar_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.DataProductos);
            this.Controls.Add(this.panel_agregarproduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregar_productos";
            this.Opacity = 0.9D;
            this.Text = "agregar_productos";
            this.panel_agregarproduct.ResumeLayout(false);
            this.panel_agregarproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_agregarproduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_nombreproduct;
        private System.Windows.Forms.Label lbltituloproducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_precioproduct;
        private System.Windows.Forms.ComboBox comboproduct;
        private System.Windows.Forms.Label labelcategoria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_cantidadproduct;
        private System.Windows.Forms.Button btn_agregar_product;
        private System.Windows.Forms.DataGridView DataProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_producto;
    }
}