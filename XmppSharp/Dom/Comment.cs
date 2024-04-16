﻿using System.Diagnostics;
using System.Xml;

namespace XmppSharp.Dom;

[DebuggerDisplay("{Value,nq}")]
public class Comment : Node
{
    public Comment(string value) => Value = value;
    public Comment(Comment other) => Value = other.Value;

    public override Node Clone()
       => new Comment(this);

    public override void WriteTo(XmlWriter writer)
        => writer.WriteComment(Value);
}
