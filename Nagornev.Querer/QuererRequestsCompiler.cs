using System.Collections.Generic;
using System.Linq;

namespace Nagornev.Querer
{
    public abstract class QuererRequestsCompiler<TRequestType>
    {
        protected abstract internal IEnumerable<TRequestType> Compile();

        protected IEnumerable<TRequestType> Compile(IEnumerable<QuererRequestCompiler<TRequestType>> compilers)
        {
            return compilers.Select(x => x.Compile());
        }
    }
}
