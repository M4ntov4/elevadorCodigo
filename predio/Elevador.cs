using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predio
{
    class Elevador
    {

        int andarAtual;
        int qntAndares;
        int capacidadetotal;
        int totalPessoa;

        public int AndarAtual { get => andarAtual; set => andarAtual = value; }
        public int QntAndares { get => qntAndares; set => qntAndares = value; }
        public int Capacidadetotal { get => capacidadetotal; set => capacidadetotal = value; }
        public int Totalpessoa { get => totalPessoa; set => totalPessoa = value; }

        public Elevador(int capacidade, int andares)
        {
            //                  //
            this.Capacidadetotal = capacidade;
            this.QntAndares = andares;
            this.Totalpessoa = 0;
            this.AndarAtual = 0;

        }

        public void EntrarElevador(int numPessoas)
        {
            if (numPessoas <= (Capacidadetotal - Totalpessoa))
            {
                this.Totalpessoa += numPessoas;
            }
        }


        public void Sair(int numPessoas)
        {
            if (numPessoas <= totalPessoa)
            {
                Totalpessoa -= numPessoas;
            }

        }

        public void Subir(int qntAndaresDeslocados)
        {
            if (qntAndaresDeslocados <= (QntAndares - AndarAtual))
            {

                AndarAtual += qntAndaresDeslocados;
            }
        }


        public void Descendo(int qntAndaresDeslocados)
        {
            if (qntAndaresDeslocados <= AndarAtual)
            {
                AndarAtual -= qntAndaresDeslocados;
            }

        }

        public string Deslocar(int andarDestino)
        {
            if (andarDestino >= AndarAtual)
            {
                Subir(andarDestino - AndarAtual);
                return "subindo";
            }
            else
            {
                Descendo(AndarAtual - andarDestino);
                return "descendo";
            }
        }

        ~Elevador() { }



    }












    

}
