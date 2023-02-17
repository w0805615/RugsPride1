using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RugsPride.Models
{
    public class RugMaterialViewModel
    {
        public List<Rug> Rugs { get; set; }
        public SelectList Material { get; set; }
        public string RugMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
