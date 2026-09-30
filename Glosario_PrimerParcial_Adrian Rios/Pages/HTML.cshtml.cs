using Glosario_PrimerParcial_Adrian_Rios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Glosario_PrimerParcial_Adrian_Rios.Models;

namespace Glosario_PrimerParcial_Adrian_Rios.Pages
{
    public class HTMLModel : PageModel
    {

        public static List<Termino> GlosarioHTML { get; set; } = new List<Termino>();
        public void OnGet()
        {
        }


    }
}
