using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using IndicacaoCerta.Dominio.Interfaces.IRepositorios;

namespace IndicacaoCerta.Dominio.Serviços
{
    public class AvaliacaoServicos : ServicosBase<Avaliacao>, IAvaliacaoServicos
    {
        private readonly IAvaliacaoRepositorioBase _avaliacaoRepositorio;

        public AvaliacaoServicos(IAvaliacaoRepositorioBase avaliacaoRepositorio)
           :base(avaliacaoRepositorio)
        {
            _avaliacaoRepositorio = avaliacaoRepositorio;
        }
    }
}
