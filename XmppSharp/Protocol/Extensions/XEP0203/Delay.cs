﻿using System.Globalization;
using XmppSharp.Attributes;
using XmppSharp.Dom;

namespace XmppSharp.Protocol.Extensions.XEP0203;

[XmppTag("delay", Namespaces.Delay)]
public class Delay : Element
{
    public Delay() : base("delay", Namespaces.Delay)
    {

    }

    public Delay(Jid? from, DateTimeOffset? stamp) : this()
    {
        From = from;
        Stamp = stamp;
    }

    public Jid? From
    {
        get => GetAttribute("from");
        set => SetAttribute("from", value);
    }

    public DateTimeOffset? Stamp
    {
        get
        {
            var value = GetAttribute("stamp");

            if (value == null)
                return null;

            if (DateTimeOffset.TryParseExact(value, Xml.XMPP_TIMESTAMP_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
                return result;

            return default;
        }
        set
        {
            if (!value.HasValue)
                RemoveAttribute("stamp");
            else
                SetAttribute("stamp", value.Value, Xml.XMPP_TIMESTAMP_FORMAT, CultureInfo.InvariantCulture);
        }
    }
}