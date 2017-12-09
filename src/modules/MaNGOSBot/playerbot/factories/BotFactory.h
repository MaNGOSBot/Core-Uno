#pragma once 
#include "../strategy/actions/InventoryAction.h"

class Player;
class PlayerbotMgr;
class ChatHandler;

using namespace std;
using ai::InventoryAction;

template<typename T>
typename T::iterator& get_random(T & list)
{
	return std::advance(list.begin(), urand(0, list.size() - 1));
}


class BotFactory : public InventoryAction {
private:
	Player* player;
	uint32 level;
	uint32 itemQuality;
	uint8 role;
	uint8 difficulty;

private:
	void Stats();
	void Bags();
	void Mounts();
	void Consumables();
	void Ammo();
	void Talents();
	void Spells();
	
public:
	BotFactory(Player* p, uint32 l, uint32 iq = 0) : InventoryAction(player->GetPlayerbotAI(), "factory") {
		player = p;
		level = l;
		itemQuality = iq;

		list<uint8> roles = TalentFactory::instance().ClassRoles[player->getClass()];
	
		role = ROLE_DPS;
		sLog.outDetail("Setup new bot (%s): Class: %s Role: %s", player->GetName(), player->getClass(), role);
	}
};