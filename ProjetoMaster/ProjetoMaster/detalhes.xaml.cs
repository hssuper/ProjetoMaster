using ProjetoMaster.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoMaster
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detalhes : ContentPage
    {
        

        public detalhes(Object produto)
        {
            if (produto == null)
            {
                throw new ArgumentNullException();
            }
            BindingContext = produto;
            InitializeComponent();
        }

        
    }
}