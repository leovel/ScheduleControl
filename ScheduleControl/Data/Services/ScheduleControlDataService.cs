using MongoDB.Driver;
using ScheduleControl.Data.Entities;
using ScheduleControl.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleControl.Data.Services
{
    public class ScheduleControlDataService
    {
        private readonly IMongoCollection<User> _usersCollection;
        private readonly IMongoCollection<TransactionLog> _transactionLogsCollection;

        private readonly ProjectionDefinition<User, UserProjection> _userProjection;
        private readonly ProjectionDefinition<TransactionLog, TransactionLogProjection> _transactionLogProjection;
        public ScheduleControlDataService(TmsReplicaDatabaseSettings databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(databaseSettings.DatabaseName);

            _usersCollection = mongoDatabase.GetCollection<User>(databaseSettings.UsersCollectionName);
            _transactionLogsCollection = mongoDatabase.GetCollection<TransactionLog>(databaseSettings.TransactionLogsCollectionName);

            _userProjection = Builders<User>.Projection.Expression(u =>
                new UserProjection
                {
                    Id = u.Id,
                    Department = u.Department,
                    FullName = $"{u.FirstName} {u.LastName}"
                });

            _transactionLogProjection = Builders<TransactionLog>.Projection.Expression(tl =>
               new TransactionLogProjection
               {
                   UserId = tl.UserGuid,
                   Date = tl.Timestamp.Date,
                   Time = tl.Timestamp.TimeOfDay.Add(TimeSpan.FromHours(1)) // Hora aumentada manualmente para corrigir o os relógios mal configurados 
               });
        }

        public async Task<List<UserProjection>> GetActiveUsersAsync(bool onlyActive = true) => await _usersCollection.Find(u => u.Active == onlyActive)
            .Project(_userProjection)
            .ToListAsync();
        public async Task<List<TransactionLogProjection>> GetLogsBetwenAsync(DateTime beginDateTime, DateTime endDateTime) => await _transactionLogsCollection
            .Find(tl => tl.Timestamp >= beginDateTime && tl.Timestamp <= endDateTime && tl.TransactionResult == "Identified")
            .Project(_transactionLogProjection)
            .ToListAsync();

    }
}
