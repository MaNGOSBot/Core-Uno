#pragma once 

using namespace std;

struct Talent {
	string Spec;
	uint8 Cls;
	uint8 Role;
	uint32 Spell;
	uint8 Rank;

	TalentEntry const* GetEntry();
};

struct TalentSet {
	string Name;
	uint8 Role;
	list<Talent> Talents;
};