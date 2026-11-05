# Proyecto Biblioteca Escolar

**Estudiante:** Valeria Berenice Alvarado Castillo
**Matrícula:** 24743549  
**Materia:** Estructura de Datos  
* **Lenguaje:** C# (.NET Framework)
* **Entorno de Desarrollo:** Visual Studio

## Avance Día 1: Documento de Diseño Preliminar

Para este proyecto se requería seleccionar la manera ideal de almacenar titulos bibliográficos que tienen una cantidad
variable de ejemplares físicos, evitando dejar espacios vacíos en la memoria. Se evaluaron tres alternativas:

1. **Arreglo Escalonado (`int[][]`):**
   - *Ventajas:* Asigna únicamente la memoria necesaria según las copias de cada libro.
   - *Desventajas:* Dificulta la manipulación al ordenar por préstamos y relacionar otros datos del libro.

2. **Lista de Arreglos (`List<int[]>`):**
   - *Ventajas:* Permite agregar más libros de una forma dinamica.
   - *Desventajas:* Separa la información de las copias respecto a los datos principales del libro (Como el titulo o el ISBN)

3. **Lista de Objetos (`List<Titulo>`):**
   - *Ventajas:* Organiza en un solo registro el ISBN, nombre, préstamos y arreglo de ejemplares sin dejar celdas vacías.
   - *Desventajas:* Requiere definir una clase previa.

**Decisión final:** Ópte por la estructura de lista de objetos ya que me permite representar cada libro de forma completa e 
interactiva. Asi no tengo que traer datos dispersos en varias listas separadas, sino que en una sola estructura controlo 
el nombre, ISBN, copias disponibles y préstamos de cada libro.


## Funcionalidades Implementadas en los dias (2,3,4,5,6,7)

1. **Catálogo de la Biblioteca:** Permite ver los datos de los 8 nombres de los libros que hay con informacion de sus 
copias disponibles.
2. **Búsqueda Rápida:** Muestra cualquier libro añadiendo palabras clave(como letras) o el código ISBN(números).
3. **Préstamos y Devoluciones:** Permite registrar los prestamos y cuando se hace su debida devolución, asi mismo
va actualizando con un contador el número de veces que fue tomado cada libro.
4. **Datos y estadisticas:** Permite saber los libros con menos y mas moda en prestamos, el total de prestamos
acomulado y el promedio de prestamos por libro.
5. **Ordenamiento de Datos:**
   * Orden alfabético por Título (A-Z).
   * Orden por popularidad de Préstamos (de mayor a menor).
6. **Nueva forma Dinámica:** Permite añadir nuevos libros ingresando titulo,codigo ISBN y la cantidad de copias de este.


## Instrucciones para Ejecutar 

1. Debes de descargar este repositorio.
2. Abrir el archivo de solución `ValeriaAlvarado_ProyBiblioEsc.sln` en Visual Studio.
3. Selecciona la tecla `F5` o dar clic en **Iniciar** para ejecutar la aplicación de consola.
4. Interactuar con el programa según las opciones que se muestran en el menú principal.