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
    public class VMmenu:BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        string _Saldo;
        string _Presupuesto;
        #endregion
        #region CONSTRUCTOR
        public VMmenu(INavigation navigation)
        {
            Navigation = navigation;
            mostrarPres();
            mostrarSaldo();
        }
        #endregion
        #region OBJETOS
        public string Saldo
        {
            get { return _Saldo; }
            set { SetValue(ref _Saldo, value); }
        }
        public string Presupuesto
        {
            get { return _Presupuesto; }
            set { SetValue(ref _Presupuesto, value); }
        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion
        #region PROCESOS

        public async Task Iringresoact()
        {
            await Navigation.PushAsync(new IngresarAct());
        }
        public async Task Iringreso()
        {
            await Navigation.PushAsync(new Vingreso());
        }
        public async Task Irretirar()
        {
            await Navigation.PushAsync(new Vretirar());
        }
        public async Task Irpresupuesto()
        {
            await Navigation.PushAsync(new Vpresupuesto());
        }

        public async Task mostrarSaldo()
        {
            Dgastos function = new Dgastos();
            var dt = await function.MostrarSaldo();
            Saldo = dt.Saldo;
        }

        public async Task mostrarPres()
        {
            Dpresupuesto function = new Dpresupuesto();
            var dt = await function.MostrarSaldo();
            Presupuesto = dt.Presupuesto;
        }

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand IringresoCommand => new Command(async () => await Iringreso());
        public ICommand IrretirarCommand => new Command(async () => await Irretirar());
        public ICommand IrpresupuestoCommand => new Command(async () => await Irpresupuesto());
        public ICommand IringresoactCommand => new Command(async () => await Iringresoact());

        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
