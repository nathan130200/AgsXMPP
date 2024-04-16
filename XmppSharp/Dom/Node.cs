﻿using System.Xml;

namespace XmppSharp.Dom;

public abstract class Node : ICloneable
{
    internal Element _parent;

    public Element Parent
    {
        get => _parent;
        set
        {
            _parent?.RemoveChild(this);
            (_parent = value)?.AddChild(this);
        }
    }

    public virtual void Remove()
    {
        _parent?.RemoveChild(this);
        _parent = null;
    }

    public virtual string Value
    {
        get;
        set;
    }

    public abstract void WriteTo(XmlWriter writer);
    public abstract Node Clone();

    object ICloneable.Clone() => Clone();
}
