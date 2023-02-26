using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ModuleMemoryRepository
    {
        private List<LesModules> _modules = new List<LesModules>();

        public ModuleMemoryRepository() 
        { 
            _modules.Add(new LesModules { Id = 1, Nom = "Le C Sharp << C# >> ", NomUrl = "asp-net-core", Description= "Decouvrir le developpement C# .NET core"});
            _modules.Add(new LesModules { Id = 2, Nom = "Le SQL", NomUrl = "bdd-sql", Description = "Decouvrir le sql server" });

        }
        public List<LesModules> GetAllModules() 
        {
            return _modules;
        }
    }
}
