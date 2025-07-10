public class Passageiro
{
    public int id {  get; set; }
    public string nome {  get; set; }
    public string cpf { get; set; }
    public string dataNascimento { get; set; }
    public string email { get; set; }
    public string telefone { get; set; }

   
 

    public void Construtor( int _id, string _nome, string _cpf, string Data, string _email, string Telefone)
    {
        id = _id;
        nome = _nome;
        cpf = _cpf;
        dataNascimento = Data;
        email = _email;
        telefone = Telefone;
    }

    

    
    



}