namespace MemoriaFutebol
{
    partial class form_menu
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
            this.btn_instrucoes = new System.Windows.Forms.PictureBox();
            this.btn_jogar = new System.Windows.Forms.PictureBox();
            this.btn_ranking = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_instrucoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_jogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ranking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_instrucoes
            // 
            this.btn_instrucoes.BackColor = System.Drawing.Color.Transparent;
            this.btn_instrucoes.Location = new System.Drawing.Point(203, 538);
            this.btn_instrucoes.Name = "btn_instrucoes";
            this.btn_instrucoes.Size = new System.Drawing.Size(245, 85);
            this.btn_instrucoes.TabIndex = 0;
            this.btn_instrucoes.TabStop = false;
            this.btn_instrucoes.Click += new System.EventHandler(this.btn_instrucoes_Click);
            this.btn_instrucoes.MouseEnter += new System.EventHandler(this.btn_instrucoes_MouseEnter);
            this.btn_instrucoes.MouseLeave += new System.EventHandler(this.btn_instrucoes_MouseLeave);
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.Color.Transparent;
            this.btn_jogar.Location = new System.Drawing.Point(454, 538);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(245, 85);
            this.btn_jogar.TabIndex = 1;
            this.btn_jogar.TabStop = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            this.btn_jogar.MouseEnter += new System.EventHandler(this.btn_jogar_MouseEnter);
            this.btn_jogar.MouseLeave += new System.EventHandler(this.btn_jogar_MouseLeave);
            // 
            // btn_ranking
            // 
            this.btn_ranking.BackColor = System.Drawing.Color.Transparent;
            this.btn_ranking.Location = new System.Drawing.Point(705, 538);
            this.btn_ranking.Name = "btn_ranking";
            this.btn_ranking.Size = new System.Drawing.Size(245, 85);
            this.btn_ranking.TabIndex = 2;
            this.btn_ranking.TabStop = false;
            this.btn_ranking.Click += new System.EventHandler(this.btn_ranking_Click);
            this.btn_ranking.MouseEnter += new System.EventHandler(this.btn_ranking_MouseEnter);
            this.btn_ranking.MouseLeave += new System.EventHandler(this.btn_ranking_MouseLeave);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.Location = new System.Drawing.Point(1064, 62);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(61, 65);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.TabStop = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            this.btn_sair.MouseEnter += new System.EventHandler(this.btn_sair_MouseEnter);
            this.btn_sair.MouseLeave += new System.EventHandler(this.btn_sair_MouseLeave);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1174, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_ranking);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.btn_instrucoes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.form_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_instrucoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_jogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ranking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_instrucoes;
        private System.Windows.Forms.PictureBox btn_jogar;
        private System.Windows.Forms.PictureBox btn_ranking;
        private System.Windows.Forms.PictureBox btn_sair;
    }
}

