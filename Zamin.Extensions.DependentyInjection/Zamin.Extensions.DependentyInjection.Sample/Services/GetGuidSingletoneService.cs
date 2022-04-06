﻿namespace Zamin.Extensions.DependentyInjection.Sample.Services;

public class GetGuidSingletoneService : IGetGuidSingletoneService
{
    private Guid guid { get; set; }

    public GetGuidSingletoneService()
    {
        guid = Guid.NewGuid();
    }

    public Guid Execute() => guid;
}
