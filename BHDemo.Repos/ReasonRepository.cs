using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BHDemo.Common.Dto;
using BHDemo.Data;

namespace BHDemo.Repos
{
    /// <summary>
    /// Repository to get, create, and update ReasonDto instances in the data store. This handles communication with the Entity Framework and maps <see cref="Reason"/> entities to and from <see cref="ReasonDto"/>s.
    /// </summary>
    public class ReasonRepository : IReasonRepository
    {
        private readonly IBHDemoDbContext _dbContext;
        private readonly IMapper _mapper = MapperConfig.SetUpMapper();

        public ReasonRepository()
        {
            _dbContext = new BHDemoDbContext();
        }

        public ReasonRepository(IBHDemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ReasonDto GetById(int id)
        {
            var entity = GetItemById(id);
            return _mapper.Map<Reason, ReasonDto>(entity);
        }


        public IEnumerable<ReasonDto> List()
        {
            var list = _dbContext.Set<Reason>().AsEnumerable();
            IEnumerable<ReasonDto> listObj = _mapper.Map<IEnumerable<Reason>, IEnumerable<ReasonDto>>(list);
            return listObj;
        }

        public IEnumerable<ReasonDto> List(System.Linq.Expressions.Expression<Func<Reason, bool>> predicate)
        {
            var list = _dbContext.Set<Reason>()
                .Where(predicate)
                .AsEnumerable();
            IEnumerable<ReasonDto> listObj = _mapper.Map<IEnumerable<Reason>, IEnumerable<ReasonDto>>(list);
            return listObj;
        }

        public ReasonDto Insert(ReasonDto item)
        {
            var entity = _mapper.Map<ReasonDto, Reason>(item);
            _dbContext.Set<Reason>().Add(entity);
            _dbContext.SaveChanges();
            var savedItem = _mapper.Map<Reason, ReasonDto>(entity);
            return savedItem;
        }

        public ReasonDto Update(ReasonDto item)
        {
            var entity = _mapper.Map<ReasonDto, Reason>(item);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            var savedItem = _mapper.Map<Reason, ReasonDto>(entity);
            return savedItem;
        }

        public void Delete(int id)
        {
            var entity = GetItemById(id);
            _dbContext.Set<Reason>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(ReasonDto item)
        {
            var entity = _mapper.Map<ReasonDto, Reason>(item);
            _dbContext.Set<Reason>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public Reason GetItemById(int id)
        {
            return _dbContext.Reasons.FirstOrDefault(x => x.Id == id);
        }
    }
}
