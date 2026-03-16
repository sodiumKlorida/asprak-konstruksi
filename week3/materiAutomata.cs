using System;
using System.Collections.Generic;
using System.Text;

namespace week3
{
    internal class materiAutomata
    {
        // STATE (KEADAAN/PERISTIWA)
        public enum State
        {
            START,
            GAME,
            PAUSE,
            EXIT
        }

        public static void automataRun()
        {
            State state = State.START;

            while (state != State.EXIT)
            {
                switch (state)
                {
                    case State.START:
                        state = Start();
                        break;

                    case State.GAME:
                        state = Game();
                        break;

                    case State.PAUSE:
                        state = Pause();
                        break;
                }
            }

            Exit();
        }

        // STATE START
        public static State Start()
        {
            Console.WriteLine("\nSTART SCREEN");
            Console.WriteLine("Hint");
            Console.WriteLine("- ENTER");
            Console.WriteLine("- QUIT");
            Console.Write("Enter Command : ");

            string command = Console.ReadLine();

            if (command == "ENTER")
                return State.GAME;
            else if (command == "QUIT")
                return State.EXIT;
            else
                return State.START;
        }

        // STATE GAME
        public static State Game()
        {
            Console.WriteLine("\nGAME SCREEN");
            Console.WriteLine("Hint");
            Console.WriteLine("- ESC");
            Console.Write("Enter Command : ");

            string command = Console.ReadLine();

            if (command == "ESC")
                return State.PAUSE;
            else
                return State.GAME;
        }

        // STATE PAUSE
        public static State Pause()
        {
            Console.WriteLine("\nPAUSE SCREEN");
            Console.WriteLine("Hint");
            Console.WriteLine("- BACK");
            Console.WriteLine("- HOME");
            Console.WriteLine("- QUIT");
            Console.Write("Enter Command : ");

            string command = Console.ReadLine();

            if (command == "BACK")
                return State.GAME;
            else if (command == "HOME")
                return State.START;
            else if (command == "QUIT")
                return State.EXIT;
            else
                return State.PAUSE;
        }

        // EXIT SCREEN
        public static void Exit()
        {
            Console.WriteLine("EXIT SCREEN");
        }
    }
}

