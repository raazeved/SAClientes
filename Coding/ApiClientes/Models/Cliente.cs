
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiClientes.Models

{
public class Cliente {

    [Key]
    public int CliId { get; set; }
    
    public string Nome {get;set;}

    public System.DateTime DataNasc {get;set;}

    public string CNPJ_CPF {get;set;}

    public string DOC {get;set;}

    public string EndPri {get;set;}
    
    public int NumPri { get; set; }

    public string ComplPri { get; set; }

    public string BaiPri {get;set;}

    public string CEP { get; set; }

    public string CidPri {get;set;}

    public string UF {get;set;}

    public string TelPri {get;set;}

    public string WhatsApp {get;set;}

    public string email {get;set;}

    public string Status {get;set;}
}

}