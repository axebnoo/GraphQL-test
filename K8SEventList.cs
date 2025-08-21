using Newtonsoft.Json;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace dashboard_api.Models.Kubernetes
{
    public class EventListCol
    {
        public string dataField { get; set; }
    }

    public class EventListRow
    {
        public string type { get; set; }
        public string message { get; set; }
        public string namespaces  { get; set; }
        public string involvedObject { get; set; }
        public string source { get; set; }
        public int count { get; set; }
        public string firstTimestamp { get; set; }
        public string lastTimestamp { get; set; }
    }

    public class K8SEventList
    {
        public List<EventListCol> column { get; set; }
        public List<EventListRow> rows { get; set; }
    }
}
