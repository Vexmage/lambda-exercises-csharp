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

## 🛠 Tools & Frameworks

.NET 9 SDK
xUnit for testing
FluentAssertions for expressive assertions
