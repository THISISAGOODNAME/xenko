// Copyright (c) 2014-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.

using SiliconStudio.Core;
using SiliconStudio.Xenko.Shaders;

namespace SiliconStudio.Xenko.Rendering.Materials
{
    /// <summary>
    /// Fresnel using Schlick approximation.
    /// </summary>
    [DataContract("MaterialSpecularMicrofacetFresnelSchlick")]
    [Display("Schlick")]
    public class MaterialSpecularMicrofacetFresnelSchlick : IMaterialSpecularMicrofacetFresnelFunction
    {
        public ShaderSource Generate(MaterialGeneratorContext context)
        {
            return new ShaderClassSource("MaterialSpecularMicrofacetFresnelSchlick");
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is MaterialSpecularMicrofacetFresnelSchlick;
        }

        public override int GetHashCode()
        {
            return typeof(MaterialSpecularMicrofacetFresnelSchlick).GetHashCode();
        }
    }
}
