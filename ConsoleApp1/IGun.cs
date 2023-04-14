public abstract class IGun
{
    protected int maxBullets;
    protected int damage;

    protected int countOfBullets;

    protected void setBullets(int value) {
        //client side HUD render
        this.countOfBullets = value;
    }


    public IGun(int d, int m) { 
        this.damage =  d;
        this.maxBullets =  m;
        this.countOfBullets = 0;
    }

    public abstract void fire();
    public void reload(Player p) {
        Console.WriteLine("Перезарядка...");

        if (p.externalAmmo == 0) { 
            //server side check run out of ammo
            Console.WriteLine("А пулек нету(((((");
            return;
            
        }


        p.externalAmmo += this.countOfBullets;

        
        int newAmmo = p.externalAmmo - this.maxBullets;

        if (newAmmo < 0)
        {
            this.setBullets(this.countOfBullets + p.externalAmmo);
            p.externalAmmo = 0;
        }
        else {
            p.externalAmmo = newAmmo;
            this.setBullets(this.maxBullets);
        }

    }

}

