﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatcherYRpp
{
    public enum AbstractType
    {
        None = 0,
        Unit = 1,
        Aircraft = 2,
        AircraftType = 3,
        Anim = 4,
        AnimType = 5,
        Building = 6,
        BuildingType = 7,
        Bullet = 8,
        BulletType = 9,
        Campaign = 10,
        Cell = 11,
        Factory = 12,
        House = 13,
        HouseType = 14,
        Infantry = 15,
        InfantryType = 16,
        Isotile = 17,
        IsotileType = 18,
        BuildingLight = 19,
        Overlay = 20,
        OverlayType = 21,
        Particle = 22,
        ParticleType = 23,
        ParticleSystem = 24,
        ParticleSystemType = 25,
        Script = 26,
        ScriptType = 27,
        Side = 28,
        Smudge = 29,
        SmudgeType = 30,
        Special = 31,
        SuperWeaponType = 32,
        TaskForce = 33,
        Team = 34,
        TeamType = 35,
        Terrain = 36,
        TerrainType = 37,
        Trigger = 38,
        TriggerType = 39,
        UnitType = 40,
        VoxelAnim = 41,
        VoxelAnimType = 42,
        Wave = 43,
        Tag = 44,
        TagType = 45,
        Tiberium = 46,
        Action = 47,
        Event = 48,
        WeaponType = 49,
        WarheadType = 50,
        Waypoint = 51,
        Abstract = 52,
        Tube = 53,
        LightSource = 54,
        EMPulse = 55,
        TacticalMap = 56,
        Super = 57,
        AITrigger = 58,
        AITriggerType = 59,
        Neuron = 60,
        FoggedObject = 61,
        AlphaShape = 62,
        VeinholeMonster = 63,
        NavyType = 64,
        SpawnManager = 65,
        CaptureManager = 66,
        Parasite = 67,
        Bomb = 68,
        RadSite = 69,
        Temporal = 70,
        Airstrike = 71,
        SlaveManager = 72,
        DiskLaser = 73
    };

    public enum DamageAreaResult
    {
        Hit = 0,
        Missed = 1,
        Nullified = 2
    };

    public enum SpotlightFlags
    {
        None = 0x0,
        NoColor = 0x1,
        NoRed = 0x2,
        NoGreen = 0x4,
        NoBlue = 0x8
    };
    public enum LandType
    {
        Clear = 0,
        Road = 1,
        Water = 2,
        Rock = 3,
        Wall = 4,
        Tiberium = 5,
        Beach = 6,
        Rough = 7,
        Ice = 8,
        Railroad = 9,
        Tunnel = 10,
        Weeds = 11
    };

    public enum Layer
    {
        None = -1,
        Underground = 0,
        Surface = 1,
        Ground = 2,
        Air = 3,
        Top = 4
    };

    public enum ChargeDrainState
    {
        None = -1,
        Charging = 0,
        Ready = 1,
        Draining = 2
    };

    public enum SuperWeaponType
    {
        Invalid = -1,
        Nuke = 0,
        IronCurtain = 1,
        LightningStorm = 2,
        ChronoSphere = 3,
        ChronoWarp = 4,
        ParaDrop = 5,
        AmerParaDrop = 6,
        PsychicDominator = 7,
        SpyPlane = 8,
        GeneticMutator = 9,
        ForceShield = 10,
        PsychicReveal = 11
    };
}
