using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectViewlModel
    {
        public ProjectViewlModel(string title, DateTime createdAt)
        {
            Title = title;
            CreatedAt = createdAt;
        }

        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
