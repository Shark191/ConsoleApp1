

using Guns;

class Program{

    static void Main(string[] args)
    {
        Player Vova = new Player("Vova");

        Vova.externalAmmo = 13;

        Vova.pickGun(new Handgun(1, 12));

        Vova.reload();

        Console.WriteLine(Vova.externalAmmo);

        for (int i = 0; i != 12; i++)
            Vova.fire();


        Vova.reload();
        
        Vova.fire();
        Vova.fire();

    }

}