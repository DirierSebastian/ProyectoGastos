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
    public class VMingresarAct : BaseViewModel
    {
        #region VARIABLES
        string _Saldo;
        string _Mensaje;
        string _valor;

        #endregion
        #region CONSTRUCTOR
        public VMingresarAct(INavigation navigation)
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
            await Navigation.PushAsync(new Vista.Menu());
        }
        public async Task Prueba()
        {
            Dgastos dgastos = new Dgastos();
            Daux daux = new Daux();
            var dt = await dgastos.MostrarSaldo();
            int saldo = Convert.ToInt32(dt.Saldo);
            int aux = Convert.ToInt32(Aux);
            int r = saldo + aux;
            Mmenu mmenu = new Mmenu();
            mmenu.Saldo = Convert.ToString(r);
            await dgastos.InsertarSaldo(mmenu);
            //return;
        }
        /*public async Task Ingresar()
        {
            Maux mSaldo = new Maux();
            Daux daux = new Daux();
            mSaldo.Aux = _Saldo;
            await daux.InsertarSaldo(mSaldo);
            return;
        }*/
        public async Task Actualizar()
        {
            //await Ingresar();
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