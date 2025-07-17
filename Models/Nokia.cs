namespace DesafioPOO.Models
{
    // Herdado da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {
            
        }
        // Sobrescrevido o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando APP {nomeApp} no Nokia");
        }
    }
}