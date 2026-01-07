# 🔌 Adapter Design Pattern - First Example

> **Welcome!** This repository showcases my first exploration of the Adapter Design Pattern, a fundamental structural pattern in software design.

---

## 📚 What's the Adapter Pattern All About?

The Adapter pattern is a structural design pattern that allows objects with incompatible interfaces to work together. Think of it like a real-world adapter—just as you use a power adapter to connect devices with different plug types, the Adapter pattern bridges the gap between different interfaces in your code!

### 🎯 The Key Ingredients

| Component | Description |
|-----------|-------------|
| **Target Interface** (`ITarget`) | The interface that the client expects to work with |
| **Adaptee** (`Adaptee`) | The existing class with a different interface that needs to be adapted |
| **Adapter** (`Adapter`) | The class that implements the Target interface and wraps the Adaptee to make it compatible |

---

## 🎬 The Scenario

Imagine you have:
- An existing class (`Adaptee`) that does something useful but has a method called `SpecificRequest()`
- A client that expects to work with something that has a `Request()` method (defined by `ITarget`)

**The Problem:** These two interfaces don't match! ❌

**The Solution:** The Adapter comes in and wraps the `Adaptee`, translating the `Request()` call into a `SpecificRequest()` call. ✅

---

## 📁 Project Structure

```
FirstAdapterExample/
├── ITarget.cs         # The target interface - what the client expects
├── Adaptee.cs         # The existing class with incompatible interface
├── Adapter.cs         # The adapter - makes Adaptee compatible with ITarget
└── Program.cs         # Demo application - the client code
```

---

## ⚙️ How It Works

### 1️⃣ The Target Interface
```csharp
public interface ITarget
{
    void Request();
}
```
<i>This is what our client code expects to use.</i>

### 2️⃣ The Adaptee (Existing Class)
```csharp
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee's specific request called.");
    }
}
```
<i>This class has a different method name (`SpecificRequest` instead of `Request`).</i>

### 3️⃣ The Adapter (Makes Them Compatible)
```csharp
public class Adapter(Adaptee adaptee) : ITarget
{
    public void Request()
    {
        adaptee.SpecificRequest();
    }
}
```
<i>The Adapter:</i>
- Implements the `ITarget` interface (so the client is happy) ✓
- Takes an `Adaptee` instance via constructor injection ✓
- Translates the `Request()` call to `SpecificRequest()` ✓

### 4️⃣ Using It All Together
```csharp
ITarget target = new Adapter(new Adaptee());
target.Request();
```

**Output:**
```
Adaptee's specific request called.
```

---

## 💡 Why Use the Adapter Pattern?

| Benefit | Description |
|---------|-------------|
| ♻️ **Reuse Existing Code** | You don't need to modify the `Adaptee` class—you can use it as-is |
| 🔗 **Interface Compatibility** | Make incompatible interfaces work together seamlessly |
| 🎯 **Separation of Concerns** | Keep the Adaptee's logic separate from the adaptation logic |
| 📈 **Easy to Extend** | Need to adapt multiple classes? Create multiple adapters! |

---

## 🌍 Real-World Examples

- **🔌 Power Adapters**: Different countries use different electrical outlets—an adapter lets you use the same device everywhere
- **🔀 USB Adapters**: Converting USB-C to USB-A
- **📚 Third-party Libraries**: When you need to use a library with a different interface than what your code expects
- **🏛️ Legacy Code Integration**: When you have old code you can't modify but need to use with new systems

---

## ✨ When to Use It

Use the Adapter pattern when:
- ✓ You want to use a class that has an incompatible interface
- ✓ You need to integrate classes from different libraries with different interfaces
- ✓ You want to make existing code work with new code without modifying the existing code
- ✓ You need to create a common interface for multiple classes with different methods

---

## 🛠️ Tech Stack

- **.NET 10**
- **C# 14.0**

---

<div align="center">

**Happy Coding! 🚀**

</div>
