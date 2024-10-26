﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebKoi6.DAL.Base
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();   
        T GetById(object Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
        void SaveChange();
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
