using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ThoughtPadLibrary.Models;

namespace ThoughtPadLibrary.Repositories;

public interface ILDBRepo
{
    public Task<EntryModel?> GetEntryByIdAsync(int id);
    public Task<IReadOnlyList<EntryModel>> GetAllEntriesAsync();
    public Task<IReadOnlyList<EntryModel>> GetEntriesByDateAsync(DateTime date);
    public Task<IReadOnlyList<EntryModel>> GetEntriesByTextAsync(string text);
}