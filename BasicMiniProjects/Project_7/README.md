# To-Do persistente — CRUD desde terminal, pero guarda las tareas en JSON. Al cerrar y abrir el programa, los datos siguen ahí.

<img src="../../Assets/Dividers/descrete divider.png"> <br>

<img src="../../Assets/Titles/What am I learning.png"> <br>
<img src="../../Assets/Stickers/books.png" width="20"> No vamos a recaer en la memoria del programa. Vamos a generar un archivo para guardar lo que hemos estado haciendo.<br>

<img src="../../Assets/Titles/The idea.png"> <br>
<img src="../../Assets/Stickers/bea.png" width="20"> Primeramente, vamos a crear una clase `Task`. Esta clase task tendrá como atributos `id`, `nombreTarea` y `isCompleted`.<br>
<img src="../../Assets/Stickers/bea.png" width="20"> Luego, definierom el guardado de todas estas tasks en una lista.<br>
<img src="../../Assets/Stickers/bea.png" width="20"> Seguido, haremos un programa que pregunte por consola qué queremos hacer.<br>
<img src="../../Assets/Stickers/bea.png" width="20"> En caso de que queramos agregar una tarea, agregaremos un id que se incremente a sí mismo a esta tarea y un `isCompleted = False` por defecto. Agregaremos esta tarea a la lista de tareas que creamos al inicio.<br>
<img src="../../Assets/Stickers/bea.png" width="20"> De esta lista de tareas actualizada, se creará/actualizará un json.<br>
<img src="../../Assets/Stickers/bea.png" width="20"> En caso de querer visualizar las tareas, cargaremos el json<br>

<img src="../../Assets/Titles/Things I learned.png"><br>
<img src="../../Assets/Stickers/bubble tea.png" width="20"> ¿Por qué en TaskItem, nombreTarea debe ser required? `Non-nullable field 'nombreTarea' must contain a non-null value when exiting constructor`<br>

<img src="../../Assets/Stickers/bubble tea.png" width="20"> ¿Cómo arreglo en `Program.cs` `Converting null literal or possible null value to non-nullable type.` por `string decision = Console.ReadLine();`?<br>
