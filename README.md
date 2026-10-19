# Пекарна · Поръчки по маси

A small Windows Forms app (C#, .NET Framework 4.0, Visual Studio 2010). A waiter uses it to take orders per table and send them to the kitchen as a kitchen ticket.

## Features

- Hall plan with 8 tables shown as buttons. Each table is marked free, has an order, or selected.
- Menu split into categories: Предястия, Основни, Напитки, Десерти. Clicking a dish adds it to the order.
- Quantity `−` / `+` and removing a line.
- Kitchen modifiers per line (без лук, средно изпечено, …) and a special note.
- Items that are not on the menu.
- Sending to the kitchen shows the ticket on screen and can save it as a `.txt` file.
- Input validation with regular expressions (item names, waiter name, note), plus limits of 1–20 per line and at most 30 lines per order.

## Run on Windows (Visual Studio 2010)

1. Open `KitchenOrders/KitchenOrders.sln`.
2. Press **F5**.

The built program is at `KitchenOrders/KitchenOrders/bin/Debug/KitchenOrders.exe`.

## Run on Linux (Wine)

Requires the `dotnet` SDK and `wine`.

One-time download of the .NET 4.0 reference assemblies:

```bash
curl -L https://www.nuget.org/api/v2/package/Microsoft.NETFramework.ReferenceAssemblies.net40/1.0.3 -o /tmp/net40ref.zip
unzip -q /tmp/net40ref.zip -d ~/.net40ref
```

Build and start:

```bash
dotnet build KitchenOrders/KitchenOrders/KitchenOrders.csproj -p:FrameworkPathOverride=$HOME/.net40ref/build/.NETFramework/v4.0
wine explorer /desktop=kiosk,1280x800 KitchenOrders/KitchenOrders/bin/Debug/KitchenOrders.exe
```

Keep the `explorer /desktop=...` part. Without it, Wine may hide the ticket window and the main form looks frozen.
