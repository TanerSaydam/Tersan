```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
AMD Ryzen 5 3600X, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method      | Mean     | Error    | StdDev   | Ratio | RatioSD |
|------------ |---------:|---------:|---------:|------:|--------:|
| ToList      | 486.7 μs | 30.91 μs | 87.69 μs |  1.00 |    0.00 |
| ToListAsync | 148.2 μs |  3.50 μs | 10.31 μs |  0.31 |    0.07 |
