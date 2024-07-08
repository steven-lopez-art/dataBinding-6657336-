using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBinding_6657336_
{
    public class Alumno : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        string nombre = string.Empty;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre == value)
                    return;
                nombre = value;
                onPropertyChanged(nameof(Nombre));
                onPropertyChanged(nameof(MostrarNombre));
            }
        }

        public string MostrarNombre => $"Nombre Ingresado: {Nombre}";

        void onPropertyChanged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
