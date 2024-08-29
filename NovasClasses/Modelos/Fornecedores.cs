using LiteDB;

namespace NovasClasses.Modelos;

public class Fornecedores : Registro
{
  [BsonId]
  public string Nome {get; set ;}
  public int Id { get; set; }
  public string Email { get; set; }
  public string Endereco { get; set;}
  public string Produtos { get; set;}
}
