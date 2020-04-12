﻿using System;
using System.Collections.Generic;

namespace Problem04BorderControl
{
    public class Engine
    {
        public void Run()
        {
            List<Passanger> passangers = new List<Passanger>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];

                    Citizen citizen = new Citizen(name, age, id);

                    passangers.Add(citizen);
                } 
                else
                {
                    string name = tokens[0];
                    string id = tokens[1];

                    Robot robot = new Robot(name, id);

                    passangers.Add(robot);
                }
            }

            string lastNums = Console.ReadLine();

            for (int i = 0; i < passangers.Count; i++)
            {
                bool isLastTreeNums = passangers[i].Id.LastIndexOf(lastNums) == passangers[i].Id.Length - lastNums.Length;

                if (isLastTreeNums)
                {
                    Console.WriteLine(passangers[i].Id);
                }
            }
        }
    }
}