<%*
const files = app.vault.getMarkdownFiles();

let maxNumber = 0;

for (const file of files) {
    const match = file.basename.match(/^(\d+)\s*-/);

    if (match) {
        maxNumber = Math.max(maxNumber, Number(match[1]));
    }
}

const nextNumber = String(maxNumber + 1).padStart(2, "0");
const title = await tp.system.prompt("Име на бележката:");

await tp.file.rename(`${nextNumber} - ${title}`);
%>

---
type: csharp-note
language: C#
created: <% tp.date.now("YYYY-MM-DD") %>
tags:
  - csharp
---

# <% title %>

## 📌 Какво е?

Напиши с твои думи какво представлява.

## 🧠 Основна идея

- 
- 
- 

## 💻 Синтаксис

```csharp

🧪 Пример

[!important] Запомни

[!warning] Честа грешка

[!tip] Съвет

🔗 Свързано