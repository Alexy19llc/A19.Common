namespace Mrh.Messaging
{
    public interface IBodyReconstructor<TBody>
    {
        /// <summary>
        ///     Used to append the body to the current message being reconstructed.
        /// </summary>
        /// <param name="position">The position to add the message to in the body.</param>
        /// <param name="body">The body of the message.</param>
        void Append(int position, TBody body);

        /// <summary>
        ///     All of the fragments have been received and the message has been reconstructured.
        /// </summary>
        /// <returns></returns>
        bool Completed();
        
        /// <summary>
        ///     Used to get the body of the message.
        /// </summary>
        TBody Body { get; }
    }
}