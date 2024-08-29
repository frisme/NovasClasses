using NovasClasses.Modelos;
using LiteDB;

namespace NovasClasses;

public class MateriaPrimaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MateriaPrimaControle() : base()
  {
    NomeDaTabela = "MateriaPrima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idmateriaprima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    return collection.FindOne(d => d.IdMP == idmateriaprima);
  }

  //----------------------------------------------------------------------------

  public virtual List<MateriaPrima>? LerTodos()
  {
    var tabela = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    return new List<MateriaPrima>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idmateriaprima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    collection.Delete(idmateriaprima);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(MateriaPrima materiaprima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    collection.Upsert(materiaprima);
  }

  //----------------------------------------------------------------------------
}