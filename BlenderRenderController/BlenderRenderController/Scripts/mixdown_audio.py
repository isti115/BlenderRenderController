import os
import json
import bpy
from bpy import context
from bpy import ops

blendPath = bpy.context.blend_data.filepath;
projName  = bpy.path.display_name_from_filepath( blendPath );

# get active scene name
a_data = bpy.context.scene
ActiveScene = str(a_data).partition('("')[-1].rpartition('")')[0]

outputPath = bpy.data.scenes[ActiveScene].render.filepath

#outputPath = bpy.data.scenes["Scene"].render.filepath

bpy.ops.sound.mixdown( filepath=outputPath + "\\audio.mp3",
		               container='MP3',
					   codec='MP3',
					   accuracy=1024,
					   bitrate=256,
					   format="F32",
					   split_channels=False);

