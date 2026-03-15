# 🧪 .NET Core Playground

Repositorio de mini proyectos de práctica progresiva con **.NET 8 Core**, organizados de menor a mayor complejidad.

Cada proyecto es independiente y enfocado en aprender conceptos específicos del ecosistema moderno de .NET: desde fundamentos del lenguaje hasta arquitectura limpia y producción real.

# Tener en cuenta:

| Tipo     | Cuándo usarlo                                      |
|----------|----------------------------------------------------|
| feat     | nuevo proyecto o funcionalidad                     |
| fix      | corrección de bug                                  |
| docs     | cambios solo en README u otros docs                |
| refactor | mejorar código sin cambiar comportamiento          |
| chore    | tareas de mantenimiento (actualizar deps, etc.)    |
| style    | formato, espacios, sin cambio lógico               |


---

## 🗂 Estructura
```
src/
├── 01-ConvertidorUnidades/     → Console App, top-level statements, LINQ básico
├── 02-InventarioMemoria/       → Colecciones, Dictionary, pattern matching
├── 03-LectorJsonCsv/           → System.Text.Json, File I/O, async/await
├── 04-TodoMinimalApi/          → ASP.NET Core Minimal APIs, Swagger, DI
├── 05-CrudEfCore/              → Entity Framework Core 8, SQLite, Migrations
├── 06-AuthJwt/                 → JWT Bearer, ASP.NET Core Identity, Roles
├── 07-RepositoryPattern/       → Repository, Unit of Work, AutoMapper
├── 08-BackgroundJobs/          → IHostedService, BackgroundService, Channels
├── 09-CleanArchitecture/       → Domain/App/Infra/Presentation, CQRS, MediatR
└── 10-EcommerceProduccion/     → Docker, Redis, Serilog, Health checks
```

---

## 🚀 Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- IDE recomendado: [Visual Studio 2022](https://visualstudio.microsoft.com/) / [Rider](https://www.jetbrains.com/rider/) / [VS Code](https://code.visualstudio.com/) + C# Dev Kit

---

## ▶️ Cómo correr un proyecto
```bash
dotnet run --project src/01-ConvertidorUnidades/ConvertidorUnidades.csproj
```

O abre `DotnetCorePlayground.sln` en tu IDE y selecciona el proyecto de inicio.

---

## 📚 Proyectos

### 01 · Convertidor de Unidades
> **Temas:** Top-level statements · `var` · Records · `switch` expressions · `string interpolation`

Console App que convierte entre unidades de longitud. Punto de entrada al C# moderno.

**Estado:** ✅ Completo

---

### 02 · Inventario en Memoria
> **Temas:** `List<T>` · `Dictionary<K,V>` · LINQ · Nullable types · Pattern matching

Sistema CRUD en memoria para gestionar productos. Sin base de datos aún.

**Estado:** 🔜 Próximamente

---

# Ejemplo de commits para el proyecto 02

## Crear el proyecto
dotnet new console -n InventarioMemoria -o src/02-InventarioMemoria
dotnet sln add src/02-InventarioMemoria/InventarioMemoria.csproj

## Commit de estructura vacía (buena práctica: estructura antes que código)
git add .
git commit -m "chore(02-inventario): agregar proyecto a la solución"

## Commit del trabajo terminado
git add src/02-InventarioMemoria/
git commit -m "feat(02-inventario): implementar CRUD con List<T> y LINQ"

## Actualizar README
git add README.md
git commit -m "docs: marcar proyecto 02 como completo en README"

git push origin main

---

## Resumen visual del flujo

github.com/new
     ↓
git clone
     ↓
dotnet new sln
     ↓
dotnet new console -o src/01-...
dotnet sln add ...
     ↓
git add . → git commit -m "chore: ..." → git push
     ↓
[desarrollar proyecto]
     ↓
git add . → git commit -m "feat(...): ..." → git push
     ↓
actualizar README → git commit -m "docs: ..." → git push

---

## 🧠 Autor

Proyecto de aprendizaje personal — [@JhonmaSG](https://github.com/JhonmaSG)