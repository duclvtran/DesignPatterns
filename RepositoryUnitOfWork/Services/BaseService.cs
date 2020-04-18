using AutoMapper;
using RepositoryUnitOfWork.Repositories;
using RepositoryUnitOfWork.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace RepositoryUnitOfWork.Services
{
    public abstract class BaseService<TEntity, TDto> : IBaseService<TEntity, TDto>
         where TEntity : class
         where TDto : class
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected abstract IGenericRepository<TEntity> _reponsitory { get; }

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = DtoToEntity(dto);

            _reponsitory.Add(entity);

            await _unitOfWork.SaveAsync();

            return EntityToDto(entity);
        }

        public virtual async Task<TDto> UpdateAsync(TDto dto)
        {
            var entity = DtoToEntity(dto);

            _reponsitory.Update(entity);

            await _unitOfWork.SaveAsync();

            return EntityToDto(entity);
        }

        public virtual async Task DeleteAsync(object id)
        {
            var entity = await _reponsitory.FindByIdAsync(id);

            if (entity == null) throw new Exception("Not found entity object with id: " + id);

            _reponsitory.Delete(entity);

            await _unitOfWork.SaveAsync();
        }

        public virtual async Task<TDto> FindByIdAsync(object id)
        {
            return EntityToDto(await _reponsitory.FindByIdAsync(id));
        }

        public async Task<PaginatedList<TEntity, TDto>> FindAsync(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int page = 1)
        {
            var query = _reponsitory.Find(filter);

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            const int PageSize = 10;
            return await PaginatedList<TEntity, TDto>.CreateAsync(query.AsNoTracking(), page, PageSize);
        }

        protected TDto EntityToDto(TEntity entity)
        {
            return Mapper.Map<TDto>(entity);
        }

        protected TEntity DtoToEntity(TDto dto)
        {
            return Mapper.Map<TEntity>(dto);
        }

        protected TEntity DtoToEntity(TDto dto, TEntity entity)
        {
            return Mapper.Map(dto, entity);
        }

        protected IEnumerable<TDto> EntityToDto(IEnumerable<TEntity> entities)
        {
            return Mapper.Map<IEnumerable<TDto>>(entities);
        }

        protected IEnumerable<TEntity> DtoToEntity(IEnumerable<TDto> dto)
        {
            return Mapper.Map<IEnumerable<TEntity>>(dto);
        }

        //public Task<PaginatedList<TEntity, TDto>> FindAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int page = 1)
        //{
        //    throw new NotImplementedException();
        //}
    }
}