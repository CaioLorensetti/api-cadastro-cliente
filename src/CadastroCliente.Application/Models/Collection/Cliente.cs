using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CadastroCliente.Application.Models.Collection
{
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
