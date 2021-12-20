using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace EjercicioPeliculas
{
    class JsonService
    {

        public void GuardarJsonService(in ObservableCollection<Pelicula> lista, in string ruta)
        {
            try
            {
                string peliculasJson = JsonConvert.SerializeObject(lista);
                File.WriteAllText(ruta, peliculasJson);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public ObservableCollection<Pelicula> CargarJsonService(in string ruta)
        {
            string peliculasJson = "";
            try
            {
                 peliculasJson = File.ReadAllText(ruta);
                ObservableCollection<Pelicula> listaJsonPeliculas = JsonConvert.DeserializeObject<ObservableCollection<Pelicula>>(peliculasJson);
                return listaJsonPeliculas;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return JsonConvert.DeserializeObject<ObservableCollection<Pelicula>>(peliculasJson);
        }
    }
}
