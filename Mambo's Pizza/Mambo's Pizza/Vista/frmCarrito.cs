﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mambo_s_Pizza.Vista
{
    public partial class frmCarrito : Form
    {
        public frmCarrito()
        {
            InitializeComponent();
            dgvCarrito.Rows.Add("Orange Chicken", "2", "18.99");
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada exitosamente. Puede monitorear la entrega de su pedido.", "Compra exitosa");
            frmInfoActualPedido frm = new frmInfoActualPedido();
            frm.Show();
            this.Hide();
        }
    }
}
