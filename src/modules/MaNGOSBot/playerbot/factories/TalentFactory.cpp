#include "TalentFactory.h"

TalentFactory::TalentFactory() {
	TalentTemplate[CLASS_WARRIOR] = { make_pair(ROLE_TANK, WarriorTank()) };
	TalentTemplate[CLASS_DRUID] = { make_pair(ROLE_HEALER, DruidHealer()) };
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