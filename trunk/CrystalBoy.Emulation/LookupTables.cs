﻿#region Copyright Notice
// This file is part of CrystalBoy.
// Copyright (C) 2008 Fabien Barbier
// 
// CrystalBoy is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CrystalBoy is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace CrystalBoy.Emulation
{
	public static class LookupTables
	{
		[CLSCompliant(false)]
		public static readonly uint[] ColorLookupTable32 = InitializeColorLookupTable32();
		[CLSCompliant(false)]
		public static readonly ushort[] ColorLookupTable16 = InitializeColorLookupTable16();

		[CLSCompliant(false)]
		public static readonly uint[] GrayPalette = BuildPalette();
		[CLSCompliant(false)]
		public static readonly ushort[] PaletteLookupTable, FlippedPaletteLookupTable;

		static LookupTables()
		{
			BuildPaletteLookupTables(out PaletteLookupTable, out FlippedPaletteLookupTable);
		}

		static uint[] BuildPalette()
		{
			return new uint[] { 0xFFFFFFFF, 0xFFC0C0C0, 0xFF808080, 0xFF000000 };
		}

		static void BuildPaletteLookupTables(out ushort[] paletteLookupTable, out ushort[] flippedPaletteLookupTable)
		{
			paletteLookupTable = new ushort[65536];
			flippedPaletteLookupTable = new ushort[65536];

			for (int i = 0; i < 65536; i++)
			{
				int src = i,
					dst1 = 0,
					dst2 = 0;

				for (int j = 0; j < 8; j++)
				{
					dst1 <<= 2;
					dst2 >>= 2;

					if ((src & 0x0001) != 0)
					{
						dst1 |= 0x0001;
						dst2 |= 0x4000;
					}
					if ((src & 0x0100) != 0)
					{
						dst1 |= 0x0002;
						dst2 |= 0x8000;
					}
					src >>= 1;
				}

				paletteLookupTable[i] = (ushort)dst1;
				flippedPaletteLookupTable[i] = (ushort)dst2;
			}
		}

		#region Color Conversion Tables Management

		#region Initialization

		// Static constructors should be avoided for performance, we use these method for table initialization instead

		private static ushort[] InitializeColorLookupTable16()
		{
			ushort[] lookupTable = new ushort[65536];

			GetPoppyColors16(lookupTable);

			return lookupTable;
		}

		private static uint[] InitializeColorLookupTable32()
		{
			uint[] lookupTable = new uint[65536];

			GetPoppyColors32(lookupTable);

			return lookupTable;
		}

		#endregion

		#region Poppy Colors

		[CLSCompliant(false)]
		public static void GetPoppyColors16(ushort[] lookupTable)
		{
			for (uint i = 0; i < lookupTable.Length; i++)
			{
				lookupTable[i] = (ushort)((i << 1) & 0xFFC0 | i & 0x1F);
			}
		}

		[CLSCompliant(false)]
		public static void GetPoppyColors32(uint[] lookupTable)
		{
			for (uint i = 0; i < lookupTable.Length; i++)
			{
				uint r = 0xFF * (i & 0x1F) / 0x1F,
					g = 0xFF * ((i >> 5) & 0x1F) / 0x1F,
					b = 0xFF * ((i >> 10) & 0x1F) / 0x1F;

				lookupTable[i] = b | (g << 8) | (r << 16) | 0xFF000000;
			}
		}

		#endregion

		#endregion
	}
}