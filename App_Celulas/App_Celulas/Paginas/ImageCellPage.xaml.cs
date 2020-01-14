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
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();
            List<Funcionaios> LISTA = new List<Funcionaios>();
            LISTA.Add(new Funcionaios { Foto= "https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-260nw-1556952626.jpg", Nome = "Maria", Cargo = "CEO" });
            LISTA.Add(new Funcionaios { Foto= "https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-260nw-1556952626.jpg", Nome = "Pedro", Cargo = "Gerente" });
            LISTA.Add(new Funcionaios { Foto= "https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-260nw-1556952626.jpg", Nome = "Juan", Cargo = "Assistente" });
            LISTA.Add(new Funcionaios { Foto= "https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-260nw-1556952626.jpg", Nome = "Thais", Cargo = "Analista" });
            LISTA.Add(new Funcionaios { Foto= "https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-260nw-1556952626.jpg", Nome = "Thamires", Cargo = "Analista Junior" });
            LISTA.Add(new Funcionaios { Foto= "https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-260nw-1556952626.jpg", Nome = "Kaka", Cargo = "Entregador" });
            ListaFuncionario.ItemsSource = LISTA;
        }
    }
}