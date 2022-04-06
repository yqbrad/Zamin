﻿namespace Zamin.Extensions.DependentyInjection.Sample.Services;

public class GetGuidTransientService : IGetGuidTransientService
{
    private Guid guid { get; set; }

    public GetGuidTransientService()
    {
        guid = Guid.NewGuid();
    }

    public Guid Execute() => guid;

}
