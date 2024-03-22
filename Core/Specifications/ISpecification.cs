
using System.Linq.Expressions;

namespace Core.specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria{get;}
        List<Expression<Func<T, object>>> Include{get;}
        object Includes { get; }
    }
}