using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidacionCdfiTutorial.Models
{
    public class RESPUESTA_JSON
    {
        public string CODIGO_ESTATUS { get; set; }
        public string ESTADO { get; set; }
        public string ES_CANCELABLE { get; set; }
        public string ESTATUS_CANCELACION { get; set; }
    }
}