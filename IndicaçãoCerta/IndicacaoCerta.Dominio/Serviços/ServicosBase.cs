using IndicacaoCerta.Dominio.Interfaces.IRepositorios;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using System;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Serviços
{
    public class ServicosBase<TEntity> : IDisposable, IServicosBase<TEntity> where TEntity : class
    {

        private readonly IRepositorioBase<TEntity> _repositorioBase;



        public ServicosBase(IRepositorioBase<TEntity> repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }


        public void Add(TEntity obj)
        {
            _repositorioBase.Add(obj);
        }

        public void Dispose()
        {
            _repositorioBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _repositorioBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositorioBase.GetById(id);
        }

        public void remove(TEntity obj)
        {
            _repositorioBase.remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repositorioBase.Update(obj);
        }
    }
}
