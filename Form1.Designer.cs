namespace ControlDePagos
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuataMásAltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotaMásBajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMasAtlas = new System.Windows.Forms.Button();
            this.btnMasBajas = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(599, 88);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuataMásAltasToolStripMenuItem,
            this.cuotaMásBajasToolStripMenuItem});
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            // 
            // cuataMásAltasToolStripMenuItem
            // 
            this.cuataMásAltasToolStripMenuItem.Name = "cuataMásAltasToolStripMenuItem";
            this.cuataMásAltasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuataMásAltasToolStripMenuItem.Text = "Cuota más altas";
            this.cuataMásAltasToolStripMenuItem.Click += new System.EventHandler(this.cuataMásAltasToolStripMenuItem_Click);
            // 
            // cuotaMásBajasToolStripMenuItem
            // 
            this.cuotaMásBajasToolStripMenuItem.Name = "cuotaMásBajasToolStripMenuItem";
            this.cuotaMásBajasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuotaMásBajasToolStripMenuItem.Text = "Cuota más bajas";
            this.cuotaMásBajasToolStripMenuItem.Click += new System.EventHandler(this.cuotaMásBajasToolStripMenuItem_Click);
            // 
            // btnMasAtlas
            // 
            this.btnMasAtlas.Enabled = false;
            this.btnMasAtlas.Location = new System.Drawing.Point(599, 154);
            this.btnMasAtlas.Name = "btnMasAtlas";
            this.btnMasAtlas.Size = new System.Drawing.Size(103, 28);
            this.btnMasAtlas.TabIndex = 3;
            this.btnMasAtlas.Text = "Cuotas mas altas";
            this.btnMasAtlas.UseVisualStyleBackColor = true;
            this.btnMasAtlas.Click += new System.EventHandler(this.btnMasAtlas_Click);
            // 
            // btnMasBajas
            // 
            this.btnMasBajas.Enabled = false;
            this.btnMasBajas.Location = new System.Drawing.Point(599, 219);
            this.btnMasBajas.Name = "btnMasBajas";
            this.btnMasBajas.Size = new System.Drawing.Size(103, 27);
            this.btnMasBajas.TabIndex = 4;
            this.btnMasBajas.Text = "Cuotas mas bajas";
            this.btnMasBajas.UseVisualStyleBackColor = true;
            this.btnMasBajas.Click += new System.EventHandler(this.btnMasBajas_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Enabled = false;
            this.btnAlta.Location = new System.Drawing.Point(599, 279);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(103, 24);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Cuota mas Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnMasBajas);
            this.Controls.Add(this.btnMasAtlas);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuataMásAltasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotaMásBajasToolStripMenuItem;
        private System.Windows.Forms.Button btnMasBajas;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnMasAtlas;
    }
}

