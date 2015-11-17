using AutoMapper;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.MVC.ViewModels;


namespace IndicacaoCerta.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioComunViewModel, UsuarioComun>();
            Mapper.CreateMap<UsuarioSystemViewModel, UsuarioSystem>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
            Mapper.CreateMap<ChamadosViewModel, Chamados>();
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<AvaliacaoViewModel, Avaliacao>();
            
        }

        
    }
}