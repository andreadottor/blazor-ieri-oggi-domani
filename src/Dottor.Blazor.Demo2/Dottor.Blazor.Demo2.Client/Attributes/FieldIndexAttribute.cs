﻿namespace Dottor.Blazor.Demo2.Client.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class FieldIndexAttribute : Attribute
{
    public FieldIndexAttribute(int index)
    {
        Index = index;
    }

    public int Index { get; private set; }
}
