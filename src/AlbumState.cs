using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.Album
{
    // The state class is access the blockchain state
    public class AlbumState : ContractState 
    {
        // A state that holds string value
        public StringState Message { get; set; }
    }
}