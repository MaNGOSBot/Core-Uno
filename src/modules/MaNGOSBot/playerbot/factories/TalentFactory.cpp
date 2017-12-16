#include "TalentFactory.h"

INSTANTIATE_SINGLETON_1(TalentFactory)

TalentFactory::TalentFactory() {
	// Set up available roles for class 
	ClassRoles[CLASS_WARRIOR] = { ROLE_TANK, ROLE_DPS };
	ClassRoles[CLASS_DRUID] = { ROLE_HEALER, ROLE_TANK, ROLE_DPS };
	ClassRoles[CLASS_SHAMAN] = { ROLE_DPS, ROLE_HEALER };
	ClassRoles[CLASS_PALADIN] = { ROLE_DPS, ROLE_HEALER, ROLE_TANK };
	ClassRoles[CLASS_HUNTER] = { ROLE_DPS };
	ClassRoles[CLASS_ROGUE] = { ROLE_DPS };
	ClassRoles[CLASS_MAGE] = { ROLE_DPS };
	ClassRoles[CLASS_WARLOCK] = { ROLE_DPS };
	ClassRoles[CLASS_PRIEST] = { ROLE_DPS, ROLE_HEALER };

	// Load from Database 

	list<Talent> rows;
	QueryResult* results = CharacterDatabase.Query("SELECT spec, class, role, spell, points from ai_playerbot_talents;");
	if (results) {
		do {
			Field* fields = results->Fetch();
			Talent row;
			row.Spec = fields[0].GetCppString();
			row.Cls = fields[1].GetUInt8();
			row.Role = fields[2].GetUInt8();
			row.Spell = fields[3].GetUInt32();
			row.Rank = fields[4].GetUInt8();
			rows.push_back(row);
		} while (results->NextRow());
		delete results;
	}
	
	map<uint8, map<string, TalentSet>> cache;
	// Categorize properly
	for (list<Talent>::iterator itr = rows.begin(); itr != rows.end(); ++itr) {
		cache[itr->Cls][itr->Spec].Name = itr->Spec;
		cache[itr->Cls][itr->Spec].Role = itr->Role;
		cache[itr->Cls][itr->Spec].Talents.push_back(*itr);
	}
		
	// Push TalentSets into class/roles
	for (map<uint8, map<string, TalentSet>>::iterator itr = cache.begin(); itr != cache.end(); ++itr) {
		for (map<string, TalentSet>::iterator itr2 = itr->second.begin(); itr2 != itr->second.end(); ++itr2) {
			TalentCache[itr->first][itr2->second.Role].push_back(itr2->second);
		}
	}
}

TalentSet* TalentFactory::GetRandomTalentSet(uint8 cls, uint8 role) {
	list<TalentSet> specs = TalentCache[cls][role];
	int max = specs.size();
	if (max < 1)
		return NULL;

	int index = rand() % (max - 0 + 1) + 0;
	list<TalentSet>::iterator itr = specs.begin();
	advance(itr, index);
	//sLog.outDetail("Found spec for Class: %s Role: %s at index %s", cls, role, index);
	return &*itr;
}