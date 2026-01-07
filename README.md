# 🔌 Adapter Design Pattern Examples

Welcome! This repository contains two hands-on examples of the **Adapter Design Pattern** in C#. Think of the Adapter as a bridge that lets two incompatible things work together—like a power adapter that lets you use a US plug in a European outlet!

---

## 📚 What's Inside?

### 1️⃣ FirstAdapterExample — *The Basics*

This is your **"Hello World"** of adapters! It shows the core idea in its simplest form.

```
┌─────────┐       ┌────────┐       ┌────────┐
│ Adaptee │◄──────│ Adapter│◄──────│ Target │
│ (Old)   │       │(Bridge)│       │(New)   │
└─────────┘       └────────┘       └────────┘
```

**What you'll find:**
- `ITarget` - What the client wants to talk to
- `Adaptee` - The old class with a different interface
- `Adapter` - The magic translator between them
- `Program.cs` - Simple demo showing it all working together

**Great for:** Understanding the pattern from scratch!

### 2️⃣ ConcreteAdapterExample — *Real World*

This example shows how you'd actually use adapters in the real world. Imagine you're building a game engine and need to work with legacy rectangle code from an old library.

```
┌──────────────────┐
│   Game Engine    │
│  (wants modern   │
│   rectangles)    │
└────────┬─────────┘
         │ IRectangle
         ▼
┌──────────────────────────┐
│ LegacyRectangleAdapter   │
│ (Converts the old format)│
└────────┬─────────────────┘
         │
         ▼
┌──────────────────┐
│ LegacyRectangle  │
│ (Old coordinate  │
│  system)         │
└──────────────────┘
```

**What you'll find:**
- `IRectangle` - Modern interface for rectangles
- `LegacyRectangle` - Old class (left, top, right, bottom style)
- `LegacyRectangleAdapter` - Bridges the gap between old and new
- `Program.cs` - Shows a game engine using legacy code seamlessly

**Great for:** Seeing how this pattern solves real integration challenges!

---

## 🔄 Key Differences

| | FirstAdapterExample | ConcreteAdapterExample |
|---|---|---|
| **Complexity** | Simple & abstract | Practical & realistic |
| **Domain** | Generic interfaces | Game engine with geometry |
| **Use Case** | Learning the pattern | Integration scenario |
| **Adaptee** | Simple `Adaptee` class | `LegacyRectangle` (real legacy code) |
| **Target Interface** | `ITarget` (single method) | `IRectangle` (multiple operations) |
| **Best For** | Understanding fundamentals | Real-world applications |

---

## 🚀 Quick Start

### What You Need
- .NET 10.0 or higher
- That's it! No external dependencies.

### Build Everything
```bash
dotnet build
```

### Run Each Example
```bash
# Run the basic example
dotnet run --project FirstAdapterExample

# Run the game engine example
dotnet run --project ConcreteAdapterExample
```

---

## 💡 Why Use the Adapter Pattern?

✅ **Keep your code clean** - Adapt without modifying original classes  
✅ **Reuse legacy code** - Integrate old libraries into new projects  
✅ **Flexible integrations** - Swap implementations on the fly  
✅ **Clean architecture** - Clear separation of concerns  
✅ **Play nice with others** - Make incompatible systems work together  

---

## 🎯 Real-World Scenarios

The Adapter pattern shines when you need to:
- 🏗️ Work with legacy code you can't change
- 📦 Integrate third-party libraries with different interfaces
- 🔌 Bridge multiple versions of the same component
- 🎮 Connect different subsystems in your application
- 🌍 Support multiple external APIs with a unified interface

---

## 📖 Learn More

Want to dive deeper into design patterns? The Adapter pattern is a structural pattern that solves interface incompatibility problems. It's one of the Gang of Four (GoF) design patterns and is super useful in real-world development!
