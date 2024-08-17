using System.Collections.Generic;

namespace ExedePrueba.ViewModels
{
    public class ResponseBase
    {
        public bool Error { get; set; }
        public List<string> Mensaje { get; set; }
    }
}