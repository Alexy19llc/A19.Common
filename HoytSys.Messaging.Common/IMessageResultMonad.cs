using Mrh.Monad;

namespace A19.Messaging.Common
{
    public interface IMessageResultMonad<TPayloadType, TBody> where TPayloadType: struct
    {
        
        /// <summary>
        ///     Used to return a result monad from a message.
        /// </summary>
        /// <param name="message">The resulting message.</param>
        /// <returns>The result monad with the value.</returns>
        IResultMonad<T> To<T>(Message<TPayloadType, TBody> message);
    }
}