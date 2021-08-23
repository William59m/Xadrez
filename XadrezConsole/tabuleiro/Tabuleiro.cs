﻿namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
        public Peca Pecass(int linhas, int colunas)
        {
            return Pecas[linhas, colunas];
        }
        public void ColocarPeca(Peca p, Possicao pos)
        {
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Possicao = pos;
        }
    }
}