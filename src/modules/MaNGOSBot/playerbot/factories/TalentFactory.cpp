#include "TalentFactory.h"

TalentFactory::TalentFactory() {
	TalentTemplate[CLASS_WARRIOR] = { make_pair(ROLE_TANK, WarriorTank()) };
	TalentTemplate[CLASS_DRUID] = {
		make_pair(ROLE_HEALER, DruidHealer()),
		make_pair(ROLE_TANK, DruidTank()),
		make_pair(ROLE_DPS, DruidDps_B())
	};
	TalentTemplate[CLASS_PALADIN] = {
		make_pair(ROLE_TANK, PaladinTank()),
		make_pair(ROLE_HEALER, PaladinHealer()),
		make_pair(ROLE_DPS, PaladinDps())
	};
	TalentTemplate[CLASS_SHAMAN] = {
		make_pair(ROLE_HEALER, ShamanHealer()),
		make_pair(ROLE_DPS, ShamanDps())
	};
	TalentTemplate[CLASS_ROGUE] = { make_pair(ROLE_DPS, RogueDPS()) };
	TalentTemplate[CLASS_HUNTER] = { make_pair(ROLE_DPS, HunterDPS_MM()) };
}

map<uint32, uint8> TalentFactory::WarriorTank() {
	map<uint32, uint8> ProtWarrior;
	ProtWarrior[130] = 5; // Arms - Deflection
	ProtWarrior[128] = 3; // Arms - Improved Thunder Clap 
	ProtWarrior[158] = 4; // Fury - Booming Voice 
	ProtWarrior[142] = 2; // Prot - Improved Bloodrage
	ProtWarrior[138] = 5; // Prot - Anticipation 
	ProtWarrior[1601] = 5; // Prot - Shield Specialization 
	ProtWarrior[140] = 5; // Prot - Toughness 
	ProtWarrior[153] = 1; // Prot - Last Stand
	ProtWarrior[145] = 1; // Prot - Improved Shield Block
	ProtWarrior[147] = 3; // Prot - Improved Revenge
	ProtWarrior[144] = 3; // Prot - Defiance
	ProtWarrior[146] = 3; // Prot - Improved Sunder Armor 
	ProtWarrior[143] = 2; // Prot - Improved Taunt 
	ProtWarrior[150] = 2; // Prot - Improved Shield Wall 
	ProtWarrior[152] = 1; // Prot - Concussion Blow 
	ProtWarrior[1654] = 3; // Prot - Shield Mastery 
	ProtWarrior[1652] = 3; // Prot - Improved Defensive Stance
	ProtWarrior[148] = 1; // Prot - Shield Slam 
	ProtWarrior[1660] = 3; // Prot - Focused Rage 
	ProtWarrior[1653] = 5; // Prot - Vitality 
	ProtWarrior[1666] = 1; // Prot - Devastate
	return ProtWarrior;
}

map<uint32, uint8> TalentFactory::DruidTank() {
	map<uint32, uint8> TankFeralDruid;
	TankFeralDruid[761] = 1; // Balance - Nature's Grasp
	TankFeralDruid[796] = 5; // Feral - Ferocity 
	TankFeralDruid[799] = 3; // Feral - Feral Instinct 
	TankFeralDruid[797] = 2; // Feral - Brutal Impact
	TankFeralDruid[794] = 3; // Feral - Thick Hide 
	TankFeralDruid[807] = 2; // Feral - Feral Swiftness
	TankFeralDruid[804] = 3; // Feral - Feral Charge 
	TankFeralDruid[798] = 2; // Feral - Sharpened Claws
	TankFeralDruid[802] = 3; // Feral - Shredding Attacks
	TankFeralDruid[803] = 2; // Feral - Predatory Strikes
	TankFeralDruid[801] = 2; // Feral - Primal Fury
	TankFeralDruid[805] = 2; // Feral - Savage Fury
	TankFeralDruid[1162] = 1; // Feral - Faerie Fire (Feral)
	TankFeralDruid[808] = 5; // Feral - Heart of the Wild
	TankFeralDruid[1794] = 3; // Feral - Survival of the Fittest
	TankFeralDruid[809] = 1; // Feral - Leader of the Pack 
	TankFeralDruid[1798] = 2; // Feral - Improved Leader of the Pack
	TankFeralDruid[1795] = 5; // Feral - Predatory Instincts
	TankFeralDruid[1796] = 1; // Feral - Mangle
	TankFeralDruid[822] = 5; // Resto - Furor
	TankFeralDruid[824] = 5; // Resto - Naturalist
	TankFeralDruid[826] = 3; // Resto - Natural Shapeshifter
	TankFeralDruid[1796] = 1; // Resto - Omen of Clarity
	return TankFeralDruid;
}

