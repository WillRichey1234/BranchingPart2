using System;

namespace BranchingPart2
{
    class MainClass
    {
        //METHODS = FUNCTIONS IN CODE HS
        public static void Main(string[] args)
        {
            //string myValue = superSecretFormula("world");
            // this private static string allows me to write the word hello in front of other words
            //so that I do not have to write the same code twice
            string myValue = superSecretFormula("sunshine");
            Console.WriteLine(myValue);
            Console.ReadLine();
                              
        }
        // this is like a private function in codehs
        // i can call it anywhere and run it a bunch so i do not have to write code twice
        // void means it will not return anything like in public static void

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}!", name);
        }
    }
}
