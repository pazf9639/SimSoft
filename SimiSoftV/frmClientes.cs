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
    public partial class frmClientes : DevExpress.XtraEditors.XtraForm
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente()
            {
                Text = "Nuevo cliente"
            }.ShowDialog();
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void bbiActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("idCliente"))
            {
                Text = "Modificar cliente(" + (int)gvClientes.GetFocusedRowCellValue("idCliente") + ")"
            }.ShowDialog();
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Cliente
            {
                idCliente = (int)gvClientes.GetFocusedRowCellValue("idCliente")
            }.Delete();
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }
    }
}