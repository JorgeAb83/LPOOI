namespace Views.Forms
{
    partial class frmCategoria
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.tabPageNuevo = new System.Windows.Forms.TabPage();
            this.tabPageEditar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPrincipal.SuspendLayout();
            this.tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPageLista);
            this.tabPrincipal.Controls.Add(this.tabPageNuevo);
            this.tabPrincipal.Controls.Add(this.tabPageEditar);
            this.tabPrincipal.ItemSize = new System.Drawing.Size(80, 20);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 41);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(776, 397);
            this.tabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.button1);
            this.tabPageLista.Controls.Add(this.dgvCategorias);
            this.tabPageLista.Controls.Add(this.txtBuscar);
            this.tabPageLista.Controls.Add(this.label1);
            this.tabPageLista.Location = new System.Drawing.Point(4, 24);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(768, 369);
            this.tabPageLista.TabIndex = 0;
            this.tabPageLista.Text = "Lista";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // tabPageNuevo
            // 
            this.tabPageNuevo.Location = new System.Drawing.Point(4, 24);
            this.tabPageNuevo.Name = "tabPageNuevo";
            this.tabPageNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNuevo.Size = new System.Drawing.Size(768, 369);
            this.tabPageNuevo.TabIndex = 1;
            this.tabPageNuevo.Text = "Nuevo";
            this.tabPageNuevo.UseVisualStyleBackColor = true;
            // 
            // tabPageEditar
            // 
            this.tabPageEditar.Location = new System.Drawing.Point(4, 24);
            this.tabPageEditar.Name = "tabPageEditar";
            this.tabPageEditar.Size = new System.Drawing.Size(768, 369);
            this.tabPageEditar.TabIndex = 2;
            this.tabPageEditar.Text = "Editar";
            this.tabPageEditar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(83, 64);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(129, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(26, 128);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(720, 220);
            this.dgvCategorias.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageLista.ResumeLayout(false);
            this.tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.TabPage tabPageNuevo;
        private System.Windows.Forms.TabPage tabPageEditar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button button1;
    }
}