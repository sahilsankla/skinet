using System.Linq.Expressions;
using Core.specifications;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {

        }
        public BaseSpecification(Expression<Func<T, bool>>criteria)
        {
       Criteria =criteria;
     
        }
        public Expression<Func<T, bool>> Criteria {get;}
        public List<Expression<Func<T, object>>> Include {get;} =
        
        new List<Expression<Func<T,object>>>();

        object ISpecification<T>.Includes => throw new NotImplementedException();

        protected void AddInclude(Expression<Func<T,object>> includeExpression)
        {
            Include.Add(includeExpression);
        }
    }
}