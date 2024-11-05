```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UKUTRU : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method                       | Length  | Mean             | Error           | StdDev          | Gen0   | Allocated |
|----------------------------- |-------- |-----------------:|----------------:|----------------:|-------:|----------:|
| ArrayIndexer                 | 10      |         498.1 ns |         4.97 ns |         6.64 ns |      - |         - |
| ArrayAsICollectionEnumerator | 10      |       3,394.2 ns |        43.86 ns |        58.56 ns | 1.5297 |    3200 B |
| ListIndexer                  | 10      |         817.5 ns |        11.09 ns |        14.03 ns |      - |         - |
| ListEnumerator               | 10      |         931.2 ns |        15.70 ns |        19.85 ns |      - |         - |
| ListAsICollectionEnumerator  | 10      |       6,514.3 ns |        96.59 ns |       125.59 ns | 1.9073 |    4000 B |
| ArrayIndexer                 | 35      |       1,712.8 ns |        17.05 ns |        22.17 ns |      - |         - |
| ArrayAsICollectionEnumerator | 35      |       9,703.0 ns |       225.69 ns |       301.29 ns | 1.5259 |    3200 B |
| ListIndexer                  | 35      |       3,250.2 ns |        41.73 ns |        54.26 ns |      - |         - |
| ListEnumerator               | 35      |       2,852.6 ns |        63.00 ns |        81.92 ns |      - |         - |
| ListAsICollectionEnumerator  | 35      |      13,712.3 ns |       368.56 ns |       492.02 ns | 1.9073 |    4000 B |
| ArrayIndexer                 | 60      |       3,372.8 ns |        28.61 ns |        36.18 ns |      - |         - |
| ArrayAsICollectionEnumerator | 60      |      18,173.3 ns |       458.88 ns |       612.59 ns | 1.5259 |    3200 B |
| ListIndexer                  | 60      |       5,501.4 ns |        94.86 ns |       126.63 ns |      - |         - |
| ListEnumerator               | 60      |       6,193.7 ns |       200.82 ns |       268.09 ns |      - |         - |
| ListAsICollectionEnumerator  | 60      |      22,085.0 ns |       687.53 ns |       917.84 ns | 1.8921 |    4000 B |
| ArrayIndexer                 | 85      |       4,556.7 ns |        53.76 ns |        61.91 ns |      - |         - |
| ArrayAsICollectionEnumerator | 85      |      24,520.8 ns |       372.08 ns |       470.56 ns | 1.5259 |    3200 B |
| ListIndexer                  | 85      |       7,148.8 ns |       107.15 ns |       143.04 ns |      - |         - |
| ListEnumerator               | 85      |       8,186.0 ns |       306.93 ns |       409.75 ns |      - |         - |
| ListAsICollectionEnumerator  | 85      |      30,649.4 ns |     1,031.97 ns |     1,377.66 ns | 1.8921 |    4000 B |
| ArrayIndexer                 | 100     |       5,236.8 ns |       121.96 ns |       162.81 ns |      - |         - |
| ArrayAsICollectionEnumerator | 100     |      28,409.3 ns |       279.61 ns |       373.27 ns | 1.5259 |    3200 B |
| ListIndexer                  | 100     |       8,117.7 ns |       231.65 ns |       301.21 ns |      - |         - |
| ListEnumerator               | 100     |       9,103.4 ns |       419.22 ns |       559.65 ns |      - |         - |
| ListAsICollectionEnumerator  | 100     |      34,873.4 ns |     1,802.24 ns |     2,405.94 ns | 1.8921 |    4000 B |
| ArrayIndexer                 | 350     |      15,510.8 ns |       167.77 ns |       223.97 ns |      - |         - |
| ArrayAsICollectionEnumerator | 350     |      92,903.1 ns |     1,736.98 ns |     2,318.82 ns | 1.4648 |    3200 B |
| ListIndexer                  | 350     |      25,434.7 ns |       370.06 ns |       494.02 ns |      - |         - |
| ListEnumerator               | 350     |      28,405.2 ns |       319.08 ns |       414.89 ns |      - |         - |
| ListAsICollectionEnumerator  | 350     |     138,558.1 ns |     4,878.23 ns |     6,512.30 ns | 1.7090 |    4000 B |
| ArrayIndexer                 | 600     |      42,745.1 ns |       936.10 ns |     1,249.67 ns |      - |         - |
| ArrayAsICollectionEnumerator | 600     |     160,625.9 ns |     5,139.12 ns |     6,860.57 ns | 1.4648 |    3200 B |
| ListIndexer                  | 600     |      48,262.2 ns |       757.75 ns |     1,011.57 ns |      - |         - |
| ListEnumerator               | 600     |      57,206.7 ns |       538.89 ns |       719.40 ns |      - |         - |
| ListAsICollectionEnumerator  | 600     |     221,653.8 ns |     7,124.07 ns |     9,009.67 ns | 1.7090 |    4000 B |
| ArrayIndexer                 | 850     |      58,799.6 ns |       551.95 ns |       717.70 ns |      - |         - |
| ArrayAsICollectionEnumerator | 850     |     222,558.7 ns |     3,472.27 ns |     4,635.39 ns | 1.4648 |    3200 B |
| ListIndexer                  | 850     |      67,191.7 ns |     1,751.78 ns |     2,338.58 ns |      - |         - |
| ListEnumerator               | 850     |      80,299.9 ns |     1,744.05 ns |     2,328.25 ns |      - |         - |
| ListAsICollectionEnumerator  | 850     |     312,788.4 ns |    16,563.97 ns |    22,112.42 ns | 1.4648 |    4000 B |
| ArrayIndexer                 | 1000    |      70,303.8 ns |     1,452.62 ns |     1,939.21 ns |      - |         - |
| ArrayAsICollectionEnumerator | 1000    |     259,803.5 ns |     6,996.63 ns |     9,340.29 ns | 1.4648 |    3200 B |
| ListIndexer                  | 1000    |      78,915.0 ns |     1,840.92 ns |     2,457.58 ns |      - |         - |
| ListEnumerator               | 1000    |      94,161.6 ns |     1,641.67 ns |     2,191.58 ns |      - |         - |
| ListAsICollectionEnumerator  | 1000    |     330,618.1 ns |    11,519.12 ns |    15,377.70 ns | 1.4648 |    4000 B |
| ArrayIndexer                 | 3500    |     243,908.1 ns |     6,971.81 ns |     9,307.16 ns |      - |         - |
| ArrayAsICollectionEnumerator | 3500    |     915,624.4 ns |     7,693.78 ns |    10,270.97 ns | 0.9766 |    3200 B |
| ListIndexer                  | 3500    |     285,840.1 ns |     5,071.72 ns |     6,770.60 ns |      - |         - |
| ListEnumerator               | 3500    |     336,186.6 ns |     6,148.66 ns |     8,208.29 ns |      - |         - |
| ListAsICollectionEnumerator  | 3500    |   1,136,554.9 ns |    39,130.84 ns |    52,238.55 ns |      - |    4000 B |
| ArrayIndexer                 | 6000    |     517,477.2 ns |    10,456.20 ns |    13,596.02 ns |      - |         - |
| ArrayAsICollectionEnumerator | 6000    |   1,621,024.9 ns |    16,379.21 ns |    20,714.46 ns |      - |    3201 B |
| ListIndexer                  | 6000    |     715,000.3 ns |    14,704.37 ns |    19,629.92 ns |      - |         - |
| ListEnumerator               | 6000    |     779,568.9 ns |     8,789.49 ns |    11,733.72 ns |      - |         - |
| ListAsICollectionEnumerator  | 6000    |   1,929,728.1 ns |    23,861.63 ns |    30,177.32 ns |      - |    4000 B |
| ArrayIndexer                 | 8500    |     987,161.0 ns |     7,922.77 ns |    10,301.84 ns |      - |         - |
| ArrayAsICollectionEnumerator | 8500    |   2,316,679.5 ns |    56,698.12 ns |    75,690.36 ns |      - |    3202 B |
| ListIndexer                  | 8500    |   1,269,667.6 ns |    20,491.95 ns |    27,356.16 ns |      - |       1 B |
| ListEnumerator               | 8500    |   1,239,599.1 ns |    19,113.96 ns |    25,516.59 ns |      - |         - |
| ListAsICollectionEnumerator  | 8500    |   2,738,904.7 ns |    61,326.64 ns |    79,741.96 ns |      - |    4000 B |
| ArrayIndexer                 | 10000   |   1,197,949.4 ns |    17,119.53 ns |    22,854.09 ns |      - |       1 B |
| ArrayAsICollectionEnumerator | 10000   |   2,749,271.1 ns |    39,402.82 ns |    52,601.63 ns |      - |    3202 B |
| ListIndexer                  | 10000   |   1,513,744.9 ns |    14,287.95 ns |    18,578.37 ns |      - |       1 B |
| ListEnumerator               | 10000   |   1,479,197.7 ns |    32,271.37 ns |    43,081.36 ns |      - |       1 B |
| ListAsICollectionEnumerator  | 10000   |   3,966,895.4 ns |   128,497.06 ns |   171,539.90 ns |      - |    4000 B |
| ArrayIndexer                 | 35000   |   8,005,875.1 ns |    36,563.23 ns |    48,810.86 ns |      - |       3 B |
| ArrayAsICollectionEnumerator | 35000   |  22,950,525.8 ns |   136,974.29 ns |   182,856.76 ns |      - |    3212 B |
| ListIndexer                  | 35000   |  14,557,961.7 ns |    40,051.50 ns |    53,467.61 ns |      - |       6 B |
| ListEnumerator               | 35000   |  17,335,866.3 ns |    63,889.17 ns |    78,461.64 ns |      - |      12 B |
| ListAsICollectionEnumerator  | 35000   |  28,426,120.2 ns |   146,836.87 ns |   174,798.86 ns |      - |    4012 B |
| ArrayIndexer                 | 60000   |  25,330,850.3 ns |    72,728.61 ns |    89,317.27 ns |      - |      12 B |
| ArrayAsICollectionEnumerator | 60000   |  44,287,257.6 ns |   253,847.91 ns |   330,074.01 ns |      - |    3209 B |
| ListIndexer                  | 60000   |  31,169,172.7 ns |   181,128.16 ns |   235,517.79 ns |      - |      25 B |
| ListEnumerator               | 60000   |  36,954,319.3 ns |   263,620.90 ns |   333,396.06 ns |      - |      29 B |
| ListAsICollectionEnumerator  | 60000   |  57,495,918.4 ns |   176,165.27 ns |   222,792.68 ns |      - |    4044 B |
| ArrayIndexer                 | 85000   |  40,759,287.5 ns |    93,644.26 ns |   111,476.84 ns |      - |      31 B |
| ArrayAsICollectionEnumerator | 85000   |  64,299,195.5 ns |   599,924.30 ns |   736,760.99 ns |      - |    3250 B |
| ListIndexer                  | 85000   |  46,507,209.5 ns |   379,719.52 ns |   493,742.67 ns |      - |      36 B |
| ListEnumerator               | 85000   |  53,779,630.9 ns |   210,301.70 ns |   265,964.34 ns |      - |       6 B |
| ListAsICollectionEnumerator  | 85000   |  83,959,493.8 ns |   282,984.11 ns |   367,959.30 ns |      - |    4067 B |
| ArrayIndexer                 | 100000  |  48,193,329.5 ns |   263,409.62 ns |   342,506.94 ns |      - |       6 B |
| ArrayAsICollectionEnumerator | 100000  |  74,887,824.8 ns |   378,336.24 ns |   478,474.25 ns |      - |    3257 B |
| ListIndexer                  | 100000  |  54,676,363.6 ns |   142,719.61 ns |   175,272.51 ns |      - |      40 B |
| ListEnumerator               | 100000  |  63,130,806.2 ns |   255,428.42 ns |   332,129.12 ns |      - |      50 B |
| ListAsICollectionEnumerator  | 100000  |  99,187,900.0 ns |   524,509.45 ns |   604,025.86 ns |      - |    4067 B |
| ArrayIndexer                 | 350000  | 168,281,530.2 ns | 1,095,053.70 ns | 1,303,583.65 ns |      - |     133 B |
| ArrayAsICollectionEnumerator | 350000  | 260,621,697.6 ns | 1,443,100.22 ns | 1,717,908.31 ns |      - |    3400 B |
| ListIndexer                  | 350000  | 193,763,337.9 ns |   753,166.90 ns |   924,956.67 ns |      - |     133 B |
| ListEnumerator               | 350000  | 221,836,336.4 ns |   600,774.93 ns |   737,805.63 ns |      - |     133 B |
| ListAsICollectionEnumerator  | 350000  | 373,368,854.2 ns | 2,690,204.35 ns | 3,498,025.85 ns |      - |    4400 B |
| ArrayIndexer                 | 600000  | 287,756,443.2 ns |   416,211.31 ns |   511,144.91 ns |      - |     200 B |
| ArrayAsICollectionEnumerator | 600000  | 458,496,690.9 ns | 2,688,776.42 ns | 3,302,059.20 ns |      - |    3600 B |
| ListIndexer                  | 600000  | 326,693,688.6 ns | 2,143,306.51 ns | 2,632,173.10 ns |      - |     200 B |
| ListEnumerator               | 600000  | 373,288,148.0 ns | 1,360,233.03 ns | 1,815,872.17 ns |      - |     400 B |
| ListAsICollectionEnumerator  | 600000  | 587,251,729.2 ns | 3,191,518.72 ns | 4,149,876.18 ns |      - |    4400 B |
| ArrayIndexer                 | 850000  | 408,901,778.3 ns | 1,517,885.99 ns | 1,919,639.93 ns |      - |     400 B |
| ArrayAsICollectionEnumerator | 850000  | 648,242,287.0 ns | 3,482,510.59 ns | 4,404,261.22 ns |      - |    3600 B |
| ListIndexer                  | 850000  | 463,911,460.9 ns | 5,461,174.54 ns | 6,906,637.79 ns |      - |     400 B |
| ListEnumerator               | 850000  | 534,330,141.7 ns | 1,919,289.11 ns | 2,495,618.19 ns |      - |      64 B |
| ListAsICollectionEnumerator  | 850000  | 833,037,263.6 ns | 2,172,293.92 ns | 2,667,772.25 ns |      - |    4400 B |
| ArrayIndexer                 | 1000000 | 479,830,560.9 ns | 1,071,891.62 ns | 1,355,599.81 ns |      - |     400 B |
| ArrayAsICollectionEnumerator | 1000000 | 759,851,912.5 ns | 3,123,357.27 ns | 4,061,247.04 ns |      - |    3600 B |
| ListIndexer                  | 1000000 | 543,440,975.0 ns |   845,398.00 ns |   973,561.59 ns |      - |     400 B |
| ListEnumerator               | 1000000 | 627,109,636.0 ns | 1,048,094.54 ns | 1,399,176.23 ns |      - |     400 B |
| ListAsICollectionEnumerator  | 1000000 | 988,868,327.3 ns | 3,758,551.23 ns | 4,615,838.86 ns |      - |    4400 B |
