﻿namespace Mambo_s_Pizza.Vista
{
    partial class frmCarrito
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
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizarCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu,
            this.Cantidad,
            this.Subtotal});
            this.dgvCarrito.Location = new System.Drawing.Point(12, 48);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(776, 390);
            this.dgvCarrito.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.Name = "Menu";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(668, 9);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(120, 30);
            this.btnFinalizarCompra.TabIndex = 6;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // frmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.dgvCarrito);
            this.Name = "frmCarrito";
            this.Text = "Carrito de compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label btnFinalizarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}