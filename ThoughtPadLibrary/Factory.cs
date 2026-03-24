using LiteDB;

using System;

using ThoughtPadLibrary.Repositories;

namespace ThoughtPadLibrary;

public static class Factory
{
    private static ILiteDatabase? _liteDatabase;

    public static ILDBRepo GetNewLiteDBRepo(string connectionString)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(connectionString, nameof(connectionString));

        return new Repositories.LDBRepo(connectionString);
    }

    internal static ILiteDatabase GetNewLiteDatabase(string connectionString)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(connectionString, nameof(connectionString));
        
        _liteDatabase ??= new LiteDB.LiteDatabase(connectionString);

        return _liteDatabase;
    }
}