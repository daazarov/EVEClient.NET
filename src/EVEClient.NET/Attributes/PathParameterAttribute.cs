﻿using System;

namespace EVEClient.NET.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class PathParameterAttribute : UrlParameterAttribute
    {
        public PathParameterAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}
