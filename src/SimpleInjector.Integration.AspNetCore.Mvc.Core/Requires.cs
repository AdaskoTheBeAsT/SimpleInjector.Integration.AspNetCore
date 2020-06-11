﻿// Copyright (c) Simple Injector Contributors. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for license information.

namespace SimpleInjector
{
    using System;

    internal static class Requires
    {
        internal static void IsNotNull(object? instance, string paramName)
        {
            if (instance is null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}