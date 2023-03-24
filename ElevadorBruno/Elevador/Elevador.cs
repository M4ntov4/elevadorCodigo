using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    class Elevador
    {
        int andarAtual;
        int totalAndares;
        int capacidadeTotal;
        int qtdeAtual;

        public int AndarAtual { get => andarAtual; set => andarAtual = value; }
        public int TotalAndares { get => totalAndares; set => totalAndares = value; }
        public int CapacidadeTotal { get => capacidadeTotal; set => capacidadeTotal = value; }
        public int QtdeAtual { get => qtdeAtual; set => qtdeAtual = value; }

        public Elevador(int capacidade, int andares)
        {
            this.CapacidadeTotal = capacidade;
            this.TotalAndares = andares;
            this.AndarAtual = 0;
            this.QtdeAtual = 0;
        }

        public string Entrar(int numeroPessoas)
        {
            if (numeroPessoas <= (CapacidadeTotal - QtdeAtual))
            {
                this.QtdeAtual += numeroPessoas;
                return "Pessoas entrando no elevador"; 
            }
            else
            {
                return "Portas fechando...";
            }
        }

        public string Sair(int numeroPessoas)
        {
            if (numeroPessoas <= QtdeAtual)
            {
                this.QtdeAtual -= numeroPessoas;
                return "Pessoas saindo do elevador";
            }
            else
            {
                return "Portas fechando...";
            }
        }

        public void Subir(int qtdeAndaresDeslocados)
        {
            if (qtdeAndaresDeslocados <= (TotalAndares - AndarAtual))
            {
                this.AndarAtual += qtdeAndaresDeslocados;
            }
        }

        public void Descer(int qtdeAndaresDeslocados)
        {
            if (qtdeAndaresDeslocados <= AndarAtual)
            {
                this.AndarAtual -= qtdeAndaresDeslocados;
            }
        }

        public string Deslocar(int andarDestino)
        {
            if (andarDestino >= AndarAtual)
            {
                Subir(andarDestino - AndarAtual);
                return "Portas fechando...";
            }
            else
            {
                Descer(AndarAtual - andarDestino);
                return "Portas fechando...";
            }
        }

        ~Elevador() { }
    }
}
