﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface ICello
    {
        string Register { get; set; }
        
        void Desc();
        void History();
        void Show();
        void Sound();
    }
}
