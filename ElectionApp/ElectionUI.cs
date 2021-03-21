using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionApp
{
    class ElectionUI
    {
        string name;
        int votes;
        Election theElection = new Election();

        public void MainMethod()
        {
            for (int index = 0; index < theElection.NumberOfCandidates; index++)
            {
                Console.Write("Please enter Candidate {0}'s name:\t ", index);
                name = Console.ReadLine();
                theElection.SetCandidateName(name, index);
                Console.Write("Please enter Candidate {0}'s vote count:\t ", index);
                votes = Int32.Parse(Console.ReadLine());
                theElection.SetCandidateVotes(votes, index);
            }

            theElection.DisplayResults();
            theElection.FindWinner();
            Console.ReadKey();
        }


    }
}
