using System;

class Program
{
    static int? PesquisaBinaria(int[] array, int item)
    {
        int baixo = 0;
        int alto = array.Length - 1;
        int meio, chute;

        while (baixo <= alto)
        {
            meio = (baixo + alto) / 2;
            chute = array[meio];

            if (chute == item)
            {
                return meio;
            }

            if (chute > item)
            {
                alto = meio - 1;
            }
            else
            {
                baixo = meio + 1;
            }
        }

        // Retorna null se o item não for encontrado
        return null;
    }

    static void Main()
    {
        int[] arrayOrdenado = { 1, 3, 5, 7, 9 };

        // Exemplo de uso
        int itemProcurado1 = 3;
        int? resultado1 = PesquisaBinaria(arrayOrdenado, itemProcurado1);
        Console.WriteLine(resultado1.HasValue ? $"Item {itemProcurado1} encontrado no índice {resultado1}" : $"Item {itemProcurado1} não encontrado no array");

        int itemProcurado2 = -1;
        int? resultado2 = PesquisaBinaria(arrayOrdenado, itemProcurado2);
        Console.WriteLine(resultado2.HasValue ? $"Item {itemProcurado2} encontrado no índice {resultado2}" : $"Item {itemProcurado2} não encontrado no array");
    }
}
