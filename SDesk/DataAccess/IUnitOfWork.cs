﻿using System;

namespace DataAccess
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        void Save();
    }
}