map<uint32, uint8> TalentFactory::DruidHealer() {
	map<uint32, uint8> RestoDruid;
	RestoDruid[821] = 5; // Resto - Improved Mark of the Wild 
	RestoDruid[824] = 5; // Resto - Naturalist 
	RestoDruid[823] = 5; // Resto - Nature's Focus 
	RestoDruid[826] = 3; // Resto - Natural Shapeshifter
	RestoDruid[829] = 3; // Resto - Intesity 
	RestoDruid[841] = 5; // Resto - Subtlety
	RestoDruid[843] = 4; // Resto - Tranquil Spirit 
	RestoDruid[830] = 3; // Resto - Improved Rejuvenation
	RestoDruid[831] = 1; // Resto - Nature's Swiftness
	RestoDruid[828] = 5; // Resto - Gift of Nature
	RestoDruid[842] = 2; // Resto - Improved Tranquility 
	RestoDruid[1788] = 2; // Resto - Empowered Touch
	RestoDruid[825] = 5; // Resto - Improved Regrowth
	RestoDruid[1797] = 3; // Resto - Living Spirit
	RestoDruid[844] = 1; // Resto - Swiftmend 
	RestoDruid[1790] = 3; // Resto - Natural Perfection 
	RestoDruid[1789] = 5; // Resto - Empowered Rejuvenation
	RestoDruid[1791] = 1; // Resto - Tree of Life
	return RestoDruid;
}

map<uint32, uint8> TalentFactory::DruidDps_B() {
	map<uint32, uint8> DpsBalanceDruid;
	DpsBalanceDruid[762] = 5; // Balance - Starlight Wrath
	DpsBalanceDruid[787] = 3; // Balance -  Control of Nature
	DpsBalanceDruid[1822] = 2; // Balance -  Focused Starlight
	DpsBalanceDruid[763] = 2; // Balance -  Improved Moonfire
	DpsBalanceDruid[788] = 1; // Balance -  Insect Swarm 
	DpsBalanceDruid[764] = 2; // Balance -  Nature's Reach
	DpsBalanceDruid[792] = 5; // Balance -   Vengeance
	DpsBalanceDruid[1782] = 3; // Balance -  Lunar Guidance
	DpsBalanceDruid[789] = 1; // Balance -  Nature's Grace
	DpsBalanceDruid[783] = 3; // Balance -  Moonglow
	DpsBalanceDruid[790] = 5; // Balance - Moonfury  
	DpsBalanceDruid[1783] = 2; // Balance - Balance of Power 
	DpsBalanceDruid[1784] = 3; // Balance -  Dreamstate
	DpsBalanceDruid[793] = 1; // Balance - Moonkin Form   
	DpsBalanceDruid[1786] = 5; // Balance - Wrath of Cenarius 
	DpsBalanceDruid[821] = 5; // Resto -  Improved Mark of the Wild
	DpsBalanceDruid[823] = 2; // Resto - Nature's Focus
	DpsBalanceDruid[826] = 3; // Resto - Natural Shapeshifter
	DpsBalanceDruid[829] = 3; // Resto - Intensity
	DpsBalanceDruid[841] = 5; // Resto - Subtlety
	return DpsBalanceDruid;
}

