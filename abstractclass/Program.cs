using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
    //public abstract class DbSet<T> where T : class
    //{
    //    public bool Create(T entity) 
    //    {
    //        Console.WriteLine("was createt");
    //        return true;
    //    }
    //    public T Read (T entity)
    //    {
    //        Console.WriteLine("was read");
    //        return null;
    //    }
    //    public bool Update(T entity)
    //    {
    //        Console.WriteLine("was updated");
    //        return true;
    //    }
    //    public bool Delete (T entity)
    //    {
    //        Console.WriteLine("was deleted");
    //        return true;
    //    }
    //}
    public abstract class BaseRepositry<T> where T : class
    {
        public bool Create(T entity)
        {
            Console.WriteLine(entity.GetType());
            Console.WriteLine("was created");
            return true;
        }
        public T Read(T entity)
        {
            Console.WriteLine("was read");
            return null;
        }
        public bool Update(T entity)
        {
            Console.WriteLine("was updated");
            return true;
        }
        public bool Delete(T entity)
        {
            Console.WriteLine("was deleted");
            return true;
        }
    }

    class FoodRepository : BaseRepositry<Food>
    {

    }

    class Food
    {
        public decimal Price { get; set; }
        public string Name{ get; set; }
        public List<Ingridient> Ingredients { get; set; }

    }
    class Ingridient
    {
        public string Name{ get; set; }
        public double Protein { get; set; }
        public double Fats { get; set; }
    }

    class Drinks
    {
        public string Name { get; set; }
        public double Price{ get; set; }
    }

    class DrinksRepository : BaseRepositry<Drinks>
    {

    }

    public class Human<T>
    {
        public T MyProperty { get; set; }

    }



    abstract class Oven
    {
        public abstract void Heat();

        public void Print()
        {
            Console.WriteLine("Yo");
        }
    }

    class GasOven : Oven
    {
        public int MyProperty { get; set; }

        public override void Heat()
        {
            Console.WriteLine("Gas");
        }
    }
    class ElectricOven : Oven 
        {
        public override void Heat()
        {
            Console.WriteLine("Electric");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Oven oven = new GasOven();
            oven.Heat();


            Food food = new Food();
            food.Name = "Salat";
            food.Price = 153;
            food.Ingredients = new List<Ingridient>();
            food.Ingredients.Add(new Ingridient { Fats = 15.3, Name = "Truf", Protein = 15.6 });

            Food food1 = food;
            Console.WriteLine($"{food.GetHashCode()}, {food1.GetHashCode()}");

            BaseRepositry<Food> foodRepository = new FoodRepository();
            foodRepository.Create(food);

            Drinks drinks = new Drinks { Name = "Beer", Price = 10};
            BaseRepositry<Drinks> drinksRepository = new DrinksRepository();
            drinksRepository.Create(drinks);

        }
    }
}
