#pragma once 
#include "../strategy/actions/InventoryAction.h"

class Player;
class PlayerbotMgr;
class ChatHandler;

using namespace std;
using ai::InventoryAction;

class BotFactory : public InventoryAction {
private:
	Roles Role;

private:
	// Initialization Functions 
	void Bags();
	void Mounts();
	void Consumables();


	void Talents();
	void Spells();
	
	


public:

};