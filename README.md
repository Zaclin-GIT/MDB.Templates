# MDB.Templates

`dotnet new` project templates for [MDB Framework](https://github.com/Zaclin-GIT/MDB) — a Unity IL2CPP modding framework.

## Installation

### One-liner (recommended)
```bash
dotnet new install https://github.com/Zaclin-GIT/MDB.Templates/releases/latest/download/MDB.Templates.1.0.0.nupkg
```

### From local clone
```bash
git clone https://github.com/Zaclin-GIT/MDB.Templates.git
dotnet new install ./MDB.Templates
```

## Templates

| Template | Short Name | Description |
|----------|-----------|-------------|
| MDB Mod  | `mdbmod`  | A mod project for MDB Framework |

## Usage

### Create a new mod

```bash
dotnet new mdbmod -n MyAwesomeMod --GamePath "C:\Path\To\Game"
```

### All options

```
dotnet new mdbmod --help
```

| Option | Description | Default |
|--------|-------------|---------|
| `-n`, `--name` | Project/mod name | `MyMod` |
| `--ModAuthor` | Your mod author name | `ModAuthor` |
| `--ModDescription` | Short description of your mod | `An MDB Framework mod` |
| `--GamePath` | Absolute path to the game folder | *(must be set)* |
| `--imgui` | Include ImGui UI boilerplate | `true` |

### Examples

**Basic mod with ImGui window:**
```bash
dotnet new mdbmod -n HealthDisplay --ModAuthor "MyName" --GamePath "C:\Games\MyGame"
```

**Headless mod (no ImGui):**
```bash
dotnet new mdbmod -n AutoFarm --ModAuthor "MyName" --GamePath "C:\Games\MyGame" --imgui false
```

### After creating

1. **Build your mod:**
   ```bash
   cd MyAwesomeMod
   dotnet build -c Release
   ```

2. **Deploy to game:**
   Copy `bin\Release\MyAwesomeMod.dll` into `<GameFolder>\MDB\Mods\`

   > **Tip:** Uncomment the `CopyToMods` target in the `.csproj` to auto-deploy on build.

3. **Inject MDB_Bridge.dll** into the game and your mod will be loaded automatically.

## Prerequisites

- [MDB Framework](https://github.com/Zaclin-GIT/MDB) injected into the game at least once (to generate the SDK)
- .NET Framework 4.8.1 targeting pack (installed with Visual Studio)
- .NET SDK 8.0+

## Uninstall

```bash
dotnet new uninstall MDB.Templates
```

## Publishing

Publishing happens automatically via GitHub Actions when you create a release.

1. **Tag & release:** Create a GitHub release with a tag like `v1.0.0`
2. The workflow will pack and attach the `.nupkg` to the release automatically

### Manual publish
```bash
dotnet pack -c Release
```
Then upload `bin\Release\MDB.Templates.<version>.nupkg` to your GitHub release.

## License

MIT
