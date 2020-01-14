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
    public partial class ViewCell : ContentPage
    {
        public ViewCell()
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
    }
}