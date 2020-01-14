using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Celulas.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Celulas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
        {
            InitializeComponent();
            List<Funcionaios> LISTA = new List<Funcionaios>();
            LISTA.Add(new Funcionaios { Nome = "Maria", Cargo = "CEO" });
            LISTA.Add(new Funcionaios { Nome = "Pedro", Cargo = "Gerente" });
            LISTA.Add(new Funcionaios { Nome = "Juan", Cargo = "Assistente" });
            LISTA.Add(new Funcionaios { Nome = "Thais", Cargo = "Analista" });
            LISTA.Add(new Funcionaios { Nome = "Thamires", Cargo = "Analista Junior" });
            LISTA.Add(new Funcionaios { Nome = "Kaka", Cargo = "Entregador" });
            ListaFuncionario.ItemsSource = LISTA;
        }
        private void FeriasAction(object sender, EventArgs args) //Todo botão possuir um object sender, EventArgs args 
        {
           Button ferias = (Button)sender;//Este cast simboliza o valor que o sender vai receber
           Funcionaios fun = (Funcionaios)ferias.CommandParameter; //Aqui estamos pegando o valor selecionado na lista
            //No caso este valor é um botão
            DisplayAlert("Ferias", "Funcionarios: " + fun.Nome, "OK");//Aqui definimos alerta a ser gerado quando for clickado no botão
        }
    }
}