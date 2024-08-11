namespace Nagornev.Querer
{
    public abstract class QuererResponseHandler<TResponseType>
    {
        protected internal abstract void Handle(TResponseType response);
    }
}
