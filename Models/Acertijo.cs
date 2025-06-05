using Newtonsoft.Json;
public class Acertijo
{
          [JsonProperty]
      public List<string> RespuestasCorrectas { get; set; } = new List<string>
        {
            "FRANCIA",         
            "LILLE",         
            "CAMPOS Y PICO", 
            "4312"         
        };
        
          [JsonProperty]
      public List<string> pistas { get; set; } = new List<string>
        {
            "A simple vista, todo parece en orden... pero ¿y si uno de ellos estuviera mintiendo? Observá con atención los pasaportes. A veces, los errores revelan más de lo que ocultan.",         
            "Observá con atención lo primero de cada imagen, quizá ahí haya una clave",         
            "Busca en el mapa los nombres que miran al cielo y tocan la tierra. La verdad está donde ambos se cruzan.", 
            "4312"         
        };
                [JsonProperty]

        public int SalaActual { get; set; }
                [JsonProperty]

 
        public string RespuestaJugador { get; set; }
                [JsonProperty]

  
        public bool gano { get; set; }

         public bool ValidarRespuesta(string RespuestaJugador)
  {

    RespuestaJugador = RespuestaJugador.ToUpper();
       if (RespuestaJugador == RespuestasCorrectas[SalaActual])
    {
        gano = true;
         
        
    }
    else
    {
        gano = false;
    }


    return gano;
    
  }
           public bool ValidarRespuestaFinal(string RespuestaJugador)
  {
 bool finalizo = false;
    RespuestaJugador = RespuestaJugador.ToUpper();
       if (RespuestaJugador == RespuestasCorrectas[3])
    {
        finalizo = true;
         
        
    }
 


    return finalizo;
    
  }
  public string darPistas ()
  {
       string pista = pistas[SalaActual];
       return pista;
  }

}
 


