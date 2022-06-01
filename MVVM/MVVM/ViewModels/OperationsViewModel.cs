using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class OperationsViewModel : ViewModelBase
    {
        #region Propiedades
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if(valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }
        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if(valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }
        int suma;
        public int ResultSuma
        {
            get { return suma; }
            set
            {
                if(suma != value)
                {
                    suma = value;
                    OnPropertyChanged();
                }
            }
        }
        int resta;
        public int ResultResta
        {
            get { return resta; }
            set
            {
                if(resta != value)
                {
                    resta = value;
                    OnPropertyChanged();
                }
            }
        }
        int multiplicar;
        public int ResultMultiplicar
        {
            get { return multiplicar; }
            set
            {
                if(multiplicar != value)
                {
                    multiplicar = value;
                    OnPropertyChanged();
                }
            }
        }
        int dividir;
        public int ResultDividir
        {
            get { return dividir; }
            set
            {
                if(dividir != value)
                {
                    dividir = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region Comandos
        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }
        #endregion
        #region Constructor
        public OperationsViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultSuma = valor1 + valor2;
            });
            Restar = new Command(() =>
            {
                ResultResta = valor1 - valor2;
            });
            Multiplicar = new Command(() =>
            {
                ResultMultiplicar = valor1 * valor2;
            });
            Dividir = new Command(() =>
            {
              if(valor2 != 0)
                {
                    ResultDividir = valor1 / valor2;
                }
                else
                {
                    ResultDividir = 0;
                }
            });
        }
        #endregion
    }

}
