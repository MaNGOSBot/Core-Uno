#include "botpch.h"
#include "../../playerbot.h"
#include "WarriorMultipliers.h"
#include "FuryWarriorStrategy.h"

using namespace ai;                           

class FuryWarriorStrategyActionNodeFactory : public NamedObjectFactory<ActionNode>
{
public:
	FuryWarriorStrategyActionNodeFactory()
	{
		creators["reach melee"] = &reach_melee;
		creators["charge"] = &charge;
		creators["intercept"] = &intercept;
		creators["melee"] = &melee;
		creators["bloodthirst"] = &bloodthirst;
		creators["whirlwind"] = &whirlwind;
		creators["death wish"] = &death_wish;
		creators["execute"] = &execute;
	}
private:
	static ActionNode* reach_melee(PlayerbotAI* ai)
	{
		return new ActionNode("reach melee",
			/*P*/ NULL,
			/*A*/ NextAction::array(0, new NextAction("charge"), NULL),
			/*C*/ NULL);
	}
	static ActionNode* charge(PlayerbotAI* ai)
	{
		return new ActionNode("charge",
			/*P*/ NextAction::array(0, new NextAction("battle stance"), NULL),
			/*A*/ NextAction::array(0, new NextAction("intercept"), NULL),
			/*C*/ NULL);
	}
	static ActionNode* intercept(PlayerbotAI* ai)
	{
		return new ActionNode("intercept",
			/*P*/ NextAction::array(0, new NextAction("berserker stance"), NULL),
			/*A*/ NULL,
			/*C*/ NULL);
	}
	static ActionNode* melee(PlayerbotAI* ai)
	{
		return new ActionNode("melee",
			/*P*/ NextAction::array(0, new NextAction("reach melee"), NULL),
			/*A*/ NULL,
			/*C*/ NULL);
	}
	static ActionNode* bloodthirst(PlayerbotAI* ai)
	{
		return new ActionNode("bloodthirst",
			/*P*/ NextAction::array(0, new NextAction("berserker stance"), NULL),
			/*A*/ NextAction::array(0, new NextAction("melee"), NULL),
			/*C*/ NULL);
	}
	static ActionNode* whirlwind(PlayerbotAI* ai)
	{
		return new ActionNode("whirlwind",
			/*P*/ NextAction::array(0, new NextAction("berserker stance"), NULL),
			/*A*/ NextAction::array(0, new NextAction("melee"), NULL),
			/*C*/ NULL);
	}
	static ActionNode* death_wish(PlayerbotAI* ai)
	{
		return new ActionNode("death wish",
			/*P*/ NULL,
			/*A*/ NextAction::array(0, new NextAction("berserker rage"), NULL),
			/*C*/ NULL);
	}
	static ActionNode* execute(PlayerbotAI* ai)
	{
		return new ActionNode("execute",
			/*P*/ NextAction::array(0, new NextAction("berserker stance"), NULL),
			/*A*/ NextAction::array(0, new NextAction("melee"), NULL),
			/*C*/ NULL);
	}
};

FuryWarriorStrategy::FuryWarriorStrategy(PlayerbotAI* ai) : GenericWarriorStrategy(ai)
{
	actionNodeFactories.Add(new FuryWarriorStrategyActionNodeFactory());
}

NextAction** FuryWarriorStrategy::getDefaultActions()
{
	return NextAction::array(0, new NextAction("bloodthirst", ACTION_NORMAL + 8), NULL);
}

void FuryWarriorStrategy::InitTriggers(std::list<TriggerNode*> &triggers)
{
	GenericWarriorStrategy::InitTriggers(triggers);
	triggers.push_back(new TriggerNode("pummel", NextAction::array(0, new NextAction("pummel", ACTION_INTERRUPT), NULL)));
	triggers.push_back(new TriggerNode("target critical health", NextAction::array(0, new NextAction("execute", ACTION_NORMAL + 9), NULL)));
	triggers.push_back(new TriggerNode("bloodthirst", NextAction::array(0, new NextAction("bloodthirst", ACTION_NORMAL + 8), NULL)));
	triggers.push_back(new TriggerNode("whirlwind", NextAction::array(0, new NextAction("whirlwind", ACTION_NORMAL + 7), NULL)));
	
    triggers.push_back(new TriggerNode("death wish",NextAction::array(0, new NextAction("death wish", ACTION_NORMAL + 2), NULL)));
	triggers.push_back(new TriggerNode("enemy out of melee", NextAction::array(0, new NextAction("reach melee", ACTION_NORMAL + 1), NULL)));  
}


void FuryWarriorAoeStrategy::InitTriggers(std::list<TriggerNode*> &triggers)
{
	triggers.push_back(new TriggerNode("medium aoe", NextAction::array(0, new NextAction("whirlwind", ACTION_NORMAL + 3), NULL)));
	triggers.push_back(new TriggerNode("medium aoe", NextAction::array(0, new NextAction("cleave", ACTION_NORMAL + 2), NULL)));
	triggers.push_back(new TriggerNode("medium aoe", NextAction::array(0, new NextAction("demoralizing shout", ACTION_NORMAL + 1), NULL)));

	triggers.push_back(new TriggerNode("light aoe",NextAction::array(0, new NextAction("cleave", ACTION_NORMAL + 2), NULL)));
	triggers.push_back(new TriggerNode("light aoe", NextAction::array(0, new NextAction("thunder clap", ACTION_NORMAL + 1), NULL)));
}
