using LiteDBExample.Modelos;
using LiteDB;

namespace NovasClasses;

public class CostureiraControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CostureiraControle() : base()
  {
    NomeDaTabela = "Costureiras";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCostureira)
  {
    var collection = liteDB.GetCollection<Costureira>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCostureira);
  }

  //----------------------------------------------------------------------------

  public virtual List<Costureira>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Costureira>(NomeDaTabela);
    return new List<Costureira>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCostureira)
  {
    var collection = liteDB.GetCollection<Costureira>(NomeDaTabela);
    collection.Delete(idCostureira);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Costureira costureira)
  {
    var collection = liteDB.GetCollection<Costureira>(NomeDaTabela);
    collection.Upsert(costureira);
  }

  //----------------------------------------------------------------------------
}