# Debug Tools

The Debug Tools package contains assets and scripts for debugging Unity projects. Included in the package are scripts for enhanced console logging, benchmarking, displaying framerate, and more. The package also comes with shaders to visualize different vertex data.

## Installation

Use the Unity [Package Manager](https://docs.unity3d.com/Manual/upm-ui.html) to install the Debug Tools package.

1. Open the Package Manager in `Window > Package Manager`
2. Click the add (`+`) button in the status bar
3. Select `Add package from git URL` from the add menu
4. Enter the following Git URL in the text box and click Add:

```http
https://github.com/zigurous/unity-debug-tools.git
```

For more information on the Package Manager and installing packages, see the following pages:

- [Unity's Package Manager](https://docs.unity3d.com/Manual/Packages.html)
- [Installing from a Git URL](https://docs.unity3d.com/Manual/upm-ui-giturl.html)

### Importing

Import the package namespace in each script or file you want to use it.

> **Note**: You may need to regenerate project files/assemblies first.

```csharp
using Zigurous.Debug;
```

## Reference

- [Logging](https://docs.zigurous.com/com.zigurous.debug/manual/logging.html)
- [Benchmarking](https://docs.zigurous.com/com.zigurous.debug/manual/benchmarking.html)
- [Framerate Display](https://docs.zigurous.com/com.zigurous.debug/manual/framerate.html)
- [Debug Shaders](https://docs.zigurous.com/com.zigurous.debug/manual/shaders.html)
