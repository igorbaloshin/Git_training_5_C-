using System;
using  static System.Console;

Clear();


void Towers(string with = "1", string on = "3", string some = "2", int count = 3)

{
    if(count > 1) Towers(with, some, on, count - 1);
    WriteLine($"{with} >> {on}");
    if(count > 1) Towers(some, on, with, count - 1);
}

Towers();
