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
    public partial class form_instrucoes : Form
    {

        string pasta_images_sys = "";
        Image img_fundo;
        Image sair_normal;
        Image sair_high;

        public form_instrucoes()
        {
            InitializeComponent();
            //determina o endereço das imagens do sistema
            pasta_images_sys = Application.StartupPath + @"\sys_images\";


            //carregamento da imagem do fundo
            img_fundo = Image.FromFile(pasta_images_sys + "bg_game.png");
            this.BackgroundImage = img_fundo;

            sair_normal = Image.FromFile(pasta_images_sys + "x.png");
            sair_high = Image.FromFile(pasta_images_sys + "x_h.png");

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/sair.wav");
            player.Play();
            this.Close();
        }

        private void form_instrucoes_Load(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = sair_normal;
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = sair_normal;
        }

        private void btn_sair_MouseEnter(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = sair_high;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/hover.wav");
            player.Play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
