
namespace SimiSoftV
{
    partial class frmClientes
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModificar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.sbsApariencia = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gcClientes = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiActualizar,
            this.bbiNuevo,
            this.bbiModificar,
            this.bbiEliminar,
            this.sbsApariencia});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiActualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiModificar),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.sbsApariencia)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // bbiActualizar
            // 
            this.bbiActualizar.Caption = "Actualizar";
            this.bbiActualizar.Id = 0;
            this.bbiActualizar.Name = "bbiActualizar";
            this.bbiActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiActualizar_ItemClick);
            // 
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevo_ItemClick);
            // 
            // bbiModificar
            // 
            this.bbiModificar.Caption = "Modificar";
            this.bbiModificar.Id = 2;
            this.bbiModificar.Name = "bbiModificar";
            this.bbiModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificar_ItemClick);
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 3;
            this.bbiEliminar.Name = "bbiEliminar";
            this.bbiEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminar_ItemClick);
            // 
            // sbsApariencia
            // 
            this.sbsApariencia.Caption = "Apariencia";
            this.sbsApariencia.Id = 4;
            this.sbsApariencia.Name = "sbsApariencia";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(798, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 548);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 548);
            // 
            // gcClientes
            // 
            this.gcClientes.DataSource = this.clienteBindingSource;
            this.gcClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcClientes.Location = new System.Drawing.Point(0, 20);
            this.gcClientes.MainView = this.gvClientes;
            this.gcClientes.MenuManager = this.barManager1;
            this.gcClientes.Name = "gcClientes";
            this.gcClientes.Size = new System.Drawing.Size(798, 548);
            this.gcClientes.TabIndex = 4;
            this.gcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(SimSoft.BML.Cliente);
            // 
            // gvClientes
            // 
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCliente,
            this.colnombre,
            this.colrazonSocial,
            this.coltelefono,
            this.coldescuento,
            this.colactivo});
            this.gvClientes.GridControl = this.gcClientes;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsBehavior.Editable = false;
            this.gvClientes.OptionsView.ColumnAutoWidth = false;
            this.gvClientes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClientes.OptionsView.ShowAutoFilterRow = true;
            this.gvClientes.OptionsView.ShowGroupPanel = false;
            // 
            // colidCliente
            // 
            this.colidCliente.Caption = "ID";
            this.colidCliente.FieldName = "idCliente";
            this.colidCliente.Name = "colidCliente";
            this.colidCliente.Visible = true;
            this.colidCliente.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // colrazonSocial
            // 
            this.colrazonSocial.Caption = "Razón social";
            this.colrazonSocial.FieldName = "razonSocial";
            this.colrazonSocial.Name = "colrazonSocial";
            this.colrazonSocial.Visible = true;
            this.colrazonSocial.VisibleIndex = 2;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Teléfono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 3;
            // 
            // coldescuento
            // 
            this.coldescuento.Caption = "Descuento";
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 4;
            // 
            // colactivo
            // 
            this.colactivo.Caption = "Activo";
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.gcClientes);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiActualizar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiNuevo;
        private DevExpress.XtraBars.BarButtonItem bbiModificar;
        private DevExpress.XtraBars.BarButtonItem bbiEliminar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.SkinBarSubItem sbsApariencia;
        private DevExpress.XtraGrid.GridControl gcClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colrazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}