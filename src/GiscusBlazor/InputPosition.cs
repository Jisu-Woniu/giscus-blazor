﻿using System;

namespace GiscusBlazor
{
    public enum InputPosition
    {
        Bottom,
        Top
    }

    internal static class InputPositionExtensions
    {
        internal static string ToPositionString(this InputPosition position) =>
            position switch
            {
                InputPosition.Bottom => "bottom",
                InputPosition.Top => "top",
                _ => throw new ArgumentOutOfRangeException(nameof(position))
            };
    }
}
