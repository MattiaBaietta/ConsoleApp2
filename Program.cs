using System.Runtime.CompilerServices;

internal class Program
{
    static void Main(string[] args)
    {
        Persona pippo = new Persona("jammebell","esposito",10);
        Console.WriteLine(pippo.Dettagli);

        Persona pippo2 = new Persona();
        Console.WriteLine(pippo2.Dettagli);
        
        
    }
}

public class Persona
{
    private string _nome = "Nome non valido";
    private string _cognome = "Non impostato";
    private int _eta = 0;
    
    public Persona(string nome,string cognome,int eta)
    {
        if (nome.Length>2)
        {
            _nome = char.ToUpper(nome[0])+nome.Substring(1);
        }
        
        _cognome = char.ToUpper(cognome[0]) + cognome.Substring(1);
        _eta = eta;
    }
    public Persona()
    {

    }

    public string Dettagli
    {
        get
        {
            return $"Il nome: {_nome} il cognome: {_cognome} di eta:{_eta}";
        }
    }
    

}
