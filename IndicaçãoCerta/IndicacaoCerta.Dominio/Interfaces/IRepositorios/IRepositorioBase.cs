﻿using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces.IRepositorios
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {

        void Add(TEntity obj);
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void remove(TEntity obj);

        void Dispose();

    }
}
