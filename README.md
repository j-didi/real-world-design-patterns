# Real-World Design Patterns

## Give a Star! :star:

If you like or want to support my work, please give it a star. Thanks!

## Introduction
In software engineering, **Design Patterns** are typical solutions to commonly occurring problems. They propose **well-defined**, **decoupled**, **reusable**, **easily testable**, and **extensible** software components. The idea was introduced in the Architecture area and then adapted for software engineering by the legendary **Gang-of-Four (GoF)**.

## Benefits
- Already validated and documented solutions
- A common vocabulary for the team
- Maintainability, testability, reuse, and more

## Motivation
Since there are a lot of misconceptions and some controversy about **real-world use cases** and the **benefits** of **Design Patterns**, I've decided to create this repository where I'll develop and share some implementations of them. Each pattern will have a **README** file with a **components relationship diagram** and explanations about it. 

## Language
The code will be in **C#**, but the concept is **language agnostic**. Some languages make it easier to implement some patterns, **Kotlin**, for example, has a **Singleton** native implementation with _object_ modifier, and **Python** has a native **Decorator**. On the other hand, languages that don't have _interfaces_ need some workaround with _abstract classes_. But at the end of the day, each one can deliver the same results.

## Patterns
### Behavioral
- [Strategy](Patterns/Behavioral/RealWorldDesignPatterns.Strategy)
- [Rules Engine](Patterns/Behavioral/RealWorldDesignPatterns.RulesEngine)

### Creational

### Structural
- [Decorator](Patterns/Structural/RealWorldDesignPatterns.Decorator)
- [Adapter](Patterns/Structural/RealWorldDesignPatterns.Adapter)

---

## SOLID
In **2000** Robert C. Martin (a.k.a. **Uncle Bob**) published the _Design Principles and Design Patterns_ paper. In this paper, he introduced the **SOLID** principles. Resuming, they are five principles that make software designs more **understandable**, **flexible**, and **maintainable**.

### Single Responsibility Principle - SRP
The patterns suggest using dedicated components instead of multipurpose ones. In **Strategy Pattern**, for example, each strategy is responsible for itself and should not know about others. **SRP** has a similar approach, proposing that each component should have only one reason to change. 

### Open-Closed Principle - OCP
The **OCP** quotes that a software module should be open for extension but closed for modification. The **Decorator** and other patterns do that. With Decorator, you can extend your software component's behaviors without touching implementation.

### Liskov Substitution Principle - LSP
While using the patterns, you will notice constant care about **polymorphism**, **inheritance**, and **composition**. Good use of these principles will simplify the understanding of **LSP** because when you make good use of these concepts, each component could be replaceable for a parent without extra conditions.

### Interface Segregation Principle - ISP
**Separation of Concerns** and **Encapsulation** are recurrent concerns in the patterns. Favor a decoupled, focused communication between the components is the **Mediator's** intent. So, keeping  a module free from dependencies that he doesn't need, as **ISP** proposes, occurs naturally. 

### Dependency Inversion Principle - DIP
**DIP** says that a software module should depend upon abstractions instead of implementation details. Similarly, the patterns favor **Contract-Based Communications** between components. The **Rules Engine** pattern, for instance, abstracts low-level rules implementation details from the service that is validating the operation. The service only needs to know that he must apply some rules. The details about how many rules or what is validated don't matter for him.
