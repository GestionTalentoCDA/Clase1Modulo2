
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Clase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region TiposAnonimos
            //var personaClase = new Persona() { Nombre = "Alejandro" };

            //var persona = new { DatosPersona = personaClase, Apellido = "Jara", Edad = 27 };
            //Console.WriteLine(persona.DatosPersona.Nombre);

            #endregion


            #region Generics
            //var lstNumeros = new List<int>() { 1,2,3,4};
            //lstNumeros.Add(5);


            //var lstNombres = new List<string>() { "Fer", "Mica", "Carla" };
            //lstNombres.Add("Andres");


            //var empresa = new Empresa() { RazonSocial = "CDA Informatica"};

            //var gestionEmpresa = new Gestionar<Empresa>();

            //gestionEmpresa.AddValue(empresa);


            //var escuela = new Escuela() { Direccion = "Direccion 1" };

            //var gestionEscuela = new Gestionar<Escuela>();
            //gestionEscuela.AddValue(escuela);
            #endregion


            #region JSON



            //Opcion 1
            //string jsonInput = "{\r\n    \"nombre_usuario\": \"alejandro\"\r\n}";
            // var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            //var resultado =    JsonSerializer.Deserialize<Persona>(jsonInput, options)  ;


            //var resultado = JsonSerializer.Deserialize<Persona>(jsonInput);


            //Console.WriteLine(resultado.Nombre);

            //string jsonInput = "{\r\n    \"clientes\": [\r\n        {\r\n            \"nombre\": \"Carlos\",\r\n            \"apellido\": \"Perez\",\r\n            \"codCliente\": \"abc123\"\r\n        },\r\n        {\r\n            \"nombre\": \"Fernando\",\r\n            \"apellido\": \"Mossier\",\r\n            \"codCliente\": \"cbd345\"\r\n        }\r\n    ]\r\n\r\n}";
            

            string jsonInput = File.ReadAllText("C:\\Users\\aleja\\Desktop\\CDA CURSO NET\\MODULO 2\\data.json");

            var resultado = JsonSerializer.Deserialize<Empresa>(jsonInput);


            var serializado = JsonSerializer.Serialize(resultado);

            Console.WriteLine(serializado);

            #endregion




        }





        public class Persona 
        {
            [JsonPropertyName("nombre_usuario")] //Opcion2
            public string Nombre { get; set; }



        }

      
        //public class Gestionar<T> 
        //{
        //   public List<T> ListValues { get; set; }

        //    public void AddValue(T newValue) 
        //    {
        //        ListValues.Add(newValue);
        //    }

        //}
        //public class Empresa 
        //{
        //    public string RazonSocial { get; set; }

        //}
        //public class Escuela 
        //{
        //    public string Direccion { get; set; }
        //}

    }

    //public class Persona
    //{
    //    public string Nombre { get; set; }
    //    public List<Amigos> Amigos { get; set; }
    //}
    //public class Amigos { public int Edad { get; set; } }

}