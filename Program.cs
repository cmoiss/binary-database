using static System.Console;
using binary_database.service;

namespace binary_database;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Start Application");

        string hexCode = RandomHexGenerator.GenerateRandomHex(16);
        WriteLine(hexCode);
    }
}