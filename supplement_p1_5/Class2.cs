using System;
using System.Collections.Generic;

namespace Shapes;

public class Shape3D
{
    public string Name { get ; set;}

    public Shape3D(string name){
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}