using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Meu projeto ASPNET Core 1", "Minha descrição de Projeto 1", 1, 1, 1000),
                new Project("Meu projeto ASPNET Core 2", "Minha descrição de Projeto 2", 1, 1, 2000),
                new Project("Meu projeto ASPNET Core 3", "Minha descrição de Projeto 3", 1, 1, 3000)
            };

            Users = new List<User>()
            {
                new User("Wellysson Nascimento Rocha", "well@dev.com.br", new DateTime(1995, 12,6)),
                new User("Júlia Katharynna", "julia.ka@dev.com.br", new DateTime(1995, 12,6)),
                new User("Luis Marcelo Sousa Barbosa", "luiz.comz@dev.com.br", new DateTime(1995, 12,6)),
            };

            Skills = new List<Skill>()
            {
                new Skill(".NET Core"),
                new Skill("Design Patterns"),
                new Skill("C#")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
