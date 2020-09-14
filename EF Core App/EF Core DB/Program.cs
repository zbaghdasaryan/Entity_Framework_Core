//Для работы с существующей БД MS SQL Server нам надо добавить три пакета:
//Microsoft.EntityFrameworkCore.SqlServer
//Microsoft.EntityFrameworkCore.Tools
//Microsoft.EntityFrameworkCore.SqlServer.Design

/*
Пакет "Microsoft.EntityFrameworkCore.SqlServer" представляет функциональность Entity Framework для работы с MS SQL Server, 
а два других пакета - "Microsoft.EntityFrameworkCore.Tools" и "Microsoft.EntityFrameworkCore.SqlServer.Design" понадобятся 
нам в дальнейшем для создания классов по базе данных, то есть reverse engineering.
*/

/*
 Далее в Package Manager Console выполним следующую команду:
Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;" Microsoft.Entit
 */
using System;

namespace EF_Core_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
