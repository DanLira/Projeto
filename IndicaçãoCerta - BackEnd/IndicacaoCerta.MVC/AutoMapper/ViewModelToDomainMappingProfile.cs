using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.MVC.ViewModels;
using AutoMapper;

namespace IndicacaoCerta.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }

        }
        
        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioComun, UsuarioComunViewModel>();
            Mapper.CreateMap<UsuarioSystem, UsuarioSystemViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Chamados, ChamadosViewModel>();
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Avaliacao, AvaliacaoViewModel>();

        }

       
    }
}