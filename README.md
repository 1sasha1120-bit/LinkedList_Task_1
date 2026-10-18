# LinkedList_Task1

Консольний застосунок на C# (.NET 10), що працює зі зв'язним списком (`Node<T>`).
Метод розширення `GetTwoThirdsNode(n)` повертає значення елемента на позиції «дві третини» списку.

## Вимоги

- **Visual Studio 2026** (v18) із робочим навантаженням **«.NET desktop development»** (або «.NET Multi-platform App UI / ASP.NET» — головне, щоб був встановлений .NET SDK)
- **.NET 10 SDK** (входить до Visual Studio 2026; перевірити можна командою `dotnet --version` — має бути `10.x`)
- **Git** (входить до Visual Studio, окремо встановлювати не обов'язково)

> Проєкт використовує формат рішення `.slnx` та `net10.0`, тому старіші версії Visual Studio (2022 і раніше) його не відкриють або не зберуть.

## Запуск проєкту у Visual Studio

### 1. Клонування репозиторію з GitHub

1. Відкрийте Visual Studio.
2. На стартовому вікні натисніть **Clone a repository** (Клонувати репозиторій).
3. У полі **Repository location** вставте посилання:
   ```
   https://github.com/1sasha1120-bit/LinkedList_Task_1.git
   ```
4. У полі **Path** оберіть папку на диску, куди завантажити проєкт.
5. Натисніть **Clone**.

Альтернатива через термінал:

```bash
git clone https://github.com/1sasha1120-bit/LinkedList_Task_1.git
```

після чого відкрийте Visual Studio → **File → Open → Project/Solution** і оберіть файл `LinkedList_Task1.slnx`.

### 2. Відкриття рішення

Після клонування в **Solution Explorer** двічі клікніть файл **`LinkedList_Task1.slnx`**
(якщо Solution Explorer показує лише папки — натисніть **Switch Views** і оберіть Solution `.slnx`).

### 3. Відновлення пакетів і збірка

Visual Studio автоматично відновить залежності (NuGet restore). Далі:

- **Build → Build Solution** (або `Ctrl + Shift + B`)

Збірка має завершитися повідомленням `Build succeeded`.

### 4. Запуск

- Переконайтеся, що стартовий проєкт — `LinkedList_Task1` (виділений жирним у Solution Explorer).
- Натисніть **Debug → Start Without Debugging** (`Ctrl + F5`) — результат виведеться в консоль і вікно не закриється одразу.
  Або **Debug → Start Debugging** (`F5`) для запуску з налагодженням.
