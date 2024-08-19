using LiteDB;

namespace LiteDBExample.Modelos;

public class MateriaPrima : Registro
{
  [BsonId]
  public string Tipo {get; set ;}
  public int IdMP { get; set; }
  public string Fornecedor { get; set; }
  public string Quantidade { get; set;}
}