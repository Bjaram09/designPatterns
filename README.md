# 🧠 Práctica Creacionales - C#

Este práctica contiene los 3 ejercicios que fueron vistos en clase sobre los siguientes patrones de diseño creacionales:
- 🧱 **Builder**
- 🧬 **Prototype**
- 🔒 **Singleton**

El punto de entrada del programa se encuentra en `Program.cs`, y allí se ejecutan los tres ejemplos secuencialmente para demostrar su funcionamiento.

## :checkered_flag: Ejecución del `Main`

```csharp
static void Main(string[] args)
    {
        //Ejercicio Singleton
        Console.WriteLine("-----SINGLETON-----");
        EjecutarEjercicioSingleton();
        
        //Ejercicio Prototype
        Console.WriteLine("-----PROTOTYPE-----");
        EjecutarEjercicioPrototype();
        
        //Ejercicio Builder
        Console.WriteLine("-----BUILDER-----");
        EjecutarEjercicioBuilder();
        
    }
```

El codigo que se uso para implementar cáda metodo está dentro de su respectivo folder dentro de PracticaCreacionales

## :file_folder: Estructura del Proyecto

```text
EjemplosPatrones
├── Dependencias
├── Creacionales
│ ├── BuilderPattern
│ ├── PrototypePattern
│ └── SingletonPattern
├── PracticaCreacionales
│ ├── EjercicioBuilder
│ ├── EjercicioPrototype
│ └── EjercicioSingleton
└── Program.cs
```

## Descripción de Carpetas

- **Creacionales/**  
  Contiene los ejercicios vistos en clase de los patrones creacionales:
  - `BuilderPattern`: Ejemplo del patrón Builder.
  - `PrototypePattern`: Ejemplo del patrón Prototype.
  - `SingletonPattern`: Ejemplo del patrón Singleton.

- **PracticaCreacionales/**  
  Carpeta destinada a ejercicios prácticos donde se aplica cada patrón:
  - `EjercicioBuilder`: Ejercicio usando el patrón Builder.
  - `EjercicioPrototype`: Ejercicio usando el patrón Prototype.
  - `EjercicioSingleton`: Ejercicio usando el patrón Singleton.
 
## :ballot_box_with_check: Requisitos

- [.NET 6.0 SDK o superior](https://dotnet.microsoft.com/)
- Un editor como [Visual Studio Code](https://code.visualstudio.com/) o [Rider](https://www.jetbrains.com/rider/)

## :rocket: Ejecución

Desde la terminal, en el directorio raíz del proyecto:

```bash
dotnet run
```

Puedes modificar `Program.cs` para ejecutar el ejemplo o ejercicio que desees probar.

---

## :information_source: Información del Proyecto

Este proyecto fue desarrollado como parte del curso **BISOFT-12: Programación con Patrones**, impartido por UCENFOTEC.

**Autor:** Bryan Jara Miranda  
**Correo:** bjaram@ucenfotec.ac.cr
