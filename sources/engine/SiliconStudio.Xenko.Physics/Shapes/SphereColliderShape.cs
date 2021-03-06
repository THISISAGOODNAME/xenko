// Copyright (c) 2014-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.

using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Extensions;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Graphics.GeometricPrimitives;
using SiliconStudio.Xenko.Rendering;

namespace SiliconStudio.Xenko.Physics
{
    public class SphereColliderShape : ColliderShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SphereColliderShape"/> class.
        /// </summary>
        /// <param name="is2D">if set to <c>true</c> [is2 d].</param>
        /// <param name="radius">The radius.</param>
        public SphereColliderShape(bool is2D, float radius)
        {
            Type = ColliderShapeTypes.Sphere;
            Is2D = is2D;

            CachedScaling = Is2D ? new Vector3(1, 1, 0) : Vector3.One;

            var shape = new BulletSharp.SphereShape(radius)
            {
                LocalScaling = CachedScaling
            };

            if (Is2D)
            {
                InternalShape = new BulletSharp.Convex2DShape(shape) { LocalScaling = CachedScaling };
            }
            else
            {
                InternalShape = shape;
            }

            DebugPrimitiveMatrix = Matrix.Scaling(2 * radius * DebugScaling);
            if (Is2D)
            {
                DebugPrimitiveMatrix.M33 = 0f;
            }
        }

        public override MeshDraw CreateDebugPrimitive(GraphicsDevice device)
        {
            return GeometricPrimitive.Sphere.New(device).ToMeshDraw();
        }
    }
}
