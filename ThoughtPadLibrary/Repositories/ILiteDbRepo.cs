using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ThoughtPadLibrary.Models;

namespace ThoughtPadLibrary.Repositories;

public interface ILiteDbRepo
{
    // create methods
    public Task CreateEntryAsync(EntryModel entry);
    // read methods
    public Task<EntryModel?> GetEntryByIdAsync(int id);
    public Task<IReadOnlyList<EntryModel>> GetAllEntriesAsync();
    public Task<IReadOnlyList<EntryModel>> GetEntriesByDateAsync(DateTime date);
    public Task<IReadOnlyList<EntryModel>> GetEntriesByTextAsync(string text);
    // update methods
    public Task UpdateEntryAsync(EntryModel entry);
    // delete methods
    public Task DeleteEntryAsync(int id);
}