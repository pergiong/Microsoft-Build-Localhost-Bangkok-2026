# Microsoft-Build-Localhost-Bangkok-2026

# ComplexDemo – GitHub Copilot Agents Demo

This project is designed to **demonstrate GitHub Copilot Agents**  
(@debugger, @profiler, @test) and how similar behaviors can be simulated with **Copilot Free**.

---

## 📂 Project Structure


---

## 🐞 Debugger Demo – `UserProcessor.cs`
- Contains multiple exceptions:
  - `NullReferenceException`
  - `ArgumentOutOfRangeException`
  - `DivideByZeroException`
- **Agent Prompt:**  
  - “Why does this code throw an exception?”  
  - “Fix this code so it doesn’t throw an exception.”

---

## ⚡ Profiler Demo – `MathUtils.cs`
- Inefficient prime factorization algorithm with nested loops.
- **Agent Prompt:**  
  - “Analyze the performance of this loop.”  
  - “Suggest a faster implementation for this function.”

---

## 🧪 Test Demo – `OrderProcessor.cs`
- Complex business logic for calculating order totals with discounts.
- Includes edge cases:
  - Empty item list
  - Invalid discount rate
  - Negative totals
- **Agent Prompt:**  
  - “Generate unit tests for this class.”  
  - “Write unit tests to cover edge cases for this method.”

---

## 🚀 How to Run
1. Open the solution in **Visual Studio 2022 v17.14+ or VS 2026 Insiders**.
2. Enable **Copilot Agents** via  
   `Tools → Options → GitHub → Copilot → Enable Copilot Agents`.
3. Run the project (`Program.cs`) to trigger sample outputs.
4. Use **Agent Picker** (`Ctrl + /`) or **Copilot Chat** to demo:
   - Debugging exceptions
   - Profiling performance
   - Generating unit tests

---

## ✅ Demo Flow
1. **Show Debugger Agent** analyzing `UserProcessor.PrintUser()`.
2. **Show Profiler Agent** optimizing `MathUtils.PrimeFactors()`.
3. **Show Test Agent** generating unit tests for `OrderProcessor`.

---

## 📌 Notes
- If **Copilot Pro** is unavailable, use **Copilot Free** with prompts in Copilot Chat:
  - “Fix this code so it doesn’t throw an exception.”  
  - “Optimize this loop for performance.”  
  - “Generate unit tests for this class.”  
- Inline suggestions (`// TODO: ...`) can also be used to simulate agent behavior.

---

## 🎯 Purpose
This demo illustrates how GitHub Copilot enhances developer productivity:
- **@debugger** → Faster bug detection & fixes  
- **@profiler** → Performance insights & optimizations  
- **@test** → Automated unit test generation  

Perfect for presentations, workshops, and live demos.
