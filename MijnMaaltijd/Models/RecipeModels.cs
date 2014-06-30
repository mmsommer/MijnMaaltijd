using System.Collections.Generic;

namespace MijnMaaltijd.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Publication { get; set; }
        public int SeasonID { get; set; }
        public int TypeID { get; set; }
        public bool IsMeat { get; set; }
        public bool IsFish { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVeganAdaptable { get; set; }
        public bool IsGlutenFreeAdaptable { get; set; }
        public int Number { get; set; }
        public string VeganAdaptation { get; set; }
        public string GlutenFreeAdaptation { get; set; }
        public string Dropbox { get; set; }

        public virtual Season Season { get; set; }
        public virtual Type Type { get; set; }
    }

    public class Season
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }

    public class Type
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}