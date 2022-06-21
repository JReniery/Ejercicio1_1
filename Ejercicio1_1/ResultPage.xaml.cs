using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage()
        {
            InitializeComponent();
        }
        public ResultPage(int op, float num1, float num2)
        {
            InitializeComponent();
            Calcular(op, num1, num2);
        }

        public void Calcular(int op, float valor1, float valor2)
        {
            var resultado = 0f;
            if (op == 0)
            {
                resultado = valor1 + valor2;
            }
            else if (op == 1)
            {
                resultado = valor1 - valor2;
            }
            else if (op == 2)
            {                
                resultado = valor1 / valor2;                
            }
            else if (op == 3)
            {
                resultado = valor1 * valor2;
            }
            lblResult.Text = resultado.ToString();
        }
    }
}