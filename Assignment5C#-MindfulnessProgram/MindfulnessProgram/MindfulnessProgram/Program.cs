using System;
using System.Threading;

namespace MindfulnessProgram
{
    public class Program
    {
        static void clear_console()
        {
            Console.Clear();

        }
        static void loading()
        {
            string animation = "|/-\\";
            //int anicount = 0;
            foreach (char i in animation)
            {
                Thread.Sleep(500);
                Console.Write("\r" + i);
                Console.Out.Flush();
            }
        }

        static void word_loading(string texty)
        {
            string animation = "|/-\\";
            for (int i = 0; i < animation.Length; i++)
            {
                Thread.Sleep(1000);
                Console.Write($"\r{texty}{animation[i]}");
                Console.Out.Flush();
            }
        }

        static void word_inc_loading(string texty, int timings)
        {
            for (int i = timings; i > 0; i--)
            {
                word_loading(texty);
                Thread.Sleep(1000);
                //Console.WriteLine();
            }
        }

        static void normalized_loading(int timety)
        {
            for (int i = timety; i > 0; i--)
            {
                loading();
                Thread.Sleep(1000);
            }
        }

        static int load_time(int times)
        {
            Console.WriteLine("Getting Ready...");
            int down_time = 0;
            for (int i = times; i > 0; i--)
            {
                down_time = i;
                loading();
                Thread.Sleep(1000);
            }
            return down_time;
        }

        static int count_down(string texty, int timing)
        {
            int i = 0;
            for (i = timing; i >= 0; i--)
            {
                string timery = i.ToString();
                Thread.Sleep(1000);
                Console.Write($"\r{texty} {timery}");
            }
            Console.WriteLine();
            return i;
        }

        static void start_breathing_exercise(int time_input)
        {
            int total_time = time_input;
            int breathe_in = 0;
            int breathe_out = 0;
            Random random = new Random();
            breathe_in = random.Next(2, 5);
            if (total_time <= breathe_in)
            {
                total_time += 2;
            }
            total_time -= breathe_in;
            if (total_time >= 4)
            {
                breathe_out = 4;
            }
            else
            {
                breathe_out = total_time;
            }
            total_time -= breathe_out;

            string breathe_in_text = "Breathe in...";
            count_down(breathe_in_text, breathe_in);
            string breathe_out_text = "Breathe out...";
            count_down(breathe_out_text, breathe_out);
            Console.WriteLine();

            if (total_time != 0)
            {
                start_breathing_exercise(total_time);
            }
        }

        static void start_exercise_for_breathing(int number)
        {
            load_time(3);
            Console.WriteLine("\n");
            start_breathing_exercise(number);
            Console.WriteLine("\nWell done!!!\n");
            //normalized_loading(3);
            Console.WriteLine("You have completed {0} seconds of the Breathing activity\n", number);
            //normalized_loading(3);
            Thread.Sleep(1000);
            Console.ReadLine();
            clear_console();
            //main_handler();
        }





        static void start_reflecting_exercise(int time_input)
        {
            load_time(3);
            Console.WriteLine("\nConsider the following prompt:\n\n--- Think of a time when you did something really difficult. ---\n");
            Console.Write("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            string reflect_text = "You may begin in: ";
            count_down(reflect_text, 3);
            clear_console();
            reflecting_exercise(time_input);
        }

        static void reflecting_exercise(int timing)
        {

            int first_ques_time = (int)(timing * 0.5);
            int sec_ques_time = first_ques_time;
            string first_text = "> How did you feel when it was complete? \n";
            string sec_text = "> What is your favorite thing about this experience? ";
            word_inc_loading(first_text, first_ques_time);
            Console.WriteLine("");
            word_inc_loading(sec_text, sec_ques_time);
            Console.WriteLine("\n\nWell done!!\n");
            normalized_loading(3);
            Console.WriteLine("You have completed {0} seconds of the Reflecting activity\n", timing);
            normalized_loading(3);
            Thread.Sleep(1000);
            clear_console();
        }





        static void ListingFunc(int timing)
        {
            int max = timing;
            DateTime start = DateTime.Now;
            Console.WriteLine("");
            Console.Write("> ");
            string item = Console.ReadLine();
            int maxi = 1;

            while ((DateTime.Now - start).TotalSeconds < max)
            {
                Console.Write("> ");
                Console.ReadLine();
                maxi += 1;
            }

            Console.WriteLine("You listed {0} items!", maxi);
        }

        static void StartListing(int timing)
        {
            load_time(3);
            Console.WriteLine("\n");
            Console.WriteLine("List as many responses you can to the following prompt:\n --- When have you felt the most elated this month? --- \n");
            string list_text = "You may begin in: ";
            count_down(list_text, 5);
            ListingFunc(timing);
            Console.WriteLine("\n\nWell done!!\n");
            normalized_loading(2);
            Console.WriteLine("You have completed another {0} seconds of the Listing activity\n", timing);
            normalized_loading(1);
            Thread.Sleep(1000);
            clear_console();
        }

        static void Main(string[] args)
        {

            int choice;

            while (true)
            {
            exit:
                string pick;
                Console.WriteLine("Menu Options");
                Console.WriteLine("1. Start Breathing activity");
                Console.WriteLine("2. Start Reflecting activity");
                Console.WriteLine("3. Start Listing activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine("***************");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                pick = Console.ReadLine();
                if (String.IsNullOrEmpty(pick) || !int.TryParse(pick, out choice))
                {
                    Console.WriteLine("Invalid Pick");
                    goto exit;
                }
                if (pick == "1")
                {
                    clear_console();
                    Console.WriteLine("  Welcome to the Breathing Activity\n");
                    Console.WriteLine("  This activity will help you relax by \n  walking your through breathing in and out slowly. \n  Clear your mind and focus on your breathing.\n");
                    Console.WriteLine("How long, in seconds, would you like for our session?: ");

                    //loading();
                    var time_in_seconds = Convert.ToInt32(Console.ReadLine());
                    clear_console();
                    start_exercise_for_breathing(time_in_seconds);
                    goto exit;
                }
                else if (pick == "2")
                {
                    clear_console();
                    Console.WriteLine("Welcome to the Reflecting Activity\n\n");
                    Console.WriteLine("This activity will help you reflect on \ntimes in your life when you have shown strength and \nresilience. This will help you recognize the power you have and \nhow you can use it in other aspects of your life.\n");
                    Console.WriteLine("How long, in seconds, would you like for our session?\n");

                    var time_in_seconds = Convert.ToInt32(Console.ReadLine());
                    clear_console();
                    start_reflecting_exercise(time_in_seconds);
                    goto exit;
                }
                else if (pick == "3")
                {
                    clear_console();
                    Console.WriteLine("Welcome to the Listing Activity\n\n");
                    Console.WriteLine("This activity will help you reflect on \ntimes in your life when you have shown strength and \nresilience. This will help you recognize the power you have and \nhow you can use it in other aspects of your life.\n");
                    Console.WriteLine("How long, in seconds, would you like for our session?");

                    var time_in_seconds = Convert.ToInt32(Console.ReadLine());
                    clear_console();
                    StartListing(time_in_seconds);
                    goto exit;
                }
                else if (pick == "4")
                {
                    clear_console();
                    Console.WriteLine("\n THANK YOU…");
                    Environment.Exit(0);
                }
            }
        }
    }
}
