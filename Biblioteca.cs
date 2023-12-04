class Biblioteca
{

    // utilizado list para facilitar na hora de gerar as coleções.
   private List<ItemBiblioteca> colecao;

    public Biblioteca()
    {
        colecao = new List<ItemBiblioteca>();
    }

    // Método para adicionar um item à coleção
      public void AdicionarItem(ItemBiblioteca item)
    {
        colecao.Add(item);
    }

    // Método para remover um item da coleção
    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
    }

    // Método de sobrecarga para buscar um item por título
      public ItemBiblioteca BuscarItemPorTitulo(string titulo)
    {
        return colecao.Find(item => item.Titulo == titulo);
    }

    // Método de sobrecarga para buscar um item por ID
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        return colecao.Find(item => item.Id == id);
    }

}