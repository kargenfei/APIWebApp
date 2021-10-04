using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNetCheckpoint.Controllers
{
    [ApiController]
    [Route("funcontroller")]
    public class FunController : ControllerBase
    {
        [HttpGet("inchesconverter/{inches}")]
        public double InchesConverter(double inches)
        {
            var convertedCm = inches * 2.54;
            return convertedCm;
        }

        [HttpGet("fahrenheitconverter/{fahrenheit}")]
        public double FahrenheitConverter(double fahrenheit)
        {
            var celsius = (fahrenheit - 32) * 5.0 / 9.0;
            return celsius;
        }
        [HttpGet("namearray/{number}/{name}")]
        public string[] NameArray(int number, string name)
        {
            List<string> nameArray = new List<string>();
            for (int n = 1; n < number + 1; n++)
                nameArray.Add(name + n.ToString());
            return nameArray.ToArray();
        }
        [HttpGet("reversearray/{word}")]
        public string ReverseArray(string word)
        {
            string newString = new string(word.ToCharArray().Reverse().ToArray());
            return newString;
        }
        [HttpGet("returndogarray/{name}/{age}/{breed}")]
        public string ReturnDogArray(string name, int age, string breed)
        {
            var inputDog=new Dog(name, age, breed);
            return inputDog.ToString();
        }

        public class Dog
        {
            public string Name;
            public int Age;
            public string Breed;
            public Dog(string name, int age, string breed)
            {
                Name = name;
                Age = age;
                Breed = breed;
            }
            public override string ToString(){
                return $"{Name}, {Age}, {Breed}";
            }
        }
    }
}
