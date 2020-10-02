using System.ComponentModel.DataAnnotations;

namespace recibo.Models
{
    public class Recibo
    {
        public int Id { get; set; }

        [Required (ErrorMessage="Esse campo é Obrigatorio")]
        public string NomeEmissor { get; set; }
        public string DocumentoEmissor { get; set; }
        public string TelefoneEmissor { get; set; }
        
        [Required (ErrorMessage="Esse campo é Obrigatorio")]
        public string NomePagador { get; set; }
        public string DocumentoPagador { get; set; }
        
        [Required (ErrorMessage="Esse campo é Obrigatorio")]
        public string referente { get; set; }
        
        [Required (ErrorMessage="Esse campo é Obrigatorio")]
        public decimal valor { get; set; }

        [Required (ErrorMessage="Esse campo é Obrigatorio")]
        public string data  { get; set; }
        public string cidade { get; set; }
        
        //[Required (ErrorMessage="Esse campo é Obrigatorio")]
        public string FormaPagamento { get; set; }
    }
}