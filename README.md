# Proyecto Biblioteca Escolar

**Estudiante:** Valeria Berenice Alvarado Castillo
**Matrícula:** 24743549  
**Materia:** Estructura de Datos  

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
