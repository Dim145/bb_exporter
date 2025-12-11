using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb_exporter.model.wan
{
    public class wan_ip_stats
    {
        public Wan wan { get; set; }
    }

    public class Wan
    {
        public Ip ip { get; set; }
    }

    public class Ip
    {
        public Stats stats { get; set; }
    }

    public class Stats
    {
        public Rx rx { get; set; }
        public Tx tx { get; set; }
    }

    public class Rx
    {
        public long packets { get; set; }
        public long bytes { get; set; }
        public long packetserrors { get; set; }
        public long packetsdiscards { get; set; }
        public float occupation { get; set; }
        public long bandwidth { get; set; }
        public long maxBandwidth { get; set; }
    }

    public class Tx
    {
        public long packets { get; set; }
        public long bytes { get; set; }
        public long packetserrors { get; set; }
        public long packetsdiscards { get; set; }
        public float occupation { get; set; }
        public long bandwidth { get; set; }
        public long maxBandwidth { get; set; }
    }
}
