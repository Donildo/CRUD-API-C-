namespace TodoApi.Entities
{
    public class Contato
    {
       public int Id { get; set; }
       public string? Nome { get; set; }
       public string? Telelfone { get; set;}
       public bool Ativo { get; set; }
    }
}