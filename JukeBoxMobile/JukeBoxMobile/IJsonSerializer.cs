using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace JukeBoxMobile
{
    public interface IJsonSerializer : ISerializer, IDeserializer
    {
    }
}
