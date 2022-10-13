# RhoMicro.Domain #

RhoMicro.Domain provides a simple base class for entities in a DDD context. What makes this base class special is that it employs the ObjectSync synchronization feature in order to synchronize properties of entities that may be separate instances but share the same id.

## Features ##

* Base Entity and Dto
* Exported ObjectSync.Synchronization Types

## Versioning ##

The most recent version of RhoMicro.Domain is 0.0.2.
RhoMicro.Domain uses [Semantic Versioning 2.0.0](https://semver.org/).
## Installation ##

Nuget Gallery: https://www.nuget.org/packages/RhoMicro.RhoMicro.Domain

Package Manager: `Install-Package RhoMicro.RhoMicro.Domain -Version 0.0.2`

.Net CLI: `dotnet add package RhoMicro.RhoMicro.Domain --version 0.0.2`
## Quick Start ##

To get started, take a look at the TestDomain project. As there is some boiler plate required to drive property synchronization, more detailed instructions will follow soon.
