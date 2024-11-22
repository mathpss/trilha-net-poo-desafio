namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            //Implementado!!!!!!!!!!
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //Implementado!!!!!!!!!!
        protected string Modelo;

        protected string Imei;

        protected int Memoria;
        

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}