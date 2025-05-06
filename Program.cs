using static System.Console;
using binary_database.service;
using binary_database.Model;

using static binary_database.service.RandomHexGenerator;
using binary_database.src.dao;

namespace binary_database;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Start Application");
        WriteLine();

        InsertGenericUsers();

        WriteLine("Usuários inseridos com sucesso!");
    }

    private static void InsertGenericUsers()
    {
        List<User> usersList = new List<User>
        {
            new("João", GenerateRandomHexAsLong(16)),
            new("Maria", GenerateRandomHexAsLong(16)),
            new("Ayrton",GenerateRandomHexAsLong(16)),
            new("Padilha", GenerateRandomHexAsLong(16)),
        };

        foreach (var user in usersList)
        {
            UserDAO.Create(user);
        }
    }
}