namespace Template.Core.UseCases.Common
{
    public interface IHandleUseCase<Request, Response>
    {
        Response Handle(Request request);
    }
}