using System;
using System.Collections.Generic;

namespace Algorithms.Tests.ATL.Limiter
{
    internal class Limiter
    {
        private readonly int timeFrame;
        private readonly int requestLimit;
        private readonly Dictionary<int, Queue<DateTime>> recentRequests = new();

        public Limiter(int timeFrame, int reguestLimit)
        {
            this.timeFrame = timeFrame;
            requestLimit = reguestLimit;
        }

        internal bool limit(int customerId)
        {
            if (LimitExceeded(customerId, recentRequests, timeFrame, requestLimit))
                return false;

            //remove excess
            RemoveExpiredRequests(customerId, recentRequests, timeFrame);

            //add to recent requests
            StoreRequest(customerId, recentRequests);

            return true;
        }

        private void StoreRequest(int customerId, Dictionary<int, Queue<DateTime>> recentRequests)
        {

            if (!recentRequests.ContainsKey(customerId))
                recentRequests.Add(customerId, new Queue<DateTime>(new[] { DateTime.Now }));

            recentRequests[customerId].Enqueue(DateTime.Now);
        }

        private void RemoveExpiredRequests(int customerId, Dictionary<int, Queue<DateTime>> recentRequests, int timeFrame)
        {
            if (!recentRequests.ContainsKey(customerId))
                return;

            var userRequests = recentRequests[customerId];

            while (userRequests.Count > 0 && IsExpired(userRequests.Peek()))
                userRequests.Dequeue();
        }

        private bool LimitExceeded(int customerId, Dictionary<int, Queue<DateTime>> recentRequests, int timeFrame, int requestLimit)
        {
            if (requestLimit == 0)
                return true;

            if (!recentRequests.ContainsKey(customerId))
                return false;

            var userRequests = recentRequests[customerId];

            if (userRequests.Count < requestLimit)
                return false;

            var oldestRequestTime = userRequests.Peek();

            if (IsExpired(oldestRequestTime))
                return false;

            return true;
        }

        private bool IsExpired(DateTime oldestRequestTime)
        {
            var ellapsedSeconds = (DateTime.Now - oldestRequestTime).TotalSeconds;
            if (ellapsedSeconds >= timeFrame)
                return true;

            return false;
        }
    }
}