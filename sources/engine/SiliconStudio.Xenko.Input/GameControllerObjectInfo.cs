// Copyright (c) 2016-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.

namespace SiliconStudio.Xenko.Input
{
    /// <summary>
    /// Provides information about an object exposed by a gamepad
    /// </summary>
    public class GameControllerObjectInfo
    {
        /// <summary>
        /// The name of the object, reported by the device
        /// </summary>
        public string Name;

        public override string ToString()
        {
            return $"GameController Object {{{Name}}}";
        }
    }
}