map<uint32, uint8> TalentFactory::DruidDps_F() {
	map<uint32, uint8> DpsFeralDruid;
	DpsFeralDruid[761] = 1; // Balance - Nature's Grasp
	DpsFeralDruid[796] = 5; // Feral - Ferocity 
	DpsFeralDruid[799] = 3; // Feral - Feral Instinct 
	DpsFeralDruid[797] = 2; // Feral - Brutal Impact
	DpsFeralDruid[794] = 3; // Feral - Thick Hide 
	DpsFeralDruid[807] = 2; // Feral - Feral Swiftness
	DpsFeralDruid[804] = 3; // Feral - Feral Charge 
	DpsFeralDruid[798] = 2; // Feral - Sharpened Claws
	DpsFeralDruid[802] = 3; // Feral - Shredding Attacks
	DpsFeralDruid[803] = 2; // Feral - Predatory Strikes
	DpsFeralDruid[801] = 2; // Feral - Primal Fury
	DpsFeralDruid[805] = 2; // Feral - Savage Fury
	DpsFeralDruid[1162] = 1; // Feral - Faerie Fire (Feral)
	DpsFeralDruid[808] = 5; // Feral -  Heart of the Wild
	DpsFeralDruid[1794] = 3; // Feral - Survival of the Fittest
	DpsFeralDruid[809] = 1; // Feral -  Leader of the Pack 
	DpsFeralDruid[1798] = 2; // Feral - Improved Leader of the Pack
	DpsFeralDruid[1795] = 5; // Feral - Predatory Instincts
	DpsFeralDruid[1796] = 1; // Feral - Mangle
	DpsFeralDruid[822] = 5; // Resto - Furor
	DpsFeralDruid[824] = 5; // Resto - Naturalist
	DpsFeralDruid[826] = 3; // Resto - Natural Shapeshifter
	DpsFeralDruid[1796] = 1; // Resto - Omen of Clarity
	return DpsFeralDruid;
}

map<uint32, uint8> TalentFactory::PaladinTank() {
	map<uint32, uint8> ProtPaladin;
	ProtPaladin[1421] = 5; // Prot - Redoubt
	ProtPaladin[1630] = 3; // Prot - Precision
	ProtPaladin[1423] = 5; // Prot - Toughness
	ProtPaladin[1442] = 1; // Prot - Blessing of Kings
	ProtPaladin[1501] = 3; // Prot - Improved Righteous Fury
	ProtPaladin[1424] = 3; // Prot - Shield Specialization
	ProtPaladin[1629] = 5; // Prot - Anticipation
	ProtPaladin[1749] = 2; // Prot - Spell Warding
	ProtPaladin[1431] = 1; // Prot - Blessing of Sanctuary
	ProtPaladin[1426] = 5; // Prot - Reckoning
	ProtPaladin[1502] = 2; // Prot - Sacred Duty
	ProtPaladin[1829] = 2; // Prot - Improved Holy Shield
	ProtPaladin[1430] = 1; // Prot - Holy Shield
	ProtPaladin[1751] = 5; // Prot - Ardent Defender
	ProtPaladin[1753] = 5; // Prot - Combat Expertise
	ProtPaladin[1754] = 1; // Prot - Avenger's Shield
	ProtPaladin[1407] = 5; // Ret - Benediction
	ProtPaladin[1631] = 2; // Ret - Improved Judgement
	ProtPaladin[1403] = 5; // Ret - Deflection
	return ProtPaladin;
}

