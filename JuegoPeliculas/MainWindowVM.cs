using Microsoft.Toolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace EjercicioPeliculas
{
    class MainWindowVM : ObservableObject
    {


        private ObservableCollection<Pelicula> _peliculas;

        public ObservableCollection<Pelicula> Peliculas
        {
            get { return _peliculas; }
            set
            {
                SetProperty(ref _peliculas, value);
            }
        }



        public MainWindowVM()
        {
            Peliculas = CargarJSON();
            PeliculaActual = Peliculas[0];
            Total = Peliculas.Count;
            Actual = 1;

            NivelDificultad = new ObservableCollection<string> { "Fácil", "Medio", "Difícil" };
            GeneroPelicula = new ObservableCollection<string> { "Acción", "Comedia", "Drama", "Ciencia-Ficción", "Terror" };
        }

        private Pelicula _peliculaActual;

        public Pelicula PeliculaActual
        {
            get { return _peliculaActual; }
            set
            {
                SetProperty(ref _peliculaActual, value);
            }
        }

        private Pelicula _peliculaSeleccionada;

        public Pelicula PeliculaSeleccionada
        {
            get { return _peliculaSeleccionada; }
            set
            {
                SetProperty(ref _peliculaSeleccionada, value);
            }
        }

        internal void IniciarPartida()
        {
            throw new NotImplementedException();
        }

        internal void FinalizarPartida()
        {
            throw new NotImplementedException();
        }

        internal void ValidarRespuesta()
        {
           // if(PeliculaActual.Titulo == )
        }

        private int _total;

        internal void GuardarJSON()
        {
            throw new NotImplementedException();
        }

        public int Total
        {
            get { return _total; }
            set
            {
                SetProperty(ref _total, value);
            }
        }

        internal void AnyadirPelicula()
        {
            throw new NotImplementedException();
        }

        private int _actual;

        internal void EditarPelicula()
        {
            throw new NotImplementedException();
        }

        public int Actual
        {
            get { return _actual; }
            set
            {
                SetProperty(ref _actual, value);
            }
        }

        internal void ExaminarImagen()
        {
            throw new NotImplementedException();
        }

        private ObservableCollection<string> _generoPelicula;

        public ObservableCollection<string> GeneroPelicula
        {
            get { return _generoPelicula; }
            set
            {
                SetProperty(ref _generoPelicula, value);
            }
        }

        private ObservableCollection<string> _nivelDificultad;

        public ObservableCollection<string> NivelDificultad
        {
            get { return _nivelDificultad; }
            set
            {
                SetProperty(ref _nivelDificultad, value);
            }
        }

        public void Siguiente()
        {
            if (Actual < Total)
            {
                Actual++;
                PeliculaActual = Peliculas[Actual - 1];
            }
        }

        public void Anterior()
        {
            if (Actual > 1)
            {
                Actual--;
                PeliculaActual = Peliculas[Actual - 1];
            }
        }

        public void MostrarPista()
        {


        }

        public ObservableCollection<Pelicula> CargarJSON()
        {
            _ = new ObservableCollection<Pelicula>();
            String peliculasJson = File.ReadAllText("peliculas.json");
            ObservableCollection<Pelicula> listaJsonPeliculas = JsonConvert.DeserializeObject<ObservableCollection<Pelicula>>(peliculasJson);
            return listaJsonPeliculas;
        }

        public static ObservableCollection<Pelicula> ModificarPeliculasJSON()
        {
            _ = new ObservableCollection<Pelicula>();
            String peliculasJson = File.ReadAllText("peliculas.json");
            ObservableCollection<Pelicula> listaJsonPeliculas = JsonConvert.DeserializeObject<ObservableCollection<Pelicula>>(peliculasJson);
            return listaJsonPeliculas;
        }

        public void EliminarPelicula()
        {
            PeliculaSeleccionada = null;
        }
    }
}
