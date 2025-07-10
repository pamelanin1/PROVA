public class Reserva : Passageiro
{

    public string _passageiro {  get; set; }
    public string _numero_assento { get; set; }
    public double _valorPassagem { get; set; }
    public string _status {  get; set; }
    public string _classe { get; set; }


    public void Construtor(string passageiro, string numero_assento, string status, string classe, double valorPassagem)
    {

        _passageiro = passageiro;
        _numero_assento = numero_assento;
        _status = status;
        _classe = classe;
        _valorPassagem = valorPassagem;


        double valor;
        if (valorPassagem < 1)
        {
            
            valor = 0;

        }
        else
        {
            Console.WriteLine("VALOR INVÁLIDO!");
        }

       

    }
    
    






}