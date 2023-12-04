abstract class ItemBiblioteca
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    protected string DescricaoInterna { get; set; }

/* foi utilizado um construtor protected para que seja garantido que ele sera usado como base para as outros classes, sendo assim não poderá ser 
instanciado */
   
     protected ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
    }

    // Método para inicializar DescricaoInterna (pode ser sobrescrito nas classes derivadas se necessário)
    protected virtual void InicializarDescricaoInterna()
    {
        DescricaoInterna = "Descrição Padrão";
    }
}