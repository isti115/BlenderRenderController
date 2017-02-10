# Readme as written by RedRaptor93

# What is this?
This branch has some modifications I've done to make Isti115's program more useful and remove some annoying limitations that conflicted with my work-flow. I think it all made the program much more stable and useful, so I'm share it ;). I plan to make gradual improvements as I'm learning and this is my first programing project

##HOW TO USE
coming soon... someday, maybe...

##CHANGES

####03/02/17

- Upload to GitHub
- blend.json is deleted when program closes
- CMD arguments! Running the following in a CMD window will automatically set to specified file: 
```
BlenderRenderController.exe “filepath to .blend”
```
- added error message if blendFilePath does not exist

####02/02/17

- Added detailed error messages

- Render and join buttons are disabled if an error is detected

- Added icon

####29/01/17

- the program now reads project's info from blend file's ACTIVE SCENE, and shows the name and number of total scenes

- fixed some unhanded exceptions evolving output file paths

- different bars for blend output and ffmpeg join

  - External programs cannot easily change the output file name or location of the render, so there is now a separated bar showing the       output location where blender will render and a tooltip informing to change the location in Blender.
  
- [get_project_info.py] now saves the json file in the scripts folder, this is necessary to avoid exceptions if output path in blend       file is NOT valid.

- Added tooltips, a strip menu w/ some options, plus general adjustments to UI to accommodate new features

##TO DO

Note that I'm still a learner, I don't know how to do most of these things, so don't expect them anytime soon, of course if anyone is willing to help, I'm all ears.

- Automatically calculate segment’s end frame

- Add an INI file to save settings
	- Project history
	- Set own default values for process count, frame step*
	- ability to point to blender.exe and Ffmpeg.exe, eliminating the need to set PATH (?)

- Make a more precise timer

- How to use section

- *Change how segments are calculated, on top of a “start” and “end” frame, a frame step value - would control the segments length (end_frame = start_frame + frame_step)

- ~~find and delete json file on start up or closure~~

- Integrate w/ Blender via plugin

- ~~call Render Controller and pass project’s info automatically (command line args)~~

- Support for more file formats
