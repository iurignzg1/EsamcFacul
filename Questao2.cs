using System;

class pessoa
{
    public string nome;

}

class program
{
    static void Main()
    {

        pessoa p1 = new pessoa();
        p1.nome = "rogerio";
        pessoa p2 = p1;
        p2.nome = "carlos";

        Console.WriteLine(p1.nome);
        Console.WriteLine(p2.nome);
    }
}
