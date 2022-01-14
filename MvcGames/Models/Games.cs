using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //dodane



namespace MvcGames.Models

{

    public class Games

    {

        public int Id { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)] //we need Date only
        [Display(Name = "Release Date")] //dodane

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public int Pegi { get; set; }

    }

}