

---
type: csharp-note
language: C#
created: 2026-09-24
tags:
  - csharp
---

# Else...if ключова дума и ред на важност

## 📌 Какво ще се прави?

Ще разберем кога да използваме else if

## 🧠 Бележки

Ще разгледаме `else if`, което по същество ни позволява да изпълняваме код, когато друго условие е изпълнено, ако първото не е изпълнено.
Как би изглеждало това?
Ние имаме ако възрастта е поне 18 или повече, така че нека да поставим едно ново условие точно след това

> [!code] C# Използване на else if
> ```csharp
> int age = 13;
> if (age >= 18)
> {
>  Console.WriteLine("Go party in the club!");
>  } else if (age > 6)
>  {
>  Console.WriteLine()
>  }
>  else
>  {
>  Console.WriteLine("Go party in school!");
>  }
> ```

Това ще изпълни в зависимост от ва дали неговото условие е вярно или не.
Нека да кажем, че възрастта е по-голяма от 6 години.

> [!code] C# Code
> ```csharp
> int age = 13;
> if (age >= 18)
> {
>  Console.WriteLine("Go party in the club!");
>  } else if (age > 6)
>  {
>  Console.WriteLine("Go party in school!");
>  }
>  else
>  {
>  Console.WriteLine("Go party in kindergraden!");
>  }
> ```

Сега, в зависимост от възрастта, ние ще получим определен изход. Нека да го пуснем отново.

![](../Images/63.png)

Ние обаче имаме и друг вариант. Нека да кажем, че сме на 3 години.

> [!code] C# Code
> ```csharp
> int age = 3;
> if (age >= 18)
> {
>  Console.WriteLine("Go party in the club!");
>  } else if (age > 6)
>  {
>  Console.WriteLine("Go party in school!");
>  }
>  else
>  {
>  Console.WriteLine("Go party in kindergraden!");
>  }
> ```

![](../Images/64.png)

Виждаме, че сега получихме различно съобщение.
Защо се получи това?
Ние имаме `if` блок, `else if` и `else` блок.
Винаги се з