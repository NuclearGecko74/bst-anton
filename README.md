# Árbol Binario de Búsqueda en C#

Este proyecto es una aplicación de consola en C# que implementa un **Árbol Binario de Búsqueda**. La aplicación permite al usuario insertar, buscar, recorrer y eliminar nodos del árbol a través de un menú interactivo.

---

## Descripción

La aplicación implementa la estructura de datos de árbol binario de búsqueda mediante dos clases principales:

- **Node:** Representa un nodo del árbol, que contiene un valor entero y referencias a los nodos izquierdo y derecho.
- **BinarySearchTree:** Define la lógica para insertar nuevos valores, buscar elementos, realizar recorridos (PreOrden, InOrden, PostOrden) y eliminar nodos.

El programa principal (clase `Program`) presenta un menú en la consola donde el usuario puede seleccionar la acción deseada.

---

## Características

- **Inserción de Valores:** Permite insertar un entero en el árbol. Si el valor ya existe, la inserción es rechazada.
- **Búsqueda de Valores:** Verifica si un valor específico se encuentra en el árbol.
- **Recorridos del Árbol:**
  - **PreOrden:** Visita primero el nodo actual, luego el subárbol izquierdo y finalmente el derecho.
  - **InOrden:** Visita el subárbol izquierdo, luego el nodo actual y finalmente el derecho.
  - **PostOrden:** Visita primero los subárboles izquierdo y derecho, y al final el nodo actual.
- **Eliminación de Nodos:** Permite eliminar un nodo del árbol, manejando correctamente los casos en que el nodo tenga cero, uno o dos hijos.

---

## Uso

1. **Compilación:**
   - Abra el proyecto en su entorno de desarrollo preferido.
   - Compile el proyecto para generar el ejecutable.

2. **Ejecución:**
   - Ejecute el programa desde la consola.
   - Se desplegará un menú con las siguientes opciones:
     - **1. Insertar un valor:** Ingrese un número entero para insertarlo en el árbol.
     - **2. Buscar un valor:** Ingrese un número para verificar si existe en el árbol.
     - **3. Recorrido PreOrden:** Muestra el recorrido en preorden del árbol.
     - **4. Recorrido InOrden:** Muestra el recorrido en inorden del árbol.
     - **5. Recorrido PostOrden:** Muestra el recorrido en postorden del árbol.
     - **6. Eliminar un nodo:** Elimina el nodo que contenga el valor especificado.
     - **7. Salir:** Termina la ejecución del programa.

3. **Interacción:**
   - Seleccione la opción deseada escribiendo el número correspondiente y presionando **Enter**.
   - Siga las instrucciones que se muestran en la consola para ingresar los valores requeridos.
