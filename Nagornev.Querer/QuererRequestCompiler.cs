namespace Nagornev.Querer
{
    public abstract class QuererRequestCompiler<TRequestType>
    {
        protected internal abstract TRequestType Compile();
    }
}
