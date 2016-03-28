﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode.Metadata.ManagedReference
{
    using System;
    using System.Collections.Generic;

    using Microsoft.DocAsCode.DataContracts.Common;
    using YamlDotNet.Serialization;

    [Serializable]
    public class ConfigFilterRule
    {
        [YamlMember(Alias = Constants.PropertyName.ApiFilterRule)]
        public List<ConfigFilterRuleItemUnion> ApiRules { get; set; } = new List<ConfigFilterRuleItemUnion>();
    }
}