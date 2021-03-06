﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Squidex.Domain.Apps.Entities.Rules.Repositories
{
    public interface IRuleRepository
    {
        Task<IReadOnlyList<Guid>> QueryRuleIdsAsync(Guid appId);
    }
}
