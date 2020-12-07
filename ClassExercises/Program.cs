using System;
using System.Threading;

namespace ClassExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            ExerciseStopwatch(); //Stopwatch Exercise
            //ExercisePost(); //Stackoverflow Post Clone Exercise
            //ExerciseStack(); //Push Pop Clear Stack Exercise

        }

        public static void ExerciseStopwatch()
        {
            var stopWatch = new Stopwatch();
            var appInfo = @"Instruction:
                - Type 'Start' for Starting StopWatch
                - Type 'Stop' for Stoping Stopwatch
                - Type 'Exit' for Exiting app";
            Console.Clear();
            Console.WriteLine(appInfo);
            var check = true;
            while (check)
            {
                try
                {
                    var input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "start":
                            Console.Clear();
                            stopWatch.StartTimer();
                            Console.WriteLine(appInfo);
                            break;
                        case "stop":
                            stopWatch.StopTimer();
                            Console.WriteLine(appInfo);
                            break;
                        case "exit":
                            check = false;
                            Console.WriteLine("Thank You for using stopwatch");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception occured \n" + e.Message);
                    Console.WriteLine(appInfo);
                }
            }
        }

        public static void ExercisePost()
        {
            var post = new Post("Hello World", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
            Console.WriteLine($"Title: { post._postTitle}, Date Posted: {post._postDate}");
            Console.WriteLine($"Description: { post._postDescription}");
            post.VoteUp();
            post.VoteDown();
            post.VoteUp();
            post.VoteUp();
            post.VoteDown();
            Console.WriteLine($"Votes: {post.AmtOfVotes}");
            Console.WriteLine();

            Console.WriteLine("Enter Title:");
            string Title = Console.ReadLine();
            Console.WriteLine("Enter Description:");
            string Potato = Console.ReadLine();
            var post2 = new Post(Title, Potato);
            Console.WriteLine($"{post2._postTitle}, Date Posted: {post2._postDate}");
            Console.WriteLine($"{post2._postDescription}");
            string input = Console.ReadLine();
            switch (input)
            {
                case "z":
                    post2.VoteUp();
                    post2.showVotes();
                    break;
                case "x":
                    post2.VoteDown();
                    post2.showVotes();
                    break;
                default:
                    post2.showVotes();
                    break;
            }

        }
        public static void ExerciseStack()
        {
            var stack = new Stack();
            stack.Push(1); //sends 1
            stack.Push(2); //sends 2 on top of 1
            stack.Push(3); //sends 3 on top of 2
            //stack.Clear();
            Console.WriteLine(stack.Pop()); //3
            Console.WriteLine(stack.Pop()); //2
            Console.WriteLine(stack.Pop()); //1
        }
    }
}
