using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste2
{
    class DadosEntrada
    {

        private int _anoNascimento;

        public int AnoNascimento
        {
            get { return _anoNascimento; }
            set { _anoNascimento = value; }
        }

        private int _anoAtual;

        public int AnoAtual
        {
            get { return _anoAtual; }
            set
            {
                if (value <= _anoNascimento)
                {
                    _anoAtual = DateTime.Now.Year;
                }
                else
                {
                    _anoAtual = value;
                }

            }
        }

        private double _altura;

        public double Altura
        {
            get { return _altura; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura inválida, por favor informar uma altura maior que zero(0).");
                }
                _altura = value;
            }
        }

        private double _peso;

        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        private double _imc;

        public double Imc
        {
            get { return _imc; }
            set { _imc = value; }
        }


        public void CalcularIMC()
        {
            Imc = _peso / (_altura * _altura);
            Console.WriteLine("Seu IMC = " + _imc);
        }

    }
}