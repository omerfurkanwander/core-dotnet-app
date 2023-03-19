﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace core_dotnet.ExceptionHandler.Internal;

public sealed class InternalErrorDetails : ProblemDetails
{
    public InternalErrorDetails(string message)
    {
        Status = StatusCodes.Status500InternalServerError;
        Type = "Internal Exception";
        Title = "Internal Error";
        Detail = message;
    }
}