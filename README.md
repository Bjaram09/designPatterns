# 🧠 Práctica Creacionales - C#

Este práctica contiene los 5 ejercicios que fueron vistos en clase sobre los siguientes patrones de diseño creacionales:
- 🧱 **Builder**
- 🧬 **Prototype**
- 🔒 **Singleton**
- 🏭 **Factory**
- 🏥 **Abstract Factory**

El punto de entrada del programa se encuentra en `Program.cs`, y allí se ejecutan los tres ejemplos secuencialmente para demostrar su funcionamiento.

## 🏁 Ejecución del `Main`
Dentro del main tenemos un menu que se ayuda con un switch para que puedas ver los ejercicios ya implementados.
```csharp
static void Main(string[] args)
    {
        ...
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("----- SINGLETON -----");
                    EjecutarEjercicioSingleton();
                    break;
                case 2:
                    Console.WriteLine("----- PROTOTYPE -----");
                    EjecutarEjercicioPrototype();
                    break;
                case 3:
                    Console.WriteLine("----- BUILDER -----");
                    EjecutarEjercicioBuilder();
                    break;
                case 4:
                    Console.WriteLine("----- FACTORY -----");
                    EjecutarEjercicioFactory();
                    break;
                case 5:
                    Console.WriteLine("----- ABSTRACT FACTORY -----");
                    EjecutarEjercicioAbstractFactory();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
        ...
    }
```

El codigo que se uso para implementar cáda metodo está dentro de su respectivo folder dentro de PracticaCreacionales.
La practica 2 esta dentro de PracticaCraecionales_v2

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
├── PracticaCreacionales_v2
│ ├── EjercicioAbstractFactory
│ └── EjercicioFactory
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

- **PracticaCreacionales_v2/**  
  Carpeta destinada a ejercicios prácticos de la segunda tarea donde se aplica cada patrón:
  - `EjercicioAbstractFactory`: Ejercicio usando el patrón Abstract Factory.
  - `EjercicioFactory`: Ejercicio usando el patrón Factory.
 
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
