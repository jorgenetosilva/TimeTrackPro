namespace Timer.Core.Models;
public class Atividade
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int CategoriaId { get; set; }

    public Categoria Categoria { get; set; }
}
