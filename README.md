# Aura Farmer

Dalamud plugin workspace for `Aura Farmer`.

## Current Status

Bootstrap scaffold created on 2026-03-25. This repo now has a buildable `Debug x64` shell with command routing, Ko-fi placement, DTR support, icon assets, and repo-ready documentation.

- Solution: `Z:\AuraFarmer\AuraFarmer.sln`
- Project: `Z:\AuraFarmer\AuraFarmer\AuraFarmer.csproj`
- Command: `/aurafarmer`
- Repository target: `Public`

## Plugin Concept

- Reuse localhost coordination patterns.
- Keep commendation and Astrope modes separate.
- Expose targets and queue policy early.

## Planned Services

- ConfigManager
- ILocalPeerTransport
- NamedPipePeerTransport
- PresenceService
- ReadinessService
- QueueAuthorityService
- CommendationModeService
- AstropeModeService

## Documents

- Project plan: `Z:\xa-xiv-docs\Dhog\AuraFarmer\AURAFARMER_PROJECT_PLAN.md`
- Knowledge base: `Z:\xa-xiv-docs\Dhog\AuraFarmer\AURAFARMER_KNOWLEDGE_BASE.md`
- Import guide: `how to import plugins.md`
- Changelog: `CHANGELOG.md`

## Notes

- Icon assets live in `images\iconHQ.png` and `images\icon.png`.
- SamplePlugin references used for the initial shell: https://github.com/goatcorp/SamplePlugin and https://github.com/goatcorp/SamplePlugin/blob/master/README.md
