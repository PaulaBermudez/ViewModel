using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ViewModelPost.Models;
using Xamarin.Forms;

namespace ViewModelPost.ViewModels
{
    public class ModelLibro : INotifyPropertyChanged
    {
        public ModelLibro()
        {
            this.Libro = new Libro();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        private Libro _Libro;

        public Libro Libro
        {
            get { return this._Libro; }
            set {
                this._Libro = value;
                OnPropertyChanged("Libro");
            }
        }

        private String _Descripcion;
        public String Descripcion
        {
            get { return this._Descripcion; }
            set
            {
                this._Descripcion = value;
                OnPropertyChanged("Descripcion");
            }
        }

        public String MostrarDescripcion()
        {
            return "Libro: " + this.Libro.Titulo +
                ", Autor: " + this.Libro.Autor +
                ", Género: " + this.Libro.Genero;
        }

        public Command MostrarLibro
        {
            get
            {
                return new Command(() => {
                    Descripcion = MostrarDescripcion();
                });
            }
        }
    }
}
