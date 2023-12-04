Biblioteca minhaBiblioteca = new Biblioteca();

Livro livro1 = new Livro(1, "O Senhor dos Anéis", "J.R.R. Tolkien");
Livro livro2 = new Livro(2, "Harry Potter", "J.K. Rowling");

// Adicionando livros à biblioteca
minhaBiblioteca.AdicionarItem(livro1);
minhaBiblioteca.AdicionarItem(livro2);

// Buscando um livro por título
Livro livroEncontrado = (Livro)minhaBiblioteca.BuscarItemPorTitulo("O Senhor dos Anéis");

// Exibindo a Descrição Interna do livro encontrado
Livro livrosEncontrados = (Livro)minhaBiblioteca.BuscarItemPorTitulo("O Senhor dos Anéis");

if (livrosEncontrados != null)
{
    livrosEncontrados.ExibirDescricaoInterna();
}
        else
{
    Console.WriteLine("Livro não encontrado por título.");
}

// Removendo um livro da biblioteca
minhaBiblioteca.RemoverItem(livro1);

// Tentando buscar o livro removido por título novamente
Livro livrosRemovidos = (Livro)minhaBiblioteca.BuscarItemPorTitulo("O Senhor dos Anéis");

if (livrosRemovidos != null)
{
    livrosRemovidos.ExibirDescricaoInterna();
}
else
{
    Console.WriteLine("Livro não encontrado após remoção.");
}