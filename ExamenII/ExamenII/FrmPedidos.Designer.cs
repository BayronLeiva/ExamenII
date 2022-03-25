namespace ExamenII
{
    partial class FrmPedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductotextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CantidadtextBox3 = new System.Windows.Forms.TextBox();
            this.ClientetextBox2 = new System.Windows.Forms.TextBox();
            this.CodigotextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotaltextBox6 = new System.Windows.Forms.TextBox();
            this.ISVtextBox5 = new System.Windows.Forms.TextBox();
            this.SubTotaltextBox4 = new System.Windows.Forms.TextBox();
            this.PedidosDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(940, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "SubTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ISV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(951, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.ProductotextBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CantidadtextBox3);
            this.groupBox1.Controls.Add(this.ClientetextBox2);
            this.groupBox1.Controls.Add(this.CodigotextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1407, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // ProductotextBox1
            // 
            this.ProductotextBox1.Location = new System.Drawing.Point(137, 107);
            this.ProductotextBox1.Name = "ProductotextBox1";
            this.ProductotextBox1.ReadOnly = true;
            this.ProductotextBox1.Size = new System.Drawing.Size(318, 27);
            this.ProductotextBox1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Producto";
            // 
            // CantidadtextBox3
            // 
            this.CantidadtextBox3.Location = new System.Drawing.Point(1053, 55);
            this.CantidadtextBox3.Name = "CantidadtextBox3";
            this.CantidadtextBox3.Size = new System.Drawing.Size(318, 27);
            this.CantidadtextBox3.TabIndex = 6;
            this.CantidadtextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox3_KeyPress);
            // 
            // ClientetextBox2
            // 
            this.ClientetextBox2.Location = new System.Drawing.Point(593, 55);
            this.ClientetextBox2.Name = "ClientetextBox2";
            this.ClientetextBox2.Size = new System.Drawing.Size(318, 27);
            this.ClientetextBox2.TabIndex = 5;
            this.ClientetextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientetextBox2_KeyPress);
            // 
            // CodigotextBox1
            // 
            this.CodigotextBox1.Location = new System.Drawing.Point(137, 55);
            this.CodigotextBox1.Name = "CodigotextBox1";
            this.CodigotextBox1.Size = new System.Drawing.Size(318, 27);
            this.CodigotextBox1.TabIndex = 4;
            this.CodigotextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigotextBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.TotaltextBox6);
            this.groupBox2.Controls.Add(this.ISVtextBox5);
            this.groupBox2.Controls.Add(this.SubTotaltextBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1407, 118);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura";
            // 
            // TotaltextBox6
            // 
            this.TotaltextBox6.Location = new System.Drawing.Point(1053, 53);
            this.TotaltextBox6.Name = "TotaltextBox6";
            this.TotaltextBox6.ReadOnly = true;
            this.TotaltextBox6.Size = new System.Drawing.Size(318, 27);
            this.TotaltextBox6.TabIndex = 8;
            // 
            // ISVtextBox5
            // 
            this.ISVtextBox5.Location = new System.Drawing.Point(593, 46);
            this.ISVtextBox5.Name = "ISVtextBox5";
            this.ISVtextBox5.ReadOnly = true;
            this.ISVtextBox5.Size = new System.Drawing.Size(318, 27);
            this.ISVtextBox5.TabIndex = 8;
            // 
            // SubTotaltextBox4
            // 
            this.SubTotaltextBox4.Location = new System.Drawing.Point(137, 46);
            this.SubTotaltextBox4.Name = "SubTotaltextBox4";
            this.SubTotaltextBox4.ReadOnly = true;
            this.SubTotaltextBox4.Size = new System.Drawing.Size(318, 27);
            this.SubTotaltextBox4.TabIndex = 6;
            // 
            // PedidosDGV
            // 
            this.PedidosDGV.AllowUserToAddRows = false;
            this.PedidosDGV.AllowUserToDeleteRows = false;
            this.PedidosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosDGV.Enabled = false;
            this.PedidosDGV.Location = new System.Drawing.Point(12, 355);
            this.PedidosDGV.Name = "PedidosDGV";
            this.PedidosDGV.ReadOnly = true;
            this.PedidosDGV.RowHeadersWidth = 51;
            this.PedidosDGV.RowTemplate.Height = 24;
            this.PedidosDGV.Size = new System.Drawing.Size(1407, 233);
            this.PedidosDGV.TabIndex = 8;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 618);
            this.Controls.Add(this.PedidosDGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CantidadtextBox3;
        private System.Windows.Forms.TextBox ClientetextBox2;
        private System.Windows.Forms.TextBox CodigotextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TotaltextBox6;
        private System.Windows.Forms.TextBox ISVtextBox5;
        private System.Windows.Forms.TextBox SubTotaltextBox4;
        private System.Windows.Forms.DataGridView PedidosDGV;
        private System.Windows.Forms.TextBox ProductotextBox1;
        private System.Windows.Forms.Label label7;
    }
}