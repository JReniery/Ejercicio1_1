using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();            
    }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            Datos(0);
        }

        private void btnResta_Clicked(object sender, EventArgs e)
        {
            Datos(1);
        }

        private void btnDiv_Clicked(object sender, EventArgs e)
        {
            Datos(2);
        }

        private void btnMult_Clicked(object sender, EventArgs e)
        {
            Datos(3);
        }       
        
        private void Datos(int op)
        {
            float num1 = (float)Convert.ToDouble(txbNum1.Text);
            float num2 = (float)Convert.ToDouble(txbNum2.Text);

            if (op == 2 && num2 == 0)
            {
                DisplayAlert("Aviso", "No se puede dividir entre cero", "OK");
            }
            else
            {
                Navigation.PushAsync(new ResultPage(op, num1, num2));
            }            
        }
    }
}
