using MongoDB.Driver;
using ScheduleControlTemplate.Data.Entities;
using ScheduleControlTemplate.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleControlTemplate.Data.Services
{
    public class ScheduleControlDataService
    {
        private readonly IMongoCollection<User> _usersCollection;
        private readonly IMongoCollection<TransactionLog> _transactionLogsCollection;
        public ScheduleControlDataService(TmsReplicaDatabaseSettings databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(databaseSettings.DatabaseName);

            _usersCollection = mongoDatabase.GetCollection<User>(databaseSettings.UsersCollectionName);
            _transactionLogsCollection = mongoDatabase.GetCollection<TransactionLog>(databaseSettings.TransactionLogsCollectionName);
        }

        public async Task<List<User>> GetActiveUsersAsync() => await _usersCollection.Find(u => u.Active == true).ToListAsync();
        public async Task<List<TransactionLog>> GetUserLogsBetwenAsync(string userGuid, DateTime beginDateTime, DateTime endDateTime) => await _transactionLogsCollection
            .Find(tl => tl.Timestamp >= beginDateTime && tl.Timestamp <= endDateTime && tl.UserGuid == userGuid && tl.TransactionResult == "Identified").ToListAsync();
    }
}
