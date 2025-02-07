﻿using XmppSharp.Attributes;
using XmppSharp.Dom;

namespace XmppSharp.Protocol.Extensions.XEP0045;

[XmppTag("item", Namespaces.MucUser)]
[XmppTag("item", Namespaces.MucAdmin)]
public class Item : XmppElement
{
    public Item() : base("item")
    {

    }

    public Affiliation? Affiliation
    {
        get => XmppEnum.FromXml<Affiliation>(GetAttribute("affiliation"));
        set
        {
            if (!value.HasValue)
                RemoveAttribute("affiliation");
            else
                SetAttribute("affiliation", XmppEnum.ToXml(value));
        }
    }

    public Jid? Jid
    {
        get => GetAttribute("jid");
        set => SetAttribute("jid", value);
    }

    public string? Nickname
    {
        get => GetAttribute("nickname");
        set => SetAttribute("nickname", value);
    }

    public Role? Role
    {
        get => XmppEnum.FromXml<Role>(GetAttribute("role"));
        set
        {
            if (!value.HasValue)
                RemoveAttribute("role");
            else
                SetAttribute("role", XmppEnum.ToXml(value));
        }
    }

    public Actor? Actor
    {
        get => Element<Actor>();
        set
        {
            Element<Actor>()?.Remove();
            AddChild(value);
        }
    }

    public string? Reason
    {
        get => Value;
        set => Value = value;
    }

    public bool Continue
    {
        get => HasTag("continue");
        set
        {
            if (!value)
                RemoveTag("continue");
            else
                SetTag("continue");
        }
    }
}
