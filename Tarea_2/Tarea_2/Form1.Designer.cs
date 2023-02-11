namespace Tarea_2
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
            this.components = new System.ComponentModel.Container();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrimerParcialtextBox = new System.Windows.Forms.TextBox();
            this.SegundotextBox = new System.Windows.Forms.TextBox();
            this.TercerotextBox = new System.Windows.Forms.TextBox();
            this.CuartotextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(226, 251);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(173, 49);
            this.Calcularbutton.TabIndex = 0;
            this.Calcularbutton.Text = "Calcular Promedio";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota del primer parcial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota del segundo parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota del tercer parcial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota del cuarto parcial";
            // 
            // PrimerParcialtextBox
            // 
            this.PrimerParcialtextBox.Location = new System.Drawing.Point(225, 94);
            this.PrimerParcialtextBox.Name = "PrimerParcialtextBox";
            this.PrimerParcialtextBox.Size = new System.Drawing.Size(100, 20);
            this.PrimerParcialtextBox.TabIndex = 5;
            this.PrimerParcialtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrimerParcialtextBox_KeyPress);
            // 
            // SegundotextBox
            // 
            this.SegundotextBox.Location = new System.Drawing.Point(225, 134);
            this.SegundotextBox.Name = "SegundotextBox";
            this.SegundotextBox.Size = new System.Drawing.Size(100, 20);
            this.SegundotextBox.TabIndex = 6;
            // 
            // TercerotextBox
            // 
            this.TercerotextBox.Location = new System.Drawing.Point(225, 169);
            this.TercerotextBox.Name = "TercerotextBox";
            this.TercerotextBox.Size = new System.Drawing.Size(100, 20);
            this.TercerotextBox.TabIndex = 7;
            // 
            // CuartotextBox
            // 
            this.CuartotextBox.Location = new System.Drawing.Point(225, 202);
            this.CuartotextBox.Name = "CuartotextBox";
            this.CuartotextBox.Size = new System.Drawing.Size(100, 20);
            this.CuartotextBox.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingrese el nombre del estudiante";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(226, 42);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(309, 20);
            this.NombretextBox.TabIndex = 10;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // Form1
            // 
            this.AcceptButton = this.Calcularbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(641, 347);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CuartotextBox);
            this.Controls.Add(this.TercerotextBox);
            this.Controls.Add(this.SegundotextBox);
            this.Controls.Add(this.PrimerParcialtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcularbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrimerParcialtextBox;
        private System.Windows.Forms.TextBox SegundotextBox;
        private System.Windows.Forms.TextBox TercerotextBox;
        private System.Windows.Forms.TextBox CuartotextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label5;
    }
}

