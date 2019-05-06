using System;

namespace Softplan.MiguelCadaviz.WebApi.Domain
{
    public static class Calculos
    {
        private static readonly decimal _percentualJuros = 0.01m;

        public static decimal CalcularJurosCompostos(decimal valorInicial, int quantidadeMeses)
        {
            var valorJuros = (decimal)Math.Pow((double)(1 + _percentualJuros), quantidadeMeses);

            return valorInicial * valorJuros;
        }
        
        public static decimal Truncar(decimal valor, int casasDecimais)
        {
            long multiplicador = (long)Math.Pow(10, casasDecimais);

            return Math.Truncate(valor * multiplicador ) / multiplicador;
        }
    }
}
