namespace Vista.Ingresos.Paneles
{
    partial class pnlTipoMoneda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spinerCordQuiniento = new System.Windows.Forms.NumericUpDown();
            this.spinerCordDocientos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.spinerCordCien = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalCordobas = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalDolares = new System.Windows.Forms.Label();
            this.spinerDolarVeinte = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.spinerDolarCincuenta = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.spinerDolarCien = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.spinerCordMil = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinerCordQuiniento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerCordDocientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerCordCien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinerDolarVeinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerDolarCincuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerDolarCien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerCordMil)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spinerCordMil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.spinerCordCien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.spinerCordDocientos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.spinerCordQuiniento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(69, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 253);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cordobas";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "INGRESE LA CANTIDAD DE BILLETES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quinientos";
            // 
            // spinerCordQuiniento
            // 
            this.spinerCordQuiniento.Location = new System.Drawing.Point(88, 76);
            this.spinerCordQuiniento.Name = "spinerCordQuiniento";
            this.spinerCordQuiniento.Size = new System.Drawing.Size(78, 20);
            this.spinerCordQuiniento.TabIndex = 1;
            this.spinerCordQuiniento.ValueChanged += new System.EventHandler(this.spinerCordQuiniento_ValueChanged);
            // 
            // spinerCordDocientos
            // 
            this.spinerCordDocientos.Location = new System.Drawing.Point(88, 115);
            this.spinerCordDocientos.Name = "spinerCordDocientos";
            this.spinerCordDocientos.Size = new System.Drawing.Size(78, 20);
            this.spinerCordDocientos.TabIndex = 3;
            this.spinerCordDocientos.ValueChanged += new System.EventHandler(this.spinerCordDocientos_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Docientos";
            // 
            // spinerCordCien
            // 
            this.spinerCordCien.Location = new System.Drawing.Point(88, 155);
            this.spinerCordCien.Name = "spinerCordCien";
            this.spinerCordCien.Size = new System.Drawing.Size(78, 20);
            this.spinerCordCien.TabIndex = 5;
            this.spinerCordCien.ValueChanged += new System.EventHandler(this.spinerCordCien_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cien";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalCordobas);
            this.groupBox2.Location = new System.Drawing.Point(6, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 57);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // lblTotalCordobas
            // 
            this.lblTotalCordobas.Location = new System.Drawing.Point(7, 20);
            this.lblTotalCordobas.Name = "lblTotalCordobas";
            this.lblTotalCordobas.Size = new System.Drawing.Size(152, 23);
            this.lblTotalCordobas.TabIndex = 0;
            this.lblTotalCordobas.Text = "0";
            this.lblTotalCordobas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.spinerDolarVeinte);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.spinerDolarCincuenta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.spinerDolarCien);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(275, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 253);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dolares";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalDolares);
            this.groupBox4.Location = new System.Drawing.Point(6, 190);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 57);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total";
            // 
            // lblTotalDolares
            // 
            this.lblTotalDolares.Location = new System.Drawing.Point(7, 20);
            this.lblTotalDolares.Name = "lblTotalDolares";
            this.lblTotalDolares.Size = new System.Drawing.Size(152, 23);
            this.lblTotalDolares.TabIndex = 0;
            this.lblTotalDolares.Text = "0";
            this.lblTotalDolares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spinerDolarVeinte
            // 
            this.spinerDolarVeinte.Location = new System.Drawing.Point(94, 115);
            this.spinerDolarVeinte.Name = "spinerDolarVeinte";
            this.spinerDolarVeinte.Size = new System.Drawing.Size(78, 20);
            this.spinerDolarVeinte.TabIndex = 5;
            this.spinerDolarVeinte.ValueChanged += new System.EventHandler(this.spinerDolarVeinte_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Veinte";
            // 
            // spinerDolarCincuenta
            // 
            this.spinerDolarCincuenta.Location = new System.Drawing.Point(94, 75);
            this.spinerDolarCincuenta.Name = "spinerDolarCincuenta";
            this.spinerDolarCincuenta.Size = new System.Drawing.Size(78, 20);
            this.spinerDolarCincuenta.TabIndex = 3;
            this.spinerDolarCincuenta.ValueChanged += new System.EventHandler(this.spinerDolarCincuenta_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cincuenta";
            // 
            // spinerDolarCien
            // 
            this.spinerDolarCien.Location = new System.Drawing.Point(94, 36);
            this.spinerDolarCien.Name = "spinerDolarCien";
            this.spinerDolarCien.Size = new System.Drawing.Size(78, 20);
            this.spinerDolarCien.TabIndex = 1;
            this.spinerDolarCien.ValueChanged += new System.EventHandler(this.spinerDolarCien_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cien";
            // 
            // spinerCordMil
            // 
            this.spinerCordMil.Location = new System.Drawing.Point(88, 36);
            this.spinerCordMil.Name = "spinerCordMil";
            this.spinerCordMil.Size = new System.Drawing.Size(78, 20);
            this.spinerCordMil.TabIndex = 8;
            this.spinerCordMil.ValueChanged += new System.EventHandler(this.spinerCordMil_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mil";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "GUARDAR INGRESO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlTipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "pnlTipoMoneda";
            this.Text = "pnlTipoMoneda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinerCordQuiniento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerCordDocientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerCordCien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinerDolarVeinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerDolarCincuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerDolarCien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinerCordMil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinerCordMil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalCordobas;
        private System.Windows.Forms.NumericUpDown spinerCordCien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spinerCordDocientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spinerCordQuiniento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalDolares;
        private System.Windows.Forms.NumericUpDown spinerDolarVeinte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spinerDolarCincuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown spinerDolarCien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}