map<uint32, uint8> TalentFactory::PaladinHealer() {
	map<uint32, uint8> HolyPaladin;
	HolyPaladin[1450] = 5; // Holy - Divine Intellect
	HolyPaladin[1432] = 5; // Holy - Spiritual Focus 
	HolyPaladin[1435] = 3; // Holy - Aura Mastery
	HolyPaladin[1628] = 2; // Holy - Unyielding Faith
	HolyPaladin[1461] = 5; // Holy - Illumination
	HolyPaladin[1446] = 2; // Holy - Improved Blessing  of Wisdom
	HolyPaladin[1433] = 1; // Holy - Divine Favor
	HolyPaladin[1465] = 3; // Holy - Sanctified Light
	HolyPaladin[1743] = 2; // Holy - Purifying Power
	HolyPaladin[1627] = 5; // Holy - Holy Power
	HolyPaladin[1745] = 3; // Holy - Light's Grace
	HolyPaladin[1502] = 1; // Holy - Holy Shock
	HolyPaladin[1746] = 5; // Holy - Holy Guidance
	HolyPaladin[1747] = 1; // Holy - Divine Illumination
	HolyPaladin[1421] = 5; // Prot - Redoubt 
	HolyPaladin[1425] = 2; // Prot - Guardian's Favor
	HolyPaladin[1423] = 4; // Prot - Toughness
	HolyPaladin[1442] = 1; // Prot - Blessing of Kings
	HolyPaladin[1424] = 3; // Prot - Shield Specialization
	HolyPaladin[1626] = 3; // Prot - Improved Concentration Aura

	return HolyPaladin;
}

map<uint32, uint8> TalentFactory::PaladinDps() {
	map<uint32, uint8> RetPaladin;
	RetPaladin[1450] = 5; // Holy - Divine Strength
	RetPaladin[1422] = 5; // Prot - Improved Devotion Aura 
	RetPaladin[1630] = 3; // Prot - Precision
	RetPaladin[1401] = 5; // Ret - Improved Blessing of Might
	RetPaladin[1407] = 5; // Ret - Benediction
	RetPaladin[1631] = 2; // Ret - Improved Judgement
	RetPaladin[1464] = 3; // Ret - Improved Seal of the Crusader
	RetPaladin[1411] = 5; // Ret - Conviction
	RetPaladin[1481] = 1; // Ret - Seal of Command
	RetPaladin[1755] = 3; // Ret - Crusade
	RetPaladin[1410] = 3; // Ret - Two-Handed Weapon Specialization
	RetPaladin[1409] = 1; // Ret - Sanctity Aura
	RetPaladin[1756] = 2; // Ret - Improved Sanctity Aura
	RetPaladin[1402] = 5; // Ret - Vengeance
	RetPaladin[1758] = 3; // Ret - Sanctified Judgement
	RetPaladin[1761] = 3; // Ret - Sanctified Seals
	RetPaladin[1441] = 1; // Ret - Repentance
	RetPaladin[1759] = 5; // Ret - Fanaticism
	RetPaladin[1823] = 1; // Ret - Crusader Strike
	return RetPaladin;
}

map<uint32, uint8> TalentFactory::ShamanHealer() {
	map<uint32, uint8> RestoShaman;
	RestoShaman[564] = 5; // Elem - Convection 
	RestoShaman[1640] = 3; // Elem - Elemental Warding
	RestoShaman[586] = 5; // Resto - Improved Healing Wave
	RestoShaman[593] = 5; // Resto - Tidal Focus
	RestoShaman[589] = 2; // Resto - Improved Reincarnation 
	RestoShaman[581] = 3; // Resto - Ancestral Healing
	RestoShaman[595] = 5; // Resto - Totemic Focus
	RestoShaman[587] = 5; // Resto - Healing Focus
	RestoShaman[582] = 1; // Resto - Totemic Mastery
	RestoShaman[1646] = 1; // Resto - Healing Grace
	RestoShaman[588] = 5; // Resto - Restorative Totems
	RestoShaman[594] = 5; // Resto - Tidal Mastery
	RestoShaman[1648] = 3; // Resto - Healing Way
	RestoShaman[591] = 1; // Resto -  Nature's Swiftness
	RestoShaman[592] = 5; // Resto -  Purification
	RestoShaman[590] = 1; // Resto -  Mana Tide Totem
	RestoShaman[1696] = 3; // Resto - Nature's Blessing 
	RestoShaman[1697] = 2; // Resto - Improved Chain Heal
	RestoShaman[1698] = 1; // Resto - Earth Shield
	return RestoShaman;
}

