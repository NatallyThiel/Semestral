// utilizado herança para puxar os dados da classe base ItemBiblioteca e não precisar ficar escrendo os mesmos atributos sempre.

class Livro : ItemBiblioteca
{
    public string Autor { get; set; }

    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
    }
    
    // Sobrescreve o método para inicializar DescricaoInterna
    protected override void InicializarDescricaoInterna()
    {
        // Você pode adicionar lógica específica para a inicialização de DescricaoInterna em Livro, se necessário.
        DescricaoInterna = $"Descrição do Livro ({Id})";
    }

    public void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição Interna do Livro ({Id}): {DescricaoInterna}");
    }
}