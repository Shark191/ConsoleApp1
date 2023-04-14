namespace Guns {
    class Handgun : IGun {


        public Handgun(int d, int m) : base(d, m) { }
        override public void fire() {

            Console.WriteLine("Пуль " + this.countOfBullets + " из " + this.maxBullets);
            
            if (this.countOfBullets == 0 ) {
                Console.WriteLine("В пукалке нету пуль");
                return;
            }

            this.countOfBullets -= 1;

            Console.WriteLine("Пистолетил делает пуф в точку");
        }

    } 
}