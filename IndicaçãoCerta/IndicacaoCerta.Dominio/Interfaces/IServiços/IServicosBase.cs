using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces.IServiços
{
    public interface IServicosBase<TEntity> where TEntity : class
    {
        
        void Add(TEntity obj);
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void remove(TEntity obj);

        void Dispose();
    }
}
