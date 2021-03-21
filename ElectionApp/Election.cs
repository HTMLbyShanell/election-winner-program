using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectionApp
{
    class Election
    {
        string[] candidateName = new string[5];
        int[] candidateVotes = new int[5];
        int NUMOFCANDIDATES = 5;
        int winner;

        public Election()
        {
        }

        public int NumberOfCandidates
        {
            get
            {
                return NUMOFCANDIDATES;
            }
            set
            {
                NUMOFCANDIDATES = value;
            }
        }

        public string[] GetCandidateName(int index)
        {
            return candidateName; //method is supposed to return candidate name.
        }

        public void SetCandidateName(string values, int index)
        {
            candidateName[index] = values;
        }

        public int[] GetCandidateVotes(int index)
        {
            return candidateVotes; //method is supposed to return the votes for the candidate
        }

        public void SetCandidateVotes(int votes, int index)
        {
            candidateVotes[index] = votes;
        }

        public int TotalVotes()
        {
            int sum = 0;
            for (int i = 0; i < candidateVotes.Length; i++)
            {
                sum += candidateVotes[i];
            }

            return sum;
        }

        public void FindWinner()
        {
            int maxIndex = -1;
            int max = -1;

            for (int i = 0; i < candidateVotes.Length; i++)
            {
                if (candidateVotes[i] > max)
                {
                    max = candidateVotes[i];
                    maxIndex = i;
                }

                candidateVotes[i] = winner;
            }

            Console.WriteLine("\n\nCandidate {0}, with {1} votes, is the winner.", candidateName[maxIndex], max);
        }

        public void DisplayResults()
        {
            Console.WriteLine("\n\nCandidate Name \tCandidate Votes \tPercentage");

            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine("{0} \t\t{1} \t\t\t{2:p}", candidateName[index], candidateVotes[index], (candidateVotes[index] / TotalVotes()));
            }
        }
    }
}
