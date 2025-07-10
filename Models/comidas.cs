namespace PruebaDeDapperYSql.Models;
using Microsoft.Data.SqlClient;

public class comidas
{
    public int idComida { get; set; }
    public string nombre { get; set; }
    public int idTipoComida { get; set; }
    public double precio { get; set; }
    public bool sinGluten { get; set; }
}