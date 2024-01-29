using AElf.Sdk.CSharp;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.Album
{
    public class Album : AlbumContainer.AlbumBase
    {
        public override Empty Initialize(Empty input)
        {
            return new Empty();
        }

        public override Empty Update(StringValue input)
        {
            State.Message.Value = input.Value;
            Context.Fire(new MessageUpdated
            {
                Value = input.Value
            });
            return new Empty();
        }

        public override StringValue Read(Empty input)
        {
            var value = State.Message.Value;
            return new StringValue
            {
                Value = value
            };
        }
    }
    
}