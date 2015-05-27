// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using NuGet;
using Xunit;

namespace Microsoft.Framework.Runtime.Tests.NuGet.Authoring
{
    public class ManifestMetadataTests
    {
        public void AuthorsIsEmptyByDefault()
        {
            var metadata = new ManifestMetadata();

            Assert.Empty(metadata.Authors);
        }

        public void OWnersIsEmptyByDefault()
        {
            var metadata = new ManifestMetadata();

            Assert.Empty(metadata.Owners);
        }

        public void OwnersFallbackToAuthors()
        {
            var metadata = new ManifestMetadata();
            metadata.Authors = new string[] { "A", "B" };

            Assert.Equal(new string[] { "A", "B" }, metadata.Owners);
        }
    }
}
