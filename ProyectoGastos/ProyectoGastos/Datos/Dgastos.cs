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
    public class Dgastos
    {
        Mmenu Lmenu = new Mmenu();
        string Idsaldo;
 
        public async Task<Mmenu> MostrarSaldo()
        {

            var Tsaldo = await Cconexion.firebase
                .Child("Gastos")
                .Child("Modelo")
                .OnceAsync<Mmenu> ();
            foreach (var sald in Tsaldo)
            {
                Mmenu mMenu = new Mmenu ();
                mMenu.IDsaldo = sald.Key;
                mMenu.Saldo = sald.Object.Saldo;

                Lmenu = mMenu;
            }
            return Lmenu;
        }

        public string GetID()
        {
            return Idsaldo;
        }
        public async Task<string> InsertarSaldo(Mmenu parametros)
        {
            var data = await Cconexion.firebase
                .Child("Gastos")
                .Child("Modelo")
                .PostAsync(new Mmenu()
                {
                    Saldo = parametros.Saldo
                });
            Idsaldo = data.Key;
            return Idsaldo;
        }



        /*public async Task ActualizarSaldo(Mmenu aux)
        {
            await Cconexion.firebase
                .Child("Gastos")
                .Child("Modelo")
                .Child(Idsaldo) 
                .PutAsync(new Mmenu() { Saldo = aux.Saldo,
                IDsaldo = aux.IDsaldo}); 
        }
        */
    }
}
