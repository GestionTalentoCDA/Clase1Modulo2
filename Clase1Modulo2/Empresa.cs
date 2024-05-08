using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clase1Modulo2
{
    public class Empresa
    {

        [JsonPropertyName("clientes")]
        public List<Cliente> Clientes { get; set; }

    }
}
