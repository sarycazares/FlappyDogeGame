namespace FlappyBird_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label_Puntuacion = new System.Windows.Forms.Label();
            this.pictureBox_Barrera = new System.Windows.Forms.PictureBox();
            this.pictureBox_Doge = new System.Windows.Forms.PictureBox();
            this.pictureBox_TuboArriba = new System.Windows.Forms.PictureBox();
            this.pictureBox_TuboAbajo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_BarreraArriba = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Barrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Doge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TuboArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TuboAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BarreraArriba)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label_Puntuacion
            // 
            this.label_Puntuacion.AutoSize = true;
            this.label_Puntuacion.BackColor = System.Drawing.Color.ForestGreen;
            this.label_Puntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Puntuacion.ForeColor = System.Drawing.Color.White;
            this.label_Puntuacion.Location = new System.Drawing.Point(12, 9);
            this.label_Puntuacion.Name = "label_Puntuacion";
            this.label_Puntuacion.Size = new System.Drawing.Size(24, 25);
            this.label_Puntuacion.TabIndex = 5;
            this.label_Puntuacion.Text = "0";
            // 
            // pictureBox_Barrera
            // 
            this.pictureBox_Barrera.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_Barrera.BackgroundImage = global::FlappyBird_Game.Properties.Resources.barra;
            this.pictureBox_Barrera.Location = new System.Drawing.Point(-274, 443);
            this.pictureBox_Barrera.Name = "pictureBox_Barrera";
            this.pictureBox_Barrera.Size = new System.Drawing.Size(779, 24);
            this.pictureBox_Barrera.TabIndex = 4;
            this.pictureBox_Barrera.TabStop = false;
            // 
            // pictureBox_Doge
            // 
            this.pictureBox_Doge.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Doge.Image = global::FlappyBird_Game.Properties.Resources.doge_normal;
            this.pictureBox_Doge.Location = new System.Drawing.Point(17, 186);
            this.pictureBox_Doge.Name = "pictureBox_Doge";
            this.pictureBox_Doge.Size = new System.Drawing.Size(88, 73);
            this.pictureBox_Doge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Doge.TabIndex = 3;
            this.pictureBox_Doge.TabStop = false;
            // 
            // pictureBox_TuboArriba
            // 
            this.pictureBox_TuboArriba.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_TuboArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_TuboArriba.Image = global::FlappyBird_Game.Properties.Resources.tuboflappy_arriba;
            this.pictureBox_TuboArriba.Location = new System.Drawing.Point(154, -104);
            this.pictureBox_TuboArriba.Name = "pictureBox_TuboArriba";
            this.pictureBox_TuboArriba.Size = new System.Drawing.Size(100, 280);
            this.pictureBox_TuboArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TuboArriba.TabIndex = 2;
            this.pictureBox_TuboArriba.TabStop = false;
            // 
            // pictureBox_TuboAbajo
            // 
            this.pictureBox_TuboAbajo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_TuboAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_TuboAbajo.Image = global::FlappyBird_Game.Properties.Resources.tuboflappy;
            this.pictureBox_TuboAbajo.Location = new System.Drawing.Point(154, 288);
            this.pictureBox_TuboAbajo.Name = "pictureBox_TuboAbajo";
            this.pictureBox_TuboAbajo.Size = new System.Drawing.Size(100, 357);
            this.pictureBox_TuboAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TuboAbajo.TabIndex = 1;
            this.pictureBox_TuboAbajo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 51);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Image = global::FlappyBird_Game.Properties.Resources.letrasdoge;
            this.pictureBox2.Location = new System.Drawing.Point(65, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_BarreraArriba
            // 
            this.pictureBox_BarreraArriba.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_BarreraArriba.BackgroundImage = global::FlappyBird_Game.Properties.Resources.barra;
            this.pictureBox_BarreraArriba.Location = new System.Drawing.Point(-236, -16);
            this.pictureBox_BarreraArriba.Name = "pictureBox_BarreraArriba";
            this.pictureBox_BarreraArriba.Size = new System.Drawing.Size(779, 24);
            this.pictureBox_BarreraArriba.TabIndex = 8;
            this.pictureBox_BarreraArriba.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 7);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(204, 7);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label2.Size = new System.Drawing.Size(34, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::FlappyBird_Game.Properties.Resources.ciudad_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(292, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_Puntuacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_Barrera);
            this.Controls.Add(this.pictureBox_Doge);
            this.Controls.Add(this.pictureBox_TuboArriba);
            this.Controls.Add(this.pictureBox_TuboAbajo);
            this.Controls.Add(this.pictureBox_BarreraArriba);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLAPPY DOGE";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Barrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Doge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TuboArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TuboAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BarreraArriba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_TuboAbajo;
        private System.Windows.Forms.PictureBox pictureBox_TuboArriba;
        private System.Windows.Forms.PictureBox pictureBox_Doge;
        private System.Windows.Forms.PictureBox pictureBox_Barrera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label_Puntuacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_BarreraArriba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

