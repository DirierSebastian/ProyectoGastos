using ProyectoGastos.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using Firebase.Database;
using ProyectoGastos.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Runtime.InteropServices;

namespace ProyectoGastos.Datos
{
    public class Dpresupuesto
    {
        Mpresupuesto Lpresupesto = new Mpresupuesto();
        string idpresupuesto;
        public async Task<string> InsertarSaldo(Mpresupuesto parametros)
        {
            var data = await Cconexion.firebase
                .Child("Gastos")
                .Child("ModeloP")
                .PostAsync(new Mpresupuesto()
                {
                    Presupuesto = parametros.Presupuesto
                });
            idpresupuesto = data.Key;
            return idpresupuesto;
        }

        public async Task<Mpresupuesto> MostrarSaldo()
        {

            var Tpres = await Cconexion.firebase
                .Child("Gastos")
                .Child("ModeloP")
                .OnceAsync<Mpresupuesto>();
            foreach (var pres in Tpres)
            {
                Mpresupuesto Mpresup = new Mpresupuesto();
                Mpresup.IDpresupuesto = pres.Key;
                Mpresup.Presupuesto = pres.Object.Presupuesto;
                Lpresupesto = Mpresup;
            }
            return Lpresupesto;
        }
    }
}
