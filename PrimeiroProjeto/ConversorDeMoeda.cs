using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    class ConversorDeMoeda
    {
        static private double iof = 1.06;

        static public double ValorTotal(double cotacao, double quantidade)
        {
            return (cotacao * quantidade) * iof;
        }
    }
}
