using System;

namespace IndicacaoCerta.Dominio.Entidades
{
    public class Avaliacao
    {
        public int AvaliacaoId { get; set; }

        public int Pontuacao { get; set; }

        public string DescricaoAvaliacao { get; set; }

        public DateTime DataAvaliacao { get; set; }

        public int ChamadosId { get; set; }

        public virtual Chamados Chamado { get; set; }

    }
}
