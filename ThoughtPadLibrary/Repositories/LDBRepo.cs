using LiteDB;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ThoughtPadLibrary.Models;

namespace ThoughtPadLibrary.Repositories;

internal class LDBRepo : ILDBRepo
{
    private readonly ILiteDatabase _db;

    public LDBRepo(string connectionString)
    {
        _db = Factory.GetNewLiteDatabase(connectionString);
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

    public Task<EntryModel?> GetEntryByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
