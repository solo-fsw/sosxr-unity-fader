# Changelog

All notable changes to this project will be documented in this file.
The changelog format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)


## [2.0.0] - 2025-02-03
### Changed
- Changed from GNU GPL 3 license to MIT license


## [1.0.2] - 2024-12-13
### Changed

- Enhanced audio fader with fade in / out / to
- Added Curve for fade


## [1.0.1] - 2024-09-26
### Fixed
- Namespaces
- package.json file


## [1.0.0] - 2024-09-17
### Added
- Created the ImageFader prefab

### Fixed
- AudioFader is now able to work both as a Bulk fader (by searching the scene for AudioSources), or as a single fader (by setting the AudioSource in the inspector)

### Changed
- Changed the Image fader to not be dependent on DOTween

### Removed
- DOTween dependency
