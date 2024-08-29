using NovasClasses.Modelos;
using LiteDB;

namespace NovasClasses;

public class ItemControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ItemControle() : base()
  {
    NomeDaTabela = "Items";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idItem)
  {
    var collection = liteDB.GetCollection<Item>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idItem);
  }

  //----------------------------------------------------------------------------

  public virtual List<Item>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Item>(NomeDaTabela);
    return new List<Item>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idItem)
  {
    var collection = liteDB.GetCollection<Item>(NomeDaTabela);
    collection.Delete(idItem);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Item item)
  {
    var collection = liteDB.GetCollection<Item>(NomeDaTabela);
    collection.Upsert(item);
  }

  //----------------------------------------------------------------------------
}