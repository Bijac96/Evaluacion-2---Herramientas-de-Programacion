namespace Bastian_Alonso
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbRutEx = new System.Windows.Forms.ComboBox();
            this.txtEmailEx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelularEx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreEx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBoxBarba = new System.Windows.Forms.CheckBox();
            this.chkBoxCabello = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstViewReservas = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnIngresar);
            this.tabPage1.Controls.Add(this.cmbHora);
            this.tabPage1.Controls.Add(this.Calendar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chkBoxBarba);
            this.tabPage1.Controls.Add(this.chkBoxCabello);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Reservas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.cmbRutEx);
            this.groupBox2.Controls.Add(this.txtEmailEx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCelularEx);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNombreEx);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(398, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 181);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente Existente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(240, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbRutEx
            // 
            this.cmbRutEx.FormattingEnabled = true;
            this.cmbRutEx.Location = new System.Drawing.Point(102, 31);
            this.cmbRutEx.Name = "cmbRutEx";
            this.cmbRutEx.Size = new System.Drawing.Size(121, 23);
            this.cmbRutEx.TabIndex = 10;
            // 
            // txtEmailEx
            // 
            this.txtEmailEx.Location = new System.Drawing.Point(102, 118);
            this.txtEmailEx.Name = "txtEmailEx";
            this.txtEmailEx.Size = new System.Drawing.Size(174, 23);
            this.txtEmailEx.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre";
            // 
            // txtCelularEx
            // 
            this.txtCelularEx.Location = new System.Drawing.Point(102, 89);
            this.txtCelularEx.Name = "txtCelularEx";
            this.txtCelularEx.Size = new System.Drawing.Size(100, 23);
            this.txtCelularEx.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "E-Mail";
            // 
            // txtNombreEx
            // 
            this.txtNombreEx.Location = new System.Drawing.Point(102, 60);
            this.txtNombreEx.Name = "txtNombreEx";
            this.txtNombreEx.Size = new System.Drawing.Size(174, 23);
            this.txtNombreEx.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "RUT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(30, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 181);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente Nuevo";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(99, 89);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 23);
            this.txtCelular.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(99, 31);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 23);
            this.txtRut.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "RUT";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(559, 153);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 24);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(421, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 24);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(421, 105);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(264, 32);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar Reserva";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00"});
            this.cmbHora.Location = new System.Drawing.Point(421, 47);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 23);
            this.cmbHora.TabIndex = 5;
            this.cmbHora.Text = "HORA:";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(129, 47);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha y Hora:";
            // 
            // chkBoxBarba
            // 
            this.chkBoxBarba.AutoSize = true;
            this.chkBoxBarba.Location = new System.Drawing.Point(467, 17);
            this.chkBoxBarba.Name = "chkBoxBarba";
            this.chkBoxBarba.Size = new System.Drawing.Size(56, 19);
            this.chkBoxBarba.TabIndex = 2;
            this.chkBoxBarba.Text = "Barba";
            this.chkBoxBarba.UseVisualStyleBackColor = true;
            // 
            // chkBoxCabello
            // 
            this.chkBoxCabello.AutoSize = true;
            this.chkBoxCabello.Location = new System.Drawing.Point(370, 16);
            this.chkBoxCabello.Name = "chkBoxCabello";
            this.chkBoxCabello.Size = new System.Drawing.Size(66, 19);
            this.chkBoxCabello.TabIndex = 1;
            this.chkBoxCabello.Text = "Cabello";
            this.chkBoxCabello.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Atención:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstViewReservas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mostrar Reservas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstViewReservas
            // 
            this.lstViewReservas.Location = new System.Drawing.Point(6, 6);
            this.lstViewReservas.Name = "lstViewReservas";
            this.lstViewReservas.Size = new System.Drawing.Size(758, 427);
            this.lstViewReservas.TabIndex = 0;
            this.lstViewReservas.UseCompatibleStateImageBehavior = false;
            this.lstViewReservas.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Barbería";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MonthCalendar Calendar;
        private Label label2;
        private CheckBox chkBoxBarba;
        private CheckBox chkBoxCabello;
        private Label label1;
        private ComboBox cmbHora;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnIngresar;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private TextBox txtNombre;
        private TextBox txtRut;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtEmailEx;
        private Label label7;
        private TextBox txtCelularEx;
        private Label label8;
        private TextBox txtNombreEx;
        private Label label9;
        private Label label10;
        private Button btnBuscar;
        private ComboBox cmbRutEx;
        private ListView lstViewReservas;
    }
}