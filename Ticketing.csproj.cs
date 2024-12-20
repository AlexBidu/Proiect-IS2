﻿<Project Sdk="Microsoft.NET.Sdk.Web">

    <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    </PropertyGroup>

    <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="9.0.0-rc.2.24474.1" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Abstractions" Version="9.0.0-rc.2.24474.1" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="9.0.0-rc.2.24474.1">
    <PrivateAssets>all</PrivateAssets>
    <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="9.0.0-rc.2.24474.1" />
    <PackageReference Include="MongoDB.Driver" Version="3.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.6.2"/>
    </ItemGroup>

    <ItemGroup>
    <Compile Remove="Database\TicketingDatabaseContext.cs" />
    </ItemGroup>

    </Project>