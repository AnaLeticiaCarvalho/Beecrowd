using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) {

        double nota1, nota2, soma;

        Console.WriteLine("Digite a nota 1: ");
        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         Console.WriteLine("Digite a nota 2: ");
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        soma = nota1 + nota1;

        Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));

        if (soma < 60)
        {
            Console.WriteLine("REPROVADO");
        }

        else
        {
            Console.WriteLine("APROVADO");
        }

        Console.ReadLine();



    }

}
