namespace Alquiler_Vehiculos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIngresarAuto = new System.Windows.Forms.Button();
            this.buttonIngresarCliente = new System.Windows.Forms.Button();
            this.buttonIngresarAlquiler = new System.Windows.Forms.Button();
            this.buttonVerAlquileres = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIngresarAuto
            // 
            this.buttonIngresarAuto.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresarAuto.Location = new System.Drawing.Point(90, 22);
            this.buttonIngresarAuto.Name = "buttonIngresarAuto";
            this.buttonIngresarAuto.Size = new System.Drawing.Size(177, 61);
            this.buttonIngresarAuto.TabIndex = 0;
            this.buttonIngresarAuto.Text = "AUTOS";
            this.buttonIngresarAuto.UseVisualStyleBackColor = true;
            this.buttonIngresarAuto.Click += new System.EventHandler(this.buttonIngresarAuto_Click);
            // 
            // buttonIngresarCliente
            // 
            this.buttonIngresarCliente.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresarCliente.Location = new System.Drawing.Point(90, 89);
            this.buttonIngresarCliente.Name = "buttonIngresarCliente";
            this.buttonIngresarCliente.Size = new System.Drawing.Size(177, 60);
            this.buttonIngresarCliente.TabIndex = 1;
            this.buttonIngresarCliente.Text = "CLIENTES";
            this.buttonIngresarCliente.UseVisualStyleBackColor = true;
            this.buttonIngresarCliente.Click += new System.EventHandler(this.buttonIngresarCliente_Click);
            // 
            // buttonIngresarAlquiler
            // 
            this.buttonIngresarAlquiler.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresarAlquiler.Location = new System.Drawing.Point(90, 155);
            this.buttonIngresarAlquiler.Name = "buttonIngresarAlquiler";
            this.buttonIngresarAlquiler.Size = new System.Drawing.Size(177, 60);
            this.buttonIngresarAlquiler.TabIndex = 2;
            this.buttonIngresarAlquiler.Text = "Ingresar Alquiler";
            this.buttonIngresarAlquiler.UseVisualStyleBackColor = true;
            this.buttonIngresarAlquiler.Click += new System.EventHandler(this.buttonIngresarAlquiler_Click);
            // 
            // buttonVerAlquileres
            // 
            this.buttonVerAlquileres.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerAlquileres.Location = new System.Drawing.Point(90, 221);
            this.buttonVerAlquileres.Name = "buttonVerAlquileres";
            this.buttonVerAlquileres.Size = new System.Drawing.Size(177, 63);
            this.buttonVerAlquileres.TabIndex = 3;
            this.buttonVerAlquileres.Text = "VER Alquileres";
            this.buttonVerAlquileres.UseVisualStyleBackColor = true;
            this.buttonVerAlquileres.Click += new System.EventHandler(this.buttonVerAlquileres_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(90, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Alquiler con mas recorrido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonVerAlquileres);
            this.Controls.Add(this.buttonIngresarAlquiler);
            this.Controls.Add(this.buttonIngresarCliente);
            this.Controls.Add(this.buttonIngresarAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIngresarAuto;
        private System.Windows.Forms.Button buttonIngresarCliente;
        private System.Windows.Forms.Button buttonIngresarAlquiler;
        private System.Windows.Forms.Button buttonVerAlquileres;
        private System.Windows.Forms.Button button1;
    }
}

