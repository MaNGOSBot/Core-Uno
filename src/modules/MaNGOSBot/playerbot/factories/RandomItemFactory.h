#pragma once 

class RandomItemFactory {
public:
	RandomItemFactory();

	
	ItemEntry FindItem(uint8 slot);
	void Outfit(Player* bot);


	// -- Static Implementation 
	static RandomItemFactory& instance() {
		static RandomItemFactory instance;
		return instance;
	}
};

#define sRandomItemFactory = RandomItemFactory::instance()