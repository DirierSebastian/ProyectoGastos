using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGastos.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://registro-de-gastos-6fc61-default-rtdb.firebaseio.com/");

    }
}
