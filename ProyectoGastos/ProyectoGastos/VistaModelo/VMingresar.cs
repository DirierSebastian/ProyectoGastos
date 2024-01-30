using ProyectoGastos.Datos;
using ProyectoGastos.Modelo;
using ProyectoGastos.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoGastos.VistaModelo
{
    public class VMingresar : BaseViewModel
    {
        #region VARIABLES
        string _Saldo;
        string _Mensaje;

        #endregion
        #region CONSTRUCTOR
        public VMingresar(INavigation navigation)
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
        public string Saldo
        {
            get { return _Saldo; }
            set { SetValue(ref _Saldo, value);}
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PushAsync(new Vista.Menu());
        }
        public async Task IngresarSaldo()
        {
            Mmenu mSaldo = new Mmenu();
            Dgastos dgastos = new Dgastos();

            mSaldo.Saldo = _Saldo;
            await dgastos.InsertarSaldo(mSaldo);
            await Volver();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        public ICommand IngresarSaldoCommand => new Command(async () => await IngresarSaldo());

        #endregion
    }

}
