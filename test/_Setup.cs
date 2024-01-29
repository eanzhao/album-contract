using AElf.Cryptography.ECDSA;
using AElf.Testing.TestBase;

namespace AElf.Contracts.Album
{
    // The Module class load the context required for unit testing
    public class Module : ContractTestModule<Album>
    {
        
    }
    
    // The TestBase class inherit ContractTestBase class, it defines Stub classes and gets instances required for unit testing
    public class TestBase : ContractTestBase<Module>
    {
        // The Stub class for unit testing
        internal readonly AlbumContainer.AlbumStub AlbumStub;
        // A key pair that can be used to interact with the contract instance
        private ECKeyPair DefaultKeyPair => Accounts[0].KeyPair;

        public TestBase()
        {
            AlbumStub = GetAlbumContractStub(DefaultKeyPair);
        }

        private AlbumContainer.AlbumStub GetAlbumContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<AlbumContainer.AlbumStub>(ContractAddress, senderKeyPair);
        }
    }
    
}