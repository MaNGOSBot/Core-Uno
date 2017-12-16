#pragma once 

#include "../structures/Talent.h"

using namespace std;

class TalentFactory {
public:
	map<uint8, map<uint8, list<TalentSet>>> TalentCache;
	map<uint8, list<uint8>> ClassRoles;

	TalentSet* GetRandomTalentSet(uint8 cls, uint8 role);

	TalentFactory();

	static TalentFactory& instance() {
		static TalentFactory instance;
		return instance;
	};
};

#define sTalentFactory = MaNGOS::Singleton<TalentFactory>::Instance()