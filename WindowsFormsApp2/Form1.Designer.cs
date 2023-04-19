namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMicro = new System.Windows.Forms.Timer(this.components);
            this.btn10s = new System.Windows.Forms.Button();
            this.btnPipoca = new System.Windows.Forms.Button();
            this.btn10m = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnLeite = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn1min = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMicro
            // 
            this.timerMicro.Interval = 1000;
            this.timerMicro.Tick += new System.EventHandler(this.timerMicro_Tick);
            // 
            // btn10s
            // 
            this.btn10s.BackColor = System.Drawing.Color.DimGray;
            this.btn10s.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn10s.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn10s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn10s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btn10s, "btn10s");
            this.btn10s.ForeColor = System.Drawing.Color.Black;
            this.btn10s.Name = "btn10s";
            this.btn10s.UseVisualStyleBackColor = false;
            this.btn10s.Click += new System.EventHandler(this.btn10s_Click);
            // 
            // btnPipoca
            // 
            this.btnPipoca.BackColor = System.Drawing.Color.DimGray;
            this.btnPipoca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPipoca.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPipoca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPipoca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnPipoca, "btnPipoca");
            this.btnPipoca.ForeColor = System.Drawing.Color.Black;
            this.btnPipoca.Name = "btnPipoca";
            this.btnPipoca.UseVisualStyleBackColor = false;
            this.btnPipoca.Click += new System.EventHandler(this.btnPipoca_Click);
            // 
            // btn10m
            // 
            this.btn10m.BackColor = System.Drawing.Color.DimGray;
            this.btn10m.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn10m.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn10m.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn10m.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btn10m, "btn10m");
            this.btn10m.ForeColor = System.Drawing.Color.Black;
            this.btn10m.Name = "btn10m";
            this.btn10m.UseVisualStyleBackColor = false;
            this.btn10m.Click += new System.EventHandler(this.btn10m_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.DimGray;
            this.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAbrir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnAbrir, "btnAbrir");
            this.btnAbrir.ForeColor = System.Drawing.Color.Black;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnLeite
            // 
            this.btnLeite.BackColor = System.Drawing.Color.DimGray;
            this.btnLeite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLeite.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLeite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnLeite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnLeite, "btnLeite");
            this.btnLeite.ForeColor = System.Drawing.Color.Black;
            this.btnLeite.Name = "btnLeite";
            this.btnLeite.UseVisualStyleBackColor = false;
            this.btnLeite.Click += new System.EventHandler(this.btnLeite_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Green;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn1min
            // 
            this.btn1min.BackColor = System.Drawing.Color.DimGray;
            this.btn1min.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1min.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn1min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn1min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btn1min, "btn1min");
            this.btn1min.ForeColor = System.Drawing.Color.Black;
            this.btn1min.Name = "btn1min";
            this.btn1min.UseVisualStyleBackColor = false;
            this.btn1min.Click += new System.EventHandler(this.btn1min_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.DimGray;
            this.btnAuto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAuto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnAuto, "btnAuto");
            this.btnAuto.ForeColor = System.Drawing.Color.Black;
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn10s);
            this.groupBox1.Controls.Add(this.btn1min);
            this.groupBox1.Controls.Add(this.btnAuto);
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btn10m);
            this.groupBox1.Controls.Add(this.btnPipoca);
            this.groupBox1.Controls.Add(this.btnLeite);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.cancel;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMicro;
        private System.Windows.Forms.Button btn10s;
        private System.Windows.Forms.Button btnPipoca;
        private System.Windows.Forms.Button btn10m;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnLeite;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btn1min;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

