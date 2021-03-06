﻿using System.Collections.Generic;
using System.Net;
using Blockcore.Utilities.Extensions;

namespace Blockcore.Utilities
{
    public class IPEndPointComparer : IEqualityComparer<IPEndPoint>
    {
        public bool Equals(IPEndPoint x, IPEndPoint y)
        {
            if (x == null || y == null)
                return x == null && y == null;

            return x.Match(y);
        }

        public int GetHashCode(IPEndPoint endPoint)
        {
            return endPoint?.Address.MapToIPv6().GetHashCode() ^ endPoint.Port ?? 0;
        }
    }
}
