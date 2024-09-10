using ConsoleApp33.Context;
using ConsoleApp33.Entities;
using Microsoft.EntityFrameworkCore;


//Eger her hansi propertyini ozumuz primary key teyin etmek isteyirikse 2 yol var 
//1.Data annotation ile Key
//2.Fluent api ile HasKey
//Key - HasKey

//Eger enty de olan her hansi propertinin table bawqa adla yaranmasini isteyirikse
//1.Data annotation  Column
//2.Fluent api ile  HasColumn


//Eger entiti incerisinde olan her hansi propertinin dataabse getmesini istemirsizse
//1.Data annotion




namespace ConsoleApp33
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            SederekDbContext context = new SederekDbContext();

        }
    }
}
