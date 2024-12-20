using System;
using System.Collections.Generic;
using static AuroraEngine.GFFObject;
using UnityEngine;
using AuroraEngine;

[Serializable]public class AuroraARE : AuroraStruct {
    // Field definitions
    [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
    [GFF("AlphaTest", Compatibility.BOTH, ExistsIn.BASE)] public Single AlphaTest;
    [GFF("DefaultEnvMap", Compatibility.BOTH, ExistsIn.BASE)] public String DefaultEnvMap;
    [GFF("Grass_TexName", Compatibility.BOTH, ExistsIn.BASE)] public String Grass_TexName;
    [GFF("Grass_Density", Compatibility.BOTH, ExistsIn.BASE)] public Single Grass_Density;
    [GFF("Grass_QuadSize", Compatibility.BOTH, ExistsIn.BASE)] public Single Grass_QuadSize;
    [GFF("Grass_Prob_LL", Compatibility.BOTH, ExistsIn.BASE)] public Single Grass_Prob_LL;
    [GFF("Grass_Prob_LR", Compatibility.BOTH, ExistsIn.BASE)] public Single Grass_Prob_LR;
    [GFF("Grass_Prob_UL", Compatibility.BOTH, ExistsIn.BASE)] public Single Grass_Prob_UL;
    [GFF("Grass_Prob_UR", Compatibility.BOTH, ExistsIn.BASE)] public Single Grass_Prob_UR;
    [GFF("MoonFogOn", Compatibility.BOTH, ExistsIn.BASE)] public Byte MoonFogOn;
    [GFF("MoonFogNear", Compatibility.BOTH, ExistsIn.BASE)] public Single MoonFogNear;
    [GFF("MoonFogFar", Compatibility.BOTH, ExistsIn.BASE)] public Single MoonFogFar;
    [GFF("MoonShadows", Compatibility.BOTH, ExistsIn.BASE)] public Byte MoonShadows;
    [GFF("SunFogOn", Compatibility.BOTH, ExistsIn.BASE)] public Byte SunFogOn;
    [GFF("SunFogNear", Compatibility.BOTH, ExistsIn.BASE)] public Single SunFogNear;
    [GFF("SunFogFar", Compatibility.BOTH, ExistsIn.BASE)] public Single SunFogFar;
    [GFF("SunShadows", Compatibility.BOTH, ExistsIn.BASE)] public Byte SunShadows;
    [GFF("IsNight", Compatibility.BOTH, ExistsIn.BASE)] public Byte IsNight;
    [GFF("LightingScheme", Compatibility.BOTH, ExistsIn.BASE)] public Byte LightingScheme;
    [GFF("ShadowOpacity", Compatibility.BOTH, ExistsIn.BASE)] public Byte ShadowOpacity;
    [GFF("DayNightCycle", Compatibility.BOTH, ExistsIn.BASE)] public Byte DayNightCycle;
    [GFF("PlayerVsPlayer", Compatibility.BOTH, ExistsIn.BASE)] public Byte PlayerVsPlayer;
    [GFF("NoRest", Compatibility.BOTH, ExistsIn.BASE)] public Byte NoRest;
    [GFF("NoHangBack", Compatibility.BOTH, ExistsIn.BASE)] public Byte NoHangBack;
    [GFF("PlayerOnly", Compatibility.BOTH, ExistsIn.BASE)] public Byte PlayerOnly;
    [GFF("Unescapable", Compatibility.BOTH, ExistsIn.BASE)] public Byte Unescapable;
    [GFF("StealthXPEnabled", Compatibility.BOTH, ExistsIn.BASE)] public Byte StealthXPEnabled;
    [GFF("OnEnter", Compatibility.BOTH, ExistsIn.BASE)] public String OnEnter;
    [GFF("OnExit", Compatibility.BOTH, ExistsIn.BASE)] public String OnExit;
    [GFF("OnHeartbeat", Compatibility.BOTH, ExistsIn.BASE)] public String OnHeartbeat;
    [GFF("OnUserDefined", Compatibility.BOTH, ExistsIn.BASE)] public String OnUserDefined;
    [GFF("DisableTransit", Compatibility.BOTH, ExistsIn.BASE)] public Byte DisableTransit;
    [GFF("ID", Compatibility.BOTH, ExistsIn.BASE)] public Int32 ID;
    [GFF("Creator_ID", Compatibility.BOTH, ExistsIn.BASE)] public Int32 Creator_ID;
    [GFF("Version", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Version;
    [GFF("Tag", Compatibility.BOTH, ExistsIn.BASE)] public CExoString Tag = new CExoString();
    [GFF("Name", Compatibility.BOTH, ExistsIn.BASE)] public CExoLocString Name = new CExoLocString();
    [GFF("Comments", Compatibility.BOTH, ExistsIn.BASE)] public CExoString Comments = new CExoString();
    [GFF("Flags", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Flags;
    [GFF("ModSpotCheck", Compatibility.BOTH, ExistsIn.BASE)] public Int32 ModSpotCheck;
    [GFF("ModListenCheck", Compatibility.BOTH, ExistsIn.BASE)] public Int32 ModListenCheck;
    [GFF("CameraStyle", Compatibility.BOTH, ExistsIn.BASE)] public Int32 CameraStyle;
    [GFF("Grass_Ambient", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Grass_Ambient;
    [GFF("Grass_Diffuse", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Grass_Diffuse;
    [GFF("MoonAmbientColor", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 MoonAmbientColor;
    [GFF("MoonDiffuseColor", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 MoonDiffuseColor;
    [GFF("MoonFogColor", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 MoonFogColor;
    [GFF("SunAmbientColor", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 SunAmbientColor;
    [GFF("SunDiffuseColor", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 SunDiffuseColor;
    [GFF("SunFogColor", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 SunFogColor;
    [GFF("DynAmbientColor", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 DynAmbientColor;
    [GFF("ChanceRain", Compatibility.BOTH, ExistsIn.BASE)] public Int32 ChanceRain;
    [GFF("ChanceSnow", Compatibility.BOTH, ExistsIn.BASE)] public Int32 ChanceSnow;
    [GFF("ChanceLightning", Compatibility.BOTH, ExistsIn.BASE)] public Int32 ChanceLightning;
    [GFF("WindPower", Compatibility.BOTH, ExistsIn.BASE)] public Int32 WindPower;
    [GFF("LoadScreenID", Compatibility.BOTH, ExistsIn.BASE)] public UInt16 LoadScreenID;
    [GFF("StealthXPLoss", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 StealthXPLoss;
    [GFF("StealthXPMax", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 StealthXPMax;
    [GFF("Grass_Emissive", Compatibility.TSL, ExistsIn.BASE)] public UInt32 Grass_Emissive;
    [GFF("DirtyARGBOne", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyARGBOne;
    [GFF("DirtySizeOne", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtySizeOne;
    [GFF("DirtyFormulaOne", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyFormulaOne;
    [GFF("DirtyFuncOne", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyFuncOne;
    [GFF("DirtyARGBTwo", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyARGBTwo;
    [GFF("DirtySizeTwo", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtySizeTwo;
    [GFF("DirtyFormulaTwo", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyFormulaTwo;
    [GFF("DirtyFuncTwo", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyFuncTwo;
    [GFF("DirtyARGBThree", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyARGBThree;
    [GFF("DirtySizeThree", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtySizeThree;
    [GFF("DirtyFormulaThre", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyFormulaThre;
    [GFF("DirtyFuncThree", Compatibility.TSL, ExistsIn.BASE)] public Int32 DirtyFuncThree;
    [GFF("KTInfoVersion", Compatibility.TSL, ExistsIn.BASE)] public CExoString KTInfoVersion = new CExoString();
    [GFF("KTInfoDate", Compatibility.TSL, ExistsIn.BASE)] public CExoString KTInfoDate = new CExoString();
    [GFF("KTGameVerIndex", Compatibility.TSL, ExistsIn.BASE)] public Int32 KTGameVerIndex;

    // Struct definitions
    [GFF("Map", Compatibility.BOTH, ExistsIn.BASE)] public AMap Map = new AMap();
    //[GFF("MiniGame", Compatibility.BOTH, ExistsIn.BASE)] public AMiniGame MiniGame = new AMiniGame();

    // List definitions
    [GFF("Rooms", Compatibility.BOTH, ExistsIn.BASE)] public List<ARooms> Rooms = new List<ARooms>();

    // Class definitions    
    [Serializable]public class AMap : AuroraStruct {
        // Field definitions
        [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
        [GFF("MapResX", Compatibility.BOTH, ExistsIn.BASE)] public Int32 MapResX;
        [GFF("NorthAxis", Compatibility.BOTH, ExistsIn.BASE)] public Int32 NorthAxis;
        [GFF("WorldPt1X", Compatibility.BOTH, ExistsIn.BASE)] public Single WorldPt1X;
        [GFF("WorldPt1Y", Compatibility.BOTH, ExistsIn.BASE)] public Single WorldPt1Y;
        [GFF("WorldPt2X", Compatibility.BOTH, ExistsIn.BASE)] public Single WorldPt2X;
        [GFF("WorldPt2Y", Compatibility.BOTH, ExistsIn.BASE)] public Single WorldPt2Y;
        [GFF("MapPt1X", Compatibility.BOTH, ExistsIn.BASE)] public Single MapPt1X;
        [GFF("MapPt1Y", Compatibility.BOTH, ExistsIn.BASE)] public Single MapPt1Y;
        [GFF("MapPt2X", Compatibility.BOTH, ExistsIn.BASE)] public Single MapPt2X;
        [GFF("MapPt2Y", Compatibility.BOTH, ExistsIn.BASE)] public Single MapPt2Y;
        [GFF("MapZoom", Compatibility.BOTH, ExistsIn.BASE)] public Int32 MapZoom;
        
    }
    
    [Serializable]public class AMiniGame : AuroraStruct {
        // Field definitions
        [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
        [GFF("Type", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Type;
        [GFF("Near_Clip", Compatibility.BOTH, ExistsIn.BASE)] public Single Near_Clip;
        [GFF("Far_Clip", Compatibility.BOTH, ExistsIn.BASE)] public Single Far_Clip;
        [GFF("CameraViewAngle", Compatibility.BOTH, ExistsIn.BASE)] public Single CameraViewAngle;
        [GFF("Bump_Plane", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Bump_Plane;
        [GFF("UseInertia", Compatibility.BOTH, ExistsIn.BASE)] public Byte UseInertia;
        [GFF("DoBumping", Compatibility.BOTH, ExistsIn.BASE)] public Byte DoBumping;
        [GFF("DOF", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 DOF;
        [GFF("MovementPerSec", Compatibility.BOTH, ExistsIn.BASE)] public Single MovementPerSec;
        [GFF("LateralAccel", Compatibility.BOTH, ExistsIn.BASE)] public Single LateralAccel;
        [GFF("Music", Compatibility.BOTH, ExistsIn.BASE)] public String Music;
    
        // Struct definitions
        [GFF("Mouse", Compatibility.BOTH, ExistsIn.BASE)] public AMouse Mouse = new AMouse();
        [GFF("Player", Compatibility.BOTH, ExistsIn.BASE)] public APlayer Player = new APlayer();
    
        // List definitions
        [GFF("Enemies", Compatibility.KotOR, ExistsIn.BASE)] public List<AEnemies> Enemies = new List<AEnemies>();
        [GFF("Obstacles", Compatibility.KotOR, ExistsIn.BASE)] public List<AObstacles> Obstacles = new List<AObstacles>();
    
        // Class definitions    
        [Serializable]public class AMouse : AuroraStruct {
            // Field definitions
            [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
            [GFF("AxisX", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 AxisX;
            [GFF("AxisY", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 AxisY;
            [GFF("FlipAxisX", Compatibility.BOTH, ExistsIn.BASE)] public Byte FlipAxisX;
            [GFF("FlipAxisY", Compatibility.BOTH, ExistsIn.BASE)] public Byte FlipAxisY;
            
        }
        
        [Serializable]public class APlayer : AuroraStruct {
            // Field definitions
            [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
            [GFF("Track", Compatibility.BOTH, ExistsIn.BASE)] public String Track;
            [GFF("Num_Loops", Compatibility.BOTH, ExistsIn.BASE)] public Int32 Num_Loops;
            [GFF("Sphere_Radius", Compatibility.BOTH, ExistsIn.BASE)] public Single Sphere_Radius;
            [GFF("Invince_Period", Compatibility.BOTH, ExistsIn.BASE)] public Single Invince_Period;
            [GFF("Hit_Points", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Hit_Points;
            [GFF("Max_HPs", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Max_HPs;
            [GFF("Bump_Damage", Compatibility.BOTH, ExistsIn.BASE)] public Int32 Bump_Damage;
            [GFF("Camera", Compatibility.BOTH, ExistsIn.BASE)] public String Camera;
            [GFF("CameraRotate", Compatibility.BOTH, ExistsIn.BASE)] public Byte CameraRotate;
            [GFF("Minimum_Speed", Compatibility.BOTH, ExistsIn.BASE)] public Single Minimum_Speed;
            [GFF("Maximum_Speed", Compatibility.BOTH, ExistsIn.BASE)] public Single Maximum_Speed;
            [GFF("Accel_Secs", Compatibility.BOTH, ExistsIn.BASE)] public Single Accel_Secs;
            [GFF("Start_Offset_X", Compatibility.BOTH, ExistsIn.BASE)] public Single Start_Offset_X;
            [GFF("Start_Offset_Y", Compatibility.BOTH, ExistsIn.BASE)] public Single Start_Offset_Y;
            [GFF("Start_Offset_Z", Compatibility.BOTH, ExistsIn.BASE)] public Single Start_Offset_Z;
            [GFF("TunnelInfinite", Compatibility.BOTH, ExistsIn.BASE)] public Vector3 TunnelInfinite;
            [GFF("TunnelXPos", Compatibility.BOTH, ExistsIn.BASE)] public Single TunnelXPos;
            [GFF("TunnelYPos", Compatibility.BOTH, ExistsIn.BASE)] public Single TunnelYPos;
            [GFF("TunnelZPos", Compatibility.BOTH, ExistsIn.BASE)] public Single TunnelZPos;
            [GFF("TunnelXNeg", Compatibility.BOTH, ExistsIn.BASE)] public Single TunnelXNeg;
            [GFF("TunnelYNeg", Compatibility.BOTH, ExistsIn.BASE)] public Single TunnelYNeg;
            [GFF("TunnelZNeg", Compatibility.BOTH, ExistsIn.BASE)] public Single TunnelZNeg;
            [GFF("Target_Offset_X", Compatibility.BOTH, ExistsIn.BASE)] public Single Target_Offset_X;
            [GFF("Target_Offset_Y", Compatibility.BOTH, ExistsIn.BASE)] public Single Target_Offset_Y;
            [GFF("Target_Offset_Z", Compatibility.BOTH, ExistsIn.BASE)] public Single Target_Offset_Z;
        
            // Struct definitions
            [GFF("Sounds", Compatibility.BOTH, ExistsIn.BASE)] public ASounds Sounds = new ASounds();
            [GFF("Scripts", Compatibility.BOTH, ExistsIn.BASE)] public AScripts Scripts = new AScripts();
        
            // List definitions
            [GFF("Models", Compatibility.BOTH, ExistsIn.BASE)] public List<AModels> Models = new List<AModels>();
            [GFF("Gun_Banks", Compatibility.BOTH, ExistsIn.BASE)] public List<AGun_Banks> Gun_Banks = new List<AGun_Banks>();
        
            // Class definitions    
            [Serializable]public class ASounds : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
                [GFF("Death", Compatibility.BOTH, ExistsIn.BASE)] public String Death;
                [GFF("Engine", Compatibility.BOTH, ExistsIn.BASE)] public String Engine;
                
            }
            
            [Serializable]public class AScripts : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
                [GFF("OnCreate", Compatibility.BOTH, ExistsIn.BASE)] public String OnCreate;
                [GFF("OnHeartbeat", Compatibility.BOTH, ExistsIn.BASE)] public String OnHeartbeat;
                [GFF("OnDamage", Compatibility.BOTH, ExistsIn.BASE)] public String OnDamage;
                [GFF("OnDeath", Compatibility.BOTH, ExistsIn.BASE)] public String OnDeath;
                [GFF("OnFire", Compatibility.BOTH, ExistsIn.BASE)] public String OnFire;
                [GFF("OnHitBullet", Compatibility.BOTH, ExistsIn.BASE)] public String OnHitBullet;
                [GFF("OnHitFollower", Compatibility.BOTH, ExistsIn.BASE)] public String OnHitFollower;
                [GFF("OnHitObstacle", Compatibility.BOTH, ExistsIn.BASE)] public String OnHitObstacle;
                [GFF("OnTrackLoop", Compatibility.BOTH, ExistsIn.BASE)] public String OnTrackLoop;
                [GFF("OnAnimEvent", Compatibility.BOTH, ExistsIn.BASE)] public String OnAnimEvent;
                [GFF("OnAccelerate", Compatibility.TSL, ExistsIn.BASE)] public String OnAccelerate;
                [GFF("OnBrake", Compatibility.TSL, ExistsIn.BASE)] public String OnBrake;
                [GFF("OnHitWorld", Compatibility.TSL, ExistsIn.BASE)] public String OnHitWorld;
                
            }
            
            [Serializable]public class AModels : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
                [GFF("Model", Compatibility.BOTH, ExistsIn.BASE)] public String Model;
                [GFF("RotatingModel", Compatibility.BOTH, ExistsIn.BASE)] public Byte RotatingModel;
                
            }
            
            [Serializable]public class AGun_Banks : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
                [GFF("BankID", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 BankID;
                [GFF("Gun_Model", Compatibility.BOTH, ExistsIn.BASE)] public String Gun_Model;
                [GFF("Fire_Sound", Compatibility.BOTH, ExistsIn.BASE)] public String Fire_Sound;
            
                // Struct definitions
                [GFF("Bullet", Compatibility.BOTH, ExistsIn.BASE)] public ABullet Bullet = new ABullet();
            
                // Class definitions    
                [Serializable]public class ABullet : AuroraStruct {
                    // Field definitions
                    [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
                    [GFF("Damage", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Damage;
                    [GFF("Lifespan", Compatibility.BOTH, ExistsIn.BASE)] public Single Lifespan;
                    [GFF("Bullet_Model", Compatibility.BOTH, ExistsIn.BASE)] public String Bullet_Model;
                    [GFF("Rate_Of_Fire", Compatibility.BOTH, ExistsIn.BASE)] public Single Rate_Of_Fire;
                    [GFF("Collision_Sound", Compatibility.BOTH, ExistsIn.BASE)] public String Collision_Sound;
                    [GFF("Speed", Compatibility.BOTH, ExistsIn.BASE)] public Single Speed;
                    [GFF("Target_Type", Compatibility.BOTH, ExistsIn.BASE)] public UInt32 Target_Type;
                    
                }
                
            }
            
        }
        
        [Serializable]public class AEnemies : AuroraStruct {
            // Field definitions
            [GFF("structid", Compatibility.KotOR, ExistsIn.BASE)] public uint structid;
            [GFF("Track", Compatibility.KotOR, ExistsIn.BASE)] public String Track;
            [GFF("Num_Loops", Compatibility.KotOR, ExistsIn.BASE)] public Int32 Num_Loops;
            [GFF("Sphere_Radius", Compatibility.KotOR, ExistsIn.BASE)] public Single Sphere_Radius;
            [GFF("Invince_Period", Compatibility.KotOR, ExistsIn.BASE)] public Single Invince_Period;
            [GFF("Hit_Points", Compatibility.KotOR, ExistsIn.BASE)] public UInt32 Hit_Points;
            [GFF("Max_HPs", Compatibility.KotOR, ExistsIn.BASE)] public UInt32 Max_HPs;
            [GFF("Bump_Damage", Compatibility.KotOR, ExistsIn.BASE)] public Int32 Bump_Damage;
            [GFF("Trigger", Compatibility.KotOR, ExistsIn.BASE)] public Byte Trigger;
        
            // Struct definitions
            [GFF("Sounds", Compatibility.KotOR, ExistsIn.BASE)] public ASounds Sounds = new ASounds();
            [GFF("Scripts", Compatibility.KotOR, ExistsIn.BASE)] public AScripts Scripts = new AScripts();
        
            // List definitions
            [GFF("Models", Compatibility.KotOR, ExistsIn.BASE)] public List<AModels> Models = new List<AModels>();
            [GFF("Gun_Banks", Compatibility.KotOR, ExistsIn.BASE)] public List<AGun_Banks> Gun_Banks = new List<AGun_Banks>();
        
            // Class definitions    
            [Serializable]public class ASounds : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.KotOR, ExistsIn.BASE)] public uint structid;
                [GFF("Death", Compatibility.KotOR, ExistsIn.BASE)] public String Death;
                [GFF("Engine", Compatibility.KotOR, ExistsIn.BASE)] public String Engine;
                
            }
            
            [Serializable]public class AScripts : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.KotOR, ExistsIn.BASE)] public uint structid;
                [GFF("OnCreate", Compatibility.KotOR, ExistsIn.BASE)] public String OnCreate;
                [GFF("OnHeartbeat", Compatibility.KotOR, ExistsIn.BASE)] public String OnHeartbeat;
                [GFF("OnDamage", Compatibility.KotOR, ExistsIn.BASE)] public String OnDamage;
                [GFF("OnDeath", Compatibility.KotOR, ExistsIn.BASE)] public String OnDeath;
                [GFF("OnFire", Compatibility.KotOR, ExistsIn.BASE)] public String OnFire;
                [GFF("OnHitBullet", Compatibility.KotOR, ExistsIn.BASE)] public String OnHitBullet;
                [GFF("OnHitFollower", Compatibility.KotOR, ExistsIn.BASE)] public String OnHitFollower;
                [GFF("OnHitObstacle", Compatibility.KotOR, ExistsIn.BASE)] public String OnHitObstacle;
                [GFF("OnTrackLoop", Compatibility.KotOR, ExistsIn.BASE)] public String OnTrackLoop;
                [GFF("OnAnimEvent", Compatibility.KotOR, ExistsIn.BASE)] public String OnAnimEvent;
                
            }
            
            [Serializable]public class AModels : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.KotOR, ExistsIn.BASE)] public uint structid;
                [GFF("Model", Compatibility.KotOR, ExistsIn.BASE)] public String Model;
                [GFF("RotatingModel", Compatibility.KotOR, ExistsIn.BASE)] public Byte RotatingModel;
                
            }
            
            [Serializable]public class AGun_Banks : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.KotOR, ExistsIn.BASE)] public uint structid;
                [GFF("BankID", Compatibility.KotOR, ExistsIn.BASE)] public UInt32 BankID;
                [GFF("Gun_Model", Compatibility.KotOR, ExistsIn.BASE)] public String Gun_Model;
                [GFF("Fire_Sound", Compatibility.KotOR, ExistsIn.BASE)] public String Fire_Sound;
                [GFF("Inaccuracy", Compatibility.KotOR, ExistsIn.BASE)] public Single Inaccuracy;
                [GFF("Sensing_Radius", Compatibility.KotOR, ExistsIn.BASE)] public Single Sensing_Radius;
                [GFF("Horiz_Spread", Compatibility.KotOR, ExistsIn.BASE)] public Single Horiz_Spread;
                [GFF("Vert_Spread", Compatibility.KotOR, ExistsIn.BASE)] public Single Vert_Spread;
            
                // Struct definitions
                [GFF("Bullet", Compatibility.KotOR, ExistsIn.BASE)] public ABullet Bullet = new ABullet();
            
                // Class definitions    
                [Serializable]public class ABullet : AuroraStruct {
                    // Field definitions
                    [GFF("structid", Compatibility.KotOR, ExistsIn.BASE)] public uint structid;
                    [GFF("Damage", Compatibility.KotOR, ExistsIn.BASE)] public UInt32 Damage;
                    [GFF("Lifespan", Compatibility.KotOR, ExistsIn.BASE)] public Single Lifespan;
                    [GFF("Bullet_Model", Compatibility.KotOR, ExistsIn.BASE)] public String Bullet_Model;
                    [GFF("Rate_Of_Fire", Compatibility.KotOR, ExistsIn.BASE)] public Single Rate_Of_Fire;
                    [GFF("Collision_Sound", Compatibility.KotOR, ExistsIn.BASE)] public String Collision_Sound;
                    [GFF("Speed", Compatibility.KotOR, ExistsIn.BASE)] public Single Speed;
                    [GFF("Target_Type", Compatibility.KotOR, ExistsIn.BASE)] public UInt32 Target_Type;
                    
                }
                
            }
            
        }
        
        [Serializable]public class AObstacles : AuroraStruct {
            // Field definitions
            [GFF("structid", Compatibility.KotOR, ExistsIn.BASE)] public uint structid;
            [GFF("Name", Compatibility.KotOR, ExistsIn.BASE)] public String Name;
        
            // Struct definitions
            [GFF("Scripts", Compatibility.KotOR, ExistsIn.BASE)] public AScripts Scripts = new AScripts();
        
            // Class definitions    
            [Serializable]public class AScripts : AuroraStruct {
                // Field definitions
                [GFF("structid", Compatibility.KotOR, ExistsIn.BASE)] public uint structid;
                [GFF("OnAnimEvent", Compatibility.KotOR, ExistsIn.BASE)] public String OnAnimEvent;
                [GFF("OnCreate", Compatibility.KotOR, ExistsIn.BASE)] public String OnCreate;
                [GFF("OnHeartbeat", Compatibility.KotOR, ExistsIn.BASE)] public String OnHeartbeat;
                [GFF("OnHitFollower", Compatibility.KotOR, ExistsIn.BASE)] public String OnHitFollower;
                [GFF("OnHitBullet", Compatibility.KotOR, ExistsIn.BASE)] public String OnHitBullet;
                
            }
            
        }
        
    }
    
    [Serializable]public class ARooms : AuroraStruct {
        // Field definitions
        [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
        [GFF("AmbientScale", Compatibility.BOTH, ExistsIn.BASE)] public Single AmbientScale;
        [GFF("DisableWeather", Compatibility.BOTH, ExistsIn.BASE)] public Byte DisableWeather;
        [GFF("RoomName", Compatibility.BOTH, ExistsIn.BASE)] public CExoString RoomName = new CExoString();
        [GFF("EnvAudio", Compatibility.BOTH, ExistsIn.BASE)] public Int32 EnvAudio;
        [GFF("ForceRating", Compatibility.TSL, ExistsIn.BASE)] public Int32 ForceRating;
    
        // List definitions
        [GFF("PartSounds", Compatibility.BOTH, ExistsIn.BASE)] public List<APartSounds> PartSounds = new List<APartSounds>();
    
        // Class definitions    
        [Serializable]public class APartSounds : AuroraStruct {
            // Field definitions
            [GFF("structid", Compatibility.BOTH, ExistsIn.BASE)] public uint structid;
            [GFF("ModelPart", Compatibility.BOTH, ExistsIn.BASE)] public CExoString ModelPart = new CExoString();
            [GFF("OmenEvent", Compatibility.BOTH, ExistsIn.BASE)] public CExoString OmenEvent = new CExoString();
            [GFF("Sound", Compatibility.BOTH, ExistsIn.BASE)] public String Sound;
            [GFF("Looping", Compatibility.BOTH, ExistsIn.BASE)] public Byte Looping;
            
        }
        
    }
    
}
