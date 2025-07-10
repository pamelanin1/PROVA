using System.Net.NetworkInformation;

public class Voo : Passageiro
{
    public string _num {  get; set; }
    public string _origem { get; set; }
    public string _destino { get; set; }
    public DateTime _data {  get; set; }
    public DateTime _horario { get; set; }
    public string _Tota_assento { get; set; }
    public string _Portao_embarque {  get; set; }
    public string _nome_aeronave { get; set; }
    public double _taxa_embarque { get; set; }


    public virtual double CalcularTaxas()
    {
        
       return _taxa_embarque;
      

    }
    public void Construtor(string num, string origem,
        string destino, string totalAssento, string PortaoEmbarque, string nomeAeronave)
    {
        _num = num;
        _origem = origem;
        _destino = destino;
        _Tota_assento = totalAssento;
        _Portao_embarque = PortaoEmbarque;
        _nome_aeronave = nomeAeronave;  
        


        double valor;
        if (_taxa_embarque < 1)
        {

            valor = 0;

        }
        else
        {
            Console.WriteLine("VALOR INVÁLIDO!");
        }



    }










}