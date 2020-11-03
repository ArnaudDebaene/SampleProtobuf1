using Google.Protobuf.WellKnownTypes;
using ProtoBuf;
using ProtoBuf.Meta;
using System;

namespace SampleProtobuf1
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeModel = RuntimeTypeModel.Default;
            typeModel.Add<Int32Value>();
            //typeModel[typeof(Int32Value)].AddField(1, nameof(Int32Value.Value));

            var msg = new MyMessage { Field1 = new Int32Value { Value = 5 } };
            var copy = Serializer.DeepClone(msg);
        }
    }
}
