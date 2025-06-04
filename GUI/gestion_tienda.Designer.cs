namespace GUI
{
    partial class gestion_tienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_tienda));
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.btnVenta = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnMaxi = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.menuvertical = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalirTienda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_verproduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnagregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.menuvertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.Gainsboro;
            this.paneltitulo.Controls.Add(this.btnVenta);
            this.paneltitulo.Controls.Add(this.btnMini);
            this.paneltitulo.Controls.Add(this.btnMaxi);
            this.paneltitulo.Controls.Add(this.btnSalir);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1300, 35);
            this.paneltitulo.TabIndex = 34;
            this.paneltitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseMove);
            // 
            // btnVenta
            // 
            this.btnVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.Location = new System.Drawing.Point(1210, 6);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(37, 26);
            this.btnVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVenta.TabIndex = 3;
            this.btnVenta.TabStop = false;
            this.btnVenta.Visible = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(1167, 9);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(37, 20);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 2;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxi.Image")));
            this.btnMaxi.Location = new System.Drawing.Point(1210, 9);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(37, 20);
            this.btnMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaxi.TabIndex = 1;
            this.btnMaxi.TabStop = false;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1253, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 32);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuvertical
            // 
            this.menuvertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuvertical.Controls.Add(this.panel6);
            this.menuvertical.Controls.Add(this.panel5);
            this.menuvertical.Controls.Add(this.panel4);
            this.menuvertical.Controls.Add(this.panel3);
            this.menuvertical.Controls.Add(this.btnSalirTienda);
            this.menuvertical.Controls.Add(this.panel2);
            this.menuvertical.Controls.Add(this.btn_verproduct);
            this.menuvertical.Controls.Add(this.panel1);
            this.menuvertical.Controls.Add(this.btnagregar);
            this.menuvertical.Controls.Add(this.pictureBox1);
            this.menuvertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuvertical.Location = new System.Drawing.Point(0, 35);
            this.menuvertical.Name = "menuvertical";
            this.menuvertical.Size = new System.Drawing.Size(275, 615);
            this.menuvertical.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(264, 361);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 58);
            this.panel6.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(264, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 58);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(264, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 58);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(3, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 58);
            this.panel3.TabIndex = 6;
            // 
            // btnSalirTienda
            // 
            this.btnSalirTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSalirTienda.FlatAppearance.BorderSize = 0;
            this.btnSalirTienda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSalirTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirTienda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirTienda.ForeColor = System.Drawing.Color.White;
            this.btnSalirTienda.Location = new System.Drawing.Point(12, 361);
            this.btnSalirTienda.Name = "btnSalirTienda";
            this.btnSalirTienda.Size = new System.Drawing.Size(254, 58);
            this.btnSalirTienda.TabIndex = 5;
            this.btnSalirTienda.Text = "SALIR DE LA CUENTA";
            this.btnSalirTienda.UseVisualStyleBackColor = false;
            this.btnSalirTienda.Click += new System.EventHandler(this.btnSalirTienda_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 58);
            this.panel2.TabIndex = 4;
            // 
            // btn_verproduct
            // 
            this.btn_verproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_verproduct.FlatAppearance.BorderSize = 0;
            this.btn_verproduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_verproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verproduct.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verproduct.ForeColor = System.Drawing.Color.White;
            this.btn_verproduct.Location = new System.Drawing.Point(9, 257);
            this.btn_verproduct.Name = "btn_verproduct";
            this.btn_verproduct.Size = new System.Drawing.Size(256, 58);
            this.btn_verproduct.TabIndex = 3;
            this.btn_verproduct.Text = "VER PRODUCTOS";
            this.btn_verproduct.UseVisualStyleBackColor = false;
            this.btn_verproduct.Click += new System.EventHandler(this.btn_verproduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 58);
            this.panel1.TabIndex = 2;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(10, 153);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(254, 58);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "AGREGAR PRODUCTOS";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(275, 35);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1025, 615);
            this.panelcontenedor.TabIndex = 36;
            // 
            // gestion_tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.menuvertical);
            this.Controls.Add(this.paneltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion_tienda";
            this.Text = "gestion_tienda";
            this.paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.menuvertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.PictureBox btnVenta;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.PictureBox btnMaxi;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel menuvertical;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalirTienda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_verproduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}