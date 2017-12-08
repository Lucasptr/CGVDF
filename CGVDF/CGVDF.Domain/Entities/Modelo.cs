using System;

namespace CGVDF.Domain.Entities
{
    public class Modelo
    {
        public int ModeloId { get; set; }
        public string NomeModelo { get; set; }
        public int NumeroPrefixo { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public int AnoFabricacao { get; set; }
        public string Radio { get; set; }
        public DateTime DataCadastro { get; set; }
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
