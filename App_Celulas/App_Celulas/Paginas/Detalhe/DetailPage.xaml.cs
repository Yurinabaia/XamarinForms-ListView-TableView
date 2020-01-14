using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Celulas.Modelo;

namespace App_Celulas.Paginas.Detalhe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Funcionaios func)
        {
            InitializeComponent();
            NomeFuncionario.Text = func.Nome;
        }
    }
}