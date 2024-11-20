namespace PeajeRamirez
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dateTimeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox4 = new GroupBox();
            btnBuscar = new Button();
            txtbBuscar = new TextBox();
            label6 = new Label();
            btnVolver = new Button();
            groupBox5 = new GroupBox();
            btnActualizar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            btnIngresar = new Button();
            txtbCarril = new TextBox();
            txtbPersonas = new TextBox();
            txtbPatente = new TextBox();
            txtbModelo = new TextBox();
            txtbMarca = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            groupBox6 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(111, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 63);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(120, 45);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Paraná";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(47, 45);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "222";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(100, 19);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "ESTACION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(385, 34);
            label5.TabIndex = 1;
            label5.Text = "CONTROL VEHICULAR ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(311, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 63);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dateTimeLabel);
            groupBox3.Location = new Point(733, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(415, 63);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            dateTimeLabel.ForeColor = SystemColors.ButtonHighlight;
            dateTimeLabel.Location = new Point(17, 19);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(52, 20);
            dateTimeLabel.TabIndex = 5;
            dateTimeLabel.Text = "HORA";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.Controls.Add(btnBuscar);
            groupBox4.Controls.Add(txtbBuscar);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(btnVolver);
            groupBox4.Location = new Point(30, 85);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(451, 90);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSeaGreen;
            btnBuscar.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnBuscar.Location = new Point(338, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 55);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtbBuscar
            // 
            txtbBuscar.Location = new Point(16, 42);
            txtbBuscar.Name = "txtbBuscar";
            txtbBuscar.Size = new Size(301, 23);
            txtbBuscar.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(56, 19);
            label6.Name = "label6";
            label6.Size = new Size(240, 20);
            label6.TabIndex = 0;
            label6.Text = "INGRESE LA MARCA  O PATENTE";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(338, 19);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 55);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Visible = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnActualizar);
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(btnIngresar);
            groupBox5.Controls.Add(txtbCarril);
            groupBox5.Controls.Add(txtbPersonas);
            groupBox5.Controls.Add(txtbPatente);
            groupBox5.Controls.Add(txtbModelo);
            groupBox5.Controls.Add(txtbMarca);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label7);
            groupBox5.Location = new Point(30, 181);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(451, 383);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkSeaGreen;
            btnActualizar.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnActualizar.Location = new Point(35, 274);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(159, 60);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "ACTUALIZAR INGRESO";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(217, 197);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(8, 199);
            label12.Name = "label12";
            label12.Size = new Size(208, 20);
            label12.TabIndex = 16;
            label12.Text = "FECHA Y HORA DE INGRESO";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkSeaGreen;
            btnIngresar.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnIngresar.Location = new Point(268, 274);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 60);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "INGRESAR VEHICULO";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtbCarril
            // 
            txtbCarril.Location = new Point(320, 157);
            txtbCarril.Name = "txtbCarril";
            txtbCarril.Size = new Size(125, 23);
            txtbCarril.TabIndex = 7;
            // 
            // txtbPersonas
            // 
            txtbPersonas.Location = new Point(170, 154);
            txtbPersonas.Name = "txtbPersonas";
            txtbPersonas.Size = new Size(81, 23);
            txtbPersonas.TabIndex = 6;
            // 
            // txtbPatente
            // 
            txtbPatente.Location = new Point(85, 118);
            txtbPatente.Name = "txtbPatente";
            txtbPatente.Size = new Size(360, 23);
            txtbPatente.TabIndex = 5;
            // 
            // txtbModelo
            // 
            txtbModelo.Location = new Point(85, 76);
            txtbModelo.Name = "txtbModelo";
            txtbModelo.Size = new Size(360, 23);
            txtbModelo.TabIndex = 4;
            // 
            // txtbMarca
            // 
            txtbMarca.Location = new Point(85, 40);
            txtbMarca.Name = "txtbMarca";
            txtbMarca.Size = new Size(360, 23);
            txtbMarca.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(8, 117);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 9;
            label11.Text = "PATENTE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(8, 157);
            label10.Name = "label10";
            label10.Size = new Size(154, 20);
            label10.TabIndex = 8;
            label10.Text = "CANT DE PERSONAS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(257, 157);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 7;
            label9.Text = "CARRIL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(6, 75);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 6;
            label8.Text = "MODELO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(6, 43);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 5;
            label7.Text = "MARCA";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkSeaGreen;
            btnSalir.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(989, 576);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 60);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(497, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 469);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox6
            // 
            groupBox6.Location = new Point(30, 571);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(952, 64);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1180, 648);
            Controls.Add(btnSalir);
            Controls.Add(groupBox6);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Sistema de Registro Vehicular";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label dateTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox4;
        private TextBox txtbBuscar;
        private Label label6;
        private Button btnBuscar;
        private GroupBox groupBox5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label11;
        private Label label10;
        private Button btnIngresar;
        private TextBox txtbCarril;
        private TextBox txtbPersonas;
        private TextBox txtbPatente;
        private TextBox txtbModelo;
        private TextBox txtbMarca;
        private Label label12;
        private DataGridView dataGridView1;
        private GroupBox groupBox6;
        private Button btnSalir;
        private DateTimePicker dateTimePicker1;
        private Button btnActualizar;
        private Button btnVolver;
    }
}
