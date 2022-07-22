using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Tests.ATL.Vote
{
    internal class VoteSystem
    {
        internal static List<string> FindWinner(List<Vote> votes, ITieBreaker tieBreaker)
        {
            EnsureVotesAreValid(votes); //O(n)

            List<Candidate> candidates = CountVotes(votes); //O(n)

            candidates = SortCandidates(candidates, tieBreaker); //O(n log(n)) 

            return candidates  //O(n)
                .Select(x => x.Name)
                .ToList();
        }

        private static void EnsureVotesAreValid(List<Vote> votes)
        {
            foreach (var vote in votes)
            {
                if (vote.Candidates.Count > 3)
                    throw new Exception("More than three votes.");

                if (votes.Count != votes.Distinct().Count())
                    throw new Exception("Multiple Votes for same person");
            }
        }

        private static List<Candidate> SortCandidates(List<Candidate> candidates, ITieBreaker tieBreaker)
        {
            return candidates
                .OrderByDescending(x => x.Score)
                .ThenByDescending(x => x, tieBreaker)
                .ToList();
        }

        private static List<Candidate> CountVotes(List<Vote> votes)
        {
            var dictionary = new Dictionary<string, Candidate>();

            int[] counts = new int[votes.Count * 3 + 1];

            foreach (Vote vote in votes)
            {
                int score = 3;
                foreach (string candidateName in vote.Candidates)
                {
                    Candidate candidate;
                    if (!dictionary.ContainsKey(candidateName))
                    {
                        candidate = new Candidate(candidateName, 0);
                        dictionary.Add(candidateName, candidate);
                    }
                    else
                        candidate = dictionary[candidateName];

                    if (candidate.Score > 0)
                        counts[candidate.Score]--;

                    candidate.Score += score;

                    counts[candidate.Score]++;

                    if (counts[candidate.Score] == 1)
                        candidate.FirstInClass = candidate.Score;

                    score--;
                }
            }

            return dictionary
                .Select(x => x.Value)
                .ToList();
        }
    }
}