# 🧠 Prácticas de Patrones de Diseño - C#

Este práctica contiene los 5 ejercicios que fueron vistos en clase sobre los siguientes patrones de diseño creacionales:
- 🧱 **Builder**
- 🧬 **Prototype**
- 🔒 **Singleton**
- 🏭 **Factory**
- 🏥 **Abstract Factory**
- 🧩 **Adapter**
- 🎨 **Decorator**
- 🌉 **Bridge**

El punto de entrada del programa se encuentra en `Program.cs`, y allí se ejecutan los tres ejemplos secuencialmente para demostrar su funcionamiento.

## 🏁 Ejecución del `Main`
Dentro del main tenemos un menu que se ayuda con un switch para que puedas ver las practicas ya implementadas.
```csharp
public static void Main(string[] args)
    {
        var mainMenu = new Menu();
        mainMenu.AddTitle("Practicas - Patrones de Diseño");
        mainMenu.AddOption("Practica Creacionales", new PracticaCreacionalesMenuCommand());
        mainMenu.AddOption("Practica Creacionales II", new PracticaCreacionalesV2MenuCommand());
        mainMenu.AddOption("Seleccion Creacionales", new SeleccionCreacionalesMenuCommand());
        mainMenu.AddOption("Practica Estructurales", new PracticaEstructuralesMenuCommand());
        mainMenu.Show();
    }
```

Estas opciones nos llevan a un submenú donde podemos elegir qué patrón de diseño queremos ver dentro de la práctica. Cada opción está implementada en su propia clase que maneja la lógica de cada patrón.

---
## Descripción de Prácticas
- **Practica Creacionales:** Esta práctica contiene ejemplos de los patrones de diseño creacionales:
  - `Builder`: Implementación del patrón Builder.
  - `Prototype`: Implementación del patrón Prototype.
  - `Singleton`: Implementación del patrón Singleton.
  

- **Practica Creacionales II:** Carpeta destinada a ejercicios prácticos de la segunda tarea donde se aplica cada patrón:
  - `Abstract Factory`: Ejercicio usando el patrón Abstract Factory.
  - `Factory`: Ejercicio usando el patrón Factory.


- **Practica Estructurales :** Carpeta destinada a ejercicios prácticos de la cuarta tarea donde se aplica cada patrón:
  - `Cargador`: Ejercicio usando el patrón Adapter.
  - `GestionFactura`: Ejercicio usando el patrón Decorator.
  - `SistemaPagos`: Ejercicio usando el patrón Bridge.
---
# 🧱 Selección de Patrones Creacionales

Esta práctica consistía en analizar distintos escenarios y decidir qué patrón de diseño creacional era el más adecuado para cada uno. Además, se debía justificar la elección y demostrar una implementación en C#.

## 1. 📄 Creación de Documentos

**Patrón utilizado:** `Factory`

Se utilizó el patrón Factory porque permite crear distintos tipos de documentos (PDF, Word, Excel) de forma ordenada y extensible (se pueden añadir más tipos de documentos). En lugar de tener que conocer cómo se construye cada uno, se delega esa responsabilidad a una fábrica, lo cual facilita la incorporación de nuevos tipos sin modificar el código existente.

## 2. 💻 Generación de Interfaz Gráfica

**Patrón utilizado:** `Abstract Factory`

Este patrón fue ideal porque permite generar conjuntos de componentes gráficos (como botones o ventanas) que son coherentes según el sistema operativo (Windows, MacOS, Linux). La clave de usar este patrón es que en el enunciado se nos dice "Familias" y con el Abstract Factory se garantiza que todos los elementos visuales se comporten y se vean todos de un mismo tipo/familia.

## 3. 🕹️ Configuración de Personajes en un Videojuego

**Patrón utilizado:** `Prototype`

El patrón Prototype fue el más adecuado porque permite clonar un personaje que ya fue personalizado, para reutilizarlo fácilmente como NPC (personaje no jugable). Esto facilita el tener que crear cada personaje desde cero y mejora el rendimiento del sistema al replicar objetos que ya existen.

## 4. 🚗 Creación de Autos Personalizados

**Patrón utilizado:** `Builder`

Se utilizó el patrón Builder porque permite construir un auto paso a paso, eligiendo el cilindraje del motor, carrocería y los accesorios justo como lo haría el patrón. Donde lo único que hacemos es definir las propiedades del auto sin necesidad de un constructor complejo y no mantenible.

## 5. 👤 Registro de Usuario Único

**Patrón utilizado:** `Singleton`

En este caso, se usó Singleton para asegurar que solo exista una instancia del registro de usuarios en todo el sistema. Y eso es en esencia el singleton, garantizar que una clase tenga una única instancia y proporcionar un metodo para acceder a esa instancia. 

---
 
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
