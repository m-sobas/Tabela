using Tabela.Models.ViewModels;

namespace Tabela.Models.Domains
{
    public class Query
    {
        public int Id { get; set; }
        public bool Radio { get; set; }
        public int? Counter { get; set; }
        public IFormFile File { get; set; }
    }
}
