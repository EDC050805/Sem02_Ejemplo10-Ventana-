namespace Sem02_Ejemplo10__Ventana_
{
    partial class Form1
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
            TxtTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            TxtPrecioInicial = new TextBox();
            TxtDescuento = new TextBox();
            TxtSubTotal = new TextBox();
            TxtImpuesto = new TextBox();
            TxtImporte = new TextBox();
            BtnDeterminar = new Button();
            BtnReiniciar = new Button();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.AutoSize = true;
            TxtTitulo.BorderStyle = BorderStyle.Fixed3D;
            TxtTitulo.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTitulo.Location = new Point(104, 9);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(264, 24);
            TxtTitulo.TabIndex = 0;
            TxtTitulo.Text = "BOLETA DE PAGO POR CONSUMO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(183, 51);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 1;
            label1.Text = "Precio inicial (S/.)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 135);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Descuento (S/.) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "Sub Total (S/.) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 135);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 4;
            label4.Text = "Impuesto (S/.) :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 178);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 6;
            label6.Text = "Importe a pagar (S/.) :";
            // 
            // TxtPrecioInicial
            // 
            TxtPrecioInicial.Location = new Point(183, 71);
            TxtPrecioInicial.Name = "TxtPrecioInicial";
            TxtPrecioInicial.Size = new Size(100, 23);
            TxtPrecioInicial.TabIndex = 7;
            // 
            // TxtDescuento
            // 
            TxtDescuento.Location = new Point(104, 132);
            TxtDescuento.Name = "TxtDescuento";
            TxtDescuento.Size = new Size(100, 23);
            TxtDescuento.TabIndex = 8;
            // 
            // TxtSubTotal
            // 
            TxtSubTotal.Location = new Point(104, 175);
            TxtSubTotal.Name = "TxtSubTotal";
            TxtSubTotal.Size = new Size(100, 23);
            TxtSubTotal.TabIndex = 9;
            // 
            // TxtImpuesto
            // 
            TxtImpuesto.Location = new Point(341, 132);
            TxtImpuesto.Name = "TxtImpuesto";
            TxtImpuesto.Size = new Size(100, 23);
            TxtImpuesto.TabIndex = 10;
            // 
            // TxtImporte
            // 
            TxtImporte.Location = new Point(341, 175);
            TxtImporte.Name = "TxtImporte";
            TxtImporte.Size = new Size(100, 23);
            TxtImporte.TabIndex = 11;
            // 
            // BtnDeterminar
            // 
            BtnDeterminar.Location = new Point(144, 218);
            BtnDeterminar.Name = "BtnDeterminar";
            BtnDeterminar.Size = new Size(75, 23);
            BtnDeterminar.TabIndex = 12;
            BtnDeterminar.Text = "Determinar";
            BtnDeterminar.UseVisualStyleBackColor = true;
            BtnDeterminar.Click += BtnDeterminar_Click;
            // 
            // BtnReiniciar
            // 
            BtnReiniciar.Location = new Point(258, 218);
            BtnReiniciar.Name = "BtnReiniciar";
            BtnReiniciar.Size = new Size(75, 23);
            BtnReiniciar.TabIndex = 13;
            BtnReiniciar.Text = "Reiniciar";
            BtnReiniciar.UseVisualStyleBackColor = true;
            BtnReiniciar.Click += BtnReiniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 253);
            Controls.Add(BtnReiniciar);
            Controls.Add(BtnDeterminar);
            Controls.Add(TxtImporte);
            Controls.Add(TxtImpuesto);
            Controls.Add(TxtSubTotal);
            Controls.Add(TxtDescuento);
            Controls.Add(TxtPrecioInicial);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox TxtPrecioInicial;
        private TextBox TxtDescuento;
        private TextBox TxtSubTotal;
        private TextBox TxtImpuesto;
        private TextBox TxtImporte;
        private Button BtnDeterminar;
        private Button BtnReiniciar;
    }
}