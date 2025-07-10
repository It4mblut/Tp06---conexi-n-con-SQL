namespace PruebaDeDapperYSql.Models;
using Microsoft.Data.SqlClient;
public class registroMesasComidas
{
    public int idRegistroMesaComida { get; set; }
    public int idRegistroMesa { get; set; }
    public int idComida { get; set; }
    public int cantidad { get; set; }
    public double precio { get; set; }
}
