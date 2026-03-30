using LiteDB;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ThoughtPadLibrary.Models;

namespace ThoughtPadLibrary.Repositories;

internal class LiteDbRepo : ILiteDbRepo, IDisposable
{
    private readonly ILiteDatabase _db;
    private readonly ILiteCollection<EntryModel> _collection;

    public LiteDbRepo(string connectionString)
    {
        _db = Factory.GetNewLiteDatabase(connectionString);
        
        _collection = _db.GetCollection<EntryModel>("entries");
        _collection.EnsureIndex(x => x.Id, unique: true);
        _collection.EnsureIndex(x => x.DateCreated);

    }

    public Task CreateEntryAsync(EntryModel entry)
    {
        throw new NotImplementedException();
    }

    public Task<EntryModel?> GetEntryByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<EntryModel>> GetAllEntriesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<EntryModel>> GetEntriesByDateAsync(DateTime date)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<EntryModel>> GetEntriesByTextAsync(string text)
    {
        throw new NotImplementedException();
    }

    public Task UpdateEntryAsync(EntryModel entry)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEntryAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _db?.Dispose();
    }
}