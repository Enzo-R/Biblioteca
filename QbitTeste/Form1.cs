using QbitTeste.Infra.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeQbit.Infra;
using testeQbit.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TextBox = System.Windows.Forms.TextBox;
using System.Threading;
using System.Runtime.InteropServices;
using testeQbit.View;

namespace QbitTeste
{
    public partial class Form1 : Form, IAlunos
    {
        Thread thread;
        Alunos alunos = new Alunos();

        public string NomeTxt 
        {
            get { return TxtNome.Text; } 
            set { TxtNome.Text = value; } 
        }
        public string EmailTxt 
        {
            get { return TxtEmail.Text; } 
            set { TxtEmail.Text = value; }
        }
        public string TelefoneTxt 
        { 
            get { return TxtTelefone.Text; }
            set { TxtTelefone.Text = value; }
        }
        public DateTime DataDeNascimentoData 
        { 
            get { return nascimentoDateTime.Value.Date; } 
            set { nascimentoDateTime.Value = value; } 
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            AlunosRepository alunosRepo = new AlunosRepository(this);

            if (TxtNome.Text != "" && EmailTxt != "")
            {
                if (nascimentoDateTime.Value.Date != DateTime.Today)
                {
                    _ = alunosRepo.Post();
                    MessageBox.Show("Conta cadastrada");
                    this.Close();

                    //reduzir consumo de recursos ao fechar janela de cadastro e utilizar uma nova janela 
                    thread = new Thread(abrirBiblioteca);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Preencha o campo com sua data de nascimento correta");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
            
        }

        public void abrirBiblioteca(object obj)
        {
            Application.Run(new Biblioteca());
        }
    }
}
