using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30_02_iida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(DateTime.Today, "IM", 19, 26, 70);
            Console.WriteLine($"名前{student.Name} 年齢{student.Age} 学籍番号{student.StudentNumber} 誕生日{student.birthday.Date} 今日は誕生日か({student.CheckBirthDay()}) 寿命{student.life_span}");
            Worker worker = new Worker("デジタル太郎", "プログラマー", DateTime.Today, 6);
            Console.WriteLine($"名前{worker.Name} 職業名{worker.ProfessionName} 年齢{worker.Age} 誕生日{worker.birthday.Date}");
            Fish fish = new Fish(DateTime.Today, "カツオ", 19, 8);
            Console.WriteLine($"名前{fish.Name} 重さ{fish.Weight}(kg) 寿命{fish.life_span}");
            Refrigerator refrigerator = new Refrigerator(DateTime.Today, "冷蔵庫", 75, 200, 100, 40);
            Console.WriteLine($"名前{refrigerator.Name} 重さ{refrigerator.Weight}");
            Insect insent = new Insect(DateTime.Today, "カブトムシ", 1);
            Console.WriteLine($"名前{insent.Name}");
            Car car = new Car(DateTime.Today, "トヨタ", 148, 200, 340, 904);
            Console.WriteLine($"名前{car.Name} 重さ{ car.Weight} (kg)");
            Cat cat = new Cat(DateTime.Today, "三毛猫", 10);
            Console.WriteLine($"名前{cat.Name} 寿命{cat.life_span}");
            Bird bird = new Bird(DateTime.Today, "梟", 5);
            Console.WriteLine($"名前{bird.Name} 寿命{bird.life_span}");
        }
    }
}
