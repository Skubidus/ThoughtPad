using LiteDB;

using System;

using ThoughtPadLibrary.Repositories;

namespace ThoughtPadLibrary;

public static class Factory
{
    private static ILiteDatabase? _liteDatabase;

    public static ILiteDbRepo GetNewLiteDBRepo(string connectionString)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(connectionString, nameof(connectionString));

        return new Repositories.LiteDbRepo(connectionString);
    }

    internal static ILiteDatabase GetNewLiteDatabase(string connectionString)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(connectionString, nameof(connectionString));
        
        _liteDatabase ??= new LiteDB.LiteDatabase(connectionString);

        return _liteDatabase;
    }
}