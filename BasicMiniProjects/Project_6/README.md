# CLI con argumentos reales — Crea una herramienta ejecutable como app --input archivo.txt --verbose. Aprende argumentos, flags y códigos de salida.

<img src="../../Assets/Dividers/descrete divider.png" alt="Pink divider with ribbon and hearts" style="display:block; margin:auto;">

<img src="../../Assets/Titles/What am I learning.png" alt="Pink divider with ribbon and hearts" style="display:block;">

<img src="../../Assets/Stickers/sleeping cat.png" width="30"> Argumentos de comando.<br>
<img src="../../Assets/Stickers/sleeping cat.png" width="30"> Ejecutables. <br>
<img src="../../Assets/Stickers/sleeping cat.png" width="30"> Flags.<br>


<img src="../../Assets/Titles/The idea.png" ><br>
La idea es hacer un pequeño software, no muy complejo, para practicar lo que significan las flags y cómo hacer un ejecutable.

<img src="../../Assets/Titles/Things I learned.png">

<img src="../../Assets/Stickers/books.png" width="30">¿Qué es un flag?<br>
Los flags son opciones que le pasamos al programa desde terminal para decirle cómo queremos que se comporte.

Por ejemplo: `app --input archivo.txt --verbose`, `--verbose` es un flag así como `--input archivo.txt`.

Existen muchos tipos de flags.

| Tipo                 | Ejemplo               | Qué hace                            | Ejemplo práctico           |
| -------------------- | --------------------- | ----------------------------------- | -------------------------- |
| **Booleano**         | `--verbose`           | Activa o desactiva una función      | Mostrar más información    |
| **Con valor**        | `--input archivo.txt` | Recibe un dato después de la opción | Elegir un archivo          |
| **Numérico**         | `--count 5`           | Recibe un número                    | Repetir una acción 5 veces |
| **Selección / modo** | `--mode fast`         | Elige entre varias opciones         | `fast`, `normal`, `slow`   |
| **Versión corta**    | `-v`                  | Abreviación de un flag largo        | `-v` en vez de `--verbose` |

Por ejemplo: `app --input archivo.txt --count 4 --mode fast --verbose`, se podría leer como: 
> Ejecuta app, usa archivo.txt, procesalo 3 veces, usa el modo rápido y muéstrame información detallada.

<img src="../../Assets/Stickers/books.png" width="30">¿Qué significa `verbose`?<br>

Verbose significa "detallado" o "prolijo". Muestra más infomación sobre lo que está haciendo el programa mientras se ejecuta.

> Cuéntame qué estás haciendo.

Especialmente útil para debugging, porque permite ver en qué etapa está el programa o dónde podría estar fallando.

<img src="../../Assets/Titles/Things that broke.png"><br>
<img src="../../Assets/Stickers/paw.png" width="30"> Al momento de hacer `dotnet run` es importante poner el argumento. Ejemplo: `dotnet run -- --input archivo.txt --count 3 --verbose`.<br>

<img src="../../Assets/Titles/Things I learned.png"><br>
Aprendí los distintos tipos de flags y cómo correr un ejecutable.