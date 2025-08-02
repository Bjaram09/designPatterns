# 🧠 Prácticas de Patrones de Diseño - C#

Este práctica contiene los ejercicios que fueron vistos en clase sobre los siguientes patrones de diseño creacionales:
- 🧱 **Builder**
- 🧬 **Prototype**
- 🔒 **Singleton**
- 🏭 **Factory**
- 🏥 **Abstract Factory**
- 🧩 **Adapter**
- 🎨 **Decorator**
- 🌉 **Bridge**
- 📦 **Facade**
- 🔄 **Flyweight**
- 🔗 **Proxy**

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
        mainMenu.AddOption("Practica Estructurales", new PracticaEstructuralesMenuCommand());
        mainMenu.AddOption("Practica Estructurales II", new PracticaEstructuralesV2MenuCommand());
        mainMenu.AddOption("Seleccion Creacionales", new SeleccionCreacionalesMenuCommand());
        mainMenu.AddOption("Seleccion Comportamiento", new SeleccionComportamientoCommand());
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


- **Practica Estructurales:** Carpeta destinada a ejercicios prácticos de la cuarta tarea donde se aplica cada patrón:
  - `Cargador`: Ejercicio usando el patrón Adapter.
  - `Gestion de Facturas`: Ejercicio usando el patrón Decorator.
  - `Sistema de Pagos`: Ejercicio usando el patrón Bridge.

- **Practica Estructurales II:** Carpeta destinada a ejercicios prácticos de la quinta tarea donde se aplica cada patrón:
  - `Ejército de soldados`: Ejercicio usando el patrón Flyweight.
  - `Cine en casa`: Ejercicio usando el patrón Facade.
  - `Registro de acceso a base de datos`: Ejercicio usando el patrón Proxy.
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
# 🔁 Selección de Patrones de Comportamiento

Esta práctica consistía en analizar distintos escenarios y decidir qué patrón de diseño de comportamiento era el más adecuado para cada uno. Además, se debía justificar la elección y demostrar una implementación en C#.

## 1. 🔗 Procesamiento de solicitudes

**Patrón utilizado:** `Chain of Responsibility`

Se utilizó el patrón Chain of Responsibility porque permite que múltiples objetos manejen una solicitud sin necesidad de conocer cuál es el objeto que finalmente la procesará. Esto es útil en sistemas donde las solicitudes pueden ser manejadas por diferentes módulos (como facturación, inventario, etc.) y se quiere evitar un acoplamiento fuerte entre ellos.

## 2. ✍️ Edición de Texto

**Patrón utilizado:** `Command`

Se utilizó el patrón Command porque permite encapsular acciones (en comandos) en objetos que pueden ser ejecutados, deshechos o re-hechos. Esto es útil para implementar funcionalidades de edición de texto donde se necesita mantener un historial de acciones y permitir deshacer/rehacer cambios de manera eficiente.

## 3. 🛒️ Recorrer productos

**Patrón utilizado:** `Iterator`

Se utilizó el patrón Iterator porque permite recorrer colecciones de productos sin exponer su estructura interna. Esto es útil para implementar catálogos de productos donde se quiere iterar sobre los elementos (como productos, categorías, etc.) sin depender de la implementación interna de la colección.

## 4. 💬 Sistema de Chat

**Patrón utilizado:** `Mediator`

Se utilizó el patrón Mediator porque permite que los componentes del sistema de chat (usuarios, mensajes) se comuniquen entre sí sin necesidad de referencias directas. Esto reduce el acoplamiento entre componentes y facilita la adición de nuevos participantes o funcionalidades al sistema.

## 5. 🎮 Guardado y Restauración de Progreso en un Juego

**Patrón utilizado:** `Memento`

Se utilizó el patrón Memento porque permite guardar el estado interno de un objeto (en este caso, el progreso del jugador) sin violar su encapsulamiento. Esto es útil cuando se quiere implementar funciones como "Guardar partida" y "Cargar partida", ya que encapsula todo el estado necesario en un objeto separado, manteniendo limpia la lógica del juego.

## 6. 📦 Notificación de Cambios de Stock

**Patrón utilizado:** `Observer`

Observer fue el más adecuado porque permite que varios módulos (facturación, estadísticas, alertas) se suscriban al sistema de inventario y reaccionen automáticamente cuando hay un cambio. Esto evita tener un acoplamiento fuerte entre clases y permite que el sistema sea más dinámico y extensible.

## 7. 📦📬 Estados de un Pedido

**Patrón utilizado:** `State`

El patrón State fue útil porque cada estado del pedido (Pendiente, Enviado, Entregado, Cancelado) tiene reglas de transición diferentes. En lugar de llenar la clase con condicionales, cada estado encapsula su propio comportamiento, haciendo que el objeto cambie su lógica interna según el estado en el que se encuentre.

## 8. 💳 Selección de Método de Pago

**Patrón utilizado:** `Strategy`

Se eligió el patrón Strategy porque permite definir múltiples formas de pago (tarjeta, PayPal, criptomonedas) de forma intercambiable. Cada estrategia de pago está encapsulada y se puede seleccionar en tiempo de ejecución, permitiendo que el sistema sea abierto a nuevas estrategias sin modificar el código existente.

## 9. 🧾 Generación de Informes con Pasos Comunes

**Patrón utilizado:** `Template Method`

Template Method fue ideal para definir una plantilla general de generación de informes (por ejemplo: abrir archivo → preparar datos → escribir contenido → exportar), pero permitiendo que cada tipo de informe redefina algunos pasos concretos. Esto promueve la reutilización de lógica común y mantiene una estructura clara.

## 10. 📊 Análisis de Archivos con Múltiples Operaciones

**Patrón utilizado:** `Visitor`

El patrón Visitor fue el más adecuado porque permite aplicar distintas operaciones (como contar palabras, verificar ortografía, extraer palabras clave) a diferentes tipos de documentos (`Texto`, `PDF`) **sin modificar sus clases**. Esto facilita la extensión de nuevas operaciones sin alterar la jerarquía de clases existente, promoviendo el principio de abierto/cerrado.

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
