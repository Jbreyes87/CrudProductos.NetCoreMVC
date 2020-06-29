﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Emsoir.Dominio.Entity
{
   public class Response<T>
    {
        public T Data { get; set; }
        public string Mensaje { get; set; }

        public bool IsSuccess { get; set; }
    }
}
