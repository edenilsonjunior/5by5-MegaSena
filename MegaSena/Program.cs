// Faça um programa que sorteie os 6 numeros da mega-sena e grave-os em um vetor ordenado

Console.WriteLine("=====Mega Sena=====");

int size = 6, index = 0, temp = 0;
int[] numeros = new int[size];
int[] numerosOrdenados = new int[size];

Random random = new Random();

// Populando o vetor principal
while(index < 6)
{
    int aux = random.Next(1, 61);
    
    if(index == 0)
    {
        numeros[index] = aux;
        index++;
    }
    else
    {
        bool repetido = false;
        for(int i = 0; i < index; i++) {

            if (numeros[i] == aux)
            {
                repetido = true;
            }
        }

        if(!repetido) {
            numeros[index] = aux;
            index++;
        }
    }
}


// Copiando o vetor original para outro vetor
for (int i = 0; i < index; i++)
{
    numerosOrdenados[i] = numeros[i];
}


// Organizando o segundo vetor
for (int i = 0; i < index; i++)
{
    for (int j = i + 1; j < index; j++)
    {
        if (numerosOrdenados[i] > numerosOrdenados[j])
        {
            temp = numerosOrdenados[i];
            numerosOrdenados[i] = numerosOrdenados[j];
            numerosOrdenados[j] = temp;
        }
    }
}

Console.WriteLine("Numeros da mega-sena desordenados:");
for (int i = 0; i < index; i++)
{
    Console.Write($"{numeros[i]} ");
}


Console.WriteLine("\nNumeros da mega-sena ordenados:");
for (int i = 0; i < index; i++)
{
    Console.Write($"{numerosOrdenados[i]} ");
}

Console.WriteLine("\n=============================");
Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();