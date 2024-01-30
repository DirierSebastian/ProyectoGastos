using ProyectoGastos.Datos;
using ProyectoGastos.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoGastos.VistaModelo
{
    public class VMretirar : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        string _Saldo;

        #endregion
        #region CONSTRUCTOR
        public VMretirar(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public string Aux
        {
            get { return _Saldo; }
            set { SetValue(ref _Saldo, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public async Task Prueba()
        {
            Dgastos dgastos = new Dgastos();
            Daux daux = new Daux();
            var dt = await dgastos.MostrarSaldo();
            int saldo = Convert.ToInt32(dt.Saldo);
            int aux = Convert.ToInt32(Aux);
            int r = saldo - aux;
            Mmenu mmenu = new Mmenu();
            mmenu.Saldo = Convert.ToString(r);
            await dgastos.InsertarSaldo(mmenu);
            //return;
        }
        public async Task Actualizar()
        {
            await Prueba();
            await Volver();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        public ICommand IngresarAuxCommand => new Command(async () => await Actualizar());

        #endregion
    }

}
