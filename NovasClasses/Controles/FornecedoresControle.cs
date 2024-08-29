using NovasClasses.Modelos;
using LiteDB;

namespace NovasClasses;

public class FornecedoresControle : BaseControle
{
  //----------------------------------------------------------------------------

  public FornecedoresControle() : base()
  {
    NomeDaTabela = "Fornecedores";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idFornecedores)
  {
    var collection = liteDB.GetCollection<Fornecedores>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idFornecedores);
  }

  //----------------------------------------------------------------------------

  public virtual List<Fornecedores>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Fornecedores>(NomeDaTabela);
    return new List<Fornecedores>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idFornecedores)
  {
    var collection = liteDB.GetCollection<Fornecedores>(NomeDaTabela);
    collection.Delete(idFornecedores);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Fornecedores fornecedores)
  {
    var collection = liteDB.GetCollection<Fornecedores>(NomeDaTabela);
    collection.Upsert(fornecedores);
  }

  //----------------------------------------------------------------------------
}