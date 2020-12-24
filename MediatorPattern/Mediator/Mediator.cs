

namespace Mediator
{
    public interface IMediator<in TRequest, out TResponse>
    {
        TResponse Send(TRequest request);
    }
    public class Mediator<TRequest, TResponse> : IMediator<TRequest, TResponse>
    {
        private readonly IHandler<TRequest, TResponse> _handler;

        public Mediator(IHandler<TRequest, TResponse> handler)
        {
            this._handler = handler;
        }

        TResponse IMediator<TRequest, TResponse>.Send(TRequest request)
        {
            return _handler.Handle(request);
        }
    }
}
