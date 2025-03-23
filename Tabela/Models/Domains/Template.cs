namespace Tabela.Models.Domains
{
    public class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public Query Query { get; set; }
    }
}
