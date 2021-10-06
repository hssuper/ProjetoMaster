using ProjetoMaster.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoMaster
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            listview.ItemsSource = new List<produto>
            {
                new produto
                {
                img = "img/celular.png",
                descricao = "I Phone 12",
                valor = "R$ 5.000"
                },
                new produto
                {
                img = "img/celular.png",
                descricao = "I Phone 12",
                valor = "R$ 5.000"
                },
                new produto
                {
                img = "img/celular.png",
                descricao = "I Phone 12",
                valor = "R$ 5.000"
                },
                new produto
                {
                img = "img/celular.png",
                descricao = "I Phone 12",
                valor = "R$ 5.000"
                }

            };
            
            

           

        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var produto = e.SelectedItem as produto;
            Detail = new NavigationPage(new detalhes(produto));
            IsPresented = false;
        }
    }


}



