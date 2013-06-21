namespace Ejemplo11
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
            this.components = new System.ComponentModel.Container();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.proveedorDeErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDeErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(153, 57);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 0;
            this.txtC.Text = "0.00";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtC.TextChanged += new System.EventHandler(this.TextChange);
            this.txtC.Validating += new System.ComponentModel.CancelEventHandler(this.Validando);
            this.txtC.Validated += new System.EventHandler(this.Validado);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(153, 119);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 20);
            this.txtF.TabIndex = 1;
            this.txtF.Text = "32.00";
            this.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtF.TextChanged += new System.EventHandler(this.TextChange);
            this.txtF.Validating += new System.ComponentModel.CancelEventHandler(this.Validando);
            this.txtF.Validated += new System.EventHandler(this.Validado);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grados Centigrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grados Farenheit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proveedorDeErrores
            // 
            this.proveedorDeErrores.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDeErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider proveedorDeErrores;
    }
}

