
using System.Text.Json.Serialization;

namespace Clase1Modulo2
{
    public class Cliente
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }



        [JsonPropertyName("apellido")]
        public string Apellido { get; set; }



        [JsonPropertyName("codCliente")]
        public string CodigoCliente { get; set; }

        [JsonPropertyName("intereses")]
        public List<Interes> Intereses { get; set; }

    }

    public class Interes 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }


        [JsonPropertyName("descripcion")]
        public string Descripcion { get; set; }
    }
}
