using Glosario_PrimerParcial_Adrian_Rios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Glosario_PrimerParcial_Adrian_Rios.Pages
{
    public class HTMLModel : PageModel
    {

        public static List<Termino> GlosarioHTML { get; set; } = new List<Termino>();
        public void OnGet()
        {
            if (GlosarioHTML.Count == 0)
            {
                GlosarioHTML.Add(new Termino{ Palabra = "padding", Definicion = "Genera espacio interno entre"});
                GlosarioHTML.Add(new Termino{ Palabra = "display: flex", Definicion = "Habilita el modelo de"});
                GlosarioHTML.Add(new Termino{ Palabra = "border-radius", Definicion = "Redondea las esquinas"});
            }
        }


    }
}
