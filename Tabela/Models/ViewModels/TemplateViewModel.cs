using Tabela.Models.Domains;

namespace Tabela.Models.ViewModels
{
    public class TemplateViewModel
    {
        //public Template Template { get; set; }
        //public IEnumerable<Query> Queries { get; set; }

        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public DateTime TemplateDateTime { get; set; }
        public IEnumerable<QueryViewModel> Queries { get; set; }


        //public int Id { get; set; }
        //public string Name { get; set; }
        //public DateTime DateTime { get; set; }
        //public IEnumerable<Query> Queries { get; set; }
    }
}
