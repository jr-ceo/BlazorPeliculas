using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula() { Titulo = "Spider-Man", Lanzamiento = new DateTime(2019, 7, 2), 
                    Poster = "./img/spiderman.jpeg" },
                new Pelicula() { Titulo = "Moana", Lanzamiento = new DateTime(2019, 7, 2), 
                    Poster = "./img/moana.webp" },
                new Pelicula() { Titulo = "Flash", Lanzamiento = new DateTime(2019, 7, 2), 
                    Poster = "./img/flash.jpg" }
            };
        }
    }
}
