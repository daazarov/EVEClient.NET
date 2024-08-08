Historical reference of changes made in EVEClient.NET.

# 2024-08-08
- **Fix**
  - `esi-issues` changes from `2024-07-16` - [details](https://github.com/esi/esi-issues/blob/master/changelog.md#2024-07-16)
  - `esi-issues` changes from `2024-07-11` - [details](https://github.com/esi/esi-issues/blob/master/changelog.md#2024-07-11)
- **Deleted**
  - `DefaultScopeAccessValidator` class and `Microsoft.IdentityModel.Tokens` references (preparation for EVEClient.NET.Identity package)
    * Now you need to implement IAccessTokenProvider and IScopeAccessValidator interfaces independently if you want to access secure endpoints
- **Added**
  - `UseOnlyPublicEndpoints()` extension method for `IEsiClientConfigurationBuilder`
    * registers stubs for `IAccessTokenProvider` and `IScopeAccessValidator` interfaces to avoid raising exceptions when executed
  - Added an optional input parameter for each protected endpoint that accepts access token.
    * can be used as an alternative to IAccessTokenProvider
- **ENHANCEMENT**:
  - Enable nullable references types for the project.

# 2024-06-10
- **Initial publishing**: