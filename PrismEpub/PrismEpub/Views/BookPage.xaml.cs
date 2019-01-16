using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismEpub.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        public BookPage()
        {
            InitializeComponent();

            GetFrame(this.texto);

          //  frame.ch
            



        }

        private void GetFrame(Label texto)
        {
            
            var l = texto.Text;

            var id = texto.Id;

            var text = (frame.Children.Where(x => x.Id == id).FirstOrDefault() as Label).Text;

            
        }

       

        private void Texto_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            GetFrame((Label)sender);

        }
    }
}