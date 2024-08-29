using LiteDB;

namespace NovasClasses.Modelos;

public class MateriaPrima : Registro
{
  [BsonId]
  public string TipoMP {get; set ;}
  public int IdMP { get; set; }
  public string FornecedorMP { get; set; }
  public string QuantidadeMP { get; set;}
}