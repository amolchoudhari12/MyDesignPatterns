# 🧠 MyDesignPatterns — Complete OOP Design Patterns Reference in C#

> **A Self-Reference Toolkit for Architects and Senior Engineers**

![C#](https://img.shields.io/badge/language-C%23-512BD4?style=for-the-badge)
![Platform](https://img.shields.io/badge/platform-.NET-blueviolet?style=for-the-badge)
![License](https://img.shields.io/badge/license-Learning%20Use-green?style=for-the-badge)

---

## 🏗️ Overview

**MyDesignPatterns** is a comprehensive C# console application demonstrating **all major Object-Oriented Design Patterns**, built with **real-world, scenario-driven examples**.

As a **Software Architect**, this project serves as your **personal reference library** — helping you recall, revisit, and reuse design fundamentals anytime you face complex architectural decisions.

Each pattern is thoughtfully implemented to simulate practical use-cases rather than abstract textbook examples, allowing you to understand *why* and *when* to use a particular pattern.

---

## 🎯 Purpose

In real-world architecture, not every challenge fits neatly into a single pattern.  
This repository acts as your **architectural encyclopedia** — a go-to companion that helps you derive hybrid or contextual designs from classical foundations.

> “Understanding design patterns deeply liberates you from dependence — you think like an architect, not just code like a developer.”

This collection ensures that you’re **never dependent** on references or external help when designing scalable, maintainable software systems.

---

## 🧩 Implemented Design Patterns

| Category | Patterns Implemented |
|-----------|----------------------|
| **Creational** | Singleton • Factory Method • Abstract Factory • Builder • Prototype |
| **Structural** | Adapter • Bridge • Composite *(extendable: Decorator, Facade, Proxy)* |
| **Behavioral** | Chain of Responsibility • Command • Iterator • Mediator • Memento • Observer • State • Strategy • Template Method • Visitor |

Each resides in its own namespace (e.g. `MyDesignPatterns.FactoryPattern`) to keep the implementation modular and readable.

---

## ⚙️ How to Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/MyDesignPatterns.git
   cd MyDesignPatterns
   ```

2. **Open in Visual Studio / VS Code**

3. **Select the pattern to execute**  
   In `Program.cs`, uncomment the desired pattern method:
   ```csharp
   //ShowFactoryPattern();
   ShowPrototypePattern();
   ```

4. **Run the project**
   ```bash
   dotnet run
   ```

5. Observe the **console output**, which demonstrates object creation, interaction, and lifecycle according to the pattern.

---

## 🧠 Key Demonstrations

| Pattern | Scenario Example |
|----------|------------------|
| **Prototype** | Dropdown cloning for faster UI initialization |
| **Observer** | Real estate system notifying seekers of new property listings |
| **Mediator** | Airport traffic control coordinating aircraft arrivals |
| **Builder** | Constructing multiple house types with dedicated builders |
| **Chain of Responsibility** | IT Support escalation through multiple support levels |
| **Strategy** | Language translation with interchangeable translation strategies |
| **Template Method** | Common structure for multi-language conversion workflows |
| **State** | Dynamic speed management in a car simulation |
| **Command** | Restaurant order and kitchen command queue simulation |
| **Iterator** | Custom collection traversal using user-defined iterators |

---

## 📂 Project Structure

```
MyDesignPatterns/
│
├── AbstractFactory/
├── AdapterPattern/
├── BridgePattern/
├── BuilderPattern/
├── ChainOfResponsibility/
├── CommandPattern/
├── CompositePattern/
├── FactoryPattern/
├── IteratorPattern/
├── MediatorPattern/
├── MementoPattern/
├── ObserverPattern/
├── PrototypePattern/
├── Singleton/
├── StatePattern/
├── StrategyPattern/
├── TemplatePattern/
├── VisitorPattern/
│
└── Program.cs     # Entry point for running each pattern demo
```

---

## 🔧 Tech Stack

- **Language:** C#  
- **Framework:** .NET (Core / 6+)  
- **Architecture Principles:** SOLID, DRY, KISS, Interface-driven design  
- **Project Type:** Console Application  

---

## 🧩 Design Philosophy

> “Patterns are not rigid rules — they are mental frameworks that evolve with context.”

This project reflects that philosophy by:
- Demonstrating flexibility in applying patterns to real-world scenarios.  
- Encouraging architectural reasoning rather than rote implementation.  
- Bridging academic principles with executable design models.  

---

## 🚀 Future Enhancements

- Add remaining structural patterns: **Decorator**, **Facade**, **Proxy**  
- Integrate **Unit Tests** for behavioral validation  
- Add a **pattern visualization UI dashboard**  
- Publish as a **NuGet learning package**  

---

## 👨‍💻 Author

**Amol Choudhari**  
*Software Architect*  
Building sustainable SaaS architectures that last decades.  
Driven by a passion for elegant system design, reusability, and knowledge preservation.

---

## 🏁 License

This project is open for **learning and internal reference**.  
For commercial or enterprise reuse, please provide author attribution.

---

> *“Every great system begins with understanding patterns — not copying them.”*
