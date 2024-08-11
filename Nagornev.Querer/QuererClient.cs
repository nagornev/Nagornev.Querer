using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nagornev.Querer
{
    public abstract class QuererClient<TRequestType, TResponseType>
    {
        public abstract Task<TResponseType> SendAsync(QuererRequestCompiler<TRequestType> compiler);

        public abstract Task<IEnumerable<TResponseType>> SendAsync(QuererRequestsCompiler<TRequestType> compiler);

        public abstract Task SendAsync(QuererRequestCompiler<TRequestType> compiler, QuererResponseHandler<TResponseType> handler);

        public abstract Task SendAsync(QuererRequestsCompiler<TRequestType> compiler, QuererResponsesHandler<TResponseType> handler);

        protected TRequestType Compile(QuererRequestCompiler<TRequestType> compiler)
        {
            return compiler.Compile();
        }

        protected IEnumerable<TRequestType> Compile(QuererRequestsCompiler<TRequestType> compiler)
        {
            return compiler.Compile();
        }

        protected void Handle(QuererResponseHandler<TResponseType> handler, TResponseType response)
        {
            handler.Handle(response);
        }

        protected void Handle(QuererResponsesHandler<TResponseType> handler, IEnumerable<TResponseType> responses)
        {
            handler.Handle(responses);
        }
    }
}
