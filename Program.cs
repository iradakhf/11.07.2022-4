using System;
namespace ConsoleAp32
{
    class Porgram
    {
        public static void Main (string[] args)
        {
            Sheeps sheeps = new Sheeps(4, "sheep");
           
            sheeps.ShowTheNumberOfSheeps();
        }
        class Sheeps
        {
            public int NumberOfSheeps { get; set; }
            public string Name { get; set; }
            public Sheeps(int number, string name)
            {
                this.NumberOfSheeps = number;
                this.Name = name;
            }
          
            public void ShowTheNumberOfSheeps()
            {
               
                    for (int i = 1; i <= this.NumberOfSheeps; i++)
                    {
                        Console.Write($"{i} : {this.Name} , ");
                      
                    }
               
                
            }
        }
    }
}