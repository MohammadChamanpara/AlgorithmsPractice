namespace Algorithms.Tests.ATL.Vote
{
    internal class Candidate
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int FirstInClass { get; internal set; }

        public Candidate(string candidate, int score)
        {
            Name = candidate;
            Score = score;
        }
    }


}