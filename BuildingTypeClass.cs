﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatcherYRpp
{
    [StructLayout(LayoutKind.Explicit, Size = 6040)]
    public struct BuildingTypeClass
    {
        public static readonly IntPtr ArrayPointer = new IntPtr(0xA83C68);

        public static YRPP.GLOBAL_DVC_ARRAY<BuildingTypeClass> ABSTRACTTYPE_ARRAY = new YRPP.GLOBAL_DVC_ARRAY<BuildingTypeClass>(ArrayPointer);

        public unsafe short GetFoundationWidth()
        {
            var func = (delegate* unmanaged[Thiscall]<ref BuildingTypeClass, short>)0x45EC90;
            return func(ref this);
        }
        public unsafe short GetFoundationHeight(bool bIncludeBib)
        {
            var func = (delegate* unmanaged[Thiscall]<ref BuildingTypeClass, Bool, short>)0x45ECA0;
            return func(ref this, bIncludeBib);
        }

        [FieldOffset(0)] public TechnoTypeClass Base;
        [FieldOffset(0)] public ObjectTypeClass BaseObjectType;
        [FieldOffset(0)] public AbstractTypeClass BaseAbstractType;

        [FieldOffset(3576)] public int ArrayIndex;
        [FieldOffset(3764)] public int Adjacent;
        [FieldOffset(3828)] public int Height;
        [FieldOffset(3832)] public int OccupyHeight;
        [FieldOffset(5408)] public int NormalZAdjust;
        [FieldOffset(5450)] public Bool TogglePower;
        [FieldOffset(5451)] public Bool HasSpotlight;
        [FieldOffset(5452)] public Bool IsTemple;
        [FieldOffset(5453)] public Bool IsPlug;
        [FieldOffset(5454)] public Bool HoverPad;
        [FieldOffset(5455)] public Bool BaseNormal;
        [FieldOffset(5456)] public Bool EligibileForAllyBuilding;
        [FieldOffset(5457)] public Bool EligibleForDelayKill;
        [FieldOffset(5458)] public Bool NeedsEngineer;
        [FieldOffset(5490)] public Bool Capturable;
        [FieldOffset(5495)] public Bool CanC4;
        [FieldOffset(5825)] public Bool Hospital;
        [FieldOffset(5835)] public Bool Helipad;
        [FieldOffset(5889)] public Bool InvisibleInGame;
        [FieldOffset(5891)] public Bool PlaceAnywhere;
        [FieldOffset(6016)] public int NumberOfDocks;
    }
}
