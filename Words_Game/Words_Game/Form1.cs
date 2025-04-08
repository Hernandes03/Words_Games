using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Words_Game
{
    public partial class formInicial : Form
    {
        //criando um método para chamar a outra tela e fechar
        Thread th;
        public formInicial()
        {
            InitializeComponent();
        }

        private void formInicial_Load(object sender, EventArgs e)
        {
            
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão Inicia, a primeira janela se fecha e abre a tela do jogo.
            this.Close();
            th = new Thread(formJogo);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void formJogo(object? obj)
        {
            //chamando método
            Application.Run(new Form2());
        }
    }
}
