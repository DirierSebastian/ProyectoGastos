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
    public class Daux
    {
       /* Maux Laux = new Maux();
        string Idaux;


        public async Task<Maux> MostrarSaldo()
        {

            var Taux = await Cconexion.firebase
                .Child("Gastos")
                .Child("ModeloX")
                .OnceAsync<Maux>();
            foreach (var au in Taux)
            {
                Maux mMenu = new Maux();
                mMenu.IDaux = au.Key;
                mMenu.Aux = au.Object.Aux;

                Laux = mMenu;
            }
            return Laux;
        }


        public async Task<string> InsertarSaldo(Maux parametros)
        {
            var data = await Cconexion.firebase
                .Child("Gastos")
                .Child("ModeloX")
                .PostAsync(new Maux()
                {
                    Aux = parametros.Aux
                });
            Idaux = data.Key;
            return Idaux;
        }
        public async Task ActualizarSaldo(Maux parametros)
        {
            await Cconexion.firebase
                .Child("Gastos")
                .Child("ModeloX")
                .Child(Idaux)
                .PutAsync(new Maux() { Aux = parametros.Aux });
        }
       */
    }
}
