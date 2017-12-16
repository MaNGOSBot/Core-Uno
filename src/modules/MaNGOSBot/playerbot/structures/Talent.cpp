#include "Talent.h"

TalentEntry const* Talent::GetEntry() {
	return sTalentStore.LookupEntry(Spell);
}