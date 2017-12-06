#pragma once 

using namespace std;

class TalentFactory {
public:
	map<uint8, map<uint8, map<uint32, uint8>>> TalentTemplate;
	map<uint8, list<uint8>> ClassRoles;

	map<uint32, uint8> WarriorTank();
	map<uint32, uint8> DruidTank();
	map<uint32, uint8> DruidHealer();
	map<uint32, uint8> DruidDps_B();
	map<uint32, uint8> DruidDps_F();
	map<uint32, uint8> PaladinTank();
	map<uint32, uint8> PaladinHealer();
	map<uint32, uint8> PaladinDps();
	map<uint32, uint8> ShamanHealer();
	map<uint32, uint8> ShamanDps();
	map<uint32, uint8> ShamanDps_Enhanc();
	map<uint32, uint8> RogueDPS();
	map<uint32, uint8> RogueDPS_A();
	map<uint32, uint8> HunterDPS_BM();
	map<uint32, uint8> HunterDPS_MM();
	map<uint32, uint8> HunterDPS_SV();

	map<TalentEntry const*, uint8> GetFromMap(map<uint32, uint8> data);
	map<TalentEntry const*, uint8> Get(uint8 cls, uint8 role);

	TalentFactory();

	static TalentFactory& instance() {
		static TalentFactory instance;
		return instance;
	};
};
