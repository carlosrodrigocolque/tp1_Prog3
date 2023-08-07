
namespace trabajoPractico_1
{
    partial class formEj1
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
            this.lblIngresarNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lboxIngreso = new System.Windows.Forms.ListBox();
            this.lboxGuardado = new System.Windows.Forms.ListBox();
            this.btnIngresoUno = new System.Windows.Forms.Button();
            this.btnIngresoTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngresarNombre
            // 
            this.lblIngresarNombre.AutoSize = true;
            this.lblIngresarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombre.Location = new System.Drawing.Point(30, 52);
            this.lblIngresarNombre.Name = "lblIngresarNombre";
            this.lblIngresarNombre.Size = new System.Drawing.Size(139, 16);
            this.lblIngresarNombre.TabIndex = 0;
            this.lblIngresarNombre.Text = "Ingrese un Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(469, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 25);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(175, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lboxIngreso
            // 
            this.lboxIngreso.FormattingEnabled = true;
            this.lboxIngreso.Location = new System.Drawing.Point(33, 139);
            this.lboxIngreso.Name = "lboxIngreso";
            this.lboxIngreso.Size = new System.Drawing.Size(207, 277);
            this.lboxIngreso.TabIndex = 3;
            // 
            // lboxGuardado
            // 
            this.lboxGuardado.FormattingEnabled = true;
            this.lboxGuardado.Location = new System.Drawing.Point(347, 139);
            this.lboxGuardado.Name = "lboxGuardado";
            this.lboxGuardado.Size = new System.Drawing.Size(206, 277);
            this.lboxGuardado.TabIndex = 4;
            // 
            // btnIngresoUno
            // 
            this.btnIngresoUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoUno.Location = new System.Drawing.Point(267, 197);
            this.btnIngresoUno.Name = "btnIngresoUno";
            this.btnIngresoUno.Size = new System.Drawing.Size(50, 30);
            this.btnIngresoUno.TabIndex = 5;
            this.btnIngresoUno.Text = ">";
            this.btnIngresoUno.UseVisualStyleBackColor = true;
            this.btnIngresoUno.Click += new System.EventHandler(this.btnIngresoUno_Click);
            // 
            // btnIngresoTodos
            // 
            this.btnIngresoTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoTodos.Location = new System.Drawing.Point(267, 248);
            this.btnIngresoTodos.Name = "btnIngresoTodos";
            this.btnIngresoTodos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIngresoTodos.Size = new System.Drawing.Size(50, 30);
            this.btnIngresoTodos.TabIndex = 6;
            this.btnIngresoTodos.Text = ">>";
            this.btnIngresoTodos.UseVisualStyleBackColor = true;
            this.btnIngresoTodos.Click += new System.EventHandler(this.btnIngresoTodos_Click);
            // 
            // formEj1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnIngresoTodos);
            this.Controls.Add(this.btnIngresoUno);
            this.Controls.Add(this.lboxGuardado);
            this.Controls.Add(this.lboxIngreso);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblIngresarNombre);
            this.Name = "formEj1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lboxIngreso;
        private System.Windows.Forms.ListBox lboxGuardado;
        private System.Windows.Forms.Button btnIngresoUno;
        private System.Windows.Forms.Button btnIngresoTodos;
    }
}