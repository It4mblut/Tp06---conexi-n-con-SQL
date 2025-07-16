namespace PruebaDeDapperYSql.Models;
using Microsoft.Data.SqlClient;
using Dapper;

public static class DB
{
    private static string _connectionString = @"Server=localhost;DataBase=ORT Gourmet;Integrated Security=True;TrustServerCertificate=True";

    public static List<clientes> saveClients(){

        List<clientes> clientes = new List<clientes>();
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            string query= "SELECT * FROM clientes";
            clientes = connection.Query<clientes>(query).ToList();

        }
        return clientes;
    }
    public static List<tiposComidas> saveFoodTypes(){

        List<tiposComidas> foodTypes = new List<tiposComidas>();
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            string query= "SELECT * FROM tiposComidas";
            foodTypes = connection.Query<tiposComidas>(query).ToList();

        }
        return foodTypes;
    }

    public static List<comidas> saveFoods(){

        List<comidas> foods = new List<comidas>();
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            string query= "SELECT * FROM comidas";
            foods = connection.Query<comidas>(query).ToList();

        }
        return foods;
    }


    public static List<mesas> saveTables(){

        List<mesas> tables = new List<mesas>();
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            string query= "SELECT * FROM mesas";
            tables = connection.Query<mesas>(query).ToList();

        }
        return tables;
    }
    public static List<mozos> saveWaiters(){

        List<mozos> waiters = new List<mozos>();
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            string query= "SELECT * FROM mozos";
            waiters = connection.Query<mozos>(query).ToList();

        }
        return waiters;
    }

    public static List<registroMesas> saveTableRegisters(){
        List<registroMesas> tableRegisters = new List<registroMesas>();
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            string query= "SELECT * FROM registroMesas";
            tableRegisters = connection.Query<registroMesas>(query).ToList();

        }
        return tableRegisters;
    }




    public static int deleteClient(int idClient){
        string query="DELETE FROM clientes WHERE idCliente = @pidCliente";
        int modifiedRegisters = 0;
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            modifiedRegisters=connection.Execute(query, new{pidCliente=idClient});
        }

        return modifiedRegisters;
    }


    public static int modifyWaiter(mozos waiter, string newSurname, string newName){
        int modifiedRegisters = 0;
        if(newName==null){
            newName=waiter.nombre;

        }
        if(newSurname==null){
            newSurname=waiter.apellido;

        }


        string query="UPDATE mozos SET nombre= @newName, apellido=@newSurname WHERE idMozo = @pidMozo";

        using(SqlConnection connection = new SqlConnection(_connectionString)){

            modifiedRegisters=connection.Execute(query, new{newName, newSurname, pidMozo=waiter.idMozo});
        }

        return modifiedRegisters;
    }
    public static void addFood(string nombre, int idTipoComida, double precio, bool sinGluten){

        string query="INSERT INTO comidas(nombre, idTipoComida, precio, sinGluten) VALUES(@nombre, @TipoComida, @precio, @sinGluten)";
        int modifiedRegisters = 0;

        using(SqlConnection connection = new SqlConnection(_connectionString)){

            modifiedRegisters=connection.Execute(query, new{nombre, TipoComida=idTipoComida, precio, sinGluten});
        }

    }

}


