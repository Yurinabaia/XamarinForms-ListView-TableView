using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Celulas.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void IrTextCell(object sender, EventArgs args) //Todo Botão possuir object sender, EventArgs args 
        {
            Navigation.PushAsync(new Paginas.TextCellPage());
        }
        private void IrImagemCell(object sender, EventArgs args)//Todo botão possuir object sender, EventArgs args
        {
            Navigation.PushAsync(new Paginas.ImageCellPage());
        } 
        private void IrEntryCell(object sender, EventArgs args ) //Todo botão possuir object sender, EventArgs args
        {
            Navigation.PushAsync(new Paginas.EntryCellPage());
        }
        private void IrSwitchCell(object sender, EventArgs args) //Todo botão possuir object sender, EventArgs args
        {
            Navigation.PushAsync(new Paginas.SwitchCellPage());
        } 
        private void IrViewCell(object sender, EventArgs args) //Todo botão possuir object sender, EventArgs args
        {
            Navigation.PushAsync(new Paginas.ViewCell());
        }     
        private void IrListView(object sender, EventArgs args) //Todo botão possuir object sender, EventArgs args
        {
            Navigation.PushAsync(new Paginas.ListViewPage());
        } 
        private void IrListViewButton(object sender, EventArgs args) //Todo botão possuir object sender, EventArgs args
        {
            Navigation.PushAsync(new Paginas.ListViewButtonPage());
        }
    }
}