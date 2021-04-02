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
    public partial class frmProveedores : DevExpress.XtraEditors.XtraForm
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedor.BestFitColumns();
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor()
            {
                Text = "Nuevo proveedor"
            }.ShowDialog();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedor.BestFitColumns();
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor((int)gvProveedor.GetFocusedRowCellValue("idProveedor"))
            {
                Text = "Modificar proveedor(" + (int)gvProveedor.GetFocusedRowCellValue("idProveedor") + ")"
            }.ShowDialog();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedor.BestFitColumns();
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            new Proveedor
            {
                idProveedor = (int)gvProveedor.GetFocusedRowCellValue("idProveedor")
            }.Delete();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedor.BestFitColumns();
        }

        private void bbiActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedor.BestFitColumns();
        }
    }
    }
