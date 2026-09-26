# Benchmark Analysis

## Overview

This benchmark compares `String` concatenation using the `+` operator with `StringBuilder` using the `Append()` method.

The benchmark was tested with different iteration counts:

- 100
- 1,000
- 10,000
- 100,000

`MemoryDiagnoser` was used to measure memory allocation.

## Benchmark Results

| Method | Iterations | Mean | Error | StdDev | Allocated |
|---|---:|---:|---:|---:|---:|
| StringConcatenation | 100 | 9,830.0 ns | 433.70 ns | 1,230.33 ns | 71.45 KB |
| StringBuilderConcatenation | 100 | 748.8 ns | 27.78 ns | 80.60 ns | 2.45 KB |
| StringConcatenation | 1,000 | 820,949.0 ns | 45,744.37 ns | 129,022.83 ns | 6,867.15 KB |
| StringBuilderConcatenation | 1,000 | 3,973.7 ns | 141.38 ns | 410.16 ns | 16.66 KB |
| StringConcatenation | 10,000 | 142,225,248.5 ns | 5,684,480.03 ns | 16,033,177.94 ns | 683,951.49 KB |
| StringBuilderConcatenation | 10,000 | 41,355.4 ns | 2,791.24 ns | 8,230.02 ns | 142.22 KB |
| StringConcatenation | 100,000 | 26,987,682,078.0 ns | 2,044,012,752.37 ns | 6,026,818,155.53 ns | 68,366,393.26 KB |
| StringBuilderConcatenation | 100,000 | 213,342.9 ns | 4,171.42 ns | 8,707.30 ns | 1,382.15 KB |

## Analysis

### 1. Which approach was faster at 100 iterations?

At 100 iterations:

- String Concatenation: `9,830.0 ns`
- StringBuilder: `748.8 ns`

StringBuilder had the lower execution time.

### 2. Which approach was faster at 100,000 iterations?

At 100,000 iterations:

- String Concatenation: `26,987,682,078.0 ns`
- StringBuilder: `213,342.9 ns`

StringBuilder had the lower execution time.

### 3. Which approach allocated more memory?

String concatenation allocated more memory.

At 100,000 iterations:

- String Concatenation: `68,366,393.26 KB`
- StringBuilder: `1,382.15 KB`

### 4. What happened to String Concatenation performance as the loop size increased?

As the number of iterations increased, the execution time of String Concatenation increased significantly.

The measured mean changed from:

- `9,830.0 ns` at 100 iterations
- `820,949.0 ns` at 1,000 iterations
- `142,225,248.5 ns` at 10,000 iterations
- `26,987,682,078.0 ns` at 100,000 iterations

This shows that repeated string concatenation became increasingly expensive as the workload increased.

### 5. Why does repeated string concatenation create additional allocations?

Strings in C# are immutable.

When using:

```csharp
result += "Academy";