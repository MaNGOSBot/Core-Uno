#pragma once 

using namespace std;

class TalentFactory {
public:
	map<uint8, map<uint8, map<uint32, uint8>>> TalentTemplate;

	map<uint32, uint8> WarriorTank();
	map<uint32, uint8> DruidHealer();
	map<TalentEntry const*, uint8> GetFromMap(map<uint32, uint8> data);
	map<TalentEntry const*, uint8> Get(uint8 cls, uint8 role);

	TalentFactory();

	static TalentFactory& instance() {
		static TalentFactory instance;
		return instance;
	};
};
