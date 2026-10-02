# Benchmark Analysis

## BenchmarkDotNet Results

| Method | Iterations | Mean | Error | StdDev | Allocated |
|---|---:|---:|---:|---:|---:|
| StringConcatenation | 100 | 8,708.8 ns | 201.88 ns | 575.98 ns | 71.45 KB |
| StringBuilderConcatenation | 100 | 524.3 ns | 14.00 ns | 38.80 ns | 2.45 KB |
| StringConcatenation | 1,000 | 721,672.8 ns | 20,473.02 ns | 57,070.60 ns | 6,867.15 KB |
| StringBuilderConcatenation | 1,000 | 3,666.9 ns | 76.46 ns | 218.14 ns | 16.66 KB |
| StringConcatenation | 10,000 | 131,315,891.8 ns | 3,811,931.04 ns | 11,119,582.59 ns | 683,664.58 KB |
| StringBuilderConcatenation | 10,000 | 28,234.2 ns | 575.31 ns | 1,650.69 ns | 142.22 KB |
| StringConcatenation | 100,000 | 27,605,318,076.9 ns | 389,802,397.43 ns | 325,502,656.17 ns | 68,366,458.79 KB |
| StringBuilderConcatenation | 100,000 | 319,588.1 ns | 7,269.39 ns | 21,089.81 ns | 1,382.15 KB |

---

### 1. Which approach was faster with 100 iterations?

StringBuilderConcatenation was faster.

- StringConcatenation: 8,708.8 ns
- StringBuilderConcatenation: 524.3 ns

StringBuilder was significantly faster in the 100-iteration benchmark.

### 2. Which approach was faster with 100,000 iterations?

StringBuilderConcatenation was faster.

- StringConcatenation: 27,605,318,076.9 ns
- StringBuilderConcatenation: 319,588.1 ns

The difference became much larger as the number of iterations increased.

### 3. Which approach allocated more memory?

StringConcatenation allocated significantly more memory.

At 100,000 iterations:

- StringConcatenation: 68,366,458.79 KB
- StringBuilderConcatenation: 1,382.15 KB

This shows a very large difference in memory allocation.

### 4. What happened to string concatenation performance as the loop size increased?

String concatenation became significantly slower as the number of iterations increased.

The Mean increased from 8,708.8 ns at 100 iterations to
27,605,318,076.9 ns at 100,000 iterations.

The memory allocation also increased significantly.

### 5. Why does repeated string concatenation create additional allocations?

Strings in C# are immutable. When strings are repeatedly concatenated, the existing string cannot be modified directly.

A new string is created to contain the new combined value. Repeating this process causes many additional string allocations.

### 6. Why does StringBuilder usually perform better when text is repeatedly appended?

StringBuilder is designed for repeated text modifications.

It can append text to its internal buffer instead of creating a completely new string for every append operation.

This reduces the number of allocations and usually improves performance when many append operations are performed.

### 7. Is StringBuilder always better than normal string operations?

No.

StringBuilder is especially useful when text is repeatedly modified or appended many times.

For simple string operations or a small number of concatenations, normal string operations can be appropriate.

The benchmark results in this experiment show that StringBuilder performed better for all tested iteration sizes.