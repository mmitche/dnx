// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Xml.Linq;

namespace NuGet
{
    public static class ManifestFileXmlExtensions
    {
        public static XElement ToXElement(this ManifestFile manifestFile, XNamespace ns)
        {
            var elem = new XElement(ns + "file");
            elem.SetAttributeValue(ns + "src", manifestFile.Source);
            elem.SetAttributeValue(ns + "target", manifestFile.Target);
            elem.SetAttributeValue(ns + "exclude", manifestFile.Exclude);

            return elem;
        }
    }
}
