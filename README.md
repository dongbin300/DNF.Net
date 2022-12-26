# DNF.Net
[![NuGet latest version](https://badgen.net/nuget/v/DNF.Net/latest)](https://nuget.org/packages/DNF.Net)
[![GitHub forks](https://badgen.net/github/forks/dongbin300/DNF.Net/)](https://GitHub.com/dongbin300/DNF.Net/network/)
![Profile views](https://gpvc.arturio.dev/dongbin300)
<br/><br/>
C# 던전앤파이터 온라인 Open API wrapper 입니다.<br/>
C# Neople D&amp;F Online Open API wrapper based on [던전앤파이터](https://developers.neople.co.kr/contents/apiDocs/df)

## Documentation
### Example
#### Create a application with `apiKey`
```C#
var apiKey = ""; /* Your API key */
var app = new DnfApplication(apiKey);
```

#### Get server info
```C#
var serverResult = await app.ServersApi.GetServerInfoAsync();
```
It will returns:
```C#
rows	Count = 8
[0]	{DnfApplicationServer { serverId = cain, serverName = 카인 }}
[1]	{DnfApplicationServer { serverId = diregie, serverName = 디레지에 }}
[2]	{DnfApplicationServer { serverId = siroco, serverName = 시로코 }}
[3]	{DnfApplicationServer { serverId = prey, serverName = 프레이 }}
[4]	{DnfApplicationServer { serverId = casillas, serverName = 카시야스 }}
[5]	{DnfApplicationServer { serverId = hilder, serverName = 힐더 }}
[6]	{DnfApplicationServer { serverId = anton, serverName = 안톤 }}
[7]	{DnfApplicationServer { serverId = bakal, serverName = 바칼 }}
```

## Feedback
[Issue](https://github.com/dongbin300/DNF.Net/issues)

## Donate
[Donate](https://www.buymeacoffee.com/psS4YtQ)

## Release Notes
- Version 1.1.7 - _2022-12-26_
  - Add Korean Class
  
- Version 1.0.5 - _2022-12-22_
  - Add NuGet Info
  
- Version 1.0.0 - _2022-12-21_
  - Initial Commit
