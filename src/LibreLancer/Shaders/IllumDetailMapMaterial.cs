﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibreLancer.Shaders
{
    using System;
    
    public class IllumDetailMapMaterial
    {
        static ShaderVariables[] variants;
        private static bool iscompiled = false;
        private static int GetIndex(ShaderFeatures features)
        {
            ShaderFeatures masked = (features & ((ShaderFeatures)(128)));
            if ((masked == ((ShaderFeatures)(128))))
            {
                return 1;
            }
            return 0;
        }
        public static ShaderVariables Get(LibreLancer.Graphics.RenderContext device, ShaderFeatures features)
        {
            AllShaders.Compile(device);
            return variants[GetIndex(features)];
        }
        public static ShaderVariables Get(LibreLancer.Graphics.RenderContext device)
        {
            AllShaders.Compile(device);
            return variants[0];
        }
        internal static void Compile(LibreLancer.Graphics.RenderContext device, string sourceBundle)
        {
            if (iscompiled)
            {
                return;
            }
            iscompiled = true;
            ShaderVariables.Log("Compiling IllumDetailMapMaterial");
            variants = new ShaderVariables[2];
            if (device.HasFeature(LibreLancer.Graphics.GraphicsFeature.Features430))
            {
                variants[0] = ShaderVariables.Compile(device, sourceBundle.Substring(421741, 1545), sourceBundle.Substring(466341, 7342));
                variants[1] = ShaderVariables.Compile(device, sourceBundle.Substring(436962, 4472), sourceBundle.Substring(476628, 3286));
            }
            else
            {
                variants[0] = ShaderVariables.Compile(device, sourceBundle.Substring(416171, 1204), sourceBundle.Substring(461604, 4737));
                variants[1] = ShaderVariables.Compile(device, sourceBundle.Substring(430257, 4131), sourceBundle.Substring(473683, 2945));
            }
        }
    }
}
