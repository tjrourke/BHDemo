using System;
using System.Collections.Generic;
using BHDemo.Common.Dto;
using BHDemo.Data;

namespace BHDemo.Repos
{
    public interface IReasonRepository
    {
        ReasonDto GetById(int id);
        IEnumerable<ReasonDto> List();
        IEnumerable<ReasonDto> List(System.Linq.Expressions.Expression<Func<Reason, bool>> predicate);
        ReasonDto Insert(ReasonDto item);
        ReasonDto Update(ReasonDto item);
        void Delete(ReasonDto item);
    }
}