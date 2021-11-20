﻿using System.Collections.Generic;

namespace Reclaimer.Shinobi.Generators.FunctionGenerator
{
    internal class Struct
    {
        public string Namespace;
        public string Name;
        public List<Function> MemberFunctions;
        public List<Function> VirtualFunctions;
        public bool HasCtor;
    }

    internal class Function
    {
        public string Name;
        public bool HasReturn;
        public bool HasBoolReturn;
        public string ReturnType;
        public bool HasParams;
        public string ParamList;
        public string ParamTypeList;
        public string ParamNameList;
        public string Signature;
        public int VirtualOffset;
        public bool IsStatic;
    }
}
