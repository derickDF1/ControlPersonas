
namespace ControlPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDpi = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtApe = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblDpi = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblApe = new System.Windows.Forms.Label();
            this.LblFe = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.buttonInicialMayus = new System.Windows.Forms.Button();
            this.labelEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // TxtDpi
            // 
            this.TxtDpi.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDpi.Location = new System.Drawing.Point(170, 50);
            this.TxtDpi.Name = "TxtDpi";
            this.TxtDpi.Size = new System.Drawing.Size(181, 26);
            this.TxtDpi.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(170, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // TxtApe
            // 
            this.TxtApe.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApe.Location = new System.Drawing.Point(170, 116);
            this.TxtApe.Name = "TxtApe";
            this.TxtApe.Size = new System.Drawing.Size(181, 26);
            this.TxtApe.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngreso.Location = new System.Drawing.Point(32, 208);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(154, 28);
            this.BtnIngreso.TabIndex = 5;
            this.BtnIngreso.Text = "Ingresar Personas";
            this.BtnIngreso.UseVisualStyleBackColor = true;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblDpi
            // 
            this.LblDpi.AutoSize = true;
            this.LblDpi.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDpi.Location = new System.Drawing.Point(402, 57);
            this.LblDpi.Name = "LblDpi";
            this.LblDpi.Size = new System.Drawing.Size(45, 19);
            this.LblDpi.TabIndex = 10;
            this.LblDpi.Text = "label5";
            this.LblDpi.Visible = false;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.Location = new System.Drawing.Point(402, 92);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(45, 19);
            this.LblNom.TabIndex = 11;
            this.LblNom.Text = "label6";
            this.LblNom.Visible = false;
            // 
            // LblApe
            // 
            this.LblApe.AutoSize = true;
            this.LblApe.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApe.Location = new System.Drawing.Point(402, 125);
            this.LblApe.Name = "LblApe";
            this.LblApe.Size = new System.Drawing.Size(45, 19);
            this.LblApe.TabIndex = 12;
            this.LblApe.Text = "label7";
            this.LblApe.Visible = false;
            // 
            // LblFe
            // 
            this.LblFe.AutoSize = true;
            this.LblFe.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFe.Location = new System.Drawing.Point(402, 162);
            this.LblFe.Name = "LblFe";
            this.LblFe.Size = new System.Drawing.Size(45, 19);
            this.LblFe.TabIndex = 13;
            this.LblFe.Text = "label8";
            this.LblFe.Visible = false;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(229, 208);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(122, 28);
            this.BtnMostrar.TabIndex = 6;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // buttonInicialMayus
            // 
            this.buttonInicialMayus.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicialMayus.Location = new System.Drawing.Point(411, 208);
            this.buttonInicialMayus.Name = "buttonInicialMayus";
            this.buttonInicialMayus.Size = new System.Drawing.Size(152, 28);
            this.buttonInicialMayus.TabIndex = 7;
            this.buttonInicialMayus.Text = "Primera Mayúscula";
            this.buttonInicialMayus.UseVisualStyleBackColor = true;
            this.buttonInicialMayus.Click += new System.EventHandler(this.buttonInicialMayus_Click);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(522, 162);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(37, 19);
            this.labelEdad.TabIndex = 17;
            this.labelEdad.Text = "Edad";
            this.labelEdad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(601, 350);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.buttonInicialMayus);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.LblFe);
            this.Controls.Add(this.LblApe);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.LblDpi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtApe);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.TxtDpi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro de usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDpi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox TxtApe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblDpi;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblApe;
        private System.Windows.Forms.Label LblFe;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button buttonInicialMayus;
        private System.Windows.Forms.Label labelEdad;
    }
}

