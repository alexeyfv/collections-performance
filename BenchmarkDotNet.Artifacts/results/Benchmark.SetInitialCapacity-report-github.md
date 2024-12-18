```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CPAQVT : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method                 | Length  | Mean            | Error         | StdDev          | Ratio    | RatioSD | Gen0     | Gen1     | Gen2     | Allocated  | Alloc Ratio |
|----------------------- |-------- |----------------:|--------------:|----------------:|---------:|--------:|---------:|---------:|---------:|-----------:|------------:|
| **DefaultInitialCapacity** | **10**      |        **230.3 ns** |       **3.63 ns** |         **4.46 ns** | **baseline** |        **** |   **0.4778** |        **-** |        **-** |     **1000 B** |            **** |
| GivenInitialCapacity   | 10      |        145.6 ns |       2.52 ns |         3.28 ns |     -37% |    2.9% |   0.1798 |        - |        - |      376 B |        -62% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **20**      |        **429.9 ns** |       **4.18 ns** |         **5.43 ns** | **baseline** |        **** |   **0.9794** |        **-** |        **-** |     **2048 B** |            **** |
| GivenInitialCapacity   | 20      |        265.2 ns |       2.32 ns |         2.77 ns |     -38% |    1.6% |   0.3324 |        - |        - |      696 B |        -66% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **30**      |        **559.5 ns** |       **3.61 ns** |         **4.57 ns** | **baseline** |        **** |   **0.9794** |        **-** |        **-** |     **2048 B** |            **** |
| GivenInitialCapacity   | 30      |        387.2 ns |       2.27 ns |         2.88 ns |     -31% |    1.1% |   0.4854 |        - |        - |     1016 B |        -50% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **40**      |        **856.1 ns** |       **6.51 ns** |         **8.23 ns** | **baseline** |        **** |   **1.9684** |        **-** |        **-** |     **4120 B** |            **** |
| GivenInitialCapacity   | 40      |        547.9 ns |       9.78 ns |        12.71 ns |     -36% |    2.5% |   0.6380 |        - |        - |     1336 B |        -68% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **50**      |        **970.1 ns** |      **10.98 ns** |        **13.48 ns** | **baseline** |        **** |   **1.9684** |        **-** |        **-** |     **4120 B** |            **** |
| GivenInitialCapacity   | 50      |        636.4 ns |       3.45 ns |         4.37 ns |     -34% |    1.5% |   0.7915 |        - |        - |     1656 B |        -60% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **60**      |      **1,052.6 ns** |      **10.11 ns** |        **13.15 ns** | **baseline** |        **** |   **1.9684** |        **-** |        **-** |     **4120 B** |            **** |
| GivenInitialCapacity   | 60      |        759.6 ns |       6.46 ns |         7.93 ns |     -28% |    1.6% |   0.9441 |        - |        - |     1976 B |        -52% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **70**      |      **1,550.2 ns** |      **13.72 ns** |        **17.84 ns** | **baseline** |        **** |   **3.9368** |        **-** |        **-** |     **8240 B** |            **** |
| GivenInitialCapacity   | 70      |        958.7 ns |      11.57 ns |        15.05 ns |     -38% |    1.9% |   1.0977 |        - |        - |     2296 B |        -72% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **80**      |      **1,690.6 ns** |      **17.85 ns** |        **21.25 ns** | **baseline** |        **** |   **3.9368** |        **-** |        **-** |     **8240 B** |            **** |
| GivenInitialCapacity   | 80      |      1,081.2 ns |      20.58 ns |        25.27 ns |     -36% |    2.6% |   1.2493 |        - |        - |     2616 B |        -68% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **90**      |      **1,801.9 ns** |       **9.20 ns** |        **11.30 ns** | **baseline** |        **** |   **3.9368** |        **-** |        **-** |     **8240 B** |            **** |
| GivenInitialCapacity   | 90      |      1,133.4 ns |      10.84 ns |        13.31 ns |     -37% |    1.3% |   1.4019 |        - |        - |     2936 B |        -64% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **100**     |      **1,949.5 ns** |      **15.26 ns** |        **20.37 ns** | **baseline** |        **** |   **3.9368** |        **-** |        **-** |     **8240 B** |            **** |
| GivenInitialCapacity   | 100     |      1,377.5 ns |       9.99 ns |        12.27 ns |     -29% |    1.3% |   1.5545 |        - |        - |     3256 B |        -60% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **200**     |      **3,709.7 ns** |      **26.42 ns** |        **33.41 ns** | **baseline** |        **** |   **7.8735** |        **-** |        **-** |    **16456 B** |            **** |
| GivenInitialCapacity   | 200     |      2,733.4 ns |      27.48 ns |        36.69 ns |     -26% |    1.6% |   3.0861 |        - |        - |     6456 B |        -61% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **300**     |      **6,093.3 ns** |      **83.24 ns** |       **102.22 ns** | **baseline** |        **** |  **15.6250** |        **-** |        **-** |    **32864 B** |            **** |
| GivenInitialCapacity   | 300     |      4,027.5 ns |     107.26 ns |       143.18 ns |     -34% |    3.8% |   4.6082 |        - |        - |     9656 B |        -71% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **400**     |      **7,437.6 ns** |      **51.28 ns** |        **66.68 ns** | **baseline** |        **** |  **15.6250** |        **-** |        **-** |    **32864 B** |            **** |
| GivenInitialCapacity   | 400     |      5,300.0 ns |     171.96 ns |       229.56 ns |     -29% |    4.3% |   6.1340 |        - |        - |    12856 B |        -61% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **500**     |      **8,710.4 ns** |     **147.14 ns** |       **180.70 ns** | **baseline** |        **** |  **15.6250** |        **-** |        **-** |    **32864 B** |            **** |
| GivenInitialCapacity   | 500     |      6,172.9 ns |      62.72 ns |        81.56 ns |     -29% |    2.4% |   7.6294 |        - |        - |    16056 B |        -51% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **600**     |     **12,038.9 ns** |     **116.87 ns** |       **156.02 ns** | **baseline** |        **** |  **31.2347** |        **-** |        **-** |    **65656 B** |            **** |
| GivenInitialCapacity   | 600     |      8,001.7 ns |      71.01 ns |        94.79 ns |     -34% |    1.7% |   9.1705 |        - |        - |    19256 B |        -71% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **700**     |     **12,966.1 ns** |      **80.34 ns** |       **104.46 ns** | **baseline** |        **** |  **31.2347** |        **-** |        **-** |    **65656 B** |            **** |
| GivenInitialCapacity   | 700     |      9,542.5 ns |      46.02 ns |        61.44 ns |     -26% |    1.0% |  10.6354 |        - |        - |    22456 B |        -66% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **800**     |     **14,912.2 ns** |     **130.87 ns** |       **160.72 ns** | **baseline** |        **** |  **31.2347** |        **-** |        **-** |    **65656 B** |            **** |
| GivenInitialCapacity   | 800     |     10,842.5 ns |      65.64 ns |        87.62 ns |     -27% |    1.3% |  12.1918 |        - |        - |    25656 B |        -61% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **900**     |     **15,977.8 ns** |     **325.24 ns** |       **411.33 ns** | **baseline** |        **** |  **31.2195** |        **-** |        **-** |    **65656 B** |            **** |
| GivenInitialCapacity   | 900     |     12,148.8 ns |      64.28 ns |        85.82 ns |     -24% |    2.7% |  13.6871 |        - |        - |    28856 B |        -56% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **1000**    |     **17,228.3 ns** |     **116.51 ns** |       **151.49 ns** | **baseline** |        **** |  **31.2195** |        **-** |        **-** |    **65656 B** |            **** |
| GivenInitialCapacity   | 1000    |     13,123.6 ns |     399.64 ns |       519.64 ns |     -24% |    4.0% |  15.1367 |        - |        - |    32056 B |        -51% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **2000**    |     **34,517.4 ns** |     **303.37 ns** |       **405.00 ns** | **baseline** |        **** |  **62.4390** |        **-** |        **-** |   **131216 B** |            **** |
| GivenInitialCapacity   | 2000    |     27,055.2 ns |     229.98 ns |       290.85 ns |     -22% |    1.6% |  30.2734 |        - |        - |    64056 B |        -51% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **3000**    |    **208,832.5 ns** |   **1,033.10 ns** |     **1,379.16 ns** | **baseline** |        **** |  **83.0078** |  **41.5039** |  **41.5039** |   **262326 B** |            **** |
| GivenInitialCapacity   | 3000    |    160,053.5 ns |   1,295.08 ns |     1,683.97 ns |     -23% |    1.2% |  30.2734 |  30.2734 |  30.2734 |    96066 B |        -63% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **4000**    |    **258,260.5 ns** |   **2,820.87 ns** |     **3,765.79 ns** | **baseline** |        **** |  **83.0078** |  **41.5039** |  **41.5039** |   **262326 B** |            **** |
| GivenInitialCapacity   | 4000    |    215,762.5 ns |   1,283.71 ns |     1,669.18 ns |     -16% |    1.6% |  39.7949 |  39.7949 |  39.7949 |   128069 B |        -51% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **5000**    |    **538,573.0 ns** |   **6,641.35 ns** |     **8,635.64 ns** | **baseline** |        **** | **124.0234** | **124.0234** | **124.0234** |   **524522 B** |            **** |
| GivenInitialCapacity   | 5000    |    275,793.6 ns |   2,953.58 ns |     3,840.48 ns |     -49% |    2.1% |  49.8047 |  49.8047 |  49.8047 |   160073 B |        -69% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **6000**    |    **601,472.9 ns** |   **6,156.95 ns** |     **7,786.57 ns** | **baseline** |        **** | **124.0234** | **124.0234** | **124.0234** |   **524522 B** |            **** |
| GivenInitialCapacity   | 6000    |    327,043.9 ns |   2,761.29 ns |     3,686.24 ns |     -46% |    1.7% |  58.5938 |  58.5938 |  58.5938 |   192076 B |        -63% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **7000**    |    **660,022.2 ns** |   **4,794.76 ns** |     **6,234.54 ns** | **baseline** |        **** | **124.0234** | **124.0234** | **124.0234** |   **524522 B** |            **** |
| GivenInitialCapacity   | 7000    |    393,378.4 ns |   1,930.69 ns |     2,510.44 ns |     -40% |    1.1% |  66.4063 |  66.4063 |  66.4063 |   224079 B |        -57% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **8000**    |    **721,404.5 ns** |   **6,024.96 ns** |     **7,834.16 ns** | **baseline** |        **** | **124.0234** | **124.0234** | **124.0234** |   **524522 B** |            **** |
| GivenInitialCapacity   | 8000    |    454,998.2 ns |   2,896.15 ns |     3,866.28 ns |     -37% |    1.4% |  76.6602 |  76.6602 |  76.6602 |   256082 B |        -51% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **9000**    |  **1,013,006.7 ns** |   **7,898.93 ns** |    **10,544.84 ns** | **baseline** |        **** | **285.1563** | **285.1563** | **285.1563** |  **1048889 B** |            **** |
| GivenInitialCapacity   | 9000    |    525,469.5 ns |   6,301.70 ns |     8,193.98 ns |     -48% |    1.8% |  90.8203 |  90.8203 |  90.8203 |   288087 B |        -73% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **10000**   |  **1,060,816.5 ns** |   **9,398.45 ns** |    **12,546.67 ns** | **baseline** |        **** | **285.1563** | **285.1563** | **285.1563** |  **1048888 B** |            **** |
| GivenInitialCapacity   | 10000   |    604,228.5 ns |   5,852.28 ns |     7,812.63 ns |     -43% |    1.7% |  99.6094 |  99.6094 |  99.6094 |   320090 B |        -69% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **20000**   |    **835,648.2 ns** |  **14,990.20 ns** |    **19,491.49 ns** | **baseline** |        **** | **167.9688** | **105.4688** | **105.4688** |  **2098098 B** |            **** |
| GivenInitialCapacity   | 20000   |    375,145.0 ns |  10,969.84 ns |    14,644.43 ns |     -55% |    4.5% |  52.2461 |  51.7578 |  51.7578 |   640453 B |        -69% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **30000**   |    **920,279.8 ns** |  **12,796.08 ns** |    **17,082.40 ns** | **baseline** |        **** | **154.2969** |  **91.7969** |  **91.7969** |  **2097997 B** |            **** |
| GivenInitialCapacity   | 30000   |    580,480.1 ns |   7,540.42 ns |    10,066.24 ns |     -37% |    2.5% |  57.6172 |  57.6172 |  57.6172 |   960514 B |        -54% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **40000**   |  **1,848,962.2 ns** |  **38,670.74 ns** |    **51,624.33 ns** | **baseline** |        **** | **203.1250** | **140.6250** | **140.6250** |  **4195580 B** |            **** |
| GivenInitialCapacity   | 40000   |    755,908.6 ns |   7,438.70 ns |     9,930.45 ns |     -59% |    3.0% |  57.6172 |  57.6172 |  57.6172 |  1280481 B |        -69% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **50000**   |  **2,073,260.0 ns** |  **56,774.41 ns** |    **75,792.22 ns** | **baseline** |        **** | **199.2188** | **136.7188** | **136.7188** |  **4195358 B** |            **** |
| GivenInitialCapacity   | 50000   |    940,557.9 ns |  24,007.11 ns |    32,048.80 ns |     -55% |    4.9% |  60.5469 |  60.5469 |  60.5469 |  1600506 B |        -62% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **60000**   |  **2,213,708.4 ns** |  **47,085.48 ns** |    **62,857.77 ns** | **baseline** |        **** | **187.5000** | **125.0000** | **125.0000** |  **4195464 B** |            **** |
| GivenInitialCapacity   | 60000   |  1,367,665.0 ns |  16,575.96 ns |    22,128.44 ns |     -38% |    3.2% |  72.2656 |  72.2656 |  72.2656 |  1920612 B |        -54% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **70000**   |  **4,503,144.9 ns** | **186,955.47 ns** |   **249,580.20 ns** | **baseline** |        **** | **250.0000** | **187.5000** | **187.5000** |  **8389924 B** |            **** |
| GivenInitialCapacity   | 70000   |  1,516,990.8 ns |  38,189.31 ns |    50,981.63 ns |     -66% |    6.4% |  70.3125 |  70.3125 |  70.3125 |  2240579 B |        -73% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **80000**   |  **4,550,987.2 ns** | **273,602.17 ns** |   **365,251.07 ns** | **baseline** |        **** | **226.5625** | **171.8750** | **164.0625** |  **8389989 B** |            **** |
| GivenInitialCapacity   | 80000   |  1,715,054.0 ns |  96,229.08 ns |   128,463.07 ns |     -62% |   10.8% |  72.2656 |  72.2656 |  72.2656 |  2560602 B |        -69% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **90000**   |  **6,292,117.2 ns** | **586,752.48 ns** |   **783,297.77 ns** | **baseline** |        **** | **226.5625** | **164.0625** | **164.0625** |  **8389711 B** |            **** |
| GivenInitialCapacity   | 90000   |  2,262,245.2 ns | 105,951.51 ns |   141,442.23 ns |     -63% |   14.2% |  78.1250 |  78.1250 |  78.1250 |  2880688 B |        -66% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **100000**  |  **6,858,591.7 ns** | **852,004.44 ns** | **1,107,846.52 ns** | **baseline** |        **** | **273.4375** | **218.7500** | **210.9375** |  **8389877 B** |            **** |
| GivenInitialCapacity   | 100000  |  3,459,044.1 ns |  68,980.25 ns |    87,237.94 ns |     -48% |   15.2% |  82.0313 |  82.0313 |  82.0313 |  3200658 B |        -62% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **200000**  | **20,818,974.7 ns** | **166,038.11 ns** |   **209,985.06 ns** | **baseline** |        **** | **375.0000** | **312.5000** | **312.5000** | **16777646 B** |            **** |
| GivenInitialCapacity   | 200000  |  8,501,863.5 ns |  70,544.51 ns |    94,174.90 ns |     -59% |    1.5% | 109.3750 | 109.3750 | 109.3750 |  6400099 B |        -62% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **300000**  | **33,491,657.8 ns** | **218,872.01 ns** |   **292,187.87 ns** | **baseline** |        **** | **500.0000** | **437.5000** | **437.5000** | **33554940 B** |            **** |
| GivenInitialCapacity   | 300000  |  9,764,749.7 ns | 103,666.08 ns |   138,391.26 ns |     -71% |    1.6% | 109.3750 | 109.3750 | 109.3750 |  9600099 B |        -71% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **400000**  | **33,977,438.3 ns** | **286,560.27 ns** |   **372,609.33 ns** | **baseline** |        **** | **375.0000** | **312.5000** | **312.5000** | **33554898 B** |            **** |
| GivenInitialCapacity   | 400000  | 13,382,554.1 ns |  85,190.15 ns |   104,621.17 ns |     -61% |    1.3% | 109.3750 | 109.3750 | 109.3750 | 12800099 B |        -62% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **500000**  | **33,843,066.4 ns** | **340,230.02 ns** |   **454,197.34 ns** | **baseline** |        **** | **266.6667** | **266.6667** | **266.6667** | **33554884 B** |            **** |
| GivenInitialCapacity   | 500000  | 15,008,288.0 ns |  49,836.33 ns |    63,027.01 ns |     -56% |    1.4% | 109.3750 | 109.3750 | 109.3750 | 16000099 B |        -52% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **600000**  | **51,502,444.4 ns** | **518,104.60 ns** |   **691,654.82 ns** | **baseline** |        **** | **400.0000** | **400.0000** | **400.0000** | **67109398 B** |            **** |
| GivenInitialCapacity   | 600000  | 19,531,931.2 ns | 148,707.68 ns |   188,067.62 ns |     -62% |    1.6% |  93.7500 |  93.7500 |  93.7500 | 19200100 B |        -71% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **700000**  | **51,817,515.2 ns** | **577,061.10 ns** |   **770,360.06 ns** | **baseline** |        **** | **300.0000** | **300.0000** | **300.0000** | **67109365 B** |            **** |
| GivenInitialCapacity   | 700000  | 19,825,122.3 ns | 553,151.81 ns |   699,559.99 ns |     -62% |    3.7% |  93.7500 |  93.7500 |  93.7500 | 22400100 B |        -67% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **800000**  | **54,113,862.8 ns** | **833,542.86 ns** | **1,112,755.87 ns** | **baseline** |        **** | **300.0000** | **300.0000** | **300.0000** | **67109365 B** |            **** |
| GivenInitialCapacity   | 800000  | 22,481,414.4 ns | 330,396.68 ns |   441,070.11 ns |     -58% |    2.8% |  93.7500 |  93.7500 |  93.7500 | 25600100 B |        -62% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **900000**  | **50,759,764.0 ns** | **431,708.34 ns** |   **576,318.29 ns** | **baseline** |        **** | **272.7273** | **272.7273** | **272.7273** | **67109352 B** |            **** |
| GivenInitialCapacity   | 900000  | 23,802,492.6 ns | 209,738.95 ns |   279,995.50 ns |     -53% |    1.6% |  93.7500 |  93.7500 |  93.7500 | 28800100 B |        -57% |
|                        |         |                 |               |                 |          |         |          |          |          |            |             |
| **DefaultInitialCapacity** | **1000000** | **56,345,905.5 ns** | **508,599.37 ns** |   **678,965.60 ns** | **baseline** |        **** | **272.7273** | **272.7273** | **272.7273** | **67109352 B** |            **** |
| GivenInitialCapacity   | 1000000 | 25,823,510.0 ns | 630,570.58 ns |   819,919.93 ns |     -54% |    3.3% |  93.7500 |  93.7500 |  93.7500 | 32000100 B |        -52% |
