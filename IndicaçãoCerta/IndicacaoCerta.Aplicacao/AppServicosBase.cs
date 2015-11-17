using IndicacaoCerta.Aplicacao.Interface;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using System;
using System.Collections.Generic;

namespace IndicacaoCerta.Aplicacao
{
    public class AppServicosBase<TEntity> : IDisposable, IAppServicoBase<TEntity> where TEntity : class
    {

        private readonly IServicosBase<TEntity> _servicoBase;

        public AppServicosBase(IServicosBase<TEntity> servicoBase)
        {
            _servicoBase = servicoBase;
        }

        public void Add(TEntity obj)
        {
            _servicoBase.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _servicoBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _servicoBase.GetById(id);
        }

        public void remove(TEntity obj)
        {
             _servicoBase.remove(obj);
        }

        public void Update(TEntity obj)
        {
            _servicoBase.Update(obj);
        }

        public void Dispose()
        {
            _servicoBase.Dispose();
        }
    }
}
