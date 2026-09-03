namespace LojaDoces
{
    class Doces
    {
        //PROPRIEDADES(ATRIBUTOS)
        public string? Confeiteiros {  get; set; }
        public double CapacidadeKg {  get; set; }
        public double PorcentagemPronta {  get; set; }
        public double TaxaProducaoPorHora {  get; set; }

        //METODOS(ACOES)
        public double CalcularKgFaltante()
        {
            double porcentagemfaltante = (100 - PorcentagemPronta) / 100.0;
            return CapacidadeKg * porcentagemfaltante;
        }
        public double calculartempoRestanteHoras()
        {
            return CalcularKgFaltante() / TaxaProducaoPorHora;
        }
        public double CalcularValorFaltante()
        {
            const double PREÇO_POR_KG = 45.50;
            return CalcularKgFaltante() * PREÇO_POR_KG;
        }
    }
}
