﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceleratio.SPDG.Generator.Objects
{
    public abstract class SPDGRoleAssignment
    {
        public SPDGPrincipal Member { get; private set; }
        public IEnumerable<SPDGRoleDefinition> RoleDefinitionBindings { get; private set; }
        public SPDGRoleAssignment(SPDGPrincipal principal, IEnumerable<SPDGRoleDefinition> roleDefinitionBindings)
        {
            Member = principal;
            RoleDefinitionBindings = roleDefinitionBindings;
        }

        public abstract void Update();
    }
}