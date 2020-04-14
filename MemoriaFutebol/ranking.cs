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
    public partial class ranking : Form
    {

        string pasta_images_sys = "";
        Image img_fundo;
        Image sair_normal;
        Image sair_high;

        public ranking()
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

        private void ranking_Load(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = sair_normal;
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sys_sounds/sair.wav");
            player.Play();
            this.Close();
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
    }
}
