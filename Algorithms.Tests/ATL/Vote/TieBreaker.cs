namespace Algorithms.Tests.ATL.Vote
{
    internal class TieBreaker : ITieBreaker
    {
        public int Compare(Candidate? x, Candidate? y)
        {
            return x?.FirstInClass > y?.FirstInClass ? 1 : -1;
        }
    }


}