using System;

namespace trees
{
    abstract class Trees
    {   
        public int age;   
        public double lenght;
        public string name;
        public int year = 0;

        public abstract void Lenghter(); //увеличение роста дерева
        
        public void Ager(){ //увеличение возраста дерева
            age+=year; 
        }

        // наличие(отсутствие) листвы
        public virtual void Listva(int season)
        {
            if (season%2==0){
                Console.WriteLine("Листья есть");
            }
            if (season%2!=0){
                Console.WriteLine("Листьев нет");
            }       
        }
        public void Info(){
            Console.WriteLine($" \nИмя: {name} \nВозраст: {age} \nДлинна: {lenght}");
        }
    }
    class Dub : Trees
    {
        public override void Lenghter()
        {
            lenght+=0.2*year;
        }

    }
    class Bereza : Trees
    {
        public override void Lenghter()
        {
            lenght+=0.3*year;
        }
    }

    class Listven : Trees
    {
        public override void Listva(int season)
        {
            if (season!=-1){
                Console.WriteLine("Листьев Нет");
            }    
        }
        public override void Lenghter()
        {
            lenght+=0.4*year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Однажды вам было нечего делать летом и вы решили посадить деревo...");
            Listven l1 = new Listven();
            l1.name = "Лиственница";

            Console.WriteLine("Введите возраст дерева");
            l1.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите рост дерева");
            l1.lenght = Convert.ToInt32(Console.ReadLine());

            while(l1.lenght>20){
                Console.WriteLine("Введите рост дерева меньше 20м");
                l1.lenght = Convert.ToInt32(Console.ReadLine());
            }
            
            int season;
            Console.WriteLine("Сколько прошло сезонов:?");
            season = Convert.ToInt32(Console.ReadLine());
            while(season!=-1)
            {
                l1.year+=(season/2);

                l1.Listva(season);
                l1.Ager();
                if (l1.lenght<20){
                    l1.Lenghter();
                }
                l1.Info();

                l1.year = 0;
                Console.WriteLine("Сколько прошло сезонов:?");
                season = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
