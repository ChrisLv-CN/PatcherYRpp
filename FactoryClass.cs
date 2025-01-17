﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatcherYRpp
{
    [StructLayout(LayoutKind.Explicit, Size = 116)]
    public struct FactoryClass
    {
        private static readonly IntPtr arrayPointer = new IntPtr(0xA83E30);
        public static ref DynamicVectorClass<Pointer<FactoryClass>> Array { get => ref DynamicVectorClass<Pointer<FactoryClass>>.GetDynamicVector(arrayPointer); }

        [FieldOffset(92)] public byte OnHold;
        [FieldOffset(93)] public byte IsDifferent;
        [FieldOffset(96)] public int Balance;
        [FieldOffset(100)] public int OriginalBalance;
        [FieldOffset(104)] public int SpecialItem;
        [FieldOffset(108)] public Pointer<HouseClass> Owner;
        [FieldOffset(112)] public byte IsSuspended;
        [FieldOffset(113)] public byte IsManual;
    }
}
