﻿namespace User.BusinessLogic.Exceptions.ExceptionMessages;

internal static class ExceptionMessages
{
    public static string NotFound(string entityType, Guid guid) =>
        $"{entityType} with id:{guid} was not found";

    public const string TokenMissing = "No token provided from authentication api";
}