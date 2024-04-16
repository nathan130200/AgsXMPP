﻿using XmppSharp.Attributes;

namespace XmppSharp.Protocol.DataForms;

[XmppTag("item", Namespace.DataForms)]
public class Item : Element
{
    public Item() : base("item", Namespace.DataForms)
    {

    }

    public Field? Field
    {
        get => Child<Field>();
        set
        {
            Field?.Remove();
            AddChild(value);
        }
    }
}
