using Project_7.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        List<TaskItem> taskItems;

        if (File.Exists("To-do.json"))
        {
            string jsonTexto = File.ReadAllText("To-do.json");

            taskItems =
                JsonSerializer.Deserialize<List<TaskItem>>(jsonTexto)
                ?? new List<TaskItem>();
        }
        else
        {
            taskItems = new List<TaskItem>();
        }

        int id = taskItems.Count + 1;

        while (true)
        {
            Console.WriteLine(
                "\n¿Qué requieres hacer?" +
                "\n1. Ver lista de tareas" +
                "\n2. Crear nueva tarea" +
                "\n3. Salir"
            );

            int decision = Convert.ToInt32(Console.ReadLine());

            if (decision == 2)
            {
                TaskItem task = Tarea(id);

                taskItems.Add(task);

                id++;
            }
            else if (decision == 1)
            {
                int tarea = 1;

                foreach (var task in taskItems)
                {
                    Console.WriteLine(
                        $"{tarea}.- {task.nombreTarea}; {task.isCompleted}"
                    );

                    tarea++;
                }
            }
            else if (decision == 3)
            {
                var opciones = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonString =
                    JsonSerializer.Serialize(taskItems, opciones);

                File.WriteAllText("To-do.json", jsonString);

                Console.WriteLine("Tareas guardadas.");

                break;
            }
        }
    }

    static TaskItem Tarea(int id)
    {
        Console.Write("Ingresa el nombre de la tarea: ");

        string nombreTarea = Console.ReadLine() ?? "";

        TaskItem task =
            new TaskItem(id, nombreTarea, false);

        return task;
    }
}