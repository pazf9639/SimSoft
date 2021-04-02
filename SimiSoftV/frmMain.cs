using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimiSoftV
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void bbiProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach(Form form in Application.OpenForms)
                if(form.GetType() == typeof(frmProductos))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "cargando tabla de productos ...");
            new frmProductos() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();

        }

        private void bbiProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProveedores))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "cargando tabla de proveedores ...");
            new frmProveedores() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void bbiClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmClientes))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "cargando tabla de clientes ...");
            new frmClientes() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }
    }
}
