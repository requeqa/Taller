
namespace Taller
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sFEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sFNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.parametrosToolStripMenuItem,
            this.listaDePreciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.nuevoToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.inventarioToolStripMenuItem.Text = "Producto";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.nuevoToolStripMenuItem.Text = "Listado";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.ListadoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.NuevoToolStripMenuItem1_Click);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem});
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.unidadToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // unidadToolStripMenuItem
            // 
            this.unidadToolStripMenuItem.Name = "unidadToolStripMenuItem";
            this.unidadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.unidadToolStripMenuItem.Text = "Unidad";
            this.unidadToolStripMenuItem.Click += new System.EventHandler(this.unidadToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 534);
            this.panel1.TabIndex = 6;
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cFEspecialesToolStripMenuItem,
            this.sFEspecialesToolStripMenuItem,
            this.cFNormalToolStripMenuItem,
            this.sFNormalToolStripMenuItem});
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de Precios";
            // 
            // cFEspecialesToolStripMenuItem
            // 
            this.cFEspecialesToolStripMenuItem.Name = "cFEspecialesToolStripMenuItem";
            this.cFEspecialesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cFEspecialesToolStripMenuItem.Text = "C/F Normal";
            this.cFEspecialesToolStripMenuItem.Click += new System.EventHandler(this.cFEspecialesToolStripMenuItem_Click);
            // 
            // sFEspecialesToolStripMenuItem
            // 
            this.sFEspecialesToolStripMenuItem.Name = "sFEspecialesToolStripMenuItem";
            this.sFEspecialesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sFEspecialesToolStripMenuItem.Text = "S/F Normal";
            this.sFEspecialesToolStripMenuItem.Click += new System.EventHandler(this.sFEspecialesToolStripMenuItem_Click);
            // 
            // cFNormalToolStripMenuItem
            // 
            this.cFNormalToolStripMenuItem.Name = "cFNormalToolStripMenuItem";
            this.cFNormalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cFNormalToolStripMenuItem.Text = "C/F Especial";
            // 
            // sFNormalToolStripMenuItem
            // 
            this.sFNormalToolStripMenuItem.Name = "sFNormalToolStripMenuItem";
            this.sFNormalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sFNormalToolStripMenuItem.Text = "S/F Especial";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFEspecialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sFEspecialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sFNormalToolStripMenuItem;
    }
}

