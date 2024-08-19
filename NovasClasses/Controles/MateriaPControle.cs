using LiteDBExample.Modelos;
using LiteDB;

namespace NovasClasses;

public class MateriaprimaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MateriaprimaControle() : base()
  {
    NomeDaTabela = "Materia Prima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMateriaPrima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idMateriaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual List<MateriaPrima>? LerTodos()
  {
    var tabela = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    return new List<MateriaPrima>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMateriaPrima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    collection.Delete(idMateriaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(MateriaPrima materiaprima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    collection.Upsert(materiaprima);
  }

  //----------------------------------------------------------------------------
}