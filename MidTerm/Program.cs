﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;          

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.DairyRead();
            Inventory.BeveragesRead();
            Inventory.ProduceRead();
            Inventory.MeatsRead();
            Inventory.SnacksRead();

            Inventory.AddItem();
            WorkHorse.MainWork();
        }
    }
}
