﻿namespace core_dotnet.ExceptionHandler.Validation;

public class ValidationError
{
    public string PropertyName { get; set; } = null!;
    public string ErrorMessage { get; set; } = null!;
}
