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
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
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
        private void ItemSelecionado(object sender, SelectedItemChangedEventArgs args)//Neste caso todo ItemSelected="ItemSelecionado" e usado os 
            //Comandos object sender, SelectedItemChangedEventArgs args
        {
            Funcionaios func = (Funcionaios)args.SelectedItem;//Aqui definimos a seleção do funcionario
            //Atraves do click que o usuario deu na lista
            //(Funcionaios)args.SelectedItem;  ISSO SE CHAMAR CAST
            Navigation.PushAsync(new Detalhe.DetailPage(func));//Aqui estamos passando para outra pagina
            //Onde ira ficar responsavel pela aparece o campo Funcionario
           
        }
        private void FeriasAction(object sender, EventArgs args)  //Todo MenuItem possuir um object sender, EventArgs args
        {
            MenuItem bot = (MenuItem)sender;//Aqui temos um cast que definir o elemento que foi clickado
            Funcionaios func = (Funcionaios)bot.CommandParameter;//Aqui estamos selecionando o elemento clickado
            //Atraves da propriedade do MenuItem CommandParameter
            DisplayAlert("Titulo: " + func.Nome, "Mensagem: " + func.Nome + " - " + func.Cargo, "ok");
        }  
        private void AbonoAction(object sender, EventArgs args)  //Todo MenuItem possuir um object sender, EventArgs args
        { 
                
        }
    }
}