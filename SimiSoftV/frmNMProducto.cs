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
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {
      private int idProducto;
        private Producto producto;
        //nuevo
        public frmNMProducto()
        {
            InitializeComponent();
            
        }
        //mod
        public frmNMProducto(int idProducto)
        {
            InitializeComponent();
            this.idProducto = idProducto;
            producto = new Producto
            {
                idProducto = this.idProducto
            }.GetById();
            txtID.Text = producto.idProducto.ToString();
            txtDescripcion.Text = producto.descripcion;
            txtUnidadM.Text = producto.unidadMedida;
            txtCodigo.Text = producto.codigo;
            txtPrecio.Text = producto.precio.ToString();
            txtStock.Text = producto.stock.ToString();
            txtMarca.Text = producto.marca;

        }

        private void FrmNMProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                if(producto==null)
                if(new Producto
                {
                    descripcion=txtDescripcion.Text,
                    unidadMedida=txtUnidadM.Text,
                    codigo=txtCodigo.Text,
                    precio=Convert.ToInt32(txtPrecio.Text),
                    stock=Convert.ToInt32(txtStock.Text),
                    marca=txtMarca.Text
                }.Add()>0)
                {
                    XtraMessageBox.Show("Producto insertado correctamente",
                        Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    this.Close();
                    
                    }
                    else
                    {
                        XtraMessageBox.Show("Error al insertar producto",
                           Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                           );
                        this.Close();
                    }

                    else
                    {
                        producto.descripcion = txtDescripcion.Text;
                        producto.unidadMedida = txtUnidadM.Text;
                        producto.codigo = txtCodigo.Text;
                        producto.precio = Convert.ToDecimal(txtPrecio.Text);
                        producto.stock = Convert.ToInt32(txtStock.Text);
                        producto.marca = txtMarca.Text;

                        if(producto.Update()>0)
                        {
                            XtraMessageBox.Show("Producto actualizado correctamente",
                                                   Application.ProductName, MessageBoxButtons.OK,
                                                   MessageBoxIcon.Information);
                            this.Close();

                        }
                    else
                    {
                        XtraMessageBox.Show("Error al Actualizar Producto",
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
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingrese una descripción";
                txtDescripcion.Focus();
                ban = true;

            }
            if (string.IsNullOrEmpty(txtUnidadM.Text))
            {
                txtUnidadM.ErrorText = "Ingrese una unidad de medida";
                if (ban == false)
                {
                    txtUnidadM.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingrese un código";
                if (ban == false)
                {
                    txtCodigo.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.ErrorText = "Ingrese un precio";
                if (ban == false)
                {
                    txtPrecio.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingrese cantidad de stock";
                if (ban == false)
                {
                    txtStock.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                txtMarca.ErrorText = "Ingrese nombre de la marca";
                if (ban == false)
                {
                    txtMarca.Focus();
                    ban = true;
                }
            }
            return !ban;
        }

      
    }
}