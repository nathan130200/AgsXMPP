﻿using XmppSharp.Attributes;
using XmppSharp.Dom;

namespace XmppSharp.Protocol.Sasl;

[XmppTag("challenge", Namespaces.Sasl)]
public sealed class Challenge : Element
{
    public Challenge() : base("challenge", Namespaces.Sasl)
    {

    }
}
