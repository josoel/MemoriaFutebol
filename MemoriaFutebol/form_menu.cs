using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriaFutebol
{
    public partial class form_menu : Form
    {
        string pasta_images_sys = "";
        Image img_fundo;

        Image instrucoes_normal;
        Image instrucoes_high;
        Image jogar_normal;
        Image jogar_high;
        Image ranking_normal;
        Image ranking_high;
        Image sair_normal;
        Image sair_high;

        public form_menu()
        {
            InitializeComponent();
            //determina o endereço das imagens do sistema
            pasta_images_sys = Application.StartupPath + @"\sys_images\";
           
            
            //carregamento da imagem do fundo
            img_fundo = Image.FromFile(pasta_images_sys + "bg_principal.png");
            this.BackgroundImage = img_fundo;


            instrucoes_normal = Image.FromFile(pasta_images_sys + "instrucoes.png");
            instrucoes_high = Image.FromFile(pasta_images_sys + "instrucoes_h.png");

            jogar_normal = Image.FromFile(pasta_images_sys + "jogar.png");
            jogar_high = Image.FromFile(pasta_images_sys + "jogar_h.png");

            ranking_normal = Image.FromFile(pasta_images_sys + "ranking.png");
            ranking_high = Image.FromFile(pasta_images_sys + "ranking_h.png");

            sair_normal = Image.FromFile(pasta_images_sys + "x.png");
            sair_high = Image.FromFile(pasta_images_sys + "x_h.png");


        }

        private void form_menu_Load(object sender, EventArgs e)
        {
            btn_instrucoes.BackgroundImage = instrucoes_normal;

            btn_jogar.BackgroundImage = jogar_normal;

            btn_ranking.BackgroundImage = ranking_normal;

            btn_sair.BackgroundImage = sair_normal;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/abertura.wav");
            player.Play();
        }


        // função "hover" quando o mouse passa por cima dos botoes
        private void btn_instrucoes_MouseEnter(object sender, EventArgs e)
        {
            btn_instrucoes.BackgroundImage = instrucoes_high;
             System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/hover.wav");
            player.Play();
        }

        private void btn_instrucoes_MouseLeave(object sender, EventArgs e)
        {
            btn_instrucoes.BackgroundImage = instrucoes_normal;
        }

        private void btn_jogar_MouseEnter(object sender, EventArgs e)
        {
            btn_jogar.BackgroundImage = jogar_high;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/hover.wav");
            player.Play();
        }

        private void btn_jogar_MouseLeave(object sender, EventArgs e)
        {
            btn_jogar.BackgroundImage = jogar_normal;
        }

        private void btn_ranking_MouseEnter(object sender, EventArgs e)
        {
            btn_ranking.BackgroundImage = ranking_high;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/hover.wav");
            player.Play();
        }

        private void btn_ranking_MouseLeave(object sender, EventArgs e)
        {
            btn_ranking.BackgroundImage = ranking_normal;    
        }

        private void btn_sair_MouseEnter(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = sair_high;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/hover.wav");
            player.Play();
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = sair_normal;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/enter.wav");
            player.Play();
            Close();
        }

        private void btn_instrucoes_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/enter.wav");
            player.Play();
            form_instrucoes instrucoes = new form_instrucoes();
            instrucoes.ShowDialog();

        }

        private void btn_ranking_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/enter.wav");
            player.Play();
            ranking ranking = new ranking();
            ranking.ShowDialog();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/enter.wav");
            player.Play();
        }
    }
}
