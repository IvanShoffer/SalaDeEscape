using Newtonsoft.Json;
public class Acertijo
{
      public List<string> RespuestasCorrectas { get; set; } = new List<string>
        {
            "Francia",         
            "Lille",         
            "Campos y Pico", 
            "4312"         
        };

 
        public int SalaActual { get; set; }

 
        public string RespuestaJugador { get; set; }

  
        public bool gano { get; set; }
         public bool ValidarRespuesta(string RespuestaJugador)
  {
    RespuestaJugador = RespuestaJugador.ToUpper();
    
  }
}
 



