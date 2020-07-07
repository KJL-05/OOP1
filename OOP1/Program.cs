using Newtonsoft.Json;
using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            People wanghuo = GeneratePeople();
            People xiaohong = GeneratePeople();
            People xiaoliang = GeneratePeople();
            People xiaoming = GeneratePeople();
            xiaohong.Age = 16;
            xiaoming.Age = 62;
            xiaoliang.Age = 20;
            PeopleCurdRepositorty database = new PeopleCurdRepositorty();
            database.Add(wanghuo);
            database.Add(xiaohong);
            database.Add(xiaoliang);
            database.Add(xiaoming);

            Console.WriteLine(JsonConvert.SerializeObject(database.GetAll()));


           /* People wanghuo;
            wanghuo = new People();
            wanghuo.Id = "20001518464851561";
            wanghuo.Name = "旺火";
            wanghuo.Gender = true;
            wanghuo.Birthday = new DateTime(2000, 01, 20,12,10,36);
            wanghuo.Eat(99);
            //序列化
            Console.WriteLine(JsonConvert.SerializeObject(wanghuo));
            //反序列化
            People wanghuo2 = JsonConvert.DeserializeObject<People>(JsonConvert.SerializeObject(wanghuo));
       */ }

        static People GeneratePeople()
        {
            People wanghuo;
            wanghuo = new People();
            wanghuo.IdNumber = "20001518464851561";
            wanghuo.Name = "旺火";
            wanghuo.Gender = true;
            wanghuo.Birthday = new DateTime(2000, 01, 20, 12, 10, 36);
            wanghuo.Eat(99);
            return wanghuo;
        }

    }

    class PeopleCurdRepositorty : RepositoryBase<People> { }


    class People:DomainModel
    {
        public People()
        {
        }
        //成员方法  行为


        public void Eat(int foodsize)
        {
            HungerIndex = HungerIndex + foodsize / 2;
        }
        //成员变量
        public int HungerIndex;
        public string IdNumber; //唯一标识符
        public string Name;
        public bool Gender;
        public int Age;
        public DateTime Birthday;
        public string Professional;
    }

}
