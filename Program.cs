namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane cane = new Cane();
            Passerotto passerotto = new Passerotto();
            Aquila aquila = new Aquila();
            Delfino delfino = new Delfino();

            cane.Dormi();
            passerotto.Dormi();
            aquila.Dormi();
            delfino.Dormi();

            cane.Mangia();
            passerotto.Mangia();    
            aquila.Mangia();
            delfino.Mangia();

            cane.Verso();
            passerotto.Verso(); 
            aquila.Verso();
            delfino.Verso();    
        }
    }
}