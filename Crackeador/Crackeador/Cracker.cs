namespace Crackeador
{
    public class Cracker
    {
        public int Medium { get; set; }
        public int High { get; set; }
        public int SuperHigh { get; set; }
        public string Login { get; set; }
        public void Download(int quality, int time, string nomeFilme)
        {
            Console.WriteLine($"O filme {nomeFilme} será baixado no tamanho de {quality}GB em {time * quality} minutos.");
        }
    }
}