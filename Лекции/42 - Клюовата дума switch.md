

---
type: csharp-note
language: C#
created: 2026-09-25
tags:
  - csharp
---

# Клюовата дума switch

## 📌 Какво ще се прави?

Ще разберем за още един начин да правим проверки.

## 🧠 Бележки

Нека сега да видим командата `switch` и как работи тя.
В следващата лекция ще разгледаме и разликата между `if` и `switch` и кога кое да използваме.
`switch` е много подобен на `if`.  
Ние видяхме как работи, включително и `else if` и `else`.
Сега да видим как работи `switch`. Ще използваме и други ключови думи като `case` и `break` и `default`.
Ще използваме и четирите, като първо ще започнем със `switch`.

> [!code] C# Използване на switch
> ```csharp
>switch (month)
{
}
> ```

И след това имаме различни случаи (`cases`).
Например в първия случай

> [!code] C# Използване на switch, case  и break
> ```csharp
>switch (month)
>{
> 	case 1:
> 	   monthName = "January";
> 	 break;
> }
> ```

И след това добавяме ключовата дума `break`.
Защо имаме нужда от ключовата дума `break`? Това ни трябва , за да се уверим ,че когато твърдението ни е вярно, никое от изброените по-долу не може да бъде вярно. Това е много подобно на това, което ние видяхме с `if/else`.
Сега нека да разгледаме другите случаи.

> [!code] C# Използване на switch, case  и break
> ```csharp
>switch (month)
>{
> 	case 1:
> 	   monthName = "January";
> 	 break;
> 	 case 2:
> 		 monthName = "February";
> 	break;
> 		case 3:
> 		monthName = "March";
> 	break; 
> }
> ```

И след това обикновено имаме ключовата дума `default`, която може да ни даде името на месеца като неизвестно например.

> [!code] C# Използване на default
> ```csharp
>switch (month)
>{
> 	case 1:
> 	   monthName = "January";
> 	 break;
> 	 case 2:
> 		 monthName = "February";
> 	break;
> 		case 3:
> 		monthName = "March";
> 	break; 
> 	default:
> 		monthName = "Unknown";
> 	break;
> }
> ```

По подразбиране `default` е все едно да имаме `else`. Така че ако числото се различава от числата, които имаме, тогава ще се изпълни `default`.
По този начин общо казано изглежда `switch` командата.








