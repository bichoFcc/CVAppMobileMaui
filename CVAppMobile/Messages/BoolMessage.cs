using CommunityToolkit.Mvvm.Messaging.Messages;

namespace CVAppMobile.Messages
{
    public class BoolMessage : ValueChangedMessage<bool>
    {
        public BoolMessage(bool value) : base(value)
        {

        }
    }
}
