// Formas de criar um array
string[] nomes = new string[5] { "Bruno", "Ana", "Gabriel", "João", "Fernando" };
int[] numeros = new int[] { 1, 2, 3, 4 };
string [] estados = { "São Paulo", "Rio de Janeiro", "Santa Catarina" };


// Recordando o FOR() e o FOREACH()
for(int x = 0; x < 5; x++)
{
    Console.WriteLine(nomes[x]);
}

foreach(var numero in numeros)
{
    Console.WriteLine(numero);
}


// Criando o array vazio e logo depois atribuindo valores
float[] pesos = new float[2];
pesos[0] = 12.5f;


// Classes para trabalhar com arrays
Array.Reverse(numeros);
foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

Array.Sort(nomes);
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}


// Buscando o índice de "Santa Catarina"
int indice = Array.BinarySearch(estados, "Santa Catarina");
Console.WriteLine(indice); // 2


// Matrizes de várias dimensões
int[,] numeros1; // Duas dimensões
int[,,] numeros2; // Três dimensões
int[,] numeros3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // Duas linhas e Três colunas

for(var linha = 0; linha < 2; linha++)
{
    for(var coluna = 0; coluna < 3; coluna++)
    {
        Console.WriteLine(numeros3[linha, coluna]);
    }
}

foreach(var numero in numeros3)
{
    Console.WriteLine(numero);
}


// Função para pegar o tamanho de linhas e colunas
for (var linha = 0; linha < numeros3.GetLength(0); linha++)
{
    for (var coluna = 0; coluna < numeros3.GetLength(1); coluna++)
    {
        Console.WriteLine(numeros3[linha, coluna]);
    }
}