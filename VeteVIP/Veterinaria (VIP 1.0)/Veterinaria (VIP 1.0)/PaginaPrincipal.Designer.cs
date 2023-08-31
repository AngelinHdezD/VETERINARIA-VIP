namespace Veterinaria__VIP_1._0_
{
    partial class PaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            lblCarrito = new Label();
            pBCCompras = new PictureBox();
            btnVentas = new Button();
            pictureBox1 = new PictureBox();
            vScrollBar1 = new VScrollBar();
            pBEstetica = new PictureBox();
            pBMedicina = new PictureBox();
            LLsEstetico = new LinkLabel();
            LLsMedico = new LinkLabel();
            dateTimePicker1 = new DateTimePicker();
            btnMascota = new Button();
            btnUsuario = new Button();
            labCalendario = new Label();
            pictureBox2 = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            btnBuscador = new Button();
            txtBuscador = new TextBox();
            ImageVIP = new PictureBox();
            pictureBox6 = new PictureBox();
            lblNoticias = new Label();
            lblEMERGENCIA = new LinkLabel();
            btnSalir = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnForo = new Button();
            ((System.ComponentModel.ISupportInitialize)pBCCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBEstetica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBMedicina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageVIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblCarrito
            // 
            lblCarrito.AutoSize = true;
            lblCarrito.BackColor = Color.Transparent;
            lblCarrito.BorderStyle = BorderStyle.FixedSingle;
            lblCarrito.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarrito.ForeColor = Color.Khaki;
            lblCarrito.Location = new Point(709, 56);
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new Size(84, 37);
            lblCarrito.TabIndex = 95;
            lblCarrito.Text = "Carrito";
            // 
            // pBCCompras
            // 
            pBCCompras.BackColor = Color.Transparent;
            pBCCompras.Image = Properties.Resources._5087847;
            pBCCompras.Location = new Point(721, 91);
            pBCCompras.Name = "pBCCompras";
            pBCCompras.Size = new Size(59, 49);
            pBCCompras.SizeMode = PictureBoxSizeMode.StretchImage;
            pBCCompras.TabIndex = 94;
            pBCCompras.TabStop = false;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.Location = new Point(715, 138);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(78, 38);
            btnVentas.TabIndex = 93;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(258, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(592, 223);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 322);
            vScrollBar1.TabIndex = 90;
            // 
            // pBEstetica
            // 
            pBEstetica.Image = (Image)resources.GetObject("pBEstetica.Image");
            pBEstetica.Location = new Point(35, 358);
            pBEstetica.Name = "pBEstetica";
            pBEstetica.Size = new Size(184, 136);
            pBEstetica.SizeMode = PictureBoxSizeMode.StretchImage;
            pBEstetica.TabIndex = 89;
            pBEstetica.TabStop = false;
            // 
            // pBMedicina
            // 
            pBMedicina.Image = (Image)resources.GetObject("pBMedicina.Image");
            pBMedicina.Location = new Point(35, 201);
            pBMedicina.Name = "pBMedicina";
            pBMedicina.Size = new Size(184, 136);
            pBMedicina.SizeMode = PictureBoxSizeMode.StretchImage;
            pBMedicina.TabIndex = 88;
            pBMedicina.TabStop = false;
            // 
            // LLsEstetico
            // 
            LLsEstetico.AutoSize = true;
            LLsEstetico.LinkColor = Color.Yellow;
            LLsEstetico.Location = new Point(80, 504);
            LLsEstetico.Name = "LLsEstetico";
            LLsEstetico.Size = new Size(92, 15);
            LLsEstetico.TabIndex = 87;
            LLsEstetico.TabStop = true;
            LLsEstetico.Text = "Servicio Estético";
            LLsEstetico.LinkClicked += LLsEstetico_LinkClicked_1;
            // 
            // LLsMedico
            // 
            LLsMedico.AutoSize = true;
            LLsMedico.LinkColor = Color.Yellow;
            LLsMedico.Location = new Point(80, 340);
            LLsMedico.Name = "LLsMedico";
            LLsMedico.Size = new Size(91, 15);
            LLsMedico.TabIndex = 86;
            LLsMedico.TabStop = true;
            LLsMedico.Text = "Servicio Médico";
            LLsMedico.LinkClicked += LLsMedico_LinkClicked_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(634, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 85;
            // 
            // btnMascota
            // 
            btnMascota.BackColor = Color.Transparent;
            btnMascota.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMascota.ForeColor = Color.Black;
            btnMascota.Location = new Point(107, 138);
            btnMascota.Name = "btnMascota";
            btnMascota.Size = new Size(78, 38);
            btnMascota.TabIndex = 80;
            btnMascota.Text = "Mascota";
            btnMascota.UseVisualStyleBackColor = false;
            btnMascota.Click += btnMascota_Click_1;
            // 
            // btnUsuario
            // 
            btnUsuario.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuario.Location = new Point(23, 138);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(78, 38);
            btnUsuario.TabIndex = 79;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click_1;
            // 
            // labCalendario
            // 
            labCalendario.AutoSize = true;
            labCalendario.BorderStyle = BorderStyle.FixedSingle;
            labCalendario.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labCalendario.ForeColor = Color.Khaki;
            labCalendario.Location = new Point(681, 179);
            labCalendario.Name = "labCalendario";
            labCalendario.Size = new Size(121, 37);
            labCalendario.TabIndex = 78;
            labCalendario.Text = "Calendario";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(884, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 77;
            pictureBox2.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(618, 225);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 76;
            // 
            // btnBuscador
            // 
            btnBuscador.Location = new Point(220, 51);
            btnBuscador.Name = "btnBuscador";
            btnBuscador.Size = new Size(32, 31);
            btnBuscador.TabIndex = 75;
            btnBuscador.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscador.UseVisualStyleBackColor = true;
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = SystemColors.InactiveCaptionText;
            txtBuscador.ForeColor = SystemColors.Info;
            txtBuscador.Location = new Point(258, 56);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(358, 23);
            txtBuscador.TabIndex = 74;
            txtBuscador.Text = "Buscador...";
            // 
            // ImageVIP
            // 
            ImageVIP.BackColor = Color.Transparent;
            ImageVIP.Image = Properties.Resources.Sin_título_1;
            ImageVIP.Location = new Point(9, 10);
            ImageVIP.Name = "ImageVIP";
            ImageVIP.Size = new Size(162, 130);
            ImageVIP.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageVIP.TabIndex = 73;
            ImageVIP.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Sin_título_11;
            pictureBox6.Location = new Point(9, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(857, 535);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 72;
            pictureBox6.TabStop = false;
            // 
            // lblNoticias
            // 
            lblNoticias.AutoSize = true;
            lblNoticias.BorderStyle = BorderStyle.FixedSingle;
            lblNoticias.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoticias.ForeColor = Color.Khaki;
            lblNoticias.Location = new Point(383, 179);
            lblNoticias.Name = "lblNoticias";
            lblNoticias.Size = new Size(94, 37);
            lblNoticias.TabIndex = 96;
            lblNoticias.Text = "Noticias";
            // 
            // lblEMERGENCIA
            // 
            lblEMERGENCIA.AutoSize = true;
            lblEMERGENCIA.BackColor = Color.Gold;
            lblEMERGENCIA.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblEMERGENCIA.LinkColor = Color.Black;
            lblEMERGENCIA.Location = new Point(634, 440);
            lblEMERGENCIA.Name = "lblEMERGENCIA";
            lblEMERGENCIA.Size = new Size(224, 39);
            lblEMERGENCIA.TabIndex = 209;
            lblEMERGENCIA.TabStop = true;
            lblEMERGENCIA.Text = "ES UNA EMERGENCIA";
            lblEMERGENCIA.LinkClicked += lblEMERGENCIA_LinkClicked;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(687, 519);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 23);
            btnSalir.TabIndex = 210;
            btnSalir.Text = "Salir de la sesión";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnterior.Location = new Point(281, 183);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(29, 33);
            btnAnterior.TabIndex = 211;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiguiente.Location = new Point(538, 183);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(31, 33);
            btnSiguiente.TabIndex = 212;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnForo
            // 
            btnForo.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnForo.Location = new Point(191, 138);
            btnForo.Name = "btnForo";
            btnForo.Size = new Size(78, 38);
            btnForo.TabIndex = 213;
            btnForo.Text = "Foro";
            btnForo.UseVisualStyleBackColor = true;
            btnForo.Click += btnForo_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(872, 554);
            Controls.Add(btnForo);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnSalir);
            Controls.Add(lblEMERGENCIA);
            Controls.Add(lblNoticias);
            Controls.Add(lblCarrito);
            Controls.Add(pBCCompras);
            Controls.Add(btnVentas);
            Controls.Add(pictureBox1);
            Controls.Add(vScrollBar1);
            Controls.Add(pBEstetica);
            Controls.Add(pBMedicina);
            Controls.Add(LLsEstetico);
            Controls.Add(LLsMedico);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnMascota);
            Controls.Add(btnUsuario);
            Controls.Add(labCalendario);
            Controls.Add(pictureBox2);
            Controls.Add(monthCalendar1);
            Controls.Add(btnBuscador);
            Controls.Add(txtBuscador);
            Controls.Add(ImageVIP);
            Controls.Add(pictureBox6);
            MaximizeBox = false;
            Name = "PaginaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Principal";
            FormClosing += PaginaPrincipal_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pBCCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBEstetica).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBMedicina).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageVIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarrito;
        private PictureBox pBCCompras;
        private Button btnVentas;
        private PictureBox pictureBox1;
        private VScrollBar vScrollBar1;
        private PictureBox pBEstetica;
        private PictureBox pBMedicina;
        private LinkLabel LLsEstetico;
        private LinkLabel LLsMedico;
        private DateTimePicker dateTimePicker1;
        private Button btnMascota;
        private Button btnUsuario;
        private Label labCalendario;
        private PictureBox pictureBox2;
        private MonthCalendar monthCalendar1;
        private Button btnBuscador;
        private TextBox txtBuscador;
        private PictureBox ImageVIP;
        private PictureBox pictureBox6;
        private Label lblNoticias;
        private LinkLabel lblEMERGENCIA;
        private Button btnSalir;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnForo;
    }
}