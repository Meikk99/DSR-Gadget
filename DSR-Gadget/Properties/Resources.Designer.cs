﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSR_Gadget.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DSR_Gadget.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 100000 Depths #1 (beginning of level)
        ///100001 Depths #2 (near bonfire key)
        ///100010 Depths #3 (near channeler)
        ///100011 Depths #4 (blighttown door)
        ///101000 Undead Burg #1 (outside sewer)
        ///101010 Undead Burg #2 (outside bonfire)
        ///101011 Undead Burg #3 (taurus fog gate)
        ///101100 Lower Undead Burg #1 (near ladder entrance)
        ///101101 Lower Undead Burg #2 (capra fog gate)
        ///101200 Undead Parish #1 (dragon bridge)
        ///101210 Undead Parish #2 (gargoyle fog gate)
        ///102000 Firelink Shrine #1
        ///110000 Painted World of Ariamis # [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Areas {
            get {
                return ResourceManager.GetString("Areas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   10000   1 1 Catarina Helm
        ///  11000   1 1 Catarina Armor
        ///  12000   1 1 Catarina Gauntlets
        ///  13000   1 1 Catarina Leggings
        ///  20000   1 1 Paladin Helm
        ///  21000   1 1 Paladin Armor
        ///  22000   1 1 Paladin Gauntlets
        ///  23000   1 1 Paladin Leggings
        ///  40000   1 1 Dark Mask
        ///  41000   1 1 Dark Armor
        ///  42000   1 1 Dark Gauntlets
        ///  43000   1 1 Dark Leggings
        ///  50000   1 2 Brigand Hood
        ///  51000   1 2 Brigand Armor
        ///  52000   1 2 Brigand Gauntlets
        ///  53000   1 2 Brigand Trousers
        ///  60000   1 1 Shadow Mask
        ///  610 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Armor {
            get {
                return ResourceManager.GetString("Armor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -1 [None]
        ///1002900 Depths (Entrance)
        ///1002950 Depths (Gaping Dragon&apos;s Room)
        ///1002960 Depths (Bonfire)
        ///1012960 Undead Burg (Pre-Dragon Scare)
        ///1012961 Undead Parish (Sunlight Altar Bonfire)
        ///1012962 Undead Burg (Bonfire)
        ///1012964 Undead Parish (Bonfire)
        ///1012965 Undead Parish (Near Boar)
        ///1012966 Undead Parish (Near Cell)
        ///1020980 Firelink Shrine (Bonfire, repeat)
        ///1022960 Firelink Shrine (Bonfire)
        ///1102511 Painted World of Ariamis (Rope Bridge)
        ///1102960 Painted World of Ariamis (Bonfire)
        ///1102961 Painted W [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Bonfires {
            get {
                return ResourceManager.GetString("Bonfires", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0:  48 b9 fe fe fe fe fe    movabs rcx,0xfefefefefefefefe
        ///7:  fe fe fe
        ///a:  48 8b 09                mov    rcx,QWORD PTR [rcx]
        ///d:  ba 01 00 00 00          mov    edx,0x1
        ///12: 48 83 ec 38             sub    rsp,0x38
        ///16: 49 be fe fe fe fe fe    movabs r14,0xfefefefefefefefe
        ///1d: fe fe fe
        ///20: 41 ff d6                call   r14
        ///23: 48 83 c4 38             add    rsp,0x38
        ///27: c3                      ret .
        /// </summary>
        internal static string BonfireWarp {
            get {
                return ResourceManager.GetString("BonfireWarp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0 4 11 08 12 13 13 11 09 09 Warrior
        ///1 5 14 10 10 11 11 10 09 11 Knight
        ///2 3 10 11 10 10 14 12 11 08 Wanderer
        ///3 5 09 11 09 09 15 10 12 11 Thief
        ///4 4 12 08 14 14 09 11 08 10 Bandit
        ///5 4 11 09 11 12 14 11 09 09 Hunter
        ///6 3 08 15 08 09 11 08 15 08 Sorcerer
        ///7 1 10 12 11 12 09 12 10 08 Pyromancer
        ///8 2 11 11 09 12 08 11 08 14 Cleric
        ///9 6 11 11 11 11 11 11 11 11 Deprived.
        /// </summary>
        internal static string Classes {
            get {
                return ResourceManager.GetString("Classes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     109  99 0 Eye of Death
        ///    111  99 0 Cracked Red Eye Orb
        ///    230  99 0 Elizabeth&apos;s Mushroom
        ///    240  99 0 Divine Blessing
        ///    260  99 0 Green Blossom
        ///    270  99 0 Bloodred Moss Clump
        ///    271  99 0 Purple Moss Clump
        ///    272  99 0 Blooming Purple Moss Clump
        ///    274  99 0 Purging Stone
        ///    275  99 0 Egg Vermifuge
        ///    280  99 0 Repair Powder
        ///    290  99 0 Throwing Knife
        ///    291  99 0 Poison Throwing Knife
        ///    292  99 0 Firebomb
        ///    293  99 0 Dung Pie
        ///    294  99 0 Alluring Skull
        ///    296  99 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Consumables {
            get {
                return ResourceManager.GetString("Consumables", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0:  ba fe fe fe fe          mov    edx,0xfefefefe
        ///5:  41 b9 fe fe fe fe       mov    r9d,0xfefefefe
        ///b:  41 b8 fe fe fe fe       mov    r8d,0xfefefefe
        ///11: 41 bc fe fe fe fe       mov    r12d,0xfefefefe
        ///17: 48 a1 fe fe fe fe fe    movabs rax,ds:0xfefefefefefefefe
        ///1e: fe fe fe
        ///21: c6 44 24 38 01          mov    BYTE PTR [rsp+0x38],0x1
        ///26: 40 88 7c 24 30          mov    BYTE PTR [rsp+0x30],dil
        ///2b: c6 44 24 28 01          mov    BYTE PTR [rsp+0x28],0x1
        ///30: 4c 8b 78 10             mov    r15,QWORD PTR [r [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetItem {
            get {
                return ResourceManager.GetString("GetItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0 None
        ///1 White Summon
        ///2 Red Summon
        ///3 Red Invade
        ///7 Gravelord Invade
        ///10 Dragon Summon
        ///11 Darkmoon Invade
        ///12 Arena (1v1)
        ///13 Arena (1v1)
        ///14 Arena (Team)
        ///15 Arena (Team)
        ///16 Arena (Team)
        ///17 Arena (Team)
        ///18 Arena (Team)
        ///19 Arena (Team)
        ///20 Arena (FFA)
        ///21 Arena (FFA)
        ///22 Arena (FFA)
        ///23 Arena (FFA)
        ///24 Arena (FFA)
        ///25 Arena (FFA).
        /// </summary>
        internal static string Invasions {
            get {
                return ResourceManager.GetString("Invasions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     384   1 0 Peculiar Doll
        ///   2001   1 0 Basement Key
        ///   2002   1 0 Crest of Artorias
        ///   2003   1 0 Cage Key
        ///   2004   1 0 Archive Tower Cell Key
        ///   2005   1 0 Archive Tower Giant Door Key
        ///   2006   1 0 Archive Tower Giant Cell Key
        ///   2007   1 0 Blighttown Key
        ///   2008   1 0 Key to New Londo Ruins
        ///   2009   1 0 Annex Key
        ///   2010   1 0 Dungeon Cell Key
        ///   2011   1 0 Big Pilgrim&apos;s Key
        ///   2012   1 0 Undead Asylum F2 East Key
        ///   2013   1 0 Key to the Seal
        ///   2014   1 0 Key to Depths
        ///   2016   1 0 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string KeyItems {
            get {
                return ResourceManager.GetString("KeyItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0:  48 ba 00 00 00 00 ff    movabs rdx,0xffffffff00000000
        ///7:  ff ff ff
        ///a:  48 b9 00 00 00 00 ff    movabs rcx,0xffffffff00000000
        ///11: ff ff ff
        ///14: 48 83 ec 38             sub    rsp,0x38
        ///18: 49 be 20 99 68 40 01    movabs r14,0x140689920
        ///1f: 00 00 00
        ///22: 41 ff d6                call   r14
        ///25: 48 83 c4 38             add    rsp,0x38
        ///29: c3                      ret .
        /// </summary>
        internal static string LevelUp {
            get {
                return ResourceManager.GetString("LevelUp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -1   0   None
        ///3000 90  Soul Arrow
        ///3010 60  Great Souls Arrow
        ///3020 36  Heavy Souls Arrow
        ///3030 24  Great Heavy Souls Arrow
        ///3040 30  Homing Soulsmass
        ///3050 30  Homing Crystal Soulsmass
        ///3060 12  Souls Spear
        ///3070 12  Crystal Souls Spear
        ///3100 15  Magic Weapon
        ///3110 9   Great Magic Weapon
        ///3120 9   Crystal Magic Weapon
        ///3300 15  Magic Shield
        ///3310 9   Strong Magic Shield
        ///3400 9   Hidden Weapon
        ///3410 9   Hidden Body
        ///3500 9   Cast Light
        ///3510 18  Hush
        ///3520 60  Aural Decoy
        ///3530 3   Repair
        ///3540 30  Fall C [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Magic {
            get {
                return ResourceManager.GetString("Magic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  100000   1 3 Dagger
        /// 101000   1 3 Parrying Dagger
        /// 102000   1 1 Ghost Blade
        /// 103000   1 3 Bandit&apos;s Knife
        /// 104000   1 1 Priscilla&apos;s Dagger
        /// 200000   1 3 Shortsword
        /// 201000   1 3 Longsword
        /// 202000   1 3 Broadsword
        /// 203000   1 3 Broken Straight Sword
        /// 204000   1 3 Balder Side Sword
        /// 205000   1 0 Crystal Straight Sword
        /// 206000   1 3 Sunlight Straight Sword
        /// 207000   1 3 Barbed Straight Sword
        /// 208000   1 1 Silver Knight Straight Sword
        /// 209000   1 1 Astora&apos;s Straight Sword
        /// 210000   1 3 Darksword        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MeleeWeapons {
            get {
                return ResourceManager.GetString("MeleeWeapons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to       1   1 0 [Unknown]
        ///   1000   1 0 Shaved
        ///   1100   1 0 Receding
        ///   1200   1 0 Short
        ///   1300   1 0 Swept Back
        ///   1400   1 0 Ponytail
        ///   1500   1 0 Wild
        ///   1600   1 0 Parted Center
        ///   1700   1 0 Semi-Long
        ///   1800   1 0 Curly
        ///   1900   1 0 Bobbed
        ///   2000   1 0 Male 11
        ///   2100   1 0 Male 12
        ///   2200   1 0 Male 13
        ///   2300   1 0 Male 14
        ///   2400   1 0 Male 15
        ///   2500   1 0 Male 16
        ///   2600   1 0 Male 17
        ///   2700   1 0 Male 18
        ///   2800   1 0 Male 19
        ///   2900   1 0 Male 20
        ///   3000   1 0 Shaved
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MysteryArmor {
            get {
                return ResourceManager.GetString("MysteryArmor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     116   1 0 Black Eye Orb (Shiva)
        ///    130   1 0 Covenant: None
        ///    131   1 0 Covenant: Way of White
        ///    132   1 0 Covenant: Princess&apos;s Guard
        ///    133   1 0 Covenant: Warrior of Sunlight
        ///    134   1 0 Covenant: Darkwraith
        ///    135   1 0 Covenant: Path of the Dragon
        ///    136   1 0 Covenant: Gravelord Servant
        ///    137   1 0 Covenant: Forest Hunter
        ///    138   1 0 Covenant: Darkmoon Blade
        ///    139   1 0 Covenant: Chaos Servant
        ///    140   1 0 Covenant: None
        ///    141   1 0 Covenant: Way of White+1
        ///    142   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MysteryGoods {
            get {
                return ResourceManager.GetString("MysteryGoods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  199000   1 0 Phantom Dagger
        /// 299000   1 0 Phantom Straight Sword
        /// 398000   1 0 Phantom Greatsword
        /// 399000   1 0 Phantom Ultra Greatsword
        /// 498000   1 0 Phantom Curved Sword
        /// 499000   1 0 Phantom Curved Greatsword
        /// 599000   1 0 Phantom Katana
        /// 699000   1 0 Phantom Thrusting Sword
        /// 798000   1 0 Phantom Axe
        /// 799000   1 0 Phantom Greataxe
        /// 898000   1 0 Phantom Hammer
        /// 899000   1 0 Phantom Greathammer
        /// 900000   1 0 Fists
        /// 999000   1 0 Phantom Fists
        ///1099000   1 0 Phantom Spear
        ///1199000   1 0 Phantom [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MysteryWeapons {
            get {
                return ResourceManager.GetString("MysteryWeapons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1200000   1 3 Short Bow
        ///1201000   1 3 Longbow
        ///1202000   1 3 Black Bow of Pharis
        ///1203000   1 1 Dragonslayer Greatbow
        ///1204000   1 3 Composite Bow
        ///1205000   1 1 Darkmoon Bow
        ///1250000   1 4 Light Crossbow
        ///1251000   1 4 Heavy Crossbow
        ///1252000   1 4 Avelyn
        ///1253000   1 4 Sniper Crossbow
        ///2000000 999 0 Standard Arrow
        ///2001000 999 0 Large Arrow
        ///2002000 999 0 Feather Arrow
        ///2003000 999 0 Fire Arrow
        ///2004000 999 0 Poison Arrow
        ///2005000 999 0 Moonlight Arrow
        ///2006000 999 0 Wooden Arrow
        ///2007000 999 0 Dragonsla [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RangedWeapons {
            get {
                return ResourceManager.GetString("RangedWeapons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     100   1 0 Havel&apos;s Ring
        ///    101   1 0 Red Tearstone Ring
        ///    102   1 0 Darkmoon Blade Covenant Ring
        ///    103   1 0 Cat Covenant Ring
        ///    104   1 0 Cloranthy Ring
        ///    105   1 0 Flame Stoneplate Ring
        ///    106   1 0 Thunder Stoneplate Ring
        ///    107   1 0 Spell Stoneplate Ring
        ///    108   1 0 Speckled Stoneplate Ring
        ///    109   1 0 Bloodbite Ring
        ///    110   1 0 Poisonbite Ring
        ///    111   1 0 Tiny Being&apos;s Ring
        ///    113   1 0 Cursebite Ring
        ///    114   1 0 White Seance Ring
        ///    115   1 0 Bellowing Dragoncre [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Rings {
            get {
                return ResourceManager.GetString("Rings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1396000   1 0 Skull Lantern
        ///1400000   1 4 East-West Shield
        ///1401000   1 4 Wooden Shield
        ///1402000   1 4 Large Leather Shield
        ///1403000   1 4 Small Leather Shield
        ///1404000   1 4 Target Shield
        ///1405000   1 4 Buckler
        ///1406000   1 4 Cracked Round Shield
        ///1408000   1 4 Leather Shield
        ///1409000   1 4 Plank Shield
        ///1410000   1 4 Caduceus Round Shield
        ///1411000   1 1 Crystal Ring Shield
        ///1450000   1 4 Heater Shield
        ///1451000   1 4 Knight Shield
        ///1452000   1 4 Tower Kite Shield
        ///1453000   1 4 Grass Crest Shield
        ///1454000 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Shields {
            get {
                return ResourceManager.GetString("Shields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to    3000  99 0 Sorcery: Soul Arrow
        ///   3010  99 0 Sorcery: Great Soul Arrow
        ///   3020  99 0 Sorcery: Heavy Soul Arrow
        ///   3030  99 0 Sorcery: Great Heavy Soul Arrow
        ///   3040  99 0 Sorcery: Homing Soulmass
        ///   3050  99 0 Sorcery: Homing Crystal Soulmass
        ///   3060  99 0 Sorcery: Soul Spear
        ///   3070  99 0 Sorcery: Crystal Soul Spear
        ///   3100  99 0 Sorcery: Magic Weapon
        ///   3110  99 0 Sorcery: Great Magic Weapon
        ///   3120  99 0 Sorcery: Crystal Magic Weapon
        ///   3300  99 0 Sorcery: Magic Shield
        ///   3310  99 0 Sorcer [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Spells {
            get {
                return ResourceManager.GetString("Spells", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1300000   1 0 Sorcerer&apos;s Catalyst
        ///1301000   1 0 Beatrice&apos;s Catalyst
        ///1302000   1 0 Tin Banishment Catalyst
        ///1303000   1 0 Logan&apos;s Catalyst
        ///1304000   1 0 Tin Darkmoon Catalyst
        ///1305000   1 0 Oolacile Ivory Catalyst
        ///1306000   1 0 Tin Crystallization Catalyst
        ///1307000   1 0 Demon&apos;s Catalyst
        ///1308000   1 0 Izalith Catalyst
        ///1330000   1 5 Pyromancy Flame
        ///1332000   1 6 Pyromancy Flame (Ascended)
        ///1360000   1 0 Talisman
        ///1361000   1 0 Canvas Talisman
        ///1362000   1 0 Thorolund Talisman
        ///1363000   1 0 Ivory Talis [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpellTools {
            get {
                return ResourceManager.GetString("SpellTools", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0 1 Human
        ///8 4 Hollow
        ///1 2 White Phantom
        ///2 16 Red Phantom
        ///2 17 Blue Phantom
        ///2 18 Path of the Dragon
        ///13 16 Arena FFA
        ///13 17 Arena Team 1
        ///13 18 Arena Team 2
        ///2 3 Red Phantom (Team).
        /// </summary>
        internal static string Teams {
            get {
                return ResourceManager.GetString("Teams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     800   1 0 Large Ember
        ///    801   1 0 Very Large Ember
        ///    802   1 0 Crystal Ember
        ///    806   1 0 Large Magic Ember
        ///    807   1 0 Enchanted Ember
        ///    808   1 0 Divine Ember
        ///    809   1 0 Large Divine Ember
        ///    810   1 0 Dark Ember
        ///    812   1 0 Large Flame Ember
        ///    813   1 0 Chaos Flame Ember
        ///   1000  99 0 Titanite Shard
        ///   1010  99 0 Large Titanite Shard
        ///   1020  99 0 Green Titanite Shard
        ///   1030  99 0 Titanite Chunk
        ///   1040  99 0 Blue Titanite Chunk
        ///   1050  99 0 White Titanite Chunk
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpgradeMaterials {
            get {
                return ResourceManager.GetString("UpgradeMaterials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     100   1 0 White Sign Soapstone
        ///    101   1 0 Red Sign Soapstone
        ///    102   1 0 Red Eye Orb
        ///    103   1 0 Black Separation Crystal
        ///    106   1 0 Orange Guidance Soapstone
        ///    108   1 0 Book of the Guilty
        ///    112   1 0 Servant Roster
        ///    113   1 0 Blue Eye Orb
        ///    114   1 0 Dragon Eye
        ///    115   1 0 Black Eye Orb
        ///    117   1 0 Darksign
        ///    118   1 0 Purple Coward&apos;s Crystal
        ///    220  99 0 Silver Pendant
        ///    371   1 0 Binoculars
        ///    377  99 0 Dragon Head Stone
        ///    378  99 0 Dragon Torso Stone
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UsableItems {
            get {
                return ResourceManager.GetString("UsableItems", resourceCulture);
            }
        }
    }
}
