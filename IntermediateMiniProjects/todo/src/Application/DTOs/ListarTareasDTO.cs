using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.src.Application.DTOs
{
    public class ListarTareasDTO
    {
        public int id {get; set;}
        public string name {get; set;}
        public bool isCompleted {get;set;}
    }
}