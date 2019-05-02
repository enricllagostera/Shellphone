# shellphone

> Let the corals grow and feed them with energy and patience.

![An early sketch of the shellphone project](https://github.com/enricllagostera/shellphone/blob/master/shellphone-social.png?raw=true)

This is a toy (game?) about letting things take their time. It runs on an Android phone and uses its sensors to focus interactions towards slow processes and question common attention relationships between the phone and player. You can read a detailed [discussion here](https://github.com/enricllagostera/shellphone/wiki/Discussion) of the design ideas behind shellphone, with references and documentation of its creation process.

By publishing shellphone's source code and documentation, my goal is that people interested in creating similar games or toys can access an example, a starting point. It was difficult to find open tools or samples of projects using sensors in an approachable way, so by making this public I might help save some of this effort in the future. The shellphone project contains a few different samples on how to use Android phone sensors (via the amazing [Android Sensors for Unity](https://github.com/mmeiburg/unityAndroidSensors) library) in a game, as well as a few ideas on how to map them into specific interactions.

## Getting started

The shellphone project was made using the Unity (version 2018.3.12+) game engine, with the Android platform module installed. This repository contains the full Unity project, including both the [Android Sensors for Unity](https://github.com/mmeiburg/unityAndroidSensors) code and assets as well as shellphone specific materials.

To install, you can download this repository, extract it to your computer and open the folder in Unity. There you can access all scenes and code.

## Video tutorial

Soon.

## Features

* Watch corals grow and change depending on their environment.
* Use environmental sensors to suggest slower interaction.
* Create curve-based vibration feedback in (almost all) Android phones.
* Project documentation both on the wiki and in the `Docs` folder in the download files.

## Contributing

If you have ideas for features or bugs you encountered while using the shellphone project, please [open an issue](https://github.com/enricllagostera/shellphone/issues). If you'd like to contribute with code or features yourself, please fork the repository and use a feature branch. Pull requests are warmly welcome.

## Links

* Documentation is available both at the [wiki](https://github.com/enricllagostera/shellphone/wiki) and on the `Docs` folder.
* To access the Android phone sensors beyond accelerometers and touchscreen, I have used the [Android Sensors for Unity](https://github.com/mmeiburg/unityAndroidSensors) library.
* To facilitate the creation of custom inspectors and some test tools, I'm using the [NaughtyAttributes](https://github.com/dbrizov/NaughtyAttributes) library.
* Vibration control library (you can find it on the [`VibeUtils` folder](Assets/Shellphone/VibeUtils)) is [based on this code](https://gist.github.com/aVolpe/707c8cf46b1bb8dfb363).

## Licensing

This project is licensed under the terms of the LGPL-3.0 (GNU Lesser General Public License v3.0). For more info, please check the license file included.
