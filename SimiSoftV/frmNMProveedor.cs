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
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {
        private int idProveedor;
        private Proveedor proveedor;
        public frmNMProveedor()
        {
            InitializeComponent();
        }
        public frmNMProveedor(int idProveedor)
        {
            InitializeComponent();
            this.idProveedor = idProveedor;
            proveedor = new Proveedor
            {
                idProveedor = this.idProveedor
            }.GetById();
            txtID.Text = proveedor.idProveedor.ToString();
            txtNombre.Text = proveedor.nombre;
            txtTelefono.Text = proveedor.telefono;

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
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingrese un número teléfonico";
                if (ban == false)
                {
                    txtTelefono.Focus();
                    ban = true;
                }
            }
          
          
            return !ban;
        }

        private void frmNMProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (proveedor == null)
                    if (new Proveedor
                    {
                       nombre=txtNombre.Text,
                       telefono=txtTelefono.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor insertado correctamente",
                            Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        this.Close();

                    }
                    else
                    {
                        XtraMessageBox.Show("Error al insertar proveedor",
                           Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                           );
                        this.Close();
                    }

                else
                {
                    proveedor.nombre = txtNombre.Text;
                    proveedor.telefono = txtTelefono.Text;

                    if (proveedor.Update() > 0)
                    {
                        XtraMessageBox.Show("Proveedor actualizado correctamente",
                                               Application.ProductName, MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        XtraMessageBox.Show("Error al Actualizar Proveedor",
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
    }
}