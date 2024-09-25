namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

         public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
             Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // FEITO
        public override void InstalarAplicativo(string nomeApp)
       {
         Console.WriteLine("Realizando a instalação do aplicativo para Nokia...");
        }
    }
}
