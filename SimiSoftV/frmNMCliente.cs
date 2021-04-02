using DevExpress.XtraEditors;
using SimSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimiSoftV
{
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {


        private int idCliente;
        private Cliente cliente;

        public frmNMCliente()
        {
            InitializeComponent();
        }

        public frmNMCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            cliente = new Cliente
            {
                idCliente = this.idCliente
            }.GetById();
            txtId.Text = cliente.idCliente.ToString();
            txtNombre.Text = cliente.nombre;
            txtRazonS.Text = cliente.razonSocial;
            txtTelefono.Text = cliente.telefono;
            txtDescuento.Text =cliente.descuento.ToString();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                if (cliente == null)
                    if (new Cliente
                    {
                        nombre = txtNombre.Text,
                        razonSocial = txtRazonS.Text,
                        telefono = txtTelefono.Text,
                        descuento = Convert.ToDecimal(txtDescuento.Text),
                        
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Cliente insertado correctamente",
                            Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        this.Close();

                    }
                    else
                    {
                        XtraMessageBox.Show("Error al insertar cliente",
                           Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                           );
                        this.Close();
                    }

                else
                {
                    cliente.nombre = txtNombre.Text;
                    cliente.razonSocial = txtRazonS.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.descuento = Convert.ToDecimal(txtDescuento.Text);
                   
                    if (cliente.Update() > 0)
                    {
                        XtraMessageBox.Show("Cliente actualizado correctamente",
                                               Application.ProductName, MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        XtraMessageBox.Show("Error al Actualizar Clente",
                           Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                           );
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingrese un nombre";
                txtNombre.Focus();
                ban = true;

            }
            if (string.IsNullOrEmpty(txtRazonS.Text))
            {
                txtRazonS.ErrorText = "Ingrese una razón social";
                if (ban == false)
                {
                    txtRazonS.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingrese un número de teléfono";
                if (ban == false)
                {
                    txtTelefono.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.ErrorText = "Ingrese el descuento";
                if (ban == false)
                {
                    txtDescuento.Focus();
                    ban = true;
                }
            }
            return !ban;
        }

        private void frmNMCliente_Load(object sender, EventArgs e)
        {

        }
    }
}