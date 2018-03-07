namespace Template.Core.UseCases.Interface
{
    public interface IHandleUseCase<Request, Response>
    {
        Response Handle(Request request);
    }
}