// Copyright (c) 2011-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.
using SiliconStudio.Core;
using SiliconStudio.Xenko.Graphics;

namespace SiliconStudio.Xenko.Shaders.Compiler
{
    [DataContract]
    public struct EffectCompilerParameters
    {
        public static readonly EffectCompilerParameters Default = new EffectCompilerParameters
        {
            Platform = GraphicsPlatform.Direct3D11,
            Profile = GraphicsProfile.Level_11_0,
            Debug = true,
            OptimizationLevel = 0,
        };

        public void ApplyCompilationMode(CompilationMode compilationMode)
        {
            switch (compilationMode)
            {
                case CompilationMode.Debug:
                case CompilationMode.Testing:
                    Debug = true;
                    OptimizationLevel = 0;
                    break;
                case CompilationMode.Release:
                    Debug = true;
                    OptimizationLevel = 1;
                    break;
                case CompilationMode.AppStore:
                    Debug = false;
                    OptimizationLevel = 2;
                    break;
            }
        }

        public GraphicsPlatform Platform { get; set; }

        public GraphicsProfile Profile { get; set; }

        public bool Debug { get; set; }

        public int OptimizationLevel { get; set; }

        /// <summary>
        /// Gets or sets the priority (in case this compile is scheduled in a custom async pool)
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        [DataMemberIgnore]
        public int TaskPriority { get; set; }
    }
}
