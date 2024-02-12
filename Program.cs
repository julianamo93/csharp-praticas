// exercício 01 - criar uma variável chamada curso
string curso = "C#: criando sua primeira aplicação";

// exercício 02 - mostrando o conteúdo no console
Console.WriteLine(curso);

// exercício 03 - criando uma variável nome e sobrenome
string nome = "Juliana";
string sobrenome = "Moreira Kinoshita";
Console.WriteLine(nome);
Console.WriteLine(sobrenome);

// exercício 04 - mostrar o nome dos instrutores
Console.WriteLine("Daniel Portugal e Gui Lima");

//exercício 05 - Nota média para aprovação
int notaMedia = 8;
if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação.");
}
else
{
    Console.WriteLine("Nota insuficiente para a aprovação.");
}

//exercício 06 - Criar uma lista de linguagens

void exibirListaDeLinguagens()
{
    Console.WriteLine("C#");
    Console.WriteLine("Java");
    Console.WriteLine("JavaScript");
}

exibirListaDeLinguagens();

//exercício 07 - Exibir o valor de C# da lista anterior
void exibirLista()
{
    Console.WriteLine("C#");
}

exibirLista();

//exercício 08 - Exibir a n-ésima posição em uma lista
//int posicao = int(Console.read());
//Console.WriteLine(lista[posicao]); - exercicio com erro!

//exercicio 09 - Função a partir de dois números
float a = 10;
float b = 2;

float soma1 = a + b;
float subtracao = a - b;
float multiplicacao = a * b;
float divisao = a / b;

Console.WriteLine($"a + b = {soma1}");
Console.WriteLine($"a - b = {subtracao}");
Console.WriteLine($"a * b = {multiplicacao}");
Console.WriteLine($"a / b = {divisao}");

//exercicio 10 e 11 - Lista de Bandas (English test)
List<string> BandsList = new List<string>();

for (int i=0; i < 5; i++)
{
    Console.WriteLine($"{i+1} => Add your 5 favorite Bands!");
    string bandsNamesTyped = Console.ReadLine()!;
    BandsList.Add(bandsNamesTyped);
}

Console.WriteLine(" ");
foreach (string band in BandsList)
{
    Console.WriteLine($"{band}");
}

//exercicio 12 - Programa de Soma de uma Lista

List<int> ListaNum = new List<int> {1, 2, 3, 4, 5, 6, 7};
int soma = 0;

foreach (int num in ListaNum)
{
    soma += num;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma}");
