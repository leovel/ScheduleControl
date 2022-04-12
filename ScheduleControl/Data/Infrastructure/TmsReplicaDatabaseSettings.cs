namespace ScheduleControl.Data.Infrastructure
{
    public class TmsReplicaDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string TransactionLogsCollectionName { get; set; }

        public string UsersCollectionName { get; set; }
    }
}
