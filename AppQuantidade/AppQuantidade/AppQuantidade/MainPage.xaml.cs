using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        int quantidade = 1;
        public MainPage()
        { 
            InitializeComponent();

        }

        private void Aumentar(object sender, EventArgs e)
        {
            quantidade++;
            lblQuantidade.Text = quantidade.ToString();
        }

        private void Diminuir(object sender, EventArgs e)
        {
            if(quantidade == 0)
            {
                DisplayAlert("Atenção", "A quantidade não pode ser menor que zero.", "OK");
                return;
            }
            quantidade--;
            lblQuantidade.Text = quantidade.ToString();
        }

        private async Task BtnSair_Clicked(object sender, EventArgs e)
        {
            var resultado = await DisplayAlert("Alerta", "Deseja realmente sair?", "Sim", "Não");

            if (resultado)
            {
                await Navigation.PopAsync();
            }
        }
    }
}
