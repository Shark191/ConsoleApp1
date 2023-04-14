public class Player
{
    public string name { get; }
    IGun? gun;
    public int externalAmmo;
    int hp = 100;


    public Player(string n)
    {
        if (n.StartsWith("TempUser"))
        {
            throw new InvalidName("Друже ты пытаешься пикнуть системное имя, так нельзя ес чо.");
        }


        if (n.StartsWith("Admin")) //оч оригинальные проверки знаю знаю
        {
            throw new InvalidName("Че риальна админ на сервере7??77?");
        }


        this.name = n;
    }

    public Player()
    {
        this.name = "TempUser" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
    }


    public void fire() {
        if (this.gun == null)
        {
            Console.WriteLine("А пукалки то нету :(");
            return;
        }

        this.gun.fire();

    }

    public void getHurt(int value) { 
        this.hp -= value;
        if (this.hp < 1) {
            //summon corpse entity

        }
    }

    public void pickGun(IGun g)
    {
        //gun render
        this.gun = g;
    }

    public void dropGun()
    {
        if (this.gun == null)
            return;

        //create item entity
        this.gun = null;
        Console.WriteLine("Gun dropped");
    }

    public void reload() {
        if (this.gun == null)
        {
            Console.WriteLine("Нечего перезаряжать :(");
            return;
        }
        this.gun.reload(this);
    }

}