int numero;
string parimpar;

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());
Console.Clear();

parimpar = (numero % 2) == 0 ? "par" : "ímpar";
Console.WriteLine($"O {numero} é {parimpar}");