using System;
using System.ComponentModel;
using SiliconStudio.Core;

namespace SiliconStudio.Xenko.Rendering.Composers
{
    public interface ISceneRenderer : IRenderCollector, IGraphicsRenderer
    {
    }

    public interface ISharedRenderer : IIdentifiable
    {
        string Name { get; }
    }

    /// <summary>
    /// Describes the code part of a <see cref="GraphicsCompositor"/>.
    /// </summary>
    [DataContract(Inherited = true)]
    public abstract class SceneRendererBase : RendererBase, ISceneRenderer
    {
        /// <inheritdoc/>
        [DataMember(-100), Display(Browsable = false)]
        public Guid Id { get; set; }

        public override string Name => GetType().Name;

        protected SceneRendererBase()
        {
            Id = Guid.NewGuid();
        }

        /// <inheritdoc/>
        public virtual void Collect(RenderContext renderContext)
        {
        }
    }
}