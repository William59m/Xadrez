﻿using System;
using tabuleiro;

namespace XadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j < tab.Colunas; j++)
                {
                    if(tab.Pecass(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Pecass(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
