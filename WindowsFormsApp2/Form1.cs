using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* 

Programar: Gustavo Gonçalves, 2º INFO.
Matéria: Desenvolvimento de Softwares - I
Professor: Rodrigo Garcia 

*/
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int contMicro = 0;
        Boolean portaAberta = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void dividirHoras()
        {
            //Fazer o visor ficar com horario HH:MM:SS (ex: 00:05:10 [5min e 10seg])
            int hor = (contMicro / (3600));
            int min = ((contMicro - (hor * 3600)) / 60);
            int seg = (contMicro - (hor * 3600) - (min * 60));            
            textBox1.Text = String.Format("{0:0,0}:{1:0,0}:{2:0,0}", hor, min, seg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load do Formulário principal
            pictureBox1.Image = WindowsFormsApp2.Properties.Resources._lock;
            this.dividirHoras();
        }

        private void timerMicro_Tick(object sender, EventArgs e)
        {
            //Função timer regressiva
            if (timerMicro.Enabled == true)
            {
                contMicro--;
                pictureBox1.Image = WindowsFormsApp2.Properties.Resources.auto;
                this.dividirHoras();
                if (contMicro == 0) 
                {
                    timerMicro.Enabled = false;
                    pictureBox1.Image = WindowsFormsApp2.Properties.Resources._lock;
                    label1.Text = "Fim.";
                    Console.Beep();
                    var result = MessageBox.Show("Fim.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnIniciar.Text = "Iniciar";
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        { 
            if (timerMicro.Enabled == false && portaAberta == false && this.contMicro > 0)
            {
                //Botao iniciar (muda o nome pra pausar)
                timerMicro.Enabled = true;
                pictureBox1.Image = WindowsFormsApp2.Properties.Resources.auto;
                btnIniciar.Text = "Pausar";
                label1.Text = "Rodando...";
            }
            else
            {
                //Botao pausar (muda o nome pra iniciar)
                timerMicro.Enabled = false;
                btnIniciar.Text = "Iniciar";
                if (contMicro > 0 && portaAberta == false) { label1.Text = "Pausado"; pictureBox1.Image = WindowsFormsApp2.Properties.Resources._lock; }
            }
        }

        private void btn10s_Click(object sender, EventArgs e)
        {
            //Botao 10s
            contMicro = contMicro + 10;
            this.dividirHoras();
        }

        private void btn10m_Click(object sender, EventArgs e)
        {
            //Botao 10min (600s)
            contMicro += 600;
            this.dividirHoras();
        }

        private void btnPipoca_Click(object sender, EventArgs e)
        {
            //Botao pipoca // 2:25
            contMicro += 165;
            this.dividirHoras();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            //Botao auto-aquecimento. // 2:45
            contMicro += 145;
            this.dividirHoras();
        }

        private void btnLeite_Click(object sender, EventArgs e)
        {
            //Botao leite // 1:10
            contMicro += 70;
            this.dividirHoras();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (portaAberta == false)
            {
                //Botao fechar
                pictureBox1.Image = WindowsFormsApp2.Properties.Resources.open;
                btnIniciar.Text = "Iniciar";
                timerMicro.Enabled = false;
                label1.Text = "Porta aberta.";
                btnAbrir.Text = "Fechar";
                portaAberta = true;
            }
            else
            {
                //Botao abrir
                pictureBox1.Image = WindowsFormsApp2.Properties.Resources._lock;
                label1.Text = "Porta fechada.";
                btnAbrir.Text = "Abrir";
                portaAberta = false;
            }
        }

        private void btn1min_Click(object sender, EventArgs e)
        {
            //Botao 1min
            contMicro += 60;
            this.dividirHoras();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (contMicro > 0)
            {

            }
            //Botao cancelar
            var result = MessageBox.Show("Você tem certeza que deseja cancelar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timerMicro.Enabled = false;
                contMicro = 0;
                this.dividirHoras();
                btnIniciar.Text = "Iniciar";
                label1.Text = "Cancelado.";
                pictureBox1.Image = WindowsFormsApp2.Properties.Resources.cancel;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
