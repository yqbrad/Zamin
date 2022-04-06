﻿namespace Zamin.Extensions.DependentyInjection.Sample.Services;

public class GetGuidScopeService : IGetGuidScopeService
{
    private Guid guid { get; set; }

    public GetGuidScopeService()
    {
        guid = Guid.NewGuid();
    }

    public Guid Execute() => guid;
}
