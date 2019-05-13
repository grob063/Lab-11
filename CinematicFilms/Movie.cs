using System;
using System.Collections.Generic;
using System.Text;

namespace CinematicFilms
{
    public class Movie //type or blueprint for my object
    {
        public string title { get; set; } //property
        public string category { get; set; } //property


        public Movie(string movietitle, string moviecategory)
        {
            title = movietitle;
            category = moviecategory;
        }
    }    
}

