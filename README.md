# Lambda Exercises in C#

A hands-on curriculum for mastering C# **lambdas, delegates, LINQ, closures, async, and expression trees**.  
Each day introduces a focused set of exercises with unit tests to guide implementation.

---

## 📂 Project Structure
lambda-exercises-csharp/
├─ src/ # Library projects (Day01, Day02, …)
├─ tests/ # xUnit test projects
├─ lambda-exercises-csharp.sln
└─ README.md


- **`src/DayXX_*`** → library with exercise stubs / implementations  
- **`tests/DayXX_*.Tests`** → xUnit test projects driving the exercises  

---

## 🚀 Getting Started

1. **Clone the repo**
   ```bash
   git clone https://github.com/Vexmage/lambda-exercises-csharp.git
   cd lambda-exercises-csharp

## Build and run tests

dotnet build
dotnet test

## Pick a day
Open the corresponding src/DayXX_* folder and work through the exercises.
The unit tests in tests/DayXX_*.Tests will guide your progress.

## 📘 Curriculum

Day 1: Basics
Map, Filter, Reduce, lambda syntax, closure capture pitfalls.

Day 2: Delegates & Closures
Custom delegates, counters, partial application, memoization.

Day 3: LINQ Core
Select, Where, Any/All, Aggregate, GroupBy.

Day 4: LINQ Advanced
Joins, GroupJoin, DistinctBy, Lookups, paging.

Day 5: Extensions & Composition
Pipe, Tee, WhereIf, Compose, predicate combinators.

Day 6: Events & Async Pipelines
Event handlers, tasks, continuations, cancellation.

Day 7: Expressions & Performance
Expression trees, dynamic query building, compiled delegates.

## Definitions
### Lambdas
Anonymous functions (inline pieces of code like x => x * 2) that can be passed around as values.
They make code concise and expressive, especially for quick transformations or filters without needing to define a full method.

### Delegates
Type-safe references to methods. A delegate defines a function signature (Func<T, U>, Action<T>, or custom) that lambdas or methods must match.
They enable flexible APIs where behavior is passed as a parameter (e.g., a Comparison<T> for sorting).

### LINQ (Language Integrated Query)
A set of features and APIs in .NET that use lambdas to query and transform collections (.Where, .Select, .GroupBy).
It lets you write SQL-like logic directly in C#, making data manipulation expressive and readable.

### Closures
When a lambda "captures" variables from the surrounding scope.
Closures make it possible to preserve state across function calls (e.g., counters), but also introduce pitfalls if you accidentally capture changing loop variables.

### Async
Short for asynchronous programming — writing methods (async Task) that run without blocking the main thread.
Useful for I/O-bound work like file access, APIs, or database calls; lambdas often appear in async continuations (.ContinueWith(t => ...)) or async LINQ-style pipelines.

### Expression Trees
Data structures that represent code (lambdas) as an object tree instead of compiled delegates.
They’re powerful for building dynamic queries (e.g., Entity Framework translating a u => u.Age > 18 expression into SQL) or for meta-programming scenarios.

## 🛠 Tools & Frameworks

.NET 9 SDK
xUnit for testing
FluentAssertions for expressive assertions
