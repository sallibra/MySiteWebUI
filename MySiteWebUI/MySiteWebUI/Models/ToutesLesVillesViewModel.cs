using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;

namespace MySiteWebUI.Models
{
    public class ToutesLesVillesViewModel
    {
        public string Nom_ville
        {
            get; set;
        }

        public int Nombre_Quartier { get; set; }
    }
}
