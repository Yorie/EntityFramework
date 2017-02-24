﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators;
using Microsoft.EntityFrameworkCore.Relational.Tests.TestUtilities;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Relational.Tests.Query
{
    public class RelationalCompositeExpressionFragmentTranslatorDependenciesTest
    {
        [Fact]
        public void Can_use_With_methods_to_clone_and_replace_service()
        {
            RelationalTestHelpers.Instance.TestDependenciesClone<RelationalCompositeExpressionFragmentTranslatorDependencies>();
        }
    }
}
