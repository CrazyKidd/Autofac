﻿// Copyright (c) Autofac Project. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autofac.Test.Scenarios.ScannedAssembly
{
    public class UndoRedoCommand : ICommand<UndoCommandData>, ICommand<RedoCommandData>
    {
        public void Execute(UndoCommandData data)
        {
        }

        public void Execute(RedoCommandData data)
        {
        }
    }
}
