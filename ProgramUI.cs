using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TriviaGame
{
    public class ProgramUI
    {
        System.Random random = new System.Random();
        Responses userResponse = new Responses();
        Animation animations = new Animation();

        List<string> Questions = new List<string>();
        List<string> Answers = new List<string>();
       
        public void Run()
        {
            //animations.Winner();
           animations.Intro();
           Menu();
          
        }

        private void Menu()
        {
            bool menuRunning = true;
            while (menuRunning)
            {
                Console.WriteLine("Trivia menu\n" +
                    "1) One Player\n" +
                    "2) Two Players\n" +
                    "3) Kid Mode\n" +
                    "4) Exit\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //First thing
                        Console.Clear();
                        OnePlayer();
                        break;
                    case "2":
                        //Second thing
                        Console.Clear();
                        TwoPlayer();
                        break;
                    case "3":
                        //Third thing
                        Console.Clear();
                        KidMode();
                        break;
                    case "4":
                        //Exit
                        menuRunning = false;
                        break;
                    default:
                        //Try again.
                        Console.WriteLine("Choose a valid option.");
                        break;
                }

                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        

       
        private void NormalQuestions()
        {

            Questions.Add("How many soccer players should each team have on the field at the start of each match?");
            Questions.Add("When Michael Jordan played for the Chicago Bulls, how many NBA Championships did he win?");
            Questions.Add("Which Williams sister has won more Grand Slam titles?");
            Questions.Add("Which Jamaican runner is an 11-time world champion and holds the record in the 100 and 200-meter race?");
            Questions.Add("Which boxer was known as “The Greatest” and “The People’s Champion”?");
            Questions.Add("What year was the very first model of the iPhone released?");
            Questions.Add("What is often seen as the smallest unit of memory?");
            Questions.Add("Which email service is owned by Microsoft?");
            Questions.Add("What was Twitter’s original name?");
            Questions.Add("What is the symbol for potassium?");
            Questions.Add("Which planet is the hottest in the solar system?");
            Questions.Add("Which natural disaster is measured with a Richter scale?");
            Questions.Add("Which planet has the most gravity?");
            Questions.Add("Which animal can be seen on the Porsche logo?");
            Questions.Add("What is the common name for dried plums?");
           
            Answers.Add("11");
            Answers.Add("Six");
            Answers.Add("Serena");
            Answers.Add("Usain Bolt");
            Answers.Add("Muhammad Ali");
            Answers.Add("2007");
            Answers.Add("kilobyte");
            Answers.Add("Hotmail");
            Answers.Add("Twitter");
            Answers.Add("K");
            Answers.Add("Venus");
            Answers.Add("Earthquakes");
            Answers.Add("Jupiter");
            Answers.Add("Horse");
            Answers.Add("Prunes");
        }

        private void HardQuestionsGroup()
        {

            Questions.Add("Who is often called the father of the computer?");
            Questions.Add("In what year was the Corvette introduced?");
            Questions.Add("What musical term is indicates a chord where the notes are played one after another rather than all together?");
            Questions.Add("In which sport are barani, rudolph and randolph all techniques?");
            Questions.Add("Which instrument is associated with Earl ‘Bud’ Powell?");
            Questions.Add("In which branch of the arts is Katherine Dunham famous?");
            Questions.Add("Hamilton Kindley Field international airport is in which country?");
            Questions.Add("In which country is the Troi-Rivieres bridge?");
            Questions.Add("Ken Thompson and Dennis Ritchie co-created which operating system?");
            Questions.Add("From 1919 to 1933, the Weimar Republic was the government of what nation?");
            Questions.Add("A “crepuscular” animal becomes active at what time?");
            Questions.Add("What was the first movie to be rated PG-13?");
            Questions.Add("Who was the first person to suggest Daylight Savings Times?");
            Questions.Add("If you order “murgh” from the menu at an Indian restaurant, what meat will you get?");
            Questions.Add("So far, which continent has hosted the Olympics the most times?");
           
            
            Answers.Add("Charles Babbage");
            Answers.Add("1953");
            Answers.Add("Arpeggio");
            Answers.Add("Trampoline");
            Answers.Add("Piano");
            Answers.Add("Ballet");
            Answers.Add("Bermuda");
            Answers.Add("Canada");
            Answers.Add("Unix");
            Answers.Add("Germany");
            Answers.Add("Dusk");
            Answers.Add("Red Dawn");
            Answers.Add("Benjamin Franklin");
            Answers.Add("Chicken");
            Answers.Add("Europe");
            
        }
        private void KidQuestions()
        {

            Questions.Add("How many legs does a spider have?");
            Questions.Add("What is the name of the toy cowboy in Toy Story?");
            Questions.Add("What is the color of an emerald?");
            Questions.Add("What’s the name of a place you go to see lots of animals?");
            Questions.Add("What is the name of the fairy in Peter Pan?");
            Questions.Add("If you freeze water, what do you get?");
            Questions.Add("How many planets are in our solar system?");
            Questions.Add("What fruit do kids traditionally give to teachers?");
            Questions.Add("Which Disney movie is Elsa in?");
            Questions.Add("Who is Mickey Mouse’s girlfriend?");
            Questions.Add("Where does Santa Claus live?");
            Questions.Add("According to the Dr. Seuss book, who stole Christmas?");
            Questions.Add("What do caterpillars turn into?");
            Questions.Add("What is the color of a school bus?");
            Questions.Add("On which holiday do you go trick-or-treating?");
           
            Answers.Add("Eight");
            Answers.Add("Woody");
            Answers.Add("Green");
            Answers.Add("Zoo");
            Answers.Add("Tinkerbell");
            Answers.Add("Ice");
            Answers.Add("Eight");
            Answers.Add("Apple");
            Answers.Add("Frozen");
            Answers.Add("Minnie Mouse");
            Answers.Add("The North Pole");
            Answers.Add("Grinch");
            Answers.Add("Butterflies");
            Answers.Add("Yellow");
            Answers.Add("Halloween");
            

        }

        private int AmountOfQuestions()
        {
            
            Console.Clear();
            Console.WriteLine("How many? 1 - " + Questions.Count());
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > Questions.Count())
            {
                //Add verication
                Console.WriteLine("Please try again");
                return AmountOfQuestions();

            }
            else
            {
                Console.Clear();
                return amount;

            }
        }
        private void OnePlayer()
        {
           
           
            //Add verication by while loop
            Console.WriteLine("Pick difficulty\n" +
                "1. Normal\n" +
                "2. Hard\n" +
                "3. All");
            string inputDifficulty = Console.ReadLine();
            switch (inputDifficulty)
            {
                case "1":
                    NormalQuestions();
                    break;
                case "2":
                    HardQuestionsGroup();
                   break;
                case "3":
                    KidQuestions();
                    NormalQuestions();
                    HardQuestionsGroup();
                    break;
                default:
                    Console.WriteLine("not an option");
                    
                    break;
            }

            int counter = 0;
            int score = 0;
            //int fullCount = TestQuestions.Count();
            int amountOfQuestions = AmountOfQuestions();
            while (counter < amountOfQuestions)
            {
                counter++;
                int questionNumber = random.Next(Questions.Count() - 1);
                Console.WriteLine($"Question: {counter}/{amountOfQuestions}");
                Console.WriteLine(Questions[questionNumber]);
                string input = Console.ReadLine().ToLower();
                if (input == Answers[questionNumber].ToLower())
                {
                    userResponse.CorrectAnswerResponse();
                    score++;

                }
                else
                {
                    userResponse.InCorrectAnswerResponse();

                }
                Questions.RemoveAt(questionNumber);
                Answers.RemoveAt(questionNumber);
                userResponse.NextQuestion();
            }
       //     Console.WriteLine("You got " + score + " out of " + counter + ".");
            if (score >= (counter / 2))
            {
                Thread.Sleep(2000);
                animations.Winner();
                Console.WriteLine("You got " + score + " out of " + counter + ".");
                Console.WriteLine("Thanks for playing!");
                Thread.Sleep(3000);

            }
            else
            {
                animations.BadResults();
            }
            Questions.Clear();
            Answers.Clear();
        }
        private void TwoPlayer()
        {


            //Add verication by while loop
            Console.WriteLine("Pick difficulty\n" +
                "1. Normal\n" +
                "2. Hard\n" +
                "3. All");
            string inputDifficulty = Console.ReadLine();
            switch (inputDifficulty)
            {
                case "1":
                    NormalQuestions();
                    break;
                case "2":
                    HardQuestionsGroup();
                    break;
                case "3":
                    KidQuestions();
                    NormalQuestions();
                    HardQuestionsGroup();
                    break;
                default:
                    Console.WriteLine("not an option");

                    break;
            }
            int scoreOne = 0;
            int scoreTwo = 0;
            int counter = 0;
            int amountOfQuestions = AmountOfQuestions();
            while (counter < amountOfQuestions)

            {
                bool correctOne = false;
                bool correctTwo = false;
                counter++;
                int questionNumber = random.Next(Questions.Count() - 1);
                Console.WriteLine($"Question: {counter}/{amountOfQuestions}");
                Console.WriteLine(Questions[questionNumber]);
                Console.WriteLine("Player One, please input your answer.");
                string inputOne = Console.ReadLine().ToLower();
                if (inputOne == Answers[questionNumber].ToLower())
                {

                    scoreOne++;
                    correctOne = true;

                }

                Console.WriteLine("Player Two, please input your answer.");
                string inputTwo = Console.ReadLine().ToLower();
                if (inputTwo == Answers[questionNumber].ToLower())
                {

                    scoreTwo++;
                    correctTwo = true;

                }



                if (correctOne && correctTwo)
                {
                    userResponse.CorrectAnswerResponse();
                }
                else if (correctOne)
                {
                    Console.WriteLine("Player One:");
                    userResponse.CorrectAnswerResponse();
                }
                else if (correctTwo)
                {
                    Console.WriteLine("Player Two:");
                    userResponse.CorrectAnswerResponse();
                }
                else
                {
                    userResponse.InCorrectAnswerResponse();

                }
                Questions.RemoveAt(questionNumber);
                Answers.RemoveAt(questionNumber);
                userResponse.NextQuestion();
            }

            Console.WriteLine("Player One received " + scoreOne + " out of " + counter + ".");
            Console.WriteLine("Player Two received " + scoreTwo + " out of " + counter + ".");
            string winner;
            if(scoreOne == scoreTwo)
            {
                Console.WriteLine("TIE!");
            }
            if (scoreOne > scoreTwo)
            {
                winner = "Player One";
                Thread.Sleep(3000);
                animations.Winner();
                Console.WriteLine(winner);
                Thread.Sleep(3000);
                Answers.Clear();
                Questions.Clear();
            }
            else if (scoreOne < scoreTwo)
            {
                winner = "Player Two";
                Thread.Sleep(3000);
                animations.Winner();
                Console.WriteLine(winner);
                Thread.Sleep(3000);
                Answers.Clear();
                Questions.Clear();
            }
           
        }

        private void KidMode()

        {
            
            //Add verication by while loop
            KidQuestions();

            int counter = 0;
            int score = 0;
            //int fullCount = TestQuestions.Count();
            int amountOfQuestions = AmountOfQuestions();
            while (counter < amountOfQuestions)
            {
                counter++;
                int questionNumber = random.Next(Questions.Count() - 1);
                Console.WriteLine($"Question: {counter}/{amountOfQuestions}");
                Console.WriteLine(Questions[questionNumber]);
                string input = Console.ReadLine().ToLower();
                if (input == Answers[questionNumber].ToLower())
                {
                    userResponse.CorrectAnswerResponse();
                    score++;

                }
                else
                {
                    userResponse.InCorrectAnswerResponse();

                }
                Questions.RemoveAt(questionNumber);
                Answers.RemoveAt(questionNumber);
                userResponse.NextQuestion();
            }
            Console.WriteLine("You got " + score + " out of " + counter + ".");
            Questions.Clear();
            Answers.Clear();
        }
    
    }
}