map<uint32, uint8> TalentFactory::ShamanDps_Enhanc() {
	map<uint32, uint8> EnhancShaman;
	EnhancShaman[614] = 5; // Enhanc - Ancestral Knowledge 
	EnhancShaman[613] = 5; // Enhanc -  Thundering Strikes
	EnhancShaman[605] = 3; // Enhanc - Improved Ghost Wolf  
	EnhancShaman[610] = 1; // Enhanc -  Enhancing Totems
	EnhancShaman[617] = 5; // Enhanc - Shamanistic Focus 
	EnhancShaman[602] = 1; // Enhanc -  Flurry
	EnhancShaman[1647] = 1; // Enhanc -  Improved Weapon Totems
	EnhancShaman[616] = 5; // Enhanc -  Spirit Weapons
	EnhancShaman[611] = 3; // Enhanc -  Elemental Weapons
	EnhancShaman[1691] = 5; // Enhanc - Mental Quickness
	EnhancShaman[1643] = 1; // Enhanc - Weapon Mastery 
	EnhancShaman[1692] = 5; // Enhanc -  Dual Wield Specialization
	EnhancShaman[1690] = 1; // Enhanc -  Dual Wield
	EnhancShaman[901] = 5; // Enhanc -  Stormstrike
	EnhancShaman[1689] = 1; // Enhanc -  Unleashed Rage
	EnhancShaman[1693] = 5; // Enhanc -  Shamanistic Rage
	EnhancShaman[586] = 3; // Resto - Improved Healing Wave
	EnhancShaman[589] = 1; // Resto - Improved Reincarnation 
	EnhancShaman[595] = 5; // Resto -  Totemic Focus
	EnhancShaman[583] = 3; // Resto - Nature's Guidance
	EnhancShaman[582] = 1; // Resto - Totemic Mastery  
	return EnhancShaman;
}

map<uint32, uint8> TalentFactory::ShamanDps() {
	map<uint32, uint8> ElemShaman;
	ElemShaman[564] = 5; // Elem - Convection 
	ElemShaman[563] = 5; // Elem -  Concussion
	ElemShaman[1640] = 3; // Elem - Elemental Warding  
	ElemShaman[574] = 1; // Elem -  Elemental Focus
	ElemShaman[562] = 5; // Elem - Call of Thunder 
	ElemShaman[567] = 1; // Elem -  Improved Fire Totems
	ElemShaman[565] = 1; // Elem -  Elemental Fury
	ElemShaman[1682] = 5; // Elem -  Unrelenting Storm
	ElemShaman[1685] = 3; // Elem -  Elemental Precision
	ElemShaman[721] = 5; // Elem - Lightning Mastery 
	ElemShaman[573] = 1; // Elem - Elemental Mastery 
	ElemShaman[1686] = 5; // Elem -  Lightning Overload
	ElemShaman[1687] = 1; // Elem -  Totem of Wrath
	ElemShaman[586] = 5; // Resto -  Improved Healing Wave
	ElemShaman[589] = 1; // Resto -  Improved Reincarnation
	ElemShaman[595] = 5; // Resto -  Totemic Focus
	ElemShaman[583] = 3; // Resto - Nature's Guidance
	ElemShaman[582] = 1; // Resto - Totemic Mastery  
	ElemShaman[588] = 5; // Resto -  Restorative Totems
	return ElemShaman;
}

