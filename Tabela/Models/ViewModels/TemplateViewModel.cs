using Tabela.Models.Domains;

namespace Tabela.Models.ViewModels
{
    public class TemplateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public IEnumerable<Query> Queries { get; set; }
    }
}
