using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MijnMaaltijd.Models
{
    public class SearchRecipe
    {
        [Display(Name="Name contains")]
        public string Name { get; set; }

        [Display(Name="Season")]
        public int? SeasonID { get; set; }

        [Display(Name="Type")]
        public int? TypeID { get; set; }

        [Display(Name="Is with meat")]
        public bool? IsMeat { get; set; }

        [Display(Name="Is with fish")]
        public bool? IsFish { get; set; }

        [Display(Name="Is vegetarian")]
        public bool? IsVegetarian { get; set; }
        
        [Display(Name="Is vegan")]
        public bool? IsVegan { get; set; }

        [Display(Name="Is gluten free")]
        public bool? IsGlutenFree { get; set; }

        [Display(Name="Is adaptable to vegan")]
        public bool? IsVeganAdaptable { get; set; }

        [Display(Name="Is adabtable to gluten free")]
        public bool? IsGlutenFreeAdaptable { get; set; }
    }
}