map<uint32, uint8> TalentFactory::RogueDPS_A() {
	map<uint32, uint8> AssaRogue;
	AssaRogue[270] = 5; // Assa - Malice
	AssaRogue[273] = 3; // Assa - Ruthlessness
	AssaRogue[274] = 2; // Assa - Murder
	AssaRogue[277] = 3; // Assa - Puncturing Wounds
	AssaRogue[281] = 1; // Assa - Relentless Strikes 
	AssaRogue[278] = 2; // Assa - Improved Expose Armor  
	AssaRogue[269] = 5; // Assa - Lethality 
	AssaRogue[682] = 5; // Assa - Vile Poisons 
	AssaRogue[268] = 2; // Assa - Improved Poisons
	AssaRogue[280] = 1; // Assa - Cold Blood
	AssaRogue[283] = 5; // Assa - Seal Fate
	AssaRogue[382] = 1; // Assa - Vigor
	AssaRogue[1718] = 5; // Assa - Find Weakness
	AssaRogue[1719] = 1; // Assa - Mutilate
	AssaRogue[186] = 5; // Combat - Lightning Reflexes
	AssaRogue[1827] = 3; // Combat - Improved Slice and Dice
	AssaRogue[181] = 5; // Combat - Precision
	AssaRogue[222] = 2; // Combat - Improved Sprint
	AssaRogue[221] = 5; // Combat - Dual Wield Specialization
	return AssaRogue;
}

map<uint32, uint8> TalentFactory::RogueDPS() {
	map<uint32, uint8> CombatRogue;
	CombatRogue[270] = 5; // Assa - Malice
	CombatRogue[273] = 3; // Assa - Ruthlessness
	CombatRogue[274] = 2; // Assa - Murder
	CombatRogue[281] = 1; // Assa - Relentless Strikes 
	CombatRogue[278] = 2; // Assa - Improved Expose Armor  
	CombatRogue[269] = 5; // Assa - Lethality 
	CombatRogue[201] = 2; // Combat - Improved Sinister Strike 
	CombatRogue[186] = 3; // Combat - Lightning Reflexes
	CombatRogue[1827] = 3; // Combat -Improved Slice and Dice
	CombatRogue[181] = 5; // Combat - Precision
	CombatRogue[204] = 2; // Combat - Endurance
	CombatRogue[221] = 5; // Combat - Dual Wield Specialization
	CombatRogue[223] = 1; // Combat - Blade Flurry
	CombatRogue[242] = 5; // Combat - Sword Specialization
	CombatRogue[183] = 5; // Combat - Fist Weapon Specialization
	CombatRogue[1703] = 2; // Combat - Weapon Expertise
	CombatRogue[1122] = 3; // Combat - Aggression
	CombatRogue[205] = 1; // Combat - Adrenaline Rush
	CombatRogue[1825] = 5; // Combat - Combat Potency
	CombatRogue[1709] = 1; // Combat - Surprise Attacks
	return CombatRogue;
}

map<uint32, uint8> TalentFactory::HunterDPS_BM() {
	map<uint32, uint8> BMHunter;
	BMHunter[1382] = 5; // BM - Improved Aspect of the Hawk
	BMHunter[1389] = 1; // BM - Endurance Training
	BMHunter[1624] = 2; // BM - Focused Fire
	BMHunter[1395] = 2; // BM -  Improved Revive Pet
	BMHunter[1396] = 5; // BM - Unleashed Fury  
	BMHunter[1385] = 2; // BM - Improved Mend Pet    
	BMHunter[1393] = 5; // BM -  Ferocity
	BMHunter[1387] = 1; // BM -  Intimidation 
	BMHunter[1390] = 2; // BM -  Bestial Discipline
	BMHunter[1799] = 2; // BM - Animal Handler
	BMHunter[1397] = 4; // BM -  Frenzy
	BMHunter[1800] = 3; // BM - Ferocious Inspiration
	BMHunter[1386] = 1; // BM -  Bestial Wrath
	BMHunter[1802] = 5; // BM - Serpent's Swiftness
	BMHunter[1803] = 1; // BM - The Beast Within 
	BMHunter[1344] = 5; // MM - Lethal Shots   
	BMHunter[1343] = 5; // MM - Improved Hunter's Mark
	BMHunter[1818] = 2; // MM -  Go for the Throat
	BMHunter[1345] = 1; // MM - Aimed Shot  
	BMHunter[1819] = 2; // MM - Rapid Killing 
	BMHunter[1349] = 5; // MM - Mortal Shots
	return BMHunter;
}

