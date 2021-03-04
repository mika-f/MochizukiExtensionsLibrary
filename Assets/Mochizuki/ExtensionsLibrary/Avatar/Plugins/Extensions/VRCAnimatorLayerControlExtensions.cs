﻿/*-------------------------------------------------------------------------------------------
 * Copyright (c) Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

using VRC.SDK3.Avatars.Components;

namespace Mochizuki.ExtensionsLibrary.Avatar.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class VRCAnimatorLayerControlExtensions
    {
        public static void CloneTo(this VRCAnimatorLayerControl source, VRCAnimatorLayerControl dest)
        {
            dest.layer = source.layer;
            dest.ApplySettings = source.ApplySettings;
            dest.blendDuration = source.blendDuration;
            dest.debugString = source.debugString;
            dest.goalWeight = source.goalWeight;
            dest.name = source.name;
            dest.playable = source.playable;
            dest.hideFlags = source.hideFlags;
        }
    }
}