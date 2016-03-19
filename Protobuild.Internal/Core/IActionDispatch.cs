﻿using System;

namespace Protobuild
{
    internal interface IActionDispatch
    {
        bool PerformAction(
            ModuleInfo module, 
            string action, 
            string platform = null, 
            string[] enabledServices = null, 
            string[] disabledServices = null, 
            string serviceSpecPath = null,
            bool debugServiceResolution = false,
            bool disablePackageResolution = false,
            bool disableHostPlatformGeneration = false,
            bool? taskParallelisation = null);

        bool DefaultAction(
            ModuleInfo module, 
            string platform = null, 
            string[] enabledServices = null, 
            string[] disabledServices = null, 
            string serviceSpecPath = null,
            bool debugServiceResolution = false,
            bool disablePackageResolution = false,
            bool disableHostPlatformGeneration = false,
            bool? taskParallelisation = null);
    }
}

