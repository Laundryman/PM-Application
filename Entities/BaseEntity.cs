using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Entities
{
    public interface IBaseEntity<T>
    {
        T Id { get; }
    }

    // This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
    // Using non-generic integer types for simplicity and to ease caching logic
    public abstract class BaseEntity<T> : IBaseEntity<T>
        where T : struct, IEquatable<T>
    {
        public virtual T Id { get; protected set; }
    }
}
