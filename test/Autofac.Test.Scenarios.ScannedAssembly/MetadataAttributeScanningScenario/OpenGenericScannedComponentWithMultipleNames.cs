﻿// Copyright (c) Autofac Project. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Autofac.Test.Scenarios.ScannedAssembly.MetadataAttributeScanningScenario
{
    [Name("My Name")]
    [DuplicatedName("My Name 2")]
    public class OpenGenericScannedComponentWithMultipleNames<T>
    {
    }
}
