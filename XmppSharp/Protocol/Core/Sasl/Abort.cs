﻿using XmppSharp.Attributes;
using XmppSharp.Dom;

namespace XmppSharp.Protocol.Core.Sasl;

[XmppTag("abort", Namespaces.Sasl)]
public class Abort : Element
{
    public Abort() : base("abort", Namespaces.Sasl)
    {

    }
}