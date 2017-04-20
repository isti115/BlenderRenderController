# Blender Render Controller

Original post by me on Blender StackExchange: http://blender.stackexchange.com/a/44906/20611

## Thanks to

* [MeTwentyFive](https://github.com/MeTwentyFive/BlenderRenderController) for the initial update.
* [RedRaptor93](https://github.com/RedRaptor93/BlenderRenderController/) for adding features and writing the first version of this README.
* [jendabek](https://github.com/jendabek/BlenderRenderController) for the separate development. His changes are not merged into the release, so make sure to check them out as well at his repository!

# Below is the README written by RedRaptor93 and modified by me (Isti115) for `Release v0.4`

## What is this?
Blender Render Controller is a tool to help speed up the render process in Blender's Video Sequence Editor(VSE).

VSE is pretty good for editing videos, it's precise and relatively easy to learn, making it a compelling choice next to other free video editing tools. There are some downsides too, main of which been that the renderer is SINGLE THREADED. Meaning that it won't take full advantage of all logical cores in your system, so rendering your finished project is SUPER SLOW compared to other video editors.

This tool offers a work-around until the Blender developers make a better renderer for VSE, 

This tool offers a work-around by calling multiple instances of `blender.exe`, each rendering a different segment of the project at the same time, making use of processing power that would otherwise go unused. After all parts are rendered, join them together and BAM, your video is ready much faster then previously possible.

## How much difference does it make?
Quite a lot! I did some testing shown below (Blender Render Controller shown in orange):

![Test3](https://app.box.com/representation/file_version_147671500287/image_2048/1.png?shared_name=u90snyjbzslz0zszwges1helzmyz6b8y)

![Test1](https://app.box.com/representation/file_version_147672318497/image_2048/1.png?shared_name=i1bwfn03tie6ieehwnz7mbp4lu700gzy)

PC used: i7 4790, 16GB DDR3 RAM @ 1600Mhz

Really shows the importance of those extra cores huh? Even if you don't use Blender VSE often, that’s a LOT of time saved. And the time added by joining the videos together is negligible (less then 1min).

## HOW TO USE

### Dependencies
- Blender, obviously
- FFmpeg, required for joining the parts together.

1. Save your .blend file with the settings you want (output path, resolution, etc)

	- Make sure the "output path" is an ABSOLUTE path and not relative, you can change the default kind of path in Blender's user settings, BRC WON'T work w/ relative paths
	
2. Open BlenderRenderController, browse for the desired blend file

	- Alternatively, you can drop the .blend file onto the window or specify it as a command line argument:  
	`> BlenderRenderController.exe "myProjectFile.blend"`
	
3. Select the chunk of the segment you want to render and press "render segment" to render a single segment or select "render all" to render the project in segments.

	- The length of each segment is controlled by the difference between the "Start Frame" and "End frame" values.  
	[Only in RedRaptor's version: The default length when you open or re-read a file can be adjusted ("segment length" in Options => Settings)]
	
4. When all the parts are done, click "Concatenate parts" to join all parts together

	- If you get a "Can't find working folder error", try "remove file from path" option below, "parts folder" must point to a FOLDER, not a FILE.
	
5. If you find that the sound glitches at the concatenation points you should export the audio separately and then merge it with the video file afterwards with the labeled buttons in section __3. Audio__ of the program.

6. That's it! Hopefully you found this useful!  
If so, don't forget to star the repository and upvote the [StackExchange answer] (http://blender.stackexchange.com/a/44906/20611) so more people can find it! :)
---
### Cross-platform alternative
Mikeycal Meyers wrote his own python script as a cross-platform solution for the problem.  
You can find his explanation about it here:   
https://youtu.be/rgwP5L1bICk  
and the actual project here:  
https://github.com/mikeycal/the-video-editors-render-script-for-blender  
Make sure to check his work out as well, and help him improve it if you know some python! ;)
