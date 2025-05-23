﻿namespace Mambo_s_Pizza.Vista
{
    partial class frmPerfilRepartidor
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
            this.components = new System.ComponentModel.Container();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.btnVerRseñas = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnMinimizar = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btnDespacharPedido = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembresiaTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 90);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(300, 30);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario: ";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(10, 150);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(300, 30);
            this.lblCalificacion.TabIndex = 7;
            this.lblCalificacion.Text = "Calificación: ";
            this.lblCalificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVerRseñas
            // 
            this.btnVerRseñas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnVerRseñas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerRseñas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRseñas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnVerRseñas.Location = new System.Drawing.Point(10, 220);
            this.btnVerRseñas.Name = "btnVerRseñas";
            this.btnVerRseñas.Size = new System.Drawing.Size(150, 30);
            this.btnVerRseñas.TabIndex = 8;
            this.btnVerRseñas.Text = "Ver reseñas";
            this.btnVerRseñas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.btnVerRseñas, "Click para ver todas las reseñas");
            this.btnVerRseñas.Click += new System.EventHandler(this.btnVerRseñas_Click);
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(10, 180);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(300, 30);
            this.lblFechaRegistro.TabIndex = 9;
            this.lblFechaRegistro.Text = "Fecha Registro: ";
            this.lblFechaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDUI
            // 
            this.lblDUI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(10, 120);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(300, 30);
            this.lblDUI.TabIndex = 10;
            this.lblDUI.Text = "DUI: ";
            this.lblDUI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = global::Mambo_s_Pizza.Properties.Resources.icons8_minimize_20;
            this.btnMinimizar.Location = new System.Drawing.Point(740, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.btnMinimizar, "Minimizar ventana");
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::Mambo_s_Pizza.Properties.Resources.icons8_close_20;
            this.btnCerrar.Location = new System.Drawing.Point(770, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.btnCerrar, "Cerrar ventana");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // btnDespacharPedido
            // 
            this.btnDespacharPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnDespacharPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespacharPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespacharPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnDespacharPedido.Location = new System.Drawing.Point(10, 260);
            this.btnDespacharPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDespacharPedido.Name = "btnDespacharPedido";
            this.btnDespacharPedido.Size = new System.Drawing.Size(150, 30);
            this.btnDespacharPedido.TabIndex = 57;
            this.btnDespacharPedido.Text = "Despachar pedido";
            this.btnDespacharPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.btnDespacharPedido, "Click para despachar el pedido con mayor prioridad");
            this.btnDespacharPedido.Click += new System.EventHandler(this.btnDespacharPedido_Click);
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.barra.Controls.Add(this.btnMinimizar);
            this.barra.Controls.Add(this.btnCerrar);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(800, 30);
            this.barra.TabIndex = 11;
            this.barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barra_MouseMove);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(300, 30);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(10, 60);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(300, 30);
            this.lblCorreo.TabIndex = 13;
            this.lblCorreo.Text = "Correo: ";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.MembresiaTexto,
            this.IdMembresia,
            this.Direccion});
            this.dgvDatos.Location = new System.Drawing.Point(320, 60);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(469, 379);
            this.dgvDatos.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 56;
            this.label1.Text = "Pedidos pendientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdPedido
            // 
            this.IdPedido.HeaderText = "Num. Pedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            // 
            // MembresiaTexto
            // 
            this.MembresiaTexto.HeaderText = "Membresía";
            this.MembresiaTexto.Name = "MembresiaTexto";
            this.MembresiaTexto.ReadOnly = true;
            // 
            // IdMembresia
            // 
            this.IdMembresia.HeaderText = "Nivel de membresía";
            this.IdMembresia.Name = "IdMembresia";
            this.IdMembresia.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // frmPerfilRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDespacharPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.btnVerRseñas);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfilRepartidor";
            this.Text = "frmPerfilRepartidor";
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label btnVerRseñas;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Label btnMinimizar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnDespacharPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembresiaTexto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}