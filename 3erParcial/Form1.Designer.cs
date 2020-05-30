namespace _3erParcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.centro = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.alcalde = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.poblacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.agregar_caracteristica = new System.Windows.Forms.Button();
            this.caracteristicas = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCaracteristica = new System.Windows.Forms.TextBox();
            this.agregar_registro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.capital = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.new_column = new System.Windows.Forms.Label();
            this.new_column_value = new System.Windows.Forms.TextBox();
            this.elegir_ciudad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.modificar_caracteristicas = new System.Windows.Forms.Button();
            this.Eliminar_renglon = new System.Windows.Forms.Button();
            this.dato_especifico = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dato = new System.Windows.Forms.CheckBox();
            this.remplazar = new System.Windows.Forms.Button();
            this.display_info = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alcalde";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poblacion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // centro
            // 
            this.centro.AutoSize = true;
            this.centro.Location = new System.Drawing.Point(216, 52);
            this.centro.Name = "centro";
            this.centro.Size = new System.Drawing.Size(38, 13);
            this.centro.TabIndex = 4;
            this.centro.Text = "Centro";
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(13, 69);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(59, 20);
            this.ciudad.TabIndex = 5;
            // 
            // alcalde
            // 
            this.alcalde.Location = new System.Drawing.Point(97, 69);
            this.alcalde.Name = "alcalde";
            this.alcalde.Size = new System.Drawing.Size(100, 20);
            this.alcalde.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 7;
            // 
            // poblacion
            // 
            this.poblacion.Location = new System.Drawing.Point(215, 199);
            this.poblacion.Name = "poblacion";
            this.poblacion.Size = new System.Drawing.Size(77, 20);
            this.poblacion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Caracteristicas";
            // 
            // agregar_caracteristica
            // 
            this.agregar_caracteristica.Location = new System.Drawing.Point(12, 250);
            this.agregar_caracteristica.Name = "agregar_caracteristica";
            this.agregar_caracteristica.Size = new System.Drawing.Size(75, 23);
            this.agregar_caracteristica.TabIndex = 10;
            this.agregar_caracteristica.Text = "Agregar";
            this.agregar_caracteristica.UseVisualStyleBackColor = true;
            this.agregar_caracteristica.Click += new System.EventHandler(this.agregar_caracteristica_Click);
            // 
            // caracteristicas
            // 
            this.caracteristicas.FormattingEnabled = true;
            this.caracteristicas.Location = new System.Drawing.Point(15, 149);
            this.caracteristicas.Name = "caracteristicas";
            this.caracteristicas.Size = new System.Drawing.Size(157, 95);
            this.caracteristicas.TabIndex = 11;
            this.caracteristicas.SelectedIndexChanged += new System.EventHandler(this.caracteristicas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. Hospitales";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 13;
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Location = new System.Drawing.Point(97, 120);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(75, 20);
            this.txtCaracteristica.TabIndex = 14;
            // 
            // agregar_registro
            // 
            this.agregar_registro.Location = new System.Drawing.Point(13, 315);
            this.agregar_registro.Name = "agregar_registro";
            this.agregar_registro.Size = new System.Drawing.Size(148, 23);
            this.agregar_registro.TabIndex = 15;
            this.agregar_registro.Text = "Registrar";
            this.agregar_registro.UseVisualStyleBackColor = true;
            this.agregar_registro.Click += new System.EventHandler(this.agregar_registro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nombre de nueva columna y tipo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // capital
            // 
            this.capital.Location = new System.Drawing.Point(219, 69);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(100, 20);
            this.capital.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar Columna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // new_column
            // 
            this.new_column.AutoSize = true;
            this.new_column.Location = new System.Drawing.Point(216, 260);
            this.new_column.Name = "new_column";
            this.new_column.Size = new System.Drawing.Size(0, 13);
            this.new_column.TabIndex = 20;
            // 
            // new_column_value
            // 
            this.new_column_value.Enabled = false;
            this.new_column_value.Location = new System.Drawing.Point(242, 289);
            this.new_column_value.Name = "new_column_value";
            this.new_column_value.Size = new System.Drawing.Size(110, 20);
            this.new_column_value.TabIndex = 21;
            // 
            // elegir_ciudad
            // 
            this.elegir_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elegir_ciudad.FormattingEnabled = true;
            this.elegir_ciudad.Location = new System.Drawing.Point(334, 69);
            this.elegir_ciudad.Name = "elegir_ciudad";
            this.elegir_ciudad.Size = new System.Drawing.Size(121, 21);
            this.elegir_ciudad.TabIndex = 23;
            this.elegir_ciudad.SelectedIndexChanged += new System.EventHandler(this.elegir_ciudad_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Elegir Ciudad";
            // 
            // modificar_caracteristicas
            // 
            this.modificar_caracteristicas.Location = new System.Drawing.Point(13, 279);
            this.modificar_caracteristicas.Name = "modificar_caracteristicas";
            this.modificar_caracteristicas.Size = new System.Drawing.Size(184, 23);
            this.modificar_caracteristicas.TabIndex = 25;
            this.modificar_caracteristicas.Text = "Modificar Caracteristicas";
            this.modificar_caracteristicas.UseVisualStyleBackColor = true;
            this.modificar_caracteristicas.Click += new System.EventHandler(this.modificar_caracteristicas_Click);
            // 
            // Eliminar_renglon
            // 
            this.Eliminar_renglon.Location = new System.Drawing.Point(462, 67);
            this.Eliminar_renglon.Name = "Eliminar_renglon";
            this.Eliminar_renglon.Size = new System.Drawing.Size(87, 23);
            this.Eliminar_renglon.TabIndex = 26;
            this.Eliminar_renglon.Text = "Eliminar renglon";
            this.Eliminar_renglon.UseVisualStyleBackColor = true;
            this.Eliminar_renglon.Click += new System.EventHandler(this.Eliminar_renglon_Click);
            // 
            // dato_especifico
            // 
            this.dato_especifico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dato_especifico.Enabled = false;
            this.dato_especifico.FormattingEnabled = true;
            this.dato_especifico.Location = new System.Drawing.Point(334, 138);
            this.dato_especifico.Name = "dato_especifico";
            this.dato_especifico.Size = new System.Drawing.Size(121, 21);
            this.dato_especifico.TabIndex = 27;
            this.dato_especifico.SelectedIndexChanged += new System.EventHandler(this.dato_especifico_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Escoger Dato";
            // 
            // Dato
            // 
            this.Dato.AutoSize = true;
            this.Dato.Location = new System.Drawing.Point(461, 138);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(88, 17);
            this.Dato.TabIndex = 30;
            this.Dato.Text = "Eliminar Dato";
            this.Dato.UseVisualStyleBackColor = true;
            this.Dato.CheckedChanged += new System.EventHandler(this.Dato_CheckedChanged);
            // 
            // remplazar
            // 
            this.remplazar.Location = new System.Drawing.Point(12, 355);
            this.remplazar.Name = "remplazar";
            this.remplazar.Size = new System.Drawing.Size(149, 23);
            this.remplazar.TabIndex = 31;
            this.remplazar.Text = "Remplazar informacion";
            this.remplazar.UseVisualStyleBackColor = true;
            this.remplazar.Click += new System.EventHandler(this.remplazar_Click);
            // 
            // display_info
            // 
            this.display_info.Location = new System.Drawing.Point(168, 355);
            this.display_info.Name = "display_info";
            this.display_info.Size = new System.Drawing.Size(136, 23);
            this.display_info.TabIndex = 33;
            this.display_info.Text = "Mostrar datos";
            this.display_info.UseVisualStyleBackColor = true;
            this.display_info.Click += new System.EventHandler(this.display_info_Click);
            // 
            // data
            // 
            this.data.FormattingEnabled = true;
            this.data.Location = new System.Drawing.Point(16, 432);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(502, 95);
            this.data.TabIndex = 34;
            this.data.SelectedIndexChanged += new System.EventHandler(this.data_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 575);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 150);
            this.dataGridView1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 790);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.display_info);
            this.Controls.Add(this.remplazar);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dato_especifico);
            this.Controls.Add(this.Eliminar_renglon);
            this.Controls.Add(this.modificar_caracteristicas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.elegir_ciudad);
            this.Controls.Add(this.new_column_value);
            this.Controls.Add(this.new_column);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.capital);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.agregar_registro);
            this.Controls.Add(this.txtCaracteristica);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.caracteristicas);
            this.Controls.Add(this.agregar_caracteristica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.poblacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.alcalde);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.centro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "3er Parcial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label centro;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.TextBox alcalde;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox poblacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button agregar_caracteristica;
        private System.Windows.Forms.ListBox caracteristicas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCaracteristica;
        private System.Windows.Forms.Button agregar_registro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox capital;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label new_column;
        private System.Windows.Forms.TextBox new_column_value;
        private System.Windows.Forms.ComboBox elegir_ciudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button modificar_caracteristicas;
        private System.Windows.Forms.Button Eliminar_renglon;
        private System.Windows.Forms.ComboBox dato_especifico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Dato;
        private System.Windows.Forms.Button remplazar;
        private System.Windows.Forms.Button display_info;
        private System.Windows.Forms.ListBox data;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

