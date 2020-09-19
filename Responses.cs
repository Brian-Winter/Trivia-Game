using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TriviaGame
{
    class Responses
    {
        List<string> CorrectResponses = new List<string>();

        public void CorrectAnswerResponse()
        {
            Console.WriteLine("Great Job!");
        }

        public void InCorrectAnswerResponse()
        {
            Console.WriteLine("You messed up. Just try again!");
        }
        public void NextQuestion()
        {
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
