namespace PruebaDeDapperYSql.Models;
using Microsoft.Data.SqlClient;

public class comidas
{
    public int idComida { get; private set; }
    public string nombre { get; private set; }
    public int idTipoComida { get; private set; }
    public double precio { get; private set; }
    public bool sinGluten { get; private set; }
}