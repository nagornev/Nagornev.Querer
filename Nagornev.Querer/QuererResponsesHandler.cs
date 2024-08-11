using System.Collections.Generic;

namespace Nagornev.Querer
{
    public abstract class QuererResponsesHandler<TResponseType>
    {
        protected internal abstract void Handle(IEnumerable<TResponseType> responses);
    }
}
