// Copyright (c) 2011-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.
namespace SiliconStudio.Xenko.Rendering
{
    /// <summary>
    /// Context used by <see cref="PipelinePluginManager"/>.
    /// </summary>
    public struct PipelinePluginContext
    {
        public readonly RenderContext RenderContext;
        public readonly RenderSystem RenderSystem;

        public PipelinePluginContext(RenderContext renderContext, RenderSystem renderSystem)
        {
            RenderContext = renderContext;
            RenderSystem = renderSystem;
        }
    }
}
