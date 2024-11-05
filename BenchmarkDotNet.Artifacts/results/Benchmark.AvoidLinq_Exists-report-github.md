```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UKUTRU : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method             | Length  | Mean              | Error          | StdDev          | Gen0   | Allocated |
|------------------- |-------- |------------------:|---------------:|----------------:|-------:|----------:|
| ArrayExists        | 10      |         13.304 ns |      0.1802 ns |       0.2405 ns |      - |         - |
| ArrayLinqAny       | 10      |         58.742 ns |      1.7084 ns |       2.2807 ns | 0.0153 |      32 B |
| ListLinqAny        | 10      |         97.327 ns |      1.8671 ns |       2.4925 ns | 0.0191 |      40 B |
| IEnumerableLinqAny | 10      |         97.330 ns |      2.1410 ns |       2.8581 ns | 0.0191 |      40 B |
| ImperativeExists   | 10      |          8.732 ns |      0.1776 ns |       0.2371 ns |      - |         - |
| ArrayExists        | 35      |         44.674 ns |      0.7663 ns |       0.9964 ns |      - |         - |
| ArrayLinqAny       | 35      |        152.128 ns |      3.1385 ns |       4.1897 ns | 0.0153 |      32 B |
| ListLinqAny        | 35      |        302.315 ns |      8.5138 ns |      11.3657 ns | 0.0191 |      40 B |
| IEnumerableLinqAny | 35      |        307.544 ns |      6.3688 ns |       8.5022 ns | 0.0191 |      40 B |
| ImperativeExists   | 35      |         24.744 ns |      0.3689 ns |       0.4665 ns |      - |         - |
| ArrayExists        | 60      |         64.739 ns |      0.9309 ns |       1.1773 ns |      - |         - |
| ArrayLinqAny       | 60      |        239.097 ns |      8.0436 ns |      10.7380 ns | 0.0153 |      32 B |
| ListLinqAny        | 60      |        493.354 ns |     14.6953 ns |      19.6178 ns | 0.0191 |      40 B |
| IEnumerableLinqAny | 60      |        462.928 ns |      7.1634 ns |       9.3144 ns | 0.0191 |      40 B |
| ImperativeExists   | 60      |         53.983 ns |      0.3923 ns |       0.5101 ns |      - |         - |
| ArrayExists        | 85      |         90.590 ns |      1.5084 ns |       2.0137 ns |      - |         - |
| ArrayLinqAny       | 85      |        338.144 ns |      6.1288 ns |       7.9692 ns | 0.0153 |      32 B |
| ListLinqAny        | 85      |        679.389 ns |     15.4791 ns |      20.6642 ns | 0.0191 |      40 B |
| IEnumerableLinqAny | 85      |        697.723 ns |     12.5279 ns |      16.7244 ns | 0.0191 |      40 B |
| ImperativeExists   | 85      |         68.868 ns |      1.5671 ns |       2.0377 ns |      - |         - |
| ArrayExists        | 100     |        102.892 ns |      1.0171 ns |       1.3579 ns |      - |         - |
| ArrayLinqAny       | 100     |        385.906 ns |      6.6549 ns |       8.8841 ns | 0.0153 |      32 B |
| ListLinqAny        | 100     |        797.971 ns |     13.6338 ns |      18.2007 ns | 0.0191 |      40 B |
| IEnumerableLinqAny | 100     |        814.578 ns |     11.9441 ns |      15.9451 ns | 0.0191 |      40 B |
| ImperativeExists   | 100     |         79.473 ns |      1.3296 ns |       1.7750 ns |      - |         - |
| ArrayExists        | 350     |        330.645 ns |      6.7640 ns |       9.0297 ns |      - |         - |
| ArrayLinqAny       | 350     |      1,315.721 ns |     27.1005 ns |      36.1784 ns | 0.0153 |      32 B |
| ListLinqAny        | 350     |      2,775.130 ns |     58.8540 ns |      78.5685 ns | 0.0191 |      40 B |
| IEnumerableLinqAny | 350     |      2,762.313 ns |     49.6040 ns |      64.4992 ns | 0.0191 |      40 B |
| ImperativeExists   | 350     |        237.560 ns |      2.8682 ns |       3.7295 ns |      - |         - |
| ArrayExists        | 600     |        573.915 ns |     10.8976 ns |      14.5479 ns |      - |         - |
| ArrayLinqAny       | 600     |      2,044.148 ns |     45.4866 ns |      60.7233 ns | 0.0153 |      32 B |
| ListLinqAny        | 600     |      4,679.770 ns |    129.8303 ns |     173.3197 ns | 0.0153 |      40 B |
| IEnumerableLinqAny | 600     |      4,628.914 ns |    140.7498 ns |     187.8970 ns | 0.0153 |      40 B |
| ImperativeExists   | 600     |        489.428 ns |      4.8491 ns |       6.4734 ns |      - |         - |
| ArrayExists        | 850     |        809.971 ns |      8.4080 ns |      10.9327 ns |      - |         - |
| ArrayLinqAny       | 850     |      3,167.732 ns |     35.3079 ns |      45.9103 ns | 0.0153 |      32 B |
| ListLinqAny        | 850     |      6,586.816 ns |    139.1448 ns |     185.7543 ns | 0.0153 |      40 B |
| IEnumerableLinqAny | 850     |      5,896.894 ns |    184.5296 ns |     246.3418 ns | 0.0153 |      40 B |
| ImperativeExists   | 850     |        684.848 ns |     15.5167 ns |      20.7143 ns |      - |         - |
| ArrayExists        | 1000    |        944.054 ns |     10.8167 ns |      13.6796 ns |      - |         - |
| ArrayLinqAny       | 1000    |      3,426.492 ns |     45.7979 ns |      61.1389 ns | 0.0153 |      32 B |
| ListLinqAny        | 1000    |      7,536.173 ns |    195.8207 ns |     261.4151 ns | 0.0153 |      40 B |
| IEnumerableLinqAny | 1000    |      7,773.149 ns |    186.1938 ns |     242.1046 ns | 0.0153 |      40 B |
| ImperativeExists   | 1000    |        802.726 ns |      9.3006 ns |      12.4160 ns |      - |         - |
| ArrayExists        | 3500    |      3,290.900 ns |     39.8428 ns |      53.1889 ns |      - |         - |
| ArrayLinqAny       | 3500    |     11,973.595 ns |    176.5473 ns |     223.2758 ns | 0.0153 |      32 B |
| ListLinqAny        | 3500    |     28,681.888 ns |    328.4609 ns |     438.4860 ns |      - |      40 B |
| IEnumerableLinqAny | 3500    |     27,383.452 ns |    535.1076 ns |     714.3534 ns |      - |      40 B |
| ImperativeExists   | 3500    |      2,865.361 ns |     42.0280 ns |      56.1062 ns |      - |         - |
| ArrayExists        | 6000    |      8,053.608 ns |    187.0543 ns |     249.7121 ns |      - |         - |
| ArrayLinqAny       | 6000    |     20,872.291 ns |    370.2122 ns |     494.2227 ns |      - |      32 B |
| ListLinqAny        | 6000    |     47,224.766 ns |    654.7424 ns |     874.0623 ns |      - |      40 B |
| IEnumerableLinqAny | 6000    |     44,111.297 ns |  1,229.0928 ns |   1,598.1680 ns |      - |      40 B |
| ImperativeExists   | 6000    |      6,524.110 ns |     68.6980 ns |      89.3268 ns |      - |         - |
| ArrayExists        | 8500    |     13,179.303 ns |    133.5762 ns |     178.3204 ns |      - |         - |
| ArrayLinqAny       | 8500    |     29,608.729 ns |    330.5757 ns |     441.3091 ns |      - |      32 B |
| ListLinqAny        | 8500    |     62,019.893 ns |  1,273.9553 ns |   1,700.6939 ns |      - |      40 B |
| IEnumerableLinqAny | 8500    |     67,894.632 ns |  1,869.0813 ns |   2,495.1701 ns |      - |      40 B |
| ImperativeExists   | 8500    |     12,328.845 ns |    142.2836 ns |     185.0088 ns |      - |         - |
| ArrayExists        | 10000   |     15,751.826 ns |    152.4065 ns |     203.4583 ns |      - |         - |
| ArrayLinqAny       | 10000   |     34,918.701 ns |    633.6458 ns |     823.9186 ns |      - |      32 B |
| ListLinqAny        | 10000   |     79,281.321 ns |    998.2920 ns |   1,298.0617 ns |      - |      40 B |
| IEnumerableLinqAny | 10000   |     80,307.164 ns |  1,979.0338 ns |   2,641.9535 ns |      - |      40 B |
| ImperativeExists   | 10000   |     14,568.796 ns |    147.6493 ns |     197.1077 ns |      - |         - |
| ArrayExists        | 35000   |    170,454.067 ns |  1,178.5310 ns |   1,573.3051 ns |      - |         - |
| ArrayLinqAny       | 35000   |    269,865.943 ns |  2,186.5601 ns |   2,765.2987 ns |      - |      32 B |
| ListLinqAny        | 35000   |    346,530.078 ns |  2,673.2789 ns |   3,568.7509 ns |      - |      40 B |
| IEnumerableLinqAny | 35000   |    345,515.935 ns |  2,861.6959 ns |   3,619.1293 ns |      - |      40 B |
| ImperativeExists   | 35000   |    134,669.827 ns |    960.8839 ns |   1,282.7525 ns |      - |         - |
| ArrayExists        | 60000   |    337,219.250 ns |  2,637.3181 ns |   3,429.2587 ns |      - |         - |
| ArrayLinqAny       | 60000   |    547,444.351 ns |  2,204.3372 ns |   2,538.5180 ns |      - |      32 B |
| ListLinqAny        | 60000   |    695,751.221 ns |  3,206.0757 ns |   3,692.1216 ns |      - |      40 B |
| IEnumerableLinqAny | 60000   |    700,333.421 ns |  5,889.6520 ns |   7,233.0222 ns |      - |      40 B |
| ImperativeExists   | 60000   |    308,062.832 ns |    956.5186 ns |   1,209.6899 ns |      - |         - |
| ArrayExists        | 85000   |    494,243.852 ns |  2,590.0895 ns |   3,180.8628 ns |      - |         - |
| ArrayLinqAny       | 85000   |    798,398.735 ns |  2,494.7951 ns |   2,969.8764 ns |      - |      32 B |
| ListLinqAny        | 85000   |  1,005,756.250 ns |  6,864.7124 ns |   8,926.0659 ns |      - |      40 B |
| IEnumerableLinqAny | 85000   |  1,037,326.307 ns | 14,027.8965 ns |  16,699.2144 ns |      - |      41 B |
| ImperativeExists   | 85000   |    478,968.708 ns |  1,909.4122 ns |   2,273.0196 ns |      - |         - |
| ArrayExists        | 100000  |    576,657.012 ns |  2,082.2548 ns |   2,779.7506 ns |      - |         - |
| ArrayLinqAny       | 100000  |    939,891.587 ns |  1,472.2950 ns |   1,695.4971 ns |      - |      32 B |
| ListLinqAny        | 100000  |  1,183,861.646 ns |  4,630.5765 ns |   6,021.0579 ns |      - |      41 B |
| IEnumerableLinqAny | 100000  |  1,187,336.961 ns |  5,901.9081 ns |   7,025.8023 ns |      - |      41 B |
| ImperativeExists   | 100000  |    559,457.454 ns |  1,427.4939 ns |   1,856.1454 ns |      - |         - |
| ArrayExists        | 350000  |  2,012,143.529 ns |  7,376.0042 ns |   9,328.2845 ns |      - |       2 B |
| ArrayLinqAny       | 350000  |  3,245,826.350 ns |  9,735.4251 ns |  12,312.1967 ns |      - |      34 B |
| ListLinqAny        | 350000  |  4,171,792.611 ns | 26,037.4152 ns |  33,855.9973 ns |      - |      43 B |
| IEnumerableLinqAny | 350000  |  4,294,903.971 ns | 23,950.8607 ns |  31,142.8869 ns |      - |      43 B |
| ImperativeExists   | 350000  |  1,964,774.219 ns |  7,073.3199 ns |   8,420.2849 ns |      - |       1 B |
| ArrayExists        | 600000  |  3,557,703.267 ns | 25,960.3096 ns |  31,881.5943 ns |      - |       2 B |
| ArrayLinqAny       | 600000  |  5,685,418.466 ns | 49,687.7022 ns |  61,020.9659 ns |      - |      44 B |
| ListLinqAny        | 600000  |  6,893,664.583 ns | 63,128.3588 ns |  82,084.7051 ns |      - |      52 B |
| IEnumerableLinqAny | 600000  |  6,829,343.750 ns | 47,326.1861 ns |  61,537.4152 ns |      - |      52 B |
| ImperativeExists   | 600000  |  3,355,484.712 ns |  5,480.5284 ns |   6,730.5816 ns |      - |       2 B |
| ArrayExists        | 850000  |  4,859,275.000 ns | 36,065.0482 ns |  46,894.7538 ns |      - |      12 B |
| ArrayLinqAny       | 850000  |  7,997,495.182 ns | 14,747.8425 ns |  19,176.3626 ns |      - |      38 B |
| ListLinqAny        | 850000  |  9,817,572.147 ns | 53,938.1875 ns |  68,214.5428 ns |      - |      46 B |
| IEnumerableLinqAny | 850000  |  9,843,881.576 ns | 73,399.2329 ns |  95,439.7436 ns |      - |      46 B |
| ImperativeExists   | 850000  |  4,765,842.510 ns | 27,322.5116 ns |  34,554.2318 ns |      - |       3 B |
| ArrayExists        | 1000000 |  5,725,090.483 ns | 29,105.6184 ns |  35,744.3164 ns |      - |      12 B |
| ArrayLinqAny       | 1000000 |  9,455,990.820 ns | 30,208.4879 ns |  39,279.5704 ns |      - |      38 B |
| ListLinqAny        | 1000000 | 11,426,453.397 ns | 77,108.0219 ns |  97,516.9672 ns |      - |      65 B |
| IEnumerableLinqAny | 1000000 | 11,468,225.000 ns | 79,276.5328 ns | 103,081.8944 ns |      - |      65 B |
| ImperativeExists   | 1000000 |  5,594,705.398 ns | 18,414.3215 ns |  22,614.4425 ns |      - |       3 B |
