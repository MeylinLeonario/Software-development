using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.src.Domain.Enums;

namespace backend.api.src.application.dtos
{
    public class CreateTaskItemDTO
    {
        public string title {get;set;}
        public string description {get;set;}
        public DateOnly deadline {get;set;}
        public Priority priority {get;set;}

        public CreateTaskItemDTO(){}
    }

}