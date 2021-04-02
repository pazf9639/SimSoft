
namespace SimiSoftV
{
    partial class frmNMCliente
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
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblRazonS = new DevExpress.XtraEditors.LabelControl();
            this.lblTelefono = new DevExpress.XtraEditors.LabelControl();
            this.lblDescuento = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtDescuento = new DevExpress.XtraEditors.TextEdit();
            this.txtRazonS = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(13, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(11, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(250, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(13, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(37, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRazonS
            // 
            this.lblRazonS.Location = new System.Drawing.Point(13, 122);
            this.lblRazonS.Name = "lblRazonS";
            this.lblRazonS.Size = new System.Drawing.Size(59, 13);
            this.lblRazonS.TabIndex = 5;
            this.lblRazonS.Text = "Razón social";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(237, 21);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(42, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Location = new System.Drawing.Point(237, 69);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(51, 13);
            this.lblDescuento.TabIndex = 7;
            this.lblDescuento.Text = "Descuento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(347, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(83, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(306, 15);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(306, 62);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 4;
            // 
            // txtRazonS
            // 
            this.txtRazonS.Location = new System.Drawing.Point(83, 119);
            this.txtRazonS.Name = "txtRazonS";
            this.txtRazonS.Size = new System.Drawing.Size(100, 20);
            this.txtRazonS.TabIndex = 2;
            // 
            // frmNMCliente
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(445, 170);
            this.Controls.Add(this.txtRazonS);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblRazonS);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNMCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNMCliente";
            this.Load += new System.EventHandler(this.frmNMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.LabelControl lblRazonS;
        private DevExpress.XtraEditors.LabelControl lblTelefono;
        private DevExpress.XtraEditors.LabelControl lblDescuento;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtDescuento;
        private DevExpress.XtraEditors.TextEdit txtRazonS;
    }
}