map<uint32, uint8> TalentFactory::HunterDPS_MM() {
	map<uint32, uint8> MMHunter;
	MMHunter[1382] = 5; // BM - Improved Aspect of the Hawk
	MMHunter[1624] = 2; // BM - Focused Fire
	MMHunter[1344] = 5; // MM - Lethal Shots
	MMHunter[1343] = 5; // MM -  Improved Hunter's Mark
	MMHunter[1342] = 5; // MM - Efficiency  
	MMHunter[1818] = 2; // MM - Go for the Throat    
	MMHunter[1345] = 1; // MM -  Aimed Shot
	MMHunter[1819] = 2; // MM -  Rapid Killing 
	MMHunter[1349] = 5; // MM -  Mortal Shots
	MMHunter[1353] = 1; // MM - Scatter Shot 
	MMHunter[1347] = 3; // MM -  Barrage
	MMHunter[1804] = 2; // MM - Combat Experience
	MMHunter[1362] = 5; // MM -  Ranged Weapon Specialization
	MMHunter[1806] = 3; // MM - Careful Aim
	MMHunter[1361] = 1; // MM - Trueshot Aura 
	MMHunter[1821] = 3; // MM - Improved Barrage   
	MMHunter[1807] = 5; // MM - Master Marksman
	MMHunter[1301] = 2; // Surv -  Humanoid Slaying
	MMHunter[1820] = 5; // Surv - Hawk Eye  
	return MMHunter;
}

map<uint32, uint8> TalentFactory::HunterDPS_SV() {
	map<uint32, uint8> SVHunter;
	SVHunter[1344] = 5; // MM - Lethal Shots
	SVHunter[1343] = 5; // MM - Improved Hunter's Mark
	SVHunter[1818] = 2; // MM -  Go for the Throat
	SVHunter[1345] = 1; // MM - Aimed Shot  
	SVHunter[1819] = 2; // MM - Rapid Killing 
	SVHunter[1349] = 5; // MM - Mortal Shots
	SVHunter[1301] = 3; // SV -  Humanoid Slaying 
	SVHunter[1820] = 3; // SV -  Hawk Eye
	SVHunter[1304] = 3; // SV - Entrapment
	SVHunter[1305] = 3; // SV -  Improved Wing Clip
	SVHunter[1622] = 5; // SV - Survivalist
	SVHunter[1310] = 3; // SV -  Surefooted
	SVHunter[1810] = 2; // SV - Survival Instincts
	SVHunter[1321] = 3; // SV - Killer Instinct
	SVHunter[1303] = 5; // SV - Lightning Reflexes  
	SVHunter[1811] = 3; // SV - Thrill of the Hunt
	SVHunter[1818] = 3; // SV - Expose Weakness
	SVHunter[1813] = 5; // SV - Master Tactician
	return SVHunter;
}

map<TalentEntry const*, uint8> TalentFactory::GetFromMap(map<uint32, uint8> data) {
	map<TalentEntry const*, uint8> talents;
	for (map<uint32, uint8>::iterator itr = data.begin(); itr != data.end(); ++itr) {
		talents[sTalentStore.LookupEntry(itr->first)] = itr->second;
	}
	return talents;
}

map<TalentEntry const*, uint8> TalentFactory::Get(uint8 cls, uint8 role) {
	return GetFromMap(TalentTemplate[cls][role]);
}