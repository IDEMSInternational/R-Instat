### Before asking for review
Please confirm that you have:

- Completed the developer testing checklist below (ticking items as you go)
- Responded to all AI/bot comments (either fixed or explained)
- Added a short note in the PR describing how you tested these changes
- Noted which issue(s) this PR relates to

**Developer Testing Checklist**
- [ ] Runs without errors  
- [ ] OK disabled when dialog is incomplete or invalid  
- [ ] OK enabled only when required inputs are valid
- [ ] Reset returns dialog to its default/sensible state
- [ ] Invalid inputs are handled cleanly (e.g. negative, too-large, empty, impossible combos)
- [ ] Running twice with different settings behaves consistently (e.g., open → run → close → reopen → change options checked → run again)
- [ ] All AI/bot comments addressed (fixed, intentionally ignored with explanation, or queried)
