// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using LibreLancer.Ini;
namespace LibreLancer.Data.Universe
{
	public class TexturePanelsRef
	{
        [Entry("file", Multiline = true)]
		public List<string> Files = new List<string>();
    }
}

