using System;
using System.Data;
using System.Data.SqlClient;

namespace hotel_guests_manager;

class Program
{
    static void Main(string[] args)
    {


    }

    //TODO: finish in the morning....

    static void connectToDatabase(){
        string constr;

        SqlConnection connection;

        constr = @"Data source=localhost;Initial Catalog=hotel;User ID= root@localhost;Password=24518300";

        connection = new SqlConnection(constr);

    }
}
