namespace Ejemplo_Funcion_Parametros__sin_y_con_Ref_
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tNota1 = new System.Windows.Forms.TextBox();
            this.tNota2 = new System.Windows.Forms.TextBox();
            this.tNota3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Funcion con Argumentos normales sin Ref";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Funcion VOID con Parametros Referencia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tNota1
            // 
            this.tNota1.Location = new System.Drawing.Point(58, 26);
            this.tNota1.Name = "tNota1";
            this.tNota1.Size = new System.Drawing.Size(100, 20);
            this.tNota1.TabIndex = 2;
            this.tNota1.Text = "Nota 1";
            // 
            // tNota2
            // 
            this.tNota2.Location = new System.Drawing.Point(58, 57);
            this.tNota2.Name = "tNota2";
            this.tNota2.Size = new System.Drawing.Size(100, 20);
            this.tNota2.TabIndex = 3;
            this.tNota2.Text = "Nota 2";
            // 
            // tNota3
            // 
            this.tNota3.Location = new System.Drawing.Point(58, 86);
            this.tNota3.Name = "tNota3";
            this.tNota3.Size = new System.Drawing.Size(100, 20);
            this.tNota3.TabIndex = 4;
            this.tNota3.Text = "Nota 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tNota3);
            this.Controls.Add(this.tNota2);
            this.Controls.Add(this.tNota1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tNota1;
        private System.Windows.Forms.TextBox tNota2;
        private System.Windows.Forms.TextBox tNota3;
    }
}

