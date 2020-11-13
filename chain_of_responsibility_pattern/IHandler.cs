namespace chain_of_responsibility_pattern
{
    public interface IHandler
    {
         IHandler SetNext(IHandler handler);

         object Handle(object request);
    }
}