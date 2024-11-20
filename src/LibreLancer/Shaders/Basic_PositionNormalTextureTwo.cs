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
    
    public class Basic_PositionNormalTextureTwo
    {
        static ShaderVariables[] variants;
        private static bool iscompiled = false;
        private static int GetIndex(ShaderFeatures features)
        {
            ShaderFeatures masked = (features & ((ShaderFeatures)(151)));
            if ((masked == ((ShaderFeatures)(16))))
            {
                return 1;
            }
            if ((masked == ((ShaderFeatures)(1))))
            {
                return 2;
            }
            if ((masked == ((ShaderFeatures)(17))))
            {
                return 3;
            }
            if ((masked == ((ShaderFeatures)(128))))
            {
                return 4;
            }
            if ((masked == ((ShaderFeatures)(144))))
            {
                return 5;
            }
            if ((masked == ((ShaderFeatures)(129))))
            {
                return 6;
            }
            if ((masked == ((ShaderFeatures)(145))))
            {
                return 7;
            }
            if ((masked == ((ShaderFeatures)(2))))
            {
                return 8;
            }
            if ((masked == ((ShaderFeatures)(18))))
            {
                return 9;
            }
            if ((masked == ((ShaderFeatures)(3))))
            {
                return 10;
            }
            if ((masked == ((ShaderFeatures)(19))))
            {
                return 11;
            }
            if ((masked == ((ShaderFeatures)(130))))
            {
                return 12;
            }
            if ((masked == ((ShaderFeatures)(146))))
            {
                return 13;
            }
            if ((masked == ((ShaderFeatures)(131))))
            {
                return 14;
            }
            if ((masked == ((ShaderFeatures)(147))))
            {
                return 15;
            }
            if ((masked == ((ShaderFeatures)(4))))
            {
                return 16;
            }
            if ((masked == ((ShaderFeatures)(20))))
            {
                return 17;
            }
            if ((masked == ((ShaderFeatures)(5))))
            {
                return 18;
            }
            if ((masked == ((ShaderFeatures)(21))))
            {
                return 19;
            }
            if ((masked == ((ShaderFeatures)(132))))
            {
                return 20;
            }
            if ((masked == ((ShaderFeatures)(148))))
            {
                return 21;
            }
            if ((masked == ((ShaderFeatures)(133))))
            {
                return 22;
            }
            if ((masked == ((ShaderFeatures)(149))))
            {
                return 23;
            }
            if ((masked == ((ShaderFeatures)(6))))
            {
                return 24;
            }
            if ((masked == ((ShaderFeatures)(22))))
            {
                return 25;
            }
            if ((masked == ((ShaderFeatures)(7))))
            {
                return 26;
            }
            if ((masked == ((ShaderFeatures)(23))))
            {
                return 27;
            }
            if ((masked == ((ShaderFeatures)(134))))
            {
                return 28;
            }
            if ((masked == ((ShaderFeatures)(150))))
            {
                return 29;
            }
            if ((masked == ((ShaderFeatures)(135))))
            {
                return 30;
            }
            if ((masked == ((ShaderFeatures)(151))))
            {
                return 31;
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
            ShaderVariables.Log("Compiling Basic_PositionNormalTextureTwo");
            variants = new ShaderVariables[32];
            if (device.HasFeature(LibreLancer.Graphics.GraphicsFeature.Features430))
            {
                variants[0] = ShaderVariables.Compile(device, sourceBundle.Substring(361913, 1752), sourceBundle.Substring(45704, 6786));
                variants[1] = ShaderVariables.Compile(device, sourceBundle.Substring(365496, 2172), sourceBundle.Substring(206407, 6988));
                variants[2] = ShaderVariables.Compile(device, sourceBundle.Substring(361913, 1752), sourceBundle.Substring(56725, 6840));
                variants[3] = ShaderVariables.Compile(device, sourceBundle.Substring(365496, 2172), sourceBundle.Substring(217832, 7042));
                variants[4] = ShaderVariables.Compile(device, sourceBundle.Substring(372006, 4679), sourceBundle.Substring(74349, 2730));
                variants[5] = ShaderVariables.Compile(device, sourceBundle.Substring(381443, 5099), sourceBundle.Substring(246119, 2932));
                variants[6] = ShaderVariables.Compile(device, sourceBundle.Substring(372006, 4679), sourceBundle.Substring(79522, 2784));
                variants[7] = ShaderVariables.Compile(device, sourceBundle.Substring(381443, 5099), sourceBundle.Substring(251696, 2986));
                variants[8] = ShaderVariables.Compile(device, sourceBundle.Substring(361913, 1752), sourceBundle.Substring(86531, 6830));
                variants[9] = ShaderVariables.Compile(device, sourceBundle.Substring(365496, 2172), sourceBundle.Substring(259109, 7032));
                variants[10] = ShaderVariables.Compile(device, sourceBundle.Substring(361913, 1752), sourceBundle.Substring(97640, 6884));
                variants[11] = ShaderVariables.Compile(device, sourceBundle.Substring(365496, 2172), sourceBundle.Substring(270622, 7086));
                variants[12] = ShaderVariables.Compile(device, sourceBundle.Substring(372006, 4679), sourceBundle.Substring(106957, 2774));
                variants[13] = ShaderVariables.Compile(device, sourceBundle.Substring(381443, 5099), sourceBundle.Substring(280343, 2976));
                variants[14] = ShaderVariables.Compile(device, sourceBundle.Substring(372006, 4679), sourceBundle.Substring(112218, 2828));
                variants[15] = ShaderVariables.Compile(device, sourceBundle.Substring(381443, 5099), sourceBundle.Substring(286008, 3030));
                variants[16] = ShaderVariables.Compile(device, sourceBundle.Substring(361913, 1752), sourceBundle.Substring(119421, 6980));
                variants[17] = ShaderVariables.Compile(device, sourceBundle.Substring(365496, 2172), sourceBundle.Substring(293615, 7182));
                variants[18] = ShaderVariables.Compile(device, sourceBundle.Substring(361913, 1752), sourceBundle.Substring(130830, 7034));
                variants[19] = ShaderVariables.Compile(device, sourceBundle.Substring(365496, 2172), sourceBundle.Substring(305428, 7236));
                variants[20] = ShaderVariables.Compile(device, sourceBundle.Substring(372006, 4679), sourceBundle.Substring(140447, 2924));
                variants[21] = ShaderVariables.Compile(device, sourceBundle.Substring(381443, 5099), sourceBundle.Substring(315449, 3126));
                variants[22] = ShaderVariables.Compile(device, sourceBundle.Substring(372006, 4679), sourceBundle.Substring(146008, 2978));
                variants[23] = ShaderVariables.Compile(device, sourceBundle.Substring(381443, 5099), sourceBundle.Substring(321414, 3180));
                variants[24] = ShaderVariables.Compile(device, sourceBundle.Substring(361913, 1752), sourceBundle.Substring(153405, 7024));
                variants[25] = ShaderVariables.Compile(device, sourceBundle.Substring(365496, 2172), sourceBundle.Substring(329215, 7226));
                variants[26] = ShaderVariables.Compile(device, sourceBundle.Substring(361913, 1752), sourceBundle.Substring(164902, 7078));
                variants[27] = ShaderVariables.Compile(device, sourceBundle.Substring(365496, 2172), sourceBundle.Substring(341116, 7280));
                variants[28] = ShaderVariables.Compile(device, sourceBundle.Substring(372006, 4679), sourceBundle.Substring(174607, 2968));
                variants[29] = ShaderVariables.Compile(device, sourceBundle.Substring(381443, 5099), sourceBundle.Substring(351225, 3170));
                variants[30] = ShaderVariables.Compile(device, sourceBundle.Substring(372006, 4679), sourceBundle.Substring(180256, 3022));
                variants[31] = ShaderVariables.Compile(device, sourceBundle.Substring(381443, 5099), sourceBundle.Substring(357278, 3224));
            }
            else
            {
                variants[0] = ShaderVariables.Compile(device, sourceBundle.Substring(360502, 1411), sourceBundle.Substring(40082, 4181));
                variants[1] = ShaderVariables.Compile(device, sourceBundle.Substring(363665, 1831), sourceBundle.Substring(199907, 4383));
                variants[2] = ShaderVariables.Compile(device, sourceBundle.Substring(360502, 1411), sourceBundle.Substring(52490, 4235));
                variants[3] = ShaderVariables.Compile(device, sourceBundle.Substring(363665, 1831), sourceBundle.Substring(213395, 4437));
                variants[4] = ShaderVariables.Compile(device, sourceBundle.Substring(367668, 4338), sourceBundle.Substring(67592, 2389));
                variants[5] = ShaderVariables.Compile(device, sourceBundle.Substring(376685, 4758), sourceBundle.Substring(238484, 2591));
                variants[6] = ShaderVariables.Compile(device, sourceBundle.Substring(367668, 4338), sourceBundle.Substring(77079, 2443));
                variants[7] = ShaderVariables.Compile(device, sourceBundle.Substring(376685, 4758), sourceBundle.Substring(249051, 2645));
                variants[8] = ShaderVariables.Compile(device, sourceBundle.Substring(360502, 1411), sourceBundle.Substring(82306, 4225));
                variants[9] = ShaderVariables.Compile(device, sourceBundle.Substring(363665, 1831), sourceBundle.Substring(254682, 4427));
                variants[10] = ShaderVariables.Compile(device, sourceBundle.Substring(360502, 1411), sourceBundle.Substring(93361, 4279));
                variants[11] = ShaderVariables.Compile(device, sourceBundle.Substring(363665, 1831), sourceBundle.Substring(266141, 4481));
                variants[12] = ShaderVariables.Compile(device, sourceBundle.Substring(367668, 4338), sourceBundle.Substring(104524, 2433));
                variants[13] = ShaderVariables.Compile(device, sourceBundle.Substring(376685, 4758), sourceBundle.Substring(277708, 2635));
                variants[14] = ShaderVariables.Compile(device, sourceBundle.Substring(367668, 4338), sourceBundle.Substring(109731, 2487));
                variants[15] = ShaderVariables.Compile(device, sourceBundle.Substring(376685, 4758), sourceBundle.Substring(283319, 2689));
                variants[16] = ShaderVariables.Compile(device, sourceBundle.Substring(360502, 1411), sourceBundle.Substring(115046, 4375));
                variants[17] = ShaderVariables.Compile(device, sourceBundle.Substring(363665, 1831), sourceBundle.Substring(289038, 4577));
                variants[18] = ShaderVariables.Compile(device, sourceBundle.Substring(360502, 1411), sourceBundle.Substring(126401, 4429));
                variants[19] = ShaderVariables.Compile(device, sourceBundle.Substring(363665, 1831), sourceBundle.Substring(300797, 4631));
                variants[20] = ShaderVariables.Compile(device, sourceBundle.Substring(367668, 4338), sourceBundle.Substring(137864, 2583));
                variants[21] = ShaderVariables.Compile(device, sourceBundle.Substring(376685, 4758), sourceBundle.Substring(312664, 2785));
                variants[22] = ShaderVariables.Compile(device, sourceBundle.Substring(367668, 4338), sourceBundle.Substring(143371, 2637));
                variants[23] = ShaderVariables.Compile(device, sourceBundle.Substring(376685, 4758), sourceBundle.Substring(318575, 2839));
                variants[24] = ShaderVariables.Compile(device, sourceBundle.Substring(360502, 1411), sourceBundle.Substring(148986, 4419));
                variants[25] = ShaderVariables.Compile(device, sourceBundle.Substring(363665, 1831), sourceBundle.Substring(324594, 4621));
                variants[26] = ShaderVariables.Compile(device, sourceBundle.Substring(360502, 1411), sourceBundle.Substring(160429, 4473));
                variants[27] = ShaderVariables.Compile(device, sourceBundle.Substring(363665, 1831), sourceBundle.Substring(336441, 4675));
                variants[28] = ShaderVariables.Compile(device, sourceBundle.Substring(367668, 4338), sourceBundle.Substring(171980, 2627));
                variants[29] = ShaderVariables.Compile(device, sourceBundle.Substring(376685, 4758), sourceBundle.Substring(348396, 2829));
                variants[30] = ShaderVariables.Compile(device, sourceBundle.Substring(367668, 4338), sourceBundle.Substring(177575, 2681));
                variants[31] = ShaderVariables.Compile(device, sourceBundle.Substring(376685, 4758), sourceBundle.Substring(354395, 2883));
            }
        }
    }
}
