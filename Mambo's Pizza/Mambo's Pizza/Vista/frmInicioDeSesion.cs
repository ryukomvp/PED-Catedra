﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mambo_s_Pizza
{
    public partial class frmInicioDeSesion : Form
    {
        int x=0;
        int y=0;

        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar el sistema?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = ColorTranslator.FromHtml("#8C3A42");
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Transparent;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void btnAlternarVisibilidad_Click(object sender, EventArgs e)
        {
            if (txtClave.PasswordChar == '*')
            {
                txtClave.PasswordChar = '\0'; // Hace visible el texto
                btnAlternarVisibilidad.Image = Properties.Resources.icons8_invisible_20;
            }
            else
            {
                txtClave.PasswordChar = '*'; // Oculta el texto
                btnAlternarVisibilidad.Image = Properties.Resources.icons8_visible_20;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarCredenciales();
        }

        private void barra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Left = Left + (e.X - x);
                Top = Top + (e.Y - y);
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = ColorTranslator.FromHtml("#8C3A42");
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = ColorTranslator.FromHtml("#640D14");
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                validarCredenciales();
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                validarCredenciales();
        }

        void validarCredenciales()
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Credenciales vacías");
                return;
            }

            switch (txtUsuario.Text)
            {
                case "admin":
                    Vista.frmPrincipal frmAdmin = new Vista.frmPrincipal();
                    frmAdmin.Show();
                    this.Hide();
                    break;
                case "cliente":
                    Vista.frmVistaClientes frmClientes = new Vista.frmVistaClientes();
                    frmClientes.Show();
                    this.Hide();
                    break;
                case "repartidor":
                    Vista.frmPerfilRepartidor frmRepartidor = new Vista.frmPerfilRepartidor();
                    frmRepartidor.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Verifique nuevamente las credenciales ingresadas", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Clear();
                    txtClave.Clear();
                    break;
            }
        }

        private void btnRecuperarClave_MouseEnter(object sender, EventArgs e)
        {
            btnRecuperarClave.BackColor = ColorTranslator.FromHtml("#640D14");
        }

        private void btnRecuperarClave_MouseLeave(object sender, EventArgs e)
        {
            btnRecuperarClave.BackColor = Color.Transparent;
        }

        private void btnRegistrarse_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarse.BackColor = ColorTranslator.FromHtml("#640D14");
        }

        private void btnRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarse.BackColor = Color.Transparent;
        }

        private void btnRecuperarClave_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Vista.frmRegistrarse frm = new Vista.frmRegistrarse();
            MostarPanel(frm);
        }

        void MostarPanel(Form frm)
        {
            while (fondo.Controls.Count > 0)
            {
                fondo.Controls.RemoveAt(0);
            }
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            fondo.Controls.Clear();
            fondo.Controls.Add(frm);
            frm.Show();
        }
    }
}
