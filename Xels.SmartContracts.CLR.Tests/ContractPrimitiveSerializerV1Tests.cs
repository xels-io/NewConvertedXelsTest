﻿using NBitcoin;
using Xels.SmartContracts.CLR.Serialization;
using Xels.SmartContracts.Networks;
using Xunit;

namespace Xels.SmartContracts.CLR.Tests
{
    public class ContractPrimitiveSerializerV1Tests
    {
        private readonly IContractPrimitiveSerializer serializer;
        private readonly Network network;

        public ContractPrimitiveSerializerV1Tests()
        {
            this.network = new SmartContractsRegTest();
            this.serializer = new ContractPrimitiveSerializerV1(this.network);
        }

        [Fact]
        public void Test_ReferenceType_Serialization()
        {
            Assert.Null(this.serializer.Deserialize(typeof(string), this.serializer.Serialize("")));
            Assert.Null(this.serializer.Deserialize(typeof(byte[]), this.serializer.Serialize(new byte[0])));
        }
    }
}