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

            List<Animale> animali = new List<Animale>() { cane, passerotto, aquila, delfino };

            foreach (Animale animale in animali)
            {
                animale.Dormi();
                animale.Mangia();
                animale.Verso();

                if (animale is IVolante)
                    FaiVolare((IVolante)animale);
                else if (animale is INuotante)
                    FaiNuotare((INuotante)animale);
                Console.WriteLine();
            }
        }

        public static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }

        public static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }
    }
}