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
    public class VMpresupuesto : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        string _Presupuesto;
        #endregion
        #region CONSTRUCTOR
        public VMpresupuesto(INavigation navigation)
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
        public string Presupuesto
        {
            get { return _Presupuesto; }
            set { SetValue(ref _Presupuesto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public async Task IngresarPresupuesto()
        {
            Mpresupuesto pres = new Mpresupuesto();
            Dpresupuesto dpres = new Dpresupuesto();

            pres.Presupuesto = _Presupuesto;
            await dpres.InsertarSaldo(pres);
            await Volver();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        public ICommand EstablecerCommand => new Command(async () => await IngresarPresupuesto());

        #endregion
    }

}
