using IndicacaoCerta.Dominio.Entidades;
using System;
using System.ComponentModel.DataAnnotations;

namespace IndicacaoCerta.MVC.ViewModels
{
    public class AvaliacaoViewModel
    {
        [Key]
        public int AvaliacaoId { get; set; }
        [Required]
        public int Pontuacao { get; set; }
        
        public string DescricaoAvaliacao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataAvaliacao { get; set; }

        public int ChamadosId { get; set; }

        public virtual Chamados Chamado { get; set; }

    }
}